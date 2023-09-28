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


namespace KidsLearning.Print.ptnPhy
{
    public partial class prnPhysic_Temp : prnControl
    {
        public prnPhysic_Temp()
        {
            InitializeComponent();
            Load += new EventHandler(frm_Load);
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            filePrintPre = "File\\Book\\Sci\\หน่วยและการแปลงหน่วยอุณหภูมิ.pdf";
        }

        #region Variables

        int minValue = 1, maxValue = 15;

        #endregion
        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ สมการ ";
            ReportToppic = "";
            iPage = 1;
            iPageAll = 1;

            printPreviewControl1.Document = printDocument1;
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
            groupBox1.Size = new Size(250, 631);
            // 
            // groupBox2
            // 
            groupBox2.Size = new Size(1196, 631);
            // 
            // printPreviewControl1
            // 
            printPreviewControl1.Size = new Size(1190, 609);
            // 
            // prnPhysic_Temp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            Name = "prnPhysic_Temp";
            Size = new Size(1446, 631);
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

            List<int> Nums = new List<int>();
            int yC = 100;
            int xC = 100;
            int w = 80, h = 50;
            Pen pen = new Pen(Color.Black, 2);
            SolidBrush solidBrush = new SolidBrush(Color.White);

            xC = 100;
            yC = yC + 30;
            double C, K, F;
            for (int i = 1; i < 5; i++)
            {


                int d = RandomNumber.Randomnumber(1, 6000);
                switch (d)
                {
                    case int n when n >= 0 && n < 1000:
                        //การแปลงหน่วยองศาเซลเซียสเป็นองศาฟาเรนไฮต์ F = 9 / 5(C) + 32
                        C = RandomNumber.Randomnumber(-273, 100);

                        e.Graphics.DrawString($"{C} องศาเซลเซียส เท่ากับกี่ องศาฟาเรนไฮต์", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5);
                        break;

                    case int n when n >= 1000 && n < 2000:
                        //การแปลงหน่วยองศาเซลเซียสเป็นเคลวิน  K = C + 273
                        C = RandomNumber.Randomnumber(-273, 100);
                        e.Graphics.DrawString($"{C} องศาเซลเซียส เท่ากับกี่ องศาเคลวิน", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5);
                        break;

                    case int n when n >= 2000 && n < 3000:
                        //การแปลงหน่วยองศาฟาเรนไฮต์เป็นองศาเซลเซียส C = (5/9)x((F-32)
                        F = RandomNumber.Randomnumber(-459, 212);
                        e.Graphics.DrawString($"{F} องศาฟาเรนไฮต์ เท่ากับกี่ องศาเซลเซียส", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5);
                        break;
                    case int n when n >= 3000 && n < 4000:
                        //การแปลงหน่วยองศาฟาเรนไฮต์เป็นเคลวิน  K = 5 / 9(F - 32) + 273.15
                        F = RandomNumber.Randomnumber(-459, 212);
                        e.Graphics.DrawString($"{F} องศาฟาเรนไฮต์ เท่ากับกี่ องศาเคลวิน", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5);
                        break;
                    case int n when n >= 4000 && n < 5000:
                        //การแปลงหน่วยเคลวินเป็นองศาเซลเซียส C = K - 273
                        K = RandomNumber.Randomnumber(0, 273);
                        e.Graphics.DrawString($"{K} องศาเคลวิน เท่ากับกี่ องศาเซลเซียส", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5);
                        break;

                    case int n when n >= 5000 && n <= 6000:
                        //การแปลงหน่วยเคลวินเป็นองศาฟาเรนไฮต์ F = 9 / 5(K - 273) + 32
                        K = RandomNumber.Randomnumber(0, 273);
                        e.Graphics.DrawString($"{K} องศาเคลวิน เท่ากับกี่ องศาฟาเรนไฮต์", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5);
                        break;


                }

                xC = 100;
                yC = yC + 250;

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
            e.HasMorePages = bMorePagesToPrint ? true : false;
        }

    }
}
