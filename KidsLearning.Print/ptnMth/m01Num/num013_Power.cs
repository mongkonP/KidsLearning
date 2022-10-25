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

namespace KidsLearning.Print.ptnMth.m01Num
{
   public partial class num013_Power : prnControl
    {

        public num013_Power()
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
            this.groupBox1.Size = new System.Drawing.Size(244, 632);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(238, 131);
            // 
            // bntPrint
            // 
            this.bntPrint.Location = new System.Drawing.Point(12, 70);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(170, 31);
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(80, 28);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 31);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(244, 0);
            this.groupBox2.Size = new System.Drawing.Size(1258, 632);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1252, 610);
            // 
            // num013_Power
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "num013_Power";
            this.Size = new System.Drawing.Size(1502, 632);
            this.Load += new System.EventHandler(this.prn_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #region Variables

        int minValue = 10, maxValue = 200;
        Random random = new Random();
        #endregion




        private void prn_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "หาเลขยกกำลังด้วยการคูณ";
            printPreviewControl1.Document = this.printDocument1;
        }

       

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail

            int yC = 150, xC = 100;
         
            string sss;



            for (int i = 0; i < 6; i++)
            {

                int a ;
                int b ;
              /*  a = RandomNumberGenerator.GetInt32(1, 10);
                b = RandomNumberGenerator.GetInt32(2, 10);

                e.Graphics.DrawString($"{(a + "^" + b).ToSuperscriptNumber()} = _______________________________________________\n" +
                                        $"   = ______________________________________\n",
                    new Font("Segoe UI", 20), new SolidBrush(Color.Black), xC, yC);*/

                 if (RandomNumberGenerator.GetInt32(0, 1000) >500)
                  {
                       a = RandomNumberGenerator.GetInt32(1, 10);
                       b = RandomNumberGenerator.GetInt32(2, 10);
                    sss = $"{(a + "^" + b).ToSuperscriptNumber()} = __________________________________________\n = ______________________________________\n";
                    
                  }
                  else 
                  {
                      a = RandomNumberGenerator.GetInt32(1, 10);
                      b = RandomNumberGenerator.GetInt32(2, 10);
                       sss = "";
                   // MessageBox.Show(a + "\n" + b);
                    if (b == 2)
                    {
                        sss = $"{a} x {a}";
                    }
                    else
                    {
                        for (int n = 1; n < b; n++)
                        {
                            sss += a + " x ";
                        }
                        sss +=  a;
                    }
                      
                      
                  sss = $"{sss} = _______\n = _________________________________\n" ;
                  }

                e.Graphics.DrawString(sss, new Font("Segoe UI", 20), new SolidBrush(Color.Black), xC, yC);
                yC += 150;



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
