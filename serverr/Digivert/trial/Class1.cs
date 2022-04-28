using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing.Drawing2D;

namespace trial
{
    public class Class1
    {//משנה את התמונה מצבעונית לשחור לבן
        public void imgload()
        {
            Bitmap image = new Bitmap(@"C:\Users\נטלי\Desktop\תוכנות הודיה\Digivert-master\Digivert\ex1.JPG ");
            Bitmap BlackAndWhite = new Bitmap(@"C:\Users\נטלי\Desktop\תוכנות הודיה\Digivert-master\Digivert\ex1.JPG ");
            //var i = Image.FromFile(pathimage);
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color color = image.GetPixel(x, y);
                    var ava = (color.R + color.B + color.G) / 3;
                    // image.SetPixel(x,y,Color.FromArgb(color.A,ava,ava,ava));
                    int temp;
                    if (ava > 128)
                        temp = 255;

                    else
                    {
                        temp = 0;
                    }

                    BlackAndWhite.SetPixel(x, y, Color.FromArgb(color.A, temp, temp, temp));


                }




            }
            string newPath = @"C:\Users\נטלי\Desktop\תוכנות הודיה\Digivert-master\Digivert\ex2.JPG";

            BlackAndWhite.Save(newPath, ImageFormat.Png);

        }//מייצא לי את הביטים השחורים בתמונה
        public void extractXY()
        {
            Bitmap bitmap;
            using (Stream bmpStream = System.IO.File.Open(@"C:\Users\נטלי\Desktop\תוכנות הודיה\Digivert-master\Digivert\ex2.JPG", System.IO.FileMode.Open))
            {
                Image image = Image.FromStream(bmpStream);
                bitmap = new Bitmap(image);
            }

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);
                    Console.WriteLine(pixelColor);
                    Console.ReadLine();
                    // check if it's black or a shade of black
                    // e.g. if it belongs to an array of colors..etc
                    // if so, record the coordinates (x,y)

                }
            }
        }
    }

    


}





