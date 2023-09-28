using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Maths;

namespace KidsLearning.Classed.Exten
{
    public static partial class ExtGraphics_Maths
    {

        private static List<string> images = System.IO.Directory.GetFiles(Application.StartupPath + @"\File\PIC\Count", "*.png").ToList<string>();
        #region ImageFromNumber
        public static Image ImageFromNumber(int number, bool rectangle = false)
        {

            return ImageFromNumber(number, 250, 320, rectangle);

        }
        /* public static Image ImageFromNumber(int number,int width,int height)
         {
             string imag_1 = images[RandomNumber.Randomnumber(0, images.Count - 1)];
             Image image =   TORServices.Drawings.exImage.ImageFromNumber(number, imag_1);
             return TORServices.Drawings.exImage.ResizeImage(image,width,height);
         }*/
        public static Image ImageFromNumber(int number, int width, int height, bool rectangle = false)
        {
            // MessageBox.Show("" + images.Count);
            string imag_1 = images[RandomNumber.Randomnumber(0, images.Count)];
            // Image image = TORServices.Drawings.exImage.ResizeImage(TORServices.Drawings.exImage.ImageFromNumber(number, imag_1), width, height);
            Image image = TORServices.Drawings.exImage.ImageFromNumber(number, imag_1);
            if (rectangle)
            {
                //  MessageBox.Show(imag_1);
                image = TORServices.Drawings.exImage.ResizeImage(image, width - 60, height - 60);
                var destImage = new Bitmap(width, height);
                using (var graphics = Graphics.FromImage(destImage))
                {
                    graphics.Clear(Color.White);
                    graphics.DrawImage(image, 30, 0);

                    graphics.DrawRectangle(new Pen(Color.Black, 3), new Rectangle(width / 2 - 40, height - 50, 80, 40));

                }
                image = destImage;
            }
            else
            {
                // MessageBox.Show(image.Height + "\n" + height);
                image = TORServices.Drawings.exImage.ResizeImage(image, width, height);
            }
            // MessageBox.Show(image.Height + "\n" + height);
            return image;
        }
        public static void DrawImageFromNumber(this Graphics e, int x, int y, int number, int width, int height, bool rectangle = false)
        {
            e.DrawImage(ImageFromNumber(number, width, height, rectangle), x, y);
        }
        public static void DrawImageFromNumber(this Graphics e, int x, int y, int number, bool rectangle = false)
        {
            e.DrawImage(ImageFromNumber(number, 250, 320, rectangle), x, y);
        }
        #endregion


        #region ImageFromNumberLong
        public static Image ImageFromNumberLong(int number, bool rectangle = false)
        {

            return ImageFromNumberLong(number, 250, 320, rectangle);

        }
        /* public static Image ImageFromNumber(int number,int width,int height)
         {
             string imag_1 = images[RandomNumber.Randomnumber(0, images.Count - 1)];
             Image image =   TORServices.Drawings.exImage.ImageFromNumber(number, imag_1);
             return TORServices.Drawings.exImage.ResizeImage(image,width,height);
         }*/
        public static Image ImageFromNumberLong(int number, int width, int height, bool rectangle = false)
        {
            // MessageBox.Show("" + images.Count);
            string imag_1 = images[RandomNumber.Randomnumber(0, images.Count)];
            // Image image = TORServices.Drawings.exImage.ResizeImage(TORServices.Drawings.exImage.ImageFromNumber(number, imag_1), width, height);
            Image image = TORServices.Drawings.exImage.ImageFromNumberLong(number, imag_1);
            if (rectangle)
            {
                //  MessageBox.Show(imag_1);
                image = TORServices.Drawings.exImage.ResizeImage(image, width - 60, height - 60);
                var destImage = new Bitmap(width, height);
                using (var graphics = Graphics.FromImage(destImage))
                {
                    graphics.Clear(Color.White);
                    graphics.DrawImage(image, 30, 0);

                    graphics.DrawRectangle(new Pen(Color.Black, 3), new Rectangle(width / 2 - 40, height - 50, 80, 40));

                }
                image = destImage;
            }
            else
            {
                // MessageBox.Show(image.Height + "\n" + height);
                image = TORServices.Drawings.exImage.ResizeImage(image, width, height);
            }
            // MessageBox.Show(image.Height + "\n" + height);
            return image;
        }
        public static void DrawImageFromNumberLong(this Graphics e, int x, int y, int number, int width, int height, bool rectangle = false)
        {
            e.DrawImage(ImageFromNumberLong(number, width, height, rectangle), x, y);
        }
        public static void DrawImageFromNumberLong(this Graphics e, int x, int y, int number, bool rectangle = false)
        {
            e.DrawImage(ImageFromNumberLong(number, 250, 320, rectangle), x, y);
        }
        #endregion


    }
}
