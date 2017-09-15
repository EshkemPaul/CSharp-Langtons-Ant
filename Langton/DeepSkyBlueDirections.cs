using System.Drawing;

namespace Langton
{
    class DeepSkyBlueDirections : Form1
    {
        public static void MoveUp()
        {
            if (bmp.GetPixel(xDeepSkyBlue, yDeepSkyBlue) == Color.FromArgb(255, 255, 255))
            {
                bmp.SetPixel(xDeepSkyBlue, yDeepSkyBlue, Color.FromArgb(0,191,255));
                xDeepSkyBlue -= 1;
                if (xDeepSkyBlue < 0)
                {
                    xDeepSkyBlue = 399;
                }
                directionDeepSkyBlue = 4;
            }
            else
            {
                bmp.SetPixel(xDeepSkyBlue, yDeepSkyBlue, Color.FromArgb(255, 255, 255));
                xDeepSkyBlue += 1;
                if (xDeepSkyBlue > 399)
                {
                    xDeepSkyBlue = 0;
                }
                directionDeepSkyBlue = 2;
            }
        }
        public static void MoveRight()
        {
            if (bmp.GetPixel(xDeepSkyBlue, yDeepSkyBlue) == Color.FromArgb(255, 255, 255))
            {
                bmp.SetPixel(xDeepSkyBlue, yDeepSkyBlue, Color.FromArgb(0,191,255));
                yDeepSkyBlue -= 1;
                if (yDeepSkyBlue < 0)
                {
                    yDeepSkyBlue = 399;
                }
                directionDeepSkyBlue = 1;
            }
            else
            {
                bmp.SetPixel(xDeepSkyBlue, yDeepSkyBlue, Color.FromArgb(255, 255, 255));
                yDeepSkyBlue += 1;
                if (yDeepSkyBlue > 399)
                {
                    yDeepSkyBlue = 0;
                }
                directionDeepSkyBlue = 3;
            }
        }
        public static void MoveDown()
        {
            if (bmp.GetPixel(xDeepSkyBlue, yDeepSkyBlue) == Color.FromArgb(255, 255, 255))
            {
                bmp.SetPixel(xDeepSkyBlue, yDeepSkyBlue, Color.FromArgb(0,191,255));
                xDeepSkyBlue += 1;
                if (xDeepSkyBlue > 399)
                {
                    xDeepSkyBlue = 0;
                }
                directionDeepSkyBlue = 2;
            }
            else
            {
                bmp.SetPixel(xDeepSkyBlue, yDeepSkyBlue, Color.FromArgb(255, 255, 255));
                xDeepSkyBlue -= 1;
                if (xDeepSkyBlue < 0)
                {
                    xDeepSkyBlue = 399;
                }
                directionDeepSkyBlue = 4;
            }
        }
        public static void MoveLeft()
        {
            if (bmp.GetPixel(xDeepSkyBlue, yDeepSkyBlue) == Color.FromArgb(255, 255, 255))
            {
                bmp.SetPixel(xDeepSkyBlue, yDeepSkyBlue, Color.FromArgb(0,191,255));
                yDeepSkyBlue += 1;
                if (yDeepSkyBlue > 399)
                {
                    yDeepSkyBlue = 0;
                }
                directionDeepSkyBlue = 3;
            }
            else
            {
                bmp.SetPixel(xDeepSkyBlue, yDeepSkyBlue, Color.FromArgb(255, 255, 255));
                yDeepSkyBlue -= 1;
                if (yDeepSkyBlue < 0)
                {
                    yDeepSkyBlue = 399;
                }
                directionDeepSkyBlue = 1;
            }
        }
    }
}
