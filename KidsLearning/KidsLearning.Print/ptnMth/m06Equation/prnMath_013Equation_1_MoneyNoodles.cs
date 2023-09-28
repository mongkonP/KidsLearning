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
using KidsLearning.Classed;

namespace KidsLearning.Print.ptnMth
{
  public partial  class prnMath_013Equation_1_MoneyNoodles:prnControl
    {
        public prnMath_013Equation_1_MoneyNoodles()
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
            ReportHeader = "การทดสอบ เกี่ยวกับ สมการ ";
            ReportToppic = "ให้เขียนสมการ พร้อมทั้งหาค่า จากประโยค ต่อไปนี้";
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
            this.groupBox1.Size = new System.Drawing.Size(214, 614);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(208, 103);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(1192, 614);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1186, 595);
            // 
            // prnMath_013Equation_1_MoneyNoodles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "prnMath_013Equation_1_MoneyNoodles";
            this.Size = new System.Drawing.Size(1406, 614);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private bool HaveGuideline;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail

            int yC = 120, xC = 100;
           // int w = 100, h = 40;
            for (int i = 0; i < 8; i++)
            {
                List<string> strType_ = new List<string>();
                strType_.AddRange(Exts.listNoodles);

                // int cAll = RandomNumber.Randomnumber(0, 5);
                string name = Exts.RandomManName;
                int c = (strType_.Count - 1 > 0) ? RandomNumber.Randomnumber(0, strType_.Count ) : 0;
                string s = strType_[c];
                int _mc = RandomNumber.Randomnumber(1, 5);
                string _return = name + " กินก๊วยเตี๋ยว โดยสั่ง " + s + _mc + " ชาม  คิดเป็นเงินเท่าใด ? \n     สมการ";
                e.Graphics.DrawString(_return, fontDetail, new SolidBrush(Color.Black), xC + 10, yC);

                if (HaveGuideline)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(xC + 95, yC + 30, 100, 30));
                    e.Graphics.DrawString(" x ", fontDetail, new SolidBrush(Color.Black), xC + 195, yC + 30);
                    e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(xC + 220, yC + 30, 100, 30));
                    e.Graphics.DrawString(" = ", fontDetail, new SolidBrush(Color.Black), xC + 320, yC + 30);
                    e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(xC + 350, yC + 30, 100, 30));
                }
                else
                {
                    e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 90, yC + 60, xC + 700, yC + 60);
                }

                yC += 100;

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
