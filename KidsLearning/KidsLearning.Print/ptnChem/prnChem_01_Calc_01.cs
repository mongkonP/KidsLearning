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

namespace KidsLearning.Print.ptnChem
{
    public partial class prnChem_01_Calc_01 : prnControl
    {
        public prnChem_01_Calc_01()
        {
            InitializeComponent();
            Load += new EventHandler(frm_Load);
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            filePrintPre = "File\\Book\\Sci\\ตัวอย่างการเจือจาง.pdf";
        }

        #region Variables

        int minValue = 1, maxValue = 15;

        #endregion
        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ การเทียบบัญญัติไตรยางค์ ";
            ReportToppic = "ให้หาค่าจาก สมการ C1V1 = C2V2 ต่อไปนี้";
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
            groupBox1.Size = new Size(250, 516);
            // 
            // groupBox2
            // 
            groupBox2.Size = new Size(1132, 516);
            // 
            // printPreviewControl1
            // 
            printPreviewControl1.Size = new Size(1126, 494);
            // 
            // prnChem_01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            Name = "prnChem_01";
            Size = new Size(1382, 516);
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        List<double> pipete = new List<double>() { 0.1, 0.2, 0.3, 0.4, 0.5, 1, 2, 3, 4, 5, 10, 20, 25, 50 };
        List<double> flask = new List<double>() { 10, 25, 50, 100, 200, 250, 500, 1000 };
        List<double> dilute = new List<double>() { 2, 5, 10, 25, 50, 100, 200 };
        List<double> conc = new List<double>() { 1000, 500, 200, 100, 50, 10, 1 };
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

            xC = 100;
            yC = yC + 30;

            for (int i = 1; i < 4; i++)
            {

                double c1 = conc[RandomNumber.Randomnumber(0, conc.Count)];
                double v1 = pipete[RandomNumber.Randomnumber(0, pipete.Count)];
                double c2 = c1 / dilute[RandomNumber.Randomnumber(0, dilute.Count)];
                double v2 = flask[RandomNumber.Randomnumber(0, flask.Count)];
                //$"กำหนดให้ C1={c1}mg/L  V1 = {v1} mL  C2 = {c2} mg/L V2 = {v2} mL"

                string _c1 = $"C[sub]1[/sub]".ToSubscriptNumber();
                string _v1 = $"V[sub]1[/sub]".ToSubscriptNumber();
                string _c2 = $"C[sub]2[/sub]".ToSubscriptNumber();
                string _v2 = $"V[sub]2[/sub]".ToSubscriptNumber();
                int d = RandomNumber.Randomnumber(1, 4000);
                switch (d)
                {
                    case int n when n >= 0 && n < 1000:
                        e.Graphics.DrawString($"กำหนดให้ {_c1}={c1} mg/L  {_v1} = {v1} mL  {_c2} = {c2} mg/L {_v2} = ? mL", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5);
                        break;

                    case int n when n >= 1000 && n < 2000:
                        e.Graphics.DrawString($"กำหนดให้ {_c1}={c1} mg/L  {_v1} = {v1} mL  {_v2} = {v2} mL {_c2} = ? mg/L", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5);
                        break;

                    case int n when n >= 2000 && n < 3000:
                        e.Graphics.DrawString($"กำหนดให้ {_c1}={c1} mg/L   {_c2} = {c2} mg/L {_v2} = {v2} mL {_v1} = ? mL ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5);
                        break;
                    case int n when n >= 3000 && n <= 4000:
                        e.Graphics.DrawString($"กำหนดให้   {_v1} = {v1} mL {_c2} = {c2} mg/L {_v2} = {v2} mL  {_c1}= ? mg/L", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5);
                        break;
                }

                xC = 100;
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
