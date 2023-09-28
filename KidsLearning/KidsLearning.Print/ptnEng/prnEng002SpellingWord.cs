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
using OfficeOpenXml;

namespace KidsLearning.Print.ptnEng
{
  public partial  class prnEng002SpellingWord : prnControl
    {
        public enum CountWordForSpell { Str_1, Str_2, Str_3 , Str_Word, Str_Word_Tran };
        public prnEng002SpellingWord()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
        
        }

        #region Variables

       private List<string> wordsAll,  lstWord;
        private RadioButton rd_3;
        private RadioButton rd_2;
        private RadioButton rd_1;
        private RadioButton rd_4;
        private RadioButton rd_5;
        private CountWordForSpell countWordForSpell = CountWordForSpell.Str_2;
     
        #endregion
        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader =  "การทดสอบ เกี่ยวกับ การสะกดอ่านภาษาอังกฤษเบื้องต้น ";
            ReportToppic = "เปรียบเทียบ พยัญชนะ สระ พร้อมคำอ่าน ต่อไปนี้";
            iPage = 1;
            iPageAll = 1;

            wordsAll = new List<string>();
            wordsAll.AddRange(Eng_Word.lst_EngSymbol);
            wordsAll.AddRange(Eng_Word.lst_EngVowel);
            wordsAll.AddRange(Eng_Word.lst_EngSpelling);
            lstWord = new List<string>();


