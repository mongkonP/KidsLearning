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
using System.Drawing.Drawing2D;

namespace KidsLearning.Print.ptnMth.m04Trigono
{
    public partial class prnMath_02Vector_01 : prnControl
    {
        public prnMath_02Vector_01()
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
            ReportHeader = "การทดสอบ เกี่ยวกับ มาตรวัด ";
            ReportToppic = "กำหนดจุดบนแกน x,y";
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
            groupBox1.Size = new Size(250, 0);
            // 
            // groupBox2
            // 
            groupBox2.Size = new Size(0, 0);
            // 
            // printPreviewControl1
            // 
            printPreviewControl1.Size = new Size(0, 0);
            // 
            // prnMath_02Vector_01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            Name = "prnMath_02Vector_01";
            Size = new Size(0, 0);
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

            int yC = 120, xC = 100;

            for (int i = 0; i < 2; i++)
            {

                e.Graphics.DrawString($"กำหนดจุด ({RandomNumber.Randomnumber(-10, 10)},{RandomNumber.Randomnumber(-10, 10)}) และ " +
                    $" ({RandomNumber.Randomnumber(-10, 10)},{RandomNumber.Randomnumber(-10, 10)}) และ" +
                    $" ({RandomNumber.Randomnumber(-10, 10)},{RandomNumber.Randomnumber(-10, 10)})", fontDetail, new SolidBrush(Color.Black), xC, yC);
                e.Graphics.DrawImage(Image.FromFile(Application.StartupPath + @"\File\PIC\Math\xyG.png"), xC + 30, yC + 30, 450, 450);
                yC += 500;

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
