using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;

namespace TORServices.Maths.Chem.MolecularMass
{
    public class TokenMolecularMass
    {
        public EnumTokenMolecularMassType TokenType { get; set; }
        public string Value { get; set; }
        public int Lenght { get; set; }
    }
    public enum EnumTokenMolecularMassType { Operator, Element, Number, Error }
    public class Element { public string Symbol; public string ElementName; public double AtomicWeight; public int AtomicNumber; public int Atoms; }
    public class Molecular { public string Formulas; }

    public class molecularMass
    {
        /*
         Na2CO3.10H2O CuSO4.5H2O H2O H2SO4 
         */

        private System.Data.DataTable atomicData;

        private string infix = "";
        public List<Element> element;
        public string Formulas;
        private double _mass = 0;
        public double MolecularMass { get { return _mass; } }

        public molecularMass(string strMolecular)
        {
            atomicData = AtomicData();
            Formulas = strMolecular;
            element = new List<Element>();
            infix = ToInfix(PreInfix(RemoveTail(Regex.Replace(strMolecular.Replace(" ", string.Empty), "[•\\.]|\\)\\(", "+"))));
            SetElement(infix);
            
        }

        private void SetElement(string infix)
        {
            bool chk = false;
            try
            {
                foreach (string elem in infix.Split('+'))
                {
                    double _AtomicMass = atomicData.AsEnumerable().Where(a => a.Field<string>("Symbol") == Regex.Match(elem, "[a-zA-Z]{1,}").Value).Select(a => a.Field<double>("AtomicMass")).First();
                    int _AtomicNumber = atomicData.AsEnumerable().Where(a => a.Field<string>("Symbol") == Regex.Match(elem, "[a-zA-Z]{1,}").Value).Select(a => a.Field<int>("AtomicNumber")).First();
                    string _ElementName = atomicData.AsEnumerable().Where(a => a.Field<string>("Symbol") == Regex.Match(elem, "[a-zA-Z]{1,}").Value).Select(a => a.Field<string>("ElementName")).First();
                    string _Symbol = Regex.Match(elem, "[a-zA-Z]{1,}").Value;
                    int _Atoms = int.Parse(Regex.Match(elem, "[0-9]{1,}").Value);
                    _mass += (_Atoms * _AtomicMass);
                    foreach (Element _elem in element)
                    {
                        if (_elem.Symbol == Regex.Match(elem, "[a-zA-Z]{1,}").Value)
                        {
                            _elem.Atoms += _Atoms;

                            chk = true;
                            break;
                        }

                    }
                    if (chk == false)
                    {
                        element.Add(new Element() { Symbol = _Symbol, ElementName = _ElementName, AtomicNumber = _AtomicNumber, AtomicWeight = _AtomicMass, Atoms = _Atoms });
                    }


                }
            }
            catch { }
        }
        private string ToInfix(string str)
        {
            if (Regex.Match(str, "[^\\*]\\([a-zA-Z0-9\\+]*\\)").Success)
            {
                Match m = Regex.Match(str, "\\([a-zA-Z0-9\\+]*\\)");

                str = str.Replace(m.Value, m.Value.Substring(1, m.Value.Length - 2));
            }

            string result = str;

            foreach (Match match in Regex.Matches(str, "[0-9]{1,}\\*\\([a-zA-Z0-9\\+]*\\)|\\([a-zA-Z0-9\\+]*\\)\\*[0-9]{1,}"))
            {
                result = result.Replace(match.Value, this.DoMultiply(match.Value));
            }
            return (result.Contains("(") && result.Contains(")")) ? this.ToInfix(result) : result;
        }


        private string RemoveTail(string str)
        {
            string result = string.Empty;

            if (str.StartsWith("(") && str.EndsWith(")"))
                result = str.Substring(1, str.Length - 2);
            else
                result = str;
            return (result.StartsWith("(") && result.EndsWith(")")) ? this.RemoveTail(result) : result;
        }

        private string DoMultiply(string str)
        {
            int multiply = int.Parse(Regex.Match(str, "^[0-9]{1,}").Value.Replace("*", string.Empty));
            string elements = Regex.Match(str, "\\([a-zA-Z0-9\\+]{1,}\\)").Value.Trim(("()").ToCharArray());

            List<TokenMolecularMass> tokens = new List<TokenMolecularMass>();

            while (elements.Length > 0)
            {
                TokenMolecularMass token = this.GetToken(elements);
                tokens.Add(token);
                elements = elements.Substring(token.Lenght);
            }

            foreach (TokenMolecularMass token in tokens)
            {
                if (token.TokenType == EnumTokenMolecularMassType.Number)
                {
                    int newValue = int.Parse(token.Value) * multiply;
                    token.Value = newValue.ToString();
                }
            }

            return this.TokenToString(tokens);
        }

