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
using KidsLearning.Classed;

namespace KidsLearning.Print.ptnMth.m05GaugeUnit
{
  public partial  class prnMath_002DateTime004AD_BE_Age : prnControl
    {
        public prnMath_002DateTime004AD_BE_Age()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
        
        }

        #region Variables

        int minValue = 1, maxValue = 15;

        #endregion
        private RadioButton rd_3;
        private RadioButton rd_2;
        private RadioButton rd_1;

        public int Leval { get; private set; }

        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ วัน เวลา ";
            ReportToppic = "การนับปีเกิด และ อายุ ";
            iPage = 1;
            iPageAll = 1;
            
            printPreviewControl1.Document = this.printDocument1;
        }

        private void InitializeComponent()
        {
            this.rd_3 = new System.Windows.Forms.RadioButton();
            this.rd_2 = new System.Windows.Forms.RadioButton();
            this.rd_1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(288, 699);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rd_3);
            this.panel2.Controls.Add(this.rd_2);
            this.panel2.Controls.Add(this.rd_1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            this.panel2.Size = new System.Drawing.Size(282, 418);
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
            this.bntPrint.Location = new System.Drawing.Point(11, 347);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(169, 308);
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(79, 305);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 308);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(288, 0);
            this.groupBox2.Size = new System.Drawing.Size(910, 699);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(904, 677);
            // 
            // rd_3
            // 
            this.rd_3.AutoSize = true;
            this.rd_3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_3.Location = new System.Drawing.Point(12, 99);
            this.rd_3.Name = "rd_3";
            this.rd_3.Size = new System.Drawing.Size(151, 34);
            this.rd_3.TabIndex = 20;
            this.rd_3.Text = "radioButton3";
            this.rd_3.UseVisualStyleBackColor = true;
            this.rd_3.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_2
            // 
            this.rd_2.AutoSize = true;
            this.rd_2.Checked = true;
            this.rd_2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_2.Location = new System.Drawing.Point(12, 59);
            this.rd_2.Name = "rd_2";
            this.rd_2.Size = new System.Drawing.Size(151, 34);
            this.rd_2.TabIndex = 19;
            this.rd_2.TabStop = true;
            this.rd_2.Text = "radioButton2";
            this.rd_2.UseVisualStyleBackColor = true;
            this.rd_2.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_1
            // 
            this.rd_1.AutoSize = true;
            this.rd_1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_1.Location = new System.Drawing.Point(11, 19);
            this.rd_1.Name = "rd_1";
            this.rd_1.Size = new System.Drawing.Size(151, 34);
            this.rd_1.TabIndex = 18;
            this.rd_1.Text = "radioButton1";
            this.rd_1.UseVisualStyleBackColor = true;
            this.rd_1.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // prnMath_010DateTime004AD_BE_Age
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "prnMath_010DateTime004AD_BE_Age";
            this.Size = new System.Drawing.Size(1198, 699);
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

            int yC = 100, xC = 100;
            for (int i = 0; i < 6; i++)
            {
                string str = "";
                string s = (RandomNumber.Randomnumber(0, 1000) < 500) ? "พ.ศ." : "ค.ศ.";
                int c = (s == "พ.ศ.") ? RandomNumber.Randomnumber(2540, 2570) : RandomNumber.Randomnumber(2000, 2030);
                string name = Exts.RandomManName;
                if (Leval == 0)
                {
                    str = $" ในปี {s} {c} {name} อายุ {RandomNumber.Randomnumber(5, 20)} ปี { name } เกิด ปี {((RandomNumber.Randomnumber(0, 1000) < 500) ? "พ.ศ." : "ค.ศ.")}  ใด ";
                }
                else if (Leval == 1)
                {
                    str = $"{ name } เกิด ปี {s} {c}  ในปี {s} {RandomNumber.Randomnumber(c + 2, c + 30)} {name} จะอายุเท่าใด ";
                }
                else if (Leval == 2)
                {
                    int ccc = RandomNumber.Randomnumber(0, 1000);
                    if (ccc > 500)
                    {
                        str = $" ในปี {s} {c} {name} อายุ {RandomNumber.Randomnumber(5, 20)} ปี { name } เกิด ปี {((RandomNumber.Randomnumber(0, 1000) < 500) ? "พ.ศ." : "ค.ศ.")}  ใด ";
                    }
                    else
                    {
                        str = $"{ name } เกิด ปี {s} {c}  ในปี {s} {RandomNumber.Randomnumber(c + 2, c + 30)} {name} จะอายุเท่าใด ";
                    }

                }


                str += $"\n วิธีทำ ___________________________________________________________________________" +
                 $"\n ________________________________________________________________________________" +
                 $"\n                         ตอบ_______________ #";

                e.Graphics.DrawString(str, fontDetail, new SolidBrush(Color.Black), xC + 50, yC + 50);

                yC += 150;

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
