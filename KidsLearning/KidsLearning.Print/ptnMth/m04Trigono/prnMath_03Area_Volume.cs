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
using System.Drawing.Drawing2D;

namespace KidsLearning.Print.ptnMth.m04Trigono
{
    public partial class prnMath_03Area_Volume : prnControl
    {
        public prnMath_03Area_Volume()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frm_Load);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);

        }

        #region Variables

        int minValue = 1, maxValue = 15;

        #endregion
        private void frm_Load(object sender, EventArgs e)
        {
            ReportHeader = "การทดสอบ เกี่ยวกับ มาตรวัด ";
            ReportToppic = "การหาพื้นที่ และ ปริมาตร";
            iPage = 1;
            iPageAll = 1;
 
            printPreviewControl1.Document = this.printDocument1;
        }

        private void InitializeComponent()
        {
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Size = new Size(250, 708);
            // 
            // groupBox2
            // 
            groupBox2.Size = new Size(992, 708);
            // 
            // printPreviewControl1
            // 
            printPreviewControl1.Size = new Size(986, 686);
            // 
            // prnMath_03Area_Volume
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            Name = "prnMath_03Area_Volume";
            Size = new Size(1242, 708);
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Loop till all the grid rows not get printed
            if (bFirstPage) printDocumentNewPage(sender, e);

            #region _Draw Detail

            int yC = 120, xC = 100;
            string str = "";
            //พายมีค่าเท่ากับ 22/7 หรือ 3.14
            // https://tuenongfree.xyz/สรุปสูตรพื้นที่ผิวและป/
            //https://www.trueplookpanya.com/learning/detail/13431#
            for (int i = 0; i < 4; i++)
            {
                int a = RandomNumber.Randomnumber(1, 22);
                switch (a)
                {

                    case 1:
                        // สูตรการหาพื้นที่สี่เหลี่ยมจัตุรัส = ด้าน x ด้าน หรือ 1 / 2 x ผลคูณของเส้นทแยงมุม
                        str = $"ให้หา พื้นที่สี่เหลี่ยมจัตุรัส ที่มีความยาวด้าน เป็น {RandomNumber.Randomnumber(1, 10)}  หน่วย";
                        break;
                    case 2:
                        //สูตรการหาพื้นที่สี่เหลี่ยมผืนผ้า = กว้าง x ยาว
                        str = $"ให้หา พื้นที่ของสี่เหลี่ยมผืนผ้า ที่มีความยาว เป็น {RandomNumber.Randomnumber(1, 10)} หน่วย และ กว้าง {RandomNumber.Randomnumber(1, 10)} หน่วย";
                        break;
                    case 3:
                        //สูตรการหาพื้นที่สามเหลี่ยม = 1/2 x ฐาน x สูง
                        str = $"ให้หา พื้นที่สามเหลี่ยม ที่มีความยาวฐานเป็น {RandomNumber.Randomnumber(1, 10)} หน่วย และสูง  {RandomNumber.Randomnumber(1, 10)} หน่วย";
                        break;
                    case 4:
                        //สูตรการหาพื้นที่สี่เหลี่ยมขนมเปียกปูน = ฐาน x สูง หรือ 1/2 x ผลคูณของเส้นทแยงมุม
                        str = $"ให้หา พื้นที่ของสี่เหลี่ยมขนมเปียกปูน ที่มีความยาวฐานเป็น {RandomNumber.Randomnumber(1, 10)} หน่วย และสูง {RandomNumber.Randomnumber(1, 10)} หน่วย";
                        break;
                    case 5:
                        //สูตรการหาพื้นที่สี่เหลี่ยมด้านขนาน = ฐาน x สูง
                        str = $"ให้หา พื้นที่ของสี่เหลี่ยมด้านขนาน ที่มีความยาวฐานเป็น {RandomNumber.Randomnumber(1, 10)} หน่วย และสูง {RandomNumber.Randomnumber(1, 10)} หน่วย";
                        break;
                    case 6:
                        //สูตรการหาพื้นที่สี่เหลี่ยมรูปว่าว = 1/2 x ผลคูณของเส้นทแยงมุม
                        str = $"ให้หา พื้นที่ของสี่เหลี่ยมรูปว่าว ที่มี ผลคูณของเส้นทแยงมุมเป็น {RandomNumber.Randomnumber(1, 10)}  หน่วย";
                        break;
                    case 7:
                        //สูตรการหาพื้นที่สี่เหลี่ยมด้านไม่เท่า = 1/2 x เส้นทแยงมุม x ผลบวกของเส้นกิ่ง= พาย x รัศมี2
                        str = $"ให้หา พื้นที่สี่เหลี่ยมด้านไม่เท่า  ที่มี เส้นทแยงมุมเป็น {RandomNumber.Randomnumber(1, 10)}  หน่วย และ ผลบวกของเส้นกิ่ง {RandomNumber.Randomnumber(1, 10)}  หน่วย";
                        break;
                    case 8:
                        //สูตรการหาปริมาตรทรงลูกบาศก์ = ด้าน3
                        str = $"ให้หา ปริมาตรทรงลูกบาศก์ ที่มีความยาวด้าน เป็น {RandomNumber.Randomnumber(1, 10)}  หน่วย";
                        break;
                    case 9:
                        //สูตรการหาปริมาตรทรงสี่เหลี่ยมมุมฉาก = กว้าง x ยาว x สูง
                        str = $"ให้หา สูตรการหาปริมาตรทรงสี่เหลี่ยมมุมฉาก ที่มีความกว้าง เป็น {RandomNumber.Randomnumber(1, 10)}  หน่วย ความยาวเป็น {RandomNumber.Randomnumber(1, 10)}  หน่วย และ สูง {RandomNumber.Randomnumber(1, 10)} หน่วย";
                        break;
                    case 10:
                        //สูตรการหาปริมาตรทรงกลม = 4/3 x พาย x รัศมี3
                        str = $"ให้หา สูตรการหาปริมาตรทรงกลม ที่มีความยาวด้าน เป็น {RandomNumber.Randomnumber(1, 10)}  หน่วย";
                        break;
                    case 11:
                        //สูตรการหาปริมาตรทรงกระบอก = พาย x รัศมี2 x สูง
                        str = $"ให้หา สูตรการหาปริมาตรทรงกระบอก ที่มีรัศมี เป็น {RandomNumber.Randomnumber(1, 10)}  หน่วย และ สูง {RandomNumber.Randomnumber(1, 10)}  หน่วย";
                        break;
                    case 12:
                        //สูตรการหาปริมาตรทรงกรวย = 1/3 x พาย x รัศมี2 x สูง
                        str = $"ให้หา สูตรการหาปริมาตรทรงกรวย ที่มีรัศมี เป็น {RandomNumber.Randomnumber(1, 10)}  หน่วย และ สูง {RandomNumber.Randomnumber(1, 10)}  หน่วย";
                        break;
                    case 13:
                        //พื้นที่ผิวทรงกลม = 4xพาย x รัศมี2
                        str = $"ให้หา พื้นที่ผิวทรงกลม ที่มีรัศมี เป็น {RandomNumber.Randomnumber(1, 10)}   หน่วย";
                        break;
                    case 14:
                        //สูตรการหาปริมาตรปริซึม = พื้นที่ฐาน x สูง
                        str = $"ให้หา หาปริมาตรปริซึม ที่มีพื้นที่ฐาน เป็น {RandomNumber.Randomnumber(1, 10)}  หน่วย และ สูง {RandomNumber.Randomnumber(1, 10)}  หน่วย";
                        break;
                    case 15:
                        //พื้นที่วงกลม = πr² 
                        str = $"ให้หา พื้นที่วงกลม ที่มีรัศมี เป็น {RandomNumber.Randomnumber(1, 10)}  หน่วย";
                        break;
                    case 16:
                        //เส้นรอบวงกลม = 2πr 
                        str = $"ให้หา เส้นรอบวงกลม ที่มีรัศมี เป็น {RandomNumber.Randomnumber(1, 10)}  หน่วย";
                        break;
                    case 17:
                        //พื้นที่ผิวข้างทรงกระบอก = 2 x พาย x รัศมี x สูง
                        str = $"ให้หา พื้นที่ผิวข้างทรงกระบอก ที่มีรัศมี เป็น {RandomNumber.Randomnumber(1, 10)}  หน่วย และ สูง {RandomNumber.Randomnumber(1, 10)}  หน่วย";
                        break;
                    case 18:
                        //พื้นที่ผิวทรงกระบอก = พื้นที่ผิวข้างทรงกระบอก + 2x พื้นที่ผิววงกลม **กรณีมี 2 ด้าน
                        str = $"ให้หา พื้นที่ผิวทรงกระบอกแบบปิดทั้ง 2 ด้าน ที่มีรัศมี เป็น {RandomNumber.Randomnumber(1, 10)}  หน่วย  และ สูง {RandomNumber.Randomnumber(1, 10)}  หน่วย";
                        break;
                    case 19:
                        //พื้นที่ผิวทรงกระบอก = พื้นที่ผิวข้างทรงกระบอก + พื้นที่ผิววงกลม **กรณีมี 1 ด้าน
                        str = $"ให้หา พื้นที่ผิวทรงกระบอกแบบปิดด้านเดียว ที่มีรัศมี เป็น {RandomNumber.Randomnumber(1, 10)}  หน่วย  และ สูง {RandomNumber.Randomnumber(1, 10)}  หน่วย";
                        break;
                    case 20:
                        //ปริมาตรพีระมิด = 1 / 3 x พื้นที่ฐาน x สูง
                        str = $"ให้หา ปริมาตรพีระมิด ที่มีพื้นที่ฐาน เป็น {RandomNumber.Randomnumber(1, 10)}  หน่วย และ สูง {RandomNumber.Randomnumber(1, 10)}  หน่วย";
                        break;
                    case 21:
                        //ปริมาตรพีระมิด = 1/3 x กว้าง x ยาว x สูง
                        str = $"ให้หา ปริมาตรพีระมิด ที่มีความกว้าง เป็น {RandomNumber.Randomnumber(1, 10)} หน่วย ความยาว {RandomNumber.Randomnumber(1, 10)} หน่วย และ สูง {RandomNumber.Randomnumber(1, 10)}  หน่วย";
                        break;
                    case 22:
                        //สูตรการหาปริมาตรปริซึม = กว้าง x ยาว x สูง
                        str = $"ให้หา หาปริมาตรปริซึม ที่มีความกว้าง เป็น {RandomNumber.Randomnumber(1, 10)} หน่วย ความยาว {RandomNumber.Randomnumber(1, 10)} และ สูง {RandomNumber.Randomnumber(1, 10)}  หน่วย";
                        break;

                }
                e.Graphics.DrawString(str, fontDetail, new SolidBrush(Color.Black), xC, yC);

                yC += 240;

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
