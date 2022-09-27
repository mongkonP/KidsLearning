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
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Size = new System.Drawing.Size(370, 607);
            this.groupBox1.Controls.SetChildIndex(this.panel2, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel1, 0);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            this.panel2.Size = new System.Drawing.Size(364, 127);
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
            this.groupBox2.Location = new System.Drawing.Point(370, 0);
            this.groupBox2.Size = new System.Drawing.Size(1011, 607);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1005, 585);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rd_3);
            this.panel1.Controls.Add(this.rd_2);
            this.panel1.Controls.Add(this.rd_1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 148);
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
            // 
            // rd_2
            // 
            this.rd_2.AutoSize = true;
            this.rd_2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_2.Location = new System.Drawing.Point(21, 52);
            this.rd_2.Name = "rd_2";
            this.rd_2.Size = new System.Drawing.Size(323, 36);
            this.rd_2.TabIndex = 1;
            this.rd_2.Text = "การหารด้วย 10 100 และ 1,000";
            this.rd_2.UseVisualStyleBackColor = true;
            // 
            // rd_1
            // 
            this.rd_1.AutoSize = true;
            this.rd_1.Checked = true;
            this.rd_1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_1.Location = new System.Drawing.Point(21, 14);
            this.rd_1.Name = "rd_1";
            this.rd_1.Size = new System.Drawing.Size(323, 36);
            this.rd_1.TabIndex = 0;
            this.rd_1.TabStop = true;
            this.rd_1.Text = "การคูณด้วย 10 100 และ 1,000";
            this.rd_1.UseVisualStyleBackColor = true;
            this.rd_1.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // num011Decimal_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "num011Decimal_01";
            this.Size = new System.Drawing.Size(1381, 607);
            this.Load += new System.EventHandler(this.prn_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }


        #region Variables

        int minValue = 10, maxValue = 200;
        private Panel panel1;
        private RadioButton rd_3;
        private RadioButton rd_2;
        private RadioButton rd_1;
        Random random = new Random();
        #endregion



   
        private void prn_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "การคูณ/หาร ทศนิยมด้วย 10 100 และ 1,000";
            printPreviewControl1.Document = this.printDocument1;
        }
        string OP = "x";
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
                OP = (RandomNumberGenerator.GetInt32(1, 1000) > 500) ? "x" : "÷";
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
              
                aa = random.NextDouble()* RandomNumberGenerator.GetInt32(minValue, maxValue);
            
                int bb = RandomNumberGenerator.GetInt32(2, 5);
                int cc = RandomNumberGenerator.GetInt32(0, 3000);
                int dd;
                switch (cc)
                {
                    case < 1000:dd = 10; break;
                    case > 1000 and <= 2000:dd = 100; break;
                    case > 2000:dd = 1000; break;
                    default:dd = 10; break;
                }
                string _aa = aa.ToString("N" + bb);
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
