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
  public partial  class op005PlusMinus_Num_02Positive:prnControl
    {
        public op005PlusMinus_Num_02Positive()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
        
        }

        #region Variables

        //double minValue = 1, maxValue = 15;
        string strOperation = "+";
        //int digit = 0;
        #endregion
        private GroupBox groupBox4;
        private RadioButton rd_5;
        private RadioButton rd_4;
        private Classed.Controls.NumberSelect numberSelect1;
        private RadioButton rd_6;

        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "การตั้งบวก ลบ เลข";
            iPage = 1;
            iPageAll = 1;
            numberSelect1.rd_4.Checked = true;
            printPreviewControl1.Document = this.printDocument1;
        }

        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rd_5 = new System.Windows.Forms.RadioButton();
            this.rd_4 = new System.Windows.Forms.RadioButton();
            this.rd_6 = new System.Windows.Forms.RadioButton();
            this.numberSelect1 = new KidsLearning.Classed.Controls.NumberSelect();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.numberSelect1);
            this.groupBox1.Size = new System.Drawing.Size(478, 593);
            this.groupBox1.Controls.SetChildIndex(this.numberSelect1, 0);
            this.groupBox1.Controls.SetChildIndex(this.groupBox4, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel2, 0);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 821);
            this.panel2.Size = new System.Drawing.Size(472, 145);
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
            this.groupBox2.Location = new System.Drawing.Point(478, 0);
            this.groupBox2.Size = new System.Drawing.Size(951, 593);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(945, 571);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rd_5);
            this.groupBox4.Controls.Add(this.rd_4);
            this.groupBox4.Controls.Add(this.rd_6);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(3, 642);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(472, 179);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ดำเนินการ";
            // 
            // rd_5
            // 
            this.rd_5.AutoSize = true;
            this.rd_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rd_5.Location = new System.Drawing.Point(15, 90);
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
            this.rd_4.Location = new System.Drawing.Point(15, 48);
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
            this.rd_6.Location = new System.Drawing.Point(15, 131);
            this.rd_6.Name = "rd_6";
            this.rd_6.Size = new System.Drawing.Size(120, 35);
            this.rd_6.TabIndex = 35;
            this.rd_6.Text = "สุ่ม (+/-)";
            this.rd_6.UseVisualStyleBackColor = true;
            this.rd_6.CheckedChanged += new System.EventHandler(this.rd_4_CheckedChanged);
            // 
            // numberSelect1
            // 
            this.numberSelect1.Dock = System.Windows.Forms.DockStyle.Top;
            this.numberSelect1.Location = new System.Drawing.Point(3, 19);
            this.numberSelect1.Name = "numberSelect1";
            this.numberSelect1.Size = new System.Drawing.Size(472, 623);
            this.numberSelect1.TabIndex = 34;
            this.numberSelect1.NumberSelectChanged += new System.EventHandler(this.numberSelect1_NumberSelectChanged);
            // 
            // op005PlusMinus_Num_02Positive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "op005PlusMinus_Num_02Positive";
            this.Size = new System.Drawing.Size(1429, 593);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        private void numberSelect1_NumberSelectChanged(object sender, EventArgs e)
        {
            /*minValue = numberSelect1.Minimum.ToInt();
            maxValue = numberSelect1.Maximum.ToInt();*/
          
            printPreviewControl1.Document = this.printDocument1;
        }

        private void rd_4_CheckedChanged(object sender, EventArgs e)
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

            //MessageBox.Show(numberSelect1.Minimum + "\n"+ numberSelect1.Maximum);
            for (int i = 1; i <= 3; i ++)
            {
                
                strOperation = ((rd_4.Checked)?"+":((rd_5.Checked)?"-":(RandomNumber.Randomnumber(0, 2000) > 1000) ? "-" : "+"));
                e.Graphics.DrawNumPositive(new Font("Arial", 20), numberSelect1.Minimum, numberSelect1.Maximum, xC,yC,strOperation,8, numberSelect1.Decimal);
                strOperation = ((rd_4.Checked) ? "+" : ((rd_5.Checked) ? "-" : (RandomNumber.Randomnumber(0, 2000) > 1000) ? "-" : "+"));
                e.Graphics.DrawNumPositive(new Font("Arial", 20), numberSelect1.Minimum, numberSelect1.Maximum, xC+300, yC, strOperation,8, numberSelect1.Decimal);
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
