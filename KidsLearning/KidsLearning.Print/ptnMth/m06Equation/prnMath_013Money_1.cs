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
using System.Text.RegularExpressions;

namespace KidsLearning.Print.ptnMth
{
  public partial  class prnMath_013Money_1:prnControl
    {
        public prnMath_013Money_1()
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
            ReportHeader = "การทดสอบ เงินๆ ทองๆ ";
            ReportToppic = "ให้แสดงวิธีทำ การรวมยอดเงิน ต่อไปนี้";
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
            this.groupBox1.Size = new System.Drawing.Size(250, 640);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(1207, 640);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1201, 618);
            // 
            // prnMath_93Money_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "prnMath_93Money_1";
            this.Size = new System.Drawing.Size(1457, 640);
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

            int yC = 150, xC = 100;
            int w = 100, h = 35;


            // DrawTable
            for (int ip = 0; ip <= 13; ip++)
            {
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC + 600, yC);
                yC += h;
            }

            yC = 150; xC = 100;
            e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC, yC + h * 13);

            e.Graphics.DrawString("  รายการ   ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5); xC += 120;
            e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC, yC + h * 13);
            e.Graphics.DrawString("   จำนวน   ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5); xC += 100;
            e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC, yC + h * 13);
            e.Graphics.DrawString("            สมการ ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5); xC += 220;
            e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC, yC + h * 13);
            e.Graphics.DrawString("  รวมยอดเงิน  ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5);
            xC = 100;
            e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 600, yC, xC + 600, yC + h * 13);
            xC = 100;
            yC += h;
            for (int ip = 1; ip <= 12; ip++)
            {
                xC = 100;
                string m = Exts.RandomMoney;
                e.Graphics.DrawString(m, fontDetail, new SolidBrush(Color.Black), xC, yC + 5);
                xC += 120;
                e.Graphics.DrawString(RandomNumber.Randomnumber(1, 10).ToString() + "  " +
                    new Regex(@"(^.*?\s)\d+", RegexOptions.Compiled).Match(m).Groups[1].Value, fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5);

                yC += h;
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
