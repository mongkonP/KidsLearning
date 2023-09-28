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

namespace KidsLearning.Print.ptnMth.m02OP
{
    public partial class op011Multipliedbyten : prnControl
    {

        public op011Multipliedbyten()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            panel1 = new Panel();
            rd_8 = new RadioButton();
            rd_7 = new RadioButton();
            rd_3 = new RadioButton();
            rd_2 = new RadioButton();
            rd_1 = new RadioButton();
            panel3 = new Panel();
            rd_6 = new RadioButton();
            rd_5 = new RadioButton();
            rd_4 = new RadioButton();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(panel1);
            groupBox1.Size = new Size(435, 0);
            groupBox1.Controls.SetChildIndex(panel1, 0);
            groupBox1.Controls.SetChildIndex(panel3, 0);
            groupBox1.Controls.SetChildIndex(panel2, 0);
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 398);
            panel2.Size = new Size(429, 127);
            // 
            // bntPrint
            // 
            bntPrint.Location = new Point(17, 60);
            // 
            // label2
            // 
            label2.Location = new Point(175, 21);
            // 
            // txtPageCount
            // 
            txtPageCount.Location = new Point(85, 18);
            // 
            // label1
            // 
            label1.Location = new Point(17, 21);
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(435, 0);
            groupBox2.Size = new Size(0, 0);
            // 
            // printPreviewControl1
            // 
            printPreviewControl1.Size = new Size(0, 0);
            // 
            // panel1
            // 
            panel1.Controls.Add(rd_8);
            panel1.Controls.Add(rd_7);
            panel1.Controls.Add(rd_3);
            panel1.Controls.Add(rd_2);
            panel1.Controls.Add(rd_1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(429, 231);
            panel1.TabIndex = 16;
            // 
            // rd_8
            // 
            rd_8.AutoSize = true;
            rd_8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rd_8.Location = new Point(21, 132);
            rd_8.Name = "rd_8";
            rd_8.Size = new Size(302, 36);
            rd_8.TabIndex = 4;
            rd_8.Text = "หารด้วยตัวเลขตามด้วย 10^n";
            rd_8.UseVisualStyleBackColor = true;
            rd_8.CheckedChanged += rd_1_CheckedChanged;
            // 
            // rd_7
            // 
            rd_7.AutoSize = true;
            rd_7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rd_7.Location = new Point(21, 94);
            rd_7.Name = "rd_7";
            rd_7.Size = new Size(302, 36);
            rd_7.TabIndex = 3;
            rd_7.Text = "คูณด้วยตัวเลขตามด้วย 10^n";
            rd_7.UseVisualStyleBackColor = true;
            rd_7.CheckedChanged += rd_1_CheckedChanged;
            // 
            // rd_3
            // 
            rd_3.AutoSize = true;
            rd_3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rd_3.Location = new Point(21, 174);
            rd_3.Name = "rd_3";
            rd_3.Size = new Size(98, 36);
            rd_3.TabIndex = 2;
            rd_3.Text = "แบบสุ่ม";
            rd_3.UseVisualStyleBackColor = true;
            rd_3.CheckedChanged += rd_1_CheckedChanged;
            // 
            // rd_2
            // 
            rd_2.AutoSize = true;
            rd_2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rd_2.Location = new Point(21, 52);
            rd_2.Name = "rd_2";
            rd_2.Size = new Size(371, 36);
            rd_2.TabIndex = 1;
            rd_2.Text = "หารด้วย 10 10^2  10^3 และ 10^4";
            rd_2.UseVisualStyleBackColor = true;
            // 
            // rd_1
            // 
            rd_1.AutoSize = true;
            rd_1.Checked = true;
            rd_1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rd_1.Location = new Point(21, 14);
            rd_1.Name = "rd_1";
            rd_1.Size = new Size(371, 36);
            rd_1.TabIndex = 0;
            rd_1.TabStop = true;
            rd_1.Text = "คูณด้วย 10 10^2  10^3 และ 10^4";
            rd_1.UseVisualStyleBackColor = true;
            rd_1.CheckedChanged += rd_1_CheckedChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(rd_6);
            panel3.Controls.Add(rd_5);
            panel3.Controls.Add(rd_4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 250);
            panel3.Name = "panel3";
            panel3.Size = new Size(429, 148);
            panel3.TabIndex = 17;
            // 
            // rd_6
            // 
            rd_6.AutoSize = true;
            rd_6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rd_6.Location = new Point(21, 92);
            rd_6.Name = "rd_6";
            rd_6.Size = new Size(98, 36);
            rd_6.TabIndex = 2;
            rd_6.Text = "แบบสุ่ม";
            rd_6.UseVisualStyleBackColor = true;
            rd_6.CheckedChanged += rd_1_CheckedChanged;
            // 
            // rd_5
            // 
            rd_5.AutoSize = true;
            rd_5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rd_5.Location = new Point(21, 52);
            rd_5.Name = "rd_5";
            rd_5.Size = new Size(182, 36);
            rd_5.TabIndex = 1;
            rd_5.Text = "ตัวตั้งเป็นทศนิยม";
            rd_5.UseVisualStyleBackColor = true;
            rd_5.CheckedChanged += rd_1_CheckedChanged;
            // 
            // rd_4
            // 
            rd_4.AutoSize = true;
            rd_4.Checked = true;
            rd_4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rd_4.Location = new Point(21, 14);
            rd_4.Name = "rd_4";
            rd_4.Size = new Size(209, 36);
            rd_4.TabIndex = 0;
            rd_4.TabStop = true;
            rd_4.Text = "ตัวตั้งเป็นจำนวนเต็ม";
            rd_4.UseVisualStyleBackColor = true;
            rd_4.CheckedChanged += rd_1_CheckedChanged;
            // 
            // op011Decimal_01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            Name = "op011Decimal_01";
            Size = new Size(0, 0);
            Load += prn_Load;
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }


