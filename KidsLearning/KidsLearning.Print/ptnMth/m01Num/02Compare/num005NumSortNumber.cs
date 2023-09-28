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
  public partial  class num005NumSortNumber:prnControl
    {
        public num005NumSortNumber()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
        
        }

        #region Variables

        int minValue = 1, maxValue = 15;

        #endregion
        private RadioButton rdSort_3;
        private RadioButton rdSort_2;
        private RadioButton rdSort_1;
        private Classed.Controls.NumberSelect numberSelect1;

        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            
            iPage = 1;
            iPageAll = 1;

            minValue = Convert.ToInt32(numberSelect1.Minimum);
            maxValue = Convert.ToInt32(numberSelect1.Maximum);
            printPreviewControl1.Document = this.printDocument1;
        }

        private void InitializeComponent()
        {
            this.numberSelect1 = new KidsLearning.Classed.Controls.NumberSelect();
            this.rdSort_1 = new System.Windows.Forms.RadioButton();
            this.rdSort_2 = new System.Windows.Forms.RadioButton();
            this.rdSort_3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numberSelect1);
            this.groupBox1.Size = new System.Drawing.Size(492, 602);
            this.groupBox1.Controls.SetChildIndex(this.numberSelect1, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel2, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdSort_3);
            this.panel2.Controls.Add(this.rdSort_2);
            this.panel2.Controls.Add(this.rdSort_1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 447);
            this.panel2.Size = new System.Drawing.Size(486, 246);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            this.panel2.Controls.SetChildIndex(this.txtPageCount, 0);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.bntPrint, 0);
            this.panel2.Controls.SetChildIndex(this.rdSort_1, 0);
            this.panel2.Controls.SetChildIndex(this.rdSort_2, 0);
            this.panel2.Controls.SetChildIndex(this.rdSort_3, 0);
            // 
            // bntPrint
            // 
            this.bntPrint.Location = new System.Drawing.Point(10, 182);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(168, 143);
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(78, 140);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 143);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(492, 0);
            this.groupBox2.Size = new System.Drawing.Size(872, 602);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(866, 580);
            // 
            // numberSelect1
            // 
            this.numberSelect1.Dock = System.Windows.Forms.DockStyle.Top;
            this.numberSelect1.Location = new System.Drawing.Point(3, 19);
            this.numberSelect1.Name = "numberSelect1";
            this.numberSelect1.Size = new System.Drawing.Size(486, 428);
            this.numberSelect1.TabIndex = 2;
            this.numberSelect1.NumberSelectChanged += new System.EventHandler(this.numberSelect1_NumberSelectChanged);
            this.numberSelect1.Load += new System.EventHandler(this.numberSelect1_Load);
            // 
            // rdSort_1
            // 
            this.rdSort_1.AutoSize = true;
            this.rdSort_1.Checked = true;
            this.rdSort_1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdSort_1.Location = new System.Drawing.Point(21, 17);
            this.rdSort_1.Name = "rdSort_1";
            this.rdSort_1.Size = new System.Drawing.Size(204, 34);
            this.rdSort_1.TabIndex = 14;
            this.rdSort_1.TabStop = true;
            this.rdSort_1.Text = "เรียงจาก น้อย ไป มาก";
            this.rdSort_1.UseVisualStyleBackColor = true;
            this.rdSort_1.CheckedChanged += new System.EventHandler(this.rdSort_1_CheckedChanged);
            // 
            // rdSort_2
            // 
            this.rdSort_2.AutoSize = true;
            this.rdSort_2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdSort_2.Location = new System.Drawing.Point(21, 57);
            this.rdSort_2.Name = "rdSort_2";
            this.rdSort_2.Size = new System.Drawing.Size(204, 34);
            this.rdSort_2.TabIndex = 15;
            this.rdSort_2.Text = "เรียงจาก มาก ไป น้อย";
            this.rdSort_2.UseVisualStyleBackColor = true;
            this.rdSort_2.CheckedChanged += new System.EventHandler(this.rdSort_1_CheckedChanged);
            // 
            // rdSort_3
            // 
            this.rdSort_3.AutoSize = true;
            this.rdSort_3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdSort_3.Location = new System.Drawing.Point(21, 97);
            this.rdSort_3.Name = "rdSort_3";
            this.rdSort_3.Size = new System.Drawing.Size(54, 34);
            this.rdSort_3.TabIndex = 16;
            this.rdSort_3.Text = "สุ่ม";
            this.rdSort_3.UseVisualStyleBackColor = true;
            this.rdSort_3.CheckedChanged += new System.EventHandler(this.rdSort_1_CheckedChanged);
            // 
            // num005NumSortNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "num005NumSortNumber";
            this.Size = new System.Drawing.Size(1364, 602);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        string sortFormat = "1";
        private void numberSelect1_NumberSelectChanged(object sender, EventArgs e)
        {
            minValue = Convert.ToInt32(numberSelect1.Minimum);
            maxValue = Convert.ToInt32(numberSelect1.Maximum);
            printPreviewControl1.Document = this.printDocument1;
        }

        private void numberSelect1_Load(object sender, EventArgs e)
        {
           
        }

        private void rdSort_1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSort_1.Checked)
            {
                sortFormat = "1";
            }
            else if (rdSort_2.Checked)
            {
                sortFormat = "2";
            }
            else if (rdSort_3.Checked)
            {
                sortFormat = "3";
            }
            printPreviewControl1.Document = this.printDocument1;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail
            int yC = 100, xC = 100;
            int w = 100, h = 40;
            int numCount = 0;
            string numString = "";
            string _str  ="";
            for (int i = 0; i < 7; i++)
            {

                /* int _a = (maxValue<=10)?10:RandomNumber.Randomnumber(minValue, maxValue);
                 int _b = (maxValue <= 10) ? 10 : Convert.ToInt32(_a * 0.5);

                 numCount = RandomNumber.Randomnumber(3, 10);
                 numString = "";
                 int a = Math.Max(_a - _b, _a + _b), b = Math.Min(_a - _b, _a + _b);
                 if (a < minValue) a = minValue;
                 if (b > maxValue) b = maxValue;
                 for (int x = 1; x <= numCount; x++)
                 {
                     numString += "  " + RandomNumber.Randomnumber(b,  a).ToString("N0");
                 }

                 */

                int _a = (maxValue <= 10) ? 10 : RandomNumber.Randomnumber(minValue, maxValue);
                int _b = (maxValue <= 10) ? 1 : Convert.ToInt32(_a * 0.5);
                if (_a < minValue || _a == maxValue) _a = minValue;
                if (_b > maxValue || _b == minValue) _b = maxValue;
                 numCount = RandomNumber.Randomnumber(3, 10);
                 numString = "";
                int a = Math.Max(_a - _b, _a + _b), b = Math.Min(_a - _b, _a + _b);
                if (b < minValue || a == maxValue) b = minValue;
                if (a > maxValue || b == minValue) a = maxValue;
                for (int x = 1; x <= numCount; x++)
                {
                    string r;
                    do { r = RandomNumber.Randomnumber(b, a).ToString("N0"); } while (numString.Contains(r));
                    numString += "  " + r;
                }


                if (sortFormat == "1")
                {
                    _str = "น้อยไปมาก";
                }
                else if (sortFormat == "2")
                {
                    _str = "มากไปน้อย";
                }
                else if (sortFormat == "3")
                {
                    _str = ((RandomNumber.Randomnumber(1, 2000) < 1000) ? "น้อยไปมาก" : "มากไปน้อย");
                }
                e.Graphics.DrawString("เรียงตัวเลขต่อไปนี้จาก " + _str, new Font("Angsana New", 15), new SolidBrush(Color.Black), xC + 5, yC + 5);
                yC += 25;
               
                e.Graphics.DrawString( numString, new Font("Angsana New", 15), new SolidBrush(Color.Black), xC + 50, yC + 5);
                yC += 50;

                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 50, yC + 20, xC + 600, yC + 20);

                yC += 50;

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
