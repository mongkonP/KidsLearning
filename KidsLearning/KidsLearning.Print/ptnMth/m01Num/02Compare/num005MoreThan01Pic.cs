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
  public partial  class num005MoreThan01Pic:prnControl
    {
        public num005MoreThan01Pic()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
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
            this.groupBox1.Size = new System.Drawing.Size(250, 602);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(1114, 602);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1108, 580);
            // 
            // num005MoreThan01Pic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "num005MoreThan01Pic";
            this.Size = new System.Drawing.Size(1364, 602);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #region Variables

        int minValue = 1, maxValue = 15;

        #endregion
        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "ระบายสีจำนวนที่มากกว่าในช่องสี่เหลี่ยม หรือ ระบายสีทั้ง 2 ช่องถ้าจำนวนเท่ากัน";
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
            Pen pen = new Pen(Color.Black, 2);
            SolidBrush solidBrush = new SolidBrush(Color.White);

            xC = 150;
            yC = yC + 100;

            int a, b;
            for (int i = 1; i <= 4; i++)
            {
                a = RandomNumber.Randomnumber(minValue, maxValue);
                b = RandomNumber.Randomnumber(minValue, maxValue);

                e.Graphics.DrawImage(KidsLearning.Classed.Exten.ExtGraphics_Maths.ImageFromNumber(a, 150, 150, true), xC, yC);

                xC = xC + 280;
                e.Graphics.DrawImage(KidsLearning.Classed.Exten.ExtGraphics_Maths.ImageFromNumber(b, 150, 150, true), xC, yC);

                xC = 150;
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
