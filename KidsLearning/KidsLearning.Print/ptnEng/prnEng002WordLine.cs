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
  public partial  class prnEng002WordLine : prnControl
    {
      
        public prnEng002WordLine()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
        
        }

        #region Variables

       private List<string> wordsAll;

        List<int> Nums = new List<int>() { 0,1,2,3,4,5,6,7 };
        #endregion
        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader =  "การทดสอบ เกี่ยวกับ ภาษาอังกฤษเบื้องต้น ";
            ReportToppic = "ลากเส้นคำศัพท์ให้ถูกต้อง";
            iPage = 1;
            iPageAll = 1;

            wordsAll = new List<string>();
           


            FileInfo existingFile = new FileInfo(@System.Windows.Forms.Application.StartupPath + @"\File\Book\Eng\Eng Sentences_1.xlsx");
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage(existingFile))
            {



                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];//EAT
                int colCount = worksheet.Dimension.End.Column;  //get Column Count
                int rowCount = worksheet.Dimension.End.Row;     //get row count

                for (int row = 2; row <= rowCount; row++)
                {

                    //  MessageBox.Show(worksheet.Cells[row, 1].Value.ToString() + "\n" + worksheet.Cells[row, 3].Value.ToString());

                    if (!string.IsNullOrEmpty(worksheet.Cells[row, 1].Value?.ToString().Trim() + "" + worksheet.Cells[row, 3].Value?.ToString().Trim()))
                    {
                        if (!worksheet.Cells[row, 1].Value.ToString().Trim().Contains(" "))
                        {
                            wordsAll.Add(worksheet.Cells[row, 1].Value?.ToString().Trim() + "|" +
                               worksheet.Cells[row, 3].Value?.ToString().Trim());
                        }
                    }


                }
                worksheet = package.Workbook.Worksheets[1];//ห้องต่างๆ ในโรงเรียน
                colCount = worksheet.Dimension.End.Column;  //get Column Count
                rowCount = worksheet.Dimension.End.Row;     //get row count

                for (int row = 2; row <= rowCount; row++)
                {


                    if (!string.IsNullOrEmpty(worksheet.Cells[row, 1].Value?.ToString().Trim()))
                    {
                        if (!worksheet.Cells[row, 1].Value.ToString().Trim().Contains(" "))
                        {
                            wordsAll.Add(worksheet.Cells[row, 1].Value?.ToString().Trim() + "|" +
                                worksheet.Cells[row, 3].Value?.ToString().Trim());

                        }

                    }

                }

                worksheet = package.Workbook.Worksheets[2];//อาชีพ
                colCount = worksheet.Dimension.End.Column;  //get Column Count
                rowCount = worksheet.Dimension.End.Row;     //get row count

                for (int row = 2; row <= rowCount; row++)
                {


                    if (!string.IsNullOrEmpty(worksheet.Cells[row, 1].Value?.ToString().Trim()))
                    {
                        if (!worksheet.Cells[row, 1].Value.ToString().Trim().Contains(" "))
                        {
                            wordsAll.Add(worksheet.Cells[row, 1].Value?.ToString().Trim() + "|" +
                               worksheet.Cells[row, 3].Value?.ToString().Trim());

                        }

                    }

                }

                worksheet = package.Workbook.Worksheets[3];//สัตว์
                colCount = worksheet.Dimension.End.Column;  //get Column Count
                rowCount = worksheet.Dimension.End.Row;     //get row count

                for (int row = 2; row <= rowCount; row++)
                {


                    if (!string.IsNullOrEmpty(worksheet.Cells[row, 1].Value?.ToString().Trim()))
                    {
                        if (!worksheet.Cells[row, 1].Value.ToString().Trim().Contains(" "))
                        {

                            wordsAll.Add(worksheet.Cells[row, 1].Value?.ToString().Trim() + "|" +
                               worksheet.Cells[row, 3].Value?.ToString().Trim());

                        }

                    }

                }

                worksheet = package.Workbook.Worksheets[4];//กีฬา
                colCount = worksheet.Dimension.End.Column;  //get Column Count
                rowCount = worksheet.Dimension.End.Row;     //get row count

                for (int row = 2; row <= rowCount; row++)
                {


                    if (!string.IsNullOrEmpty(worksheet.Cells[row, 1].Value?.ToString().Trim()))
                    {
                        if (!worksheet.Cells[row, 1].Value.ToString().Trim().Contains(" "))
                        {
                            wordsAll.Add(worksheet.Cells[row, 1].Value?.ToString().Trim() + "|" +
                                worksheet.Cells[row, 3].Value?.ToString().Trim());

                        }

                    }


                }

                worksheet = package.Workbook.Worksheets[5];//สี
                colCount = worksheet.Dimension.End.Column;  //get Column Count
                rowCount = worksheet.Dimension.End.Row;     //get row count

                for (int row = 2; row <= rowCount; row++)
                {


                    if (!string.IsNullOrEmpty(worksheet.Cells[row, 1].Value?.ToString().Trim()))
                    {
                        if (!worksheet.Cells[row, 1].Value.ToString().Trim().Contains(" "))
                        {
                            wordsAll.Add(worksheet.Cells[row, 1].Value?.ToString().Trim() + "|" +
                                worksheet.Cells[row, 3].Value?.ToString().Trim());

                        }

                    }

                }

            };


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
            this.groupBox1.Size = new System.Drawing.Size(250, 632);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(244, 130);
            // 
            // bntPrint
            // 
            this.bntPrint.Location = new System.Drawing.Point(18, 68);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(176, 29);
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(86, 26);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 29);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(1328, 632);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1322, 610);
            // 
            // prnEng002WordLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "prnEng002WordLine";
            this.Size = new System.Drawing.Size(1578, 632);
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
            int yC = 180 , xC = 100;
            int w = 100, h = 35;
            List<string> wordA = new  List<string>();
            List<string> wordB = new  List<string>();
            List<string> _words = new List<string>();
            _words.AddRange( wordsAll);
            string word;
            /*List<int> ints_a = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7,8,9 };
            List<int> ints_b = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7,8,9 };*/
           
            for (int i = 1; i <= 10; i++)
            {
                int zz = RandomNumber.Randomnumber(0, _words.Count);
                word = _words[zz];
                var ww = word.Split('|');

                // int z = (ints_a.Count == 1) ? 0 : RandomNumber.Randomnumber(0, ints_a.Count-1);
                  wordA.Add( ww[0].ToUpper());
                 //ints_a.RemoveAt(z);
                // z = (ints_b.Count==1)?0:RandomNumber.Randomnumber(0, ints_b.Count - 1);
                     wordB.Add( ww[1]);
                // ints_b.RemoveAt(z);

                _words.RemoveAt(zz);

            }
          
            for (int i = 0; i < 10; i++)
            {

                int z = (wordA.Count == 1) ? 0 : RandomNumber.Randomnumber(0, wordA.Count );
                e.Graphics.DrawString(wordA[z], new Font("Angsana New", 22), new SolidBrush(Color.Black), xC + 5, yC + 5);
                wordA.RemoveAt(z);

                z = (wordB.Count == 1) ? 0 : RandomNumber.Randomnumber(0, wordB.Count );
                e.Graphics.DrawString(wordB[z], new Font("Angsana New", 22), new SolidBrush(Color.Black), xC + 350, yC + 5);
                wordB.RemoveAt(z);
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
