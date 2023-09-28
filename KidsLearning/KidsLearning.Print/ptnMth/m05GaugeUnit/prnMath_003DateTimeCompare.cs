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

namespace KidsLearning.Print.ptnMth.m05GaugeUnit
{
  public partial  class prnMath_003DateTimeCompare : prnControl
    {
        public prnMath_003DateTimeCompare()
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
            ReportHeader = "การทดสอบ เกี่ยวกับ วัน เวลา ";
            ReportToppic = "การเปรียบเทียบระยะเวลาโดยใช้ความสัมพันธ์ ของหน่วยเวลา กำหนดให้ \n" +
                 "1 นาที เท่ากับ 60 วินาที 1 ชั่วโมง เท่ากับ 60 นาที 1 วัน เท่ากับ 24 ชั่วโมง 1 สัปดาห์ เท่ากับ 7 วัน \n"+
                "1 เดือน เท่ากับ 30 วัน  1 ปี เท่ากับ 12 เดือน 1 ปี เท่ากับ 365 วัน\n" ;
            //1 นาที เท่ากับ 60 วินาที
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
            this.groupBox1.Size = new System.Drawing.Size(250, 602);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            this.panel2.Size = new System.Drawing.Size(244, 131);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(1021, 602);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1015, 580);
            // 
            // prnMath_003DateTimeCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "prnMath_003DateTimeCompare";
            this.Size = new System.Drawing.Size(1271, 602);
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

            int yC = 200, xC = 100;
            for (int i = 0; i < 6; i++)
            {
                string str = "";
                string s = (RandomNumber.Randomnumber(0, 1000) < 500) ? "พ.ศ." : "ค.ศ.";
                int c = (s == "พ.ศ.") ? RandomNumber.Randomnumber(2525, 2570) : RandomNumber.Randomnumber(1981, 2030);
                str = $" ในปี {s} {c} ตรงกับ {((s == "พ.ศ.") ? "ค.ศ." : "พ.ศ.")} ใด  " +
                    $"\n วิธีทำ __________________________________________________" +
                    $"\n _______________________________________________________" +
                    $"\n                         ตอบ_______________ #";

                e.Graphics.DrawString(str, fontDetail, new SolidBrush(Color.Black), xC + 50, yC + 50);

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
