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
   public partial class num012gcf_lcm04_relationships : prnControl
    {

        public num012gcf_lcm04_relationships()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.rd_4 = new System.Windows.Forms.RadioButton();
            this.rd_5 = new System.Windows.Forms.RadioButton();
            this.rd_6 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Size = new System.Drawing.Size(244, 683);
            this.groupBox1.Controls.SetChildIndex(this.panel3, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel2, 0);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 161);
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
            this.groupBox2.Size = new System.Drawing.Size(1122, 683);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1116, 661);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.rd_6);
            this.panel3.Controls.Add(this.rd_5);
            this.panel3.Controls.Add(this.rd_4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 142);
            this.panel3.TabIndex = 18;
            // 
            // num012gcf_lcm04_relationships
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "num012gcf_lcm04_relationships";
            this.Size = new System.Drawing.Size(1366, 683);
            this.Load += new System.EventHandler(this.prn_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }


        #region Variables

        int minValue = 10, maxValue = 200;
        private Panel panel3;
        private RadioButton rd_6;
        private RadioButton rd_5;
        private RadioButton rd_4;
        Random random = new Random();
        #endregion




        private void prn_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "ความสัมพันธ์ระหว่าง ห.ร.ม. กับ  ค.ร.น.";
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
            int w = 50, h = 35, wr = 25;
            string sss;



            for (int i = 0; i < 4; i++)
            {

                int a = RandomNumber.Randomnumber(minValue, maxValue);
                int b = RandomNumber.Randomnumber(minValue, maxValue);
                int c = RandomNumber.Randomnumber(minValue, maxValue);
                int d = RandomNumber.Randomnumber(minValue, maxValue);
                sss = "ตัวประกอบของ ";

                if (rd_4.Checked)
                {
                    e.Graphics.DrawString($"{sss} {a} ได้แก่ _______________________________________________________\n" +
                                            $"{sss} { b} ได้แก่ _______________________________________________________\n" +
                                            $"ตัวที่ซ้ำกัน ได้แก่ _______________________________________________________\n" +
                                            $"ตัวที่ไม่ซ้ำกัน  ได้แก่ _______________________________________________________\n" +
                                            $"ดังนั้น ค.ร.น. ของ { a} และ { b } คือ ___________________________________________\n",
                        new Font("Angsana New", 18), new SolidBrush(Color.Black), xC, yC);
                }
                else if (rd_5.Checked)
                {
                    e.Graphics.DrawString($"{sss} {a} ได้แก่ _______________________________________________________\n" +
                                          $"{sss} { b} ได้แก่ _______________________________________________________\n" +
                                         $"{sss} { c} ได้แก่ _______________________________________________________\n" +
                                          $"ตัวที่ซ้ำกัน ได้แก่ _______________________________________________________\n" +
                                            $"ตัวที่ไม่ซ้ำกัน  ได้แก่ _______________________________________________________\n" +
                                          $"ดังนั้น ค.ร.น. ของ { a}, { b } และ { c }  คือ _______________________________________\n",
                                          new Font("Angsana New", 18), new SolidBrush(Color.Black), xC, yC);
                }
                else if (rd_6.Checked)
                {
                    e.Graphics.DrawString($"{sss} {a} ได้แก่ _______________________________________________________\n" +
                                          $"{sss} { b} ได้แก่ _______________________________________________________\n" +
                                         $"{sss} { c} ได้แก่ _______________________________________________________\n" +
                                         $"{sss} { d} ได้แก่ _______________________________________________________\n" +
                                        $"ตัวที่ซ้ำกัน ได้แก่ _______________________________________________________\n" +
                                            $"ตัวที่ไม่ซ้ำกัน  ได้แก่ _______________________________________________________\n" +
                                          $"ดังนั้น ค.ร.น. ของ { a}, { b },{c} และ { d }  คือ _______________________________________\n",
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
