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
namespace KidsLearning.Print.ptnMth.m01Num
{
   public partial class num002CountandCircleNumber: prnControl
    {
        public num002CountandCircleNumber()
        {
            InitializeComponent();
         
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            this.Load += new System.EventHandler(this.prnMath_01_Num_01_Load);
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
            this.groupBox1.Size = new System.Drawing.Size(292, 739);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            this.panel2.Size = new System.Drawing.Size(286, 119);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(292, 0);
            this.groupBox2.Size = new System.Drawing.Size(1179, 739);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1173, 717);
            // 
            // prnMath_002CountandCircleNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "prnMath_002CountandCircleNumber";
            this.Size = new System.Drawing.Size(1471, 739);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

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

            int Anw = RandomNumberGenerator.GetInt32(minValue, maxValue);
               int countAnw = RandomNumberGenerator.GetInt32(2, 6);
            for (int i = 1; i <= countAnw; i++)
                Nums.Add(Anw);
            for (int i = 1; i <= 10- countAnw; i++)
                Nums.Add(RandomNumberGenerator.GetInt32(minValue, maxValue));

          //  Nums.ForEach(n => MessageBox.Show(Anw + "\n"+n.ToString()));
            

            e.Graphics.DrawString($"นับ และ วงรอบรูปที่แสดงจำนวน  {Anw}", fontDetail, new SolidBrush(Color.Black), xC, yC);
            xC = 150;
            yC = yC + 100;
          
            int randomIndex, number;
            for (int i = 1; i <= 10; i += 2)
            {
                randomIndex = RandomNumberGenerator.GetInt32(0,Nums.Count-1);
                number = Nums[randomIndex];

                e.Graphics.DrawImage(KidsLearning.Classed.Exten.ExtGraphics_Maths.ImageFromNumber(number, 100,100), xC, yC);
                Nums.RemoveAt(randomIndex);

                xC = xC + 320;
                if (Nums.Count > 1)
                {
                    randomIndex = RandomNumberGenerator.GetInt32(0, Nums.Count - 1);
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
