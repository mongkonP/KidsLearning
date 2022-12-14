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
  public partial  class op007MultipliedDivide_04SubSection_Detail : prnControl
    {
        public op007MultipliedDivide_04SubSection_Detail()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
        
        }

        #region Variables

        int minValue = 1, maxValue = 15;

        #endregion
        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "เขียนความสัมพันธ์ของจำนวน แบบส่วนย่อย-ส่วนรวม x,÷ และ กระจายความสัมพันธ์";
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
            this.groupBox1.Size = new System.Drawing.Size(250, 676);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(953, 676);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(947, 654);
            // 
            // op007MultipliedDivide_04SubSection_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "op007MultipliedDivide_04SubSection_Detail";
            this.Size = new System.Drawing.Size(1203, 676);
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

          //  e.Graphics.DrawImage(TORServices.Drawings.exImage.ResizeImage(Image.FromFile(Application.StartupPath + @"\File\PicSam\Sam_sub-section_01_Detail.png"), 700, 180), 50, 100);
            xC = 150;
            yC = yC + 50;
            for (int i = 1; i <= 4; i++)
            {

                int a = RandomNumberGenerator.GetInt32(minValue, maxValue);
                int b = RandomNumberGenerator.GetInt32(minValue, maxValue);
                string _a, _b, _c;

                switch (RandomNumberGenerator.GetInt32(1, 3000))
                {
                    case <=1000:
                        _a = "";_b = b.ToString();_c = (a * b).ToString();
                        break;
                    case >1000 and <=2000:
                        _a = a.ToString(); _b = ""; _c = (a * b).ToString();
                        break;
                    default:
                        _a = a.ToString(); _b = b.ToString(); _c = "";
                        break;
                }

                e.Graphics.DrawTriEllipseString(_c, _b, _a, xC, yC, 80, 50);
                e.Graphics.DrawImage(TORServices.Drawings.exImage.ResizeImage(Image.FromFile(Application.StartupPath + @"\File\PicSam\Ex_sub-section_Detail.png"), 360, 150), xC + 250, yC-30);


                yC = yC + 200;


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
