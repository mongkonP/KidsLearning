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

namespace KidsLearning.Print.ptnMth.m01Num
{
   public partial class num010NumSubdivision : prnControl
    {

        public num010NumSubdivision()
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
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(244, 607);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            this.panel2.Size = new System.Drawing.Size(238, 315);
            // 
            // bntPrint
            // 
            this.bntPrint.Location = new System.Drawing.Point(14, 247);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(172, 208);
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(82, 205);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 208);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(244, 0);
            this.groupBox2.Size = new System.Drawing.Size(1137, 607);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1131, 585);
            // 
            // num010NumSubdivision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "num010NumSubdivision";
            this.Size = new System.Drawing.Size(1381, 607);
            this.Load += new System.EventHandler(this.prnMath_01_Num_01_1to50_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #region Variables

        int minValue = 10, maxValue = 200;
   
        #endregion



   
        private void prnMath_01_Num_01_1to50_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "ตัวประกอบของจำนวนนับ";
            printPreviewControl1.Document = this.printDocument1;
        }



        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail

            int yC = 150, xC = 100;
            int w = 50, h = 35,wr = 25;
            int aa;
            for (int i = 0; i < 4; i++)
            {
                aa = RandomNumberGenerator.GetInt32(minValue, maxValue);
                e.Graphics.DrawRectangleString(aa.ToString(), fontDetail, new Pen(Color.Black, 3), new Rectangle(xC, yC, w , h));


                for (int a = 1; a < 9; a++)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(xC + a*(w + wr), yC, w, h));
                    e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(xC + a * (w + wr), yC+2*h, w, h));

                    e.Graphics.DrawLine(new Pen(Color.Black, 3), xC + a * (w + wr), yC + h / 2, xC + a * (w + wr) - wr, yC + h / 2);
                    
                    e.Graphics.DrawLine(new Pen(Color.Black, 3), xC+a*(w+wr)+w/2, yC + h , xC + a * (w + wr) + w / 2, yC + 2 * h);

                }

                e.Graphics.DrawString($"ดังนั้น {aa} สามารถนำมาแยกตัวประกอบได้เป็น \n _______________________________________________________", 
                    new Font("Angsana New", 18), new SolidBrush(Color.Black), xC, yC+ 4 * h ); 
                yC += 6*h + 10 ;

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
