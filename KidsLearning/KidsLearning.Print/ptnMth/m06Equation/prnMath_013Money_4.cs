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
using System.Text.RegularExpressions;

namespace KidsLearning.Print.ptnMth
{
  public partial  class prnMath_013Money_4:prnControl
    {
        public prnMath_013Money_4()
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
            ReportHeader = "การทดสอบ เงินๆ ทองๆ ";
            ReportToppic = "ให้แสดงวิธีทำ การรวมยอดเงิน ต่อไปนี้";
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
            // prnMath_013Money_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "prnMath_013Money_4";
            this.Size = new System.Drawing.Size(1406, 614);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail

            int yC = 120, xC = 100;
            int w = 100, h = 40;
            for (int i = 0; i < 3; i++)
            {
                List<string> strType_ = new List<string>();
                strType_.AddRange(Exts.listNoodles);
                //  System.Windows.Forms.MessageBox.Show(strType_.Count.ToString());
                int cAll = RandomNumber.Randomnumber(0, 5);
                string name = Exts.RandomManName;
                string _return = name + " กินก๊วยเตี๋ยว โดยสั่ง ";
                int mc = 0;
                for (int cc = 0; cc <= cAll; cc++)
                {

                    int c = (strType_.Count - 1 > 0) ? RandomNumber.Randomnumber(0, strType_.Count ) : 0;
                    string s = strType_[c];
                    int _mc = RandomNumber.Randomnumber(1, 5);
                    _return += s + _mc + " ชาม ";
                    string smc;
                    try { smc = new Regex(@"(\d+)", RegexOptions.None).Match(s).Value.Trim(); }
                    catch { smc = ""; }
                    if (smc != "")
                        mc += int.Parse(smc) * _mc;
                    strType_.Remove(s);

                }

                List<int> payM = new List<int>() { 2, 5, 10, 20, 50, 100, 500, 1000 };
                listNum_A_B listA_B = new listNum_A_B();
                //1 2 5 10  20 50 100 500 1000
                List<int> payAll = new List<int>();


                int __mc;
                payAll.Add(mc);
                payM.ForEach(mm =>
                {
                    __mc = ((mc / mm) + 1) * mm;
                    if (!payAll.Contains(__mc))
                        payAll.Add(__mc);
                });


                _return += $"  เมื่อ {name} จ่ายเงิน " + payAll[RandomNumber.Randomnumber(0, payAll.Count )] 
                    + " บาท แม่ค้าต้องทอนเงินเท่าไหร่ ?";
                e.Graphics.DrawString(_return, fontDetail, new SolidBrush(Color.Black), new RectangleF(xC - 50, yC, 750, 80));
                yC += 75;


                yC += 35;
                e.Graphics.DrawString("แสดงวิธีทำ# ", fontDetail, new SolidBrush(Color.Black), xC - 10, yC - 25);
                yC -= 30;
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 80, yC, xC + 700, yC);
                for (int ii = 0; ii < 6; ii++)
                {
                    yC += 30;
                    e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 80, yC, xC + 700, yC);
                }
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 80, yC - 30 * 6, xC + 80, yC);
                e.Graphics.DrawString("  รายการ ", fontDetail, new SolidBrush(Color.Black), xC + 80, yC - 30 * 6);

                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 250, yC - 30 * 6, xC + 250, yC);
                e.Graphics.DrawString(" จำนวน", fontDetail, new SolidBrush(Color.Black), xC + 250, yC - 30 * 6);

                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 320, yC - 30 * 6, xC + 320, yC);
                e.Graphics.DrawString(" สมการ ", fontDetail, new SolidBrush(Color.Black), xC + 380, yC - 30 * 6);

                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 600, yC - 30 * 6, xC + 600, yC);
                e.Graphics.DrawString(" รวมยอดเงิน ", fontDetail, new SolidBrush(Color.Black), xC + 600, yC - 30 * 6);

                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 700, yC - 30 * 6, xC + 700, yC);

                e.Graphics.DrawString(" รวมยอดเงิน ", fontDetail, new SolidBrush(Color.Black), xC + 500, yC);
                e.Graphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(xC + 600, yC, 100, 30));
                e.Graphics.DrawString("แม่ค้าทอนเงิน                              -                              = ", fontDetail, new SolidBrush(Color.Black), xC + 5, yC + 20);
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(xC + 95, yC + 20, 100, 30));
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(xC + 210, yC + 20, 100, 30));
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(xC + 330, yC + 20, 100, 30));
                yC += 60;

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
