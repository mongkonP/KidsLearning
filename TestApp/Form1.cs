using System.Drawing.Drawing2D;
using System.Security.Cryptography;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 1000; i++)
                    richTextBox1.Invoke(new Action(() =>
                    { richTextBox1.Text += "\n" + TORServices.Maths.Expression.GenerateTerm(); }));


            });


        }
    }
}