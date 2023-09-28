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
    public partial class num004NumberArabicThaiStringRoman : prnControl
    {
        public num004NumberArabicThaiStringRoman()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);

        }

        #region Variables

        int minValue = 1, maxValue = 15;

        #endregion
        private Classed.Controls.NumberSelect numberSelect1;

        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "การเขียน ตัวเลขฮินดู อารบิกและตัวเลขไทย แสดงจำนวนนับ\n**เติมส่วนที่ขาดไปในช่องว่าง";
            iPage = 1;
            iPageAll = 1;

            printPreviewControl1.Document = this.printDocument1;
        }

        private void InitializeComponent()
        {
            numberSelect1 = new Classed.Controls.NumberSelect();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numberSelect1);
            groupBox1.Size = new Size(470, 655);
            groupBox1.Controls.SetChildIndex(numberSelect1, 0);
            groupBox1.Controls.SetChildIndex(panel2, 0);
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 572);
            panel2.Size = new Size(464, 119);
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(470, 0);
            groupBox2.Size = new Size(1056, 655);
            // 
            // printPreviewControl1
            // 
            printPreviewControl1.Size = new Size(1050, 633);
            // 
            // numberSelect1
            // 
            numberSelect1.Dock = DockStyle.Top;
            numberSelect1.Location = new Point(3, 19);
            numberSelect1.Name = "numberSelect1";
            numberSelect1.Size = new Size(464, 553);
            numberSelect1.TabIndex = 2;
            numberSelect1.NumberSelectChanged += numberSelect1_NumberSelectChanged;
            // 
            // num004NumberArabicThaiStringRoman
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            Name = "num004NumberArabicThaiStringRoman";
            Size = new Size(1526, 655);
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void numberSelect1_NumberSelectChanged(object sender, EventArgs e)
        {
            minValue = Convert.ToInt32(numberSelect1.Minimum);
            maxValue = Convert.ToInt32(numberSelect1.Maximum);
            printPreviewControl1.Document = this.printDocument1;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail

            List<int> Nums = new List<int>();
            int yC = 180;
            int xC = 100;
            int w = 80, h = 50;
            Pen pen = new Pen(Color.Black, 2);
            SolidBrush solidBrush = new SolidBrush(Color.White);

            xC = 150;

            for (int i = 1; i <= 5; i++)
            {

                int a = RandomNumber.Randomnumber(minValue, maxValue);

                int b = RandomNumber.Randomnumber(0, 3000);

                if (b < 1000)
                {
                    e.Graphics.DrawTableNumberText(xC + 20, yC + 5, a, false, false, true);
                }
                else if (b > 1000 && b < 2000)
                {
                    e.Graphics.DrawTableNumberText(xC + 20, yC + 5, a, true, false, false);
                }
                else
                {
                    e.Graphics.DrawTableNumberText(xC + 20, yC + 5, a, false, true, false);
                }


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
