using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static KidsLearning.Classed.Exten.Ext_Maths;
using TORServices.Drawings;
using TORServices.Systems;
using KidsLearning.Classed;
using TORServices.Maths;

namespace KidsLearning.Classed.Exten
{
    public static partial class ExtGraphics_Maths
    {

        public enum OperatorSelect { Addition, Subtraction, Multiplication, Division, Exponential, AddSub, MultiDiv, All };
        public static void DrawPlusMinusFillRectangle(this Graphics e, string Opr, bool ramdomRect, double min, double max,int digit, Font fontDetail, int x, int y)
        {
            int d1 = (digit < 0) ? RandomNumber.Randomnumber(1, 5) : digit;
            int d2 = (digit < 0) ? RandomNumber.Randomnumber(1, 5) : digit;
            double a = RandomNumber.Randomnumber(min, max,d1);
            double b = RandomNumber.Randomnumber(min, max, d2);
            double _a , _b ;

            double anw;
            if (Opr.Trim() == "+")
            {
                _a = a;
                _b = b;
                anw = a + b;
            }
            else
            {
                _a = Math.Min(a, b);
                _b = Math.Max(a, b);
                anw = _b - _a;
            }
         
            Pen pen = new Pen(Color.Black, 3);
            SolidBrush solidBrush = new SolidBrush(Color.Black);
            int h = (int)e.MeasureString(b.ToString($"F{d2}"), fontDetail).Height;
            int w_1 = (int)e.MeasureString(b.ToString($"F{d2}"), fontDetail).Width;
            int w_2 = (int)e.MeasureString(b.ToString($"F{d2}"), fontDetail).Width;
           
            if (!ramdomRect)
            {
                

                e.DrawString(_b.ToString($"F{d2}"), fontDetail, solidBrush, x, y);
                e.DrawString(Opr.Trim(), fontDetail, solidBrush, x +130, y - 20 + h / 2);
                e.DrawString(_a.ToString($"F{d1}"), fontDetail, solidBrush, x + 200, y);
                e.DrawString(" = ", fontDetail, solidBrush, x +  340, y - 20 + h / 2);
               
                e.DrawRectangle(new Pen(Color.Black, 3), x + 400, y - 10, 180, h + 10);
            }
            else
            {
                int c = RandomNumber.Randomnumber(1, 3000);
                if (c < 1000)
                {


                    e.DrawString(_b.ToString($"F{d2}"), fontDetail, solidBrush, x, y);
                    e.DrawString(Opr.Trim(), fontDetail, solidBrush, x + 130, y - 20 + h / 2);
                    e.DrawString(_a.ToString($"F{d1}"), fontDetail, solidBrush, x + 200, y);
                    e.DrawString(" = ", fontDetail, solidBrush, x + 340, y - 20 + h / 2);

                    e.DrawRectangle(new Pen(Color.Black, 3), x + 400, y - 10, 160, h + 10);

                }
                else if (c >= 1000 && c < 2000)
                {
                    e.DrawRectangle(new Pen(Color.Black, 2), x - 40, y - 10, 150, h + 10);

                    e.DrawString(Opr.Trim(), fontDetail, solidBrush, x + 130, y - 20 + h / 2);
                    e.DrawString(_a.ToString($"F{d1}"), fontDetail, solidBrush, x + 200, y);
                    e.DrawString(" = ", fontDetail, solidBrush, x + 340, y - 20 + h / 2);
                    e.DrawString(anw.ToString($"F{Math.Max(d1, d2)}"), fontDetail, solidBrush, x + 420, y);
                }
                else { 
                        e.DrawString(_b.ToString($"F{d2}"), fontDetail, solidBrush, x, y);
                        e.DrawString(Opr.Trim(), fontDetail, solidBrush, x + 130, y - 20 + h / 2);
                        
                        e.DrawRectangle(new Pen(Color.Black, 2), x + 160, y - 10, 140, h + 10);
                        e.DrawString(" = ", fontDetail, solidBrush, x + 340, y - 20 + h / 2);
                        e.DrawString(anw.ToString($"F{Math.Max(d1, d2)}"), fontDetail, solidBrush, x + 420, y);                
                }

            }

        }
        public static void DrawPlusMinusFillRectangleTwo(this Graphics e, string Opr, int min, int max, Font fontDetail, int x, int y)
        {
            int a = RandomNumber.Randomnumber(min, max);
            int b = RandomNumber.Randomnumber(min, max);
            int _a = Math.Min(a, b), _b = Math.Max(a, b);
            int c = RandomNumber.Randomnumber(1, 3000);
            int anw = (Opr.Trim() == "+") ? (a + b) : (_b - _a);
            // Font font = new Font("Arial", 20, FontStyle.Bold);
            Pen pen = new Pen(Color.Black, 3);
            SolidBrush solidBrush = new SolidBrush(Color.Black);
            int h = (int)e.MeasureString(b.ToString("N0"), fontDetail).Height;
            int w_1 = (int)e.MeasureString(b.ToString("N0"), fontDetail).Width;
            int w_2 = (int)e.MeasureString(b.ToString("N0"), fontDetail).Width;
            switch (c)
            {
                case int n when n < 1000:

                    e.DrawString(b.ToString("N0"), fontDetail, solidBrush, x, y);
                    e.DrawString(Opr.Trim(), fontDetail, solidBrush, x + w_1 + 30, y - 20 + h / 2);
                    e.DrawString(a.ToString("N0"), fontDetail, solidBrush, x + w_1 + 80, y);
                    e.DrawString(" = ", fontDetail, solidBrush, x + w_1 + w_2 + 120, y - 20 + h / 2);
                    e.DrawRectangle(new Pen(Color.Black, 3), x + w_1 + w_2 + 180, y - 20, w_2 + w_1, h);
                    // e.DrawString(anw.ToString(), fontDetail, solidBrush, x + w_1 + w_2 + 180, y);
                    break;
                case int n when n >= 1000 && n < 2000:
                    // e.DrawString(b.ToString(), fontDetail, solidBrush, x, y);
                    e.DrawRectangle(new Pen(Color.Black, 3), x, y, w_1 + 20, h);
                    e.DrawString(Opr.Trim(), fontDetail, solidBrush, x + w_1 + 30, y - 20 + h / 2);
                    e.DrawString(a.ToString("N0"), fontDetail, solidBrush, x + w_1 + 80, y);
                    e.DrawString(" = ", fontDetail, solidBrush, x + w_1 + w_2 + 120, y - 20 + h / 2);
                    e.DrawString(anw.ToString("N0"), fontDetail, solidBrush, x + w_1 + w_2 + 180, y);
                    break;
                case int n when n >= 2000:
                    e.DrawString(b.ToString("N0"), fontDetail, solidBrush, x, y);
                    e.DrawString(Opr.Trim(), fontDetail, solidBrush, x + w_1 + 30, y - 20 + h / 2);
                    e.DrawRectangle(new Pen(Color.Black, 3), x + w_1 + 80, y, w_2 + 20, h);
                    //e.DrawString(a.ToString(), fontDetail, solidBrush, x + w_1 + 80, y);
                    e.DrawString(" = ", fontDetail, solidBrush, x + w_1 + w_2 + 120, y - 20 + h / 2);
                    e.DrawString(anw.ToString("N0"), fontDetail, solidBrush, x + w_1 + w_2 + 180, y);
                    break;

            }
        }
        public static void DrawPlusMinusFillRectangleThree(this Graphics e, string Opr, int min, int max, Font fontDetail, int x, int y)
        {
            int a = RandomNumber.Randomnumber(min, max);
            int b = RandomNumber.Randomnumber(min, max);
            int _a = Math.Min(a, b), _b = Math.Max(a, b);
            int c = RandomNumber.Randomnumber(1, 3000);
            int anw = (Opr.Trim() == "+") ? (a + b) : (_b - _a);
            // Font font = new Font("Arial", 20, FontStyle.Bold);
            Pen pen = new Pen(Color.Black, 3);
            SolidBrush solidBrush = new SolidBrush(Color.Black);
            int h = (int)e.MeasureString(b.ToString("N0"), fontDetail).Height;
            int w_1 = (int)e.MeasureString(b.ToString("N0"), fontDetail).Width;
            int w_2 = (int)e.MeasureString(b.ToString("N0"), fontDetail).Width;
            switch (c)
            {
                case int n when n < 1000:

                    e.DrawString(b.ToString("N0"), fontDetail, solidBrush, x, y);
                    e.DrawString(Opr.Trim(), fontDetail, solidBrush, x + w_1 + 30, y - 20 + h / 2);
                    e.DrawString(a.ToString("N0"), fontDetail, solidBrush, x + w_1 + 80, y);
                    e.DrawString(" = ", fontDetail, solidBrush, x + w_1 + w_2 + 120, y - 20 + h / 2);
                    e.DrawRectangle(new Pen(Color.Black, 3), x + w_1 + w_2 + 180, y, w_2 + w_1, h);
                    // e.DrawString(anw.ToString(), fontDetail, solidBrush, x + w_1 + w_2 + 180, y);
                    break;
                case int n when n >= 1000 && n < 2000:
                    // e.DrawString(b.ToString(), fontDetail, solidBrush, x, y);
                    e.DrawRectangle(new Pen(Color.Black, 3), x, y, w_1 + 20, h);
                    e.DrawString(Opr.Trim(), fontDetail, solidBrush, x + w_1 + 30, y - 20 + h / 2);
                    e.DrawString(a.ToString("N0"), fontDetail, solidBrush, x + w_1 + 80, y);
                    e.DrawString(" = ", fontDetail, solidBrush, x + w_1 + w_2 + 120, y - 20 + h / 2);
                    e.DrawString(anw.ToString("N0"), fontDetail, solidBrush, x + w_1 + w_2 + 180, y);
                    break;
                case int n when n>= 2000:
                    e.DrawString(b.ToString("N0"), fontDetail, solidBrush, x, y);
                    e.DrawString(Opr.Trim(), fontDetail, solidBrush, x + w_1 + 30, y - 20 + h / 2);
                    e.DrawRectangle(new Pen(Color.Black, 3), x + w_1 + 80, y, w_2 + 20, h);
                    //e.DrawString(a.ToString(), fontDetail, solidBrush, x + w_1 + 80, y);
                    e.DrawString(" = ", fontDetail, solidBrush, x + w_1 + w_2 + 120, y - 20 + h / 2);
                    e.DrawString(anw.ToString("N0"), fontDetail, solidBrush, x + w_1 + w_2 + 180, y);
                    break;

            }
        }
        public static void DrawPlusMinusNumberSol(this Graphics e, OperatorSelect typeOperator, listNum_A_B listNum_A_B, Font fontDetail, int x, int y)
        {
            // Measure string.
            SizeF stringSize = new SizeF();

            string op = "";
            int b = listNum_A_B.MinValue;
            int a = listNum_A_B.MaxValue;
            int c = 0;
            int ipp = RandomNumber.Randomnumber(1, 2000);
            if (typeOperator == OperatorSelect.Addition || (typeOperator == OperatorSelect.AddSub && (ipp < 1000)))
            {
                op = " + ";

            }

            else if (typeOperator == OperatorSelect.Subtraction || (typeOperator == OperatorSelect.AddSub && (ipp >= 1000)))
            {
                op = " - ";

            }
            string EQ = a + " " + op + " " + b + " = ?";
            stringSize = e.MeasureString(EQ, fontDetail);

            //   e.DrawRectangle(new Pen(Brushes.Black, 1), new Rectangle(x, y, w, 140));

            e.DrawString(EQ, fontDetail, Brushes.Black, x, y + 10);


            string _a = string.Join("  ", a.ToString().ToArray());
            string _b = string.Join("  ", b.ToString().ToArray());

            int _w = (Math.Max((int)e.MeasureString(_a, fontDetail).Width * 2, (int)e.MeasureString(_b, fontDetail).Width * 2)) + 20;


            e.DrawString(_a, fontDetail, Brushes.Black, x + _w - 20 - (int)e.MeasureString(_a, fontDetail).Width, y + 70);
            e.DrawString(op, fontDetail, Brushes.Black, x + _w - 10, y + 80);
            e.DrawString(_b, fontDetail, Brushes.Black, x + _w - 20 - (int)e.MeasureString(_b, fontDetail).Width, y + 100);

            int _y = y + (int)e.MeasureString(_b, fontDetail).Height + 110;
            e.DrawLine(new Pen(Brushes.Black, 2), x, _y, x + _w - 20, _y);
            _y += (int)e.MeasureString(_b, fontDetail).Height + 20;
            e.DrawLine(new Pen(Brushes.Black, 2), x, _y, x + _w - 20, _y);
            e.DrawLine(new Pen(Brushes.Black, 2), x, _y + 5, x + _w - 20, _y + 5);



        }

