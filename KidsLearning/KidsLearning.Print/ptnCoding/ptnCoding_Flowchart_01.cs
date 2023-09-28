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

namespace KidsLearning.Print.ptnCoding
{
  public partial  class ptnCoding_Flowchart_01:prnControl
    {
        private Panel panel3;
        private RadioButton rdS_2;
        private RadioButton rdS_1;
        private Panel panel1;
        private RadioButton rd_3;
        private RadioButton rd_2;
        private RadioButton rd_1;

        public ptnCoding_Flowchart_01()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            this.rd_1.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            this.rd_2.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            this.rd_3.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            this.rdS_1.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            this.rdS_2.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
        }


        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบด้านโปรแกรม";
            ReportToppic = "เขียนขั้นตอนจากโจทย์ต่อไปนี้";
            iPage = 1;
            iPageAll = 1;
            
            printPreviewControl1.Document = this.printDocument1;
        }

        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdS_2 = new System.Windows.Forms.RadioButton();
            this.rdS_1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rd_3 = new System.Windows.Forms.RadioButton();
            this.rd_2 = new System.Windows.Forms.RadioButton();
            this.rd_1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Size = new System.Drawing.Size(315, 727);
            this.groupBox1.Controls.SetChildIndex(this.panel1, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel3, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel2, 0);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 348);
            this.panel2.Size = new System.Drawing.Size(309, 119);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(315, 0);
            this.groupBox2.Size = new System.Drawing.Size(863, 727);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(857, 705);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdS_2);
            this.panel3.Controls.Add(this.rdS_1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 171);
            this.panel3.TabIndex = 19;
            // 
            // rdS_2
            // 
            this.rdS_2.AutoSize = true;
            this.rdS_2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdS_2.Location = new System.Drawing.Point(39, 100);
            this.rdS_2.Name = "rdS_2";
            this.rdS_2.Size = new System.Drawing.Size(131, 34);
            this.rdS_2.TabIndex = 17;
            this.rdS_2.Text = "ไม่มีผังงานให้";
            this.rdS_2.UseVisualStyleBackColor = true;
            // 
            // rdS_1
            // 
            this.rdS_1.AutoSize = true;
            this.rdS_1.Checked = true;
            this.rdS_1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdS_1.Location = new System.Drawing.Point(39, 54);
            this.rdS_1.Name = "rdS_1";
            this.rdS_1.Size = new System.Drawing.Size(111, 34);
            this.rdS_1.TabIndex = 16;
            this.rdS_1.TabStop = true;
            this.rdS_1.Text = "มีผังงานให้";
            this.rdS_1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rd_3);
            this.panel1.Controls.Add(this.rd_2);
            this.panel1.Controls.Add(this.rd_1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 158);
            this.panel1.TabIndex = 18;
            // 
            // rd_3
            // 
            this.rd_3.AutoSize = true;
            this.rd_3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_3.Location = new System.Drawing.Point(40, 109);
            this.rd_3.Name = "rd_3";
            this.rd_3.Size = new System.Drawing.Size(130, 34);
            this.rd_3.TabIndex = 19;
            this.rd_3.Text = "การทำซ้ำ  1";
            this.rd_3.UseVisualStyleBackColor = true;
            // 
            // rd_2
            // 
            this.rd_2.AutoSize = true;
            this.rd_2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_2.Location = new System.Drawing.Point(39, 69);
            this.rd_2.Name = "rd_2";
            this.rd_2.Size = new System.Drawing.Size(258, 34);
            this.rd_2.TabIndex = 17;
            this.rd_2.Text = "การเลือกกระทำตามเงื่อนไข 1";
            this.rd_2.UseVisualStyleBackColor = true;
            // 
            // rd_1
            // 
            this.rd_1.AutoSize = true;
            this.rd_1.Checked = true;
            this.rd_1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_1.Location = new System.Drawing.Point(39, 23);
            this.rd_1.Name = "rd_1";
            this.rd_1.Size = new System.Drawing.Size(244, 34);
            this.rd_1.TabIndex = 16;
            this.rd_1.TabStop = true;
            this.rd_1.Text = "การทำงานแบบตามลำดับ 1";
            this.rd_1.UseVisualStyleBackColor = true;
            // 
            // ptnCoding_Flowchart_02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "ptnCoding_Flowchart_02";
            this.Size = new System.Drawing.Size(1178, 727);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        string SOP = "1"; bool ShowFlow = true;
        private void rd_1_CheckedChanged(object sender, EventArgs e)
        {

            if (rd_1.Checked)
            {
                SOP = "1";
            }
            else if (rd_2.Checked)
            { SOP = "2"; }
            else if (rd_3.Checked)
            { SOP = "3"; }

            ShowFlow = rdS_1.Checked;
            // MessageBox.Show(SOP);
            printPreviewControl1.Document = this.printDocument1;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail

            List<int> Nums = new List<int>();
            int yC = 120;
            int xC = 100;

            Pen pen = new Pen(Color.Black, 2);
            SolidBrush solidBrush = new SolidBrush(Color.White);
            //  MessageBox.Show("SOP = " + SOP);
            if (SOP == "1")
            {
                //  MessageBox.Show("1");
                for (int i = 1; i <= 2; i++)
                {

                    int a = RandomNumber.Randomnumber(1, 100);
                    int b = RandomNumber.Randomnumber(1, 100);
                    string s = (RandomNumber.Randomnumber(1, 1000) > 500) ? "+" : "x";
                    e.Graphics.DrawString($"เขียนขั้นตอนของ {a} {s} {b} =?", new Font("Arial", 14), new SolidBrush(Color.Black), xC, yC);
                    e.Graphics.DrawString($"โฟลว์ชาร์ต#", new Font("Arial", 14), new SolidBrush(Color.Black), xC + 50, yC + 50);
                    if (ShowFlow)
                    {
                        e.Graphics.DrawImage(Image.FromFile(Application.StartupPath + @"\File\PIC\Coding\FlwPlusNum.png"), xC + 150, yC + 100);
                    }

                    yC = yC + 450;

                }
            }
            else if (SOP == "2")
            {
                // MessageBox.Show("2");
                int a = RandomNumber.Randomnumber(1, 100);
                int b = RandomNumber.Randomnumber(1, 100);
                int c = RandomNumber.Randomnumber(1, 10000);
                if (c > 5000)
                {
                    e.Graphics.DrawString($"เขียนขั้นตอนของ {a} ว่าเป็นจำนวนคู่หรือไม่ \n โดยถ้าเป็นจำนวนคู่ ให้แสดงคำว่า คู่", new Font("Arial", 14), new SolidBrush(Color.Black), xC, yC);
                    e.Graphics.DrawString($"โฟลว์ชาร์ต#", new Font("Arial", 14), new SolidBrush(Color.Black), xC + 50, yC + 80);
                    if (ShowFlow)
                    {
                        e.Graphics.DrawImage(Image.FromFile(Application.StartupPath + @"\File\PIC\Coding\FlwIf.png"), xC + 100, yC + 150);
                    }
                }
                else
                {
                    e.Graphics.DrawString($"เขียนขั้นตอนของ {a} ว่าเป็นจำนวนคู่หรือไม่ \n โดยถ้าเป็นจำนวนคู่ ให้แสดงคำว่า คู่ ถ้าไม่ใช่ให้แสดงคำว่า คี่", new Font("Arial", 14), new SolidBrush(Color.Black), xC, yC);
                    e.Graphics.DrawString($"โฟลว์ชาร์ต#", new Font("Arial", 14), new SolidBrush(Color.Black), xC + 50, yC + 80);
                    if (ShowFlow)
                    {
                        e.Graphics.DrawImage(Image.FromFile(Application.StartupPath + @"\File\PIC\Coding\FlwIfElse.png"), xC , yC + 150);
                    }
                }

            }
            else if (SOP == "3")
            {
                int a = 1;
                int b = RandomNumber.Randomnumber(1, 100);
                string s = "";
                int c = RandomNumber.Randomnumber(1, 10000);
                if (c < 3000)
                {
                    a = RandomNumber.Randomnumber(1, 10);
                    s = "เขียนตั้นตอนสูตรคูณแม่ " + a;
                }
                else if (a > 3000 && a < 6000)
                {

                    a = RandomNumber.Randomnumber(1, 10);
                    if (RandomNumber.Randomnumber(1, 1000) > 500)
                        s = "เขียนตั้นตอนการบวก เพิ่ม ที่ละ 1 จาก 0 จนถึง " + a;
                    else
                        s = $"เขียนตั้นตอนการบวก ลดลง ที่ละ 1 จาก {a} จนถึง {0}";
                }
                else
                {
                    a = RandomNumber.Randomnumber(5, 20);
                    b = RandomNumber.Randomnumber(5, 10);
                    int d = RandomNumber.Randomnumber(1, 3000);
                    if (d > 2000)
                        s = $"เขียนตั้นตอนการ เพิ่ม ที่ละ {b} จาก 0 จนถึง {a * b}";
                    else if (d < 2000)
                        s = $"เขียนตั้นตอนการ ลดลง ที่ละ {b} จาก {a * b} จนถึง {0}";
                    else
                        s = $"เขียนตั้นตอนการ คูณ ที่ละ {b} จาก {0} จนถึง {a}";
                }
                e.Graphics.DrawString(s, new Font("Arial", 14), new SolidBrush(Color.Black), xC, yC);
                e.Graphics.DrawString($"โฟลว์ชาร์ต#", new Font("Arial", 14), new SolidBrush(Color.Black), xC + 50, yC + 50);
                if (ShowFlow)
                {
                    e.Graphics.DrawImage(Image.FromFile(Application.StartupPath + @"\File\PIC\Coding\FlwLoop.png"), xC + 150, yC + 100);
                }
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
