﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using KidsLearning.Classed;
using KidsLearning.Classed.Exten;
using KidsLearning.Control.Exten;
using TORServices.Drawings;

using TORServices.Maths;

namespace KidsLearning.Control.MathControl.Number
{
  public  class _Math_01_Number1to50:Choie4Choie
    {
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton4;
        private Panel panel4;

        public _Math_01_Number1to50()
        {
            InitializeComponent();
           

            this.HeaderName = "Math_Number1to50 ";
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            this.radioButton2.Click += new System.EventHandler(this.radioButton1_Click);
            this.radioButton3.Click += new System.EventHandler(this.radioButton1_Click);
            this.radioButton4.Click += new System.EventHandler(this.radioButton1_Click);

        }
        private void InitializeComponent()
        {
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Size = new System.Drawing.Size(272, 93);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 3);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Size = new System.Drawing.Size(301, 93);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(4, 154);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Size = new System.Drawing.Size(272, 92);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(426, 154);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Size = new System.Drawing.Size(301, 92);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.None;
            this.panel2.Location = new System.Drawing.Point(0, 394);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Size = new System.Drawing.Size(759, 324);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.None;
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Size = new System.Drawing.Size(972, 394);
            this.panel1.Controls.SetChildIndex(this.panel4, 0);
            this.panel1.Controls.SetChildIndex(this.pictureBox1, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.None;
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Size = new System.Drawing.Size(759, 394);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton3.Location = new System.Drawing.Point(27, 152);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(86, 35);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.Text = "1-50";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(27, 106);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(101, 35);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "20-50";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(27, 65);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(86, 35);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1-20";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton4.Location = new System.Drawing.Point(27, 23);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(86, 35);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.Text = "1-10";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.radioButton3);
            this.panel4.Controls.Add(this.radioButton2);
            this.panel4.Controls.Add(this.radioButton1);
            this.panel4.Controls.Add(this.radioButton4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(759, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(213, 394);
            this.panel4.TabIndex = 7;
            // 
            // Math_Number1to50
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "Math_Number1to50";
            this.Size = new System.Drawing.Size(972, 718);
            this.Load += new System.EventHandler(this.Math_Number1to50_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        public void RandomChoie()
        {

            string imag_1 = Application.StartupPath + @"File\PIC\Count\" +  RandomNumber.Randomnumber(1,50 ) + ".png";
            pictureBox1.Invoke(new Action(() => { pictureBox1.Image = null; }));
            int min = 1, max = 20;
            using (frmWaitFormDialog f = new frmWaitFormDialog(new Action(() =>
            {
                _Choies = new List<string>();
                if (radioButton1.Checked)
                {
                    min = 1; max = 20;
                }
                else if (radioButton2.Checked)
                {
                    min = 20; max = 50;
                }
                else if (radioButton3.Checked)
                {
                    min = 1; max = 50;
                }
                else if (radioButton4.Checked)
                {
                    min = 1; max = 10;
                }
                Ans = RandomNumber.Randomnumber(min, max).ToString();
                _Choies.Add(Ans);
                int cc = 0;
                for (int b = 1; b < 4; b++)
                {
                    while (_Choies.Contains(cc.ToString()) || cc == 0)
                    {

                        cc = RandomNumber.Randomnumber((int.Parse(Ans) - 5 < min) ? min : int.Parse(Ans) - 5, (int.Parse(Ans) + 5 > max) ? max : int.Parse(Ans) + 5);
                        System.Threading.Thread.Sleep(100);
                    }
                    _Choies.Add(cc.ToString());

                }


                pictureBox1.Invoke(new Action(() => { pictureBox1.Image =extMath.RandomNumberPic(int.Parse(Ans), imag_1); }));
                SetButtonText();

                /* string str;
                 for (int b = 1; b <= 4; b++)
                 {
                     Button btn = this.Controls.Find("button" + b, true).FirstOrDefault() as Button;
                     str =_Choies[ RandomNumber.Randomnumber(0, _Choies.Count)];
                     btn.Invoke(new Action(() => { btn.Text = str; }));
                     _Choies.Remove(str);
                     System.Threading.Thread.Sleep(50);

                 }*/


            })))
            {
                f.ShowDialog(this);
            }
        }
        private void radioButton1_Click(object sender, EventArgs e)
        {
            RandomChoie();
        }

        private void Math_Number1to50_Load(object sender, EventArgs e)
        {
            RandomChoie();
        }
        protected override void OnbuttonChoieClick(EventArgs e)
        {
            base.OnbuttonChoieClick(e);
            RandomChoie();

        }

     

    }
}
