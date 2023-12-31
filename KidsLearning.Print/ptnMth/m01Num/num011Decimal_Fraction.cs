﻿using KidsLearning.Classed.Exten;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Drawings;

namespace KidsLearning.Print.ptnMth.m01Num
{
   public partial class num011Decimal_Fraction : prnControl
    {

        public num011Decimal_Fraction()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(244, 667);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            this.panel2.Size = new System.Drawing.Size(238, 315);
            // 
            // bntPrint
            // 
            this.bntPrint.Location = new System.Drawing.Point(14, 247);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(172, 208);
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(82, 205);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 208);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(244, 0);
            this.groupBox2.Size = new System.Drawing.Size(1038, 667);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1032, 645);
            // 
            // num011Decimal_Fraction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "num011Decimal_Fraction";
            this.Size = new System.Drawing.Size(1282, 667);
            this.Load += new System.EventHandler(this.prn_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #region Variables

        int minValue = 10, maxValue = 200;
        Random random = new Random();
        #endregion



   
        private void prn_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "เลขนัยสำคัญ และ การปัดเศษ";
            printPreviewControl1.Document = this.printDocument1;
        }



        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail

            int yC = 150, xC = 100;
            int w = 50, h = 35,wr = 25;
            double aa;
            for (int i = 0; i < 8; i++)
            {
              
                aa = random.NextDouble()* RandomNumberGenerator.GetInt32(minValue, maxValue);
            
                int bb = RandomNumberGenerator.GetInt32(3, 10);
                int cc = RandomNumberGenerator.GetInt32(0, bb);
                e.Graphics.DrawString("ให้เขียน " +aa.ToString("N"+ bb) +" ให้อยู่ในรูปแบบ " +((cc==0)? " จำนวนเต็ม " :$"ทศนิยม {cc} ตำแหน่ง")+ " \n _______________________________________________________",
                    new Font("Angsana New", 18), new SolidBrush(Color.Black), xC, yC);
                
                yC += 160 ;

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
