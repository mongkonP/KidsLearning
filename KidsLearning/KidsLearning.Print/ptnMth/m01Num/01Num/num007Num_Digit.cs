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
    public partial class num007Num_Digit : prnControl
    {
        public num007Num_Digit()
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
            ReportToppic = "บอกค่าของเลขโดดในแต่ละหลัก ของจำนวนนับ";
            iPage = 1;
            iPageAll = 1;

            printPreviewControl1.Document = this.printDocument1;
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
            // panel2
            // 
            panel2.Size = new Size(244, 344);
            // 
            // bntPrint
            // 
            bntPrint.Location = new Point(15, 265);
            // 
            // label2
            // 
            label2.Location = new Point(173, 226);
            // 
            // txtPageCount
            // 
            txtPageCount.Location = new Point(83, 223);
            // 
            // label1
            // 
            label1.Location = new Point(15, 226);
            // 
            // groupBox2
            // 
            groupBox2.Size = new Size(1276, 655);
            // 
            // printPreviewControl1
            // 
            printPreviewControl1.Size = new Size(1270, 633);
            // 
            // num007Num_Digit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            Name = "num007Num_Digit";
            Size = new Size(1526, 655);
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail

            int yC = 120, xC = 150;

            for (int i = 1; i <= 4; i++)
            {

                int a = RandomNumber.Randomnumber(1000, 1000000);
                e.Graphics.DrawDigitMillion(fontExpression, a, xC, yC);

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