        private List<TokenMolecularMass> AddOne(List<TokenMolecularMass> tokens)
        {
            List<TokenMolecularMass> result = new List<TokenMolecularMass>();
            TokenMolecularMass Previous = null;

            foreach (TokenMolecularMass token in tokens)
            {
                if (Previous != null)
                {
                    if (Previous.TokenType == EnumTokenMolecularMassType.Element && token.TokenType != EnumTokenMolecularMassType.Number)
                    {
                        result.Add(new TokenMolecularMass() { Value = "1", TokenType = EnumTokenMolecularMassType.Number, Lenght = 1 });
                    }
                }

                result.Add(token);
                Previous = token;
            }

            if (result.Count > 0)
            {
                if (result.Last().TokenType == EnumTokenMolecularMassType.Element)
                {
                    result.Add(new TokenMolecularMass() { Value = "1", TokenType = EnumTokenMolecularMassType.Number, Lenght = 1 });
                }
            }

            return result;
        }

        private string PreInfix(string str)
        {
            List<string> result = new List<string>();

            foreach (string s in str.Split('+'))
            {
                result.Add(this.ConvertToInfix(s));
            }

            return string.Join("+", result.ToArray());
        }

        private string ConvertToInfix(string str)
        {
            List<TokenMolecularMass> tokens = new List<TokenMolecularMass>();

            while (str.Length > 0)
            {
                TokenMolecularMass token = this.GetToken(str);
                tokens.Add(token);
                str = str.Substring(token.Lenght);
            }

            List<TokenMolecularMass> result = new List<TokenMolecularMass>();
            TokenMolecularMass previous = null;

            if (tokens.Count > 0)
            {
                if (tokens.First().TokenType == EnumTokenMolecularMassType.Number)
                {
                    tokens.Insert(1, new TokenMolecularMass() { Value = "(", TokenType = EnumTokenMolecularMassType.Operator, Lenght = 1 });
                    tokens.Add(new TokenMolecularMass() { Value = ")", TokenType = EnumTokenMolecularMassType.Operator, Lenght = 1 });
                }

                foreach (TokenMolecularMass token in tokens)
                {
                    if (result.Count == 0)
                    {
                        result.Add(token);
                        previous = token;
                    }
                    else
                    {
                        switch (previous.TokenType)
                        {
                            case EnumTokenMolecularMassType.Element:
                                switch (token.TokenType)
                                {
                                    case EnumTokenMolecularMassType.Element:
                                        result.Add(new TokenMolecularMass() { Value = "+", TokenType = EnumTokenMolecularMassType.Operator, Lenght = 1 });
                                        result.Add(token);
                                        previous = token;
                                        break;
                                    case EnumTokenMolecularMassType.Number:
                                        result.Add(token);
                                        previous = token;
                                        break;
                                    case EnumTokenMolecularMassType.Operator:
                                        if (token.Value == "(")
                                            result.Add(new TokenMolecularMass() { Value = "+", TokenType = EnumTokenMolecularMassType.Operator, Lenght = 1 });

                                        result.Add(token);
                                        previous = token;
                                        break;
                                }
                                break;
                            case EnumTokenMolecularMassType.Number:
                                switch (token.TokenType)
                                {
                                    case EnumTokenMolecularMassType.Element:
                                        result.Add(new TokenMolecularMass() { Value = "+", TokenType = EnumTokenMolecularMassType.Operator, Lenght = 1 });
                                        result.Add(token);
                                        previous = token;
                                        break;
                                    case EnumTokenMolecularMassType.Number:
                                        break;
                                    case EnumTokenMolecularMassType.Operator:
                                        if (token.Value != ")" && tokens.First().TokenType == EnumTokenMolecularMassType.Number)
                                            result.Add(new TokenMolecularMass() { Value = "*", TokenType = EnumTokenMolecularMassType.Operator, Lenght = 1 });
                                        else if (token.Value != ")")
                                            result.Add(new TokenMolecularMass() { Value = "+", TokenType = EnumTokenMolecularMassType.Operator, Lenght = 1 });

                                        result.Add(token);
                                        previous = token;
                                        break;
                                }
                                break;
                            case EnumTokenMolecularMassType.Operator:
                                switch (token.TokenType)
                                {
                                    case EnumTokenMolecularMassType.Element:
                                        result.Add(token);
                                        previous = token;
                                        break;
                                    case EnumTokenMolecularMassType.Number:
                                        if (token.Value != ")")
                                            result.Add(new TokenMolecularMass() { Value = "*", TokenType = EnumTokenMolecularMassType.Operator, Lenght = 1 });

                                        result.Add(token);
                                        previous = token;
                                        break;
                                    case EnumTokenMolecularMassType.Operator:
                                        break;
                                }
                                break;
                        }
                    }
                }
            }

            return this.Swap(this.TokenToString(this.AddOne(result)));
        }

