using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TORServices.Drawings;
using KidsLearning.Classed.Exten;
namespace KidsLearning
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
           //pictureBox1.Image = KidsLearning.Classed.Exten.ExtGraphics.ImageFromNumber(12,400,400,true);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
           // Image image = KidsLearning.Classed.Exten.ExtGraphics.ImageFromNumber(12,  true);
           // e.Graphics.DrawImage(image, 0, 0);
         e.Graphics.DrawTableNumberText(10,10,123,false,true,true);
        }
    }
}
