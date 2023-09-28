using KidsLearning.Classed;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TORServices.Maths;

namespace KidsLearning.Print.ptnMth.m09Polynomial
{
    public partial class _01_Monomial_01 : prnControl
    {
        public _01_Monomial_01()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);

        }

        #region Variables



        #endregion

        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ เอกนาม ";
            ReportToppic = "ให้เติมข้อมูลในช่องว่าง ** ให้ใช้ / ในช่องที่เป็น เอกนาม และใช้ x ในช่องที่ไม่เป็นเอกนาม";
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
            // _01_Monomial_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "_01_Monomial_01";
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

            /* */

            #region _Draw Detail

            int yC = 150, xC = 100;
            int w = 100, h = 50;
            e.Graphics.DrawString($"นิพจน์", fontDetail, new SolidBrush(Color.Black), xC + 50, yC + 5);
            e.Graphics.DrawString($"สัมประสิทธิ์", fontDetail, new SolidBrush(Color.Black), xC + 230, yC + 5);
            e.Graphics.DrawString($"ดีกรี", fontDetail, new SolidBrush(Color.Black), xC + 400, yC + 5);
            e.Graphics.DrawString($"เป็น/ไม่เป็นเอกนาม", fontDetail, new SolidBrush(Color.Black), xC + 530, yC + 5);

            for (int row = 0; row < 15; row++)
            {
                e.Graphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(xC, yC, 200, h));
                e.Graphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(xC + 200, yC, 150, h));
                e.Graphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(xC + 350, yC, 150, h));
                e.Graphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(xC + 500, yC, 200, h));
               if (row > 0)
                {
                    string expression = TORServices.Maths.Expression.GenerateTerm(-10,21, RandomNumber.Randomnumber(0, 4),-4,5);
                    do { expression = TORServices.Maths.Expression.GenerateTerm(-10, 21, RandomNumber.Randomnumber(0, 4), -4, 5); } while (string.IsNullOrEmpty(expression.Trim()));
                    e.Graphics.DrawString(expression, fontExpression, new SolidBrush(Color.Black), xC + 10, yC + 5);
                }
                yC += h; // Move to the next row with some vertical spacing
                xC = 100; // Reset the column position for the next row
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