        private string Swap(string str)
        {
            string result = str;

            foreach (Match match in Regex.Matches(str, "\\([a-zA-Z0-9\\+]*\\)\\*[0-9]{1,}"))
            {
                string[] temp = match.Value.Split('*');

                result = result.Replace(match.Value, temp[1] + "*" + temp[0]);
            }

            foreach (Match match in Regex.Matches(result, "[a-zA-Z]{1,}[0-9]{1,}"))
            {
                string element = Regex.Match(match.Value, "[a-zA-Z]{1,}").Value;
                string amount = Regex.Match(match.Value, "[0-9]{1,}").Value;

                result = result.Replace(match.Value, amount + element);
            }

            return result;
        }

        private bool IsValid(string str)
        {
            List<TokenMolecularMass> tokens = new List<TokenMolecularMass>();

            int b1 = str.ToCharArray().Where(c => c == '(').Count();
            int b2 = str.ToCharArray().Where(c => c == ')').Count();

            while (str.Length > 0)
            {
                TokenMolecularMass token = this.GetToken(str);
                tokens.Add(token);
                str = str.Substring(token.Lenght);
            }

            TokenMolecularMass errorToken = tokens.Where(t => t.TokenType == EnumTokenMolecularMassType.Error).FirstOrDefault();

            /*  if (errorToken != null)
                  this.textBoxResult.Text = errorToken.Value;

              if (b1 != b2)
                  this.textBoxResult.Text = "Error: syntax error";*/

            return (errorToken == null && b1 == b2) ? true : false;
        }

        private TokenMolecularMass GetToken(string str)
        {
            TokenMolecularMass token = new TokenMolecularMass();
            string first = str.Substring(0, 1);

            switch (this.TokenType(first))
            {
                case EnumTokenMolecularMassType.Element:
                    Match match1 = Regex.Match(str, "^[A-Z][a-z]*");

                    if (this.IsElement(match1.Value))
                    {
                        token.Value = match1.Value;
                        token.TokenType = EnumTokenMolecularMassType.Element;
                        token.Lenght = match1.Value.Length;
                    }
                    else
                    {
                        token.Value = string.Format("Error: unknown '{0}'", match1.Value);
                        token.TokenType = EnumTokenMolecularMassType.Error;
                        token.Lenght = match1.Value.Length;
                    }
                    break;
                case EnumTokenMolecularMassType.Number:
                    Match match2 = Regex.Match(str, "^[0-9]*");

                    token.Value = match2.Value;
                    token.TokenType = EnumTokenMolecularMassType.Number;
                    token.Lenght = match2.Value.Length;
                    break;
                case EnumTokenMolecularMassType.Operator:
                    token.Value = first;
                    token.TokenType = EnumTokenMolecularMassType.Operator;
                    token.Lenght = 1;
                    break;
                default:
                    token.Value = string.Format("Error: unknown '{0}'", first);
                    token.TokenType = EnumTokenMolecularMassType.Error;
                    token.Lenght = 1;
                    break;
            }

            return token;
        }

        private bool IsElement(string element)
        {
            return atomicData.AsEnumerable().Where(a => a.Field<string>("Symbol") == element).Count() > 0 ? true : false;
        }
        private EnumTokenMolecularMassType TokenType(string str)
        {
            EnumTokenMolecularMassType result;

            if ((new string[] { "+", "(", ")" }).Contains(str))
            {
                result = EnumTokenMolecularMassType.Operator;
            }
            else if ((new Regex("[0-9]")).Match(str).Success)
            {
                result = EnumTokenMolecularMassType.Number;
            }
            else if ((new Regex("[A-Z]")).Match(str).Success)
            {
                result = EnumTokenMolecularMassType.Element;
            }
            else
            {
                result = EnumTokenMolecularMassType.Error;
            }

            return result;
        }

