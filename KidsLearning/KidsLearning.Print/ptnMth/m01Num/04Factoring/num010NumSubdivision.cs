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
    public partial class num010NumSubdivision : prnControl
    {

        public num010NumSubdivision()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // groupBox1
            // 
            groupBox1.Size = new Size(244, 0);
            // 
            // panel2
            // 
            panel2.Size = new Size(238, 315);
            // 
            // bntPrint
            // 
            bntPrint.Location = new Point(14, 247);
            // 
            // label2
            // 
            label2.Location = new Point(172, 208);
            // 
            // txtPageCount
            // 
            txtPageCount.Location = new Point(82, 205);
            // 
            // label1
            // 
            label1.Location = new Point(14, 208);
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(244, 0);
            groupBox2.Size = new Size(0, 0);
            // 
            // printPreviewControl1
            // 
            printPreviewControl1.Size = new Size(0, 0);
            // 
            // num010NumSubdivision
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            Name = "num010NumSubdivision";
            Size = new Size(0, 0);
            Load += prnMath_01_Num_01_1to50_Load;
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
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
            int w = 50, h = 35, wr = 25;
            int aa;
            for (int i = 0; i < 4; i++)
            {
                //aa = RandomNumber.Randomnumber(minValue, maxValue);
                aa = 1;
                for (int m = 0; m <= RandomNumber.Randomnumber(1, 4); m++)
                    aa *= RandomNumber.Randomnumber(2, 7);

                e.Graphics.DrawRectangleString(aa.ToString(), fontExpression, new Pen(Color.Black, 3), new Rectangle(xC, yC, w, h));


                for (int a = 1; a < 9; a++)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(xC + a * (w + wr), yC, w, h));
                    e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(xC + a * (w + wr), yC + 2 * h, w, h));

                    e.Graphics.DrawLine(new Pen(Color.Black, 3), xC + a * (w + wr), yC + h / 2, xC + a * (w + wr) - wr, yC + h / 2);

                    e.Graphics.DrawLine(new Pen(Color.Black, 3), xC + a * (w + wr) + w / 2, yC + h, xC + a * (w + wr) + w / 2, yC + 2 * h);

                }

                e.Graphics.DrawString($"ดังนั้น {aa} สามารถนำมาแยกตัวประกอบได้เป็น \n _______________________________________________________",
                    new Font("Angsana New", 18), new SolidBrush(Color.Black), xC, yC + 4 * h);
                yC += 6 * h + 10;

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
