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

        public static void DrawDigitMillion(this Graphics e, Font fontDetail, int Number, int x, int y)
        {
            
            SizeF stringSize = new SizeF();
            stringSize = e.MeasureString(Number.ToString("n0") + " ", fontDetail);


            e.DrawString(" Number: " +  Number.ToString("n0") + " ", fontDetail, Brushes.Black, x - stringSize.Width, y);
            e.DrawFillRectangleString(" หน้วยนับ ", fontDetail, null, new Pen(Color.Black, 2), new Rectangle(x + 20, y + 30, 70, Convert.ToInt32(stringSize.Height + 10)));
            e.DrawFillRectangleString(" หลักล้าน ", fontDetail, null, new Pen(Color.Black, 2), new Rectangle(x + 90, y+30, 70, Convert.ToInt32( stringSize.Height+10)));
            e.DrawFillRectangleString(" หลักแสน ", fontDetail, null, new Pen(Color.Black, 2), new Rectangle(x + 160, y + 30, 70, Convert.ToInt32(stringSize.Height + 10)));
            e.DrawFillRectangleString(" หลักหมื่น ", fontDetail, null, new Pen(Color.Black, 2), new Rectangle(x + 230, y + 30, 70, Convert.ToInt32(stringSize.Height + 10)));
            e.DrawFillRectangleString(" หลักพัน ", fontDetail, null, new Pen(Color.Black, 2), new Rectangle(x + 300, y + 30, 70, Convert.ToInt32(stringSize.Height + 10)));
            e.DrawFillRectangleString(" หลักร้อย ", fontDetail, null, new Pen(Color.Black, 2), new Rectangle(x + 370, y + 30, 70, Convert.ToInt32(stringSize.Height + 10)));
            e.DrawFillRectangleString(" หลักสิบ ", fontDetail, null, new Pen(Color.Black, 2), new Rectangle(x + 440, y + 30, 70, Convert.ToInt32(stringSize.Height + 10)));
            e.DrawFillRectangleString(" หลักหน่วย", fontDetail, null, new Pen(Color.Black, 2), new Rectangle(x + 510, y + 30, 70, Convert.ToInt32(stringSize.Height + 10)));


            e.DrawFillRectangleString(" เลขโดด ", fontDetail, null, new Pen(Color.Black, 2), new Rectangle(x + 20, y + 30+ Convert.ToInt32(stringSize.Height + 10), 70, Convert.ToInt32(stringSize.Height + 10)));
            e.DrawFillRectangleString("  ", fontDetail, null, new Pen(Color.Black, 2), new Rectangle(x + 90, y + 30+ Convert.ToInt32(stringSize.Height + 10), 70, Convert.ToInt32(stringSize.Height + 10)));
            e.DrawFillRectangleString("  ", fontDetail, null, new Pen(Color.Black, 2), new Rectangle(x + 160, y + 30+Convert.ToInt32(stringSize.Height + 10), 70, Convert.ToInt32(stringSize.Height + 10)));
            e.DrawFillRectangleString("  ", fontDetail, null, new Pen(Color.Black, 2), new Rectangle(x + 230, y + 30 + Convert.ToInt32(stringSize.Height + 10), 70, Convert.ToInt32(stringSize.Height + 10)));
            e.DrawFillRectangleString("  ", fontDetail, null, new Pen(Color.Black, 2), new Rectangle(x + 300, y + 30 + Convert.ToInt32(stringSize.Height + 10), 70, Convert.ToInt32(stringSize.Height + 10)));
            e.DrawFillRectangleString("  ",fontDetail, null, new Pen(Color.Black, 2), new Rectangle(x + 370, y + 30 + Convert.ToInt32(stringSize.Height + 10), 70, Convert.ToInt32(stringSize.Height + 10)));
            e.DrawFillRectangleString("  ", fontDetail, null, new Pen(Color.Black, 2), new Rectangle(x + 440, y + 30 + Convert.ToInt32(stringSize.Height + 10), 70, Convert.ToInt32(stringSize.Height + 10)));
            e.DrawFillRectangleString(" ", fontDetail, null, new Pen(Color.Black, 2), new Rectangle(x + 510, y + 30 + Convert.ToInt32(stringSize.Height + 10), 70, Convert.ToInt32(stringSize.Height + 10)));

            e.DrawFillRectangleString(" คำอ่าน ", fontDetail, null, new Pen(Color.Black, 2), new Rectangle(x + 20, y + 30 + 2*Convert.ToInt32(stringSize.Height + 10), 70, Convert.ToInt32(stringSize.Height + 10)));
            e.DrawFillRectangleString("  ", fontDetail, null, new Pen(Color.Black, 2), new Rectangle(x + 90, y + 30 + 2*Convert.ToInt32(stringSize.Height + 10), 490, Convert.ToInt32(stringSize.Height + 10)));
            //new SolidBrush(Color.Black)

        }

        public static void DrawDigitTrillion(this Graphics e, Font fontDetail, float a, float b, int x, int y)
        {

            SizeF stringSize = new SizeF();
            stringSize = e.MeasureString(a.ToString("n0") + " ", fontDetail);


            e.DrawString(a.ToString("n0") + " ", fontDetail, Brushes.Black, x - stringSize.Width, y);
            e.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(x + 20, y, 30, 30));
            e.DrawString(b.ToString("n0") + " ", fontDetail, Brushes.Black, x + 70, y);


        }
    }
}
