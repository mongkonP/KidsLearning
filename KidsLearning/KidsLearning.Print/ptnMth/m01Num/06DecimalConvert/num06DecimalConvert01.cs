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
    public partial class num06DecimalConvert01 : prnControl
    {
        public num06DecimalConvert01()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);

        }

        #region Variables

        int minValue = 1, maxValue = 15;

        #endregion
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;

        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "แปลงเลขฐานต่อไปนี้";
            iPage = 1;
            iPageAll = 1;

            printPreviewControl1.Document = this.printDocument1;
        }

        private void InitializeComponent()
        {
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(239, 614);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton5);
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Size = new System.Drawing.Size(233, 382);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            this.panel2.Controls.SetChildIndex(this.txtPageCount, 0);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.bntPrint, 0);
            this.panel2.Controls.SetChildIndex(this.radioButton1, 0);
            this.panel2.Controls.SetChildIndex(this.radioButton2, 0);
            this.panel2.Controls.SetChildIndex(this.radioButton3, 0);
            this.panel2.Controls.SetChildIndex(this.radioButton4, 0);
            this.panel2.Controls.SetChildIndex(this.radioButton5, 0);
            // 
            // bntPrint
            // 
            this.bntPrint.Location = new System.Drawing.Point(18, 335);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(147, 299);
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(70, 296);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 299);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(239, 0);
            this.groupBox2.Size = new System.Drawing.Size(1167, 614);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1161, 595);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioButton1.Location = new System.Drawing.Point(18, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(141, 22);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.Text = "เลขฐาน 10 ไปฐาน 2";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioButton2.Location = new System.Drawing.Point(17, 58);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(141, 22);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.Text = "เลขฐาน 10 ไปฐาน 8";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioButton3.Location = new System.Drawing.Point(18, 86);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(149, 22);
            this.radioButton3.TabIndex = 16;
            this.radioButton3.Text = "เลขฐาน 10 ไปฐาน 16";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioButton4.Location = new System.Drawing.Point(18, 114);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(142, 22);
            this.radioButton4.TabIndex = 20;
            this.radioButton4.Text = "เลขฐาน 10  ไปโรมัน";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.radioButton5.Location = new System.Drawing.Point(18, 142);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(70, 22);
            this.radioButton5.TabIndex = 22;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "แบบสุ่ม";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // num06DecimalConvert01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "num06DecimalConvert01";
            this.Size = new System.Drawing.Size(1406, 614);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        string _ConvertNumDecimaltoHexadecimal()
        {
            string s = "";
            int a = RandomNumber.Randomnumber(1, 2000);
            int n = RandomNumber.Randomnumber(1, 1000);
            string num = Convert.ToString(a, 16);
            if (a >= 1 && a < 1000)
            {
                s = $"แปลงค่าจากเลข จาก {n + "[sub]10[/sub]".ToSubscriptNumber()} เป็นเลขฐาน 16 ";
            }
            else
            {
                s = $"แปลงค่าจากเลข จาก {num + "[sub]16[/sub]".ToSubscriptNumber()} เป็นเลขฐาน 10 ";
            }
            return s;

        }
        string _ConvertNumDecimaltoOctal()
        {
            string s = "";
            int a = RandomNumber.Randomnumber(1, 2000);
            int n = RandomNumber.Randomnumber(1, 1000);
            string num = Convert.ToString(a, 8);
            if (a >= 1 && a < 1000)
            {
                s = $"แปลงค่าจากเลข จาก {n + "[sub]10[/sub]".ToSubscriptNumber()} เป็นเลขฐาน 8 ";
            }
            else
            {
                s = $"แปลงค่าจากเลข จาก {num + "[sub]8[/sub]".ToSubscriptNumber()} เป็นเลขฐาน 10 ";
            }
            return s;

        }
        string _ConvertNumDecimaltoBinary()
        {
            string s = "";
            int a = RandomNumber.Randomnumber(1, 2000);
            int n = RandomNumber.Randomnumber(1, 1000);
            string num = Convert.ToString(a, 2);
            if (a >= 1 && a < 1000)
            {
                s = $"แปลงค่าจากเลข จาก {n+"[sub]10[/sub]".ToSubscriptNumber()} เป็นเลขฐาน 2 ";
            }
            else
            {
                s = $"แปลงค่าจากเลข จาก {num + "[sub]2[/sub]".ToSubscriptNumber()} เป็นเลขฐาน 10 ";
            }
            return s;

        }
        string _ConvertRomanNum()
        {
            string s = "แปลงค่าจาก จาก {0} เป็น {1} ";
            int a = RandomNumber.Randomnumber(1, 9000);
            string _a = a.ToRomanNumber();
            int b = RandomNumber.Randomnumber(1, 2000);
            if (b >= 1 && b <1000)
            {
                s = $"แปลงค่าจาก จาก {a} เป็น เลขโรมัน ";
            }
            else
            {
                s = $"แปลงค่าจาก จาก {_a} เป็น เลขฐานสิบ ";
            }

            return string.Format(s);

        }
        string _ConvertNum()
        {
            string num = "";
            int a = RandomNumber.Randomnumber(1, 4000);
            if (radioButton1.Checked)
            {
                num = _ConvertNumDecimaltoBinary();
            }
            else if (radioButton2.Checked)
            {
                num = _ConvertNumDecimaltoOctal();
            }
            else if (radioButton3.Checked)
            {
                num = _ConvertNumDecimaltoHexadecimal();
            }
            else if (radioButton4.Checked)
            {
                num = _ConvertRomanNum();
            }
            else
            { 
            
            if (a >= 1 && a < 1000)
            {
                num = _ConvertNumDecimaltoHexadecimal();
            }
            else if (a >= 1001 && a < 2000)
            {
                num = _ConvertNumDecimaltoOctal();
            }
            else if (a >= 2001 && a < 3000)
            {
                num = _ConvertNumDecimaltoBinary();
            }
            else if (a >= 3001 && a <= 4000)
            {
                num = _ConvertRomanNum();
            }
            }
            
            return num;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            printPreviewControl1.Document = this.printDocument1;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail

            int yC = 120, xC = 150;
        
            for (int i = 1; i < 5; i++)
            {
                e.Graphics.DrawString( _ConvertNum(), fontExpression, new SolidBrush(Color.Black), xC, yC);

                yC = yC + 230;

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
