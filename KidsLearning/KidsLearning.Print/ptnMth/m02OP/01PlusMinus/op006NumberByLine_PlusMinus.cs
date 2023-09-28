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
  public partial  class op006NumberByLine_PlusMinus:prnControl
    {
        public op006NumberByLine_PlusMinus()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
        
        }

        #region Variables

        int minValue = 1, maxValue = 10;
        string Opr = "+";
        string file = Application.StartupPath + @"\File\PicSam\ExNumLine.png";
        #endregion

        private GroupBox groupBox4;
        private RadioButton rd_5;
        private RadioButton rd_4;
        private RadioButton rd_6;
        private GroupBox groupBox3;
        private RadioButton rd_2;
        private RadioButton rd_1;
        private RadioButton rd_3;

        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rd_2 = new System.Windows.Forms.RadioButton();
            this.rd_1 = new System.Windows.Forms.RadioButton();
            this.rd_3 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rd_5 = new System.Windows.Forms.RadioButton();
            this.rd_4 = new System.Windows.Forms.RadioButton();
            this.rd_6 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(250, 676);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            this.panel2.Size = new System.Drawing.Size(244, 647);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            this.panel2.Controls.SetChildIndex(this.txtPageCount, 0);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.bntPrint, 0);
            this.panel2.Controls.SetChildIndex(this.groupBox3, 0);
            this.panel2.Controls.SetChildIndex(this.groupBox4, 0);
            // 
            // bntPrint
            // 
            this.bntPrint.Location = new System.Drawing.Point(5, 581);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(163, 542);
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(73, 539);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 542);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(1076, 676);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1070, 654);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rd_2);
            this.groupBox3.Controls.Add(this.rd_1);
            this.groupBox3.Controls.Add(this.rd_3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 208);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ช่วงตัวเลข";
            // 
            // rd_2
            // 
            this.rd_2.AutoSize = true;
            this.rd_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_2.Location = new System.Drawing.Point(15, 80);
            this.rd_2.Name = "rd_2";
            this.rd_2.Size = new System.Drawing.Size(95, 35);
            this.rd_2.TabIndex = 33;
            this.rd_2.Text = "-20-4";
            this.rd_2.UseVisualStyleBackColor = true;
            this.rd_2.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_1
            // 
            this.rd_1.AutoSize = true;
            this.rd_1.Checked = true;
            this.rd_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_1.Location = new System.Drawing.Point(15, 38);
            this.rd_1.Name = "rd_1";
            this.rd_1.Size = new System.Drawing.Size(86, 35);
            this.rd_1.TabIndex = 31;
            this.rd_1.TabStop = true;
            this.rd_1.Text = "1-20";
            this.rd_1.UseVisualStyleBackColor = true;
            this.rd_1.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_3
            // 
            this.rd_3.AutoSize = true;
            this.rd_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_3.Location = new System.Drawing.Point(15, 121);
            this.rd_3.Name = "rd_3";
            this.rd_3.Size = new System.Drawing.Size(110, 35);
            this.rd_3.TabIndex = 32;
            this.rd_3.Text = "-10-10";
            this.rd_3.UseVisualStyleBackColor = true;
            this.rd_3.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rd_5);
            this.groupBox4.Controls.Add(this.rd_4);
            this.groupBox4.Controls.Add(this.rd_6);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(0, 208);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(244, 245);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ดำเนินการ";
            // 
            // rd_5
            // 
            this.rd_5.AutoSize = true;
            this.rd_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_5.Location = new System.Drawing.Point(15, 90);
            this.rd_5.Name = "rd_5";
            this.rd_5.Size = new System.Drawing.Size(134, 35);
            this.rd_5.TabIndex = 36;
            this.rd_5.Text = "การลบ (-)";
            this.rd_5.UseVisualStyleBackColor = true;
            this.rd_5.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_4
            // 
            this.rd_4.AutoSize = true;
            this.rd_4.Checked = true;
            this.rd_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_4.Location = new System.Drawing.Point(15, 48);
            this.rd_4.Name = "rd_4";
            this.rd_4.Size = new System.Drawing.Size(156, 35);
            this.rd_4.TabIndex = 34;
            this.rd_4.TabStop = true;
            this.rd_4.Text = "การบวก (+)";
            this.rd_4.UseVisualStyleBackColor = true;
            this.rd_4.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_6
            // 
            this.rd_6.AutoSize = true;
            this.rd_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_6.Location = new System.Drawing.Point(15, 131);
            this.rd_6.Name = "rd_6";
            this.rd_6.Size = new System.Drawing.Size(120, 35);
            this.rd_6.TabIndex = 35;
            this.rd_6.Text = "สุ่ม (+/-)";
            this.rd_6.UseVisualStyleBackColor = true;
            this.rd_6.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // op006NumberByLine_PlusMinus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "op006NumberByLine_PlusMinus";
            this.Size = new System.Drawing.Size(1326, 676);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }
        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
             ReportToppic = "แสดงเส้นจำนวน ดังต่อไปนี้";
            iPage = 1;
            iPageAll = 1;
            this.rd_1_CheckedChanged(null,null);
            printPreviewControl1.Document = this.printDocument1;
        }
        private void rd_1_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_3.Checked)
            {
                minValue = -10;
                maxValue = 10;
                file = Application.StartupPath + @"\File\PicSam\ExNumLine_01.png";
                // file = Application.StartupPath + @"\File\PicSam\ExNumLine_03.png";
            }
            else if (rd_2.Checked)
            {
                minValue = -10;
                maxValue = 4;
                file = Application.StartupPath + @"\File\PicSam\ExNumLine_01.png";
            }
            else if (rd_1.Checked)
            {
                minValue = 1;
                maxValue = 10;
                file = Application.StartupPath + @"\File\PicSam\ExNumLine.png";
            }

           

            if (rd_4.Checked)
            {
                Opr = "+";
            }
            else if (rd_5.Checked)
            {
                Opr = "-";
            }
            else if (rd_6.Checked)
            {

                Opr = "+/-" ;
            }
            printPreviewControl1.Document = this.printDocument1;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail


            int yC = 100;
            int xC = 100;
            int w = 80, h = 50;

          //  e.Graphics.DrawImage(TORServices.Drawings.exImage.ResizeImage(Image.FromFile(Application.StartupPath+ ((minValue==1)? @"\File\PicSam\Sam_NumbyLine.png": @"\File\PicSam\Sam_NumbyLine_01.png")), 700, 180), 50, 100);

           // 
           
           


            xC = 100;
            yC = yC + 50;
            for (int i = 1; i <= 5; i++)
            {

                int a = RandomNumber.Randomnumber(minValue, maxValue);
                int _b= RandomNumber.Randomnumber(minValue, maxValue);
                string sOP;
                if (Opr == "+")
                {
                    sOP = a + " + " + _b + "  = ";
                }
                else if (Opr == "-")
                {
                    sOP = Math.Max(a, _b) + " - " + Math.Min(a, _b) + "  = ";
                }
                else
                {

                    /* int b = RandomNumber.Randomnumber(0, 3000);
                     if (b<=1500)
                     {
                         sOP = a + " + " + _b + "  = ";
                     }
                     else
                     {
                         sOP = Math.Max(a, _b) + " - " + Math.Min(a, _b) + "  = ";
                     }*/
                    sOP = KidsLearning.Classed.Exten.Ext_Maths.RandomOP_Add_Subt(a, _b);

                }

                e.Graphics.DrawImage(TORServices.Drawings.exImage.ResizeImage(Image.FromFile(file), 700, 180), xC, yC);
                e.Graphics.DrawString(sOP, new Font("Arial", 26, FontStyle.Bold), new SolidBrush(Color.Black), xC+240,yC+10);

                yC = yC + 180;


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
