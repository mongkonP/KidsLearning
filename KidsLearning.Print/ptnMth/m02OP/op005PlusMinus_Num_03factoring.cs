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

namespace KidsLearning.Print.ptnMth
{
  public partial  class op005PlusMinus_Num_03factoring : prnControl
    {
        public op005PlusMinus_Num_03factoring()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
        
        }

        #region Variables

        double minValue = 1, maxValue = 15;
        string strOperation = "+";

        #endregion
        private GroupBox groupBox4;
        private RadioButton rd_5;
        private RadioButton rd_4;
        private ComboBox cmbDecimal;
        private Label label3;
        private RadioButton rd_6;

        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "การตั้งบวก ลบ ทศนิยม";
            iPage = 1;
            iPageAll = 1;
            
            printPreviewControl1.Document = this.printDocument1;
        }

        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbDecimal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rd_5 = new System.Windows.Forms.RadioButton();
            this.rd_4 = new System.Windows.Forms.RadioButton();
            this.rd_6 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Size = new System.Drawing.Size(350, 605);
            this.groupBox1.Controls.SetChildIndex(this.groupBox4, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel2, 0);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 349);
            this.panel2.Size = new System.Drawing.Size(344, 140);
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
            this.groupBox2.Location = new System.Drawing.Point(350, 0);
            this.groupBox2.Size = new System.Drawing.Size(891, 605);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(885, 583);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbDecimal);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.rd_5);
            this.groupBox4.Controls.Add(this.rd_4);
            this.groupBox4.Controls.Add(this.rd_6);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(3, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(344, 330);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ดำเนินการ";
            // 
            // cmbDecimal
            // 
            this.cmbDecimal.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbDecimal.FormattingEnabled = true;
            this.cmbDecimal.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbDecimal.Location = new System.Drawing.Point(229, 40);
            this.cmbDecimal.Name = "cmbDecimal";
            this.cmbDecimal.Size = new System.Drawing.Size(85, 53);
            this.cmbDecimal.TabIndex = 57;
            this.cmbDecimal.Text = "0";
            this.cmbDecimal.TextChanged += new System.EventHandler(this.cmbDecimal_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 37);
            this.label3.TabIndex = 56;
            this.label3.Text = "decimal/ทศนิยม:";
            // 
            // rd_5
            // 
            this.rd_5.AutoSize = true;
            this.rd_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_5.Location = new System.Drawing.Point(23, 155);
            this.rd_5.Name = "rd_5";
            this.rd_5.Size = new System.Drawing.Size(134, 35);
            this.rd_5.TabIndex = 36;
            this.rd_5.Text = "การลบ (-)";
            this.rd_5.UseVisualStyleBackColor = true;
            this.rd_5.CheckedChanged += new System.EventHandler(this.rd_4_CheckedChanged);
            // 
            // rd_4
            // 
            this.rd_4.AutoSize = true;
            this.rd_4.Checked = true;
            this.rd_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_4.Location = new System.Drawing.Point(23, 113);
            this.rd_4.Name = "rd_4";
            this.rd_4.Size = new System.Drawing.Size(156, 35);
            this.rd_4.TabIndex = 34;
            this.rd_4.TabStop = true;
            this.rd_4.Text = "การบวก (+)";
            this.rd_4.UseVisualStyleBackColor = true;
            this.rd_4.CheckedChanged += new System.EventHandler(this.rd_4_CheckedChanged);
            // 
            // rd_6
            // 
            this.rd_6.AutoSize = true;
            this.rd_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_6.Location = new System.Drawing.Point(23, 196);
            this.rd_6.Name = "rd_6";
            this.rd_6.Size = new System.Drawing.Size(120, 35);
            this.rd_6.TabIndex = 35;
            this.rd_6.Text = "สุ่ม (+/-)";
            this.rd_6.UseVisualStyleBackColor = true;
            this.rd_6.CheckedChanged += new System.EventHandler(this.rd_4_CheckedChanged);
            // 
            // op005PlusMinus_Num_03factoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "op005PlusMinus_Num_03factoring";
            this.Size = new System.Drawing.Size(1241, 605);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }


        private void rd_4_CheckedChanged(object sender, EventArgs e)
        {
            printPreviewControl1.Document = this.printDocument1;

        }

        private void cmbDecimal_TextChanged(object sender, EventArgs e)
        {
            printPreviewControl1.Document = this.printDocument1;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail

            List<int> Nums = new List<int>();
            int yC = 200;
            int xC = 100;
           // int w = 80, h = 50;
            Pen pen = new Pen(Color.Black, 2);
            SolidBrush solidBrush = new SolidBrush(Color.White);

            xC = 150;
     

            for (int i = 1; i <= 3; i ++)
            {
                if (rd_4.Checked)
                {
                    strOperation = "+";
                }
                else if (rd_5.Checked)
                {
                    strOperation = "-";
                }
                else
                {
                    strOperation = (RandomNumberGenerator.GetInt32(0, 2000) > 1000) ? "-" : "+";
                }

                e.Graphics.DrawNumPositive(new Font("Arial", 20), minValue,maxValue,xC,yC,strOperation,8);
                if (rd_4.Checked)
                {
                    strOperation = "+";
                }
                else if (rd_5.Checked)
                {
                    strOperation = "-";
                }
                else
                {
                    strOperation = (RandomNumberGenerator.GetInt32(0, 2000) > 1000) ? "-" : "+";
                }

                e.Graphics.DrawNumPositive(new Font("Arial", 20), minValue, maxValue, xC+300, yC, strOperation,8);
                yC = yC + 220;

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
