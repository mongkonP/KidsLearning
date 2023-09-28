using KidsLearning.Classed;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TORServices.Maths;

namespace KidsLearning.Print.ptnMth.m09Polynomial
{
    public partial class _Monomial_Add_01 : prnControl
    {
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton1;

        public _Monomial_Add_01()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);

        }

        #region Variables



        #endregion

        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ พหุนาม ";
            ReportToppic = "การ บวก ลบ คูณ หาร พหุนาม แบบตั้งบวก/คูณ";
            iPage = 1;
            iPageAll = 1;


            printPreviewControl1.Document = this.printDocument1;
        }

        private void InitializeComponent()
        {
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Size = new System.Drawing.Size(221, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel1, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel3, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel2, 0);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 331);
            this.panel2.Size = new System.Drawing.Size(215, 118);
            // 
            // bntPrint
            // 
            this.bntPrint.Location = new System.Drawing.Point(9, 57);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(145, 23);
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(68, 21);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 23);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(221, 0);
            this.groupBox2.Size = new System.Drawing.Size(0, 0);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(0, 0);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioButton1.Location = new System.Drawing.Point(24, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(144, 28);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "การบวก พหุนาม";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioButton2.Location = new System.Drawing.Point(24, 64);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(135, 28);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.Text = "การลบ พหุนาม";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioButton3.Location = new System.Drawing.Point(24, 98);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(141, 28);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.Text = "การคูณ พหุนาม";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioButton5.Location = new System.Drawing.Point(24, 166);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(80, 28);
            this.radioButton5.TabIndex = 17;
            this.radioButton5.Text = "แบบสุ่ม";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 226);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButton6);
            this.panel3.Controls.Add(this.radioButton7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 242);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 89);
            this.panel3.TabIndex = 2;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioButton6.Location = new System.Drawing.Point(24, 10);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(72, 28);
            this.radioButton6.TabIndex = 1;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "ดีกรี 2";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioButton7.Location = new System.Drawing.Point(24, 44);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(72, 28);
            this.radioButton7.TabIndex = 14;
            this.radioButton7.Text = "ดีกรี 3";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // _Monomial_Add_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "_Monomial_Add_01";
            this.Size = new System.Drawing.Size(0, 0);
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

        private void prnMath_01Num07Odd02Number_Load(object sender, EventArgs e)
        {

            printPreviewControl1.Document = this.printDocument1;
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            printPreviewControl1.Document = this.printDocument1;
        }
        string _Draw()
        {

            string op = "";

            if (radioButton1.Checked)
            {
                op = "+";
            }
            else if (radioButton2.Checked)
            {
                op = "-";
            }
            else if (radioButton3.Checked)
            {
                op = "x";
            }
  
            else if (radioButton5.Checked)
            {
                int r = RandomNumber.Randomnumber(1, 3000);
                if (r >= 1 && r < 1000)
                {
                    op = "+";
                }
                else if (r >= 1000 && r < 2000)
                {
                    op = "-";
                }
                else if (r >= 2000 )
                {
                    op = "x";
                }

            }

            int d = (radioButton6.Checked) ? 2 : 3;
            string expression = TORServices.Maths.Expression.GenerateExpressionbyOperate(op, d);

            return expression;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            /* */

            #region _Draw Detail

            int yC = 150, xC = 120;
            int w = 100, h = 280;
             for (int row = 1; row < 4; row++)
             {
                 e.Graphics.DrawString(_Draw(), fontExpression, new SolidBrush(Color.Black), xC + 10, yC + 5);
                 yC += h;

             }
            #endregion


            if (iPage > iPageAll - 1)
             bNewPage =  bMorePagesToPrint = false;
            if (bNewPage) printDocumentNewPage(sender, e);


            iPage++;

            //If more lines exist, print another page.
            e.HasMorePages = (bMorePagesToPrint) ? true : false;
        }

    }
}
