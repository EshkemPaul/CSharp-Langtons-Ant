using System.Drawing;

namespace Langton
{
    class DarkOrangeDirections : Form1
    {
        public static void MoveUp()
        {
            if (bmp.GetPixel(xDarkOrange, yDarkOrange) == Color.FromArgb(255, 255, 255))
            {
                bmp.SetPixel(xDarkOrange, yDarkOrange, Color.FromArgb(255, 140, 0));
                xDarkOrange -= 1;
                if (xDarkOrange < 0)
                {
                    xDarkOrange = 399;
                }
                directionDarkOrange = 4;
            }
            else
            {
                bmp.SetPixel(xDarkOrange, yDarkOrange, Color.FromArgb(255, 255, 255));
                xDarkOrange += 1;
                if (xDarkOrange > 399)
                {
                    xDarkOrange = 0;
                }
                directionDarkOrange = 2;
            }
        }
        public static void MoveRight()
        {
            if (bmp.GetPixel(xDarkOrange, yDarkOrange) == Color.FromArgb(255, 255, 255))
            {
                bmp.SetPixel(xDarkOrange, yDarkOrange, Color.FromArgb(255, 140, 0));
                yDarkOrange -= 1;
                if (yDarkOrange < 0)
                {
                    yDarkOrange = 399;
                }
                directionDarkOrange = 1;
            }
            else
            {
                bmp.SetPixel(xDarkOrange, yDarkOrange, Color.FromArgb(255, 255, 255));
                yDarkOrange += 1;
                if (yDarkOrange > 399)
                {
                    yDarkOrange = 0;
                }
                directionDarkOrange = 3;
            }
        }
        public static void MoveDown()
        {
            if (bmp.GetPixel(xDarkOrange, yDarkOrange) == Color.FromArgb(255, 255, 255))
            {
                bmp.SetPixel(xDarkOrange, yDarkOrange, Color.FromArgb(255, 140, 0));
                xDarkOrange += 1;
                if (xDarkOrange > 399)
                {
                    xDarkOrange = 0;
                }
                directionDarkOrange = 2;
            }
            else
            {
                bmp.SetPixel(xDarkOrange, yDarkOrange, Color.FromArgb(255, 255, 255));
                xDarkOrange -= 1;
                if (xDarkOrange < 0)
                {
                    xDarkOrange = 399;
                }
                directionDarkOrange = 4;
            }
        }
        public static void MoveLeft()
        {
            if (bmp.GetPixel(xDarkOrange, yDarkOrange) == Color.FromArgb(255, 255, 255))
            {
                bmp.SetPixel(xDarkOrange, yDarkOrange, Color.FromArgb(255, 140, 0));
                yDarkOrange += 1;
                if (yDarkOrange > 399)
                {
                    yDarkOrange = 0;
                }
                directionDarkOrange = 3;
            }
            else
            {
                bmp.SetPixel(xDarkOrange, yDarkOrange, Color.FromArgb(255, 255, 255));
                yDarkOrange -= 1;
                if (yDarkOrange < 0)
                {
                    yDarkOrange = 399;
                }
                directionDarkOrange = 1;
            }
        }
    }
}
