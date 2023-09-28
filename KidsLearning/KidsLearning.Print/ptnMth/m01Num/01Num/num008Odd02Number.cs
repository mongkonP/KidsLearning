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
  public partial  class num008Odd02Number:prnControl
    {
        public num008Odd02Number()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
        
        }

        #region Variables

        int minValue = 1, maxValue = 15;

        #endregion
        private Classed.Controls.NumberSelect numberSelect1;

        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "ให้เติม คู่ หรือ คี่ ในช่องว่าง";
            iPage = 1;
            iPageAll = 1;

            minValue = Convert.ToInt32(numberSelect1.Minimum);
            maxValue = Convert.ToInt32(numberSelect1.Maximum);
            printPreviewControl1.Document = this.printDocument1;
        }

        private void InitializeComponent()
        {
            this.numberSelect1 = new KidsLearning.Classed.Controls.NumberSelect();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numberSelect1);
            this.groupBox1.Size = new System.Drawing.Size(493, 602);
            this.groupBox1.Controls.SetChildIndex(this.numberSelect1, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel2, 0);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 317);
            this.panel2.Size = new System.Drawing.Size(487, 119);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(493, 0);
            this.groupBox2.Size = new System.Drawing.Size(871, 602);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(865, 580);
            // 
            // numberSelect1
            // 
            this.numberSelect1.Dock = System.Windows.Forms.DockStyle.Top;
            this.numberSelect1.Location = new System.Drawing.Point(3, 19);
            this.numberSelect1.Name = "numberSelect1";
            this.numberSelect1.Size = new System.Drawing.Size(487, 298);
            this.numberSelect1.TabIndex = 2;
            this.numberSelect1.NumberSelectChanged += new System.EventHandler(this.numberSelect1_NumberSelectChanged);
            this.numberSelect1.MouseCaptureChanged += new System.EventHandler(this.numberSelect1_MouseCaptureChanged);
            // 
            // num008Odd02Number
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "num008Odd02Number";
            this.Size = new System.Drawing.Size(1364, 602);
            this.Load += new System.EventHandler(this.prnMath_01Num07Odd02Number_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void numberSelect1_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void numberSelect1_NumberSelectChanged(object sender, EventArgs e)
        {
            minValue = Convert.ToInt32(numberSelect1.Minimum);
            maxValue = Convert.ToInt32(numberSelect1.Maximum);
            printPreviewControl1.Document = this.printDocument1;
        }

        private void prnMath_01Num07Odd02Number_Load(object sender, EventArgs e)
        {
            minValue = Convert.ToInt32(numberSelect1.Minimum);
            maxValue = Convert.ToInt32(numberSelect1.Maximum);
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
            
            for (int i = 0; i <= 10; i++)
            {

                xC = 100;
                e.Graphics.DrawRectangleString(RandomNumber.Randomnumber(minValue, maxValue).ToString(), fontExpression, new Pen(Color.Black, 2), new Rectangle(xC, yC, w + 30, h));
                e.Graphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(xC + w + 30, yC, w, h));

                xC = xC + 2 * w + 60;
                e.Graphics.DrawRectangleString(RandomNumber.Randomnumber(minValue, maxValue).ToString(), fontExpression, new Pen(Color.Black, 2), new Rectangle(xC, yC, w + 30, h));
                e.Graphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(xC + w + 30, yC, w, h));

                yC += 55;
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
