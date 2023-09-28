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

namespace KidsLearning.Print.ptnMth.m01Num
{
    public partial class num003CountNumberPicture : prnControl
    {
        public num003CountNumberPicture()
        {
            InitializeComponent();
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
            // num003CountNumberPicture
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            Name = "num003CountNumberPicture";
            Size = new Size(1526, 655);
            Load += prnMath_01_Num_01_1to15_2_Load;
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #region Variables

        int minValue = 1, maxValue = 15;

        #endregion
        private void prnMath_01_Num_01_1to15_2_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "นับจำนวนตามรูปภาพ";
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

            xC = 150;
            yC = yC + 50;

            for (int i = 1; i <= 3; i++)
            {

                int a = RandomNumber.Randomnumber(minValue, maxValue);

                e.Graphics.DrawImageFromNumber(xC, yC, a, 200, 250, true);
                xC = xC + 350;
                a = RandomNumber.Randomnumber(minValue, maxValue);
                e.Graphics.DrawImageFromNumber(xC, yC, a, 200, 250, true);
                xC = 150;
                yC = yC + 300;

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
