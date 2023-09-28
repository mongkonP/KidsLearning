using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KidsLearning.Print.ptnPhy
{
    public partial class prnPhysic_01_Significant_02 : prnControl
    {
        public prnPhysic_01_Significant_02()
        {
            InitializeComponent();
            Load += new EventHandler(frm_Load);
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            filePrintPre = "File\\Book\\Sci\\significant figure.pdf";
        }

        #region Variables
        Random random = new Random();
        int minValue = 1, maxValue = 15;

        #endregion
        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ เลขนัยสำคัญ";
            ReportToppic = "หาคำตอบต่อไปนี้ตาม เลขนัยสำคัญ";
            iPage = 1;
            iPageAll = 1;

            printPreviewControl1.Document = printDocument1;
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
            groupBox1.Size = new Size(250, 576);
            // 
            // groupBox2
            // 
            groupBox2.Size = new Size(868, 576);
            // 
            // printPreviewControl1
            // 
            printPreviewControl1.Size = new Size(862, 554);
            // 
            // prnPhysic_01_Significant_02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            Name = "prnPhysic_01_Significant_02";
            Size = new Size(1118, 576);
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

            int yC = 150, xC = 100;
            int w = 50, h = 35, wr = 25;
            double aa;
            for (int i = 0; i < 5; i++)
            {

                e.Graphics.DrawString($" {TORServices.Maths.MathFunction.GenerateOperator(1.00,20.00)} ",
                    new Font("Angsana New", 18), new SolidBrush(Color.Black), xC, yC);

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
            e.HasMorePages = bMorePagesToPrint ? true : false;
        }

    }
}
