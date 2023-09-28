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
using TORServices.Maths.Chem.MolecularMass;

namespace KidsLearning.Print.ptnChem
{
    public partial class prnChem_05_Molecular_02 : prnControl
    {
        public prnChem_05_Molecular_02()
        {
            InitializeComponent();
            Load += new EventHandler(frm_Load);
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            fontDetail = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        }
        List<string> FM;
        #region Variables

        int minValue = 1, maxValue = 15;

        #endregion

        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;

        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ การคำนวณมวลโมเลกุล";
            ReportToppic = "คำนวณมวลโมเลกุล ต่อไปนี้";
            iPage = 1;
            iPageAll = 1;
            InitData();
        }
        void InitData()
        {
            FM = new List<string>();
            using (StreamReader reader = new StreamReader("File\\Book\\Sci\\FM_CHEM.txt"))
            {
                reader.ReadToEnd().Split('\n')
                        .ToList()
                        .ForEach(mf =>
                        {
                            if (!string.IsNullOrEmpty(mf.Trim()))
                            {
                                if (radioButton1.Checked)
                                {
                                    if (mf.Trim().Length <= 10)
                                        FM.Add(mf.Trim());
                                }
                                else if (radioButton2.Checked)
                                {
                                    if (mf.Trim().Length > 10)
                                        FM.Add(mf.Trim());
                                }
                                else
                                {
                                    FM.Add(mf.Trim());
                                }
                            }

                        });
            }
            printPreviewControl1.Document = printDocument1;
        }
        private void InitializeComponent()
        {
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Size = new Size(250, 655);
            // 
            // panel2
            // 
            panel2.Controls.Add(radioButton3);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton1);
            panel2.Size = new Size(244, 399);
            panel2.Controls.SetChildIndex(label1, 0);
            panel2.Controls.SetChildIndex(txtPageCount, 0);
            panel2.Controls.SetChildIndex(label2, 0);
            panel2.Controls.SetChildIndex(bntPrint, 0);
            panel2.Controls.SetChildIndex(radioButton1, 0);
            panel2.Controls.SetChildIndex(radioButton2, 0);
            panel2.Controls.SetChildIndex(radioButton3, 0);
            // 
            // bntPrint
            // 
            bntPrint.Location = new Point(11, 335);
            // 
            // groupBox2
            // 
            groupBox2.Size = new Size(1276, 655);
            // 
            // printPreviewControl1
            // 
            printPreviewControl1.Size = new Size(1270, 633);
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(25, 80);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(78, 25);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "อย่างง่าย";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += rd_1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(25, 120);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(81, 25);
            radioButton2.TabIndex = 15;
            radioButton2.Text = "อย่างยาก";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += rd_1_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(25, 162);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(51, 25);
            radioButton3.TabIndex = 16;
            radioButton3.Text = "รวม";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += rd_1_CheckedChanged;
            // 
            // prnChem_03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            Name = "prnChem_03";
            Size = new Size(1526, 655);
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        /* private string SetSubString(string Formulas)
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


         }*/
        private void rd_1_CheckedChanged(object sender, EventArgs e)
        {
            InitData();
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

            for (int i = 1; i < 4; i++)
            {
                string Formulas = FM[RandomNumber.Randomnumber(0, FM.Count)]; //new molecularMass().SetSubString.ToSubscriptNumber();
                molecularMass m = new molecularMass(Formulas);
                Formulas += "\n" + new molecularMass(Formulas);
                e.Graphics.DrawString($"{m.SetSubString.ToSubscriptNumber()} \n {m.GetAtomDetails}", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5);

                //string Formulas = new molecularMass(FM[RandomNumber.Randomnumber(0, FM.Count)]).SetSubString.ToSubscriptNumber();
                // e.Graphics.DrawString($"คำนวณมวลโมเลกุล {Formulas}", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5);
                // e.Graphics.DrawString($"คำนวณน้ำหนักโมเลกุล {FM[RandomNumber.Randomnumber(0, FM.Count)]}", fontDetail, new SolidBrush(Color.Black), xC + 400, yC + 5);
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