        public static void DrawMultiNumberSol(this Graphics e, listNum_A_B listNum_A_B, Font fontDetail, int x, int y)
        {
            // Measure string.
            SizeF stringSize = new SizeF();

            string op = " x ";
            int b = listNum_A_B.MinValue;
            int a = listNum_A_B.MaxValue;
            int c = 0;

            string EQ = a + " " + op + " " + b + " = ?";
            stringSize = e.MeasureString(EQ, fontDetail);

            //   e.DrawRectangle(new Pen(Brushes.Black, 1), new Rectangle(x, y, w, 140));

            e.DrawString(EQ, fontDetail, Brushes.Black, x, y + 10);


            string _a = string.Join("  ", a.ToString().ToArray());
            string _b = string.Join("  ", b.ToString().ToArray());

            int _w = (Math.Max((int)e.MeasureString(_a, fontDetail).Width * 2, (int)e.MeasureString(_b, fontDetail).Width * 2)) + 20;

            e.DrawString(_a, fontDetail, Brushes.Black, x + _w - 20 - (int)e.MeasureString(_a, fontDetail).Width, y + 70);
            e.DrawString(op, fontDetail, Brushes.Black, x + _w - 10, y + 80);
            e.DrawString(_b, fontDetail, Brushes.Black, x + _w - 20 - (int)e.MeasureString(_b, fontDetail).Width, y + 100);

            int _y = y + (int)e.MeasureString(_b, fontDetail).Height + 140;
            e.DrawLine(new Pen(Brushes.Black, 2), x, _y, x + _w - 20, _y);
            if (b >= 10)
            {
                //  System.Windows.Forms.MessageBox.Show(b.ToString());

                _y += (int)e.MeasureString(_b, fontDetail).Height + 20;
                e.DrawLine(new Pen(Brushes.Black, 2), x, _y, x + _w - 20, _y);
            }

            if (b >= 100)
            {
                // System.Windows.Forms.MessageBox.Show(b.ToString());
                _y += (int)e.MeasureString(_b, fontDetail).Height + 20;
                e.DrawLine(new Pen(Brushes.Black, 2), x, _y, x + _w - 20, _y);
            }

            _y += (int)e.MeasureString(_b, fontDetail).Height + 40;
            e.DrawLine(new Pen(Brushes.Black, 2), x, _y, x + _w - 20, _y);
            // e.DrawString("Ans.", fontDetail, Brushes.Black, x+_w-20 ,_y-40);
            e.DrawLine(new Pen(Brushes.Black, 2), x, _y + 5, x + _w - 20, _y + 5);



        }

