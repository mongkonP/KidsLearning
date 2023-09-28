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
using TORServices.Maths.Sci;
using TORServices.Systems;

namespace KidsLearning.Print.ptnMth.m01Num
{
   public partial class num013_PowerPerfix_02 : prnControl
    {

        public num013_PowerPerfix_02()
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
            this.groupBox2.Size = new System.Drawing.Size(1258, 632);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1252, 610);
            // 
            // num013_PowerbyTen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "num013_PowerbyTen";
            this.Size = new System.Drawing.Size(1502, 632);
            this.Load += new System.EventHandler(this.prn_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #region Variables

       // int minValue = 10, maxValue = 200;
        Random random = new Random();

        #endregion


        Random r = new Random();

        List<Prefixe> Prefixs;
        Dictionary<string, string> units;

        private void prn_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "หน่วยนับและคำอปุสรรค ";
            Prefixs = Prefixess.prefixes;
            units = Unit.Units;
            printPreviewControl1.Document = this.printDocument1;
        }



        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail

            int yC = 150, xC = 100;

            string sss;



            for (int i = 0; i < 4; i++)
            {

                double a;
                int b;
                List<Prefixe> lst = Prefixs;
             
                // หา key ที่ index ที่สุ่มได้
                string _uint = units.ElementAt(random.Next(0, units.Count)).Key;


                int c = RandomNumber.Randomnumber(0, lst.Count );
                Prefixe pr_01 = lst[c];
                lst.RemoveAt(c);
                int d = RandomNumber.Randomnumber(0, lst.Count );
                Prefixe pr_02 = lst[d];
                lst.RemoveAt(d);

                if (c < d)
                {
                    sss = $" แปลงหน่วยจาก { (r.NextDouble()*Math.Pow(10,r.Next(0,2))).ToString($"F{r.Next(2, 5)}")} {pr_01.prefixeTh.Trim()}{_uint} ";
                }
                else
                {
                    sss = $"แปลงหน่วยจาก {(r.NextDouble() * Math.Pow(10, r.Next(3, 5))).ToString($"F0")} {pr_01.prefixeTh.Trim()}{_uint}";// $" แปลงหน่วยจาก {(pr_01.factor / pr_02.factor) * double.Parse(r.NextDouble().ToString($"F{r.Next(2, 5)}")) * Math.Pow(10, r.Next(2, 5))} {pr_01.prefixeTh.Trim()}{_uint} ";

                }


                sss +=   $" เป็นหน่วย {pr_02.prefixeTh.Trim()}{_uint} " +
                    $"\n ______________________________________________________________________" +
                    $"\n ______________________________________________________________________" +
                    $"\n ______________________________________________________________________" +
                    $"\n ______________________________________________________________________" +
                    $"\n ______________________________________________________________________";

                
                

                e.Graphics.DrawString(sss, new Font("Segoe UI", 16), new SolidBrush(Color.Black), xC, yC);
                yC += 200;



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
