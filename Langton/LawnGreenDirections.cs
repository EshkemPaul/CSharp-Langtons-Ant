using System.Drawing;

namespace Langton
{
    class LawnGreenDirections : Form1
    {
        public static void MoveUp()
        {
            if (bmp.GetPixel(xLawnGreen, yLawnGreen) == Color.FromArgb(255, 255, 255))
            {
                bmp.SetPixel(xLawnGreen, yLawnGreen, Color.FromArgb(124,252,0));
                xLawnGreen -= 1;
                if (xLawnGreen < 0)
                {
                    xLawnGreen = 399;
                }
                directionLawnGreen = 4;
            }
            else
            {
                bmp.SetPixel(xLawnGreen, yLawnGreen, Color.FromArgb(255, 255, 255));
                xLawnGreen += 1;
                if (xLawnGreen > 399)
                {
                    xLawnGreen = 0;
                }
                directionLawnGreen = 2;
            }
        }
        public static void MoveRight()
        {
            if (bmp.GetPixel(xLawnGreen, yLawnGreen) == Color.FromArgb(255, 255, 255))
            {
                bmp.SetPixel(xLawnGreen, yLawnGreen, Color.FromArgb(124,252,0));
                yLawnGreen -= 1;
                if (yLawnGreen < 0)
                {
                    yLawnGreen = 399;
                }
                directionLawnGreen = 1;
            }
            else
            {
                bmp.SetPixel(xLawnGreen, yLawnGreen, Color.FromArgb(255, 255, 255));
                yLawnGreen += 1;
                if (yLawnGreen > 399)
                {
                    yLawnGreen = 0;
                }
                directionLawnGreen = 3;
            }
        }
        public static void MoveDown()
        {
            if (bmp.GetPixel(xLawnGreen, yLawnGreen) == Color.FromArgb(255, 255, 255))
            {
                bmp.SetPixel(xLawnGreen, yLawnGreen, Color.FromArgb(124,252,0));
                xLawnGreen += 1;
                if (xLawnGreen > 399)
                {
                    xLawnGreen = 0;
                }
                directionLawnGreen = 2;
            }
            else
            {
                bmp.SetPixel(xLawnGreen, yLawnGreen, Color.FromArgb(255, 255, 255));
                xLawnGreen -= 1;
                if (xLawnGreen < 0)
                {
                    xLawnGreen = 399;
                }
                directionLawnGreen = 4;
            }
        }
        public static void MoveLeft()
        {
            if (bmp.GetPixel(xLawnGreen, yLawnGreen) == Color.FromArgb(255, 255, 255))
            {
                bmp.SetPixel(xLawnGreen, yLawnGreen, Color.FromArgb(124,252,0));
                yLawnGreen += 1;
                if (yLawnGreen > 399)
                {
                    yLawnGreen = 0;
                }
                directionLawnGreen = 3;
            }
            else
            {
                bmp.SetPixel(xLawnGreen, yLawnGreen, Color.FromArgb(255, 255, 255));
                yLawnGreen -= 1;
                if (yLawnGreen < 0)
                {
                    yLawnGreen = 399;
                }
                directionLawnGreen = 1;
            }
        }
    }
}
