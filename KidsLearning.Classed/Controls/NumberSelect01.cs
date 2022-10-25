using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KidsLearning.Classed.Controls
{
    public partial class NumberSelect01 : UserControl
    {
        public double Minimum;
        public double Maximum;
        public int Decimal;
        public NumberSelect01()
        {
            InitializeComponent();
            rd_1.Click += new EventHandler(radioButton1_Click);
            rd_2.Click += new EventHandler(radioButton1_Click);
            rd_3.Click += new EventHandler(radioButton1_Click);
            rd_4.Click += new EventHandler(radioButton1_Click);
            rd_5.Click += new EventHandler(radioButton1_Click);
            rd_6.Click += new EventHandler(radioButton1_Click);
            rd_13.Click += new EventHandler(radioButton1_Click);
            rd_14.Click += new EventHandler(radioButton1_Click);

            rd_1.CheckedChanged += new EventHandler(radioButton1_Click);
            rd_2.CheckedChanged += new EventHandler(radioButton1_Click);
            rd_3.CheckedChanged += new EventHandler(radioButton1_Click);
            rd_4.CheckedChanged += new EventHandler(radioButton1_Click);
            rd_5.CheckedChanged += new EventHandler(radioButton1_Click);
            rd_6.CheckedChanged += new EventHandler(radioButton1_Click);
            rd_13.CheckedChanged += new EventHandler(radioButton1_Click);
            rd_14.CheckedChanged += new EventHandler(radioButton1_Click);

        }
        #region _NumberSelect
        private static readonly object _NumberSelectChanged = new object();
        public event EventHandler NumberSelectChanged
        {
            add
            {
                this.Events.AddHandler(_NumberSelectChanged, value);
            }
            remove
            {
                this.Events.RemoveHandler(_NumberSelectChanged, value);
            }
        }
        protected virtual void OnNumberSelectChanged(EventArgs e)
        {
            EventHandler handler = (EventHandler)Events[_NumberSelectChanged];
            if (handler != null) handler(this, e);
        }
        #endregion
        private void NumberSelect_Load(object sender, EventArgs e)
        {
            rd_3.Checked = true;
            OnNumberSelectChanged(null);
        }
        private void radioButton1_Click(object sender, EventArgs e)
        {
            
            if (rd_1.Checked)//1-10
            {
                Minimum = 1;
                Maximum = 10;
            }
            else if (rd_2.Checked)//20-50
            {
                Minimum = 20;
                Maximum = 50;
            }
            else if (rd_3.Checked)//1-20
            {
                Minimum = 1;
                Maximum = 20;
            }
            else if (rd_4.Checked)// 1 - 50
            {
                Minimum = 1;
                Maximum = 50;
            }
            else if (rd_5.Checked)
            {
                Minimum = 50;
                Maximum = 100;
            }
            else if (rd_6.Checked)
            {
                Minimum = 1;
                Maximum = 100;
            }
           
            else if (rd_13.Checked)
            {
                Minimum = -10;
                Maximum = 10;
            }
            else if (rd_14.Checked)
            {
                Minimum = -50;
                Maximum = 50;
            }
            OnNumberSelectChanged(null);
        }

        private void cmbDecimal_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            bool isNumeric = int.TryParse(cmbDecimal.Text, out Decimal);
         

            Minimum = double.Parse(Minimum.ToString( $"F{Decimal}"  ));
            Maximum = double.Parse(Maximum.ToString($"F{Decimal}"));

            OnNumberSelectChanged(null);
        }

        private void cmbDecimal_TextChanged(object sender, EventArgs e)
        {
            bool isNumeric = int.TryParse(cmbDecimal.Text, out Decimal);

            Minimum = double.Parse(Minimum.ToString($"F{Decimal}"));
            Maximum =  double.Parse( Maximum.ToString($"F{Decimal}"));

            OnNumberSelectChanged(null);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                Decimal = -1;
             else
                Decimal = int.Parse(cmbDecimal.Text);

            OnNumberSelectChanged(null);
        }
    }
}
