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

namespace KidsLearning.Print.ptnEng
{
  public partial  class prnEng001CompareTh_En : prnControl
    {
        public prnEng001CompareTh_En()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
        
        }

        #region Variables
        /* List<string> lst_1 = new List<string>() { "b=บ", "bl=บล", "br=บร", "c=ค", "ch=ช", "cl=คล", "cr=คร", "d=ด", "dr=ดร", "f=ฟ", "fl=ฟล", "fr=ฟร", "g=ก", "gh=ก", "gl=กล", "gr=กร", "h=ฮ", "j=จ", "k=ค/ก", "kl=คล/กล", "kn=น", "kr=คร/กร", "l=ล", "m=ม", "n=น", "p=พ", "ph=ฟ", "pl=พล", "pr=พร", "q=คว", "r=ร", "s=ซ/ส", "sc=สค/ส", "sch=สค/ช", "scr=สคร", "sh=ช", "sk=สค", "sl=สล", "sm=สม", "sn=สน", "sp=สพ", "spl=สพล", "spr=สพร", "sq=สคว", "st=สท", "str=สทร", "sw=สว", "t=ท/ต", "th=ด/ตซ", "tr=ทร", "v=วฟ", "w=ว", "wh=ฮ/ว", "wr=ร", "x=ซ", "y=ย", "z=ส", "ng=ง" };
         List<string> lst_2 = new List<string>() { "a=แอะ,แอ,อะ,อา", "ai=ไอ", "au=เอา", "ao=เอา", "ar=อาร์/ออร์", "al=อาล์/ออล์", "a-e=เอ", "au=ออ", "aw = ออa", "y=เอย์", "e=เอะ / อี", "ea=อี/เอ", "ear=เอีย/แอ", "ee=อี", "ew=อิว", "ey=อี/เอ", "er=เออร์", "ere=เอีย/แอ", "i = อิ", "ia = เอีย", "ir=เออ", "i-e=ไอ", "o = โอ/เอาะ/อัน", "oo = อู", "oa=โอ", "oi=ออย", "or=เออ/ออ", "oor=ออ/อัว", "ou=เอา/อู", "ow =เอา/โอ", "oy = ออย", "o-e = โอ/อัน", "u=อุ/อัua=อัว", "ur = เออร์", "uy = ไอ", "y=ไอ/อี", "ye=ไอ", "u-e=ยู/อู", "ue=อู" };
         List<string> lst_3 = new List<string>() { "b=บ", "bt=บท์", "c=ค", "ch=ช", "ck=ค", "ct=คท์", "d=ด", "dge=ดจ์", "f=ฟ", "ff=ฟ", "ft=ฟท์", "g=ก", "ge=จ", "ght=ท", "k=ค", "l=ล", "ll=ลล์", "ld=ลด์", "lf=ลฟ์", "lt=ลท์", "mpt=มพท์", "m=ม", "mb=มบ์", "mf=มฟ์", "mp=มพ์", "n=น", "nd=นด์", "ng=ง", "nx,nk=งค์", "nce=นส์", "nse=นส์", "nt=นท์", "nz=นส์", "p=พ", "pf=พฟ์", "ph=ฟ", "pt=มท์", "q=ค", "que=ค", "pth=พตซ์", "s=ซ/ส", "sk=สค์", "sp=สพ", "s=ส", "st=สท์", "t=ท", "th=ตซ", "the=ด", "v=ฟ", "ve=ฟ", "w=ว", "x=กซ์", "xt=คซท์", "y=ย", "ye=ย", "z=ส" };
         List<string> wordsAll;*/
        List<string> wordsAll;
        List<string> words;

        #endregion
        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ การสะกดอ่านภาษาอังกฤษเบื้องต้น ";
            ReportToppic = "เปรียบเทียบ พยัญชนะ สระ  ต่อไปนี้";
            iPage = 1;
            iPageAll = 1;
            words = new List<string>();

            wordsAll = new List<string>();
            wordsAll.AddRange(Eng_Word.lst_EngSymbol);
            wordsAll.AddRange(Eng_Word.lst_EngVowel);
            wordsAll.AddRange(Eng_Word.lst_EngSpelling);

            List<Task> tasks = new List<Task>();

            for (int i = 0; i <= iPageAll + 1; i++)
            {
                tasks.Add(Task.Factory.StartNew(() =>
                {
                    for (int p = 0; p <= 25; p++)
                    {
                        words.Add(Eng_Word.GetWord(wordsAll));
                    }
                }));
            }
            Task.WaitAll(tasks.ToArray());
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
            this.groupBox1.Size = new System.Drawing.Size(250, 707);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(1276, 707);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1270, 685);
            // 
            // prnEng001CompareTh_En
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "prnEng001CompareTh_En";
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


            int yC =200;
            int xC = 180;
            int w = 120, h = 50;

            Pen pen = new Pen(Color.Black, 2);
            SolidBrush solidBrush = new SolidBrush(Color.White);
            e.Graphics.DrawRectangleString("อักษร อังกฤษ", fontDetail, pen, new Rectangle(xC, yC, w, h));
            e.Graphics.DrawRectangleString("อักษร/สระ ไทย", fontDetail, pen, new Rectangle(xC + w, yC, w, h));
            e.Graphics.DrawRectangleString("อักษร อังกฤษ", fontDetail, pen, new Rectangle(xC + 3 * w, yC, w, h));
            e.Graphics.DrawRectangleString("อักษร/สระ ไทย", fontDetail, pen, new Rectangle(xC + 4 * w, yC, w, h));


            yC += h;
            for (int i = 0; i < 10; i++)
            {

                e.Graphics.DrawRectangleString(Eng_Word.GetWord(wordsAll), fontDetail, pen, new Rectangle(xC, yC, w, h));
                e.Graphics.DrawRectangleString("  ", fontDetail, pen, new Rectangle(xC + w, yC, w, h));
                //  ic++;
                  e.Graphics.DrawRectangleString(Eng_Word.GetWord(wordsAll), fontDetail, pen, new Rectangle(xC + 3 * w, yC, w, h));
                  e.Graphics.DrawRectangleString("  ", fontDetail, pen, new Rectangle(xC + 4 * w, yC, w, h));
                //  ic++;

                yC += h;
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
