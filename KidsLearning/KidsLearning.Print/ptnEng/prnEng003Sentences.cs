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
    public partial class prnEng003Sentences : prnControl
    {
        public enum CountSentences { En2Th, Th2En, ThisThat, Verbtobe, Verbtohave, Verbtowant };
        public prnEng003Sentences()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);


        }

        #region Variables
        CountSentences countSentences = CountSentences.En2Th;
        int minValue = 1, maxValue = 15;
        private RadioButton rd_2;
        private RadioButton rd_1;
        private RadioButton rd_6;
        private RadioButton rd_5;
        private RadioButton rd_4;
        private RadioButton rd_3;
        private List<string> lstWord;
        private List<string> lstHaveHasN;
        private List<string> n_1 = new List<string>() { "I","You", "We","They","She", "He","It", "Mother", "Father", "Child", "Wife", "Daughter", "Son" ,
            "Brother", "Daddy","Granddaughter","Grandchild","Grandfather","Grandmother","Grandson","Sister","Baby"};

        private List<string> lstLike;
        private List<string> lstEat;
        private List<string> lstThatThis;
        private List<string> lstIsAmAre;
        private List<string> lstPlay;
        private List<string> lstHaveHas;
        private List<string> vLike = new List<string>() { "like", "see", "give", "need", "want" };
        private List<string> ttLike = new List<string>() { "This", "That", "These", "Those" };


        List<string> nth_1 = new List<string>() { "ฉัน","คุณ", "เรา","พวกเขา","เธอ", "เขา","มัน", "แม่",
            "พ่อ", "เด็กๆ", "ภรรยา", "สามี", "ลุกชาย" , "พี่ชาย", "น้องชาย", "คุณ ปู่","หลาน","คุณ ตา",
            "คุณ ยาย","คุณ ย่า","หลานชาย","พี่สาว","น้องสาวสาว"};

        List<string> lstLiketh;
        List<string> lstEatth;
        List<string> lstThatThisth;
        List<string> lstIsAmAreth;
        List<string> lstPlayth;
        List<string> lstHaveHasth;
        List<string> vLiketh = new List<string>() { "ชอบ", "เห็น", "ให้", "ต้องการ", "มี" };
        List<string> ttLiketh = new List<string>() { "นั่น", "นี่", "เหล่านี้", "เหล่านั้น" };


        List<string> lstAnimal;
        List<string> lstFood;

        List<string> lstOccupationO;
        List<string> lstOccupationN;
        #endregion



        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ การสะกดอ่านภาษาอังกฤษเบื้องต้น ";
            ReportToppic = "ฝึกเขียน และ อ่านคำศัพท์ต่อไปนี้";
            iPage = 1;
            iPageAll = 1;

            //get the first worksheet in the workbook
            lstLike = new List<string>();
            lstEat = new List<string>();
            lstThatThis = new List<string>();
            lstIsAmAre = new List<string>();
            lstPlay = new List<string>();
            lstHaveHas = new List<string>();

            //get the first worksheet in the workbook
            lstLiketh = new List<string>();
            lstEatth = new List<string>();
            lstThatThisth = new List<string>();
            lstIsAmAreth = new List<string>();
            lstPlayth = new List<string>();
            lstHaveHasth = new List<string>();

            lstFood = new List<string>();
            lstAnimal = new List<string>();

            lstOccupationN = new List<string>() { "I","You", "We","They","She", "He","It", "Mother", "Father",  "Wife", "Daughter",
            "Brother", "Daddy","Grandfather","Grandmother","Sister","This", "That"};

            lstHaveHasN = new List<string>() { "I", "We","They","She", "He","Mother", "Father", "Child", "Wife", "Daughter", "Son" ,
            "Brother", "Daddy","Granddaughter","Grandchild","Grandfather","Grandmother","Grandson","Sister","Baby"};

            lstOccupationO = new List<string>();

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
                            lstLike.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());
                            lstEat.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());
                            lstThatThis.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());
                            lstHaveHas.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());

                            lstFood.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());


                            lstLiketh.Add(worksheet.Cells[row, 3].Value?.ToString().Trim());
                            lstEatth.Add(worksheet.Cells[row, 3].Value?.ToString().Trim());
                            lstThatThisth.Add(worksheet.Cells[row, 3].Value?.ToString().Trim());
                            lstHaveHasth.Add(worksheet.Cells[row, 3].Value?.ToString().Trim());

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
                            lstLike.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());
                            lstThatThis.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());

                            lstLiketh.Add(worksheet.Cells[row, 3].Value?.ToString().Trim());
                            lstThatThisth.Add(worksheet.Cells[row, 3].Value?.ToString().Trim());
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
                            lstIsAmAre.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());
                            lstOccupationO.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());


                            lstIsAmAreth.Add(worksheet.Cells[row, 3].Value?.ToString().Trim());
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

                            lstLike.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());
                            lstEat.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());
                            lstThatThis.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());
                            lstHaveHas.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());
                            lstAnimal.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());

                            lstLiketh.Add(worksheet.Cells[row, 3].Value?.ToString().Trim());
                            lstEatth.Add(worksheet.Cells[row, 3].Value?.ToString().Trim());
                            lstThatThisth.Add(worksheet.Cells[row, 3].Value?.ToString().Trim());
                            lstHaveHasth.Add(worksheet.Cells[row, 3].Value?.ToString().Trim());
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
                            lstLike.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());
                            lstPlay.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());

                            lstLiketh.Add(worksheet.Cells[row, 3].Value?.ToString().Trim());
                            lstPlayth.Add(worksheet.Cells[row, 3].Value?.ToString().Trim());
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
                            lstLike.Add(worksheet.Cells[row, 1].Value?.ToString().Trim());


                            lstLiketh.Add(worksheet.Cells[row, 3].Value?.ToString().Trim());
                        }

                    }

                }

            };

            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            printPreviewControl1.Document = this.printDocument1;
        }
        private void rd_1_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_1.Checked)
            {
                countSentences = CountSentences.En2Th;
            }
            else if (rd_2.Checked)
            {
                countSentences = CountSentences.Th2En;
            }
            else if (rd_3.Checked)
            {
                ReportToppic = "เติม that/this ในช่องว่างให้ถูกต้อง"; ;
                countSentences = CountSentences.ThisThat;
            }
            else if (rd_4.Checked)
            {
                ReportToppic = "เติม is/am/are ในช่องว่างให้ถูกต้อง";
                countSentences = CountSentences.Verbtobe;
            }
            else if (rd_5.Checked)
            {
                ReportToppic = "เติม have/has ในช่องว่างให้ถูกต้อง";
                countSentences = CountSentences.Verbtohave;
            }
            else if (rd_6.Checked)
            {
                ReportToppic = "ฝึกเขียน และ อ่านคำศัพท์ต่อไปนี้";
                countSentences = CountSentences.Verbtowant;
            }

            printPreviewControl1.Document = this.printDocument1;
        }
        #region _InitializeComponent
        private void InitializeComponent()
        {
            this.rd_2 = new System.Windows.Forms.RadioButton();
            this.rd_1 = new System.Windows.Forms.RadioButton();
            this.rd_3 = new System.Windows.Forms.RadioButton();
            this.rd_4 = new System.Windows.Forms.RadioButton();
            this.rd_5 = new System.Windows.Forms.RadioButton();
            this.rd_6 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(412, 676);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rd_6);
            this.panel2.Controls.Add(this.rd_5);
            this.panel2.Controls.Add(this.rd_4);
            this.panel2.Controls.Add(this.rd_3);
            this.panel2.Controls.Add(this.rd_2);
            this.panel2.Controls.Add(this.rd_1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            this.panel2.Size = new System.Drawing.Size(406, 556);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            this.panel2.Controls.SetChildIndex(this.txtPageCount, 0);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.bntPrint, 0);
            this.panel2.Controls.SetChildIndex(this.rd_1, 0);
            this.panel2.Controls.SetChildIndex(this.rd_2, 0);
            this.panel2.Controls.SetChildIndex(this.rd_3, 0);
            this.panel2.Controls.SetChildIndex(this.rd_4, 0);
            this.panel2.Controls.SetChildIndex(this.rd_5, 0);
            this.panel2.Controls.SetChildIndex(this.rd_6, 0);
            // 
            // bntPrint
            // 
            this.bntPrint.Location = new System.Drawing.Point(11, 493);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(169, 454);
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(79, 451);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 454);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(412, 0);
            this.groupBox2.Size = new System.Drawing.Size(878, 676);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(872, 654);
            // 
            // rd_2
            // 
            this.rd_2.AutoSize = true;
            this.rd_2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_2.Location = new System.Drawing.Point(16, 60);
            this.rd_2.Name = "rd_2";
            this.rd_2.Size = new System.Drawing.Size(216, 36);
            this.rd_2.TabIndex = 18;
            this.rd_2.Text = "ชุดประโยคภาษาไทย";
            this.rd_2.UseVisualStyleBackColor = true;
            this.rd_2.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_1
            // 
            this.rd_1.AutoSize = true;
            this.rd_1.Checked = true;
            this.rd_1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_1.Location = new System.Drawing.Point(16, 18);
            this.rd_1.Name = "rd_1";
            this.rd_1.Size = new System.Drawing.Size(243, 36);
            this.rd_1.TabIndex = 17;
            this.rd_1.TabStop = true;
            this.rd_1.Text = "ชุดประโยคภาษาอังกฤษ";
            this.rd_1.UseVisualStyleBackColor = true;
            this.rd_1.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_3
            // 
            this.rd_3.AutoSize = true;
            this.rd_3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_3.Location = new System.Drawing.Point(16, 102);
            this.rd_3.Name = "rd_3";
            this.rd_3.Size = new System.Drawing.Size(226, 36);
            this.rd_3.TabIndex = 19;
            this.rd_3.Text = "ชุดประโยค ThisThat";
            this.rd_3.UseVisualStyleBackColor = true;
            this.rd_3.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_4
            // 
            this.rd_4.AutoSize = true;
            this.rd_4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_4.Location = new System.Drawing.Point(16, 144);
            this.rd_4.Name = "rd_4";
            this.rd_4.Size = new System.Drawing.Size(247, 36);
            this.rd_4.TabIndex = 20;
            this.rd_4.Text = "ชุดประโยค Verb to be";
            this.rd_4.UseVisualStyleBackColor = true;
            this.rd_4.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_5
            // 
            this.rd_5.AutoSize = true;
            this.rd_5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_5.Location = new System.Drawing.Point(16, 186);
            this.rd_5.Name = "rd_5";
            this.rd_5.Size = new System.Drawing.Size(271, 36);
            this.rd_5.TabIndex = 21;
            this.rd_5.Text = "ชุดประโยค Verb to have";
            this.rd_5.UseVisualStyleBackColor = true;
            this.rd_5.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // rd_6
            // 
            this.rd_6.AutoSize = true;
            this.rd_6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_6.Location = new System.Drawing.Point(16, 228);
            this.rd_6.Name = "rd_6";
            this.rd_6.Size = new System.Drawing.Size(271, 36);
            this.rd_6.TabIndex = 22;
            this.rd_6.Text = "ชุดประโยค Verb to want";
            this.rd_6.UseVisualStyleBackColor = true;
            this.rd_6.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);
            // 
            // prnEng003Sentences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "prnEng003Sentences";
            this.Size = new System.Drawing.Size(1290, 676);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail


            int yC = 150, xC = 100;
            int w = 100, h = 35;

            int count = 14;
            // DrawTable
            int rr;
            string s = "";
            if (countSentences == CountSentences.En2Th)
            {
                for (int ip = 0; ip < 7; ip++)
                {
                    xC = 100;
                    rr = RandomNumber.Randomnumber(0, 5);

                    //live at

                    if (rr == 0)//  ...........  Like/give/need/see/want ...........
                    {
                        s = n_1[RandomNumber.Randomnumber(0, n_1.Count)] + "    " + vLike[RandomNumber.Randomnumber(0, vLike.Count )] + 
                            "      " + lstLike[RandomNumber.Randomnumber(0, lstLike.Count )];
                    }
                    else if (rr == 1)//  ...........  eat ...........
                    {
                        s = n_1[RandomNumber.Randomnumber(0, n_1.Count)] + "    eat      " 
                            + lstEat[RandomNumber.Randomnumber(0, lstEat.Count )];
                    }
                    else if (rr == 2)//............ is/am/are ...............
                    {
                        string ss = n_1[RandomNumber.Randomnumber(0, n_1.Count)];

                        if (ss == "I")
                        {
                            s = ss + "   am     " + lstIsAmAre[RandomNumber.Randomnumber(0, lstIsAmAre.Count)];
                        }
                        else if (ss == "We" || ss == "They")
                        {
                            s = ss + "   are     " + lstIsAmAre[RandomNumber.Randomnumber(0, lstIsAmAre.Count)];
                        }
                        else
                        {
                            s = ss + "    is      " + lstIsAmAre[RandomNumber.Randomnumber(0, lstIsAmAre.Count )];
                        }

                    }
                    else if (rr == 3) // that/this/These / Those is ................
                    {

                        s = ttLike[RandomNumber.Randomnumber(0, ttLike.Count )] + 
                            "    is      " + lstEat[RandomNumber.Randomnumber(0, lstEat.Count )];

                    }
                    else if (rr == 4)  //have has
                    {
                        string ss = n_1[RandomNumber.Randomnumber(0, n_1.Count )];
                        if (ss == "I" || ss == "You" || ss == "We" || ss == "They")
                        {
                            s = n_1[RandomNumber.Randomnumber(0, n_1.Count )] + "    have      " 
                                + lstHaveHas[RandomNumber.Randomnumber(0, lstHaveHas.Count )];
                        }
                        else
                        {
                            s = n_1[RandomNumber.Randomnumber(0, n_1.Count )] + "    has      " 
                                + lstHaveHas[RandomNumber.Randomnumber(0, lstHaveHas.Count )];
                        }

                    }
                    else if (rr == 5)  //play
                    {
                        s = n_1[RandomNumber.Randomnumber(0, n_1.Count )] + "  play     " 
                            + lstPlay[RandomNumber.Randomnumber(0, lstPlay.Count )];

                    }
                    e.Graphics.DrawString(" ประโยค ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 8);
                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 20, yC + 8, 80, h));
                    e.Graphics.DrawString("   " + s, fontDetail, new SolidBrush(Color.Black), xC + 100, yC + 8);
                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 100, yC + 8, 400, h));

                    yC += h;
                    e.Graphics.DrawString(" คำอ่าน ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 8);
                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 20, yC + 8, 80, h));
                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 100, yC + 8, 400, h));
                    yC += h;
                    e.Graphics.DrawString(" คำแปล ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 8);
                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 20, yC + 8, 80, h));
                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 100, yC + 8, 400, h));

                    yC += h + 15;
                }
            }
            else if (countSentences == CountSentences.Th2En)
            {
                for (int ip = 0; ip < 8; ip++)
                {
                    xC = 100;
                    rr = RandomNumber.Randomnumber(0, 5);

                    //live at

                    if (rr == 0)//  ...........  Like/give/need/see/want ...........
                    {
                        s = nth_1[RandomNumber.Randomnumber(0, nth_1.Count )] + "    " +
                            vLiketh[RandomNumber.Randomnumber(0, vLiketh.Count )] + "      " +
                            lstLiketh[RandomNumber.Randomnumber(0, lstLiketh.Count )];
                    }
                    else if (rr == 1)//  ...........  eat ...........
                    {
                        s = nth_1[RandomNumber.Randomnumber(0, nth_1.Count )] + " กิน " +
                            lstEatth[RandomNumber.Randomnumber(0, lstEatth.Count )];
                    }
                    else if (rr == 2)//............ is/am/are ...............
                    {
                        string ss = nth_1[RandomNumber.Randomnumber(0, nth_1.Count )];
                        s = ss + " คือ " + lstIsAmAreth[RandomNumber.Randomnumber(0, lstIsAmAreth.Count )];


                    }
                    else if (rr == 3) // that/this/These / Those is ................
                    {

                        s = ttLiketh[RandomNumber.Randomnumber(0, ttLiketh.Count )] + " คือ " +
                            lstEatth[RandomNumber.Randomnumber(0, lstEatth.Count )];

                    }
                    else if (rr == 4)  //have has
                    {
                        string ss = nth_1[RandomNumber.Randomnumber(0, nth_1.Count )];

                        s = nth_1[RandomNumber.Randomnumber(0, nth_1.Count )] + " มี  " +
                            lstHaveHasth[RandomNumber.Randomnumber(0, lstHaveHasth.Count )];


                    }
                    else if (rr == 5)  //play
                    {
                        s = nth_1[RandomNumber.Randomnumber(0, nth_1.Count )] + " เล่น " +
                            lstPlayth[RandomNumber.Randomnumber(0, lstPlayth.Count )];

                    }
                    e.Graphics.DrawString(" ประโยคไทย ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 8);
                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 20, yC + 8, 130, h));
                    e.Graphics.DrawString("   " + s, fontDetail, new SolidBrush(Color.Black), xC + 150, yC + 8);
                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 150, yC + 8, 400, h));

                    yC += h;
                    e.Graphics.DrawString(" ประโยคอังกฤษ ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 8);
                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 20, yC + 8, 130, h));
                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 150, yC + 8, 400, h));

                    yC += h + 15;
                }
            }
            else if (countSentences == CountSentences.ThisThat)
            {
                for (int ip = 0; ip < 8; ip++)
                {
                    xC = 100;
                    rr = RandomNumber.Randomnumber(0, 2000);

                    s = "................   is   " + lstThatThis[RandomNumber.Randomnumber(0, lstThatThis.Count )];

                    e.Graphics.DrawString(" ประโยค ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 8);
                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 20, yC + 8, 80, h));
                    e.Graphics.DrawString("   " + s, fontDetail, new SolidBrush(Color.Black), xC + 100, yC + 15);
                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 100, yC + 8, 200, h));

                    if (rr < 1000)
                    {
                        e.Graphics.DrawImage(TORServices.Drawings.exImage.ResizeImage(System.Windows.Forms.Application.StartupPath + @"\File\PIC\Eng_Basic\App\that.png", 280, 60), xC + 320, yC - 5);
                    }
                    else
                    {
                        e.Graphics.DrawImage(TORServices.Drawings.exImage.ResizeImage(System.Windows.Forms.Application.StartupPath + @"\File\PIC\Eng_Basic\App\this.png", 280, 60), xC + 320, yC - 5);
                    }
                    /*   yC += 25;
                       e.Graphics.DrawString(" คำอ่าน ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5);
                       e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 20, yC + 8, 80, 25));
                       e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 100, yC + 8, 400, 25));*/

                    yC += h;
                    e.Graphics.DrawString(" คำแปล ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 8);
                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 20, yC + 8, 80, h));
                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 100, yC + 8, 200, h));


                    yC += 80;
                }
            }
            else if (countSentences == CountSentences.Verbtobe)
            {
                for (int ip = 0; ip < 8; ip++)
                {
                    xC = 100;
                    rr = RandomNumber.Randomnumber(0, 3000);

                    if (rr < 1000)//Animal
                    {
                        s = lstAnimal[RandomNumber.Randomnumber(0, lstAnimal.Count )] + " ............. animal";

                    }
                    else if (rr >= 1000 && rr < 2000)//Food
                    {
                        s = lstFood[RandomNumber.Randomnumber(0, lstAnimal.Count )] + " ............. food";
                    }
                    else //Occupation
                    {
                        s = lstOccupationN[RandomNumber.Randomnumber(0, lstOccupationN.Count )] + 
                            " ............. " + lstOccupationO[RandomNumber.Randomnumber(0, lstOccupationO.Count )];
                    }


                    e.Graphics.DrawString(" ประโยค ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 8);
                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 20, yC + 8, 80, h));
                    e.Graphics.DrawString("   " + s, fontDetail, new SolidBrush(Color.Black), xC + 100, yC + 15);
                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 100, yC + 8, 400, h));

                    /*   yC += 25;
                       e.Graphics.DrawString(" คำอ่าน ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5);
                       e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 20, yC + 8, 80, 25));
                       e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 100, yC + 8, 400, 25));*/
                    yC += h;
                    e.Graphics.DrawString(" คำแปล ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 8);
                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 20, yC + 8, 80, h));
                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 100, yC + 8, 400, h));

                    yC += h + 15;
                    //  System.Threading.Thread.Sleep(1000);
                }
            }
            else if (countSentences == CountSentences.Verbtohave)
            {
                for (int ip = 0; ip < 8; ip++)
                {
                    xC = 100;
                    rr = RandomNumber.Randomnumber(0, 5);
                    s = lstHaveHasN[RandomNumber.Randomnumber(0, lstHaveHasN.Count )] + "  .............    " 
                        + lstHaveHas[RandomNumber.Randomnumber(0, lstHaveHas.Count )];

                    e.Graphics.DrawString(" ประโยค ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5);
                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 20, yC + 8, 80, h));
                    e.Graphics.DrawString("   " + s, fontDetail, new SolidBrush(Color.Black), xC + 100, yC + 8);
                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 100, yC + 8, 400, h));

                    /*  yC += 25;
                      e.Graphics.DrawString(" คำอ่าน ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5);
                      e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 20, yC + 8, 80, 25));
                      e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 100, yC + 8, 400, 25));*/
                    yC += h;
                    e.Graphics.DrawString(" คำแปล ", fontDetail, new SolidBrush(Color.Black), xC + 20, yC + 5);
                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 20, yC + 8, 80, h));
                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(xC + 100, yC + 8, 400, h));

                    yC += 60;
                }

            }
            else if (countSentences == CountSentences.Verbtowant)
            {

            }


            yC += h; xC = 100;


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
