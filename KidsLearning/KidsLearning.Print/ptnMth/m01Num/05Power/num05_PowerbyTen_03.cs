using KidsLearning.Classed.Exten;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Drawings;
using TORServices.Maths;
namespace KidsLearning.Print.ptnMth.m02OP
{
    public partial class num05_PowerbyTen_03 : prnControl
    {

        public num05_PowerbyTen_03()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(244, 632);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(238, 131);
            // 
            // bntPrint
            // 
            this.bntPrint.Location = new System.Drawing.Point(12, 70);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(170, 31);
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(80, 28);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 31);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(244, 0);
            this.groupBox2.Size = new System.Drawing.Size(1210, 632);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1204, 610);
            // 
            // op013_PowerbyTen_OP_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "op013_PowerbyTen_OP_01";
            this.Size = new System.Drawing.Size(1454, 632);
            this.Load += new System.EventHandler(this.prn_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #region Variables

        int minValue = 10, maxValue = 200;
        Random random = new Random();
        #endregion


        Random r = new Random();

        private void prn_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "การคูณ หาร เลขยกกำลังของ 10 ";

            printPreviewControl1.Document = this.printDocument1;
        }



        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail

            int yC = 150, xC = 100;

            string sss;

            //÷

            for (int i = 0; i < 3; i++)
            {

                string _a = (RandomNumber.Randomnumber(1, 1000) > 500) ? "x" : "÷";
                string _b = (RandomNumber.Randomnumber(1, 1000) > 500) ? "x" : "÷";
                string _c = (RandomNumber.Randomnumber(1, 1000) > 500) ? "x" : "÷";
                sss = "";
                int __a = RandomNumber.Randomnumber(2, 10);
                for (int a = 0; a <= __a; a++)
                {
                    sss += $"{(10 + "^" + RandomNumber.Randomnumber(-25, 25)).ToSuperscriptNumber()}";
                    if (a < __a)
                        sss += " " + ((RandomNumber.Randomnumber(1, 1000) > 500) ? "x" : "÷");
                }
                sss += $"= ?" +
                    $"\nวิธีทำ _________________________________________________" +
                    $"\n ______________________________________________________" +
                    $"\n ______________________________________________________" +
                    $"\n ______________________________________________________" +
                    $"\n ______________________________________________________" +
                    $"\n ______________________________________________________";


                e.Graphics.DrawString(sss, new Font("Segoe UI", 16), new SolidBrush(Color.Black), xC, yC);
                yC += 280;



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
