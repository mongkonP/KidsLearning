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
    public partial class num007NumberByLine : prnControl
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
            rd_1 = new RadioButton();
            rd_3 = new RadioButton();
            rd_2 = new RadioButton();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Size = new Size(250, 655);
            // 
            // panel2
            // 
            panel2.Controls.Add(rd_2);
            panel2.Controls.Add(rd_1);
            panel2.Controls.Add(rd_3);
            panel2.Size = new Size(244, 325);
            panel2.Controls.SetChildIndex(label1, 0);
            panel2.Controls.SetChildIndex(txtPageCount, 0);
            panel2.Controls.SetChildIndex(label2, 0);
            panel2.Controls.SetChildIndex(bntPrint, 0);
            panel2.Controls.SetChildIndex(rd_3, 0);
            panel2.Controls.SetChildIndex(rd_1, 0);
            panel2.Controls.SetChildIndex(rd_2, 0);
            // 
            // bntPrint
            // 
            bntPrint.Location = new Point(13, 249);
            // 
            // label2
            // 
            label2.Location = new Point(171, 210);
            // 
            // txtPageCount
            // 
            txtPageCount.Location = new Point(81, 207);
            // 
            // label1
            // 
            label1.Location = new Point(13, 210);
            // 
            // groupBox2
            // 
            groupBox2.Size = new Size(1276, 655);
            // 
            // printPreviewControl1
            // 
            printPreviewControl1.Size = new Size(1270, 633);
            // 
            // rd_1
            // 
            rd_1.AutoSize = true;
            rd_1.Checked = true;
            rd_1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            rd_1.Location = new Point(22, 23);
            rd_1.Name = "rd_1";
            rd_1.Size = new Size(86, 35);
            rd_1.TabIndex = 28;
            rd_1.TabStop = true;
            rd_1.Text = "1-20";
            rd_1.UseVisualStyleBackColor = true;
            rd_1.CheckedChanged += rd_1_CheckedChanged;
            // 
            // rd_3
            // 
            rd_3.AutoSize = true;
            rd_3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            rd_3.Location = new Point(22, 106);
            rd_3.Name = "rd_3";
            rd_3.Size = new Size(110, 35);
            rd_3.TabIndex = 29;
            rd_3.Text = "-10-10";
            rd_3.UseVisualStyleBackColor = true;
            rd_3.CheckedChanged += rd_1_CheckedChanged;
            // 
            // rd_2
            // 
            rd_2.AutoSize = true;
            rd_2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            rd_2.Location = new Point(22, 65);
            rd_2.Name = "rd_2";
            rd_2.Size = new Size(95, 35);
            rd_2.TabIndex = 30;
            rd_2.Text = "-20-4";
            rd_2.UseVisualStyleBackColor = true;
            rd_2.CheckedChanged += rd_1_CheckedChanged;
            // 
            // num007NumberByLine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            Name = "num007NumberByLine";
            Size = new Size(1526, 655);
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
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

            int b = RandomNumber.Randomnumber(0, 3000);
            string file;
            if (b > 1000)
            {
                file = Application.StartupPath + @"\File\PicSam\ExNumLine.png";
            }
            else if (b> 1000 && b <= 2000)
            {
                file = Application.StartupPath + @"\File\PicSam\ExNumLine_01.png";
            }
            else
            {
                file = Application.StartupPath + @"\File\PicSam\ExNumLine_03.png";
            }
            


            xC = 100;
            yC = yC + 50;
            for (int i = 1; i <= 5; i++)
            {

                int a = RandomNumber.Randomnumber(minValue, maxValue);
                e.Graphics.DrawImage(TORServices.Drawings.exImage.ResizeImage(Image.FromFile(file), 700, 180), xC, yC);
                e.Graphics.DrawString(a.ToString(), new Font("Arial", 26, FontStyle.Bold), new SolidBrush(Color.Black), xC + 240, yC + 10);

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
