using KidsLearning.Classed.Exten;
using KidsLearning.Print.ptnChem;
using KidsLearning.Print.ptnEng;
using KidsLearning.Print.ptnMth;
using KidsLearning.Print.ptnMth.m01Num;
using KidsLearning.Print.ptnMth.m02OP;
using KidsLearning.Print.ptnMth.m03Stat;
using KidsLearning.Print.ptnMth.m04Trigono;
using KidsLearning.Print.ptnMth.m05GaugeUnit;
using KidsLearning.Print.ptnMth.m09Polynomial;
using KidsLearning.Print.ptnPhy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Maths;
using TORServices.Systems;

namespace KidsLearning.frm
{
    public partial class frmPrint : Form
    {
        public frmPrint()
        {
            InitializeComponent();

            #region _Math
            #region _menuMathCount
            this.menuMathCount01.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new num001CountDrawtolink()); };
            this.menuMathCount02.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new num002CountandCircleNumber()); };
            this.menuMathCount03.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new num001Num002CountandCircleNumber_01()); };
            this.menuMathCount04.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new num003CountNumberPicture()); };
            this.menuMathCount05.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new num004NumberArabicThaiStringRoman()); };
            this.menuMathCount06.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new num005MoreThan01Pic()); };
            this.menuMathCount07.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new num005MoreThan02Number()); };
            this.menuMathCount08.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new num005NumSortNumber()); };
            this.menuMathCount09.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new num007Num_Digit()); };
            this.menuMathCount10.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new num007NumberByLine()); };
            this.menuMathCount11.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new num008Odd01Pic()); };
            this.menuMathCount12.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new num008Odd02Number()); };
            this.menuMathCount13.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new num009Fraction_01()); };
            this.menuMathCount14.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new num009Fraction_02Compare()); };
            this.menuMathCount15.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new num009Fraction_02NumberConvert()); };
            this.menuMathCount16.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new num010NumSubdivision()); };
            this.menuMathCount17.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new num011SignificantFigure02()); };
            toolStripMenuItem11.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new num011SignificantFigure01()); };

            this.menuMathCount26.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new num012gcf_lcm()); };
            this.menuMathCount28.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new num012gcf_lcm03_Devide()); };


            #endregion

            #region _nemuMathOP
            this.nemuMathOP01.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new op001Plus_pic()); };
            this.nemuMathOP02.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new op002Minus_pic()); };
            this.nemuMathOP03.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new op004PlusMinus_Num_01()); };
            this.nemuMathOP04.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new op003PlusMinus_Subdivision()); };
            this.nemuMathOP05.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new op005PlusMinus_Num_02Positive()); };
            this.nemuMathOP06.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new op006NumberByLine_PlusMinus()); };
            this.nemuMathOP07.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new op007MultipliedDivide_01Num()); };
            this.nemuMathOP08.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new op007MultipliedDivide_02Num()); };
            this.nemuMathOP09.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new op007MultipliedDivide_03SubSection()); };
            this.nemuMathOP10.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new op007MultipliedDivide_04SubSection_Detail()); };
            this.nemuMathOP11.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new op009Fraction01LongDivision()); };
            this.nemuMathOP12.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new op009Fraction02SortDivision()); };
            this.nemuMathOP13.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new op007MultipliedDivide_05Positive()); };
            this.nemuMathOP14.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new op010FractionRuleofthree()); };
            this.nemuMathOP15.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new op010FractionRuleofthreePercent()); };
            this.nemuMathOP16.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new op010FractionPlusMinus_01Pic()); };
            this.nemuMathOP17.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new op010FractionPMMD_02Num()); };
            this.nemuMathOP18.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new op011Multipliedbyten()); };
    
            this.nemuMathOP30.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new op004PlusMinus_Num_02()); };


            #endregion

            #region _menuMathStat
            this.menuMathStat01.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new st_001Statistics_1()); };
            this.menuMathStat02.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new st_001Statistics_2()); };
            

            #endregion

            #region _menoMathTrigono
            this.menoMathTrigono01.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new prnMath_014GaugeAngle_01()); };
            this.menoMathTrigono02.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new prnMath_014GaugeAngle_02()); };
            this.menoMathTrigono03.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new prnMath_015GaugeLength_01()); };
            this.menoMathTrigono04.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new prnMath_015GaugeLength_02()); };
            
            #endregion

            #region _Unit
            menuUnit_Datetime1.Click += (o, e) =>
             {
                 panel1.Controls.Clear();
                 panel1.Controls.Add(new prnMath_001DateTime001Time());
             };
            menuUnit_Datetime2.Click += (o, e) =>
             {
                 panel1.Controls.Clear();
                 panel1.Controls.Add(new prnMath_001DateTime002NextTime());
             };

            menuUnit_Datetime3.Click += (o, e) =>
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(new prnMath_002DateTime003AD_BE());
            };
            menuUnit_Datetime4.Click += (o, e) =>
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(new prnMath_002DateTime004AD_BE_Age());
            };
            menuUnit_Datetime5.Click += (o, e) =>
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(new prnMath_003DateTimeCompare());
            };
            #endregion
            #endregion


        }



        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        void getEQ()
        {
            // Create a scheduler that uses two threads.
            LimitedConcurrencyLevelTaskScheduler lcts = new LimitedConcurrencyLevelTaskScheduler(10);
            List<Task> tasks = new List<Task>();

            // Create a TaskFactory and pass it our custom scheduler.
            TaskFactory factory = new TaskFactory(lcts);
            CancellationTokenSource cts = new CancellationTokenSource();
            string s = "";
            // Use it to run a second set of tasks.
            for (int i = 0;i<20000;i++)
            {
                Task t1 = factory.StartNew(() => {
                    s += "\n" + TORServices.Maths.Expression.GenerateExpressionTwo();
                }, cts.Token);
                tasks.Add(t1);
            }

            // Wait for the tasks to complete before displaying a completion message.
            Task.WaitAll(tasks.ToArray());
            cts.Dispose();
            using (StreamWriter writer = File.CreateText("D:\\txtEQ.txt"))
            {
                writer.Write(s);
            }

            MessageBox.Show("complete");
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
           // getEQ();
            //string input = "2CO[sub]3[/sub].2Pb.H[sub]2[/sub]O[sub]2[/sub]Pb";
            //string output = input.ToSubscriptNumber();
            //MessageBox.Show(Convert.ToString(RandomNumber.Randomnumber(1,1000),128));
            //   panel1.Controls.Add(new num009Fraction_02NumberConvert());


        }

        private void menuEng06_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Add(new prnPrintWord_());
        }

    
  

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Add(new prnMath_02Vector_01());
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Add(new prnMath_02Vector_02());
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Add(new prnMath_02Vector_03());
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Add(new num013_PowerPerfix_01());
        }
        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Add(new num013_PowerPerfix_02());
        }

        private void menuOperate_Click(object sender, EventArgs e)
        {

        }

        private void menuMathAll_Click(object sender, EventArgs e)
        {

        }

        private void menuMathCount_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // MessageBox.Show("Test");

        }

        private void mnuSciPhy_Elec_Resistor_01_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Add(new prnSci_Resistor_01());
        }

        private void menoMathTrigono06_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Add(new prnSci_Resistor_01());

        }

        private void menoMathTrigono07_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Add(new prnMath_03Area_Volume());
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Add(new prnChem_05_Molecular_02());
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Add(new prnChem_04_Atom_01());
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Add(new prnChem_05_Molecular_01());
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Add(new prnChem_05_Molecular_03());
        }

        private void การคำนวณสายละลาย01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Add(new prnChem_01_Calc_01());
        }

        private void การคำนวณสายละลาย02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Add(new prnChem_01_Calc_02());
        }

        private void menuMathCount17_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Add(new num011SignificantFigure02());
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Add(new prnPhysic_01_Significant_01());
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Add(new prnPhysic_01_Significant_02());
        }

    

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Add(new _01_Monomial_01());
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Add(new _01_Monomial_02());
        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Add(new num05_PowerbyTen_03());
        }

        private void menuMathPwTen_Click_1(object sender, EventArgs e)
        {
          
            panel1.Controls.Clear(); panel1.Controls.Add(new num05_PowerbyTen_01());
        }

        private void menuMathPwTen_01_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Add(new num05_PowerbyTen_02());
        }

        private void menuMathPw_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Add(new num05_Power());
            
        }

        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Add(new num05_PowerbyTen_04());
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Add(new prnMath_06Equation_01());
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Add(new prnMath_06Equation_02());
        }

        private void แปลงเลขToolStripMenuItem_Click(object sender, EventArgs e)
        {
    
        }

        private void toolStripMenuItem30_Click(object sender, EventArgs e)
        {
        panel1.Controls.Clear(); panel1.Controls.Add(new num06DecimalConvert01());
        }

        private void toolStripMenuItem35_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Add(new _Monomial_Add_01());
           
        }

        private void toolStripMenuItem36_Click(object sender, EventArgs e)
        {
           // panel1.Controls.Clear(); panel1.Controls.Add(new _Monomial_Multi_01());
        }

        private void toolStripMenuItem31_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Add(new _Monomial_Factorization_01());
        }

        private void toolStripMenuItem32_Click(object sender, EventArgs e)
        {
           // panel1.Controls.Clear(); panel1.Controls.Add(new _Monomial_Multi_01());
        }

        private void toolStripMenuItem33_Click(object sender, EventArgs e)
        {
           // panel1.Controls.Clear(); panel1.Controls.Add(new _Monomial_Multi_01());
        }





        /*   private void nemuMathOP21_Click(object sender, EventArgs e)
           {
               panel1.Controls.Clear(); panel1.Controls.Add(new op013_PowerbyTen_02_OP());
           }*/
    }
}
