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
    public partial class NumberSelect : UserControl
    {
        public double Minimum;
        public double Maximum;
        public int Decimal;
        public NumberSelect()
        {
            InitializeComponent();
            rd_1.Click += new EventHandler(radioButton1_Click);
            rd_2.Click += new EventHandler(radioButton1_Click);
            rd_3.Click += new EventHandler(radioButton1_Click);
            rd_4.Click += new EventHandler(radioButton1_Click);
            rd_5.Click += new EventHandler(radioButton1_Click);
            rd_6.Click += new EventHandler(radioButton1_Click);
            rd_7.Click += new EventHandler(radioButton1_Click);
            rd_8.Click += new EventHandler(radioButton1_Click);
            rd_9.Click += new EventHandler(radioButton1_Click);
            rd_10.Click += new EventHandler(radioButton1_Click);
            rd_11.Click += new EventHandler(radioButton1_Click);
            rd_12.Click += new EventHandler(radioButton1_Click);
            rd_13.Click += new EventHandler(radioButton1_Click);
            rd_14.Click += new EventHandler(radioButton1_Click);
            rd_15.Click += new EventHandler(radioButton1_Click);
            rd_16.Click += new EventHandler(radioButton1_Click);
            rd_17.Click += new EventHandler(radioButton1_Click);
            rd_18.Click += new EventHandler(radioButton1_Click);

            rd_70.Click += new EventHandler(radioButton1_Click);

            rd_1.CheckedChanged += new EventHandler(radioButton1_Click);
            rd_2.CheckedChanged += new EventHandler(radioButton1_Click);
            rd_3.CheckedChanged += new EventHandler(radioButton1_Click);
            rd_4.CheckedChanged += new EventHandler(radioButton1_Click);
            rd_5.CheckedChanged += new EventHandler(radioButton1_Click);
            rd_6.CheckedChanged += new EventHandler(radioButton1_Click);
            rd_7.CheckedChanged += new EventHandler(radioButton1_Click);
            rd_8.CheckedChanged += new EventHandler(radioButton1_Click);
            rd_9.CheckedChanged += new EventHandler(radioButton1_Click);
            rd_10.CheckedChanged += new EventHandler(radioButton1_Click);
            rd_11.CheckedChanged += new EventHandler(radioButton1_Click);
            rd_12.CheckedChanged += new EventHandler(radioButton1_Click);
            rd_13.CheckedChanged += new EventHandler(radioButton1_Click);
            rd_14.CheckedChanged += new EventHandler(radioButton1_Click);
            rd_15.CheckedChanged += new EventHandler(radioButton1_Click);
            rd_16.CheckedChanged += new EventHandler(radioButton1_Click);
            rd_17.CheckedChanged += new EventHandler(radioButton1_Click);
            rd_18.CheckedChanged += new EventHandler(radioButton1_Click);

            rd_70.CheckedChanged += new EventHandler(radioButton1_Click);
        
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
            else if (rd_7.Checked)
            {
                Minimum = 100;
                Maximum = 500;
            }
            else if (rd_8.Checked)
            {
                Minimum = 100;
                Maximum = 1000;
            }
            else if (rd_9.Checked)
            {
                Minimum = 1000;
                Maximum = 10000;
            }
            else if (rd_10.Checked)
            {
                Minimum = 10000;
                Maximum = 100000;
            }
            else if (rd_11.Checked)
            {
                Minimum = 100000;
                Maximum = 1000000;
            }
            else if (rd_12.Checked)
            {
                Minimum = 500000;
                Maximum = 10000000;
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
            else if (rd_15.Checked)
            {
                Minimum = -100;
                Maximum = 100;
            }
            else if (rd_16.Checked)
            {
                Minimum = -1000;
                Maximum = 1000;
            }
            else if (rd_17.Checked)
            {
                Minimum = -10000;
                Maximum = 1000000;
            }
            else if (rd_18.Checked)
            {
                Minimum = -10000000;
                Maximum = 10000000;
            }
           

            else if (rd_70.Checked)
            {
                if(!string.IsNullOrEmpty(txtMin.Text))
                Minimum = Convert.ToInt32("0" + txtMin.Text);
                if (!string.IsNullOrEmpty(txtMax. Text))
                    Maximum = Convert.ToInt32("0" + txtMax. Text);
            }
            OnNumberSelectChanged(null);
        }


        private void txtMin_Leave(object sender, EventArgs e)
        {
            if (rd_70.Checked)
            {
                if (!string.IsNullOrEmpty(txtMin.Text))
                    Minimum = Convert.ToInt32("0" + txtMin.Text);
                OnNumberSelectChanged(null);
            }



          
        }

        private void txtMax_Leave(object sender, EventArgs e)
        {
            if (rd_70.Checked)
            {

                if (!string.IsNullOrEmpty(txtMax.Text))
                    Maximum = Convert.ToInt32("0" + txtMax.Text);
                OnNumberSelectChanged(null);
            }

        }

        private void cmbDecimal_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            bool isNumeric = int.TryParse(cmbDecimal.Text, out Decimal);
         

            Minimum = double.Parse(Minimum.ToString($"F{Decimal}"));
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
    }
}
