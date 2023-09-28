using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsLearning.Print
{
    public interface IprnControl
    {
         
        string ReportHeader { get; set; }
         string ReportToppic { get; set; }
    }
}
