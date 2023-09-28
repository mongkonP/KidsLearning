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

namespace KidsLearning.Print.ptnMth
{
    public partial class prnMath_06Equation_01 : prnControl
    {
        public prnMath_06Equation_01()
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
            ReportHeader = "การทดสอบ เกี่ยวกับ สมการ ตัวแปรเดียว";
            ReportToppic = "แสดงวิธีทำเพื่อหาคำตอบของสมการ ต่อไปนี้ (สามารถตอบในรูปเศษส่วนได้)";
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
            this.groupBox1.Size = new System.Drawing.Size(214, 614);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(208, 103);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(1192, 614);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1186, 595);
            // 
            // prnMath_06Equation_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "prnMath_06Equation_01";
            this.Size = new System.Drawing.Size(1406, 614);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

       /* string[] sChar = new string[] { "a", "b", "c", "x", "y", "z" };
        private string _Equation()
        {
            int a = RandomNumber.Randomnumber(-20, 20);
            int b = RandomNumber.Randomnumber(-20, 20);
            int c = RandomNumber.Randomnumber(-20, 20);

            int d = RandomNumber.Randomnumber(1, 5000);
            string o = (RandomNumber.Randomnumber(1, 3000) > 1500) ? "+" : "-";
            string s = "";
            String _a=(a==1?"":a.ToString()), _b=(b==1?"":b.ToString());
            switch (d)
            {
                case int n when (n >= 0 && n < 1000):
                    //ax+b=0
                    s = $"{_a}{sChar[RandomNumber.Randomnumber(0, sChar.Length)]} {o} {_b}  = 0";
                    break;

                case int n when (n >= 1000 && n < 2000):
                    //ax+b=c
                    s = $"{_a}{sChar[RandomNumber.Randomnumber(0, sChar.Length)]} {o} {_b}  = {c}";
                    break;

                case int n when (n >= 2000 && n < 3000):
                    //ax = b+c
                    s = $"{_a}{sChar[RandomNumber.Randomnumber(0, sChar.Length)]} = {_b} {o} {c}";
                    break;
                case int n when (n >= 3000 && n < 4000):
                    //ax=b
                    s = $"{_a}{sChar[RandomNumber.Randomnumber(0, sChar.Length)]} = {_b} {o} {c}";
                    break;
                
                case int n when (n >= 4000 && n <= 5000):
                    //c=ax+b
                    s = $"{_a}{sChar[RandomNumber.Randomnumber(0, sChar.Length)]} = {_b} {o} {c}";
                    break;
                    
            }

            return s.Replace("--", "+").Replace("+-", "-").Replace("-+", "-")
                .Replace("- -", "+").Replace("+ -", "-").Replace("- +", "-");
        }*/
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail

           // List<int> Nums = new List<int>();
            int yC = 100;
            int xC = 100;
            int w = 80, h = 50;
            Pen pen = new Pen(Color.Black, 2);
            SolidBrush solidBrush = new SolidBrush(Color.White);
            e.Graphics.DrawLine(new Pen(Color.Black, 3), 420, yC + 30, 420, yC + 900);
            xC = 50;
            yC = yC + 30;

            for (int i = 1; i <= 3; i++)
            {

                e.Graphics.DrawString(TORServices.Maths.Expression.GenerateExpressionOne(), fontExpression, new SolidBrush(Color.Black), xC + 20, yC + 5); xC += 380;

                e.Graphics.DrawString(TORServices.Maths.Expression.GenerateExpressionOne(), fontExpression, new SolidBrush(Color.Black), xC + 20, yC + 5);


                //e.Graphics.DrawString("แสดงวิธีทำหาคำตอบของสมการ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5);
                xC = 50;
                yC = yC + 280;

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
