using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsLearning.Classed.Exten
{
    public static partial class ExtGraphics_Maths
    {

        public static void DrawMorethanLess(this Graphics e, Font fontDetail, float a, float b, int x, int y)
        {
            // int _x = (int)(x -e.MeasureString(a + " ", fontDetail).Width);
            // Measure string.
            SizeF stringSize = new SizeF();
            stringSize = e.MeasureString(a.ToString("n0") + " ", fontDetail);


            e.DrawString(a.ToString("n0") + " ", fontDetail, Brushes.Black, x - stringSize.Width, y);
            e.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(x + 20, y, 30, 30));
            e.DrawString(b.ToString("n0") + " ", fontDetail, Brushes.Black, x + 70, y);


        }


    }
}
