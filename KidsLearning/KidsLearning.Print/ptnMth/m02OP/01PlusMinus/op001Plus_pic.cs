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

namespace KidsLearning.Print.ptnMth.m02OP
{
  public partial  class op001Plus_pic:prnControl
    {
        public op001Plus_pic()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
        
        }

        #region Variables

        int minValue = 1, maxValue = 12;

        #endregion
        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "นับจำนวนตามรูปภาพ และ รวมจำนวน ทั้ง 2 รูป";
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
            this.groupBox1.Size = new System.Drawing.Size(250, 739);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(1221, 739);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1215, 717);
            // 
            // prnMath_006Plus_pic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "prnMath_006Plus_pic";
            this.Size = new System.Drawing.Size(1471, 739);
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
            int w = 80, h = 50;
            Pen pen = new Pen(Color.Black, 2);
            SolidBrush solidBrush = new SolidBrush(Color.White);

            xC = 150;
            yC = yC + 50;

            for (int i = 1; i <= 4; i ++)
            {

                int a = RandomNumber.Randomnumber(1, 10);
                int b = RandomNumber.Randomnumber(1, 10);
                e.Graphics.DrawImage(KidsLearning.Classed.Exten.ExtGraphics_Maths.ImageFromNumber(a, 200, 150, true), xC, yC);
                e.Graphics.DrawImage(KidsLearning.Classed.Exten.ExtGraphics_Maths.ImageFromNumber(b, 200, 150, true), xC+200, yC);
                e.Graphics.DrawString("+", new Font("Arial", 32, FontStyle.Bold), new SolidBrush(Color.Black), xC + 180, yC + 100);

                e.Graphics.DrawString("=", new Font("Arial", 32, FontStyle.Bold), new SolidBrush(Color.Black), xC + 400, yC + 100);
                e.Graphics.DrawRectangle(new Pen(Color.Black, 3), xC + 450, yC + 95, 100, 50);
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
