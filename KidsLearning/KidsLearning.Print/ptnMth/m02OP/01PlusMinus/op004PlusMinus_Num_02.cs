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
using OfficeOpenXml.FormulaParsing.Excel.Functions.Database;

namespace KidsLearning.Print.ptnMth.m02OP
{
    public partial class op004PlusMinus_Num_02 : prnControl
    {
        public op004PlusMinus_Num_02()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);

        }

        #region Variables

        int minValue = 1, maxValue = 12;
        List<string> sOPs = new List<string>() { "++","--","+-","-+"};
        bool ramdomRect = false;
        #endregion
        private Classed.Controls.NumberSelect01 numberSelect1;
        private GroupBox groupBox3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;

        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "เติมคำตอบลงในช่องสี่เหลี่ยม ต่อไป นี้";
            iPage = 1;
            iPageAll = 1;

            printPreviewControl1.Document = this.printDocument1;
        }

        private void InitializeComponent()
        {
            this.numberSelect1 = new KidsLearning.Classed.Controls.NumberSelect01();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.numberSelect1);
            this.groupBox1.Size = new System.Drawing.Size(458, 648);
            this.groupBox1.Controls.SetChildIndex(this.numberSelect1, 0);
            this.groupBox1.Controls.SetChildIndex(this.groupBox3, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel2, 0);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 488);
            this.panel2.Size = new System.Drawing.Size(452, 119);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(458, 0);
            this.groupBox2.Size = new System.Drawing.Size(959, 648);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(953, 626);
            // 
            // numberSelect1
            // 
            this.numberSelect1.Dock = System.Windows.Forms.DockStyle.Top;
            this.numberSelect1.Location = new System.Drawing.Point(3, 19);
            this.numberSelect1.Name = "numberSelect1";
            this.numberSelect1.Size = new System.Drawing.Size(452, 313);
            this.numberSelect1.TabIndex = 2;
            this.numberSelect1.NumberSelectChanged += new System.EventHandler(this.numberSelect1_NumberSelectChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(3, 332);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(452, 156);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ตัวเลือก";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(15, 90);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(133, 35);
            this.radioButton1.TabIndex = 36;
            this.radioButton1.Text = "สุ่มคำตอบ";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.rd_4_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(15, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(130, 35);
            this.radioButton2.TabIndex = 34;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "หาคำตอบ";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.rd_4_CheckedChanged);
            // 
            // op004PlusMinus_Num_02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "op004PlusMinus_Num_02";
            this.Size = new System.Drawing.Size(1417, 648);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        private void rd_4_CheckedChanged(object sender, EventArgs e)
        {
            

            if (radioButton1.Checked)
            {
                ramdomRect = true;
            }
            else if (radioButton2.Checked)
            {
                ramdomRect = false;
            }
            printPreviewControl1.Document = this.printDocument1;
        }


        private void numberSelect1_NumberSelectChanged(object sender, EventArgs e)
        {
            minValue = Convert.ToInt32(numberSelect1.Minimum);
            maxValue = Convert.ToInt32(numberSelect1.Maximum);
            printPreviewControl1.Document = this.printDocument1;
        }

       

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail
            

            int yC = 100;
            int xC = 100;
            int w = 80, h = 40;
            Pen pen = new Pen(Color.Black, 3);
            SolidBrush solidBrush = new SolidBrush(Color.Black);

      
            yC = yC + 50;
            double anw = 0f;
      
            double _num1 = 0f, _num2 = 0f, _num3 = 0f;
            string op1 = "",op2 = "";
            for (int i = 1; i <= 10; i++)
            {

                
               

                int d1 = (numberSelect1.Decimal < 0) ? RandomNumber.Randomnumber(1, 5) : numberSelect1.Decimal;
                int d2 = (numberSelect1.Decimal < 0) ? RandomNumber.Randomnumber(1, 5) : numberSelect1.Decimal;
                int d3 = (numberSelect1.Decimal < 0) ? RandomNumber.Randomnumber(1, 5) : numberSelect1.Decimal;
                int d4 = Math.Max(d3,Math.Max(d1, d2));
                double num1 =  RandomNumber.Randomnumber(numberSelect1.Minimum, numberSelect1.Maximum, d1);
                double num2 =  RandomNumber.Randomnumber(numberSelect1.Minimum, numberSelect1.Maximum, d2);
                double num3 =  RandomNumber.Randomnumber(numberSelect1.Minimum, numberSelect1.Maximum, d2);


                switch (RandomNumber.Randomnumber(1, 4000))
                {
                    case int n when n > 3000:
                        op1 = "+";op2 = "+";
                        anw = num1 + num2 + num3;
                        break;
                    case int n when n  <= 3000 && n  > 2000:
                        op1 = "-"; op2 = "-";
                        anw = num1 - num2 - num3;
                        break;
                    case int n when n  <= 2000 && n > 1000:
                        op1 = "-"; op2 = "+";
                        anw = num1 - num2 + num3;
                        break;
                    case int n when n  <= 1000:
                        op1 = "+"; op2 = "-";
                        anw = num1 + num2 - num3;
                        break;

                }
                if (radioButton2.Checked)
                {
                    e.Graphics.DrawString(num1.ToString($"F{d1}"), fontDetail, solidBrush, xC, yC);
                    e.Graphics.DrawString(op1, fontDetail, solidBrush, xC + 80, yC);

                    e.Graphics.DrawString(num2.ToString($"F{d2}"), fontDetail, solidBrush, xC + 130, yC);
                    e.Graphics.DrawString(op2, fontDetail, solidBrush, xC + 220, yC);

                    e.Graphics.DrawString(num3.ToString($"F{d3}"), fontDetail, solidBrush, xC + 250, yC);
                    e.Graphics.DrawString(" = ", fontDetail, solidBrush, xC + 350, yC);

                    e.Graphics.DrawRectangle(new Pen(Color.Black, 3), xC + 400, yC - 5, 150, h);
                }
                else if (radioButton1.Checked)
                {
                    switch (RandomNumber.Randomnumber(1, 4000))
                    {
                        case int n when n  > 3000:
                            e.Graphics.DrawString(num1.ToString($"F{d1}"), fontDetail, solidBrush, xC, yC);
                            e.Graphics.DrawString(op1, fontDetail, solidBrush, xC + 80, yC);

                            e.Graphics.DrawString(num2.ToString($"F{d2}"), fontDetail, solidBrush, xC + 130, yC);
                            e.Graphics.DrawString(op2, fontDetail, solidBrush, xC + 220, yC);

                            e.Graphics.DrawString(num3.ToString($"F{d3}"), fontDetail, solidBrush, xC + 250, yC);
                            e.Graphics.DrawString(" = ", fontDetail, solidBrush, xC + 350, yC);

                            e.Graphics.DrawRectangle(new Pen(Color.Black, 3), xC + 400, yC - 5, 120, h);
                            break;
                        case int n when n  <= 3000 && n > 2000:
                            e.Graphics.DrawRectangle(new Pen(Color.Black, 3), xC-20 , yC - 5, 100, h);
                           // e.Graphics.DrawString(num1.ToString($"F{d1}"), fontDetail, solidBrush, xC, yC);
                            e.Graphics.DrawString(op1, fontDetail, solidBrush, xC + 80, yC);

                            e.Graphics.DrawString(num2.ToString($"F{d2}"), fontDetail, solidBrush, xC + 130, yC);
                            e.Graphics.DrawString(op2, fontDetail, solidBrush, xC + 220, yC);

                            e.Graphics.DrawString(num3.ToString($"F{d3}"), fontDetail, solidBrush, xC + 250, yC);
                            e.Graphics.DrawString(" = ", fontDetail, solidBrush, xC + 350, yC);

                            e.Graphics.DrawString(anw.ToString($"F{d4}"), fontDetail, solidBrush, xC + 400, yC);

                           
                            break;
                        case int n when n  <= 2000 && n  > 1000:
                            e.Graphics.DrawString(num1.ToString($"F{d1}"), fontDetail, solidBrush, xC, yC);
                            e.Graphics.DrawString(op1, fontDetail, solidBrush, xC + 80, yC);

                            e.Graphics.DrawRectangle(new Pen(Color.Black, 3), xC + 100, yC - 5, 110, h);
                           // e.Graphics.DrawString(num2.ToString($"F{d2}"), fontDetail, solidBrush, xC + 130, yC);
                            e.Graphics.DrawString(op2, fontDetail, solidBrush, xC + 220, yC);

                            e.Graphics.DrawString(num3.ToString($"F{d3}"), fontDetail, solidBrush, xC + 250, yC);
                            e.Graphics.DrawString(" = ", fontDetail, solidBrush, xC + 350, yC);

                            e.Graphics.DrawString(anw.ToString($"F{d4}"), fontDetail, solidBrush, xC + 400, yC);
                            break;
                        case int n when n  <= 1000:
                            e.Graphics.DrawString(num1.ToString($"F{d1}"), fontDetail, solidBrush, xC, yC);
                            e.Graphics.DrawString(op1, fontDetail, solidBrush, xC + 80, yC);

                            e.Graphics.DrawString(num2.ToString($"F{d2}"), fontDetail, solidBrush, xC + 130, yC);
                            e.Graphics.DrawString(op2, fontDetail, solidBrush, xC + 220, yC);

                            e.Graphics.DrawRectangle(new Pen(Color.Black, 3), xC + 240, yC - 5, 110, h);
                            //e.Graphics.DrawString(num3.ToString($"F{d3}"), fontDetail, solidBrush, xC + 250, yC);
                            e.Graphics.DrawString(" = ", fontDetail, solidBrush, xC + 350, yC);

                            e.Graphics.DrawString(anw.ToString($"F{d4}"), fontDetail, solidBrush, xC + 400, yC);
                            break;

                    }

                }

                

                

               
               
               

              
              

                yC = yC + 80;


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
