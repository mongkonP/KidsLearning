using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class frmCkock_01 : Form
    {
        public frmCkock_01()
        {
            InitializeComponent();
        }

        private void frmCkock_01_Load(object sender, EventArgs e)
        {

        }
        private void DrawClockFace(Graphics gr)
        {
            // Draw.
            using (Pen thick_pen = new Pen(Color.Blue, 4))
            {
                // Outline.
                gr.DrawEllipse(thick_pen,
                    -ClientSize.Width / 2, -ClientSize.Height / 2,
                    ClientSize.Width, ClientSize.Height);

                // Get scale factors.
                /*float outer_x_factor = 0.45f * ClientSize.Width;
                float outer_y_factor = 0.45f * ClientSize.Height;
                float inner_x_factor = 0.425f * ClientSize.Width;
                float inner_y_factor = 0.425f * ClientSize.Height;
                float big_x_factor = 0.4f * ClientSize.Width;
                float big_y_factor = 0.4f * ClientSize.Height;*/

                float outer_x_factor = ClientSize.Width;
                float outer_y_factor = ClientSize.Height;
                float big_x_factor = ClientSize.Width;
                float big_y_factor = ClientSize.Height;


                // Draw the tick marks.
                thick_pen.StartCap = LineCap.Triangle;
               /* for (int minute = 1; minute <= 60; minute++)
                {*/
                    double angle = 30;
                    float cos_angle = (float)Math.Cos(angle);
                    float sin_angle = (float)Math.Sin(angle);
                PointF outer_pt = new PointF(100,100);//new PointF(ClientSize.Width/2, ClientSize.Height/2);
                    /*if (minute % 10 == 0)
                    {*/
                        PointF inner_pt = new PointF( big_x_factor * cos_angle, big_y_factor * sin_angle);
                        gr.DrawLine(thick_pen,outer_pt, inner_pt );
                    //}
                    
                //}
            }
        }

        private void frmCkock_01_Paint(object sender, PaintEventArgs e)
        {
            // Translate to center the drawing.
            e.Graphics.TranslateTransform(
                ClientSize.Width / 2,
                ClientSize.Height / 2);
            DrawClockFace(e.Graphics);
        }
    }
}
