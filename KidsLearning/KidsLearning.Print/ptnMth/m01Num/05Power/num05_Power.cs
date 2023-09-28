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
   public partial class num05_Power : prnControl
    {

        public num05_Power()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.rd_1 = new System.Windows.Forms.RadioButton();
            this.rd_2 = new System.Windows.Forms.RadioButton();
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
            this.groupBox1.Size = new System.Drawing.Size(244, 683);
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rd_2);
            this.panel2.Controls.Add(this.rd_1);
            this.panel2.Size = new System.Drawing.Size(238, 251);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            this.panel2.Controls.SetChildIndex(this.txtPageCount, 0);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.bntPrint, 0);
            this.panel2.Controls.SetChildIndex(this.rd_1, 0);
            this.panel2.Controls.SetChildIndex(this.rd_2, 0);
            // 
            // bntPrint
            // 
            this.bntPrint.Location = new System.Drawing.Point(12, 181);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(170, 142);
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(80, 139);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 142);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(244, 0);
            this.groupBox2.Size = new System.Drawing.Size(1122, 683);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1116, 661);
            // 
            // rd_1
            // 
            this.rd_1.AutoSize = true;
            this.rd_1.Checked = true;
            this.rd_1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_1.Location = new System.Drawing.Point(12, 12);
            this.rd_1.Name = "rd_1";
            this.rd_1.Size = new System.Drawing.Size(110, 36);
            this.rd_1.TabIndex = 14;
            this.rd_1.TabStop = true;
            this.rd_1.Text = "ไม่ติดลบ";
            this.rd_1.UseVisualStyleBackColor = true;
            this.rd_1.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_2
            // 
            this.rd_2.AutoSize = true;
            this.rd_2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_2.Location = new System.Drawing.Point(12, 54);
            this.rd_2.Name = "rd_2";
            this.rd_2.Size = new System.Drawing.Size(100, 36);
            this.rd_2.TabIndex = 15;
            this.rd_2.Text = "มีติดลบ";
            this.rd_2.UseVisualStyleBackColor = true;
            this.rd_2.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // num013_Power
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "num013_Power";
            this.Size = new System.Drawing.Size(1366, 683);
            this.Load += new System.EventHandler(this.prn_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #region Variables

        int minValue = 10, maxValue = 200;
        private RadioButton rd_2;
        private RadioButton rd_1;
        Random random = new Random();
        #endregion




        private void prn_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "หาเลขยกกำลังด้วยการคูณ";
            printPreviewControl1.Document = this.printDocument1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void rd_1_CheckedChanged(object sender, EventArgs e)
        {

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
               

                 if (RandomNumber.Randomnumber(0, 1000) >500)
                  {
                       a =(rd_2.Checked)? RandomNumber.Randomnumber(-10, 10): RandomNumber.Randomnumber(1, 10);
                       b = RandomNumber.Randomnumber(2, 5);
                       sss = $"{(a + "^" + b).ToSuperscriptNumber()} = __________________________________________\n = ______________________________________\n";
                    
                  }
                  else 
                  {
                    a = (rd_2.Checked) ? RandomNumber.Randomnumber(-10, 10) : RandomNumber.Randomnumber(1, 10);
                    b = RandomNumber.Randomnumber(2, 5);
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
