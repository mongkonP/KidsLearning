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

            #region _Math
            #region _menuMathCount
            this.menuMathCount01.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new num001CountDrawtolink()); };
            this.menuMathCount02.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new num002CountandCircleNumber()); };
            this.menuMathCount03.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new num001Num002CountandCircleNumber_01()); };
            this.menuMathCount04.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new num003CountNumberPicture()); };
            this.menuMathCount05.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new num004NumberArabicThaiStringRoman()); };
            this.menuMathCount06.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new num005MoreThan01Pic()); };
            this.menuMathCount07.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new num005MoreThan02Number()); };
            this.menuMathCount08.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new num005NumSortNumber()); };
            this.menuMathCount09.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new num007Num_Digit()); };
            this.menuMathCount10.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new num007NumberByLine()); };
            this.menuMathCount11.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new num008Odd01Pic()); };
            this.menuMathCount12.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new num008Odd02Number()); };
            this.menuMathCount13.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new num009Fraction_01()); };
            this.menuMathCount14.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new num009Fraction_02Compare()); };
            this.menuMathCount15.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new num009Fraction_02NumberConvert()); };
            this.menuMathCount16.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new num010NumSubdivision()); };
            this.menuMathCount17.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new num011SignificantFigure01()); };
            this.menuMathCount18.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new num011Decimal_01()); };
            this.menuMathCount19.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new num011Decimal_Fraction()); };
            this.menuMathCount20.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new num012gcf_lcm04_relationships()); };
            this.menuMathCount21.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            this.menuMathCount22.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            this.menuMathCount23.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            this.menuMathCount24.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            this.menuMathCount25.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            this.menuMathCount26.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new num012gcf_lcm()); };
            this.menuMathCount27.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new num012gcf_lcm02_factoring()); };
            this.menuMathCount28.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new num012gcf_lcm03_Devide()); };
            //this.menuMathCount29.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathCount30.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathCount31.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathCount32.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathCount33.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathCount34.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathCount35.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathCount36.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathCount37.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathCount38.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathCount39.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathCount40.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathCount41.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathCount42.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathCount43.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathCount44.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathCount45.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathCount46.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathCount47.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathCount48.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathCount49.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathCount50.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };

            #endregion

            #region _nemuMathOP
            this.nemuMathOP01.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new op001Plus_pic()); };
            this.nemuMathOP02.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new op002Minus_pic()); };
            this.nemuMathOP03.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new op004PlusMinus_Num_01()); };
            this.nemuMathOP04.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new op003PlusMinus_Subdivision()); };
            this.nemuMathOP05.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new op005PlusMinus_Num_02Positive()); };
            this.nemuMathOP06.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new op006NumberByLine_PlusMinus()); };
            this.nemuMathOP07.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new op007MultipliedDivide_01Num()); };
            this.nemuMathOP08.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new op007MultipliedDivide_02Num()); };
            this.nemuMathOP09.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new op007MultipliedDivide_03SubSection()); };
            this.nemuMathOP10.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new op007MultipliedDivide_04SubSection_Detail()); };
            this.nemuMathOP11.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new op009Fraction01LongDivision()); };
            this.nemuMathOP12.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new op009Fraction02SortDivision()); };
            this.nemuMathOP13.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new op007MultipliedDivide_05Positive()); };
            this.nemuMathOP14.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new op010FractionRuleofthree()); };
            this.nemuMathOP15.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new op010FractionRuleofthreePercent()); };
            this.nemuMathOP16.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new op010FractionPlusMinus_01Pic()); };
            this.nemuMathOP17.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new op010FractionPlusMinus_02Num()); };
            this.nemuMathOP18.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new op011Decimal_01()); };
            this.nemuMathOP19.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new op013_PowerbyTen_OP_01()); };
            this.nemuMathOP21.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new op013_PowerbyTen_OP_02()); };
            this.nemuMathOP30.Click += (o, e) => { panel1.Controls.Clear(); panel1.Controls.Add(new op004PlusMinus_Num_02()); };
           

            #endregion

            #region _menuMathStat
            this.menuMathStat01.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new st_001Statistics_1()); };
            this.menuMathStat02.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new st_001Statistics_2()); };
            this.menuMathStat03.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            this.menuMathStat04.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            this.menuMathStat05.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            this.menuMathStat06.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat07.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat08.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat09.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat10.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat11.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat12.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat13.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat14.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat15.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat16.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat17.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat18.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat19.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat20.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat21.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat22.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat23.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat24.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat25.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat26.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat27.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat28.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat29.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat30.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat31.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat32.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat33.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat34.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat35.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat36.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat37.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat38.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat39.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat40.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat41.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat42.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat43.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat44.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat45.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat46.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat47.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat48.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat49.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menuMathStat50.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };

            #endregion

            #region _menoMathTrigono
            this.menoMathTrigono01.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new prnMath_014GaugeAngle_01()); };
            this.menoMathTrigono02.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new prnMath_014GaugeAngle_02()); };
            this.menoMathTrigono03.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new prnMath_015GaugeLength_01()); };
            this.menoMathTrigono04.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new prnMath_015GaugeLength_02()); };
            this.menoMathTrigono05.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            this.menoMathTrigono06.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono07.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono08.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono09.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono10.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono11.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono12.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono13.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono14.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono15.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono16.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono17.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono18.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono19.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono20.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono21.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono22.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono23.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono24.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono25.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono26.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono27.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono28.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono29.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono30.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono31.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono32.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono33.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono34.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono35.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono36.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono37.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono38.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono39.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono40.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono41.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono42.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono43.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono44.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono45.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono46.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono47.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono48.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono49.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
            //this.menoMathTrigono50.Click +=(o,e)=> { panel1.Controls.Clear(); panel1.Controls.Add(new ()); };
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

            #region _menuEng
            menuEng01.Click += (o, e) =>
            {
                panel1.Controls.Clear(); panel1.Controls.Add(new prnEng002SpellingWord());

            };
            menuEng02.Click += (o, e) =>
            {
                panel1.Controls.Clear();  panel1.Controls.Add(new prnEng001CompareTh_En());

            };
            menuEng03.Click += (o, e) =>
            {

                panel1.Controls.Clear(); panel1.Controls.Add(new prnEng003Sentences());
            };
            menuEng04.Click += (o, e) =>
            {
                panel1.Controls.Clear(); panel1.Controls.Add(new prnEng002SpellingWord());
            };
            menuEng05.Click += (o, e) =>
            {
                panel1.Controls.Clear();  panel1.Controls.Add(new prnEng002WordLine());
            };
            #endregion
        }



        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void frmPrint_Load(object sender, EventArgs e)
        {
           panel1.Controls.Clear();

           //panel1.Controls.Add(new prnMath_010DateTime003AD_BE());


        }

        private void menuEng06_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Add(new prnPrintWord_());
        }

        private void menuMathPw_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Add(new num013_Power());
        }

        private void menuMathPwTen_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); panel1.Controls.Add(new num013_PowerbyTen_01());
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



        /*   private void nemuMathOP21_Click(object sender, EventArgs e)
           {
               panel1.Controls.Clear(); panel1.Controls.Add(new op013_PowerbyTen_02_OP());
           }*/
    }
}
