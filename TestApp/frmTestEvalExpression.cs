using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Expressions;
namespace TestApp
{
    public partial class frmTestEvalExpression : Form
    {
        public frmTestEvalExpression()
        {
            InitializeComponent();
        }
        Random random = new Random();
        private void frmTestEvalExpression_Load(object sender, EventArgs e)
        {
            /*for(int i = 0;i<50;i++)
              richTextBox1.Text +="\n" + ParseEquation();*/
            /*string input = "2CO[sub]22[/sub].2Pb.H[sub]2[/sub]O[sub]2[/sub]Pb";
            string output = input.ToSubscriptNumber();
            richTextBox1.Text = output;*/
            /* string ss = "";
             using (StreamReader reader = new StreamReader("D:\\T_MEGA\\GithubCode\\KidsLearning\\KidsLearning\\File\\Book\\Sci\\FM_CHEM.txt"))
             { 
                 ss = reader.ReadToEnd().Replace("|","\n");
             }


                 DataTable dataTable = AtomicData();
             foreach (DataRow row in dataTable.Rows)
             {
                 string Elm = row[0].ToString();
                 for (int i = 2; i <= 40; i++)
                 {
                     ss = ss.Replace($"{Elm}{i}", $"{Elm}[sub]{i}[/sub]");
                 }
             }
             richTextBox1.Text = ss;*/

            for (int i = 1; i <= 30; i++)
            {
                string c  = (i==1)?"":i.ToString();
                richTextBox1.Text += $"| C{c}H{i + 2}";
            }
        }

        string ParseEquation()
        {
            string s = "";
            int a = RandomNumberGenerator.GetInt32(1, 10);
            int x = RandomNumberGenerator.GetInt32(-5, 5);
            int b = RandomNumberGenerator.GetInt32(-10, 10);
            int y = RandomNumberGenerator.GetInt32(-5, 5);
            int d = RandomNumberGenerator.GetInt32(1, 3000);

            string o = (RandomNumberGenerator.GetInt32(1, 1000) > 500) ? "+" : "-";
            string ev = "";

            switch (d)
            {
                case int n when (n >= 0 && n < 1000):
                    //ax+/-b=0
                    // ev = $"{a}{x} {o} {b}{y}  = 0";
                    do
                    {
                        a = RandomNumberGenerator.GetInt32(1, 10);
                        x = RandomNumberGenerator.GetInt32(-5, 5);
                        b = RandomNumberGenerator.GetInt32(1, 10);
                        y = RandomNumberGenerator.GetInt32(-5, 5);

                        o = (RandomNumberGenerator.GetInt32(1, 1000) > 500) ? "+" : "-";
                    } while (a * x + (o == "+" ? b * y : -b * y) != 0);
                    ev = $"{a}x {o} {b}y  = 0";
                    break;

                case int n when (n >= 1000 && n < 2000):
                    //ax+/-b=c
                    ev = $"{a}x {o} {b}y  = {Eval.Execute<int>($"{a}{x} {o} {b}{y}")}";
                    break;

                case int n when (n >= 2000 && n <= 3000):
                    //ax = b+/-c
                    if (o == "+")
                        ev = $"{a}x = {b}y {o} {Eval.Execute<int>($"{a}{x} - {b}{y}")}";
                    else
                        ev = $"{a}x = {b}y {o} {Eval.Execute<int>($"{b}{y} - {a}{x}")}";
                    break;
            }

            // Parameter: Argument Position

            s = ev.Replace("--", "+").Replace("+-", "-").Replace("-+", "-")
                .Replace("- -", "+").Replace("+ -", "-").Replace("- +", "-");




            a = RandomNumberGenerator.GetInt32(1, 10);
            b = RandomNumberGenerator.GetInt32(-10, 10);
            d = RandomNumberGenerator.GetInt32(1, 3000);

            o = (RandomNumberGenerator.GetInt32(1, 1000) > 500) ? "+" : "-";

            switch (d)
            {
                case int n when (n >= 0 && n < 1000):
                    //ax+/-b=0


                    // ev = $"{a}{x} {o} {b}{y}  = 0";


                    do
                    {
                        a = RandomNumberGenerator.GetInt32(1, 10);
                        x = RandomNumberGenerator.GetInt32(-5, 5);
                        b = RandomNumberGenerator.GetInt32(1, 10);
                        y = RandomNumberGenerator.GetInt32(-5, 5);

                        o = (RandomNumberGenerator.GetInt32(1, 1000) > 500) ? "+" : "-";
                    } while (a * x + (o == "+" ? b * y : -b * y) != 0);

                    ev = $"{a}x {o} {b}y  = 0";
                    break;

                case int n when (n >= 1000 && n < 2000):
                    //ax+/-b=c
                    ev = $"{a}x {o} {b}y  = {Eval.Execute<int>($"{a}{x} {o} {b}{y}")}";
                    break;

                case int n when (n >= 2000 && n <= 3000):
                    //ax = b+/-c
                    if (o == "+")
                        ev = $"{a}x = {b}y {o} {Eval.Execute<int>($"{a}{x} - {b}{y}")}";
                    else
                        ev = $"{a}x =  {b} y {o} {Eval.Execute<int>($"{b}{y} - {a}{x}")}";
                    break;
            }

            // Parameter: Argument Position
            return $"{s} and " + ev.Replace("--", "+").Replace("+-", "-").Replace("-+", "-")
                .Replace("- -", "+").Replace("+ -", "-").Replace("- +", "-");

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
