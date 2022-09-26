using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TORServices.Maths;
using TORServices.Drawings;
namespace KidsLearning.Classed.Exten
{
    public static partial class ExtGraphics_Maths
    {


        public static void DrawTableNumberText(this Graphics g, int x, int y, int num, bool numA, bool numTh, bool numTxt)
        {
            int _x, _y;
            _x = x; _y = y;
            Pen pen = new Pen(Color.Black, 3);


            g.DrawRectangleString("เลขอารบิก", pen, new Rectangle(_x, _y, 150, 40));
            g.DrawRectangleString((numA) ? num.ToString() : "", pen, new Rectangle(_x + 150, _y, 450, 40));
            _y += 40;
            g.DrawRectangleString("เลขไทย", pen, new Rectangle(_x, _y, 150, 40));
            g.DrawRectangleString((numTh) ? num.ToArabicAndThai(extMath.ArabicAndThaiObtion.ArabicToThai) : "", pen, new Rectangle(_x + 150, _y, 450, 40));
            _y += 40;
            g.DrawRectangleString("คำอ่าน", pen, new Rectangle(_x, _y, 150, 40));
            g.DrawRectangleString((numTxt) ? num.ToArabicToThaiText() : "", pen, new Rectangle(_x + 150, _y, 450, 40));


        }


    }
}
