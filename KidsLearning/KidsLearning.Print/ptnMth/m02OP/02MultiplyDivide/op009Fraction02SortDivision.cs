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
  public partial  class op009Fraction02SortDivision : prnControl
    {
        public op009Fraction02SortDivision()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
        
        }

        #region Variables

        int minValue = 1, maxValue = 100;

        #endregion
        private Panel panel1;
        private RadioButton rd_3;
        private RadioButton rd_2;
        private Panel panel3;
        private RadioButton rd_6;
        private RadioButton rd_5;
        private RadioButton rd_4;
        private RadioButton rd_1;

        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ การหาร ";
            ReportToppic = "หาผลหาร ต่อไปนี้ โดยการหารสั้น";
            iPage = 1;
            iPageAll = 1;
            
            printPreviewControl1.Document = this.printDocument1;
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.rd_3 = new System.Windows.Forms.RadioButton();
            this.rd_2 = new System.Windows.Forms.RadioButton();
            this.rd_1 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rd_6 = new System.Windows.Forms.RadioButton();
            this.rd_5 = new System.Windows.Forms.RadioButton();
            this.rd_4 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Size = new System.Drawing.Size(250, 707);
            this.groupBox1.Controls.SetChildIndex(this.panel3, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel1, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel2, 0);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 321);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(1127, 707);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1121, 685);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rd_3);
            this.panel1.Controls.Add(this.rd_2);
            this.panel1.Controls.Add(this.rd_1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 148);
            this.panel1.TabIndex = 15;
            // 
            // rd_3
            // 
            this.rd_3.AutoSize = true;
            this.rd_3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_3.Location = new System.Drawing.Point(21, 92);
            this.rd_3.Name = "rd_3";
            this.rd_3.Size = new System.Drawing.Size(98, 36);
            this.rd_3.TabIndex = 2;
            this.rd_3.Text = "แบบสุ่ม";
            this.rd_3.UseVisualStyleBackColor = true;
            this.rd_3.CheckedChanged += new System.EventHandler(this.rd_CheckedChanged);
            // 
            // rd_2
            // 
            this.rd_2.AutoSize = true;
            this.rd_2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_2.Location = new System.Drawing.Point(21, 52);
            this.rd_2.Name = "rd_2";
            this.rd_2.Size = new System.Drawing.Size(173, 36);
            this.rd_2.TabIndex = 1;
            this.rd_2.Text = "หารแบบไม่ลงตัว";
            this.rd_2.UseVisualStyleBackColor = true;
            this.rd_2.CheckedChanged += new System.EventHandler(this.rd_CheckedChanged);
            // 
            // rd_1
            // 
            this.rd_1.AutoSize = true;
            this.rd_1.Checked = true;
            this.rd_1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_1.Location = new System.Drawing.Point(21, 14);
            this.rd_1.Name = "rd_1";
            this.rd_1.Size = new System.Drawing.Size(154, 36);
            this.rd_1.TabIndex = 0;
            this.rd_1.TabStop = true;
            this.rd_1.Text = "หารแบบลงตัว";
            this.rd_1.UseVisualStyleBackColor = true;
            this.rd_1.CheckedChanged += new System.EventHandler(this.rd_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rd_6);
            this.panel3.Controls.Add(this.rd_5);
            this.panel3.Controls.Add(this.rd_4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 154);
            this.panel3.TabIndex = 16;
            // 
            // rd_6
            // 
            this.rd_6.AutoSize = true;
            this.rd_6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_6.Location = new System.Drawing.Point(21, 92);
            this.rd_6.Name = "rd_6";
            this.rd_6.Size = new System.Drawing.Size(159, 36);
            this.rd_6.TabIndex = 2;
            this.rd_6.Text = "1000-10000";
            this.rd_6.UseVisualStyleBackColor = true;
            this.rd_6.CheckedChanged += new System.EventHandler(this.rd_CheckedChanged);
            // 
            // rd_5
            // 
            this.rd_5.AutoSize = true;
            this.rd_5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_5.Location = new System.Drawing.Point(21, 52);
            this.rd_5.Name = "rd_5";
            this.rd_5.Size = new System.Drawing.Size(133, 36);
            this.rd_5.TabIndex = 1;
            this.rd_5.Text = "100-1000";
            this.rd_5.UseVisualStyleBackColor = true;
            this.rd_5.CheckedChanged += new System.EventHandler(this.rd_CheckedChanged);
            // 
            // rd_4
            // 
            this.rd_4.AutoSize = true;
            this.rd_4.Checked = true;
            this.rd_4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_4.Location = new System.Drawing.Point(21, 14);
            this.rd_4.Name = "rd_4";
            this.rd_4.Size = new System.Drawing.Size(94, 36);
            this.rd_4.TabIndex = 0;
            this.rd_4.TabStop = true;
            this.rd_4.Text = "1-100";
            this.rd_4.UseVisualStyleBackColor = true;
            this.rd_4.CheckedChanged += new System.EventHandler(this.rd_CheckedChanged);
            // 
            // prnMath_011Num09Fraction_SortDivision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "prnMath_011Num09Fraction_SortDivision";
            this.Size = new System.Drawing.Size(1377, 707);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        private void rd_CheckedChanged(object sender, EventArgs e)
        {
           
            if (rd_4.Checked)
            {
                minValue = 1;
                maxValue = 100;
            }
          else  if (rd_5.Checked)
            {
                minValue = 100;
                maxValue = 1000;
            }
            else if (rd_6.Checked)
            {
                minValue = 1000;
                maxValue = 10000;
            }
            printPreviewControl1.Document = this.printDocument1;
        }

      

        //   public enum LongDivisionOption { IntegerNum, MixedNum, DecimalNum, RandomNum }

        //  private LongDivisionOption longDivisionOption;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail

            int yC = 150, xC = 100;
           // int w = 100, h = 40;
            for (int i = 0; i < 4; i++)
            {

                int a = RandomNumber.Randomnumber(2, 10);
                int b = RandomNumber.Randomnumber((minValue<100)?50:minValue, maxValue);
                // int _c;
            
                 if (rd_1.Checked)
                 {
                     b = b - (b % a);
                    // a =Convert.ToInt32( b / _a) + b%_a;
                 }
                 else if (rd_2.Checked)
                 {

                     b = b - (b % a) + ((a==2)?1:RandomNumber.Randomnumber(1, a));
                 }
                 else if (rd_3.Checked)
                 {
                     if (RandomNumber.Randomnumber(1, 1000) > 500)
                     {
                         b = b - (b % a);
                     }
                     else
                     {
                         b = b - (b % a) + ((a == 2) ? 1 : RandomNumber.Randomnumber(1, a ));
                     }

                 }


                e.Graphics.DrawString($"{b} ÷ { a} = ? ", new Font("Angsana New", 22), new SolidBrush(Color.Black), xC + 50, yC + 15);

               // e.Graphics.DrawString($")", new Font("Angsana New", 38), new SolidBrush(Color.Black), xC + 50, yC + 15);
                //  e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 250, yC, xC + 500, yC);
              //  e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 250, yC, xC + 250, yC + 25);
                e.Graphics.DrawString(")", new Font("Angsana New", 28), new SolidBrush(Color.Black), xC + 245, yC-8);
                yC += 32;
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 180, yC, xC + 240, yC);

                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 250, yC, xC + 500, yC); yC += 30;
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 250, yC, xC + 500, yC); yC += 30;
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 250, yC, xC + 500, yC); yC += 30;
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 250, yC, xC + 500, yC); yC += 30;
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 250, yC, xC + 500, yC); yC += 30;
                yC += 15;

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
