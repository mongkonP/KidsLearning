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

namespace KidsLearning.Print.ptnMth.m01Num
{
    public partial class num001Num002CountandCircleNumber_01 : prnControl
    {
        public num001Num002CountandCircleNumber_01()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);

        }
        private void InitializeComponent()
        {
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Size = new Size(250, 655);
            // 
            // groupBox2
            // 
            groupBox2.Size = new Size(1276, 655);
            // 
            // printPreviewControl1
            // 
            printPreviewControl1.Size = new Size(1270, 633);
            // 
            // num001Num002CountandCircleNumber_01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            Name = "num001Num002CountandCircleNumber_01";
            Size = new Size(1526, 655);
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #region Variables

        int minValue = 1, maxValue = 15;

        #endregion
        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "นับ และ ระบายสีวงกลมให้เท่ากับจำนวนที่นับ";
            iPage = 1;
            iPageAll = 1;
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            printPreviewControl1.Document = this.printDocument1;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail

            int yC = 100;
            int xC = 100;
            int w = 80, h = 50;

            // e.Graphics.DrawString($"นับ และ ระบายสีวงกลมให้เท่ากับจำนวนที่นับ", fontDetail, new SolidBrush(Color.Black), xC, yC);

            xC = 150;
            yC += 100;

            for (int i = 1; i < 6; i++)
            {
                int Anw = RandomNumber.Randomnumber(1, 10);

                e.Graphics.DrawImage(KidsLearning.Classed.Exten.ExtGraphics_Maths.ImageFromNumber(Anw, 80, 80), xC, yC);
                e.Graphics.DrawRectangleEllipses(xC + 120, yC + 20, 40, 40, 10);
                yC = yC + 180;

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
