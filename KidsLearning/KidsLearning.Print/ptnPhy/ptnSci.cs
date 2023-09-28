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

namespace KidsLearning.Print.ptnPhy
{
    public partial class ptnSci : prnControl
    {
        public ptnSci()
        {
            InitializeComponent();
            Load += new EventHandler(frm_Load);
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);

        }

        #region Variables

        int minValue = 1, maxValue = 15;

        #endregion
        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "นับจำนวนตามรูปภาพและ X รูปที่มีจำนวนมากกว่า\n** หากจำนวนเท่ากันให้ X ทั้ง 2 รูป";
            iPage = 1;
            iPageAll = 1;

            printPreviewControl1.Document = printDocument1;
        }

        private void InitializeComponent()
        {
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Size = new Size(250, 715);
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 593);
            // 
            // groupBox2
            // 
            groupBox2.Size = new Size(781, 715);
            // 
            // printPreviewControl1
            // 
            printPreviewControl1.Size = new Size(775, 693);
            // 
            // prnMath_83_Num_01_1to15_5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            Name = "prnMath_83_Num_01_1to15_5";
            Size = new Size(1031, 715);
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail

            List<int> Nums = new List<int>();
            int yC = 100;
            int xC = 100;
            int w = 80, h = 50;
            Pen pen = new Pen(Color.Black, 2);
            SolidBrush solidBrush = new SolidBrush(Color.White);

            xC = 150;
            yC = yC + 150;

            for (int i = 1; i <= 6; i += 2)
            {

                int a = RandomNumber.Randomnumber(1, 10);
                int b = RandomNumber.Randomnumber(1, 10);
                e.Graphics.DrawImage(ExtGraphics_Maths.ImageFromNumber(a, 250, 150, true), xC, yC);
                // e.Graphics.DrawRectangle(new Pen(Color.Black, 3), xC+40, yC+110, 60, 60);
                xC = xC + 300;
                e.Graphics.DrawImage(ExtGraphics_Maths.ImageFromNumber(b, 250, 150, true), xC, yC);
                // e.Graphics.DrawRectangle(new Pen(Color.Black, 3), xC + 40, yC + 110, 60, 60);
                xC = 150;
                yC = yC + 250;

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
            e.HasMorePages = bMorePagesToPrint ? true : false;
        }

    }
}
