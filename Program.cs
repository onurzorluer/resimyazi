using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Drawing2D;



namespace resimyazi
{
    class Program
    {
        static void Main(string[] args)
        {

            double dolarKuru = 3.40;
            double yeniDolarKuru = 3.36;

            if (dolarKuru <= yeniDolarKuru)
            {

                //Arkaplanda kullanmak istediğimiz resmin konumunu seçiyoruz.
                Bitmap resim1 = (Bitmap)Image.FromFile(@"C:\Users\Onur\Desktop\background.jpg", true);

                Graphics g = Graphics.FromImage(resim1);

                //Arkaplan resminin üzerine yazmak istediğimiz yazı ve çeşitli detaylarını -yazı tipi, boyutu, konumu vs.- ayarlıyoruz.
                g.DrawString("DOLAR", new Font("Verdana", 20, FontStyle.Bold), new SolidBrush(System.Drawing.Color.White), 60, 80);
                g.DrawString(yeniDolarKuru.ToString(), new Font("Verdana", 18, FontStyle.Bold), new SolidBrush(System.Drawing.Color.White), 80, 110);

                //Arkaplan resminin üzerine koymak istediğimiz resmin konumunu seçiyoruz.
                System.Drawing.Image img1 = System.Drawing.Image.FromFile(@"C:\Users\Onur\Desktop\up-97614_960_720.png", true);

                //üzerine koyduğumuz resmin konumunu ayarlıyoruz.
                g.DrawImage(img1, 180, 80, 50, 50);

                //Yeni oluşturduğumuz resmin kayıt edileceği yeri belirliyoruz.
                resim1.Save(@"C:\Users\Onur\Desktop\dolar-yuksel.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }

            else
            {
                //Arkaplanda kullanmak istediğimiz resmin konumunu seçiyoruz.
                Bitmap resim2 = (Bitmap)Image.FromFile(@"C:\Users\Onur\Desktop\background.jpg", true);

                Graphics g = Graphics.FromImage(resim2);

                //Arkaplan resminin üzerine yazmak istediğimiz yazı ve çeşitli detaylarını -yazı tipi, boyutu, konumu vs.- ayarlıyoruz.
                g.DrawString("DOLAR", new Font("Verdana", 20, FontStyle.Bold), new SolidBrush(System.Drawing.Color.White), 60, 80);
                g.DrawString(yeniDolarKuru.ToString(), new Font("Verdana", 18, FontStyle.Bold), new SolidBrush(System.Drawing.Color.White), 80, 110);

                //Arkaplan resminin üzerine koymak istediğimiz resmin konumunu seçiyoruz.
                System.Drawing.Image img2 = System.Drawing.Image.FromFile(@"C:\Users\Onur\Desktop\down-254095_960_720.png", true);

                //üzerine koyduğumuz resmin konumunu ayarlıyoruz.
                g.DrawImage(img2, 180, 80, 50, 50);

                //Yeni oluşturduğumuz resmin kayıt edileceği yeri belirliyoruz.
                resim2.Save(@"C:\Users\Onur\Desktop\dolar-dus.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }

            Console.WriteLine("Resim Başarıyla Oluşturuldu.");
            Console.ReadLine();

        }
    }
}
