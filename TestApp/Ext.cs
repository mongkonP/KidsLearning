using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestApp
{
    public static class Ext
    {
        public static Random random= new Random();

        public static string ToSubscriptNumber(this string @this)
        {
            var pattern = @"\[sub\](.*?)\[/sub\]";
            var matches = Regex.Matches(@this, pattern);

            foreach (Match match in matches)
            {
                var subscript = match.Groups[1].Value;
                var subscriptNumber = ConvertToSubscript(subscript);
                @this = @this.Replace(match.Value, subscriptNumber);
            }

            return @this;
        }

        private static string ConvertToSubscript(string number)
        {
            var sb = new StringBuilder();

            foreach (var digit in number)
            {
                if (digit >= '0' && digit <= '9')
                {
                    sb.Append((char)(digit + 8272)); // 8272 is the offset for subscript numbers
                }
                else
                {
                    sb.Append(digit);
                }
            }

            return sb.ToString();
        }

        private static string ToSubscriptNumber(this int @this)
        {

            var sb = new StringBuilder();
            var digits = @this.ToString().ToArray();

            foreach (var digit in digits)
            {
                if (digit == '0')
                {
                    sb.Append(("\u2080"));
                }
                else if (digit == '1')
                {
                    sb.Append(("\u2081"));
                }
                else if (digit == '2')
                {
                    sb.Append(("\u2082"));
                }
                else if (digit == '3')
                {
                    sb.Append(("\u2083"));
                }
                else if (digit == '4')
                {
                    sb.Append(("\u2084"));
                }
                else if (digit == '5')
                {
                    sb.Append(("\u2085"));
                }
                else if (digit == '6')
                {
                    sb.Append(("\u2086"));
                }
                else if (digit == '7')
                {
                    sb.Append(("\u2087"));
                }
                else if (digit == '8')
                {
                    sb.Append(("\u2088"));
                }
                else if (digit == '9')
                {
                    sb.Append(("\u2089"));
                }
                else if (digit == '+')
                {
                    sb.Append(("\u208A"));
                }
                else if (digit == '-')
                {
                    sb.Append(("\u208B"));
                }
                else if (digit == '=')
                {
                    sb.Append(("\u208C"));
                }
                else if (digit == '(')
                {
                    sb.Append(("\u208D"));
                }
                else if (digit == ')')
                {
                    sb.Append(("\u207E"));
                }
            }
            return sb.ToString();
        }
    }


}
