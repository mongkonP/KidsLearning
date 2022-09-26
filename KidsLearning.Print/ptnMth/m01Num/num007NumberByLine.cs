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
  public partial  class num007NumberByLine:prnControl
    {
        public num007NumberByLine()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
        
        }

        #region Variables

        int minValue = 1, maxValue = 20;

        #endregion
        private RadioButton rd_1;
        private RadioButton rd_2;
        private RadioButton rd_3;

        private void InitializeComponent()
        {
            this.rd_1 = new System.Windows.Forms.RadioButton();
            this.rd_3 = new System.Windows.Forms.RadioButton();
            this.rd_2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(250, 739);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rd_2);
            this.panel2.Controls.Add(this.rd_1);
            this.panel2.Controls.Add(this.rd_3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            this.panel2.Size = new System.Drawing.Size(244, 325);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            this.panel2.Controls.SetChildIndex(this.txtPageCount, 0);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.bntPrint, 0);
            this.panel2.Controls.SetChildIndex(this.rd_3, 0);
            this.panel2.Controls.SetChildIndex(this.rd_1, 0);
            this.panel2.Controls.SetChildIndex(this.rd_2, 0);
            // 
            // bntPrint
            // 
            this.bntPrint.Location = new System.Drawing.Point(13, 249);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(171, 210);
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(81, 207);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 210);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(1221, 739);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1215, 717);
            // 
            // rd_1
            // 
            this.rd_1.AutoSize = true;
            this.rd_1.Checked = true;
            this.rd_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_1.Location = new System.Drawing.Point(22, 23);
            this.rd_1.Name = "rd_1";
            this.rd_1.Size = new System.Drawing.Size(86, 35);
            this.rd_1.TabIndex = 28;
            this.rd_1.TabStop = true;
            this.rd_1.Text = "1-20";
            this.rd_1.UseVisualStyleBackColor = true;
            this.rd_1.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_3
            // 
            this.rd_3.AutoSize = true;
            this.rd_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_3.Location = new System.Drawing.Point(22, 106);
            this.rd_3.Name = "rd_3";
            this.rd_3.Size = new System.Drawing.Size(110, 35);
            this.rd_3.TabIndex = 29;
            this.rd_3.Text = "-10-10";
            this.rd_3.UseVisualStyleBackColor = true;
            this.rd_3.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_2
            // 
            this.rd_2.AutoSize = true;
            this.rd_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_2.Location = new System.Drawing.Point(22, 65);
            this.rd_2.Name = "rd_2";
            this.rd_2.Size = new System.Drawing.Size(95, 35);
            this.rd_2.TabIndex = 30;
            this.rd_2.Text = "-20-4";
            this.rd_2.UseVisualStyleBackColor = true;
            this.rd_2.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // prnMath_007NumberByLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "prnMath_007NumberByLine";
            this.Size = new System.Drawing.Size(1471, 739);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
             ReportToppic = "แสดงเส้นจำนวน ดังต่อไปนี้";
            iPage = 1;
            iPageAll = 1;

            printPreviewControl1.Document = this.printDocument1;
        }
        private void rd_1_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_3.Checked)
            {
                minValue = -10;
                maxValue = 10;
            }
            else if (rd_2.Checked)
            {
                minValue = -20;
                maxValue = 4;
            }
            else
            {
                minValue = 1;
                maxValue = 20;
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

            int b = RandomNumberGenerator.GetInt32(0, 3000);
            string file;
            switch (b)
            {
                case <1000:
                    file = Application.StartupPath + @"\File\PicSam\ExNumLine.png";
                    break;
                case >1000 and <=2000:
                    file = Application.StartupPath + @"\File\PicSam\ExNumLine_01.png";
                    break;
                case >2000:
                    file = Application.StartupPath + @"\File\PicSam\ExNumLine_03.png";
                    break;
                default:
                    file = Application.StartupPath + @"\File\PicSam\ExNumLine.png";
                    break;
            }


            xC = 100;
            yC = yC + 50;
            for (int i = 1; i <= 5; i++)
            {

                int a = RandomNumberGenerator.GetInt32(minValue, maxValue);
                e.Graphics.DrawImage(TORServices.Drawings.exImage.ResizeImage(Image.FromFile(file), 700, 180), xC, yC);
                e.Graphics.DrawString(a.ToString(), new Font("Arial", 26, FontStyle.Bold), new SolidBrush(Color.Black), xC+240,yC+10);

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
