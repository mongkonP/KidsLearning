using KidsLearning.Classed.Exten;
using KidsLearning.Control.Exten;
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
    public partial class num002CountandCircleNumber : prnControl
    {
        public num002CountandCircleNumber()
        {
            InitializeComponent();

            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            this.Load += new System.EventHandler(this.prnMath_01_Num_01_Load);
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
            groupBox1.Size = new Size(292, 655);
            // 
            // panel2
            // 
            panel2.Size = new Size(286, 119);
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(292, 0);
            groupBox2.Size = new Size(1234, 655);
            // 
            // printPreviewControl1
            // 
            printPreviewControl1.Size = new Size(1228, 633);
            // 
            // num002CountandCircleNumber
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            Name = "num002CountandCircleNumber";
            Size = new Size(1526, 655);
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #region Variables

        int minValue = 1, maxValue = 15;
        int countC = 13;
        List<listNum_A_B> listNum_A_Bs = new List<listNum_A_B>();
        #endregion

        private void prnMath_01_Num_01_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            iPage = 1;
            iPageAll = 1;
            printPreviewControl1.Document = this.printDocument1;


        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);
            List<int> Nums = new List<int>();
            int yC = 100;
            int xC = 100;
            int w = 80, h = 50;
            Pen pen = new Pen(Color.Black, 2);
            SolidBrush solidBrush = new SolidBrush(Color.White);

            int Anw = RandomNumber.Randomnumber(minValue, maxValue);
            int countAnw = RandomNumber.Randomnumber(2, 6);
            for (int i = 1; i <= countAnw; i++)
                Nums.Add(Anw);
            for (int i = 1; i <= 10 - countAnw; i++)
                Nums.Add(RandomNumber.Randomnumber(minValue, maxValue));

            //  Nums.ForEach(n => MessageBox.Show(Anw + "\n"+n.ToString()));


            e.Graphics.DrawString($"นับ และ วงรอบรูปที่แสดงจำนวน  {Anw}", fontDetail, new SolidBrush(Color.Black), xC, yC);
            xC = 150;
            yC = yC + 100;

            int randomIndex, number;
            for (int i = 1; i <= 10; i += 2)
            {
                randomIndex = RandomNumber.Randomnumber(0, Nums.Count);
                number = Nums[randomIndex];

                e.Graphics.DrawImage(KidsLearning.Classed.Exten.ExtGraphics_Maths.ImageFromNumber(number, 100, 100), xC, yC);
                Nums.RemoveAt(randomIndex);

                xC = xC + 320;
                if (Nums.Count > 1)
                {
                    randomIndex = RandomNumber.Randomnumber(0, Nums.Count);
                    number = Nums[randomIndex];
                    Nums.RemoveAt(randomIndex);
                }
                else
                {
                    number = Nums[0];
                }
                e.Graphics.DrawImage(KidsLearning.Classed.Exten.ExtGraphics_Maths.ImageFromNumber(number, 100, 100), xC, yC);

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
