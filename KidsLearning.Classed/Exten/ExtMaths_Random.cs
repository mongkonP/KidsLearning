using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KidsLearning.Classed.Exten
{
    public class RandomNumber
    {
        int _a, _b;
        public RandomNumber(int min, int max)
        {
            _a = RandomNumberGenerator.GetInt32(min, max);
            _b = RandomNumberGenerator.GetInt32(min, max);
           // System.Windows.Forms.MessageBox.Show(_a + "\n" + _b);
        }
        public int MinValue
        {
            get { return Math.Min(_a, _b); }
        }
        public int MaxValue
        {
            get { return Math.Max(_a, _b); }
        }
    }
    public static partial class Ext_Maths
    {
        private static Random r = new Random();
        public static double Randomdouble(int min, int max)
        {
            return RandomNumberGenerator.GetInt32(min, max) + r.NextDouble();
        }
        public static double Randomdouble(int min, int max, int _decimal)
        {
            double d = RandomNumberGenerator.GetInt32(min, max) + r.NextDouble();
            return Convert.ToDouble(d.ToString("N" + _decimal));
        }
        public static double RandomInt(int min, int max)
        {
            return r.Next(min, max); //RandomNumberGenerator.GetInt32(min, max);
        }
    }
}
