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
    public partial class num01DecimalConvert : prnControl
    {
        public num01DecimalConvert()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);

        }

        #region Variables

        int minValue = 1, maxValue = 15;

        #endregion
        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "แปลงเลขฐานต่อไปนี้";
            iPage = 1;
            iPageAll = 1;

            printPreviewControl1.Document = this.printDocument1;
        }

        private void InitializeComponent()
        {
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(284, 614);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(278, 382);
            // 
            // bntPrint
            // 
            this.bntPrint.Location = new System.Drawing.Point(18, 335);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(147, 299);
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(70, 296);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 299);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(284, 0);
            this.groupBox2.Size = new System.Drawing.Size(1122, 614);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1116, 595);
            // 
            // num01DecimalConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "num01DecimalConvert";
            this.Size = new System.Drawing.Size(1406, 614);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        string _ConvertNum()
        {
            string s = "แปลงค่าจากเลขฐาน {0} จาก {1} เป็นเลขฐาน {2} ";
            List<int>  nums = new  List<int> { 2,  8, 10, 16 };
            List<int> nums_ = new List<int> { 2,  8, 10, 16 };
            int a = RandomNumber.Randomnumber(1, 1000);
            int r = RandomNumber.Randomnumber(1, 10);
            int n = nums[RandomNumber.Randomnumber(0, nums.Count-1)];
            nums_.Remove(n);
            string num = Convert.ToString(a, n);
            return string.Format(s,n,num, nums_[RandomNumber.Randomnumber(0, nums_.Count-1)]);

        }
      
        string _ConvertRomanNum()
        {
            string s = "แปลงค่าจาก จาก {0} เป็น {1} ";
            int a = RandomNumber.Randomnumber(1, 9000);
            string _a = a.ToRomanNumber();
            int b = RandomNumber.Randomnumber(1, 2000);
            if (b >= 1 && b <1000)
            {
                s = $"แปลงค่าจาก จาก {a} เป็น เลขโรมัน ";
            }
            else
            {
                s = $"แปลงค่าจาก จาก {_a} เป็น เลขฐานสิบ ";
            }

            return string.Format(s);

        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail

            int yC = 120, xC = 150;
            int b = RandomNumber.Randomnumber(1, 2000);
            for (int i = 1; i < 5; i++)
            {
                e.Graphics.DrawString((b >= 1 && b < 1000) ? _ConvertNum(): _ConvertRomanNum(), fontExpression, new SolidBrush(Color.Black), xC, yC);

                yC = yC + 230;

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
