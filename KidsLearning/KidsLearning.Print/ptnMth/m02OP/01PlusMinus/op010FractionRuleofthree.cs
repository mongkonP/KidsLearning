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
  public partial  class op010FractionRuleofthree:prnControl
    {
        public op010FractionRuleofthree()
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
            ReportHeader = "การทดสอบ เกี่ยวกับ บัญญัติไตรยางศ์ ";
            ReportToppic = "ให้เขียนเศษส่วนให้เป็น สมการ และ หาค่าตัวแปร";
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
            this.groupBox1.Size = new System.Drawing.Size(250, 683);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(964, 683);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(958, 661);
            // 
            // op010FractionRuleofthree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "op010FractionRuleofthree";
            this.Size = new System.Drawing.Size(1214, 683);
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

            // System.Windows.Forms.MessageBox.Show("page " + iPage);
            int yC = 120, xC = 100;
            int w = 100, h = 40;
            for (int i = 0; i < 6; i++)
            {

                int a = RandomNumber.Randomnumber(1, 10);
                int b = a * RandomNumber.Randomnumber(1, 5);
                int _e = RandomNumber.Randomnumber(1, 5);
                int d = _e * b;
                int c = a * _e;
                string _a = "", _b = "", _c = "", _d = "";
                int f = RandomNumber.Randomnumber(1, 1000);
                if (f <= 250)
                {
                    _a = "A"; _b = b.ToString(); _c = c.ToString(); _d = d.ToString();
                }
                else if (f > 250 && f <= 500)
                {
                    _a = a.ToString(); _b = "B"; _c = c.ToString(); _d = d.ToString();
                }
                else if (f > 500 && f <= 750)
                {
                    _a = a.ToString(); _b = b.ToString(); _c = "C"; _d = d.ToString();
                }
                else if (f > 750)
                {
                    _a = a.ToString(); _b = b.ToString(); _c = c.ToString(); _d = "D";
                }
                e.Graphics.DrawFraction(_a, _b, xC + 10, yC);
                e.Graphics.DrawString(" = ", new Font("Angsana New", 20), new SolidBrush(Color.Black), xC + 100, yC + 15);
                e.Graphics.DrawFraction(_c, _d, xC + 110, yC);
                e.Graphics.DrawLine(new Pen(Brushes.Black, 2), xC + 250, yC + 25, 700, yC + 25);
                e.Graphics.DrawLine(new Pen(Brushes.Black, 2), xC + 250, yC + 55, 700, yC + 55);
                e.Graphics.DrawLine(new Pen(Brushes.Black, 2), xC + 250, yC + 85, 700, yC + 85);
                e.Graphics.DrawLine(new Pen(Brushes.Black, 2), xC + 250, yC + 115, 700, yC + 115);
                yC += 150;

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
