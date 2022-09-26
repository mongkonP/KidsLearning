
using KidsLearning.frm;
using KidsLearning.Print;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KidsLearning
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
       {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //    new prnMath_Equation().PrintFromAddition_and_Subtraction_1();
           // MessageBox.Show(KidsLearning.Classed.Exten.ExtGraphics_Maths.Randomdouble(10,100,3).ToString());
      // new prnMath_01_Num().PrintFrom01ByImageToNumberRectangle(2);
            Application.Run(new frmPrint());
           // DataTable dt = new DataTable();
           // var v = dt.Compute("5-3+6", "");
         //  MessageBox.Show(Exts.ConvertMoney(75));
          //  Application.Run(new frmLoadFile());

           
        }
    }
}
