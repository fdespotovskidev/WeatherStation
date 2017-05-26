using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Drawing.Imaging;

namespace WeatherStation
{

    static class Utilities
    {
        public static float ToCelsius(float fahrenheitValue)
        {
            return (fahrenheitValue - 32.0f) * 5.0f / 9.0f;
        }

        public static float ToFahrenheit(float celsiusValue)
        {
            return celsiusValue * 9.0f / 5.0f + 32.0f;
        }

        public static Bitmap ChangeImageOpacity(Image image, float opacityValue)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            Graphics graphics = Graphics.FromImage(bmp);
            ColorMatrix colormatrix = new ColorMatrix();
            colormatrix.Matrix33 = opacityValue;
            ImageAttributes imgAttribute = new ImageAttributes();
            imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            graphics.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imgAttribute);
            graphics.Dispose();
            return bmp;
        }
    }
}
