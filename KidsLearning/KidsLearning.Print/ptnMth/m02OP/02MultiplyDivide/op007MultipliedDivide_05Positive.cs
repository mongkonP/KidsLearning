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
using TORServices.Systems;

namespace KidsLearning.Print.ptnMth
{
  public partial  class op007MultipliedDivide_05Positive : prnControl
    {
        public op007MultipliedDivide_05Positive()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
        
        }

        #region Variables

        int minValue = 1, maxValue = 15;
        private GroupBox groupBox3;
        private RadioButton rd_2;
        private RadioButton rd_1;
        private RadioButton rd_3;
        string strOperation = "+";

        #endregion

        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "การตั้งคูณ";
            iPage = 1;
            iPageAll = 1;
            
            printPreviewControl1.Document = this.printDocument1;
        }

        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rd_2 = new System.Windows.Forms.RadioButton();
            this.rd_1 = new System.Windows.Forms.RadioButton();
            this.rd_3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Size = new System.Drawing.Size(273, 714);
            this.groupBox1.Controls.SetChildIndex(this.groupBox3, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel2, 0);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 227);
            this.panel2.Size = new System.Drawing.Size(267, 135);
            // 
            // bntPrint
            // 
            this.bntPrint.Location = new System.Drawing.Point(5, 54);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(163, 15);
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(73, 12);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 15);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(273, 0);
            this.groupBox2.Size = new System.Drawing.Size(930, 714);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(924, 692);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rd_2);
            this.groupBox3.Controls.Add(this.rd_1);
            this.groupBox3.Controls.Add(this.rd_3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(3, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 208);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ช่วงตัวเลข";
            // 
            // rd_2
            // 
            this.rd_2.AutoSize = true;
            this.rd_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_2.Location = new System.Drawing.Point(15, 80);
            this.rd_2.Name = "rd_2";
            this.rd_2.Size = new System.Drawing.Size(210, 35);
            this.rd_2.TabIndex = 33;
            this.rd_2.Text = "ตัวคูณ 2 ตำแหน่ง";
            this.rd_2.UseVisualStyleBackColor = true;
            this.rd_2.CheckedChanged += new System.EventHandler(this.rd_4_CheckedChanged);
            // 
            // rd_1
            // 
            this.rd_1.AutoSize = true;
            this.rd_1.Checked = true;
            this.rd_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_1.Location = new System.Drawing.Point(15, 38);
            this.rd_1.Name = "rd_1";
            this.rd_1.Size = new System.Drawing.Size(210, 35);
            this.rd_1.TabIndex = 31;
            this.rd_1.TabStop = true;
            this.rd_1.Text = "ตัวคูณ 1 ตำแหน่ง";
            this.rd_1.UseVisualStyleBackColor = true;
            this.rd_1.CheckedChanged += new System.EventHandler(this.rd_4_CheckedChanged);
            // 
            // rd_3
            // 
            this.rd_3.AutoSize = true;
            this.rd_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_3.Location = new System.Drawing.Point(15, 121);
            this.rd_3.Name = "rd_3";
            this.rd_3.Size = new System.Drawing.Size(210, 35);
            this.rd_3.TabIndex = 32;
            this.rd_3.Text = "ตัวคูณ 3 ตำแหน่ง";
            this.rd_3.UseVisualStyleBackColor = true;
            this.rd_3.CheckedChanged += new System.EventHandler(this.rd_4_CheckedChanged);
            // 
            // op007MultipliedDivide_05Positive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "op007MultipliedDivide_05Positive";
            this.Size = new System.Drawing.Size(1203, 714);
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
            /*if (rd_1.Checked)
            {
                minValue = 2;maxValue = 9;


            }
            else if (rd_2.Checked)
            {
                minValue = 10; maxValue = 99;

            }
            else if (rd_3.Checked)
            {
                minValue = 100; maxValue = 999;
            }*/
            printPreviewControl1.Document = this.printDocument1;

        }
        Font font = new Font("Angsana New", 22);
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail

            List<int> Nums = new List<int>();
            int yC = 100;
            int xC = 100;
            int w = 180, h = 40;
            Pen pen = new Pen(Color.Black, 2);
            SolidBrush solidBrush = new SolidBrush(Color.White);

            xC = 80;

            int a = 1, b = 1;
            for (int i = 1; i <= 3; i ++)
            {

                for (int z = 0; z <= 1; z++)
                {
                    if (rd_1.Checked)
                    {
                        a = RandomNumber.Randomnumber(2, 50);
                        b = RandomNumber.Randomnumber(1, 9);


                    }
                    else if (rd_2.Checked)
                    {
                        a = RandomNumber.Randomnumber(10, 1000);
                        b = RandomNumber.Randomnumber(10, 99);

                    }
                    else if (rd_3.Checked)
                    {
                        a = RandomNumber.Randomnumber(100, 1000);
                        b = RandomNumber.Randomnumber(100, 999);
                    }

                    string _a = TextStringExtension.SpacedString(Math.Max( a,b).ToString());
                    string _b = TextStringExtension.SpacedString(Math.Min(a, b).ToString());
                    StringFormat stringFormat = new StringFormat() { Alignment = StringAlignment.Far };

                    e.Graphics.DrawString(_a, font, new SolidBrush(Color.Black), new Rectangle(xC + 50, yC, w, h), stringFormat);
                    e.Graphics.DrawString(" x ", font, new SolidBrush(Color.Black), xC + 55 + w, yC + 10);
                    e.Graphics.DrawLine(new Pen(Color.Black, 2), xC + 50, yC + h , xC + w + 50, yC + h );
                    e.Graphics.DrawString(_b, font, new SolidBrush(Color.Black), new Rectangle(xC + 50, yC + h + 5, w, h), stringFormat);
                    e.Graphics.DrawLine(new Pen(Color.Black, 2), xC + 50, yC + 2 * h , xC + w + 50, yC + 2 * h );
                    e.Graphics.DrawLine(new Pen(Color.Black, 2), xC + 50, yC + 3 * h , xC + w + 50, yC + 3 * h );
                    
                    if (rd_1.Checked)
                    {
                        e.Graphics.DrawLine(new Pen(Color.Black, 2), xC + 50, yC + 3 * h + 8, xC + w + 50, yC + 3 * h + 8);

                    }
                    else if (rd_2.Checked)
                    {
                        e.Graphics.DrawString("0", font, new SolidBrush(Color.Black), new Rectangle(xC + 50, yC + 3 * h, w, h), stringFormat);
                        e.Graphics.DrawLine(new Pen(Color.Black, 2), xC + 50, yC + 4 * h, xC + w + 50, yC + 4 * h);
                       
                        e.Graphics.DrawLine(new Pen(Color.Black, 2), xC + 50, yC + 5 * h, xC + w + 50, yC + 5 * h);
                        e.Graphics.DrawLine(new Pen(Color.Black, 2), xC + 50, yC + 5 * h + 8, xC + w + 50, yC + 5 * h + 8);

                    }
                    else if (rd_3.Checked)
                    {
                        e.Graphics.DrawString("0", font, new SolidBrush(Color.Black), new Rectangle(xC + 50, yC + 3 * h, w, h), stringFormat);
                        e.Graphics.DrawLine(new Pen(Color.Black, 2), xC + 50, yC + 4 * h, xC + w + 50, yC + 4 * h);
                        e.Graphics.DrawString(TextStringExtension.SpacedString("00"), font, new SolidBrush(Color.Black), new Rectangle(xC + 50, yC + 4 * h, w, h), stringFormat);
                        e.Graphics.DrawLine(new Pen(Color.Black, 2), xC + 50, yC + 5 * h, xC + w + 50, yC + 5 * h);
                        e.Graphics.DrawLine(new Pen(Color.Black, 2), xC + 50, yC + 6 * h, xC + w + 50, yC + 6 * h);
                        e.Graphics.DrawLine(new Pen(Color.Black, 2), xC + 50, yC + 6 * h + 8, xC + w + 50, yC + 6 * h + 8);
                    }
                   


                    xC = 450;
                }
               

                xC = 80;
                yC = yC + 8 * h ;

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