        public static void DrawPlusMinusMultiDivNum(this Graphics e, OperatorSelect typeOperator, listNum_A_B listNum_A_B, Font fontDetail, int min, int max, int x, int y, bool random)
        {

            // Measure string.
            SizeF stringSize = new SizeF();

            string op = "";
            int b = listNum_A_B.MinValue;
            int a = listNum_A_B.MaxValue;
            int c = 0;
            if (typeOperator == OperatorSelect.Addition)
            {
                op = " + ";
                c = a + b;
            }
            else if (typeOperator == OperatorSelect.Division)
            {
                op = " ÷ ";

                c = a;
                a = (int)(c / RandomNumber.Randomnumber(1, 50));
                b = (int)(c / a);
                c = a * b;
            }
            else if (typeOperator == OperatorSelect.Subtraction)
            {
                op = " - ";
                c = a - b;
            }
            else if (typeOperator == OperatorSelect.Multiplication)
            {
                op = " x ";
                c = a;
                a = (int)(c / RandomNumber.Randomnumber(1, 50));
                b = (int)(c / a);
                c = a * b;

            }
            else if (typeOperator == OperatorSelect.All)
            {
                int ipp = RandomNumber.Randomnumber(1, 4000);
                if (ipp < 1000)
                {
                    op = " + ";
                    c = a + b;
                }
                else if (ipp >= 1000 && ipp < 2000)
                {
                    op = " - ";
                    c = a - b;
                }
                else if (ipp >= 2000 && ipp < 3000)
                {
                    op = " ÷ ";
                    c = a;
                    a = (int)(c / RandomNumber.Randomnumber(1, 50));
                    b = (int)(c / a);
                    c = a * b;
                }
                else if (ipp >= 3000)
                {
                    op = " x ";
                    c = a;
                    a = (int)(c / RandomNumber.Randomnumber(1, 50));
                    b = (int)(c / a);
                    c = a * b;
                }
            }

            //  System.Windows.Forms.MessageBox.Show(a+ "  "  + b + "  "  + c + "  " + op);

            e.DrawString(" " + op + " ", fontDetail, Brushes.Black, x + 130, y + 10);
            e.DrawString(" = ", fontDetail, Brushes.Black, x + 290, y + 10);

            e.DrawString(a.ToString("n0"), fontDetail, Brushes.Black, x + 120 - e.MeasureString(a.ToString("n0") + " ", fontDetail).Width, y + 10);
            e.DrawString(b.ToString("n0") + " ", fontDetail, Brushes.Black, x + 170, y + 10);
            e.DrawString(c.ToString("n0") + " ", fontDetail, Brushes.Black, x + 350, y + 10);

            if (!random)
            {

                e.DrawRectangle(new Pen(Color.Black, 2), x + 320, y, 120, 40);
            }
            else
            {
                int ipp = RandomNumber.Randomnumber(1, 3000);
                if (ipp < 1000)
                {

                    e.DrawRectangle(new Pen(Color.Black, 2), x, y, 120, 40);

                }
                else if (ipp >= 1000 && ipp < 2000)
                {
                    e.DrawRectangle(new Pen(Color.Black, 2), x + 170, y, 120, 40);
                }
                else if (ipp >= 2000)
                {
                    e.DrawRectangle(new Pen(Color.Black, 2), x + 320, y, 120, 40);
                }

            }


        }

