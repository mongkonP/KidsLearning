using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TORServices.Maths;

namespace KidsLearning.Print.ptnEng
{
 public static   class Eng_Word
    {
        private static List<string> lst_1 = new List<string>() { "b=บ", "bl=บล", "br=บร", "c=ค", "ch=ช", "cl=คล", "cr=คร", "d=ด", "dr=ดร", "f=ฟ", "fl=ฟล", "fr=ฟร", "g=ก", "gh=ก", "gl=กล", "gr=กร", "h=ฮ", "j=จ", "k=ค/ก", "kl=คล/กล", "kn=น", "kr=คร/กร", "l=ล", "m=ม", "n=น", "p=พ", "ph=ฟ", "pl=พล", "pr=พร", "q=คว", "r=ร", "s=ซ/ส", "sc=สค/ส", "sch=สค/ช", "scr=สคร", "sh=ช", "sk=สค", "sl=สล", "sm=สม", "sn=สน", "sp=สพ", "spl=สพล", "spr=สพร", "sq=สคว", "st=สท", "str=สทร", "sw=สว", "t=ท/ต", "th=ด/ตซ", "tr=ทร", "v=วฟ", "w=ว", "wh=ฮ/ว", "wr=ร", "x=ซ", "y=ย", "z=ส", "ng=ง" };
        private static List<string> lst_2 = new List<string>() { "a=แอะ,แอ,อะ,อา", "ai=ไอ", "au=เอา", "ao=เอา", "ar=อาร์/ออร์", "al=อาล์/ออล์", "a-e=เอ", "au=ออ", "aw = ออa", "y=เอย์", "e=เอะ / อี", "ea=อี/เอ", "ear=เอีย/แอ", "ee=อี", "ew=อิว", "ey=อี/เอ", "er=เออร์", "ere=เอีย/แอ", "i = อิ", "ia = เอีย", "ir=เออ", "i-e=ไอ", "o = โอ/เอาะ/อัน", "oo = อู", "oa=โอ", "oi=ออย", "or=เออ/ออ", "oor=ออ/อัว", "ou=เอา/อู", "ow =เอา/โอ", "oy = ออย", "o-e = โอ/อัน", "u=อุ/อัua=อัว", "ur = เออร์", "uy = ไอ", "y=ไอ/อี", "ye=ไอ", "u-e=ยู/อู", "ue=อู" };
        private static List<string> lst_3 = new List<string>() { "b=บ", "bt=บท์", "c=ค", "ch=ช", "ck=ค", "ct=คท์", "d=ด", "dge=ดจ์", "f=ฟ", "ff=ฟ", "ft=ฟท์", "g=ก", "ge=จ", "ght=ท", "k=ค", "l=ล", "ll=ลล์", "ld=ลด์", "lf=ลฟ์", "lt=ลท์", "mpt=มพท์", "m=ม", "mb=มบ์", "mf=มฟ์", "mp=มพ์", "n=น", "nd=นด์", "ng=ง", "nx,nk=งค์", "nce=นส์", "nse=นส์", "nt=นท์", "nz=นส์", "p=พ", "pf=พฟ์", "ph=ฟ", "pt=มท์", "q=ค", "que=ค", "pth=พตซ์", "s=ซ/ส", "sk=สค์", "sp=สพ", "s=ส", "st=สท์", "t=ท", "th=ตซ", "the=ด", "v=ฟ", "ve=ฟ", "w=ว", "x=กซ์", "xt=คซท์", "y=ย", "ye=ย", "z=ส" };


        public static  List<string> lst_EngSymbol
        { 
            get 
            {
                return lst_1;
                }
             }


      public static List<string> lst_EngVowel
        {
            get
            {
                return lst_2;
            }
        }
       public static List<string> lst_EngSpelling
        {
            get
            {
                return lst_3;
            }
        }
        /*private static List<string> lst_All;
        public static List<string> lst_EngAll
        {
            get
            {
                lst_All = new List<string>();
                lst_All.AddRange(lst_1);
                lst_All.AddRange(lst_2);
                lst_All.AddRange(lst_3);
                return lst_All;
            }
        }*/

      public static  string GetWord(List<string> lst, int c = 0)
        {
            return lst[RandomNumber.Randomnumber(0, lst.Count)].Split('=')[c];

        }
    }
}
