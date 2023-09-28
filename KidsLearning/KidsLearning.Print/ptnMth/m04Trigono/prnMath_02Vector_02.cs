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
  public partial  class prnMath_02Vector_02 : prnControl
    {
        public prnMath_02Vector_02()
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
            ReportToppic = "กำหนดจุด และ ลากเส้นตรง บนแกน x,y";
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
            this.groupBox1.Size = new System.Drawing.Size(250, 683);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(1116, 683);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1110, 661);
            // 
            // prnMath_02Vector_02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "prnMath_02Vector_02";
            this.Size = new System.Drawing.Size(1366, 683);
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
        
            for (int i = 0; i < 2; i++)
            {

                e.Graphics.DrawString($"กำหนดจุด A=({RandomNumber.Randomnumber(-10, 10)},{RandomNumber.Randomnumber(-10, 10)}) และ" +
                                      $"B=({RandomNumber.Randomnumber(-10, 10)},{RandomNumber.Randomnumber(-10, 10)})"
                                      , fontDetail, new SolidBrush(Color.Black), xC , yC);
                e.Graphics.DrawImage(Image.FromFile(Application.StartupPath+ @"\File\PIC\Math\xyG.png"),xC+30,yC+30,420,420);
                yC += 450;
                e.Graphics.DrawString($"เส้นตรง AB มีความยาว ___________ หน่วย "
                                     , fontDetail, new SolidBrush(Color.Black), xC, yC);

                yC += 40;

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
