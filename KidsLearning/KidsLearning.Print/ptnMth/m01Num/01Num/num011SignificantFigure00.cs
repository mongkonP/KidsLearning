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
   public partial class num011SignificantFigure00 : prnControl
    {

        public num011SignificantFigure00()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.rd_1 = new System.Windows.Forms.RadioButton();
            this.rd_2 = new System.Windows.Forms.RadioButton();
            this.rd_3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(370, 683);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rd_3);
            this.panel2.Controls.Add(this.rd_2);
            this.panel2.Controls.Add(this.rd_1);
            this.panel2.Size = new System.Drawing.Size(364, 315);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            this.panel2.Controls.SetChildIndex(this.txtPageCount, 0);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.bntPrint, 0);
            this.panel2.Controls.SetChildIndex(this.rd_1, 0);
            this.panel2.Controls.SetChildIndex(this.rd_2, 0);
            this.panel2.Controls.SetChildIndex(this.rd_3, 0);
            // 
            // bntPrint
            // 
            this.bntPrint.Location = new System.Drawing.Point(14, 247);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(172, 208);
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(82, 205);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 208);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(370, 0);
            this.groupBox2.Size = new System.Drawing.Size(779, 683);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(773, 661);
            // 
            // rd_1
            // 
            this.rd_1.AutoSize = true;
            this.rd_1.Checked = true;
            this.rd_1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_1.Location = new System.Drawing.Point(14, 23);
            this.rd_1.Name = "rd_1";
            this.rd_1.Size = new System.Drawing.Size(296, 36);
            this.rd_1.TabIndex = 14;
            this.rd_1.TabStop = true;
            this.rd_1.Text = "ค่าประมาณเป็นจำนวนเต็ม 10";
            this.rd_1.UseVisualStyleBackColor = true;
            this.rd_1.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_2
            // 
            this.rd_2.AutoSize = true;
            this.rd_2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_2.Location = new System.Drawing.Point(14, 65);
            this.rd_2.Name = "rd_2";
            this.rd_2.Size = new System.Drawing.Size(309, 36);
            this.rd_2.TabIndex = 15;
            this.rd_2.Text = "ค่าประมาณเป็นจำนวนเต็ม 100";
            this.rd_2.UseVisualStyleBackColor = true;
            this.rd_2.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_3
            // 
            this.rd_3.AutoSize = true;
            this.rd_3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_3.Location = new System.Drawing.Point(14, 107);
            this.rd_3.Name = "rd_3";
            this.rd_3.Size = new System.Drawing.Size(140, 36);
            this.rd_3.TabIndex = 16;
            this.rd_3.Text = "สุ่ม 10-100";
            this.rd_3.UseVisualStyleBackColor = true;
            this.rd_3.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // num011SignificantFigure00
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "num011SignificantFigure00";
            this.Size = new System.Drawing.Size(1149, 683);
            this.Load += new System.EventHandler(this.prn_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #region Variables

        int minValue = 10, maxValue = 200;
        private RadioButton rd_3;
        private RadioButton rd_2;
        private RadioButton rd_1;
        Random random = new Random();
        #endregion



   
        private void prn_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "การหาค่าประมาณ";
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
            int aa;
            string numStr = "";
            for (int i = 0; i < 8; i++)
            {

                if (rd_1.Checked)
                {
                    aa = RandomNumber.Randomnumber(1, 999);
                    numStr = " 10 ";
                }
                else if (rd_2.Checked)
                {
                    aa = RandomNumber.Randomnumber(200, 9999);
                    numStr = " 100 ";
                }
                else
                {
                    if (RandomNumber.Randomnumber(1, 999) > 500)
                    {
                        aa = RandomNumber.Randomnumber(1, 999);
                        numStr = " 10 ";
                    }
                    else
                    {
                        aa = RandomNumber.Randomnumber(200, 9999);
                        numStr = " 100 ";
                    }
                }
                
                e.Graphics.DrawString($"{aa} เป็นจำนวนนับที่อยู่ระหว่าง _______และ _________" +
                    $"\n ค่าประมาณเต็ม {numStr} คือ _____________________  ",
                    new Font("Angsana New", 18), new SolidBrush(Color.Black), xC, yC);
                
                yC += 110 ;

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
