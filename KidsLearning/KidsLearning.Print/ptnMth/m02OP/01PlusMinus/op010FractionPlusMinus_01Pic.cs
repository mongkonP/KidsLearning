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
  public partial  class op010FractionPlusMinus_01Pic:prnControl
    {
        public op010FractionPlusMinus_01Pic()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
        
        }

        #region Variables

        int minValue = 1, maxValue = 15;

        #endregion
        private RadioButton rd_2;
        private RadioButton rd_1;

        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "การ บวก ลบ เศษส่วน\nให้วาดรูปตามที่กำหนด";
            iPage = 1;
            iPageAll = 1;
            
            printPreviewControl1.Document = this.printDocument1;
        }

        private void InitializeComponent()
        {
            this.rd_2 = new System.Windows.Forms.RadioButton();
            this.rd_1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(250, 602);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rd_2);
            this.panel2.Controls.Add(this.rd_1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            this.panel2.Size = new System.Drawing.Size(244, 356);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            this.panel2.Controls.SetChildIndex(this.txtPageCount, 0);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.bntPrint, 0);
            this.panel2.Controls.SetChildIndex(this.rd_1, 0);
            this.panel2.Controls.SetChildIndex(this.rd_2, 0);
            // 
            // bntPrint
            // 
            this.bntPrint.Location = new System.Drawing.Point(14, 266);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(172, 227);
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(82, 224);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 227);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(1089, 602);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1083, 580);
            // 
            // rd_2
            // 
            this.rd_2.AutoSize = true;
            this.rd_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_2.Location = new System.Drawing.Point(14, 71);
            this.rd_2.Name = "rd_2";
            this.rd_2.Size = new System.Drawing.Size(191, 35);
            this.rd_2.TabIndex = 32;
            this.rd_2.Text = "การลบ เศษส่วน";
            this.rd_2.UseVisualStyleBackColor = true;
            this.rd_2.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_1
            // 
            this.rd_1.AutoSize = true;
            this.rd_1.Checked = true;
            this.rd_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_1.Location = new System.Drawing.Point(14, 29);
            this.rd_1.Name = "rd_1";
            this.rd_1.Size = new System.Drawing.Size(206, 35);
            this.rd_1.TabIndex = 31;
            this.rd_1.TabStop = true;
            this.rd_1.Text = "การบวก เศษส่วน";
            this.rd_1.UseVisualStyleBackColor = true;
            this.rd_1.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // op010FractionPlusMinus_01Pic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "op010FractionPlusMinus_01Pic";
            this.Size = new System.Drawing.Size(1339, 602);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

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

            List<int> Nums = new List<int>();
            int yC = 100;
            int xC = 100;
            int w = 30, h = 30;
            Pen pen = new Pen(Color.Black, 2);
            SolidBrush solidBrush = new SolidBrush(Color.White);

            xC = 150;
            yC = 170;
            int a , b, d, c ;
            for (int i = 1; i <= 4; i ++)
            {

                if (rd_1.Checked)
                {
                    a = RandomNumber.Randomnumber(3, 6);
                    b = RandomNumber.Randomnumber(3, 6);
                  
                   // d =int.Parse( (0.25 *  Convert.ToDouble( a )*Convert.ToDouble( b)).ToString());
                   // MessageBox.Show(d.ToString());
                    c = RandomNumber.Randomnumber(1,  5);
                    e.Graphics.DrawTable(pen, xC, yC, w, h, a, b, c);

                    e.Graphics.DrawString("จำนวนช่องทั้งหมด _____________\n"+
                                          "ช่องที่ระบายสี _________ช่อง เศษส่วนคือ________\n"+
                                          "เขียน X ในช่องที่ว่าง "+ RandomNumber.Randomnumber(1, a*b-c) + " ช่อง เศษส่วนคือ________\n" + 
                                          "ดังนั้น ____ + ____ = ______", fontDetail, new SolidBrush(Color.Black), xC + 200, yC+10);
                }
                else
                {
                    a = RandomNumber.Randomnumber(3, 6);
                    b = RandomNumber.Randomnumber(3, 6);
                    d = Convert.ToInt32(50 / 100 * a * b);
                    c = RandomNumber.Randomnumber(d,  a * b);

                    e.Graphics.DrawTable(pen, xC, yC, w, h, a, b, c);

                    e.Graphics.DrawString("จำนวนช่องทั้งหมด _____________\n" +
                                          "ช่องที่ระบายสี _________ช่อง เศษส่วนคือ________\n" +
                                          "เขียน X ในช่องที่ระบายสี " + RandomNumber.Randomnumber(1, c) + " ช่อง เศษส่วนคือ________\n" +
                                          "ดังนั้น ____ - ____ = ______", fontDetail, new SolidBrush(Color.Black), xC + 200, yC + 10);
                }

               


                yC = yC + b * h + 100;

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
