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
using System.IO;
using KidsLearning.Classed;

namespace KidsLearning.Print.ptnMth
{
    public partial class prnMath_06Equation_02 : prnControl
    {
        public prnMath_06Equation_02()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);

        }

        #region Variables

        int minValue = 1, maxValue = 15;
        List<string> Equations;
        #endregion
        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ สมการ 2 ตัวแปร";
            ReportToppic = "แสดงวิธีทำเพื่อหาคำตอบของสมการ ต่อไปนี้ (สามารถตอบในรูปเศษส่วนได้)";
            iPage = 1;
            iPageAll = 1;
            Equations = new List<string>();
            using (StreamReader reader = new StreamReader("File\\Book\\Mth\\EQ.txt"))
            {
                reader.ReadToEnd().Split('\n').ToList()
                        .ForEach(l =>
                        {
                            if (!string.IsNullOrEmpty(l))
                                Equations.Add(l);
                        });
            }
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
            this.groupBox1.Size = new System.Drawing.Size(214, 493);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(208, 103);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(1050, 493);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1044, 474);
            // 
            // prnMath_06Equation_02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "prnMath_06Equation_02";
            this.Size = new System.Drawing.Size(1264, 493);
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

            //List<int> Nums = new List<int>();
            int yC = 100;
            int xC = 100;
            int w = 80, h = 50;
           // Pen pen = new Pen(Color.Black, 2);
           // SolidBrush solidBrush = new SolidBrush(Color.White);
            xC = 50;
            yC = yC + 30;
            // GetImage(e.Graphics);
            List<string> list = Equations;
            for (int i = 1; i <= 4; i++)
            {
                int item = RandomNumber.Randomnumber(0, list.Count - 1);
                e.Graphics.DrawString(list[item], fontExpression, new SolidBrush(Color.Black), xC + 20, yC + 5);
                list.RemoveAt(item);
                xC = 50;
                yC = yC + 200;

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
