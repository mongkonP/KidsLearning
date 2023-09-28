using KidsLearning.Classed;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KidsLearning.Print.ptnMth.m09Polynomial
{
    public partial class _01_Monomial_02 : prnControl
    {
        public _01_Monomial_02()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);

        }

        #region Variables



        #endregion

        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ พหุนาม ";
            ReportToppic = "ทำพหุนามต่อไปนี้ ให้สมบูรณ์";
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
            this.groupBox1.Size = new System.Drawing.Size(234, 614);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(228, 103);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(234, 0);
            this.groupBox2.Size = new System.Drawing.Size(1172, 614);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1166, 595);
            // 
            // _01_Monomial_02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "_01_Monomial_02";
            this.Size = new System.Drawing.Size(1406, 614);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void prnMath_01Num07Odd02Number_Load(object sender, EventArgs e)
        {

            printPreviewControl1.Document = this.printDocument1;
        }



        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
         {
             //Loop till all the grid rows not get printed
             if (bFirstPage) printDocumentNewPage(sender, e);


             #region _Draw Detail

             int yC = -50, xC = 100;
             int w = 100, h = 180;

             for (int row = 0; row < 6; row++)
             {

                 if (row > 0)
                 {
                     string expression = TORServices.Maths.Expression.GenerateExpressionMultiVariable();
                     e.Graphics.DrawString(expression, fontExpression, new SolidBrush(Color.Black), xC + 10, yC + 5);
                 }
                 yC += h;
                 xC = 100;
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
