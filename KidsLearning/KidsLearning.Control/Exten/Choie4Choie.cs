


using KidsLearning.Classed;
using KidsLearning.Classed.Exten;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using TORServices.Maths;

namespace KidsLearning.Control.Exten
{
   public class Choie4Choie:TestPanel
    {
        protected Panel panel3;

        public Choie4Choie()
        {
            InitializeComponent();
          
        }
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1272, 159);
            this.panel3.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 88);
            this.button1.TabIndex = 4;
            this.button1.Text = "A";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonChoie_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(322, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(279, 88);
            this.button2.TabIndex = 5;
            this.button2.Text = "B";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonChoie_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(12, 134);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(274, 88);
            this.button4.TabIndex = 6;
            this.button4.Text = "C";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttonChoie_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(322, 134);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(279, 88);
            this.button3.TabIndex = 7;
            this.button3.Text = "D";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonChoie_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 495);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 248);
            this.panel2.TabIndex = 1;
            this.panel2.Resize += new System.EventHandler(this.panel2_Resize);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.11765F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 289F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.20689F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.7931F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(607, 227);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 495);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(645, 495);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Choie4Choie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Choie4Choie";
            this.Size = new System.Drawing.Size(645, 743);
            this.Load += new System.EventHandler(this.Choie4Choie_Load);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        protected  string Ans = "";
        protected string HeaderName = "";
        public Button button1;
        public Button button2;
        public Button button4;
        public Button button3;
        protected Panel panel2;
        protected Panel panel1;
        public PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        public List<string> _Choies;
        private void buttonChoie_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            frmAlert f = new frmAlert((btn.Text == Ans) ? Properties.Resources.right : Properties.Resources.wrong);
            f.ShowDialog();
            //ExtFile.WriteLog(HeaderName +" Ans:" + Ans + ((btn.Text == Ans) ? 1 : 0));
            this.OnScoreChange(new ScoreEvent(((btn.Text == Ans) ? 1 : 0), 1));
            this.OnbuttonChoieClick(e);
        }

        protected void SetButtonText()
        {
            string str;
            str = _Choies[RandomNumber.Randomnumber(0, _Choies.Count)];
            button1.Invoke(new Action(() => { button1.Text ="A. " +  str; }));
            _Choies.Remove(str);
            System.Threading.Thread.Sleep(50);
            str = _Choies[RandomNumber.Randomnumber(0, _Choies.Count)];
            button2.Invoke(new Action(() => { button2.Text = "B. " + str; }));
            _Choies.Remove(str);
            System.Threading.Thread.Sleep(50);
            str = _Choies[ RandomNumber.Randomnumber(0, _Choies.Count)];
            button3.Invoke(new Action(() => { button3.Text = "C. " + str; }));
            _Choies.Remove(str);
            System.Threading.Thread.Sleep(50);
            str = _Choies[0];
            button4.Invoke(new Action(() => { button4.Text = "D. " + str; }));
            _Choies.Remove(str);
            System.Threading.Thread.Sleep(50);
        
        }


        private void Choie4Choie_Load(object sender, EventArgs e)
        {
            
           //ExtFile.WriteLog(HeaderName +  ":Load");
        }

        private void panel2_Resize(object sender, EventArgs e)
        {
            int w = button2.Location.X - button1.Location.X + button1.Width;
            int h = button2.Location.Y - button1.Location.Y + button1.Height;


        }
    }
}
