using System.Drawing;

namespace Langton
{
    class RuleRL : Form1
    {
        public static void MoveUp()
        {
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(255, 255, 255))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(0, 0, 0));
                xBlack += 1;
                if (xBlack > 399)
                {
                    xBlack = 0;
                }
                directionBlack = 2;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(0, 0, 0))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(0, 191, 255));
                xBlack -= 1;
                if (xBlack < 0)
                {
                    xBlack = 399;
                }
                directionBlack = 4;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(0, 191, 255))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(0, 0, 0));
                xBlack += 1;
                if (xBlack > 399)
                {
                    xBlack = 0;
                }
                directionBlack = 2;
                return;
            }
        }
        public static void MoveRight()
        {
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(255, 255, 255))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(0, 0, 0));
                yBlack += 1;
                if (yBlack > 399)
                {
                    yBlack = 0;
                }
                directionBlack = 3;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(0, 0, 0))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(0, 191, 255));
                yBlack -= 1;
                if (yBlack < 0)
                {
                    yBlack = 399;
                }
                directionBlack = 1;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(0, 191, 255))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(0, 0, 0));
                yBlack += 1;
                if (yBlack > 399)
                {
                    yBlack = 0;
                }
                directionBlack = 3;
                return;
            }
        }
        public static void MoveDown()
        {
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(255, 255, 255))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(0, 0, 0));
                xBlack -= 1;
                if (xBlack < 0)
                {
                    xBlack = 399;
                }
                directionBlack = 4;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(0, 0, 0))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(0, 191, 255));
                xBlack += 1;
                if (xBlack > 399)
                {
                    xBlack = 0;
                }
                directionBlack = 2;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(0, 191, 255))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(0, 0, 0));
                xBlack -= 1;
                if (xBlack < 0)
                {
                    xBlack = 399;
                }
                directionBlack = 4;
                return;
            }
        }
        public static void MoveLeft()
        {
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(255, 255, 255))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(0, 0, 0));
                yBlack -= 1;
                if (yBlack < 0)
                {
                    yBlack = 399;
                }
                directionBlack = 1;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(0, 0, 0))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(0, 191, 255));
                yBlack += 1;
                if (yBlack > 399)
                {
                    yBlack = 0;
                }
                directionBlack = 3;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(0, 191, 255))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(0, 0, 0));
                yBlack -= 1;
                if (yBlack < 0)
                {
                    yBlack = 399;
                }
                directionBlack = 1;
                return;
            }
        }
    }
}
