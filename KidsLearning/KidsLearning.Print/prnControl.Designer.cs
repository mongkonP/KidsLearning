
namespace KidsLearning.Print
{
    partial class prnControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prnControl));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bntPrint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPageCount = new TORServices.Forms.NumericTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_EndPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 752);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bntPrint);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtPageCount);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 119);
            this.panel2.TabIndex = 1;
            // 
            // bntPrint
            // 
            this.bntPrint.BackgroundImage = global::KidsLearning.Print.Properties.Resources.menu_print;
            this.bntPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntPrint.Location = new System.Drawing.Point(11, 53);
            this.bntPrint.Name = "bntPrint";
            this.bntPrint.Size = new System.Drawing.Size(50, 51);
            this.bntPrint.TabIndex = 13;
            this.bntPrint.UseVisualStyleBackColor = true;
            this.bntPrint.Click += new System.EventHandler(this.bntPrint_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(169, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "หน้า";
            // 
            // txtPageCount
            // 
            this.txtPageCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPageCount.Location = new System.Drawing.Point(79, 11);
            this.txtPageCount.Name = "txtPageCount";
            this.txtPageCount.Size = new System.Drawing.Size(84, 33);
            this.txtPageCount.TabIndex = 1;
            this.txtPageCount.Text = "10";
            this.txtPageCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "จำนวน";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.printPreviewControl1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(250, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(883, 752);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sample";
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.AutoZoom = false;
            this.printPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printPreviewControl1.Document = this.printDocument1;
            this.printPreviewControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.printPreviewControl1.Location = new System.Drawing.Point(3, 19);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(877, 730);
            this.printPreviewControl1.TabIndex = 0;
            this.printPreviewControl1.Zoom = 1D;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // prnControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "prnControl";
            this.Size = new System.Drawing.Size(1133, 752);
            this.Load += new System.EventHandler(this.prnControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PrintDialog printDialog1;
        public System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        public System.Drawing.Printing.PrintDocument printDocument1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button bntPrint;
        public System.Windows.Forms.Label label2;
        public TORServices.Forms.NumericTextBox txtPageCount;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.PrintPreviewControl printPreviewControl1;
    }
}
