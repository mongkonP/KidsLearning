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
using System.Text.RegularExpressions;
using System.Data;
using TORServices.Maths.Chem.MolecularMass;

namespace KidsLearning.Print.ptnChem
{
    public partial class prnChem_04_Atom_01 : prnControl
    {
        public prnChem_04_Atom_01()
        {
            InitializeComponent();
            Load += new EventHandler(frm_Load);
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            fontDetail = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            filePrintPre = "File\\Book\\Sci\\PeriodicTable.png";
        }
        DataTable Elements;
        #region Variables

        int minValue = 1, maxValue = 15;

        #endregion

        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตารางธาตุ";
            ReportToppic = "บอกรายละเอียดธาติ ต่อไปนี้";
            iPage = 1;
            iPageAll = 1;
            Elements = ExtSci_Chem.AtomicData();


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
            groupBox1.Size = new Size(250, 0);
            // 
            // panel2
            // 
            panel2.Size = new Size(244, 155);
            // 
            // bntPrint
            // 
            bntPrint.Location = new Point(11, 76);
            // 
            // groupBox2
            // 
            groupBox2.Size = new Size(0, 0);
            // 
            // printPreviewControl1
            // 
            printPreviewControl1.Size = new Size(0, 0);
            // 
            // prnChem_04_Atom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            Name = "prnChem_04_Atom";
            Size = new Size(0, 0);
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private string SetSubString(string Formulas)
        {

            string input = Formulas;
            string output = "";
            string[] groups = input.Split('.');

            foreach (string group in groups)
            {

                Match match = Regex.Match(group, @"^(\d+)(.*)$");
                if (match.Success)
                {
                    string replacedS2 = Regex.Replace(match.Groups[2].Value, @"(\d+)", "[sub]$1[/sub]");
                    output += match.Groups[1].Value + replacedS2;
                }
                else
                {
                    string replacedS2 = Regex.Replace(group, @"(\d+)", "[sub]$1[/sub]");
                    output += replacedS2;
                }
            }
            return output;


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

            xC = 100;
            yC = yC + 30;

            for (int i = 1; i < 6; i++)
            {
                DataRow r = Elements.Rows[RandomNumber.Randomnumber(0, Elements.Rows.Count)];
                string Symbol = r[0].ToString();
                string ElementName = r[1].ToString();
                double AtomicMass = (double)r[2];
                int AtomicNumber = (int)r[3];

                e.Graphics.DrawString(
                    $"ElementName:  {ElementName}\n" +
                    $"Symbol: ..................................\n" +
                    $"AtomicMass: ..............................\n" +
                    $"AtomicNumber: ............................", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5);

                xC = 100;
                yC = yC + 160;

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
