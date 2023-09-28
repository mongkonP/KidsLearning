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
  public partial  class op007MultipliedDivide_02Num:prnControl
    {
        public op007MultipliedDivide_02Num()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
        
        }

        #region Variables

        int minValue = 1, maxValue = 15;

        #endregion
        private RadioButton rd_2;
        private RadioButton rd_3;
        private RadioButton rd_1;

        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "การหาผลคูณ หาร ต่อไปนี้";
            iPage = 1;
            iPageAll = 1;
            
            printPreviewControl1.Document = this.printDocument1;
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
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(368, 676);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rd_3);
            this.panel2.Controls.Add(this.rd_2);
            this.panel2.Controls.Add(this.rd_1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            this.panel2.Size = new System.Drawing.Size(362, 318);
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
            this.bntPrint.Location = new System.Drawing.Point(16, 249);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(174, 210);
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(84, 207);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 210);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(368, 0);
            this.groupBox2.Size = new System.Drawing.Size(958, 676);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(952, 654);
            // 
            // rd_1
            // 
            this.rd_1.AutoSize = true;
            this.rd_1.Checked = true;
            this.rd_1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_1.Location = new System.Drawing.Point(16, 34);
            this.rd_1.Name = "rd_1";
            this.rd_1.Size = new System.Drawing.Size(154, 36);
            this.rd_1.TabIndex = 14;
            this.rd_1.TabStop = true;
            this.rd_1.Text = "หาผลการคูณ";
            this.rd_1.UseVisualStyleBackColor = true;
            this.rd_1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rd_2
            // 
            this.rd_2.AutoSize = true;
            this.rd_2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_2.Location = new System.Drawing.Point(16, 78);
            this.rd_2.Name = "rd_2";
            this.rd_2.Size = new System.Drawing.Size(154, 36);
            this.rd_2.TabIndex = 15;
            this.rd_2.Text = "หาผลการหาร";
            this.rd_2.UseVisualStyleBackColor = true;
            this.rd_2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rd_3
            // 
            this.rd_3.AutoSize = true;
            this.rd_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_3.Location = new System.Drawing.Point(16, 131);
            this.rd_3.Name = "rd_3";
            this.rd_3.Size = new System.Drawing.Size(120, 35);
            this.rd_3.TabIndex = 36;
            this.rd_3.Text = "สุ่ม (+/-)";
            this.rd_3.UseVisualStyleBackColor = true;
            this.rd_3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // op007MultipliedDivide_02Num
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "op007MultipliedDivide_02Num";
            this.Size = new System.Drawing.Size(1326, 676);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        string Sop = "x";
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            

            printPreviewControl1.Document = this.printDocument1;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail


            int yC = 150;
            int xC = 150;

            Pen pen = new Pen(Color.Black, 2);
            SolidBrush solidBrush = new SolidBrush(Color.White);

            xC = 150;


            for (int i = 1; i <= 7; i ++)
            {
                if (rd_1.Checked)
                {
                    Sop = "x"; 
                }
                else if (rd_2.Checked)
                {
                    Sop = "/"; 
                }
                else if (rd_3.Checked)
                {
                    if (RandomNumber.Randomnumber(1, 1000) > 500)
                    {
                        Sop = "x"; 
                    }
                    else
                    {
                        Sop = "/"; 
                    }
                }
                int a = RandomNumber.Randomnumber(1, 10);
                int b = RandomNumber.Randomnumber(1, 10);
                if (Sop == "x")
                {
                    e.Graphics.DrawString($"{a} x { b } = ................", fontDetail, new SolidBrush(Color.Black), xC, yC);
                    a = RandomNumber.Randomnumber(1, 10);
                    b = RandomNumber.Randomnumber(1, 10);

                    e.Graphics.DrawString($"{a} x { b } = ................", fontDetail, new SolidBrush(Color.Black), xC + 200, yC);
                }
                else
                {
                    e.Graphics.DrawString($"{a*b} ÷ { b } = ................", fontDetail, new SolidBrush(Color.Black), xC, yC);
                    a = RandomNumber.Randomnumber(1, 10);
                    b = RandomNumber.Randomnumber(1, 10);

                    e.Graphics.DrawString($"{a*b} ÷ { b } = ................", fontDetail, new SolidBrush(Color.Black), xC + 200, yC);
                }

                yC = yC + 80;

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
