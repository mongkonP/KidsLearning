using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TORServices.Drawings;
using TORServices.Maths;
using TORServices.Maths.Sci;
namespace KidsLearning.Classed.Exten
{
    public static partial class ExtSciDraw
    {

        //Ω ±

        //https://th.mouser.com/technical-resources/conversion-calculators/resistor-color-code-calculator
        private static List<string> digitOptions = new List<string>() { "สีดำ", "สีน้ำตาล", "สีแดง", "สีส้ม", "สีเหลือง", "สีเขียว", "สีน้ำเงิน", "สีม่วง", "สีเทา", "สีขาว" };
        private static List<string> multiplierOptions = new List<string>() { "สีเงิน|0.01", "สีทอง|0.1", "สีดำ|1", "สีน้ำตาล|10", "สีแดง|100", "สีส้ม|1000", "สีเหลือง|10000", "สีเขียว|100000", "สีน้ำเงิน|10000000", "สีม่วง|10000000" };
        private static List<string> toleranceOptions = new List<string>() { "สีเงิน| 10%", "สีทอง| 5%","สีน้ำตาล| 1%", "สีแดง| 2%", "สีเขียว| 0.5%", "สีน้ำเงิน| 0.25%", "สีม่วง| 0.1%" };
        private static  Font stringFont = new Font("Angsana New", 20);
        public static void DrawResistor01(this Graphics e,  int x, int y)
        {
           
            
                if (RandomNumber.Randomnumber(0, 1000) < 500)
                {
                    e.DrawImage(Image.FromFile(@System.Windows.Forms.Application.StartupPath + @"\File\PIC\Sci\resistorBlank_4.png"), x, y);
                    e.DrawString($"สีแถบ {digitOptions[RandomNumber.Randomnumber(0, digitOptions.Count)]}/" +
                                     $"{digitOptions[RandomNumber.Randomnumber(0, digitOptions.Count)]}/" +
                                     $"{multiplierOptions[RandomNumber.Randomnumber(0, multiplierOptions.Count)].Split('|')[0]}/" +
                                     $"{toleranceOptions[RandomNumber.Randomnumber(0, toleranceOptions.Count)].Split('|')[0]}", stringFont, Brushes.Black, x + 10, y + 140);

                }
                else
                {
                    e.DrawImage(Image.FromFile(@System.Windows.Forms.Application.StartupPath + @"\File\PIC\Sci\resistorBlank_5.png"), x, y);
                    e.DrawString($"สีแถบ {digitOptions[RandomNumber.Randomnumber(0, digitOptions.Count)]}/" +
                                      $"{digitOptions[RandomNumber.Randomnumber(0, digitOptions.Count)]}/" +
                                      $"{digitOptions[RandomNumber.Randomnumber(0, digitOptions.Count)]}/" +
                                      $"{multiplierOptions[RandomNumber.Randomnumber(0, multiplierOptions.Count)].Split('|')[0]}/" +
                                      $"{toleranceOptions[RandomNumber.Randomnumber(0, toleranceOptions.Count)].Split('|')[0]}"
                                       , stringFont, Brushes.Black, x + 10, y + 140);

                }

            e.DrawString($"ความต้านทาน : ____________________" , stringFont, Brushes.Black, x + 10, y + 190);
        }
        public static void DrawResistor02(this Graphics e, int x, int y)
        {
            {

                if (RandomNumber.Randomnumber(0, 1000) < 500)
                {
                    e.DrawImage(Image.FromFile(@System.Windows.Forms.Application.StartupPath + @"\File\PIC\Sci\resistorBlank_4.png"), x, y);
                    e.DrawString($"สีแถบ ___________/___________/___________/___________", stringFont, Brushes.Black, x + 10, y + 140);
                    double ir = (double.Parse(RandomNumber.Randomnumber(0, digitOptions.Count )
                                    + "" + RandomNumber.Randomnumber(0, digitOptions.Count)
                                    + "" + RandomNumber.Randomnumber(0, digitOptions.Count)
                                   )) * double.Parse(multiplierOptions[RandomNumber.Randomnumber(0, multiplierOptions.Count)].Split('|')[1]);

                    e.DrawString($"ความต้านทาน : {ir.ToPrefix()}Ω ±{toleranceOptions[RandomNumber.Randomnumber(0, toleranceOptions.Count)].Split('|')[1]}", stringFont, Brushes.Black, x + 10, y + 190);

                }
                else
                {
                    e.DrawImage(Image.FromFile(@System.Windows.Forms.Application.StartupPath + @"\File\PIC\Sci\resistorBlank_5.png"), x, y);
                    e.DrawString($"สีแถบ ___________/___________/___________/___________/___________", stringFont, Brushes.Black, x + 10, y + 140);

                    double ir = (double.Parse(RandomNumber.Randomnumber(0, digitOptions.Count)
                                   + "" + RandomNumber.Randomnumber(0, digitOptions.Count)
                                   + "" + RandomNumber.Randomnumber(0, digitOptions.Count)
                                   + "" + RandomNumber.Randomnumber(0, digitOptions.Count)
                                  )) * double.Parse(multiplierOptions[RandomNumber.Randomnumber(0, multiplierOptions.Count)].Split('|')[1]);

                    e.DrawString($"ความต้านทาน : {ir.ToPrefix()}Ω ±{toleranceOptions[RandomNumber.Randomnumber(0, toleranceOptions.Count)].Split('|')[1]}", stringFont, Brushes.Black, x + 10, y + 190);

                }

            }

            

          

        }
      

    }
}
