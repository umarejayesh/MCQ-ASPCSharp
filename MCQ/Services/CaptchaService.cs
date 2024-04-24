using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Caching;

namespace MyMVCApplication.Services
{
    public class CaptchaService
    {
        private string _captchaText;
        private Random rand = new Random();
        
        private Point[] GetRandomPoints()
        {
            Point[] points = { new Point(rand.Next(10, 150), rand.Next(10, 150)), new Point(rand.Next(10, 100), rand.Next(10, 100)) };
            return points;
        }

        public string CaptchaText
        {
            get { return _captchaText;  }
        }

        public void CreateImage(HttpContext context)
        {
            _captchaText = GetRandomText(context);

            // put in the cache 

            

            HttpContext.Current.Cache.Insert("cachedCaptcha",_captchaText); 

            Bitmap bitmap = new Bitmap(200, 150, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            Graphics g = Graphics.FromImage(bitmap);

            Pen pen = new Pen(Color.Yellow);

            Rectangle rect = new Rectangle(0, 0, 200, 150);

            SolidBrush b = new SolidBrush(Color.DarkKhaki);

            SolidBrush blue = new SolidBrush(Color.Blue);

            int counter = 0;

            g.DrawRectangle(pen, rect);

            g.FillRectangle(b, rect);

            for (int i = 0; i < _captchaText.Length; i++)
            {
                g.DrawString(_captchaText[i].ToString(), new Font("Verdena", 10 + rand.Next(14, 18)), blue, new PointF(10 + counter, 10));
                counter += 20;
            }

            DrawRandomLines(g);

            HttpContext.Current.Response.ContentType = "image/gif";

            bitmap.Save(HttpContext.Current.Response.OutputStream, ImageFormat.Gif);

            g.Dispose();

            bitmap.Dispose();

        }


        private void DrawRandomLines(Graphics g)
        {
            SolidBrush green = new SolidBrush(Color.Blue);

            for (int i = 0; i < 30; i++)
            {
                g.DrawLines(new Pen(green, 2), GetRandomPoints());
            }
        }

        private string GetRandomText(HttpContext context)
        {
            StringBuilder randomText = new StringBuilder();
            string code = String.Empty;

            string alphabets = "abcdefghijklmnopqrstuvwxyz";

            Random r = new Random();

            for (int j = 0; j <= 5; j++)
            {
                randomText.Append(alphabets[r.Next(alphabets.Length)]);
            }

            code = randomText.ToString();
            return code;
        }

    }
}
