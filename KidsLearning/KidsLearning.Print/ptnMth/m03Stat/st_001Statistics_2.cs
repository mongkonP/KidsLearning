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

namespace KidsLearning.Print.ptnMth.m03Stat
{
  public partial  class st_001Statistics_2:prnControl
    {
        public st_001Statistics_2()
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
            ReportHeader = "การทดสอบ เกี่ยวกับ สถิติ/Statistics "; ;
            ReportToppic = "สถิติเบื้องต้น";
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
            this.groupBox1.Size = new System.Drawing.Size(250, 629);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(1148, 629);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1142, 607);
            // 
            // st_001Statistics_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "st_001Statistics_2";
            this.Size = new System.Drawing.Size(1398, 629);
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

            int yC = 150, xC = 100;
            int w = 100, h = 40;
            int numCount = 0;
            string numString = "";
            for (int i = 0; i < 4; i++)
            {

                int a = RandomNumber.Randomnumber(5, 20);
                int b = Convert.ToInt32(a * 50 / 100);
                numCount = RandomNumber.Randomnumber(5, 15);
                numString = "";
                for (int x = 1; x <= numCount; x++)
                {
                    numString += "  " + RandomNumber.Randomnumber(a - b, a + b);
                }

                //  numString = "จากข้อมูล ตัวเลขต่อไปนี้ \n" + numString + "\n \n \n \n \n";
                e.Graphics.DrawString("จากข้อมูล ตัวเลขต่อไปนี้ " + numString, new Font("Angsana New", 15), new SolidBrush(Color.Black), xC + 50, yC + 5);
                yC += 35;
                e.Graphics.DrawString("1.เรียงจาก น้อยไปมาก ได้ดังนี้ ", new Font("Angsana New", 15), new SolidBrush(Color.Black), xC + 50, yC);
                yC += 25;
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 50, yC + 20, xC + 340, yC + 20);
                yC += 25;
                e.Graphics.DrawString("2.จำนวนข้อมูล = ", new Font("Angsana New", 15), new SolidBrush(Color.Black), xC + 50, yC);
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 180, yC + 20, xC + 240, yC + 20);
                yC += 25;
                e.Graphics.DrawString("3.ผลรวมของข้อมูล = ", new Font("Angsana New", 15), new SolidBrush(Color.Black), xC + 50, yC);
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 180, yC + 20, xC + 240, yC + 20);
                yC += 25;
                e.Graphics.DrawString("4.ค่าเฉลี่ย (Mean) = ", new Font("Angsana New", 15), new SolidBrush(Color.Black), xC + 50, yC);
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC + 180, yC + 20, xC + 240, yC + 20);


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
