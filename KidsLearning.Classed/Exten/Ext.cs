using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KidsLearning.Classed
{
   public static class Exts
    {

        #region _ListDetail

        private static List<string> name = new List<string>() { " ไตเติ้ล "," คุณยาย "," คุณตา "," คุณพ่อ "," คุณแม่ "," คุณปู่ "," คุณย่า "," ข้าวฝ้าง ", " คุณลุง ", " คุณอา ", " คุณน้า "
        , " ต้นกล้า ", " ภูผา ", " ปอร์เช่ ", " กัปตัน ", " คอปเตอร์ ", " เพื่อน ", " เฟย ", " ภูมิ ", " หมอก ", " ม่อน ", " ราม ", " โรม ", " ยอดรัก ", " ว่าน ",
            " วิทย์ ", " เอื้อ ", " กวิน ", " กองพล ", " กองทัพ ", " ขุนเขา ", " ขอบฟ้า ", " เจ้านาย ", " เจ้าขุน ", " จิรา ", " จิระ ", " ดาวเหนือ ", " ตะวัน ", " ตั้งเต ",
            " ต้นน้ำ ", " ไต้ฝุ่น ", " แทนไท ", " แทนคุณ ", " ธนู ", " นาวา "
        , " พะเพื่อน ", " ภาคิน ", " ม่านหมอก ", " ม่อนไม้ ", " มาวิน ", " ราชัน ", " เรวิน ", " ศิระ ", " ศิลา ", " วาโย ", " วาวี ", " วาที ", " วายุ ", " สิงโต ", " อาทิตย์ ", " ไออุ่น ", " ไอหมอก "};

        private static List<string> lstMoney = new List<string>() { " เหรียญ 1 บาท ", " เหรียญ 2 บาท ", " เหรียญ 5 บาท ", " เหรียญ 10 บาท ", " แบงค์ 20 บาท ", " แบงค์ 50 บาท ",
            " แบงค์ 100 บาท ", " แบงค์ 500 บาท ", " แบงค์ 1000 บาท " };
        private static List<string> lstMoneyBye = new List<string>() { " 50 บาท ", " 80 บาท ", " 100 บาท ", " 40 บาท ", " 60 บาท " };
        private static List<string> lstDetailBye = new List<string>() { " สาคูไส้หมู 15 บาท ", " ขนมเปียกปูน 15 บาท ", " วุ้นมะพร้าว 20 บาท " , " ทองหยอด 25 บาท "
        , " น้ำอัดลม 10 บาท "," ก๋วยเตี๋ยวคั่วไก่ 20 บาท "," แอปเปิ้ล 10 บาท "," สับปะรด 15 บาท "," เทมปุระ 20 บาท "," ราดหน้า 20 บาท ",
            " แกงจืดเต้าหู้ 20 บาท "," ไข่พะโล้ 15 บาท "," ก๋วยจั๊บน้ำข้น 20 บาท "," แกงจืดแตงกวา 20 บาท "," ไข่ลูกเขย 15 บาท "," เอแคลร์ 20 บาท ",
            " แยมโรล 15 บาท "," ผัดกะหล่ำปลี 20 บาท "," ซิฟฟ่อนเค้ก 20 บาท "," ขนมปังลูกเกด 15 บาท "," ฝรั่ง 10 บาท "," แตงโม 15 บาท "
        ," มะม่วง 10 บาท "," ข้าวโพด 15 บาท " ," น้ำอัดลม 10 บาท "," น้ำดื่ม 10 บาท "," น้ำแอปเปิ้ลปั่น 15 บาท "," น้ำส้มปั่น 15 บาท "," น้ำมะม่วงปั่น 15 บาท "," ช็อกโกแลต 20 บาท "};

        private static List<string> lstNoodles = new List<string> {
                "เส้นเล็ก น้ำ 20 บาท", "เส้นเล็ก น้ำ 30 บาท",
                "เส้นเล็ก แห้ง 20 บาท", "เส้นเล็ก แห้ง 30 บาท",
                "เส้นใหญ่ น้ำ 20 บาท", "เส้นใหญ่ น้ำ 30 บาท",
                "เส้นใหญ่ แห้ง 20 บาท", "เส้นใหญ่ แห้ง 30 บาท",
                "บะหมี่ น้ำ 20 บาท", "บะหมี่ น้ำ 30 บาท",
                "บะหมี่ แห้ง 20 บาท", "บะหมี่ แห้ง 30 บาท",
                "มาม่า น้ำ 20 บาท", "มาม่า น้ำ 30 บาท",
                "มาม่า แห้ง 20 บาท", "มาม่า แห้ง 30 บาท",
                "วุ้นเส้น น้ำ 20 บาท", "วุ้นเส้น น้ำ 30 บาท",
                "วุ้นเส้น แห้ง 20 บาท", "วุ้นเส้น แห้ง 30 บาท" ,
                "เกาเหลา 40 บาท","เกาเหลา 60 บาท"};

        #endregion
        public static string RandomManName
        {
            get {return name[RandomNumberGenerator.GetInt32(0,name.Count)]; }
            
        }
        public static string RandomMoney
        {
            get {  return lstMoney[RandomNumberGenerator.GetInt32(0, lstMoney.Count)]; }
          
        }
        public static string RandomMoneyBye
        {
            get {return lstMoneyBye[RandomNumberGenerator.GetInt32(0, lstMoneyBye.Count)]; }
            
        }
        public static string RandomDetailFoodBye
        {
            get
            {
                return lstDetailBye[RandomNumberGenerator.GetInt32(0, lstDetailBye.Count)];
            }
        }        
        public static string RandomDetailNoodlesBye
        {
            get
            {
               return lstNoodles[RandomNumberGenerator.GetInt32(0, lstNoodles.Count)];
            }

        }
        public static List<string> listNoodles
        {
            get { return lstNoodles; }
        }
        public static List<string> listFood
        {
            get { return lstDetailBye; }
        }

        public static string ConvertMoney(int mc)
        {
            /*  List<int> payM = new List<int>() { 2, 5, 10, 20, 50, 100, 500, 1000 };

             List<int> payAll = new List<int>();
             string ssss = " " + mc;
             payAll.Add(mc);
             for (int a = 0; a < payM.Count - 1; a++)
             {
                 int mm = payM[a];

                 if (!payAll.Contains(mm) && mm >= mc)  // ถ้า mm ไม่มีใน payAll และ mm มากกว่า mc 
                 {
                     ssss += "," + mc;
                     payAll.Add(mc); 
                 }
                 else if (mm < mc && payM[a + 1] > mc) 
                 {

                             for (int b = a; b >= 0; b--)
                             {

                                 int _b = payM[a] + payM[b];
                        // System.Windows.Forms.MessageBox.Show("_b = " + _b + "\n" +  payAll.Contains(_b).ToString() + "\n" + ssss);
                                 if (_b > mc && _b < payM[a + 1] && !payAll.Contains(_b))
                                 {
                             ssss += "," + _b;
                             payAll.Add(_b);
                                 }
                                 else
                                 {
                                     for (int c = a; c >= 0; c--)
                                     {
                                         int _c = payM[a] + payM[b] + payM[b];
                                // System.Windows.Forms.MessageBox.Show("_c = " + _c + "\n" + payAll.Contains(_c).ToString() + "\n" + ssss);
                                 if (_c > mc && _c < payM[a + 1] && !payAll.Contains(_c))
                                         {
                                     ssss += "," + _c;
                                     payAll.Add(_c);
                                         }
                                         else
                                         {
                                             for (int d = a; d >= 0; d--)
                                             {
                                                 int _d = payM[a] + payM[b] + payM[b] + payM[d];

                                        // System.Windows.Forms.MessageBox.Show("_d = " + _d + "\n" + payAll.Contains(_d).ToString() + "\n" + ssss);

                                         if (_d > mc && _d < payM[a + 1] && !payAll.Contains(_d))
                                                 {
                                             ssss += "," + _d;
                                             payAll.Add(_d);
                                                 }

                                             }
                                         }
                                     }
                                 }
                             }

                 }



             }

           var s1 = new StringBuilder();
             var results = payAll.Where(x => x != 0).OrderBy(x => x);
             foreach (int s in results)
             {
                 s1.Append(s + " , ");
             }*/

            List<int> payM = new List<int>() { 2, 5, 10, 20, 50, 100, 500, 1000 };
            List<int> payAll = new List<int>();
            int __mc;
            payAll.Add(mc);
            payM.ForEach(mm =>
            {
                __mc = ((mc / mm) + 1) * mm;
                if (!payAll.Contains(__mc))
                    payAll.Add(__mc);
            });

            string ssss = "";
            payAll.ForEach(m => ssss += " " + m);

            return ssss;

        }

        public static List<string> RandomChoie(List<string> lst)
        {
            List<string> _lst = new List<string>();
            List<string> __lst = lst;
            do {
               int randomIndex  = RandomNumberGenerator.GetInt32(0, __lst.Count );
                _lst.Add(__lst[randomIndex]);
                __lst.RemoveAt(randomIndex);

            } while( __lst.Count > 0);

            return _lst;
        }

        //https://stackoverflow.com/questions/11451001/why-isnt-my-text-right-aligned-when-i-custom-draw-my-strings
        //https://docs.microsoft.com/en-us/dotnet/desktop/winforms/advanced/how-to-align-drawn-text?view=netframeworkdesktop-4.8&redirectedfrom=MSDN

        public static void DrawString(this Graphics g, string s, Font f, StringFormat stringFormat, RectangleF r, Color c)
        {
           
           /* stringFormat.Alignment = StringAlignment.Far;
            stringFormat.LineAlignment = StringAlignment.Center; // Not necessary here*/
            g.DrawString(s, f, new SolidBrush(c), r, stringFormat);
        }
    }
}
