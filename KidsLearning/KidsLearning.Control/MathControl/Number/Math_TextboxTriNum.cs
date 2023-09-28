
using KidsLearning.Control.Exten;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KidsLearning.Control.MathControl.Number
{
 public partial   class Math_TextboxTriNum: UserControlPrint
    {
        enum Operate { Add,Dev}
        public Math_TextboxTriNum()
        {
            InitializeComponent();
        }
        private TextBox txtNum_1;
        private TextBox txtNum_2;
        private TextBox txtNum_3;

       

        private void InitializeComponent()
        {
            this.txtNum_1 = new System.Windows.Forms.TextBox();
            this.txtNum_2 = new System.Windows.Forms.TextBox();
            this.txtNum_3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNum_1
            // 
            this.txtNum_1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNum_1.Location = new System.Drawing.Point(84, 16);
            this.txtNum_1.Name = "txtNum_1";
            this.txtNum_1.Size = new System.Drawing.Size(100, 35);
            this.txtNum_1.TabIndex = 0;
            this.txtNum_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtNum_2
            // 
            this.txtNum_2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNum_2.Location = new System.Drawing.Point(15, 85);
            this.txtNum_2.Name = "txtNum_2";
            this.txtNum_2.Size = new System.Drawing.Size(100, 35);
            this.txtNum_2.TabIndex = 1;
            this.txtNum_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtNum_3
            // 
            this.txtNum_3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNum_3.Location = new System.Drawing.Point(140, 85);
            this.txtNum_3.Name = "txtNum_3";
            this.txtNum_3.Size = new System.Drawing.Size(100, 35);
            this.txtNum_3.TabIndex = 2;
            this.txtNum_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // TextboxTriNum
            // 
            this.Controls.Add(this.txtNum_3);
            this.Controls.Add(this.txtNum_2);
            this.Controls.Add(this.txtNum_1);
            this.Name = "TextboxTriNum";
            this.Size = new System.Drawing.Size(255, 132);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TextboxTriNum_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TextboxTriNum_Paint(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 3);

            e.Graphics.DrawLine(blackPen, txtNum_1.Location.X + txtNum_1.Width/2,txtNum_1.Location.Y + txtNum_1.Height, txtNum_2.Location.X + txtNum_2.Width / 2, txtNum_2.Location.Y );
            e.Graphics.DrawLine(blackPen, txtNum_1.Location.X + txtNum_1.Width / 2, txtNum_1.Location.Y + txtNum_1.Height, txtNum_3.Location.X + txtNum_3.Width / 2, txtNum_3.Location.Y);
        }
        [System.ComponentModel.Browsable(true)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
        [System.ComponentModel.Category("TOR Setting")]
        [System.ComponentModel.Description("Set Number1")]
        public string Number1
        {
            get { return txtNum_1.Text; }
            set { 
                if (!string.IsNullOrEmpty(value)) txtNum_1.Text = value;
                 txtNum_1.ReadOnly = (string.IsNullOrEmpty(txtNum_1.Text))?false: true;
                 }
        }
        [System.ComponentModel.Browsable(true)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
        [System.ComponentModel.Category("TOR Setting")]
        [System.ComponentModel.Description("Set Number2")]
        public string Number2
        {
            get { return txtNum_2.Text; }
            set
            {
                if (!string.IsNullOrEmpty(value)) txtNum_2.Text = value;
                txtNum_2.ReadOnly = (string.IsNullOrEmpty(txtNum_2.Text)) ? false : true;
            }
        }
        [System.ComponentModel.Browsable(true)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
        [System.ComponentModel.Category("TOR Setting")]
        [System.ComponentModel.Description("Set Number3")]
        public string Number3
        {
            get { return txtNum_3.Text; }
            set
            {
                if (!string.IsNullOrEmpty(value)) txtNum_3.Text = value;
                txtNum_3.ReadOnly = (string.IsNullOrEmpty(txtNum_3.Text)) ? false : true;
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        public  void SetNumber(string num1, string num2, string num3)
        {
            Number1 = num1;
            Number2 = num2;
            Number3 = num3;
        }
    }
}
