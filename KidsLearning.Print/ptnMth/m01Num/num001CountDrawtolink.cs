using KidsLearning.Classed.Exten;
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
   public partial class num001CountDrawtolink:prnControl
    {

        public num001CountDrawtolink()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(244, 707);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            this.panel2.Size = new System.Drawing.Size(238, 119);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(244, 0);
            this.groupBox2.Size = new System.Drawing.Size(1257, 707);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1251, 685);
            // 
            // prnMath_001Drawtolink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "prnMath_001Drawtolink";
            this.Size = new System.Drawing.Size(1501, 707);
            this.Load += new System.EventHandler(this.prnMath_01_Num_01_1to50_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

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

                int a = RandomNumberGenerator.GetInt32(minValue, maxValue);
                NumsA.Add(a);
                NumsB.Add(a);
                ssss += "_" + a;
            }

           
            e.Graphics.DrawString( "ลากเส้นตามจำนวนที่ถุกต้อง", fontDetail, new SolidBrush(Color.Black), xC, yC);
            xC = 150;
            yC = yC + 100;

            int randomIndex, number;
            for (int i = 1; i <= 5; i++)
            {

                number = NumsA[i-1];
                e.Graphics.DrawImage(KidsLearning.Classed.Exten.ExtGraphics_Maths.ImageFromNumber(number, 100, 100), xC, yC);

               // System.Threading.Thread.Sleep(1000);
                xC = xC + 340;
                if (NumsB.Count > 1)
                {
                    randomIndex = RandomNumberGenerator.GetInt32(0, NumsB.Count - 1);
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