        #region Variables

        int minValue = 10, maxValue = 200;
        private Panel panel1;
        private RadioButton rd_3;
        private RadioButton rd_2;
        private RadioButton rd_1;
        private Panel panel3;
        private RadioButton rd_6;
        private RadioButton rd_5;
        private RadioButton rd_4;
        private RadioButton rd_8;
        private RadioButton rd_7;
        Random random = new Random();
        #endregion




        private void prn_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "การคูณ/หาร ด้วย 10 100 1,000 และ 10,000";
            printPreviewControl1.Document = this.printDocument1;
        }
        string OP = "x";
        bool numInt = true;
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
            int w = 50, h = 35, wr = 25;
            double aa;
            for (int i = 0; i < 5; i++)
            {
                if (rd_1.Checked)
                {
                    OP = "x";
                }
                else if (rd_2.Checked)
                {
                    OP = "÷";
                }
                else if (rd_7.Checked)
                {
                    OP = "xInt";
                }
                else if (rd_8.Checked)
                {
                    OP = "÷Int";
                }
                else if (rd_3.Checked)
                {
                    int ddd = RandomNumber.Randomnumber(1, 4000);
                    switch (ddd)
                    {
                        case int n when n > 3000: OP = "x"; break;
                        case int n when n <= 3000 && n  > 2000: OP = "÷"; break;
                        case int n when n <= 2000  && n  > 1000: OP = "xInt"; break;
                        case int n when n  <= 1000: OP = "x"; break;
                        default: OP = "÷Int"; break;
                    }

                }

                if (rd_4.Checked)
                {
                    numInt = true;
                }
                else if (rd_5.Checked)
                {
                    numInt = false;
                }
                else if (rd_6.Checked)
                {
                    numInt = (RandomNumber.Randomnumber(1, 1000) > 500) ? true : false;
                }

                aa = random.NextDouble() * RandomNumber.Randomnumber(minValue, maxValue);

                int bb = RandomNumber.Randomnumber(2, 5);

                int cc = RandomNumber.Randomnumber(1, 4);
                int dd = Convert.ToInt32(Math.Pow(10, cc));

                string strOP;
                string _aa = (numInt) ? RandomNumber.Randomnumber(minValue, maxValue).ToString() : aa.ToString("N" + bb);
                if (OP == "x" || OP == "÷")
                {
                    strOP = _aa + " " + OP + " " + dd;
                }
                else
                {
                    strOP = RandomNumber.Randomnumber(minValue, maxValue) + " " + OP.Replace("Int", " " + RandomNumber.Randomnumber(2, 9) * dd);
                }

                e.Graphics.DrawString($"{strOP} = ?" +
                     " \n _______________________________________________________" +
                     " \n _______________________________________________________" +
                     " \n _______________________________________________________" +
                     " \n _______________________________________________________",
                    new Font("Angsana New", 16), new SolidBrush(Color.Black), xC, yC);

                yC += 180;

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
