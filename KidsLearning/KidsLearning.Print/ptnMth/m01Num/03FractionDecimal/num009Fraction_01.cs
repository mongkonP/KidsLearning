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
  public partial  class num009Fraction_01:prnControl
    {
        public num009Fraction_01()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
        
        }

        #region Variables

        int minValue = 1, maxValue = 15;

        #endregion

        private CheckBox checkBox2;
        private CheckBox checkBox1;

        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "นับจำนวนตามรูปภาพที่ระบายสี แล้วเขียนในรูปเศษส่วน";
            iPage = 1;
            iPageAll = 1;
            
            printPreviewControl1.Document = this.printDocument1;
        }

        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Size = new System.Drawing.Size(250, 602);
            this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel2, 0);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(1114, 602);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1108, 580);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(14, 178);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 36);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "มีตัวส่วน";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox2.Location = new System.Drawing.Point(14, 220);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(236, 36);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "ตารางปล่าว ให้ระบายสี";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // num009Fraction_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "num009Fraction_01";
            this.Size = new System.Drawing.Size(1364, 602);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
 
            if (checkBox2.Checked)
            {
                ReportToppic = "ระบายสีตามจำนวน รูปเศษส่วน";
            }
            else
            {
                ReportToppic = "นับจำนวนตามรูปภาพที่ระบายสี แล้วเขียนในรูปเศษส่วน";
            }

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
            yC = yC + 30;
            Font font = new Font("Arial", 24, FontStyle.Bold);
           
            for (int i = 1; i <= 5; i ++)
            {

                int a = RandomNumber.Randomnumber(3, 6);
                int b = RandomNumber.Randomnumber(3, 6);
                int c = RandomNumber.Randomnumber(1,a*b);

                
                
                int _x = 350;
                int _y = yC + (h * b) / 2;

                e.Graphics.DrawLine(new Pen(Brushes.Black, 3), _x, _y, _x +50, _y);
                if (!checkBox2.Checked)
                {
                    e.Graphics.DrawTable(pen, xC, yC, w, h, a, b, c);
                    if (checkBox1.Checked)
                    {
                        e.Graphics.DrawString((a*b).ToString(), font, new SolidBrush(Color.Black), _x , _y + 5);
                    }
                }
                else
                {
                    e.Graphics.DrawTable(pen, xC, yC, w, h, a, b, 0);
                    SizeF stringSize =  e.Graphics.MeasureString(a.ToString(), font);
                    e.Graphics.DrawString(a.ToString(), font, new SolidBrush(Color.Black), _x, _y -stringSize.Height);
                    if(checkBox1.Checked)
                    {
                        e.Graphics.DrawString((a * b).ToString(), font, new SolidBrush(Color.Black), _x, _y + 5);
                    }

                }
                e.Graphics.DrawString("คำอ่าน........................................................", fontDetail, new SolidBrush(Color.Black), _x + 100, _y + 5);
                yC = yC + b*h+50;

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
