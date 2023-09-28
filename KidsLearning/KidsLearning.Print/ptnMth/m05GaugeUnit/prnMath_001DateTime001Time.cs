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
  public partial  class prnMath_001DateTime001Time : prnControl
    {
        public prnMath_001DateTime001Time()
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

        public int Leval { get; private set; }

        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ วัน เวลา ";
            ReportToppic = "ให้บอกเวลา ต่อไปนี้";
            iPage = 1;
            iPageAll = 1;
            
            printPreviewControl1.Document = this.printDocument1;
        }

        private void InitializeComponent()
        {
            this.rd_2 = new System.Windows.Forms.RadioButton();
            this.rd_1 = new System.Windows.Forms.RadioButton();
            this.rd_3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(436, 699);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rd_3);
            this.panel2.Controls.Add(this.rd_2);
            this.panel2.Controls.Add(this.rd_1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            this.panel2.Size = new System.Drawing.Size(430, 348);
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
            this.bntPrint.Location = new System.Drawing.Point(12, 271);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(170, 232);
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(80, 229);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 232);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(436, 0);
            this.groupBox2.Size = new System.Drawing.Size(1101, 699);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1095, 677);
            // 
            // rd_2
            // 
            this.rd_2.AutoSize = true;
            this.rd_2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_2.Location = new System.Drawing.Point(16, 73);
            this.rd_2.Name = "rd_2";
            this.rd_2.Size = new System.Drawing.Size(301, 34);
            this.rd_2.TabIndex = 17;
            this.rd_2.Text = "ลากเข็มนาฬิกา ตามเวลา hh:mm";
            this.rd_2.UseVisualStyleBackColor = true;
            this.rd_2.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_1
            // 
            this.rd_1.AutoSize = true;
            this.rd_1.Checked = true;
            this.rd_1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_1.Location = new System.Drawing.Point(15, 33);
            this.rd_1.Name = "rd_1";
            this.rd_1.Size = new System.Drawing.Size(225, 34);
            this.rd_1.TabIndex = 16;
            this.rd_1.TabStop = true;
            this.rd_1.Text = "บอกเวลาจากเข็มนาฬิกา";
            this.rd_1.UseVisualStyleBackColor = true;
            this.rd_1.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_3
            // 
            this.rd_3.AutoSize = true;
            this.rd_3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_3.Location = new System.Drawing.Point(16, 113);
            this.rd_3.Name = "rd_3";
            this.rd_3.Size = new System.Drawing.Size(324, 34);
            this.rd_3.TabIndex = 18;
            this.rd_3.Text = "ลากเข็มนาฬิกา ตามเวลา hh:mm:ss";
            this.rd_3.UseVisualStyleBackColor = true;
            this.rd_3.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // prnMath_010DateTime001Time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "prnMath_010DateTime001Time";
            this.Size = new System.Drawing.Size(1537, 699);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
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

                if (Leval == 0)
                {
                    e.Graphics.DrawClock(RandomNumber.Randomnumber(0, 12), RandomNumber.Randomnumber(0, 60), RandomNumber.Randomnumber(0, 60), xC, yC);
                    e.Graphics.DrawString("นาฬิกาบอกเวลา ____:____:____", fontDetail, new SolidBrush(Color.Black), xC + 200, yC + 50);
                }
                else if(Leval == 1)
                {
                    e.Graphics.DrawClock( xC, yC);

                    e.Graphics.DrawString($"นาฬิกาบอกเวลา {RandomNumber.Randomnumber(0, 12)}:{RandomNumber.Randomnumber(0, 60)}", fontDetail, new SolidBrush(Color.Black), xC + 200, yC + 50);
                }
                else if(Leval == 2)
                {
                    e.Graphics.DrawClock(xC, yC);

                    e.Graphics.DrawString($"นาฬิกาบอกเวลา {RandomNumber.Randomnumber(0, 12)}:{RandomNumber.Randomnumber(0, 60)}:{RandomNumber.Randomnumber(0, 60)}", fontDetail, new SolidBrush(Color.Black), xC + 200, yC + 50);
                }


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
