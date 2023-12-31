﻿using KidsLearning.Classed.Exten;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace KidsLearning.Print.ptnMth.m01Num
{
 public partial   class num003CountNumberPicture:prnControl
    {
        public num003CountNumberPicture()
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
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(250, 602);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(1114, 602);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Size = new System.Drawing.Size(1108, 580);
            // 
            // num003CountNumberPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.Name = "num003CountNumberPicture";
            this.Size = new System.Drawing.Size(1364, 602);
            this.Load += new System.EventHandler(this.prnMath_01_Num_01_1to15_2_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #region Variables

        int minValue = 1, maxValue = 15;

        #endregion
        private void prnMath_01_Num_01_1to15_2_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ ตัวเลข ";
            ReportToppic = "นับจำนวนตามรูปภาพ";
            iPage = 1;
            iPageAll = 1;
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            printPreviewControl1.Document = this.printDocument1;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail

            int yC = 100;
            int xC = 100;
            int w = 80, h = 50;

            xC = 150;
            yC = yC + 50;

            for (int i = 1; i <= 3; i++)
            {

                int a = RandomNumberGenerator.GetInt32(minValue, maxValue);

                e.Graphics.DrawImageFromNumber(xC, yC, a, 200, 250, true);
                xC = xC + 350;
                a = RandomNumberGenerator.GetInt32(minValue, maxValue);
                e.Graphics.DrawImageFromNumber(xC, yC, a, 200, 250, true);
                xC = 150;
                yC = yC + 300;

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
