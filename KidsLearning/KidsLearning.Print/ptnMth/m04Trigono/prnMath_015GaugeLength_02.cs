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
  public partial  class prnMath_015GaugeLength_02 : prnControl
    {
        public prnMath_015GaugeLength_02()
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
            ReportToppic = "ลากเส้นตามความยาวต่อไปนี้ และกำหนดจุด B";
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
            this.groupBox1.Size = new System.Drawing.Size(250, 602);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(1032, 602);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1026, 580);
            // 
            // prnMath_015GaugeLength_02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "prnMath_015GaugeLength_02";
            this.Size = new System.Drawing.Size(1282, 602);
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

            int yC = 120, xC = 100;
        
            for (int i = 0; i < 5; i++)
            {

                // e.Graphics.DrawString("วัดความยาว ต่อไปนี้ ", fontDetail, new SolidBrush(Color.Black), new RectangleF(xC - 50, yC, 750, 80));
                yC += 50;

                using (Pen pen = new Pen(Color.Black, 3))
                {

                    pen.StartCap = LineCap.RoundAnchor;
                   
                    //int x, y;
                   
                      //  x = xC + RandomNumber.Randomnumber(150, 600);
                        e.Graphics.DrawLine(pen, xC + 80, yC, xC + 82, yC);
                        e.Graphics.DrawString("A", fontDetail, new SolidBrush(Color.Black), xC + 60, yC - 20);
                       // e.Graphics.DrawString("B", fontDetail, new SolidBrush(Color.Black), x, yC - 20);
                    
                    

                }
                yC += 20;
                int cm = RandomNumber.Randomnumber(1, 10);
                int mm = RandomNumber.Randomnumber(0, 10);
                if (mm > 0)
                {
                    e.Graphics.DrawString($"ความยาว {cm} เซนติเมตร {mm} มิลลิเมตร", fontDetail, new SolidBrush(Color.Black), xC + 80, yC);
                }
                else
                { 
                  e.Graphics.DrawString($"ความยาว {cm} เซนติเมตร ", fontDetail, new SolidBrush(Color.Black), xC + 80, yC);
                }
              
              

                yC += 60;

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
