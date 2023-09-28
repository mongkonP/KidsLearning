using KidsLearning.Classed;
using KidsLearning.Control.Exten;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Maths;

namespace KidsLearning.Control.MathControl.Number
{
 public partial   class Math_Number01: UserControlPrint
    {
        public Math_Number01()
        {
            InitializeComponent();
            button1.Click += buttonChoie_Click;
            button2.Click += buttonChoie_Click;
            button3.Click += buttonChoie_Click;
            button4.Click += buttonChoie_Click;
        }

    

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDetail;

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDetail = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDetail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 78);
            this.panel1.TabIndex = 0;
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDetail.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDetail.Location = new System.Drawing.Point(0, 0);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(155, 65);
            this.lblDetail.TabIndex = 0;
            this.lblDetail.Text = "label1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.button4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 78);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(937, 655);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(471, 330);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(463, 322);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(3, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(462, 322);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(471, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(463, 321);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(462, 321);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Math_Number01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Math_Number01";
            this.Size = new System.Drawing.Size(937, 733);
            this.Load += new System.EventHandler(this.Math_Number01_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #region _ScoreChange
        private static readonly object _ScoreChange = new object();
        public event ScoreEventHandler ScoreChange
        {
            add
            {
                this.Events.AddHandler(_ScoreChange, value);
            }
            remove
            {
                this.Events.RemoveHandler(_ScoreChange, value);
            }
        }
        protected virtual void OnScoreChange(ScoreEvent e)
        {
            ScoreEventHandler handler = (ScoreEventHandler)Events[_ScoreChange];
            if (handler != null) handler(this, e);
        }

        private static readonly object _buttonChoie_Click = new object();
        public event EventHandler buttonChoieClick
        {
            add
            {
                this.Events.AddHandler(_buttonChoie_Click, value);
            }
            remove
            {
                this.Events.RemoveHandler(_buttonChoie_Click, value);
            }
        }
        protected virtual void OnbuttonChoieClick(EventArgs e)
        {
            EventHandler handler = (EventHandler)Events[_buttonChoie_Click];
            if (handler != null) handler(this, e);
        }
        #endregion

        private void Math_Number01_Load(object sender, EventArgs e)
        {
            SetButton();
        }
        private void buttonChoie_Click(object sender, EventArgs e)
        {
            Button _btn = sender as Button;

            frmAlert f = new frmAlert((_btn.Name == btn) ? Properties.Resources.right : Properties.Resources.wrong);
            f.ShowDialog();
            //ExtFile.WriteLog(HeaderName +" Ans:" + Ans + ((btn.Text == Ans) ? 1 : 0));
            this.OnScoreChange(new ScoreEvent(((_btn.Name == btn) ? 1 : 0), 1));
            this.OnbuttonChoieClick(e);
            SetButton();
        }
        int Ans;string btn = "";
        void SetButton()
        { 
            Ans = RandomNumber.Randomnumber(1, 20);
            lblDetail.Text = "เลือกรูปภาพที่มีจำนวนเท่ากับ " + Ans;
            int a = Ans;
            int b = a;
            while (b==a)
            {
               b = RandomNumber.Randomnumber(1, 20);
            }
            int c = a;
            while (c == a || c == b)
            {
                c = RandomNumber.Randomnumber(1, 20);
            }
            int d = a;
            while (d == a || d == b || d== c)
            {
                d = RandomNumber.Randomnumber(1, 20);
            }
            int e = RandomNumber.Randomnumber(1, 1000);
            if (e <= 250)
            {
                btn = "button1";
               
                button1.BackgroundImage = KidsLearning.Classed.Exten.ExtGraphics_Maths.ImageFromNumber(a);
                button2.BackgroundImage = KidsLearning.Classed.Exten.ExtGraphics_Maths.ImageFromNumber(b);
                button3.BackgroundImage = KidsLearning.Classed.Exten.ExtGraphics_Maths.ImageFromNumber(c);
                button4.BackgroundImage = KidsLearning.Classed.Exten.ExtGraphics_Maths.ImageFromNumber(d);
            }
            else if (e > 250 && e<=500)
            {
                btn = "button2";
                button1.BackgroundImage = KidsLearning.Classed.Exten.ExtGraphics_Maths.ImageFromNumber(b);
                button2.BackgroundImage = KidsLearning.Classed.Exten.ExtGraphics_Maths.ImageFromNumber(a);
                button3.BackgroundImage = KidsLearning.Classed.Exten.ExtGraphics_Maths.ImageFromNumber(c);
                button4.BackgroundImage = KidsLearning.Classed.Exten.ExtGraphics_Maths.ImageFromNumber(d);
            }
            else if (e > 500 && e <= 750)
            {
                btn = "button3";

                button1.BackgroundImage = KidsLearning.Classed.Exten.ExtGraphics_Maths.ImageFromNumber(b);          
                button2.BackgroundImage = KidsLearning.Classed.Exten.ExtGraphics_Maths.ImageFromNumber(c);     
                button3.BackgroundImage = KidsLearning.Classed.Exten.ExtGraphics_Maths.ImageFromNumber(a);
                button4.BackgroundImage = KidsLearning.Classed.Exten.ExtGraphics_Maths.ImageFromNumber(d);
            }
            else if (e >750)
            {
                btn = "button4";
 
                button1.BackgroundImage = KidsLearning.Classed.Exten.ExtGraphics_Maths.ImageFromNumber(b);
                button2.BackgroundImage = KidsLearning.Classed.Exten.ExtGraphics_Maths.ImageFromNumber(d);
                button3.BackgroundImage = KidsLearning.Classed.Exten.ExtGraphics_Maths.ImageFromNumber(c);
                button4.BackgroundImage = KidsLearning.Classed.Exten.ExtGraphics_Maths.ImageFromNumber(a);
            }
        }
    }
}