        public static void DrawPlusMinusTwo(this Graphics e, Font fontDetail, int min, int max, int x, int y, bool random = false, operater_AddDifTwo operater_AddDifTwo = operater_AddDifTwo.one)
        {

            // Measure string.
            List<string> operater_1 = new List<string>() { "+_+", "+_-", "-_+", "-_-" };
            List<string> operater_2 = new List<string>() { "+_+_+", "+_+_-", "+_-_+", "+_-_-", "-_+_+", "-_+_-", "-_-_+", "-_-_-" };
            List<string> operater_3 = new List<string>() { "+_+_+_+", "+_+_+_-", "+_+_-_+", "+_+_-_-", "+_-_+_+", "+_-_+_-", "+_-_-_+", "+_-_-_-", "-_+_+_+", "-_+_+_-", "-_+_-_+", "-_+_-_-", "-_-_+_+", "-_-_+_-", "-_-_-_+", "-_-_-_-" };


            SizeF stringSize = new SizeF();
            int _a = RandomNumber.Randomnumber(min, max);
            int _b = RandomNumber.Randomnumber(min, max);
            int _c = RandomNumber.Randomnumber(min, max);



            string op = "";
            int b = Math.Min(_a, _b);
            int a = Math.Max(_a, _b);

            int c = 0;

            int ipp = RandomNumber.Randomnumber(1, 2000);
            if (ipp < 1000)
            {
                op = "+_-";
            }
            else
            {
                op = "-_+";
            }

            e.DrawString(" " + op + " ", fontDetail, Brushes.Black, x + 130, y + 10);
            e.DrawString(" = ", fontDetail, Brushes.Black, x + 290, y + 10);

            e.DrawString(a.ToString("n0"), fontDetail, Brushes.Black, x + 120 - e.MeasureString(a.ToString("n0") + " ", fontDetail).Width, y + 10);
            e.DrawString(b.ToString("n0") + " ", fontDetail, Brushes.Black, x + 170, y + 10);
            e.DrawString(c.ToString("n0") + " ", fontDetail, Brushes.Black, x + 350, y + 10);

            if (!random)
            {

                e.DrawRectangle(new Pen(Color.Black, 2), x + 320, y, 120, 40);
            }
            else
            {
                ipp = RandomNumber.Randomnumber(1, 3000);
                if (ipp < 1000)
                {

                    e.DrawRectangle(new Pen(Color.Black, 2), x, y, 120, 40);

                }
                else if (ipp >= 1000 && ipp < 2000)
                {
                    e.DrawRectangle(new Pen(Color.Black, 2), x + 170, y, 120, 40);
                }
                else if (ipp >= 2000)
                {
                    e.DrawRectangle(new Pen(Color.Black, 2), x + 320, y, 120, 40);
                }

            }


        }


