using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KidsLearning.Classed.Exten
{
    public class Prefixe
    {
        public string prefixeEn;
        public string prefixeTh;
        public string symbol;
        public string multi;
        public double factor;
        public Prefixe(string pt, string pe, string s, string m, double f)
        {
            prefixeEn = pe; prefixeTh = pt; symbol = s; multi = m; factor = f;

        }
        public Prefixe()
        {


        }
    }
    public static class Prefixess
    {
        //https://th.wikipedia.org/wiki/คำอุปสรรคเอสไอ
        public static Prefixe yotta = new Prefixe("ยอตตะ-", "yotta-", " 	Y-", "10^24", 1000000000000000000000000d);
        public static Prefixe zetta = new Prefixe("เซตตะ-", "zetta-", "Z-", "10^21", 1000000000000000000000d);
        public static Prefixe exa = new Prefixe("เอกซะ-", "exa-", "E-", "10^18", 1000000000000000000d);
        public static Prefixe peta = new Prefixe("เพตะ-", "peta-", "P-", "10^15", 1000000000000000d);
        public static Prefixe tera = new Prefixe("เทระ-", "tera-", "T-", "10^12", 1000000000000d);
        public static Prefixe giga = new Prefixe("จิกะ-", "giga-", "G-", "10^9", 1000000000d);
        public static Prefixe mega = new Prefixe("เมกะ-", "mega-", "M-", "10^6", 1000000d);
        public static Prefixe kilo = new Prefixe("กิโล-", "kilo-", "k-", "10^3", 1000d);
        public static Prefixe hecto = new Prefixe("เฮกโต-", "hecto-", "h-", "10^2", 100d);
        public static Prefixe deca = new Prefixe("เดคา-", "deca-", "da-", "10^1", 10d);
        public static Prefixe deci = new Prefixe("เดซิ-", "deci-", "d-", "10^-1", 0.1d);
        public static Prefixe centi = new Prefixe("เซนติ-", "centi-", "c-", "10^-2", 0.01d);
        public static Prefixe milli = new Prefixe("มิลลิ-", "milli-", "m-", "10^-3", 0.001d);
        public static Prefixe micro = new Prefixe("ไมโคร-", "micro-", "μ-", "10^-6", 0.000001d);
        public static Prefixe nano = new Prefixe("นาโน-", "nano-", "n-", "10^-9", 0.000000001d);
        public static Prefixe pico = new Prefixe("พิโค-", "pico-", "p-", "10^-12", 0.000000000001d);
        public static Prefixe femto = new Prefixe("เฟมโต-", "femto-", "f-", "10^-15", 0.000000000000001d);
        public static Prefixe atto = new Prefixe("อัตโต-", "atto-", "a-", "10^-18", 0.000000000000000001d);
        public static Prefixe zepto = new Prefixe("เซปโต-", "zepto-", "z-", "10^-21", 0.000000000000000000001d);
        public static Prefixe yocto = new Prefixe("ยอกโต-", "yocto-", "y-", "10^-24", 0.000000000000000000000001d);
      private static  Regex regex = new Regex(@"(\d+) ", RegexOptions.Compiled);
        public static string ToPrefix(this string value, int digit = 0)
        {
            string r = "";
            string d = regex.Matches(value)[0].Groups[1].Value;
            string _u = value.Replace(d, "");

            r = double.Parse(d).ToPrefix( digit) + _u.Trim();

            return r;


        }
            public static string ToPrefix(this double d,int digit = 0)
        {
            string r = "";
            if (d > yotta.factor)
            {
                r = (d / yotta.factor).ToString($"F{digit}") + " Y";
            }
            else if (d < yotta.factor && d > zetta.factor)
            {
                r = (d / zetta.factor).ToString($"F{digit}") + " Z";
            }
            else if (d < zetta.factor && d > exa.factor)
            {
                r = (d / exa.factor).ToString($"F{digit}") + " E";
            }
            else if (d < exa.factor && d > peta.factor)
            {
                r = (d / peta.factor).ToString($"F{digit}") + " P";
            }
            else if (d < peta.factor && d > tera.factor)
            {
                r = (d / tera.factor).ToString($"F{digit}") + " Z";
            }
            else if (d < tera.factor && d > giga.factor)
            {
                r = (d / giga.factor).ToString($"F{digit}") + " G";
            }
            else if (d < giga.factor && d > mega.factor)
            {
                r = (d / mega.factor).ToString($"F{digit}") + " M";
            }
            else if (d < mega.factor && d > kilo.factor)
            {
                r = (d / kilo.factor).ToString($"F{digit}") + " k";
            }
            else if (d < kilo.factor && d > hecto.factor)
            {
                r = (d / hecto.factor).ToString($"F{digit}") + " h";
            }
            else if (d < hecto.factor && d > deca.factor)
            {
                r = (d / deca.factor).ToString($"F{digit}") + " da";
            }
            else if (d < deca.factor && d > deci.factor)
            {
                r = (d / deci.factor).ToString($"F{digit}") + " c";
            }
            else if (d < deci.factor && d > centi.factor)
            {
                r = (d / centi.factor).ToString($"F{digit}") + " d";
            }
            else if (d < centi.factor && d > milli.factor)
            {
                r = (d / milli.factor).ToString($"F{digit}") + " m";
            }
            else if (d < milli.factor && d > micro.factor)
            {
                r = (d / micro.factor).ToString($"F{digit}") + " μ";
            }
            else if (d < micro.factor && d > nano.factor)
            {
                r = (d / nano.factor).ToString($"F{digit}") + " n";
            }
            else if (d < nano.factor && d > pico.factor)
            {
                r = (d / pico.factor).ToString($"F{digit}") + " p";
            }
            else if (d < pico.factor && d > femto.factor)
            {
                r = (d / femto.factor).ToString($"F{digit}") + " f";
            }
            else if (d < femto.factor && d > atto.factor)
            {
                r = (d / atto.factor).ToString($"F{digit}") + " a";
            }
            else if (d < atto.factor && d > zepto.factor)
            {
                r = (d / zepto.factor).ToString($"F{digit}") + " z";
            }
            else if (d < zepto.factor && d > yocto.factor)
            {
                r = (d / yocto.factor).ToString($"F{digit}") + " y";
            }
            else
            {
                r = d.ToString($"F{digit}");
            }
            return r;
        }


    }
    public class SciUnit
    {
        public string uintEn;
        public string symbol;
        public string quantityName;
        public string quantitySymbol;
    }
    public static class SI_Unit
    {


        /*
         ชื่อหน่วยวัด 	สัญลักษณ์หน่วยวัด 	ชื่อปริมาณ 	สัญลักษณ์ปริมาณ
    เมตร 	m 	ความยาว 	l (L ตัวเล็ก)
    กรัม 	g 	มวล 	m
    วินาที 	s 	เวลา 	t
    แอมแปร์ 	A 	กระแสไฟฟ้า 	I (i ตัวใหญ่)
    เคลวิน 	K 	อุณหภูมิอุณหพลวัติ 	T
    แคนเดลา 	cd 	ความเข้มของการส่องสว่าง 	Iv (i ตัวใหญ่ห้อยด้วยตัว v เล็ก)
    โมล 	mol 	ปริมาณของสาร 	n

         */

    }
   
}
