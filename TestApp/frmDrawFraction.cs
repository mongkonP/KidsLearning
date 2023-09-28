
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class frmDrawFraction : Form
    {
        public frmDrawFraction()
        {
            InitializeComponent();
        }
        private float R1 = 100;  // ค่าตัวต้านทาน R1 (ให้กำหนดค่าตั้งต้นตามที่คุณต้องการ)
        private float R2 = 220;  // ค่าตัวต้านทาน R2 (ให้กำหนดค่าตั้งต้นตามที่คุณต้องการ)
        private float R3 = 330;  // ค่าตัวต้านทาน R3 (ให้กำหนดค่าตั้งต้นตามที่คุณต้องการ)

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            /*  Graphics graphics = e.Graphics;

              // กำหนดสีและสไตล์ต่างๆ
              Pen pen = new Pen(Color.Black, 3);

              // วาดตัวต้านทานแบบซิกแซก
              int startX = this.Width / 2 - 100;
              int startY = this.Height / 2;
              int angle = 80;
              int lineLength = 25;
              int numLines = 9;

              for (int i = 0; i < numLines; i++)
              {
                  // คำนวณจุดสิ้นสุดของเส้นวาด
                  int endX = startX + lineLength;
                  int endY = startY + (i % 2 == 0 ? lineLength / 2 : -lineLength / 2);


                  // หมุนเส้นวาด
                  double radians = angle * Math.PI / 180.0;
                  double rotatedEndX = Math.Cos(radians) * (endX - startX) - Math.Sin(radians) * (endY - startY) + startX;
                  double rotatedEndY = Math.Sin(radians) * (endX - startX) + Math.Cos(radians) * (endY - startY) + startY;

                  // วาดเส้นวาด

                  graphics.DrawLine(pen, startX, startY, (int)rotatedEndX, (int)rotatedEndY);

                  // อัพเดตจุดเริ่มต้นสำหรับเส้นถัดไป
                  startX = (int)rotatedEndX;
                  startY = (int)rotatedEndY;

                  // หมุนเส้นวาด
                  angle = -angle;
              }*/
            Graphics graphics = e.Graphics;

        }

        private void frmDrawFraction_Load(object sender, EventArgs e)
        {

        }
    }

}
