using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    //https://www.slideshare.net/omidMustefa/analog-clock-c
    public partial class frmClock : Form
    {
        Point[,] hands_coord = new Point[3, 2] { 
            { new Point(0, 0), new Point(0, 120) },
            { new Point(0, 0), new Point(0, 140) },
            { new Point(0, 0), new Point(0, 140) }
        };
        DateTime cur;
        DateTime prev;
        bool change;
        Graphics e;
        public frmClock()
        {
            InitializeComponent();
        }

        private void frmClock_Load(object sender, EventArgs e)
        {

        }

        private void frmClock_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(this.Size.Width / 2, this.Size.Height / 2);
            e.Graphics.RotateTransform(150);
            DrawClock(e.Graphics);
            DrawHands(e.Graphics, prev, true, Color.FromArgb(250, 0, 0, 0));
        }
        private void RotatePoint(Point[] pt, int iRotate, int iangle)
        {
            Point ptTemp = new Point(0, 0);
            for (int i = 0; i < iRotate; i++)
            {
                ptTemp.X = (int)(pt[i].X * Math.Cos(2 * Math.PI * iangle / 360) - pt[i].Y*Math.Sin(2*Math.PI*iangle/360));
                ptTemp.Y = (int)(pt[i].Y * Math.Cos(2 * Math.PI * iangle / 360) - pt[i].X * Math.Sin(2 * Math.PI * iangle / 360));
            }
        }
        private void DrawClock(Graphics e)
        {
            Point[] pt = new Point[2];
            for (int iangle = 0; iangle < 360; iangle += 6)
            {
                pt[0].X = 0; pt[0].Y = 150;
                RotatePoint(pt, 1, iangle);
                pt[1].X = pt[1].Y = (iangle % 5 == 0 ? 10 : 5);
                pt[0].X = pt[1].X/2; pt[0].Y = pt[1].Y/2;
                Pen p = new Pen(Color.FromArgb(255, 0, 0, 0));
                SolidBrush solid = new SolidBrush(Color.FromArgb(255, 0, 0, 0));
                e.DrawEllipse(p, pt[0].X, pt[0].Y, pt[1].X, pt[1].Y);
                e.FillEllipse(solid, pt[0].X, pt[0].Y, pt[1].X, pt[1].Y);
            }
        }
        private void DrawHands(Graphics e, DateTime dt, bool change, Color c)
        {
            Point[,] pt = new Point[3,2];
            int[] iangle = new int[3];
            iangle[0] = (int)((dt.Hour*30)%360+dt.Minute/2);
            iangle[1] = (int)(dt.Minute * 6);
            iangle[2] = (int)(dt.Second * 6);
            pt = (Point[,])hands_coord.Clone();
            for (int i = change ? 0 : 2; i < 3; i++)
            {
                Point[] tt = { pt[i, 0], pt[i,1] };
                RotatePoint(tt, 2, iangle[i]);
                Pen p = new Pen(c);
                e.DrawLine(p, tt[0], tt[1]);
            
            }
        }

        private void frmClock_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cur = DateTime.Now;
            change = cur.Hour != prev.Hour || cur.Minute != prev.Minute;
            DrawHands(this.CreateGraphics(), cur, change, Color.FromArgb(255,255,255,255));
            DrawHands(this.CreateGraphics(), cur, change, Color.FromArgb(255, 0, 0, 0));
            prev = cur;
            Invalidate();
        }
    }
}