            FileInfo existingFile = new FileInfo(@System.Windows.Forms.Application.StartupPath + @"\File\Book\Eng\Eng word.xlsx");
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage(existingFile))
            {
                //get the first worksheet in the workbook
                ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                int colCount = worksheet.Dimension.End.Column;  //get Column Count
                int rowCount = worksheet.Dimension.End.Row;     //get row count
                lstWord = new List<string>();
                for (int row = 2; row <= rowCount; row++)
                {


                    if (!string.IsNullOrEmpty(worksheet.Cells[row, 1].Value?.ToString().Trim()))
                        lstWord.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());
                }

            };


            printPreviewControl1.Document = this.printDocument1;
        }

        private void InitializeComponent()
        {
            this.rd_1 = new System.Windows.Forms.RadioButton();
            this.rd_2 = new System.Windows.Forms.RadioButton();
            this.rd_3 = new System.Windows.Forms.RadioButton();
            this.rd_4 = new System.Windows.Forms.RadioButton();
            this.rd_5 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(250, 707);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rd_5);
            this.panel2.Controls.Add(this.rd_4);
            this.panel2.Controls.Add(this.rd_3);
            this.panel2.Controls.Add(this.rd_2);
            this.panel2.Controls.Add(this.rd_1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            this.panel2.Size = new System.Drawing.Size(244, 428);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            this.panel2.Controls.SetChildIndex(this.txtPageCount, 0);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.bntPrint, 0);
            this.panel2.Controls.SetChildIndex(this.rd_1, 0);
            this.panel2.Controls.SetChildIndex(this.rd_2, 0);
            this.panel2.Controls.SetChildIndex(this.rd_3, 0);
            this.panel2.Controls.SetChildIndex(this.rd_4, 0);
            this.panel2.Controls.SetChildIndex(this.rd_5, 0);
            // 
            // bntPrint
            // 
            this.bntPrint.Location = new System.Drawing.Point(13, 352);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(171, 313);
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(81, 310);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 313);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(1276, 707);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1270, 685);
            // 
            // rd_1
            // 
            this.rd_1.AutoSize = true;
            this.rd_1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_1.Location = new System.Drawing.Point(30, 28);
            this.rd_1.Name = "rd_1";
            this.rd_1.Size = new System.Drawing.Size(163, 36);
            this.rd_1.TabIndex = 14;
            this.rd_1.Text = "1 ชุด ตัวอักษร";
            this.rd_1.UseVisualStyleBackColor = true;
            this.rd_1.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_2
            // 
            this.rd_2.AutoSize = true;
            this.rd_2.Checked = true;
            this.rd_2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_2.Location = new System.Drawing.Point(30, 69);
            this.rd_2.Name = "rd_2";
            this.rd_2.Size = new System.Drawing.Size(163, 36);
            this.rd_2.TabIndex = 15;
            this.rd_2.TabStop = true;
            this.rd_2.Text = "2 ชุด ตัวอักษร";
            this.rd_2.UseVisualStyleBackColor = true;
            this.rd_2.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_3
            // 
            this.rd_3.AutoSize = true;
            this.rd_3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_3.Location = new System.Drawing.Point(30, 122);
            this.rd_3.Name = "rd_3";
            this.rd_3.Size = new System.Drawing.Size(163, 36);
            this.rd_3.TabIndex = 16;
            this.rd_3.Text = "3 ชุด ตัวอักษร";
            this.rd_3.UseVisualStyleBackColor = true;
            this.rd_3.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_4
            // 
            this.rd_4.AutoSize = true;
            this.rd_4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_4.Location = new System.Drawing.Point(30, 177);
            this.rd_4.Name = "rd_4";
            this.rd_4.Size = new System.Drawing.Size(167, 36);
            this.rd_4.TabIndex = 17;
            this.rd_4.Text = "ชุดอ่านคำศัพท์";
            this.rd_4.UseVisualStyleBackColor = true;
            this.rd_4.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_5
            // 
            this.rd_5.AutoSize = true;
            this.rd_5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_5.Location = new System.Drawing.Point(30, 235);
            this.rd_5.Name = "rd_5";
            this.rd_5.Size = new System.Drawing.Size(202, 36);
            this.rd_5.TabIndex = 18;
            this.rd_5.Text = "ชุดคำศัพท์/คำแปล";
            this.rd_5.UseVisualStyleBackColor = true;
            this.rd_5.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // prnEng002SpellingWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "prnEng002SpellingWord";
            this.Size = new System.Drawing.Size(1526, 707);
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

            string spell = "";
            int yC = 150 , xC = 100;
            int w = 100, h = 35;
            if (countWordForSpell != CountWordForSpell.Str_Word && countWordForSpell != CountWordForSpell.Str_Word_Tran)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (countWordForSpell == CountWordForSpell.Str_1)
                    {
                        spell = Eng_Word.GetWord(wordsAll);
                    }
                    else if (countWordForSpell == CountWordForSpell.Str_2)
                    {
                        spell = Eng_Word.GetWord(Eng_Word.lst_EngSymbol) + "_" + Eng_Word.GetWord(Eng_Word.lst_EngVowel);

                    }
                    else if (countWordForSpell == CountWordForSpell.Str_3)
                    {
                        spell = Eng_Word.GetWord(Eng_Word.lst_EngSymbol) + "_" + Eng_Word.GetWord(Eng_Word.lst_EngVowel) + "_" + Eng_Word.GetWord(Eng_Word.lst_EngSpelling);

                    }

                    e.Graphics.DrawSpellWord(spell.Split('_').ToList<string>(), fontDetail, 100, yC);
                    yC += 100;
                }


            }
            else if (countWordForSpell == CountWordForSpell.Str_Word)
            {
                int count = 14;
                // DrawTable
                for (int ip = 0; ip <= count; ip++)
                {
                    e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC + 620, yC);
                    yC += h;
                }

                yC = 150; xC = 100;
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC, yC + h * count);

                e.Graphics.DrawString("  คำศัพท์   ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5); xC += 100;
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC, yC + h * count);

                e.Graphics.DrawString("พยัญชนะต้น", fontDetail, new SolidBrush(Color.Black), xC, yC + 5); xC += 100;
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC, yC + h * count);

                e.Graphics.DrawString(" สระ ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5); xC += 100;
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC, yC + h * count);

                e.Graphics.DrawString(" ตัวสะกด ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5); xC += 100;
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC, yC + h * count);

                e.Graphics.DrawString(" คำอ่าน ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5); xC += 220;
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC, yC + h * count);

                yC += h; xC = 100;
                for (int ip = 1; ip <= count - 1; ip++)
                {


                    e.Graphics.DrawString(lstWord[RandomNumber.Randomnumber(0, lstWord.Count)], fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5);

                    yC += h;
                }

            }
            else if (countWordForSpell == CountWordForSpell.Str_Word_Tran)
            {
                int count = 14;
                // DrawTable
                for (int ip = 0; ip <= count; ip++)
                {
                    e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC + 620, yC);
                    yC += h;
                }

                yC = 150; xC = 100;
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC, yC + h * count);

                e.Graphics.DrawString("  คำศัพท์   ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5); xC += 200;
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC, yC + h * count);
                e.Graphics.DrawString("   คำอ่าน   ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5); xC += 200;
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC, yC + h * count);
                e.Graphics.DrawString("คำแปล ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5); xC += 220;
                e.Graphics.DrawLine(new Pen(Color.Black, 1), xC, yC, xC, yC + h * count);

                yC += h; xC = 100;
                for (int ip = 1; ip <= count - 1; ip++)
                {


                    e.Graphics.DrawString(lstWord[RandomNumber.Randomnumber(0, lstWord.Count)], fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5);

                    yC += h;
                }

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

        private void rd_1_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_1.Checked)
            {
                countWordForSpell = CountWordForSpell.Str_1;
            }
            else if (rd_2.Checked)
            {
                countWordForSpell = CountWordForSpell.Str_2;
            }
            else if (rd_3.Checked)
            {
                countWordForSpell = CountWordForSpell.Str_3;
            }
            else if (rd_4.Checked)
            {
                ReportToppic = "ฝึกเขียน และ อ่านคำศัพท์ต่อไปนี้"; ;
                countWordForSpell = CountWordForSpell.Str_Word;
            }
            else if (rd_5.Checked)
            {
                ReportToppic = "ฝึกเขียน และ อ่านคำศัพท์ต่อไปนี้"; ;
                countWordForSpell = CountWordForSpell.Str_Word_Tran;
            }
            printPreviewControl1.Document = this.printDocument1;
        }
    }
}
