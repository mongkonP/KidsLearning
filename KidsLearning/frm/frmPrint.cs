using KidsLearning.Print.ptnEng;
using KidsLearning.Print.ptnMth;
using KidsLearning.Print.ptnMth.m01Num;
using KidsLearning.Print.ptnMth.m02OP;
using KidsLearning.Print.ptnMth.m03Stat;
using KidsLearning.Print.ptnMth.m04Trigono;
using KidsLearning.Print.ptnMth.m05GaugeUnit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KidsLearning.frm
{
    public partial class frmPrint : Form
    {
        public frmPrint()
        {
            InitializeComponent();

            #region _menuCount

            this.menuCount01.Click += new System.EventHandler(this.menuCount01_Click);
            this.menuCount02.Click += new System.EventHandler(this.menuCount02_Click);
            this.menuCount03.Click += new System.EventHandler(this.menuCount03_Click);
            this.menuCount04.Click += new System.EventHandler(this.menuCount04_Click);
            this.menuCount05.Click += new System.EventHandler(this.menuCount05_Click);
            this.menuCount06.Click += new System.EventHandler(this.menuCount06_Click);
            this.menuCount07.Click += new System.EventHandler(this.menuCount07_Click);
            this.menuCount08.Click += new System.EventHandler(this.menuCount08_Click);
            this.menuCount09.Click += new System.EventHandler(this.menuCount09_Click);
            this.menuCount10.Click += new System.EventHandler(this.menuCount10_Click);
            this.menuCount11.Click += new System.EventHandler(this.menuCount11_Click);
            this.menuCount12.Click += new System.EventHandler(this.menuCount12_Click);
            this.menuCount13.Click += new System.EventHandler(this.menuCount13_Click);
            this.menuCount14.Click += new System.EventHandler(this.menuCount14_Click);
            this.menuCount15.Click += new System.EventHandler(this.menuCount15_Click);
            this.menuCount16.Click += new System.EventHandler(this.menuCount16_Click);
            this.menuCount17.Click += new System.EventHandler(this.menuCount17_Click);
            this.menuCount18.Click += new System.EventHandler(this.menuCount18_Click);
            this.menuCount19.Click += new System.EventHandler(this.menuCount19_Click);
            this.menuCount20.Click += new System.EventHandler(this.menuCount20_Click);
            this.menuCount21.Click += new System.EventHandler(this.menuCount21_Click);
            this.menuCount22.Click += new System.EventHandler(this.menuCount22_Click);
            this.menuCount23.Click += new System.EventHandler(this.menuCount23_Click);
            this.menuCount24.Click += new System.EventHandler(this.menuCount24_Click);
            this.menuCount25.Click += new System.EventHandler(this.menuCount25_Click);
            #endregion



            #region _menuOP
            this.nemuOP01.Click += new System.EventHandler(this.nemuOP01_Click);
            this.nemuOP02.Click += new System.EventHandler(this.nemuOP02_Click);
            this.nemuOP03.Click += new System.EventHandler(this.nemuOP03_Click);
            this.nemuOP04.Click += new System.EventHandler(this.nemuOP04_Click);
            this.nemuOP05.Click += new System.EventHandler(this.nemuOP05_Click);
            this.nemuOP06.Click += new System.EventHandler(this.nemuOP06_Click);
            this.nemuOP07.Click += new System.EventHandler(this.nemuOP07_Click);
            this.nemuOP08.Click += new System.EventHandler(this.nemuOP08_Click);
            this.nemuOP09.Click += new System.EventHandler(this.nemuOP09_Click);
            this.nemuOP10.Click += new System.EventHandler(this.nemuOP10_Click);
            this.nemuOP11.Click += new System.EventHandler(this.nemuOP11_Click);
            this.nemuOP12.Click += new System.EventHandler(this.nemuOP12_Click);
            this.nemuOP13.Click += new System.EventHandler(this.nemuOP13_Click);
            this.nemuOP14.Click += new System.EventHandler(this.nemuOP14_Click);
            this.nemuOP15.Click += new System.EventHandler(this.nemuOP15_Click);
            this.nemuOP16.Click += new System.EventHandler(this.nemuOP16_Click);
            this.nemuOP17.Click += new System.EventHandler(this.nemuOP17_Click);
            this.nemuOP18.Click += new System.EventHandler(this.nemuOP18_Click);
            this.nemuOP19.Click += new System.EventHandler(this.nemuOP19_Click);
            this.nemuOP20.Click += new System.EventHandler(this.nemuOP20_Click);
            this.nemuOP21.Click += new System.EventHandler(this.nemuOP21_Click);
            this.nemuOP22.Click += new System.EventHandler(this.nemuOP22_Click);
            this.nemuOP23.Click += new System.EventHandler(this.nemuOP23_Click);
            this.nemuOP24.Click += new System.EventHandler(this.nemuOP24_Click);
            this.nemuOP25.Click += new System.EventHandler(this.nemuOP25_Click);
            this.nemuOP26.Click += new System.EventHandler(this.nemuOP26_Click);
            this.nemuOP27.Click += new System.EventHandler(this.nemuOP27_Click);
            this.nemuOP28.Click += new System.EventHandler(this.nemuOP28_Click);
            this.nemuOP29.Click += new System.EventHandler(this.nemuOP29_Click);
            this.nemuOP30.Click += new System.EventHandler(this.nemuOP30_Click);


            #endregion

            #region _menuStat
            this.menuStat01.Click += new System.EventHandler(this.menuStat01_Click);
            this.menuStat02.Click += new System.EventHandler(this.menuStat02_Click);
            this.menuStat03.Click += new System.EventHandler(this.menuStat03_Click);
            this.menuStat04.Click += new System.EventHandler(this.menuStat04_Click);
            this.menuStat05.Click += new System.EventHandler(this.menuStat05_Click);
            this.menuStat06.Click += new System.EventHandler(this.menuStat06_Click);
            this.menuStat07.Click += new System.EventHandler(this.menuStat07_Click);
            this.menuStat08.Click += new System.EventHandler(this.menuStat08_Click);
            this.menuStat09.Click += new System.EventHandler(this.menuStat09_Click);
            this.menuStat10.Click += new System.EventHandler(this.menuStat10_Click);
            this.menuStat11.Click += new System.EventHandler(this.menuStat11_Click);
            this.menuStat12.Click += new System.EventHandler(this.menuStat12_Click);
            this.menuStat13.Click += new System.EventHandler(this.menuStat13_Click);
            this.menuStat14.Click += new System.EventHandler(this.menuStat14_Click);
            this.menuStat15.Click += new System.EventHandler(this.menuStat15_Click);
            this.menuStat16.Click += new System.EventHandler(this.menuStat16_Click);
            this.menuStat17.Click += new System.EventHandler(this.menuStat17_Click);
            this.menuStat18.Click += new System.EventHandler(this.menuStat18_Click);
            this.menuStat19.Click += new System.EventHandler(this.menuStat19_Click);
            this.menuStat20.Click += new System.EventHandler(this.menuStat20_Click);

            #endregion

            #region _menoTrigono

            this.menoTrigono01.Click += new System.EventHandler(this.menoTrigono01_Click);
            this.menoTrigono02.Click += new System.EventHandler(this.menoTrigono02_Click);
            this.menoTrigono03.Click += new System.EventHandler(this.menoTrigono03_Click);
            this.menoTrigono04.Click += new System.EventHandler(this.menoTrigono04_Click);
            this.menoTrigono05.Click += new System.EventHandler(this.menoTrigono05_Click);
            this.menoTrigono06.Click += new System.EventHandler(this.menoTrigono06_Click);
            this.menoTrigono07.Click += new System.EventHandler(this.menoTrigono07_Click);
            this.menoTrigono08.Click += new System.EventHandler(this.menoTrigono08_Click);
            this.menoTrigono09.Click += new System.EventHandler(this.menoTrigono09_Click);
            this.menoTrigono10.Click += new System.EventHandler(this.menoTrigono10_Click);
            this.menoTrigono11.Click += new System.EventHandler(this.menoTrigono11_Click);
            this.menoTrigono12.Click += new System.EventHandler(this.menoTrigono12_Click);
            this.menoTrigono13.Click += new System.EventHandler(this.menoTrigono13_Click);
            this.menoTrigono14.Click += new System.EventHandler(this.menoTrigono14_Click);
            this.menoTrigono15.Click += new System.EventHandler(this.menoTrigono15_Click);
            this.menoTrigono16.Click += new System.EventHandler(this.menoTrigono16_Click);
            this.menoTrigono17.Click += new System.EventHandler(this.menoTrigono17_Click);
            this.menoTrigono18.Click += new System.EventHandler(this.menoTrigono18_Click);
            this.menoTrigono19.Click += new System.EventHandler(this.menoTrigono19_Click);
            this.menoTrigono20.Click += new System.EventHandler(this.menoTrigono20_Click);

            #endregion
        }



        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void frmPrint_Load(object sender, EventArgs e)
        {
           panel1.Controls.Clear();

           panel1.Controls.Add(new prnMath_010DateTime003AD_BE());

            // pictureBox1.Image = KidsLearning.Classed.Exten.ExtGraphics.ImageFromNumber(12);
            // pictureBox2.Image = KidsLearning.Classed.Exten.ExtGraphics.ImageFromNumber(12,100,100);
        }


        #region _menuEng


        private void menuEng01_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            prnEng002SpellingWord f = new prnEng002SpellingWord();
            panel1.Controls.Add(f);

        }
        private void menuEng02_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            prnEng001CompareTh_En f = new prnEng001CompareTh_En();
            panel1.Controls.Add(f);

        }
        private void menuEng03_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            prnEng003Sentences f = new prnEng003Sentences();
            panel1.Controls.Add(f);
        }
        private void menuEng04_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            prnEng002SpellingWord f = new prnEng002SpellingWord();
            panel1.Controls.Add(f);
        }
        private void menuEng05_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new prnEng002WordLine());
        }



        #endregion

        #region _Math
        #region _Math_num


        private void menuCount01_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new num001CountDrawtolink());
        }

        private void menuCount02_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new num002CountandCircleNumber());
   
        }

        private void menuCount03_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new num001Num002CountandCircleNumber_01());
        }

        private void menuCount04_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new num003CountNumberPicture());
        }

        private void menuCount05_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new num004NumberArabicThaiStringRoman());
        }

        private void menuCount06_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new num005MoreThan01Pic());
        }

        private void menuCount07_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new num005MoreThan02Number());
        }

        private void menuCount08_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new num005NumSortNumber());
        }

        private void menuCount09_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new num007Num_Digit());
        }

        private void menuCount10_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new num007NumberByLine());
        }

        private void menuCount11_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new num008Odd01Pic());
        }

        private void menuCount12_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new num008Odd02Number());
        }

        private void menuCount13_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new num009Fraction_01());
        }

        private void menuCount14_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new num009Fraction_02Compare());
        }

        private void menuCount15_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
             panel1.Controls.Add(new num009Fraction_02NumberConvert());
        }

        private void menuCount16_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount17_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount18_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount19_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount20_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount21_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount22_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount23_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount24_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount25_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount26_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount27_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount28_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount29_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount30_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount31_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount32_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount33_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount34_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount35_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount36_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount37_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount38_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount39_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount40_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount41_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount42_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount43_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount44_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount45_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount46_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount47_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount48_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuCount49_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }
        #endregion

        #region _nemuOP
        private void nemuOP01_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new op001Plus_pic());
        }

        private void nemuOP02_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new op002Minus_pic());
        }

        private void nemuOP03_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new op004PlusMinus_Num_01());
        }

        private void nemuOP04_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new op003PlusMinus_Subdivision());
        }

        private void nemuOP05_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new op005PlusMinus_Num_02Positive());
        }

        private void nemuOP06_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new op006NumberByLine_PlusMinus());
        }

        private void nemuOP07_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new op007MultipliedDivide_01Num());
        }

        private void nemuOP08_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new op007MultipliedDivide_02Num());
        }

        private void nemuOP09_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new op007MultipliedDivide_03SubSection());
        }

        private void nemuOP10_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new op007MultipliedDivide_04SubSection_Detail());
        }

        private void nemuOP11_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new op009Fraction01LongDivision());
        }

        private void nemuOP12_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new op009Fraction02SortDivision());
        }

        private void nemuOP13_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new op007MultipliedDivide_05Positive());
        }

        private void nemuOP14_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new op010FractionRuleofthree());
        }

        private void nemuOP15_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new op010FractionRuleofthreePercent());
        }

        private void nemuOP16_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP17_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP18_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP19_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP20_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP21_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP22_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP23_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP24_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP25_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP26_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP27_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP28_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP29_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP30_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP31_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP32_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP33_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP34_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP35_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP36_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP37_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP38_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP39_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP40_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP41_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP42_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP43_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP44_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP45_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP46_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP47_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP48_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void nemuOP49_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        #endregion

        #region _menuStat


        private void menuStat01_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new prnMath_016Statistics_1());
        }

        private void menuStat02_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new prnMath_016Statistics_2());
        }

        private void menuStat03_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuStat04_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuStat05_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuStat06_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuStat07_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuStat08_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuStat09_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuStat10_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuStat11_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuStat12_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuStat13_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuStat14_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuStat15_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuStat16_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuStat17_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuStat18_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuStat19_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menuStat20_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        #endregion

        #region _menoTrigono

       

        private void menoTrigono01_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new prnMath_014GaugeAngle_01());
        }

        private void menoTrigono02_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new prnMath_014GaugeAngle_02());
        }

        private void menoTrigono03_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new prnMath_015GaugeLength_01());
        }

        private void menoTrigono04_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new prnMath_015GaugeLength_02());
        }

        private void menoTrigono05_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menoTrigono06_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menoTrigono07_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menoTrigono08_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menoTrigono09_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menoTrigono10_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menoTrigono11_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menoTrigono12_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menoTrigono13_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menoTrigono14_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menoTrigono15_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menoTrigono16_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menoTrigono17_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menoTrigono18_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menoTrigono19_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }

        private void menoTrigono20_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            //panel1.Controls.Add(new ());
        }


        #endregion

        #region _Unit
        private void menuUnit_Datetime1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new prnMath_010DateTime001Time());
        }
        private void menuUnit_Datetime2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new prnMath_010DateTime002NextTime());
        }

    private void menuUnit_Datetime3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new prnMath_010DateTime003AD_BE());
        }
        private void menuUnit_Datetime4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new prnMath_010DateTime004AD_BE_Age());
        }
        #endregion

        #endregion


    }
}