        public static void DrawNumPositive(this Graphics e, Font fontDetail, int min, int max, int x, int y, string opr, int CountNum = 7)
        {


            int a  = (int)RandomNumber.Randomnumber(min, max);
            int b = (int)RandomNumber.Randomnumber(min, max);
            string _a = TextStringExtension.SpacedString(Math.Min( a,b).ToString());
            string _b = TextStringExtension.SpacedString(Math.Max(a, b).ToString());

            //System.Windows.Forms.MessageBox.Show(num.MinValue + "\n" + num.MaxValue + "\n" + _a + "\n" + _b);

            int w = Convert.ToInt32(e.MeasureString("0  ", fontDetail).Width);
            int h = Convert.ToInt32(e.MeasureString("0  ", fontDetail).Height);

            //https://docs.microsoft.com/en-us/dotnet/desktop/winforms/advanced/how-to-align-drawn-text?view=netframeworkdesktop-4.8
            StringFormat format = new StringFormat(StringFormatFlags.DirectionRightToLeft);

            // https://stackoverflow.com/questions/11451001/why-isnt-my-text-right-aligned-when-i-custom-draw-my-strings
            //https://docs.microsoft.com/en-us/dotnet/desktop/winforms/advanced/how-to-align-drawn-text?view=netframeworkdesktop-4.8&redirectedfrom=MSDN
            StringFormat stringFormat = new StringFormat() { Alignment = StringAlignment.Far };


            e.DrawString(_b, fontDetail, new SolidBrush(Color.Black), new Rectangle(x, y, w * CountNum, h), stringFormat);
            e.DrawString(_a, fontDetail, new SolidBrush(Color.Black), new Rectangle(x, y + h + 10, w * CountNum, h), stringFormat);
            e.DrawLine(new Pen(Color.Black, 3), x, y + 2 * h + 10, x + (CountNum) * w, y + 2 * h + 10);
            e.DrawString(opr, fontDetail, new SolidBrush(Color.Black), x + (CountNum) * w, y + 10 + h / 2);
            e.DrawLine(new Pen(Color.Black, 3), x, y + h * 3 + 15, x + (CountNum) * w, y + h * 3 + 15);
            e.DrawLine(new Pen(Color.Black, 3), x, y + h * 3 + 20, x + (CountNum) * w, y + h * 3 + 20);



        }

