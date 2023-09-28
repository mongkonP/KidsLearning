using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KidsLearning.Control.MathControl.Number
{
   public partial class Math_01_Number1to50: UserControl
    {
        private Exten.Choie4Choie choie4Choie2;
        private Panel panel2;
        public Exten.Choie4Choie choie4Choie1;
        private GroupBox groupBox3;
        private TORServices.Forms.TextBoxNumber txtMax;
        private Label label1;
        private TORServices.Forms.TextBoxNumber txtMin;
        private RadioButton radioButton5;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox4;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private Button bntPrint;
        private Panel panel1;
     

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.choie4Choie1 = new KidsLearning.Control.Exten.Choie4Choie();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMax = new TORServices.Forms.TextBoxNumber();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMin = new TORServices.Forms.TextBoxNumber();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.bntPrint = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bntPrint);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(705, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 627);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.choie4Choie1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(705, 627);
            this.panel2.TabIndex = 2;
            // 
            // choie4Choie1
            // 
            this.choie4Choie1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.choie4Choie1.Location = new System.Drawing.Point(0, 0);
            this.choie4Choie1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.choie4Choie1.Name = "choie4Choie1";
            this.choie4Choie1.Size = new System.Drawing.Size(705, 627);
            this.choie4Choie1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMax);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtMin);
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 182);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ช่วงตัวเลข";
            // 
            // txtMax
            // 
            this.txtMax.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMax.Location = new System.Drawing.Point(171, 121);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(56, 43);
            this.txtMax.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(121, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "To";
            // 
            // txtMin
            // 
            this.txtMin.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMin.Location = new System.Drawing.Point(59, 122);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(56, 43);
            this.txtMin.TabIndex = 12;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton5.Location = new System.Drawing.Point(39, 137);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(14, 13);
            this.radioButton5.TabIndex = 11;
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton3.Location = new System.Drawing.Point(146, 75);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(86, 35);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.Text = "1-50";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton4.Location = new System.Drawing.Point(39, 33);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(86, 35);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.Text = "1-10";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(146, 29);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(101, 35);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.Text = "20-50";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(39, 75);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(86, 35);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1-20";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton6);
            this.groupBox4.Controls.Add(this.radioButton7);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 182);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(333, 133);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Setting";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton6.Location = new System.Drawing.Point(28, 29);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(157, 35);
            this.radioButton6.TabIndex = 10;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "แบบตัวเลือก";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton7.Location = new System.Drawing.Point(28, 70);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(144, 35);
            this.radioButton7.TabIndex = 11;
            this.radioButton7.Text = "แบบเติมคำ";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // bntPrint
            // 
            this.bntPrint.Image = global::KidsLearning.Control.Properties.Resources.menu_print;
            this.bntPrint.Location = new System.Drawing.Point(98, 340);
            this.bntPrint.Name = "bntPrint";
            this.bntPrint.Size = new System.Drawing.Size(172, 177);
            this.bntPrint.TabIndex = 14;
            this.bntPrint.UseVisualStyleBackColor = true;
            this.bntPrint.Click += new System.EventHandler(this.bntPrint_Click);
            // 
            // Math_01_Number1to50
            // 
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Math_01_Number1to50";
            this.Size = new System.Drawing.Size(1038, 627);
            this.Load += new System.EventHandler(this.Math_01_Number1to50_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Math_01_Number1to50_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void bntPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
