using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KidsLearning.Print.ptnEng
{
    public partial class prnPrintWord_ : UserControl
    {
        public prnPrintWord_()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
        }
        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bFirstPage = true;
            bNewPage = true;
        }

        internal void printDocumentNewPage(object sender, PrintPageEventArgs e)
        {
            // System.Windows.Forms.MessageBox.Show(_ReportHeader);
            //Draw Header
            //  string strToppic = "แปลงหน่วยนับ ต่อไปนี้ให้ถูกต้อง";
            e.Graphics.DrawString(ReportHeader, fontHeader, Brushes.Black, 300, e.MarginBounds.Top - e.Graphics.MeasureString(ReportHeader, fontHeader, e.MarginBounds.Width).Height - 13);
            e.Graphics.DrawString(ReportToppic, fontHeader, Brushes.Black, 100, 90);
            //Draw Footer
            e.Graphics.DrawString("", fontHeader, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Bottom + 40);

        }
        int i_c = 0;
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail


            int yC = 120, xC = 60;
            int w = 100, h = 35;
            // Create pen.
            Pen blackPen = new Pen(Color.Black, 2);
            for (int i = 1; i <= 3; i++)
            { e.Graphics.DrawLine(blackPen, xC, yC, xC, yC + 900); xC += 200; }
            xC += 120;
            e.Graphics.DrawLine(blackPen, xC, yC, xC, yC + 900);
            yC = 120; xC = 60;
            for (int i = 0; i <= 26; i++)
            { e.Graphics.DrawLine(blackPen, xC, yC, xC + 720, yC); yC += 35; }
            yC = 120; xC = 60;

            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.LineAlignment = StringAlignment.Center;
            drawFormat.Alignment = StringAlignment.Center;

            // Draw string to screen.

            e.Graphics.DrawString("คำศัพท์", new Font("Angsana New", 22), new SolidBrush(Color.Black), new RectangleF(xC + 5, yC, 200, 35), drawFormat);
            e.Graphics.DrawString("คำอ่าน", new Font("Angsana New", 22), new SolidBrush(Color.Black), new RectangleF(xC + 205, yC, 200, 35), drawFormat);
            e.Graphics.DrawString("คำแปล", new Font("Angsana New", 22), new SolidBrush(Color.Black), new RectangleF(xC + 405, yC, 320, 35), drawFormat);

            yC += 35;
            for (int i = 1; i <= 25; i++)
            {
                if (i_c < dataGridView1.Rows.Count - 1)
                {

                    e.Graphics.DrawString(dataGridView1[0,i_c].Value.ToString(), new Font("Angsana New", 22), new SolidBrush(Color.Black), xC + 5, yC - 5);
                    e.Graphics.DrawString(dataGridView1[1, i_c].Value.ToString(), new Font("Angsana New", 22), new SolidBrush(Color.Black), xC + 205, yC - 5);
                    e.Graphics.DrawString(dataGridView1[2, i_c].Value.ToString(), new Font("Angsana New", 22), new SolidBrush(Color.Black), xC + 405, yC - 5);
                    yC += 35;
                    i_c++;
                }



            }



            #endregion


            // System.Windows.Forms.MessageBox.Show(i_c + "\n"+ wordsAll.Count.ToString());

            if (i_c >= dataGridView1.Rows.Count - 1)
            {
                bNewPage = false;
                bMorePagesToPrint = false;
            }

            if (bNewPage)
            {
                printDocumentNewPage(sender, e);
            }



            //If more lines exist, print another page.
            e.HasMorePages = (bMorePagesToPrint) ? true : false;
        }
        #region Variables


        private string ReportHeader;
        private string ReportToppic;

        private Font fontHeader = new Font("Angsana New", 18, FontStyle.Bold);
        private Font fontDetail = new Font("Angsana New", 18);


        private System.Drawing.StringFormat strFormat = new StringFormat()
        {
            Alignment = StringAlignment.Near,
            LineAlignment = StringAlignment.Center,
            Trimming = StringTrimming.EllipsisCharacter
        }; //Used to format the grid rows.

        private int iPage = 1;
        private int iPageAll = 10;
        private bool bFirstPage = false; //Used to check whether we are printing first page
        private bool bNewPage = false;// Used to check whether we are printing a new page
        //Whether more pages have to print or not
        private bool bMorePagesToPrint = false;
       

        #endregion
        private void prnPrintWord__Load(object sender, EventArgs e)
        {
            ReportHeader = "คำศัพท์";
         DataTable   dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Eng");
            dt.Columns.Add("Read");
            dt.Columns.Add("Th");



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


                            DataRow r = dt.NewRow();
                            r["Eng"] = worksheet.Cells[row, 1].Value?.ToString().Trim();
                            r["Read"] = worksheet.Cells[row, 2].Value?.ToString().Trim();
                            r["Th"] = worksheet.Cells[row, 3].Value?.ToString().Trim();
                            dt.Rows.Add(r);

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
                            DataRow r = dt.NewRow();
                            r["Eng"] = worksheet.Cells[row, 1].Value?.ToString().Trim();
                            r["Read"] = worksheet.Cells[row, 2].Value?.ToString().Trim();
                            r["Th"] = worksheet.Cells[row, 3].Value?.ToString().Trim();
                            dt.Rows.Add(r);

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
                            DataRow r = dt.NewRow();
                            r["Eng"] = worksheet.Cells[row, 1].Value?.ToString().Trim();
                            r["Read"] = worksheet.Cells[row, 2].Value?.ToString().Trim();
                            r["Th"] = worksheet.Cells[row, 3].Value?.ToString().Trim();
                            dt.Rows.Add(r);

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

                            DataRow r = dt.NewRow();
                            r["Eng"] = worksheet.Cells[row, 1].Value?.ToString().Trim();
                            r["Read"] = worksheet.Cells[row, 2].Value?.ToString().Trim();
                            r["Th"] = worksheet.Cells[row, 3].Value?.ToString().Trim();
                            dt.Rows.Add(r);

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
                            DataRow r = dt.NewRow();
                            r["Eng"] = worksheet.Cells[row, 1].Value?.ToString().Trim();
                            r["Read"] = worksheet.Cells[row, 2].Value?.ToString().Trim();
                            r["Th"] = worksheet.Cells[row, 3].Value?.ToString().Trim();
                            dt.Rows.Add(r);

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
                            DataRow r = dt.NewRow();
                            r["Eng"] = worksheet.Cells[row, 1].Value?.ToString().Trim();
                            r["Read"] = worksheet.Cells[row, 2].Value?.ToString().Trim();
                            r["Th"] = worksheet.Cells[row, 3].Value?.ToString().Trim();
                            dt.Rows.Add(r);

                        }

                    }

                }

            };
           
            dataGridView1.DataSource = dt;
            dataGridView1.Sort(dataGridView1.Columns[0] ,ListSortDirection.Ascending);
            dataGridView1.Columns[0].Width = 220;
            dataGridView1.Columns[1].Width = 220;
            dataGridView1.Columns[2].Width = 500;
        }

        private void bntPrint_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.DialogResult.OK == this.printDialog1.ShowDialog())
            {
                bNewPage = true;
                bMorePagesToPrint = true;

                iPageAll = dataGridView1.RowCount/25;
                iPage = 1;
                this.printDocument1.DocumentName = ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                this.printDocument1.Print();
            }
        }
    }
}
