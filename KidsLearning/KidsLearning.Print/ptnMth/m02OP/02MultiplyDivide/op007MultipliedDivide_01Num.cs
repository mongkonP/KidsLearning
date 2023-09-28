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

namespace KidsLearning.Print.ptnMth.m02OP
{
  public partial  class op007MultipliedDivide_01Num:prnControl
    {
        public op007MultipliedDivide_01Num()
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
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "การกระจายการคูณ หาร";
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
            this.groupBox1.Size = new System.Drawing.Size(279, 676);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            this.panel2.Size = new System.Drawing.Size(273, 290);
            // 
            // bntPrint
            // 
            this.bntPrint.Location = new System.Drawing.Point(9, 215);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(167, 176);
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(77, 173);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 176);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(279, 0);
            this.groupBox2.Size = new System.Drawing.Size(1047, 676);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1041, 654);
            // 
            // op007MultipliedDivide_01Num
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "op007MultipliedDivide_01Num";
            this.Size = new System.Drawing.Size(1326, 676);
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

            List<int> Nums = new List<int>();
            int yC = 130;
            int xC = 150;
           
            Pen pen = new Pen(Color.Black, 2);
            SolidBrush solidBrush = new SolidBrush(Color.White);

            string str = "";
    

            for (int i = 1; i <= 6; i++)
            {

                int a = RandomNumber.Randomnumber(2, 10);
                int b = RandomNumber.Randomnumber(2, 10);

               
                     str = "เขียนในรูปการบวก:   " + a;
                    
                         for (int p = 2; p <= b; p++)
                             str += " + " + a;
                     
                     str += " = ..........................";
                     str += "\nเขียนในรูปการคูณ:   " + a + " x " + b + " = .........................";
                    str += "\nเขียนในรูปการหาร:   " + a * b + " ÷ " + b + " = .......................";
               

               
                e.Graphics.DrawString(str, fontDetail, new SolidBrush(Color.Black), xC, yC);
                yC = yC + 150;

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
