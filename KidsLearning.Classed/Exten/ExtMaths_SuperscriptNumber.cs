using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KidsLearning.Classed.Exten
{
    public static class SuperscriptNumber
    {
        //https://stackoverflow.com/questions/15042334/how-can-i-add-superscript-power-operators-in-c-sharp-winforms
        //https://en.wikipedia.org/wiki/Unicode_subscripts_and_superscripts
        //https://stackoverflow.com/questions/19682459/superscript-label-or-form-name
        private static readonly string superscripts = @"0123456789+-";
        private static string ToSuperscriptNumber(this int @this)
        {

            var sb = new StringBuilder();
            var digits = @this.ToString().ToArray();

            foreach (var digit in digits)
            {
                if (digit == '0')
                {
                    sb.Append(("\u2070"));
                }
                else if (digit == '1')
                {
                    sb.Append(("\u00B9"));
                }
                else if (digit == '2')
                {
                    sb.Append(("\u00B2"));
                }
                else if (digit == '3')
                {
                    sb.Append(("\u00B3"));
                }
                else if (digit == '4')
                {
                    sb.Append(("\u2074"));
                }
                else if (digit == '5')
                {
                    sb.Append(("\u2075"));
                }
                else if (digit == '6')
                {
                    sb.Append(("\u2076"));
                }
                else if (digit == '7')
                {
                    sb.Append(("\u2077"));
                }
                else if (digit == '8')
                {
                    sb.Append(("\u2078"));
                }
                else if (digit == '9')
                {
                    sb.Append(("\u2079"));
                }
                else if (digit == '+')
                {
                    sb.Append(("\u207A"));
                }
                else if (digit == '-')
                {
                    sb.Append(("\u207B"));
                }
            }
            return sb.ToString();
        }

        public static string ToSuperscriptNumber(this string @this)
        {
            var a = @this.Trim().Split('^');
            string s = "";
            if (a.Length == 2)
            {
                string _a = a[0].Trim();
                int _b = int.Parse(a[1].Trim());
                s = _a + _b.ToSuperscriptNumber();
            }

            return s;

        }
    }
}
