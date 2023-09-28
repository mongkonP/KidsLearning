using KidsLearning.Classed.Exten;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TORServices.Maths;
using static TORServices.Maths.extMath;
using TORServices.Drawings;

namespace KidsLearning.Print.ptnMth.m02OP
{
  public partial  class op007MultipliedDivide_03SubSection : prnControl
    {
        public op007MultipliedDivide_03SubSection()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
        
        }

        #region Variables

        int minValue = 1, maxValue = 10;

        #endregion
        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "เขียนความสัมพันธ์ของจำนวน แบบส่วนย่อย-ส่วนรวม x,÷";
            iPage = 1;
            iPageAll = 1;
            
            printPreviewControl1.Document = this.printDocument1;
        }

        private void InitializeComponent()
        {
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(250, 593);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(1256, 593);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1250, 571);
            // 
            // op007MultipliedDivide_03SubSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "op007MultipliedDivide_03SubSection";
            this.Size = new System.Drawing.Size(1506, 593);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail

          
            int yC = 100;
            int xC = 100;
            int w = 80, h = 50;

           // e.Graphics.DrawImage(TORServices.Drawings.exImage.ResizeImage(Image.FromFile(Application.StartupPath + @"\File\PicSam\Sam_sub-section.png"), 700, 180), 50, 100);
            xC = 150;
            yC = yC + 50;
            for (int i = 1; i <= 3; i++)
            {

                int a = RandomNumber.Randomnumber(minValue, maxValue);
                int b = RandomNumber.Randomnumber(minValue, maxValue);
                string _a, _b, _c;

                switch (RandomNumber.Randomnumber(1, 3000))
                {
                    case int n when n <=1000:
                        _a = "";_b = b.ToString();_c = (a * b).ToString();
                        break;
                    case int n when n  > 1000 && n <=2000:
                        _a = a.ToString(); _b = ""; _c = (a * b).ToString();
                        break;
                    default:
                        _a = a.ToString(); _b = b.ToString(); _c = "";
                        break;
                }

                e.Graphics.DrawTriEllipseString(_c, _b, _a, xC, yC, 80, 50);

                a = RandomNumber.Randomnumber(minValue, maxValue);
                b = RandomNumber.Randomnumber(minValue, maxValue);
                switch (RandomNumber.Randomnumber(1, 3000))
                {
                    case int n when n  <= 1000:
                        _a = ""; _b = b.ToString(); _c = (a * b).ToString();
                        break;
                    case int n when n  > 1000 && n <= 2000:
                        _a = a.ToString(); _b = ""; _c = (a * b).ToString();
                        break;
                    default:
                        _a = a.ToString(); _b = b.ToString(); _c = "";
                        break;
                }

                e.Graphics.DrawTriEllipseString(_c, _b, _a, xC + 300, yC, 80, 50);


                yC = yC + 250;


            }


            #endregion



            if (iPage > iPageAll - 1)
            {
                bNewPage = false;
                bMorePagesToPrint = false;
            }

            if (bNewPage)
            {
                printDocumentNewPage(sender, e);
            }

            iPage++;

            //If more lines exist, print another page.
            e.HasMorePages = (bMorePagesToPrint) ? true : false;
        }

    }
}
