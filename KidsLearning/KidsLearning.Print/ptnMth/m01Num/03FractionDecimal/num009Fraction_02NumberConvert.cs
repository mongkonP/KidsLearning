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

namespace KidsLearning.Print.ptnMth.m01Num
{
  public partial  class num009Fraction_02NumberConvert : prnControl
    {
        public num009Fraction_02NumberConvert()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
        
        }

        #region Variables

        int minValue = 1, maxValue = 15;

        #endregion
        private RadioButton rd_3;
        private RadioButton rd_2;
        private RadioButton rd_1;

        string OP = "1";
        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "เขียนให้อยู่ในรูปเศษส่วนอย่างต่ำ พร้อมแสดงวิธีทำ";
            iPage = 1;
            iPageAll = 1;
            
            printPreviewControl1.Document = this.printDocument1;
        }

        private void InitializeComponent()
        {
            this.rd_1 = new System.Windows.Forms.RadioButton();
            this.rd_2 = new System.Windows.Forms.RadioButton();
            this.rd_3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(368, 683);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rd_3);
            this.panel2.Controls.Add(this.rd_2);
            this.panel2.Controls.Add(this.rd_1);
            this.panel2.Size = new System.Drawing.Size(362, 474);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            this.panel2.Controls.SetChildIndex(this.txtPageCount, 0);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.bntPrint, 0);
            this.panel2.Controls.SetChildIndex(this.rd_1, 0);
            this.panel2.Controls.SetChildIndex(this.rd_2, 0);
            this.panel2.Controls.SetChildIndex(this.rd_3, 0);
            // 
            // bntPrint
            // 
            this.bntPrint.Location = new System.Drawing.Point(12, 404);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(170, 365);
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(80, 362);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 365);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(368, 0);
            this.groupBox2.Size = new System.Drawing.Size(791, 683);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(785, 661);
            // 
            // rd_1
            // 
            this.rd_1.AutoSize = true;
            this.rd_1.Checked = true;
            this.rd_1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_1.Location = new System.Drawing.Point(12, 31);
            this.rd_1.Name = "rd_1";
            this.rd_1.Size = new System.Drawing.Size(222, 36);
            this.rd_1.TabIndex = 14;
            this.rd_1.TabStop = true;
            this.rd_1.Text = "เขียนเศษส่วนอย่างต่ำ";
            this.rd_1.UseVisualStyleBackColor = true;
            this.rd_1.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_2
            // 
            this.rd_2.AutoSize = true;
            this.rd_2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_2.Location = new System.Drawing.Point(12, 73);
            this.rd_2.Name = "rd_2";
            this.rd_2.Size = new System.Drawing.Size(282, 36);
            this.rd_2.TabIndex = 15;
            this.rd_2.Text = "เขียนเศษส่วนเป็นจำนวนคละ";
            this.rd_2.UseVisualStyleBackColor = true;
            this.rd_2.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_3
            // 
            this.rd_3.AutoSize = true;
            this.rd_3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_3.Location = new System.Drawing.Point(12, 115);
            this.rd_3.Name = "rd_3";
            this.rd_3.Size = new System.Drawing.Size(282, 36);
            this.rd_3.TabIndex = 16;
            this.rd_3.Text = "เขียนจำนวนคละเป็นเศษส่วน";
            this.rd_3.UseVisualStyleBackColor = true;
            this.rd_3.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // num009Fraction_02NumberConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "num009Fraction_02NumberConvert";
            this.Size = new System.Drawing.Size(1159, 683);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void rd_1_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_1.Checked)
            {
                OP = "1"; ReportToppic = "เขียนเศษส่วนต่อไปนี้ ให้อยู่ในรูปเศษส่วนอย่างต่ำ ";
            }
            else if (rd_2.Checked)
            {
                OP = "2"; ReportToppic = "เขียนเศษส่วนต่อไปนี้ ให้อยู่ในรูปจำนวนคละ  ";
            }
            else if (rd_3.Checked)
            {
                OP = "3"; ReportToppic = "เขียนจำนวนคละต่อไปนี้ ให้อยู่ในรูปเศษส่วน  ";
            }
            printPreviewControl1.Document = this.printDocument1;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail


            int yC = 130;
            int xC =  150;


            for (int i = 1; i <= 6; i++)
            {
                int c = 1, a = 1, b = 1 ;

                if (OP == "1")
                {
                    
                    c = RandomNumber.Randomnumber(2, 10);
                     a = RandomNumber.Randomnumber(2, 10) * c;
                     b = RandomNumber.Randomnumber(2, 10) * c;
                    e.Graphics.DrawFraction(a, b, xC, yC);
                    e.Graphics.DrawString(" วิธีทำ# ", new Font("Angsana New", 20), new SolidBrush(Color.Black), xC + 150, yC + 5);

                }
                else if (OP == "2")
                {


                     a = RandomNumber.Randomnumber(3, 10);
                     b = RandomNumber.Randomnumber(2, 10);
                     c = RandomNumber.Randomnumber(1, a - 1);
                    int d = a * b + c;
                    e.Graphics.DrawFraction(0, d, a, xC + 10, yC, false, false, false);
                    e.Graphics.DrawString(" = ", new Font("Angsana New", 20), new SolidBrush(Color.Black), xC + 120, yC + 20);
                    e.Graphics.DrawFraction(b, d, a, xC + 200, yC, true, true, false);
                 

                }
                else if (OP == "3")
                {


                    a = RandomNumber.Randomnumber(3, 10);
                    b = RandomNumber.Randomnumber(2, 10);
                    c = RandomNumber.Randomnumber(1, a - 1);
                    int d = a * b + c;
                    e.Graphics.DrawFraction(0, d, a, xC + 200, yC, true, false, false);
                    e.Graphics.DrawString(" = ", new Font("Angsana New", 20), new SolidBrush(Color.Black), xC + 120, yC + 20);
                    e.Graphics.DrawFraction(b, c, a, xC + 10, yC, false, false, false); 

                }
              

               /* for (int l = 1; l <= 5; l++)
                {
                    e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 100,yC+(25*l), xC + 500, yC + (25 * l));
                }*/

                yC+= 150;

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
