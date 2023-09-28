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
  public partial  class op003PlusMinus_Subdivision:prnControl
    {
        public op003PlusMinus_Subdivision()
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
            ReportHeader = "การทดสอบ เกี่ยวกับ ความสัมพันธ์ของจำนวน แบบส่วนย่อย – ส่วนรวม";
            ReportToppic = "เขียนตัวเลขในภาพแสดงความสัมพันธ์ของจำนวนแบบส่วนย่อย-ส่วนรวม";
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
            this.groupBox1.Size = new System.Drawing.Size(250, 699);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(1202, 699);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1196, 677);
            // 
            // prnMath_02OperOper01Subdivision02Num
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "prnMath_02OperOper01Subdivision02Num";
            this.Size = new System.Drawing.Size(1452, 699);
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

            int yC = 150;
            int xC = 100;
            int w = 80, h = 50;

            xC = 150;


            for (int i = 1; i <= 4; i++)
            {
                string str_a, str_b, str_c;
                int a, b, c, _c;
                a = RandomNumber.Randomnumber(minValue, maxValue);
                b = RandomNumber.Randomnumber(minValue, maxValue);
                c = a + b;
                _c = RandomNumber.Randomnumber(0, 1000);
                if (_c <= 300)
                {
                    str_a = ""; str_b = b.ToString(); str_c = c.ToString();
                }
                else if (_c > 300 && _c <= 700)
                {
                    str_a = a.ToString(); str_b = ""; str_c = c.ToString();
                }
                else
                {
                    str_a = a.ToString(); str_b = b.ToString(); str_c = "";
                }

                e.Graphics.DrawTriEllipseString(str_c, str_a, str_b, xC, yC, 60, 60, "");


                xC = xC + 300;

                a = RandomNumber.Randomnumber(minValue, maxValue);
                b = RandomNumber.Randomnumber(minValue, maxValue);
                c = a + b;
                _c = RandomNumber.Randomnumber(0, 1000);
                if (_c <= 300)
                {
                    str_a = ""; str_b = b.ToString(); str_c = c.ToString();
                }
                else if (_c > 300 && _c <= 700)
                {
                    str_a = a.ToString(); str_b = ""; str_c = c.ToString();
                }
                else
                {
                    str_a = a.ToString(); str_b = b.ToString(); str_c = "";
                }

                e.Graphics.DrawTriEllipseString(str_c, str_a, str_b, xC, yC, 60, 60, "");

                xC = 150;
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
