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
   public partial class num011Decimal_01 : prnControl
    {

        public num011Decimal_01()
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
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Size = new System.Drawing.Size(435, 667);
            this.groupBox1.Controls.SetChildIndex(this.panel1, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel3, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel2, 0);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 315);
            this.panel2.Size = new System.Drawing.Size(429, 127);
            // 
            // bntPrint
            // 
            this.bntPrint.Location = new System.Drawing.Point(17, 60);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(175, 21);
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(85, 18);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 21);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(435, 0);
            this.groupBox2.Size = new System.Drawing.Size(847, 667);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(841, 645);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rd_3);
            this.panel1.Controls.Add(this.rd_2);
            this.panel1.Controls.Add(this.rd_1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 148);
            this.panel1.TabIndex = 16;
            // 
            // rd_3
            // 
            this.rd_3.AutoSize = true;
            this.rd_3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_3.Location = new System.Drawing.Point(21, 92);
            this.rd_3.Name = "rd_3";
            this.rd_3.Size = new System.Drawing.Size(98, 36);
            this.rd_3.TabIndex = 2;
            this.rd_3.Text = "แบบสุ่ม";
            this.rd_3.UseVisualStyleBackColor = true;
            this.rd_3.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_2
            // 
            this.rd_2.AutoSize = true;
            this.rd_2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_2.Location = new System.Drawing.Point(21, 52);
            this.rd_2.Name = "rd_2";
            this.rd_2.Size = new System.Drawing.Size(371, 36);
            this.rd_2.TabIndex = 1;
            this.rd_2.Text = "หารด้วย 10 10^2  10^3 และ 10^4";
            this.rd_2.UseVisualStyleBackColor = true;
            // 
            // rd_1
            // 
            this.rd_1.AutoSize = true;
            this.rd_1.Checked = true;
            this.rd_1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_1.Location = new System.Drawing.Point(21, 14);
            this.rd_1.Name = "rd_1";
            this.rd_1.Size = new System.Drawing.Size(371, 36);
            this.rd_1.TabIndex = 0;
            this.rd_1.TabStop = true;
            this.rd_1.Text = "คูณด้วย 10 10^2  10^3 และ 10^4";
            this.rd_1.UseVisualStyleBackColor = true;
            this.rd_1.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rd_6);
            this.panel3.Controls.Add(this.rd_5);
            this.panel3.Controls.Add(this.rd_4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 167);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(429, 148);
            this.panel3.TabIndex = 17;
            // 
            // rd_6
            // 
            this.rd_6.AutoSize = true;
            this.rd_6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_6.Location = new System.Drawing.Point(21, 92);
            this.rd_6.Name = "rd_6";
            this.rd_6.Size = new System.Drawing.Size(98, 36);
            this.rd_6.TabIndex = 2;
            this.rd_6.Text = "แบบสุ่ม";
            this.rd_6.UseVisualStyleBackColor = true;
            this.rd_6.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_5
            // 
            this.rd_5.AutoSize = true;
            this.rd_5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_5.Location = new System.Drawing.Point(21, 52);
            this.rd_5.Name = "rd_5";
            this.rd_5.Size = new System.Drawing.Size(173, 36);
            this.rd_5.TabIndex = 1;
            this.rd_5.Text = "หารด้วยทศนิยม";
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
            this.rd_4.Size = new System.Drawing.Size(200, 36);
            this.rd_4.TabIndex = 0;
            this.rd_4.TabStop = true;
            this.rd_4.Text = "คูณด้วยจำนวนเต็ม";
            this.rd_4.UseVisualStyleBackColor = true;
            this.rd_4.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // num011Decimal_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "num011Decimal_01";
            this.Size = new System.Drawing.Size(1282, 667);
            this.Load += new System.EventHandler(this.prn_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        Random random = new Random();
        #endregion



   
        private void prn_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "การคูณ/หาร ทศนิยมด้วย 10 100 และ 1,000";
            printPreviewControl1.Document = this.printDocument1;
        }
        string OP = "x";
        bool numInt = true;
        private void rd_1_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_1.Checked)
            {
                OP = "x";
            }
            else if (rd_2.Checked)
            {
                OP = "÷";
            }
            else if (rd_3.Checked)
            {
                OP = (RandomNumber.Randomnumber(1, 1000) > 500) ? "x" : "÷";
            }

            if (rd_3.Checked)
            {
                numInt = true;
            }
            else if (rd_4.Checked)
            {
                numInt = false;
            }
            else if (rd_5.Checked)
            {
                numInt = (RandomNumber.Randomnumber(1, 1000) > 500) ? true : false;
            }

            printPreviewControl1.Document = this.printDocument1;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail

            int yC = 150, xC = 100;
            int w = 50, h = 35,wr = 25;
            double aa;
            for (int i = 0; i < 5; i++)
            {
              
                aa = random.NextDouble()* RandomNumber.Randomnumber(minValue, maxValue);
            
                int bb = RandomNumber.Randomnumber(2, 5);
                int cc = RandomNumber.Randomnumber(1, 4);
                int dd = Convert.ToInt32( Math.Pow(10,cc));
               /* switch (cc)
                {
                    case < 1000:dd = 10; break;
                    case > 1000 and <= 2000:dd = 100; break;
                    case > 2000 and<=3000:dd = 1000; break;
                    case > 3000:  dd = 10000; break;
                    default:dd = 10; break;
                }*/
                string _aa = (numInt)? int.Parse(aa.ToString()).ToString(): aa.ToString("N" + bb);
                e.Graphics.DrawString($"{_aa} {OP} {dd} = ?"+ 
                     " \n _______________________________________________________"+
                     " \n _______________________________________________________"+ 
                     " \n _______________________________________________________"+
                     " \n _______________________________________________________",
                    new Font("Angsana New", 16), new SolidBrush(Color.Black), xC, yC);
                
                yC += 180 ;

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
