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
  public partial  class num009Fraction_02Compare:prnControl
    {
        public num009Fraction_02Compare()
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
            ReportToppic = "เขียนเศษส่วน และ ใส่เครื่องหมาย < > =  ในช่องสี่เหลี่ยม";
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
            this.groupBox1.Size = new System.Drawing.Size(250, 667);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(694, 667);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(688, 645);
            // 
            // num009Fraction_02Compare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "num009Fraction_02Compare";
            this.Size = new System.Drawing.Size(944, 667);
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

            List<int> Nums = new List<int>();
            int yC = 100;
            int xC = 100;
            int w = 30, h = 30;
            Pen pen = new Pen(Color.Black, 2);
            SolidBrush solidBrush = new SolidBrush(Color.White);

            xC = 150;
            yC = yC + 30;
            Font font = new Font("Arial", 24, FontStyle.Bold);

            for (int i = 1; i <= 5; i++)
            {

                int a = RandomNumber.Randomnumber(3, 6);
                int b = RandomNumber.Randomnumber(3, 6);
                int c = RandomNumber.Randomnumber(1, a * b);


                e.Graphics.DrawTable(pen, xC, yC, w, h, a, b, c);

                e.Graphics.DrawLine(new Pen(Brushes.Black, 3), xC + 200, yC + (h * b) / 2, xC + 240, yC + (h * b) / 2);

                c = RandomNumber.Randomnumber(1, a * b);
                e.Graphics.DrawTable(pen, xC+400, yC, w, h, a, b, c);
                e.Graphics.DrawLine(new Pen(Brushes.Black, 3), xC + 310, yC + (h * b) / 2, xC + 350, yC + (h * b) / 2);

                // Draw rectangle to screen.
                e.Graphics.DrawRectangle(new Pen(Color.Black, 3), new Rectangle(xC + 250, yC + (h * b) / 2 - 25, 50, 50));
                yC = yC + b * h + 50;

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
