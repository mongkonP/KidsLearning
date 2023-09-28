using KidsLearning.Classed.Exten;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Drawings;
using TORServices.Maths;
using TORServices.Maths.Sci;
using TORServices.Systems;

namespace KidsLearning.Print.ptnMth.m01Num
{
   public partial class num013_PowerPerfix_01 : prnControl
    {

        public num013_PowerPerfix_01()
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

        int minValue = 10, maxValue = 200;
        Random random = new Random();
        List<Prefixe> Prefixs;
        List<string> units;
        #endregion


        Random r = new Random();

        private void prn_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "หน่วยนับและคำอปุสรรค ";

            Prefixs = new List<Prefixe>() {
             new Prefixe("เทระ", "tera-", "T-", "10^12", 1000000000000d),
            new Prefixe("จิกะ", "giga-", "G-", "10^9", 1000000000d),
            new Prefixe("เมกะ", "mega-", "M-", "10^6", 1000000d),
            new Prefixe("กิโล", "kilo-", "k-", "10^3", 1000d),
            new Prefixe("เฮกโต", "hecto-", "h-", "10^2", 100d),
            new Prefixe("เดคา", "deca-", "da-", "10^1", 10d),
           
            new Prefixe("เดซิ", "deci-", "d-", "10^-1", 0.1d),
            new Prefixe("เซนติ", "centi-", "c-", "10^-2", 0.01d),
            new Prefixe("มิลลิ", "milli-", "m-", "10^-3", 0.001d),
            new Prefixe("ไมโคร", "micro-", "μ-", "10^-6", 0.000001d),
            new Prefixe("นาโน", "nano-", "n-", "10^-9", 0.000000001d),
            new Prefixe("พิโค", "pico-", "p-", "10^-12", 0.000000000001d),
           };
            units = new List<string>() { "เมตร", "กรัม", "วินาที", "แอมแปร์", "เคลวิน", "โมล", "เฮิรตซ์", "นิวตัน", "จูล", "วัตต์", "โวลต์", "โอห์ม", "ฟารัด" };
            printPreviewControl1.Document = this.printDocument1;
        }



        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail

            int yC = 150, xC = 100;

            string sss;



            for (int i = 0; i < 6; i++)
            {

                string a;
                Prefixe prefixe = Prefixs[RandomNumber.Randomnumber(0, Prefixs.Count )];
                string _uint = units[RandomNumber.Randomnumber(0, units.Count)];

                 if (prefixe.factor >= 10d)
                  {
                    
                    a = ( (r.NextDouble().ToDouble(r.Next(2,5)))*(Math.Pow(10,r.Next(1,5)))* prefixe.factor).ToString("F0");
                  }
                  else
                  {



                    /* a = (RandomNumber.Randomnumber(10, 1000) * prefixe.factor).ToString(prefixe.factor.ToString());
                     string fm = $"F{ int.Parse( new Regex(@"\d+\^-?([\d]+)", RegexOptions.Compiled).Matches(prefixe.multi)[0].Groups[1].Value)+3}";
                     a = double.Parse(a).ToString("##0.############################################");*/

                    a = (r.NextDouble().ToDouble(r.Next(2, 5))* (Math.Pow(10, r.Next(1, 5))) * prefixe.factor).ToString("##0.############################################");
                }
               
                sss = $"  {a} {_uint} ในหน่วย  {prefixe.prefixeTh}{_uint} " +
                    $"\n ______________________________________________________________________" +
                    $"\n ______________________________________________________________________" +
                    $"\n ______________________________________________________________________";

                
                

                e.Graphics.DrawString(sss, new Font("Segoe UI", 16), new SolidBrush(Color.Black), xC, yC);
                yC += 155;



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
