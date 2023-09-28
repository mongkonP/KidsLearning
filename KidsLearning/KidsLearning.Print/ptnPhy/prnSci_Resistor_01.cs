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

namespace KidsLearning.Print.ptnPhy
{
    public partial class prnSci_Resistor_01 : prnControl
    {

        public prnSci_Resistor_01()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // groupBox1
            // 
            groupBox1.Size = new Size(244, 606);
            // 
            // panel2
            // 
            panel2.Size = new Size(238, 131);
            // 
            // bntPrint
            // 
            bntPrint.Location = new Point(12, 70);
            // 
            // label2
            // 
            label2.Location = new Point(170, 31);
            // 
            // txtPageCount
            // 
            txtPageCount.Location = new Point(80, 28);
            // 
            // label1
            // 
            label1.Location = new Point(12, 31);
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(244, 0);
            groupBox2.Size = new Size(1138, 606);
            // 
            // printPreviewControl1
            // 
            printPreviewControl1.Size = new Size(1132, 584);
            // 
            // prnSci_Resistor_01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            Name = "prnSci_Resistor_01";
            Size = new Size(1382, 606);
            Load += prn_Load;
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }


        #region Variables

        int minValue = 10, maxValue = 200;
        Random random = new Random();
        #endregion




        private void prn_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "การคำนวณรหัสสีตัวต้านทาน 1";
            printPreviewControl1.Document = printDocument1;
        }

        private void rd_1_CheckedChanged(object sender, EventArgs e)
        {

            printPreviewControl1.Document = printDocument1;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail

            int yC = 150, xC = 200;


            for (int i = 0; i < 3; i++)
            {
                if (RandomNumber.Randomnumber(0, 1000) > 500)
                {
                    e.Graphics.DrawResistor01(xC, yC);
                }
                else
                {
                    e.Graphics.DrawResistor02(xC, yC);

                }

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
            e.HasMorePages = bMorePagesToPrint ? true : false;
        }

    }
}