        public static void DrawNumPositive(this Graphics e, Font fontDetail, double min, double max, int x, int y, string opr, int CountNum = 6, int digit = 3)
        {

            //https://pantip.com/topic/41657834/comment5
            double a = RandomNumber.Randomnumber(min, max,digit);
            double b = RandomNumber.Randomnumber(min, max,digit);
            string __a = TextStringExtension.SpacedString(Math.Min(a, b).ToString());
            string __b = TextStringExtension.SpacedString(Math.Max(a, b).ToString());

            var formatted_a = String.Format($"{{0:F{digit}}}", __a);
            var formatted_b = String.Format($"{{0:F{digit}}}", __b);//num.MaxValue.ToString($"F{c}");

            var _a = String.Join<char>(" ", formatted_a);
            var _b = String.Join(" ", (IEnumerable<char>)formatted_b);


            int w = Convert.ToInt32(e.MeasureString("0  ", fontDetail).Width);
            int h = Convert.ToInt32(e.MeasureString("0  ", fontDetail).Height);

            //https://docs.microsoft.com/en-us/dotnet/desktop/winforms/advanced/how-to-align-drawn-text?view=netframeworkdesktop-4.8
            StringFormat format = new StringFormat(StringFormatFlags.DirectionRightToLeft);

            // https://stackoverflow.com/questions/11451001/why-isnt-my-text-right-aligned-when-i-custom-draw-my-strings
            //https://docs.microsoft.com/en-us/dotnet/desktop/winforms/advanced/how-to-align-drawn-text?view=netframeworkdesktop-4.8&redirectedfrom=MSDN
            StringFormat stringFormat = new StringFormat() { Alignment = StringAlignment.Far };


            e.DrawString(_b, fontDetail, new SolidBrush(Color.Black), new Rectangle(x, y, w * CountNum, h), stringFormat);
            e.DrawString(_a, fontDetail, new SolidBrush(Color.Black), new Rectangle(x, y + h + 10, w * CountNum, h), stringFormat);
            e.DrawLine(new Pen(Color.Black, 3), x, y + 2 * h + 10, x + (CountNum) * w, y + 2 * h + 10);
            e.DrawString(opr, fontDetail, new SolidBrush(Color.Black), x + (CountNum) * w, y + 10 + h / 2);
            e.DrawLine(new Pen(Color.Black, 3), x, y + h * 3 + 15, x + (CountNum) * w, y + h * 3 + 15);
            e.DrawLine(new Pen(Color.Black, 3), x, y + h * 3 + 20, x + (CountNum) * w, y + h * 3 + 20);



        }


    }
}
