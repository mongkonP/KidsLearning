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

namespace KidsLearning.Print.ptnMth.m01Num
{
    public partial class num001CountDrawtolink : prnControl
    {

        public num001CountDrawtolink()
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
            groupBox1.Size = new Size(244, 655);
            // 
            // panel2
            // 
            panel2.Size = new Size(238, 119);
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(244, 0);
            groupBox2.Size = new Size(1282, 655);
            // 
            // printPreviewControl1
            // 
            printPreviewControl1.Size = new Size(1276, 633);
            // 
            // num001CountDrawtolink
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            Name = "num001CountDrawtolink";
            Size = new Size(1526, 655);
            Load += prnMath_01_Num_01_1to50_Load;
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }


        #region Variables

        int minValue = 1, maxValue = 10;

        #endregion



        public void RandomChoie()
        {


            iPage = 1;
            iPageAll = 1;
            printPreviewControl1.Document = this.printDocument1;
        }
        private void prnMath_01_Num_01_1to50_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            RandomChoie();
        }



        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            List<int> NumsA = new List<int>();
            List<int> NumsB = new List<int>();
            int yC = 100;
            int xC = 100;
            int w = 80, h = 50;
            Pen pen = new Pen(Color.Black, 2);
            SolidBrush solidBrush = new SolidBrush(Color.White);
            string ssss = "";
            for (int i = 1; i <= 5; i++)
            {

                int a = RandomNumber.Randomnumber(minValue, maxValue);
                NumsA.Add(a);
                NumsB.Add(a);
                ssss += "_" + a;
            }


            e.Graphics.DrawString("ลากเส้นตามจำนวนที่ถุกต้อง", fontDetail, new SolidBrush(Color.Black), xC, yC);
            xC = 150;
            yC = yC + 100;

            int randomIndex, number;
            for (int i = 1; i <= 5; i++)
            {

                number = NumsA[i - 1];
                e.Graphics.DrawImage(KidsLearning.Classed.Exten.ExtGraphics_Maths.ImageFromNumber(number, 100, 100), xC, yC);

                // System.Threading.Thread.Sleep(1000);
                xC = xC + 340;
                if (NumsB.Count > 1)
                {
                    randomIndex = RandomNumber.Randomnumber(0, NumsB.Count);
                    number = NumsB[randomIndex];
                    NumsB.RemoveAt(randomIndex);
                }
                else
                {
                    number = NumsB[0];
                }


                e.Graphics.DrawString(number.ToString(), new Font("Angsana New", 32, FontStyle.Bold), new SolidBrush(Color.Black), xC, yC + 30);


                xC = 150;
                yC = yC + 150;

            }

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
