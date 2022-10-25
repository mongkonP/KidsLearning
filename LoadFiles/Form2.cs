using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
using TORServices.Maths;

namespace LoadFiles
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
 for (int i = 1; i <= 9; i++)
            {

                List<Task> tasks = new List<Task>();
                tasks.Add(Task.Factory.StartNew(() => loadfiledltvAll($"https://dltv.ac.th/teachplan/lists/{i}/{2000}/MjU2NCAvIDE=")));
                tasks.Add(Task.Factory.StartNew(() => loadfiledltvAll($"https://dltv.ac.th/teachplan/lists/{i}/{2000}/MjU2NCAvIDI=")));

                    tasks.Add(Task.Factory.StartNew(() => loadfiledltvAll($"https://dltv.ac.th/teachplan/lists/{i}/{2000}/MjU2MyAvIDE=")));
                    tasks.Add(Task.Factory.StartNew(() => loadfiledltvAll($"https://dltv.ac.th/teachplan/lists/{i}/{2000}/MjU2MyAvIDI=")));

                    
                    Task.WaitAll(tasks.ToArray());
            }

                this.Write("Complete");
            });
           
        }
        Regex regex = new Regex(@"<div class=""numberCircle"">.</div> &nbsp;(.*?)</div>", RegexOptions.None);

        void loadfiledltvAll(string _url)
        {

           
           
            string url = _url;
            this.Write(_url);
            string newflatChain = string.Join(">> ชั้น " + url.Split('/')[5] + Environment.NewLine, from Match match in regex.Matches(TORServices.Network.WebHelper.getHTML(url).Result) select match.Groups[1].Value.Trim());
            richTextBox1.WriteLine(newflatChain);
          

        }
    }
}
