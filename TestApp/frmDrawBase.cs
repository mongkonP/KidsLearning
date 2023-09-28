using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Maths;
namespace TestApp
{
    public partial class frmDrawBase : Form
    {
        public frmDrawBase()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int dpi = 40;
        private void frmDrawBase_Load(object sender, EventArgs e)
        {
            float sideLength1InCm = 10.0f;
            float sideLength2InCm = 15.0f;
            float sideLength3InCm = 20.0f;
            DrawTriangleOnPictureBox(pictureBox1, sideLength1InCm, sideLength2InCm, sideLength3InCm);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void DrawTriangleOnPictureBox(PictureBox pictureBox, float sideLength1InCm, float sideLength2InCm, float sideLength3InCm)
        {
            int pixelLength1 = (int)(sideLength1InCm * dpi / 2.54f);
            int pixelLength2 = (int)(sideLength2InCm * dpi / 2.54f);
            int pixelLength3 = (int)(sideLength3InCm * dpi / 2.54f);

            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                Pen pen = new Pen(Color.Black, 3);
                int triangleHeight = (int)(pixelLength1 * Math.Sqrt(3) / 2);

                int topX = pictureBox.Width / 2;
                int topY = (pictureBox.Height - triangleHeight) / 2;

                int leftX = topX - pixelLength1 / 2;
                int leftY = topY + triangleHeight;

                int rightX = topX + pixelLength1 / 2;
                int rightY = topY + triangleHeight;

                Point[] points =
                {
            new Point(topX, topY),
            new Point(leftX, leftY),
            new Point(rightX, rightY)
        };

                graphics.DrawPolygon(pen, points);

                // แสดงรายละเอียดความยาวของแต่ละด้าน
                Font font = new Font("Arial", 12);
                Brush brush = Brushes.Black;

                string side1Details = $"ด้าน 1: {sideLength1InCm} cm";
                string side2Details = $"ด้าน 2: {sideLength2InCm} cm";
                string side3Details = $"ด้าน 3: {sideLength3InCm} cm";

                int textX = topX;
                int textY = topY + triangleHeight + 10; // 10 เพิ่มข้อความลงด้านล่างของรูปสามเหลี่ยม

                graphics.DrawString(side1Details, font, brush, textX, textY);
                textX = leftX;
                textY = (topY + leftY) / 2;
                graphics.DrawString(side2Details, font, brush, textX, textY);
                textX = rightX;
                textY = (topY + rightY) / 2;
                graphics.DrawString(side3Details, font, brush, textX, textY);
            }
            pictureBox.Image = bitmap;
        }
    }
}
