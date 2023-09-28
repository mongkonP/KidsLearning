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
    public partial class op004PlusMinus_Num_01 : prnControl
    {
        public op004PlusMinus_Num_01()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);

        }

        #region Variables

        int minValue = 1, maxValue = 12;
        string Opr = "+";
        bool ramdomRect = false;
        #endregion
        private Classed.Controls.NumberSelect01 numberSelect1;
        private GroupBox groupBox4;
        private RadioButton rd_5;
        private RadioButton rd_4;
        private GroupBox groupBox3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton rd_6;

        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "เติมคำตอบลงในช่องสี่เหลี่ยม ต่อไป นี้";
            iPage = 1;
            iPageAll = 1;

            printPreviewControl1.Document = this.printDocument1;
        }

        private void InitializeComponent()
        {
            this.numberSelect1 = new KidsLearning.Classed.Controls.NumberSelect01();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rd_5 = new System.Windows.Forms.RadioButton();
            this.rd_4 = new System.Windows.Forms.RadioButton();
            this.rd_6 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.numberSelect1);
            this.groupBox1.Size = new System.Drawing.Size(393, 667);
            this.groupBox1.Controls.SetChildIndex(this.numberSelect1, 0);
            this.groupBox1.Controls.SetChildIndex(this.groupBox4, 0);
            this.groupBox1.Controls.SetChildIndex(this.groupBox3, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel2, 0);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 621);
            this.panel2.Size = new System.Drawing.Size(387, 103);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(393, 0);
            this.groupBox2.Size = new System.Drawing.Size(991, 667);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(985, 648);
            // 
            // numberSelect1
            // 
            this.numberSelect1.Dock = System.Windows.Forms.DockStyle.Top;
            this.numberSelect1.Location = new System.Drawing.Point(3, 16);
            this.numberSelect1.Name = "numberSelect1";
            this.numberSelect1.Size = new System.Drawing.Size(387, 311);
            this.numberSelect1.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rd_5);
            this.groupBox4.Controls.Add(this.rd_4);
            this.groupBox4.Controls.Add(this.rd_6);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.groupBox4.Location = new System.Drawing.Point(3, 327);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(387, 159);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ดำเนินการ";
            // 
            // rd_5
            // 
            this.rd_5.AutoSize = true;
            this.rd_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.rd_5.Location = new System.Drawing.Point(13, 78);
            this.rd_5.Name = "rd_5";
            this.rd_5.Size = new System.Drawing.Size(134, 35);
            this.rd_5.TabIndex = 36;
            this.rd_5.Text = "การลบ (-)";
            this.rd_5.UseVisualStyleBackColor = true;
            // 
            // rd_4
            // 
            this.rd_4.AutoSize = true;
            this.rd_4.Checked = true;
            this.rd_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.rd_4.Location = new System.Drawing.Point(13, 42);
            this.rd_4.Name = "rd_4";
            this.rd_4.Size = new System.Drawing.Size(156, 35);
            this.rd_4.TabIndex = 34;
            this.rd_4.TabStop = true;
            this.rd_4.Text = "การบวก (+)";
            this.rd_4.UseVisualStyleBackColor = true;
            // 
            // rd_6
            // 
            this.rd_6.AutoSize = true;
            this.rd_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.rd_6.Location = new System.Drawing.Point(13, 114);
            this.rd_6.Name = "rd_6";
            this.rd_6.Size = new System.Drawing.Size(120, 35);
            this.rd_6.TabIndex = 35;
            this.rd_6.Text = "สุ่ม (+/-)";
            this.rd_6.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.groupBox3.Location = new System.Drawing.Point(3, 486);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 135);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ตัวเลือก";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.radioButton1.Location = new System.Drawing.Point(13, 78);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(133, 35);
            this.radioButton1.TabIndex = 36;
            this.radioButton1.Text = "สุ่มคำตอบ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.radioButton2.Location = new System.Drawing.Point(13, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(130, 35);
            this.radioButton2.TabIndex = 34;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "หาคำตอบ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // op004PlusMinus_Num_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "op004PlusMinus_Num_01";
            this.Size = new System.Drawing.Size(1384, 667);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        private void rd_4_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_4.Checked)
            {
                Opr = "+";
            }
            else if (rd_5.Checked)
            {
                Opr = "-";
            }
            else if (rd_6.Checked)
            {

                Opr = "+/-";
            }

            if (radioButton1.Checked)
            {
                ramdomRect = true;
            }
            else if (radioButton2.Checked)
            {
                ramdomRect = false;
            }
            printPreviewControl1.Document = this.printDocument1;
        }


        private void numberSelect1_NumberSelectChanged(object sender, EventArgs e)
        {
            minValue = Convert.ToInt32(numberSelect1.Minimum);
            maxValue = Convert.ToInt32(numberSelect1.Maximum);
            printPreviewControl1.Document = this.printDocument1;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail


            int yC = 100;
            int xC = 100;
            int w = 80, h = 50;


            xC = 100;
            yC = yC + 50; string sOP;
            for (int i = 1; i <= 10; i++)
            {

                /* int a = RandomNumber.Randomnumber(minValue, maxValue);
                 int b = RandomNumber.Randomnumber(minValue, maxValue);
                 int _a = Math.Min(a, b),_b =Math.Max(a, b);*/

                if (Opr == "+")
                {
                    sOP = " + ";
                }
                else if (Opr == "-")
                {
                    sOP = " - ";
                }
                else
                {

                    if (RandomNumber.Randomnumber(1, 2000) > 1000)
                    {
                        sOP = " + ";
                    }
                    else
                    {
                        sOP = " - ";
                    }


                }

                e.Graphics.DrawPlusMinusFillRectangle(sOP, ramdomRect, minValue, maxValue, this.numberSelect1.Decimal, new Font("Arial", 22), xC, yC);



                yC = yC + 80;


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
