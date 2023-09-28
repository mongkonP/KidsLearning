using KidsLearning.Classed.Exten;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Drawings;
using TORServices.Maths;
namespace KidsLearning.Print.ptnMth.m01Num
{
   public partial class num05_PowerbyTen_01 : prnControl
    {

        public num05_PowerbyTen_01()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(209, 591);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(203, 114);
            // 
            // bntPrint
            // 
            this.bntPrint.Location = new System.Drawing.Point(10, 61);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(146, 27);
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(69, 24);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 27);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(209, 0);
            this.groupBox2.Size = new System.Drawing.Size(952, 591);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(946, 572);
            // 
            // num013_PowerbyTen_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "num013_PowerbyTen_01";
            this.Size = new System.Drawing.Size(1161, 591);
            this.Load += new System.EventHandler(this.prn_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #region Variables

        int minValue = 10, maxValue = 200;
        Random random = new Random();
        #endregion


        Random r = new Random();

        private void prn_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "หาเลขยกกำลังของ 10 ";
            printPreviewControl1.Document = this.printDocument1;
        }



        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail

            int yC = 150, xC = 100;

            string sss;



            for (int i = 0; i < 6; i++)
            {

                double a;
                int b;
               

                
                    a = (r.Next(1,1000) + r.NextDouble());
                    b = RandomNumber.Randomnumber(-10, 10);
                    sss = $"{a.ToString("N"+r.Next(0,5))}x{(10 + "^" + b).ToSuperscriptNumber()} = __________________________________________";

                
                

                e.Graphics.DrawString(sss, new Font("Segoe UI", 20), new SolidBrush(Color.Black), xC, yC);
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