        private string TokenToString(List<TokenMolecularMass> tokens)
        {
            string result = string.Empty;

            foreach (TokenMolecularMass token in tokens)
            {
                result += token.Value;
            }

            return result;
        }

        private System.Data.DataTable AtomicData()
        {
            object[][] data = new object[][]
            { 
                new object[] { "H", "Hydrogen", 1.0079, 1 },
                new object[] { "He", "Helium", 4.0026, 2 },
                new object[] { "Li", "Lithium", 6.941, 3 },
                new object[] { "Be", "Beryllium", 9.0122, 4 },
                new object[] { "B", "Boron", 10.811, 5 },
                new object[] { "C", "Carbon", 12.0107, 6 },
                new object[] { "N", "Nitrogen", 14.0067, 7 },
                new object[] { "O", "Oxygen", 15.9994, 8 },
                new object[] { "F", "Fluorine", 18.9984, 9 },
                new object[] { "Ne", "Neon", 20.1797, 10 },
                new object[] { "Na", "Sodium", 22.9897, 11 },
                new object[] { "Mg", "Magnesium", 24.305, 12 },
                new object[] { "Al", "Aluminum", 26.9815, 13 },
                new object[] { "Si", "Silicon", 28.0855, 14 },
                new object[] { "P", "Phosphorus", 30.9738, 15 },
                new object[] { "S", "Sulfur", 32.065, 16 },
                new object[] { "Cl", "Chlorine", 35.453, 17 },
                new object[] { "K", "Potassium", 39.0983, 19 },
                new object[] { "Ar", "Argon", 39.948, 18 },
                new object[] { "Ca", "Calcium", 40.078, 20 },
                new object[] { "Sc", "Scandium", 44.9559, 21 },
                new object[] { "Ti", "Titanium", 47.867, 22 },
                new object[] { "V", "Vanadium", 50.9415, 23 },
                new object[] { "Cr", "Chromium", 51.9961, 24 },
                new object[] { "Mn", "Manganese", 54.938, 25 },
                new object[] { "Fe", "Iron", 55.845, 26 },
                new object[] { "Ni", "Nickel", 58.6934, 28 },
                new object[] { "Co", "Cobalt", 58.9332, 27 },
                new object[] { "Cu", "Copper", 63.546, 29 },
                new object[] { "Zn", "Zinc", 65.39, 30 },
                new object[] { "Ga", "Gallium", 69.723, 31 },
                new object[] { "Ge", "Germanium", 72.64, 32 },
                new object[] { "As", "Arsenic", 74.9216, 33 },
                new object[] { "Se", "Selenium", 78.96, 34 },
                new object[] { "Br", "Bromine", 79.904, 35 },
                new object[] { "Kr", "Krypton", 83.8, 36 },
                new object[] { "Rb", "Rubidium", 85.4678, 37 },
                new object[] { "Sr", "Strontium", 87.62, 38 },
                new object[] { "Y", "Yttrium", 88.9059, 39 },
                new object[] { "Zr", "Zirconium", 91.224, 40 },
                new object[] { "Nb", "Niobium", 92.9064, 41 },
                new object[] { "Mo", "Molybdenum", 95.94, 42 },
                new object[] { "Tc", "Technetium", 98.0, 43 },
                new object[] { "Ru", "Ruthenium", 101.07, 44 },
                new object[] { "Rh", "Rhodium", 102.9055, 45 },
                new object[] { "Pd", "Palladium", 106.42, 46 },
                new object[] { "Ag", "Silver", 107.8682, 47 },
                new object[] { "Cd", "Cadmium", 112.411, 48 },
                new object[] { "In", "Indium", 114.818, 49 },
                new object[] { "Sn", "Tin", 118.71, 50 },
                new object[] { "Sb", "Antimony", 121.76, 51 },
                new object[] { "I", "Iodine", 126.9045, 53 },
                new object[] { "Te", "Tellurium", 127.6, 52 },
                new object[] { "Xe", "Xenon", 131.293, 54 },
                new object[] { "Cs", "Cesium", 132.9055, 55 },
                new object[] { "Ba", "Barium", 137.327, 56 },
                new object[] { "La", "Lanthanum", 138.9055, 57 },
                new object[] { "Ce", "Cerium", 140.116, 58 },
                new object[] { "Pr", "Praseodymium", 140.9077, 59 },
                new object[] { "Nd", "Neodymium", 144.24, 60 },
                new object[] { "Pm", "Promethium", 145.0, 61 },
                new object[] { "Sm", "Samarium", 150.36, 62 },
                new object[] { "Eu", "Europium", 151.964, 63 },
                new object[] { "Gd", "Gadolinium", 157.25, 64 },
                new object[] { "Tb", "Terbium", 158.9253, 65 },
                new object[] { "Dy", "Dysprosium", 162.5, 66 },
                new object[] { "Ho", "Holmium", 164.9303, 67 },
                new object[] { "Er", "Erbium", 167.259, 68 },
                new object[] { "Tm", "Thulium", 168.9342, 69 },
                new object[] { "Yb", "Ytterbium", 173.04, 70 },
                new object[] { "Lu", "Lutetium", 174.967, 71 },
                new object[] { "Hf", "Hafnium", 178.49, 72 },
                new object[] { "Ta", "Tantalum", 180.9479, 73 },
                new object[] { "W", "Tungsten", 183.84, 74 },
                new object[] { "Re", "Rhenium", 186.207, 75 },
                new object[] { "Os", "Osmium", 190.23, 76 },
                new object[] { "Ir", "Iridium", 192.217, 77 },
                new object[] { "Pt", "Platinum", 195.078, 78 },
                new object[] { "Au", "Gold", 196.9665, 79 },
                new object[] { "Hg", "Mercury", 200.59, 80 },
                new object[] { "Tl", "Thallium", 204.3833, 81 },
                new object[] { "Pb", "Lead", 207.2, 82 },
                new object[] { "Bi", "Bismuth", 208.9804, 83 },
                new object[] { "Po", "Polonium", 209.0, 84 },
                new object[] { "At", "Astatine", 210.0, 85 },
                new object[] { "Rn", "Radon", 222.0, 86 },
                new object[] { "Fr", "Francium", 223.0, 87 },
                new object[] { "Ra", "Radium", 226.0, 88 },
                new object[] { "Ac", "Actinium", 227.0, 89 },
                new object[] { "Pa", "Protactinium", 231.0359, 91 },
                new object[] { "Th", "Thorium", 232.0381, 90 },
                new object[] { "Np", "Neptunium", 237.0, 93 },
                new object[] { "U", "Uranium", 238.0289, 92 },
                new object[] { "Am", "Americium", 243.0, 95 },
                new object[] { "Pu", "Plutonium", 244.0, 94 },
                new object[] { "Cm", "Curium", 247.0, 96 },
                new object[] { "Bk", "Berkelium", 247.0, 97 },
                new object[] { "Cf", "Californium", 251.0, 98 },
                new object[] { "Es", "Einsteinium", 252.0, 99 },
                new object[] { "Fm", "Fermium", 257.0, 100 },
                new object[] { "Md", "Mendelevium", 258.0, 101 },
                new object[] { "No", "Nobelium", 259.0, 102 },
                new object[] { "Rf", "Rutherfordium", 261.0, 104 },
                new object[] { "Lr", "Lawrencium", 262.0, 103 },
                new object[] { "Db", "Dubnium", 262.0, 105 },
                new object[] { "Bh", "Bohrium", 264.0, 107 },
                new object[] { "Sg", "Seaborgium", 266.0, 106 },
                new object[] { "Mt", "Meitnerium", 268.0, 109 },
                new object[] { "Rg", "Roentgenium", 272.0, 111 },
                new object[] { "Hs", "Hassium", 277.0, 108 }
            };

            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add(new System.Data.DataColumn("Symbol", typeof(string)));
            dt.Columns.Add(new System.Data.DataColumn("ElementName", typeof(string)));
            dt.Columns.Add(new System.Data.DataColumn("AtomicMass", typeof(double)));
            dt.Columns.Add(new System.Data.DataColumn("AtomicNumber", typeof(int)));

            foreach (object[] obj in data)
            {
                System.Data.DataRow dr = dt.NewRow();
                dr.SetField<string>("Symbol", (string)obj[0]);
                dr.SetField<string>("ElementName", (string)obj[1]);
                dr.SetField<double>("AtomicMass", (double)obj[2]);
                dr.SetField<int>("AtomicNumber", (int)obj[3]);
                dt.Rows.Add(dr);
            }

            return dt;
        }
    }
}
