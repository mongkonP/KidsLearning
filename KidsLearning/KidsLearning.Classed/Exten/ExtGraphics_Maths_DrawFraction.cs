using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TORServices.Drawings;
namespace KidsLearning.Classed.Exten
{
    public static partial class ExtGraphics_Maths
    {
        public static void DrawFraction(this Graphics e, int excfraction, int numerator, int denominator, int x, int y)
        {
            // Measure string.

               Font stringFont = new Font("Angsana New", 20);

               SizeF stringSize_numerator = e.MeasureString(numerator.ToString() + "   ", stringFont);
               SizeF stringSize_denominator = e.MeasureString(denominator.ToString() + "   ", stringFont);
               SizeF stringSize_excfraction = e.MeasureString(excfraction.ToString() + "   ", stringFont);

               float w = ((stringSize_numerator.Width < stringSize_denominator.Width) ? stringSize_denominator.Width : stringSize_numerator.Width);
               int _x, _y, _w, _h;
               _x = x + 5 + Convert.ToInt32(w);
               _y = y + 2;
               _w = 33;
               _h = 30;
               if (numerator !=0)
               {
                   e.DrawString(numerator.ToString(), stringFont, new SolidBrush(Color.Black), new Rectangle(_x, _y, _w, _h), new StringFormat() { Alignment = StringAlignment.Center });
               }
               if (denominator != 0 && denominator != 1)
                   e.DrawLine(new Pen(Brushes.Black, 2), _x, y + stringSize_numerator.Height - 5, _x + _w, y + stringSize_numerator.Height - 5);

               _y = y + _h;

               if (denominator != 0)
               {
                       e.DrawString(denominator.ToString(), stringFont, new SolidBrush(Color.Black), new Rectangle(_x, _y, _w, _h), new StringFormat() { Alignment = StringAlignment.Center });

               }



               _x = x;
               _y = y + _h / 2 + 5;

               if (excfraction != 0)
               {
                   e.DrawString(excfraction.ToString(), stringFont, new SolidBrush(Color.Black), new Rectangle(_x, _y, _w, _h), new StringFormat() { Alignment = StringAlignment.Center });
               }


        }
        public static void DrawFraction(this Graphics e, int excfraction, int numerator, int denominator, int x, int y,
           bool numeratorRec = false, bool excfractionRec = false, bool denominatorRec = false, bool excfractionShow = true)
        {
            // Measure string.

            Font stringFont = new Font("Angsana New", 20);

            SizeF stringSize_numerator = e.MeasureString(numerator.ToString() + "   ", stringFont);
            SizeF stringSize_denominator = e.MeasureString(denominator.ToString() + "   ", stringFont);
            SizeF stringSize_excfraction = e.MeasureString(excfraction.ToString() + "   ", stringFont);

            float w = ((stringSize_numerator.Width < stringSize_denominator.Width) ? stringSize_denominator.Width : stringSize_numerator.Width);
            int _x, _y, _w, _h;
            _x = x + 5 + Convert.ToInt32(w);
            _y = y + 2;
            _w = 33;
            _h = 30;
            if (numeratorRec)
            {

                e.DrawRectangle(Pens.Black, new Rectangle(_x, _y, _w, _h));
            }
            else
            {
                e.DrawString(numerator.ToString(), stringFont, new SolidBrush(Color.Black), new Rectangle(_x, _y, _w, _h), new StringFormat() { Alignment = StringAlignment.Center });
            }
            if (denominator != 0 && denominator != 1)
                e.DrawLine(new Pen(Brushes.Black, 2), _x, y + stringSize_numerator.Height - 5, _x + _w, y + stringSize_numerator.Height - 5);

            _y = y + _h;

            if (denominatorRec)
            {
                e.DrawRectangle(Pens.Black, new Rectangle(_x, _y + 10, _w, _h));
            }
            else
            {
                if(denominator !=0 &&  denominator !=1)
                e.DrawString(denominator.ToString(), stringFont, new SolidBrush(Color.Black), new Rectangle(_x, _y, _w, _h), new StringFormat() { Alignment = StringAlignment.Center });

            }



            _x = x;
            _y = y + _h / 2 + 5;

            if (excfractionRec)
            {
                e.DrawRectangle(Pens.Black, new Rectangle(_x - 18, _y, _w, _h));
            }
            else if (excfractionShow && excfraction != 0)
            {
                e.DrawString(excfraction.ToString(), stringFont, new SolidBrush(Color.Black), new Rectangle(_x, _y, _w, _h), new StringFormat() { Alignment = StringAlignment.Center });
            }


        }
        public static void DrawFraction(this Graphics e, string excfraction, string numerator, string denominator, int x, int y,
            bool numeratorRec = false, bool excfractionRec = false, bool denominatorRec = false, bool excfractionShow = true)
        {
            // Measure string.

            Font stringFont = new Font("Angsana New", 20);

            SizeF stringSize_numerator = e.MeasureString(numerator.ToString() + "   ", stringFont);
            SizeF stringSize_denominator = e.MeasureString(denominator.ToString() + "   ", stringFont);
            SizeF stringSize_excfraction = e.MeasureString(excfraction.ToString() + "   ", stringFont);

            float w = ((stringSize_numerator.Width < stringSize_denominator.Width) ? stringSize_denominator.Width : stringSize_numerator.Width);
            int _x, _y, _w, _h;
            _x = x + 5 + Convert.ToInt32(w);
            _y = y + 2;
            _w = 33;
            _h = 30;
            if (numeratorRec)
            {

                e.DrawRectangle(Pens.Black, new Rectangle(_x, _y, _w, _h));
            }
            else
            {
                e.DrawString(numerator.ToString(), stringFont, new SolidBrush(Color.Black), new Rectangle(_x, _y, _w, _h), new StringFormat() { Alignment = StringAlignment.Center });
            }

            e.DrawLine(new Pen(Brushes.Black, 2), _x, y + stringSize_numerator.Height - 5, _x + _w, y + stringSize_numerator.Height - 5);

            _y = y + _h;

            if (denominatorRec)
            {
                e.DrawRectangle(Pens.Black, new Rectangle(_x, _y + 10, _w, _h));
            }
            else
            {
                e.DrawString(denominator.ToString(), stringFont, new SolidBrush(Color.Black), new Rectangle(_x, _y, _w, _h), new StringFormat() { Alignment = StringAlignment.Center });

            }



            _x = x;
            _y = y + _h / 2 + 5;

            if (excfractionRec)
            {
                e.DrawRectangle(Pens.Black, new Rectangle(_x - 18, _y, _w, _h));
            }
            else if (excfractionShow && int.Parse(excfraction) != 0)
            {
                e.DrawString(excfraction.ToString(), stringFont, new SolidBrush(Color.Black), new Rectangle(_x, _y, _w, _h), new StringFormat() { Alignment = StringAlignment.Center });
            }


        }
        public static void DrawFraction(this Graphics e, string numerator, string denominator, int x, int y)
        {
            // Measure string.

            Font stringFont = new Font("Angsana New", 20);

            SizeF stringSize_numerator = e.MeasureString(numerator.ToString() + "   ", stringFont);
            SizeF stringSize_denominator = e.MeasureString(denominator.ToString() + "   ", stringFont);


            float w = ((stringSize_numerator.Width < stringSize_denominator.Width) ? stringSize_denominator.Width : stringSize_numerator.Width);
            int _x, _y, _w, _h;
            _x = x + 5 + Convert.ToInt32(w);
            _y = y + 2;
            _w = 55;
            _h = 30;

            e.DrawString(numerator.ToString(), stringFont, new SolidBrush(Color.Black), new Rectangle(_x, _y, _w, _h), new StringFormat() { Alignment = StringAlignment.Center });


            e.DrawLine(new Pen(Brushes.Black, 2), _x, y + stringSize_numerator.Height - 5, _x + _w, y + stringSize_numerator.Height - 5);

            _y = y + _h;


            e.DrawString(denominator.ToString(), stringFont, new SolidBrush(Color.Black), new Rectangle(_x, _y, _w, _h), new StringFormat() { Alignment = StringAlignment.Center });





            _x = x;
            _y = y + _h / 2 + 5;



        }
        public static void DrawFraction(this Graphics e, int numerator, int denominator, int x, int y)
        {
            // Measure string.

            Font stringFont = new Font("Angsana New", 20);

            SizeF stringSize_numerator = e.MeasureString(numerator.ToString() + "   ", stringFont);
            SizeF stringSize_denominator = e.MeasureString(denominator.ToString() + "   ", stringFont);


            float w = ((stringSize_numerator.Width < stringSize_denominator.Width) ? stringSize_denominator.Width : stringSize_numerator.Width);
            int _x, _y, _w, _h;
            _x = x + 5 + Convert.ToInt32(w);
            _y = y + 2;
            _w = 33;
            _h = 30;

            e.DrawString(numerator.ToString(), stringFont, new SolidBrush(Color.Black), new Rectangle(_x, _y, _w, _h), new StringFormat() { Alignment = StringAlignment.Center });


            e.DrawLine(new Pen(Brushes.Black, 2), _x, y + stringSize_numerator.Height - 5, _x + _w, y + stringSize_numerator.Height - 5);

            _y = y + _h;


            e.DrawString(denominator.ToString(), stringFont, new SolidBrush(Color.Black), new Rectangle(_x, _y, _w, _h), new StringFormat() { Alignment = StringAlignment.Center });





            _x = x;
            _y = y + _h / 2 + 5;



        }
        public static void DrawFraction(this Graphics e, string numerator, string denominator, int x, int y, bool numeratorRec = false, bool denominatorRec = false)
        {
            // Measure string.

            Font stringFont = new Font("Angsana New", 20);

            SizeF stringSize_numerator = e.MeasureString(numerator.ToString() + "   ", stringFont);
            SizeF stringSize_denominator = e.MeasureString(denominator.ToString() + "   ", stringFont);

            float w = ((stringSize_numerator.Width < stringSize_denominator.Width) ? stringSize_denominator.Width : stringSize_numerator.Width);
            int _x, _y, _w, _h;
            _x = x + 5 + Convert.ToInt32(w);
            _y = y + 2;
            _w = Convert.ToInt32(w) + 5;
            _h = 30;
            if (numeratorRec)
            {

                e.DrawRectangle(Pens.Black, new Rectangle(_x, _y, _w, _h));
            }
            else
            {
                e.DrawString(numerator.ToString(), stringFont, new SolidBrush(Color.Black), new Rectangle(_x, _y, _w, _h), new StringFormat() { Alignment = StringAlignment.Center });
            }

            e.DrawLine(new Pen(Brushes.Black, 2), _x, y + stringSize_numerator.Height - 5, _x + _w, y + stringSize_numerator.Height - 5);

            _y = y + _h;

            if (denominatorRec)
            {
                e.DrawRectangle(Pens.Black, new Rectangle(_x, _y + 10, _w, _h));
            }
            else
            {
                e.DrawString(denominator.ToString(), stringFont, new SolidBrush(Color.Black), new Rectangle(_x, _y, _w, _h), new StringFormat() { Alignment = StringAlignment.Center });

            }




        }
        public static void DrawTableFraction(this Graphics g, System.Drawing.Pen pen, int x, int y, int width, int height, int ColumnCounts, int Rowcounts, string a = "", string b = "", int count = 0)
        {
            g.DrawTable(pen, x, y, width, height, ColumnCounts, Rowcounts, count);

            int _x = x+ (width * (ColumnCounts + 1)) + 50;
            int _y = y+ (height * Rowcounts) / 2;

            g.DrawLine(new Pen(Brushes.Black, 4), _x, _y, _x + 40, _y);

        }

    }
}
