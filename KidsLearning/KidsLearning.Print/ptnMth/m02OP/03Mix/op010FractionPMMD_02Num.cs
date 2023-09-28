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

namespace KidsLearning.Print.ptnMth.m02OP
{
    public partial class op010FractionPMMD_02Num : prnControl
    {
        public op010FractionPMMD_02Num()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);

        }

        #region Variables

        int minValue = 1, maxValue = 15;

        #endregion
        private Panel panel3;
        private RadioButton rd_6;
        private RadioButton rd_5;
        private RadioButton rd_4;
        private Panel panel1;
        private RadioButton rd_3;
        private RadioButton rd_2;
        private RadioButton rd_7;
        private RadioButton rd_8;
        private RadioButton rd_10;
        private RadioButton rd_9;
        private RadioButton rd_1;

        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ เศษส่วน ";
            ReportToppic = "ให้หาผล บวก ลบ คูณ หาร เศษส่วนต่อไปนี้";
            iPage = 1;
            iPageAll = 1;
            int a = 2, b = 5;


            printPreviewControl1.Document = this.printDocument1;
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.rd_10 = new System.Windows.Forms.RadioButton();
            this.rd_9 = new System.Windows.Forms.RadioButton();
            this.rd_3 = new System.Windows.Forms.RadioButton();
            this.rd_2 = new System.Windows.Forms.RadioButton();
            this.rd_1 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rd_8 = new System.Windows.Forms.RadioButton();
            this.rd_7 = new System.Windows.Forms.RadioButton();
            this.rd_6 = new System.Windows.Forms.RadioButton();
            this.rd_5 = new System.Windows.Forms.RadioButton();
            this.rd_4 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(247, 591);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Size = new System.Drawing.Size(241, 555);
            this.panel2.Controls.SetChildIndex(this.panel1, 0);
            this.panel2.Controls.SetChildIndex(this.panel3, 0);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            this.panel2.Controls.SetChildIndex(this.txtPageCount, 0);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.bntPrint, 0);
            // 
            // bntPrint
            // 
            this.bntPrint.Location = new System.Drawing.Point(17, 491);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(153, 458);
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(75, 455);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 458);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(247, 0);
            this.groupBox2.Size = new System.Drawing.Size(805, 591);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(799, 572);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rd_10);
            this.panel1.Controls.Add(this.rd_9);
            this.panel1.Controls.Add(this.rd_3);
            this.panel1.Controls.Add(this.rd_2);
            this.panel1.Controls.Add(this.rd_1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 205);
            this.panel1.TabIndex = 14;
            // 
            // rd_10
            // 
            this.rd_10.AutoSize = true;
            this.rd_10.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.rd_10.Location = new System.Drawing.Point(16, 116);
            this.rd_10.Name = "rd_10";
            this.rd_10.Size = new System.Drawing.Size(181, 36);
            this.rd_10.TabIndex = 4;
            this.rd_10.Text = "การหาร เศษส่วน";
            this.rd_10.UseVisualStyleBackColor = true;
            // 
            // rd_9
            // 
            this.rd_9.AutoSize = true;
            this.rd_9.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.rd_9.Location = new System.Drawing.Point(18, 81);
            this.rd_9.Name = "rd_9";
            this.rd_9.Size = new System.Drawing.Size(181, 36);
            this.rd_9.TabIndex = 3;
            this.rd_9.Text = "การคูณ เศษส่วน";
            this.rd_9.UseVisualStyleBackColor = true;
            // 
            // rd_3
            // 
            this.rd_3.AutoSize = true;
            this.rd_3.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.rd_3.Location = new System.Drawing.Point(18, 153);
            this.rd_3.Name = "rd_3";
            this.rd_3.Size = new System.Drawing.Size(98, 36);
            this.rd_3.TabIndex = 2;
            this.rd_3.Text = "แบบสุ่ม";
            this.rd_3.UseVisualStyleBackColor = true;
            // 
            // rd_2
            // 
            this.rd_2.AutoSize = true;
            this.rd_2.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.rd_2.Location = new System.Drawing.Point(18, 45);
            this.rd_2.Name = "rd_2";
            this.rd_2.Size = new System.Drawing.Size(173, 36);
            this.rd_2.TabIndex = 1;
            this.rd_2.Text = "การลบ เศษส่วน";
            this.rd_2.UseVisualStyleBackColor = true;
            // 
            // rd_1
            // 
            this.rd_1.AutoSize = true;
            this.rd_1.Checked = true;
            this.rd_1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.rd_1.Location = new System.Drawing.Point(18, 12);
            this.rd_1.Name = "rd_1";
            this.rd_1.Size = new System.Drawing.Size(185, 36);
            this.rd_1.TabIndex = 0;
            this.rd_1.TabStop = true;
            this.rd_1.Text = "การบวก เศษส่วน";
            this.rd_1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rd_8);
            this.panel3.Controls.Add(this.rd_7);
            this.panel3.Controls.Add(this.rd_6);
            this.panel3.Controls.Add(this.rd_5);
            this.panel3.Controls.Add(this.rd_4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 205);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 183);
            this.panel3.TabIndex = 15;
            // 
            // rd_8
            // 
            this.rd_8.AutoSize = true;
            this.rd_8.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.rd_8.Location = new System.Drawing.Point(18, 113);
            this.rd_8.Name = "rd_8";
            this.rd_8.Size = new System.Drawing.Size(142, 36);
            this.rd_8.TabIndex = 4;
            this.rd_8.Text = "มีจำนวนคละ";
            this.rd_8.UseVisualStyleBackColor = true;
            // 
            // rd_7
            // 
            this.rd_7.AutoSize = true;
            this.rd_7.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.rd_7.Location = new System.Drawing.Point(18, 81);
            this.rd_7.Name = "rd_7";
            this.rd_7.Size = new System.Drawing.Size(140, 36);
            this.rd_7.TabIndex = 3;
            this.rd_7.Text = "มีจำนวนเต็ม";
            this.rd_7.UseVisualStyleBackColor = true;
            // 
            // rd_6
            // 
            this.rd_6.AutoSize = true;
            this.rd_6.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.rd_6.Location = new System.Drawing.Point(16, 149);
            this.rd_6.Name = "rd_6";
            this.rd_6.Size = new System.Drawing.Size(144, 36);
            this.rd_6.TabIndex = 2;
            this.rd_6.Text = "แบบสุ่มเลือก";
            this.rd_6.UseVisualStyleBackColor = true;
            // 
            // rd_5
            // 
            this.rd_5.AutoSize = true;
            this.rd_5.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.rd_5.Location = new System.Drawing.Point(18, 45);
            this.rd_5.Name = "rd_5";
            this.rd_5.Size = new System.Drawing.Size(132, 36);
            this.rd_5.TabIndex = 1;
            this.rd_5.Text = "ส่วนต่างกัน";
            this.rd_5.UseVisualStyleBackColor = true;
            // 
            // rd_4
            // 
            this.rd_4.AutoSize = true;
            this.rd_4.Checked = true;
            this.rd_4.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.rd_4.Location = new System.Drawing.Point(18, 12);
            this.rd_4.Name = "rd_4";
            this.rd_4.Size = new System.Drawing.Size(129, 36);
            this.rd_4.TabIndex = 0;
            this.rd_4.TabStop = true;
            this.rd_4.Text = "ส่วนเท่ากัน";
            this.rd_4.UseVisualStyleBackColor = true;
            // 
            // op010FractionPMMD_02Num
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "op010FractionPMMD_02Num";
            this.Size = new System.Drawing.Size(1052, 591);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        string Sop = "+", Den = "E";
        private void rd_1_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_1.Checked)
            {
                Sop = "+";
            }
            else if (rd_2.Checked)
            {
                Sop = "-";
            }
            else if (rd_9.Checked)
            {
                Sop = "x";
            }
            else if (rd_10.Checked)
            {
                Sop = "÷";
            }
            else if (rd_3.Checked)
            {
                Sop = "+-x÷";
            }

            if (rd_4.Checked)//ส่วนเท่ากัน
            {
                Den = "E";
            }
            else if (rd_5.Checked)//ส่วนต่างกัน
            {
                Den = "NE";
            }
            else if (rd_6.Checked)//แบบสุ่มเลือก
            {
                Den = "E/NE";
            }
            else if (rd_7.Checked)//มีจำนวนเต็ม
            {
                Den = "E_Int";
            }
            else if (rd_8.Checked)//มีจำนวนคละ
            {
                Den = "E_Flc";
            }
            printPreviewControl1.Document = this.printDocument1;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail

            int yC = 120, xC = 100;
            int a = 0, b = 0, _a = 0, _b = 0,
                den_1 = 1, den_2 = 1, _den_1 = 1, _den_2 = 1,
                ext_1 = 0, ext_2 = 0, _ext_1 = 0, _ext_2 = 0;
            string _sop = Sop;
            string _Den;
            for (int i = 0; i < 6; i++)
            {

                _den_1 = 1;
                _den_2 = 1;
                _ext_1 = 0;
                _ext_2 = 0;
                if (Den == "E/NE")
                {
                    switch (RandomNumber.Randomnumber(1, 4000))
                    {
                        case int n when n > 3000:
                            _Den = "E"; break;
                        case int n when n <= 3000 && n > 2000:
                            _Den = "NE"; break;
                        case int n when n <= 2000 && n > 1000:
                            _Den = "E_Int"; break;
                        case int n when n <= 1000:
                            _Den = "E_Flc"; break;
                        default:
                            _Den = "E"; break;
                    }
                }
                else
                {
                    _Den = Den;
                }

                if (_Den == "E")//ส่วนเหมือนกัน
                {
                    _den_1 = RandomNumber.Randomnumber(3, 10);
                    _den_2 = _den_1;

                }
                else if (_Den == "NE")//ส่วนต่างกัน
                {
                    _den_1 = RandomNumber.Randomnumber(4, 10);
                    do
                    {
                        _den_2 = RandomNumber.Randomnumber(2, 10);
                    } while (_den_1 == _den_2);

                }
                else if (_Den == "E_Int")//แบบมีจำนวนเต็ม
                {
                    int aa = RandomNumber.Randomnumber(1, 3000);
                    if (aa > 1500)
                    {
                        _den_2 = 1;
                        _den_1 = RandomNumber.Randomnumber(3, 10);
                    }
                    else
                    {
                        _den_1 = 1;
                        _den_2 = RandomNumber.Randomnumber(3, 10);
                    }

                    //  MessageBox.Show(_den_1 + "  " + _den_2);
                }
                else if (_Den == "E_Flc")//แบบมีจำนวนคละ
                {

                    _den_1 = RandomNumber.Randomnumber(5, 10);
                    _den_2 = RandomNumber.Randomnumber(5, 10);
                    _ext_1 = RandomNumber.Randomnumber(0, 10);
                    _ext_2 = RandomNumber.Randomnumber(0, 10);
                    /*int aa = RandomNumber.Randomnumber(1, 3000) ;
                    if (aa > 2000)
                    {
                        _ext_1 = RandomNumber.Randomnumber(1, 10);
                        
                    }
                    else if (aa < 1000)
                    {
                  
                        _ext_2 = RandomNumber.Randomnumber(1, 10);
                    }
                    else
                    {
                        _ext_1 = RandomNumber.Randomnumber(1, 10);
                        _ext_2 = RandomNumber.Randomnumber(1, 10);
                    }*/


                }


                // MessageBox.Show(_sop + "  " + Den);

                //ถ้าเป็นจำนวนเต็ม _den จะ เท่ากับ 1

                _a = (_den_1 == 1) ? RandomNumber.Randomnumber(1, 10) :
                ((_den_1 == 2) ? 1 : RandomNumber.Randomnumber(1, _den_1));
                _b = (_den_2 == 1) ? RandomNumber.Randomnumber(1, 10) :
                    ((_den_2 == 2) ? 1 : RandomNumber.Randomnumber(1, _den_2));

                a = _a;
                b = _b;
                den_1 = _den_1;
                den_2 = _den_2;
                ext_1 = _ext_1;
                ext_2 = _ext_2;

                if (Sop == "+-x÷")
                {

                    int aa = RandomNumber.Randomnumber(1, 4000);
                    switch (aa)
                    {
                        case int n when n > 3000:
                            _sop = "+";
                            break;
                        case int n when n <= 3000 && n > 2000:
                            _sop = "-";
                            break;
                        case int n when n <= 2000 && n > 1000:
                            _sop = "x";
                            break;
                        case int n when n <= 1000:
                            _sop = "÷";
                            break;
                        default:
                            _sop = "+";
                            break;

                    }
                }

                if (_sop == "-")
                {
                    double v_a = (Convert.ToDouble(((_ext_1 == 0) ? 1d : _ext_1)) * Convert.ToDouble(_den_1) + Convert.ToDouble(_a)) / Convert.ToDouble(_den_1);
                    double v_b = (Convert.ToDouble(((_ext_2 == 0) ? 1d : _ext_2)) * Convert.ToDouble(_den_2) + Convert.ToDouble(_b)) / Convert.ToDouble(_den_2);
                    //  MessageBox.Show($"{_a} + {_den_1}*{_ext_1} = {v_a}"  + "\n" + $"{_b} + {_den_2}*{_ext_2} = {v_b}" );
                    if (v_a > v_b)
                    {
                        a = _b;
                        b = _a;
                        den_1 = _den_2;
                        den_2 = _den_1;
                        ext_1 = _ext_2;
                        ext_2 = _ext_1;
                    }
                    else if (v_a == v_b)
                    {
                        b += (b == 1) ? 1 : RandomNumber.Randomnumber(1, b);
                    }

                }




                if (den_2 > 1)
                {
                    e.Graphics.DrawFraction(ext_2, b, den_2, xC + 10, yC);
                }
                else
                {
                    e.Graphics.DrawString(b.ToString(), new Font("Angsana New", 22), new SolidBrush(Color.Black), xC + 60, yC + 15);
                }

                e.Graphics.DrawString(_sop, new Font("Angsana New", 22), new SolidBrush(Color.Black), xC + 80, yC + 15);

                if (den_1 > 1)
                {
                    e.Graphics.DrawFraction(ext_1, a, den_1, xC + 100, yC);
                }
                else
                {
                    e.Graphics.DrawString(b.ToString(), new Font("Angsana New", 22), new SolidBrush(Color.Black), xC + 110, yC + 15);
                }


                e.Graphics.DrawString(" วิธีทำ# ", new Font("Angsana New", 20), new SolidBrush(Color.Black), xC + 200, yC + 5);
                yC += 150;

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
