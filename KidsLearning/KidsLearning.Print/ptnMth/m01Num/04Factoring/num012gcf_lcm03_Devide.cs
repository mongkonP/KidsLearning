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
    public partial class num012gcf_lcm03_Devide : prnControl
    {

        public num012gcf_lcm03_Devide()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            rd_4 = new RadioButton();
            rd_5 = new RadioButton();
            rd_6 = new RadioButton();
            panel3 = new Panel();
            panel4 = new Panel();
            rd_9 = new RadioButton();
            rd_8 = new RadioButton();
            rd_7 = new RadioButton();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(panel4);
            groupBox1.Size = new Size(270, 0);
            groupBox1.Controls.SetChildIndex(panel4, 0);
            groupBox1.Controls.SetChildIndex(panel3, 0);
            groupBox1.Controls.SetChildIndex(panel2, 0);
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 313);
            panel2.Size = new Size(264, 131);
            // 
            // bntPrint
            // 
            bntPrint.Location = new Point(12, 70);
            // 
            // label2
            // 
            label2.Location = new Point(170, 31);
            // 
            // txtPageCount
            // 
            txtPageCount.Location = new Point(80, 28);
            // 
            // label1
            // 
            label1.Location = new Point(12, 31);
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(270, 0);
            groupBox2.Size = new Size(0, 0);
            // 
            // printPreviewControl1
            // 
            printPreviewControl1.Size = new Size(0, 0);
            // 
            // rd_4
            // 
            rd_4.AutoSize = true;
            rd_4.Checked = true;
            rd_4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rd_4.Location = new Point(21, 14);
            rd_4.Name = "rd_4";
            rd_4.Size = new Size(185, 36);
            rd_4.TabIndex = 0;
            rd_4.TabStop = true;
            rd_4.Text = "แบบตัวเลข 2 ชุด";
            rd_4.UseVisualStyleBackColor = true;
            rd_4.CheckedChanged += rd_1_CheckedChanged;
            // 
            // rd_5
            // 
            rd_5.AutoSize = true;
            rd_5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rd_5.Location = new Point(21, 52);
            rd_5.Name = "rd_5";
            rd_5.Size = new Size(185, 36);
            rd_5.TabIndex = 1;
            rd_5.Text = "แบบตัวเลข 3 ชุด";
            rd_5.UseVisualStyleBackColor = true;
            rd_5.CheckedChanged += rd_1_CheckedChanged;
            // 
            // rd_6
            // 
            rd_6.AutoSize = true;
            rd_6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rd_6.Location = new Point(21, 94);
            rd_6.Name = "rd_6";
            rd_6.Size = new Size(185, 36);
            rd_6.TabIndex = 2;
            rd_6.Text = "แบบตัวเลข 4 ชุด";
            rd_6.UseVisualStyleBackColor = true;
            rd_6.CheckedChanged += rd_1_CheckedChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(rd_6);
            panel3.Controls.Add(rd_5);
            panel3.Controls.Add(rd_4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 171);
            panel3.Name = "panel3";
            panel3.Size = new Size(264, 142);
            panel3.TabIndex = 18;
            // 
            // panel4
            // 
            panel4.Controls.Add(rd_9);
            panel4.Controls.Add(rd_8);
            panel4.Controls.Add(rd_7);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(3, 19);
            panel4.Name = "panel4";
            panel4.Size = new Size(264, 152);
            panel4.TabIndex = 20;
            // 
            // rd_9
            // 
            rd_9.AutoSize = true;
            rd_9.Checked = true;
            rd_9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rd_9.Location = new Point(20, 94);
            rd_9.Name = "rd_9";
            rd_9.Size = new Size(184, 36);
            rd_9.TabIndex = 2;
            rd_9.TabStop = true;
            rd_9.Text = "ห.ร.ม. และ ค.ร.น.";
            rd_9.UseVisualStyleBackColor = true;
            rd_9.CheckedChanged += rd_1_CheckedChanged;
            // 
            // rd_8
            // 
            rd_8.AutoSize = true;
            rd_8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rd_8.Location = new Point(21, 52);
            rd_8.Name = "rd_8";
            rd_8.Size = new Size(85, 36);
            rd_8.TabIndex = 1;
            rd_8.Text = "ค.ร.น.";
            rd_8.UseVisualStyleBackColor = true;
            rd_8.CheckedChanged += rd_1_CheckedChanged;
            // 
            // rd_7
            // 
            rd_7.AutoSize = true;
            rd_7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            rd_7.Location = new Point(21, 14);
            rd_7.Name = "rd_7";
            rd_7.Size = new Size(84, 36);
            rd_7.TabIndex = 0;
            rd_7.Text = "ห.ร.ม.";
            rd_7.UseVisualStyleBackColor = true;
            rd_7.CheckedChanged += rd_1_CheckedChanged;
            // 
            // num012gcf_lcm03_Devide
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            Name = "num012gcf_lcm03_Devide";
            Size = new Size(0, 0);
            Load += prn_Load;
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }


        #region Variables

        int minValue = 10, maxValue = 200;
        private Panel panel3;
        private RadioButton rd_6;
        private RadioButton rd_5;
        private RadioButton rd_4;
        private Panel panel4;
        private RadioButton rd_9;
        private RadioButton rd_8;
        private RadioButton rd_7;
        Random random = new Random();
        #endregion




        private void prn_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "การหา ห.ร.ม. และ ค.ร.น. โดยการหาร";
            printPreviewControl1.Document = this.printDocument1;
        }

        private void rd_1_CheckedChanged(object sender, EventArgs e)
        {

            printPreviewControl1.Document = this.printDocument1;
        }
        int RandomValue(int st, int c)
        {
            int r = st;
            for (int m = 0; m <= ((c > 3) ? 1 : RandomNumber.Randomnumber(1, 3)); m++)
            {

                r *= (st > 50) ? RandomNumber.Randomnumber(2, 5) : RandomNumber.Randomnumber(2, 10);

            }
            return r;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail

            int yC = 150, xC = 100;
            int w = 50, h = 35, wr = 25;
            string sss;



            for (int i = 0; i < 4; i++)
            {

                int _numscommonfactor = 1;
                int _c = 0;
                for (int m = 0; m <= RandomNumber.Randomnumber(1, 3); m++)
                {
                    if (_numscommonfactor <= 20)
                    {
                        _numscommonfactor *= RandomNumber.Randomnumber(2, 5);
                        _c++;
                    }

                }
                int a = RandomValue(_numscommonfactor, _c);
                int b = RandomValue(_numscommonfactor, _c);
                int c = RandomValue(_numscommonfactor, _c);
                int d = RandomValue(_numscommonfactor, _c);

                sss = "ตัวประกอบของ ";
                string s = (rd_7.Checked) ? "ห.ร.ม. " : ((rd_8.Checked) ? "ค.ร.น." : " ห.ร.ม. และ ค.ร.น.");
                if (rd_4.Checked)
                {
                    e.Graphics.DrawString($"ให้หา {s} ของ {a} และ {b} ด้วยการหาร \n",
                        new Font("Angsana New", 18), new SolidBrush(Color.Black), xC, yC);
                }
                else if (rd_5.Checked)
                {
                    e.Graphics.DrawString($"ให้หา {s} ของ {a}, {b} และ {c}  ด้วยการหาร \n",
                                          new Font("Angsana New", 18), new SolidBrush(Color.Black), xC, yC);
                }
                else if (rd_6.Checked)
                {
                    e.Graphics.DrawString($"ให้หา {s} ของ {a}, {b},{c} และ {d} ด้วยการหาร \n",
                                          new Font("Angsana New", 18), new SolidBrush(Color.Black), xC, yC);
                }

                yC += 230;



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
