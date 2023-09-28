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
using System.Text.RegularExpressions;
using KidsLearning.Classed;

namespace KidsLearning.Print.ptnMth.m05GaugeUnit
{
  public partial  class prnMath_001DateTime002NextTime : prnControl
    {
        public prnMath_001DateTime002NextTime()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
        
        }

        #region Variables

        int minValue = 1, maxValue = 15;

        #endregion
        private RadioButton rd_1;
        private RadioButton rd_4;
        private RadioButton rd_3;
        private RadioButton rd_2;

        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ วัน เวลา ";
            ReportToppic = "ให้วาดเข็มนาฬิกาด้วยไม้บรรทัด และ ตอบคำถาม ต่อไป นี้ ต่อไปนี้";
            iPage = 1;
            iPageAll = 1;
            
            printPreviewControl1.Document = this.printDocument1;
        }

        private void InitializeComponent()
        {
            this.rd_1 = new System.Windows.Forms.RadioButton();
            this.rd_2 = new System.Windows.Forms.RadioButton();
            this.rd_3 = new System.Windows.Forms.RadioButton();
            this.rd_4 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(314, 720);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rd_4);
            this.panel2.Controls.Add(this.rd_3);
            this.panel2.Controls.Add(this.rd_2);
            this.panel2.Controls.Add(this.rd_1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            this.panel2.Size = new System.Drawing.Size(308, 402);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            this.panel2.Controls.SetChildIndex(this.txtPageCount, 0);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.bntPrint, 0);
            this.panel2.Controls.SetChildIndex(this.rd_1, 0);
            this.panel2.Controls.SetChildIndex(this.rd_2, 0);
            this.panel2.Controls.SetChildIndex(this.rd_3, 0);
            this.panel2.Controls.SetChildIndex(this.rd_4, 0);
            // 
            // bntPrint
            // 
            this.bntPrint.Location = new System.Drawing.Point(7, 329);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(165, 290);
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(75, 287);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 290);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(314, 0);
            this.groupBox2.Size = new System.Drawing.Size(695, 720);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(689, 698);
            // 
            // rd_1
            // 
            this.rd_1.AutoSize = true;
            this.rd_1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_1.Location = new System.Drawing.Point(8, 27);
            this.rd_1.Name = "rd_1";
            this.rd_1.Size = new System.Drawing.Size(182, 34);
            this.rd_1.TabIndex = 14;
            this.rd_1.Text = "บอกเวลาเป็นชั่วโมง";
            this.rd_1.UseVisualStyleBackColor = true;
            this.rd_1.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_2
            // 
            this.rd_2.AutoSize = true;
            this.rd_2.Checked = true;
            this.rd_2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_2.Location = new System.Drawing.Point(9, 67);
            this.rd_2.Name = "rd_2";
            this.rd_2.Size = new System.Drawing.Size(222, 34);
            this.rd_2.TabIndex = 15;
            this.rd_2.TabStop = true;
            this.rd_2.Text = "บอกเวลาเป็นชั่วโมง นาที";
            this.rd_2.UseVisualStyleBackColor = true;
            this.rd_2.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_3
            // 
            this.rd_3.AutoSize = true;
            this.rd_3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_3.Location = new System.Drawing.Point(9, 107);
            this.rd_3.Name = "rd_3";
            this.rd_3.Size = new System.Drawing.Size(272, 34);
            this.rd_3.TabIndex = 16;
            this.rd_3.Text = "บอกเวลาเป็นชั่วโมง นาที วินาที";
            this.rd_3.UseVisualStyleBackColor = true;
            this.rd_3.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_4
            // 
            this.rd_4.AutoSize = true;
            this.rd_4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_4.Location = new System.Drawing.Point(9, 147);
            this.rd_4.Name = "rd_4";
            this.rd_4.Size = new System.Drawing.Size(100, 34);
            this.rd_4.TabIndex = 17;
            this.rd_4.Text = "สุ่ม เลือก";
            this.rd_4.UseVisualStyleBackColor = true;
            this.rd_4.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // prnMath_010DateTime002NextTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "prnMath_010DateTime002NextTime";
            this.Size = new System.Drawing.Size(1009, 720);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
       private int Leval;

        private void rd_1_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_1.Checked)
            {
                Leval = 0;
            }
            else if (rd_2.Checked)
            {
                Leval = 1;
            }
            else if (rd_3.Checked)
            {
                Leval = 2;
            }
            else if (rd_4.Checked)
            {
                Leval = 3;
            }

            printPreviewControl1.Document = this.printDocument1;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail

            int yC = 120, xC = 100;
            for (int i = 0; i < 5; i++)
            {

                e.Graphics.DrawClock(RandomNumber.Randomnumber(0, 12), RandomNumber.Randomnumber(0, 60), RandomNumber.Randomnumber(0, 60), xC, yC);
                e.Graphics.DrawClock(xC + 500, yC);
                string str = "นาฬิกาบอกเวลา ____:____:____";
                string t = "";
                if (Leval == 0)
                {
                    t = $"{RandomNumber.Randomnumber(1, 30)} ชั่วโมง ";
                }
                else if (Leval == 1)
                {
                    t = $"{ RandomNumber.Randomnumber(1, 30)} ชั่วโมง {RandomNumber.Randomnumber(1, 60)} นาที ";
                }
                else if (Leval == 2)
                {
                    t = $"{RandomNumber.Randomnumber(1, 30)} ชั่วโมง {RandomNumber.Randomnumber(1, 60)} นาที {RandomNumber.Randomnumber(1, 60)} วินาที ";
                }
                else if (Leval == 3)
                {
                    int a = RandomNumber.Randomnumber(1, 3000);
                    if (a > 0 && a < 1000)
                    {
                        t = $"{RandomNumber.Randomnumber(1, 30)} ชั่วโมง ";
                    }
                    else if (a >= 1000 && a < 2000)
                    {
                        t = $"{ RandomNumber.Randomnumber(1, 30)} ชั่วโมง {RandomNumber.Randomnumber(1, 60)} นาที ";
                    }
                    else
                    {
                        t = $"{RandomNumber.Randomnumber(1, 30)} ชั่วโมง {RandomNumber.Randomnumber(1, 60)} นาที {RandomNumber.Randomnumber(1, 60)} วินาที ";
                    }

                }
                str += "\n" + ((RandomNumber.Randomnumber(0, 1000) > 500) ? "ย้อนกลับไปอีก " + t : $"อีก {t } ข้างหน้า");
                str += "\nจะเป็นเวลา ____:____:____";
                e.Graphics.DrawString(str, fontDetail, new SolidBrush(Color.Black), xC + 200, yC + 50);


                yC += 170;

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
