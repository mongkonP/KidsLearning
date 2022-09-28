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

namespace KidsLearning.Print.ptnMth.m01Num
{
   public partial class num012gcf_lcm : prnControl
    {

        public num012gcf_lcm()
        {
            InitializeComponent();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.rd_8 = new System.Windows.Forms.RadioButton();
            this.rd_7 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Size = new System.Drawing.Size(244, 667);
            this.groupBox1.Controls.SetChildIndex(this.panel4, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel1, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel3, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel2, 0);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 411);
            this.panel2.Size = new System.Drawing.Size(238, 131);
            // 
            // bntPrint
            // 
            this.bntPrint.Location = new System.Drawing.Point(12, 70);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(170, 31);
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(80, 28);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 31);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(244, 0);
            this.groupBox2.Size = new System.Drawing.Size(1132, 667);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1126, 645);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rd_3);
            this.panel1.Controls.Add(this.rd_2);
            this.panel1.Controls.Add(this.rd_1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 148);
            this.panel1.TabIndex = 17;
            // 
            // rd_3
            // 
            this.rd_3.AutoSize = true;
            this.rd_3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_3.Location = new System.Drawing.Point(21, 92);
            this.rd_3.Name = "rd_3";
            this.rd_3.Size = new System.Drawing.Size(107, 36);
            this.rd_3.TabIndex = 2;
            this.rd_3.Text = "1-1000";
            this.rd_3.UseVisualStyleBackColor = true;
            this.rd_3.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_2
            // 
            this.rd_2.AutoSize = true;
            this.rd_2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_2.Location = new System.Drawing.Point(21, 52);
            this.rd_2.Name = "rd_2";
            this.rd_2.Size = new System.Drawing.Size(94, 36);
            this.rd_2.TabIndex = 1;
            this.rd_2.Text = "1-100";
            this.rd_2.UseVisualStyleBackColor = true;
            this.rd_2.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_1
            // 
            this.rd_1.AutoSize = true;
            this.rd_1.Checked = true;
            this.rd_1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_1.Location = new System.Drawing.Point(21, 14);
            this.rd_1.Name = "rd_1";
            this.rd_1.Size = new System.Drawing.Size(81, 36);
            this.rd_1.TabIndex = 0;
            this.rd_1.TabStop = true;
            this.rd_1.Text = "1-50";
            this.rd_1.UseVisualStyleBackColor = true;
            this.rd_1.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rd_6);
            this.panel3.Controls.Add(this.rd_5);
            this.panel3.Controls.Add(this.rd_4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 269);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 142);
            this.panel3.TabIndex = 18;
            // 
            // rd_6
            // 
            this.rd_6.AutoSize = true;
            this.rd_6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_6.Location = new System.Drawing.Point(21, 94);
            this.rd_6.Name = "rd_6";
            this.rd_6.Size = new System.Drawing.Size(185, 36);
            this.rd_6.TabIndex = 2;
            this.rd_6.Text = "แบบตัวเลข 4 ชุด";
            this.rd_6.UseVisualStyleBackColor = true;
            this.rd_6.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_5
            // 
            this.rd_5.AutoSize = true;
            this.rd_5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_5.Location = new System.Drawing.Point(21, 52);
            this.rd_5.Name = "rd_5";
            this.rd_5.Size = new System.Drawing.Size(185, 36);
            this.rd_5.TabIndex = 1;
            this.rd_5.Text = "แบบตัวเลข 3 ชุด";
            this.rd_5.UseVisualStyleBackColor = true;
            this.rd_5.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_4
            // 
            this.rd_4.AutoSize = true;
            this.rd_4.Checked = true;
            this.rd_4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_4.Location = new System.Drawing.Point(21, 14);
            this.rd_4.Name = "rd_4";
            this.rd_4.Size = new System.Drawing.Size(185, 36);
            this.rd_4.TabIndex = 0;
            this.rd_4.TabStop = true;
            this.rd_4.Text = "แบบตัวเลข 2 ชุด";
            this.rd_4.UseVisualStyleBackColor = true;
            this.rd_4.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rd_8);
            this.panel4.Controls.Add(this.rd_7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(238, 102);
            this.panel4.TabIndex = 19;
            // 
            // rd_8
            // 
            this.rd_8.AutoSize = true;
            this.rd_8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_8.Location = new System.Drawing.Point(21, 52);
            this.rd_8.Name = "rd_8";
            this.rd_8.Size = new System.Drawing.Size(85, 36);
            this.rd_8.TabIndex = 1;
            this.rd_8.Text = "ค.ร.น.";
            this.rd_8.UseVisualStyleBackColor = true;
            this.rd_8.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_7
            // 
            this.rd_7.AutoSize = true;
            this.rd_7.Checked = true;
            this.rd_7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_7.Location = new System.Drawing.Point(21, 14);
            this.rd_7.Name = "rd_7";
            this.rd_7.Size = new System.Drawing.Size(84, 36);
            this.rd_7.TabIndex = 0;
            this.rd_7.TabStop = true;
            this.rd_7.Text = "ห.ร.ม.";
            this.rd_7.UseVisualStyleBackColor = true;
            this.rd_7.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // num012gcf_lcm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "num012gcf_lcm";
            this.Size = new System.Drawing.Size(1376, 667);
            this.Load += new System.EventHandler(this.prn_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

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
        private Panel panel4;
        private RadioButton rd_8;
        private RadioButton rd_7;
        Random random = new Random();
        #endregion



   
        private void prn_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "คูณร่วมน้อย(ค.ร.น.) และ หารร่วมมาก(ห.ร.ม.)";
            printPreviewControl1.Document = this.printDocument1;
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
            int w = 50, h = 35,wr = 25;
            string sss;
            
                if (rd_1.Checked)
                {
                    minValue = (rd_8.Checked)?2:10; maxValue = 50;
                }
                else if (rd_2.Checked)
                {
                    minValue = (rd_8.Checked) ? 2 : 10; maxValue = 100;
                }
                else if (rd_3.Checked)
                {
                    minValue = (rd_8.Checked) ? 2 : 10; maxValue = 1000;
                }
                else
                {
                    minValue = (rd_8.Checked) ? 2 : 10; maxValue = 50;
                   
                }
           
            
            for (int i = 0; i < 4; i++)
            {
              
                int a  = RandomNumberGenerator.GetInt32(minValue, maxValue);
                int b = RandomNumberGenerator.GetInt32(minValue, maxValue);
                int c = RandomNumberGenerator.GetInt32(minValue, maxValue);
                int d = RandomNumberGenerator.GetInt32(minValue, maxValue);
                sss = (rd_7.Checked)?"ตัวประกอบของ ": "พหุคูณของ ";
                if (rd_4.Checked)
                {
                    e.Graphics.DrawString($"{sss} {a} ได้แก่ _______________________________________________________\n" +
                                            $"{sss} { b} ได้แก่ _______________________________________________________\n" +
                                            ((rd_7.Checked) ? $"ดังนั้น ห.ร.ม. ของ { a} และ { b } คือ ___________________________________________\n":
                                            $"ดังนั้น ค.ร.น. ของ { a} และ { b } คือ ___________________________________________\n"),
                        new Font("Angsana New", 18), new SolidBrush(Color.Black), xC, yC);
                }
                else if (rd_5.Checked)
                {
                    e.Graphics.DrawString($"{sss} {a} ได้แก่ _______________________________________________________\n" +
                                          $"{sss} { b} ได้แก่ _______________________________________________________\n" +
                                         $"{sss} { c} ได้แก่ _______________________________________________________\n" +
                                         ((rd_7.Checked)? $"ดังนั้น ห.ร.ม. ของ { a}, { b } และ { c } คือ ______________________________________\n":
                                          $"ดังนั้น ค.ร.น. ของ { a}, { b } และ { c }  คือ _______________________________________\n"),
                                          new Font("Angsana New", 18), new SolidBrush(Color.Black), xC, yC);
                }
                else if (rd_6.Checked)
                {
                    e.Graphics.DrawString($"{sss} {a} ได้แก่ _______________________________________________________\n" +
                                          $"{sss} { b} ได้แก่ _______________________________________________________\n" +
                                         $"{sss} { c} ได้แก่ _______________________________________________________\n" +
                                         $"{sss} { d} ได้แก่ _______________________________________________________\n" +
                                         ((rd_7.Checked) ? $"ดังนั้น ห.ร.ม. ของ { a}, { b },{c} และ { d } คือ ______________________________________\n" :
                                          $"ดังนั้น ค.ร.น. ของ { a}, { b },{c} และ { d }  คือ _______________________________________\n"),
                                          new Font("Angsana New", 18), new SolidBrush(Color.Black), xC, yC);
                }
                
                
                yC += 230 ;

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
