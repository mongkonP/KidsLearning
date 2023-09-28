using KidsLearning.Classed;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TORServices.Maths;

namespace KidsLearning.Print.ptnMth.m09Polynomial
{
    public partial class _Monomial_Factorization_01 : prnControl
    {
        private System.Windows.Forms.Panel panel1;

        public _Monomial_Factorization_01()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);

        }

        #region Variables



        #endregion

        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ พหุนาม ";
            ReportToppic = "การแจกแจงตัวประกอบพหุนาม";
            iPage = 1;
            iPageAll = 1;


            printPreviewControl1.Document = this.printDocument1;
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Size = new System.Drawing.Size(334, 614);
            this.groupBox1.Controls.SetChildIndex(this.panel1, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel2, 0);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 52);
            this.panel2.Size = new System.Drawing.Size(328, 118);
            // 
            // bntPrint
            // 
            this.bntPrint.Location = new System.Drawing.Point(9, 57);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(145, 23);
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(68, 21);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 23);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(334, 0);
            this.groupBox2.Size = new System.Drawing.Size(1045, 614);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1039, 595);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 36);
            this.panel1.TabIndex = 1;
            // 
            // _Monomial_Factorization_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "_Monomial_Factorization_01";
            this.Size = new System.Drawing.Size(1379, 614);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void prnMath_01Num07Odd02Number_Load(object sender, EventArgs e)
        {

            printPreviewControl1.Document = this.printDocument1;
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            printPreviewControl1.Document = this.printDocument1;
        }
        string _Draw()
        {

            string op = "";
            string cr =Expression.RandomCharacter();
            string term01 = Expression.GenerateTerm(cr,1,false);
            string term02 = Expression.GenerateTerm(cr, 1, false);

            int d = RandomNumber.Randomnumber(1, 7000);

            string expression ="";
            if (d < 1000)
            {
                //1.(น+ล)2 = น2  + 2นล + ล2
                expression = $"({term01} + {term02}){"2".ToSuperscriptNumber()}";
            }
            else if(d>=1000 && d <2000){
                //2.(น - ล)2 = น2  – 2นล + ล2
                expression = $"({term01} - {term02}){"2".ToSuperscriptNumber()}";
            }
            else if (d >= 2000 && d < 3000) {
                //3.(น-ล)(น+ล) = น2 – ล2
                expression = $"({term01} - {term02})({term01}+{term02})";
            }
            else if (d >= 3000 && d < 4000) {
                //4.(น-ล)( น2  + 2นล + ล2) = น3 – ล3
            }
            else if (d >= 4000 && d < 5000) {
                //5.(น+ล)( น2  –  2นล + ล2) =   น3 + ล3

            }
            else if (d >= 5000 && d < 6000) {
                //6.(น+ล)3  = น3 + 3น2 ล + 3นล2 + ล3
                expression = $"({term01} + {term02}){"3".ToSuperscriptNumber()}";
            }
            else if (d >= 6000 ) {
                //7.(น-ล)3  = น3 – 3น2 ล + 3นล2 – ล3
                expression = $"({term01} - {term02}){"3".ToSuperscriptNumber()}";
            }

            return expression;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            /* */

            #region _Draw Detail

            int yC = 150, xC = 120;
            int w = 100, h = 280;
             for (int row = 1; row < 4; row++)
             {
                 e.Graphics.DrawString(_Draw(), fontExpression, new SolidBrush(Color.Black), xC + 10, yC + 5);
                 yC += h;

             }
            #endregion


            if (iPage > iPageAll - 1)
             bNewPage =  bMorePagesToPrint = false;
            if (bNewPage) printDocumentNewPage(sender, e);


            iPage++;

            //If more lines exist, print another page.
            e.HasMorePages = (bMorePagesToPrint) ? true : false;
        }

    }
}
