using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KidsLearning.Print
{
    public partial class prnControl : UserControl
    {
        public prnControl()
        {
            InitializeComponent();
        }
        #region Variables

       
        protected string ReportHeader;
        protected string ReportToppic;

        protected Font fontHeader = new Font("CordiaUPC", 18, FontStyle.Bold);
        protected Font fontDetail = new Font("CordiaUPC", 18);
        protected Font fontExpression = new Font("Microsoft Sans Serif", 18);

        public string filePrintPre = "";

        protected System.Drawing.StringFormat strFormat = new StringFormat()
        {
            Alignment = StringAlignment.Near,
            LineAlignment = StringAlignment.Center,
            Trimming = StringTrimming.EllipsisCharacter
        }; //Used to format the grid rows.

        protected int iPage = 1;
        protected int iPageAll = 10;
        protected bool bFirstPage = false; //Used to check whether we are printing first page
        protected bool bNewPage = false;// Used to check whether we are printing a new page
        //Whether more pages have to print or not
        protected bool bMorePagesToPrint = false;
      

        #endregion
        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bFirstPage = true;
            bNewPage = true;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
       internal void printDocumentNewPage(object sender, PrintPageEventArgs e)
        {
            // System.Windows.Forms.MessageBox.Show(_ReportHeader);
            //Draw Header
            //  string strToppic = "แปลงหน่วยนับ ต่อไปนี้ให้ถูกต้อง";
            e.Graphics.DrawString(ReportHeader, fontHeader, Brushes.Black, 300, e.MarginBounds.Top - e.Graphics.MeasureString(ReportHeader, fontHeader, e.MarginBounds.Width).Height - 13);
            e.Graphics.DrawString(ReportToppic, fontHeader, Brushes.Black, 100, 90);
            //Draw Footer
            e.Graphics.DrawString($"test date ...../...../.......  by.............................  Print date {DateTime.Now.ToString("yyyyMMdd hhmmss")} Page{iPage}/{iPageAll}", fontHeader, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Bottom + 40);

        }
        private void prnControl_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.printDocument1.DefaultPageSettings.Landscape = false;
          //  groupBox1.Width = 250;
        }

        private void bntPrint_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.DialogResult.OK == this.printDialog1.ShowDialog())
            {
                string filePre = Application.StartupPath +  filePrintPre;
               
               /* if ( File.Exists(filePre))
                {
                    if (MessageBox.Show("คุณต้องการสั่งปริ้น เนื้อหา/บทเรียน ด้วยหรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        TORServices.Drawings.PrintFile.Print(filePre);
                    }
                    
                }*/
                bNewPage = true;
                bMorePagesToPrint = true;

                iPageAll = int.Parse(this.txtPageCount.Text);
                iPage = 1;
                this.printDocument1.PrinterSettings.PrinterName = printDialog1.PrinterSettings.PrinterName;
                this.printDocument1.DocumentName = ReportHeader + string.Format("{0:yyyyMMdd hhmmss}", DateTime.Now);
                this.printDocument1.Print();
            }
        }
        


        private void printDocument1_EndPrint(object sender, PrintEventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }
    }
}
