using System.Drawing;

namespace Langton
{
    class RuleLLRRRLRLRLLR : Form1
    {
        public static void MoveUp()
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
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(255, 0, 0));
                xBlack += 1;
                if (xBlack > 399)
                {
                    xBlack = 0;
                }
                directionBlack = 2;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(255, 0, 0))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(255, 140, 0));
                xBlack += 1;
                if (xBlack > 399)
                {
                    xBlack = 0;
                }
                directionBlack = 2;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(255, 140, 0))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(124, 252, 0));
                xBlack += 1;
                if (xBlack > 399)
                {
                    xBlack = 0;
                }
                directionBlack = 2;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(124, 252, 0))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(255, 20, 147));
                xBlack -= 1;
                if (xBlack < 0)
                {
                    xBlack = 399;
                }
                directionBlack = 4;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(255, 20, 147))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(0, 100, 0));
                xBlack += 1;
                if (xBlack > 399)
                {
                    xBlack = 0;
                }
                directionBlack = 2;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(0, 100, 0))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(148, 0, 211));
                xBlack -= 1;
                if (xBlack < 0)
                {
                    xBlack = 399;
                }
                directionBlack = 4;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(148, 0, 211))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(160, 82, 45));
                xBlack += 1;
                if (xBlack > 399)
                {
                    xBlack = 0;
                }
                directionBlack = 2;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(160, 82, 45))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(75, 0, 130));
                xBlack -= 1;
                if (xBlack < 0)
                {
                    xBlack = 399;
                }
                directionBlack = 4;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(75, 0, 130))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(30, 114, 255));
                xBlack -= 1;
                if (xBlack < 0)
                {
                    xBlack = 399;
                }
                directionBlack = 4;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(30, 114, 255))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(0, 255, 255));
                xBlack += 1;
                if (xBlack > 399)
                {
                    xBlack = 0;
                }
                directionBlack = 2;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(0, 255, 255))
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
        public static void MoveRight()
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
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(255, 0, 0));
                yBlack += 1;
                if (yBlack > 399)
                {
                    yBlack = 0;
                }
                directionBlack = 3;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(255, 0, 0))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(255, 140, 0));
                yBlack += 1;
                if (yBlack > 399)
                {
                    yBlack = 0;
                }
                directionBlack = 3;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(255, 140, 0))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(124, 252, 0));
                yBlack += 1;
                if (yBlack > 399)
                {
                    yBlack = 0;
                }
                directionBlack = 3;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(124, 252, 0))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(255, 20, 147));
                yBlack -= 1;
                if (yBlack < 0)
                {
                    yBlack = 399;
                }
                directionBlack = 1;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(255, 20, 147))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(0, 100, 0));
                yBlack += 1;
                if (yBlack > 399)
                {
                    yBlack = 0;
                }
                directionBlack = 3;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(0, 100, 0))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(148, 0, 211));
                yBlack -= 1;
                if (yBlack < 0)
                {
                    yBlack = 399;
                }
                directionBlack = 1;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(148, 0, 211))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(160, 82, 45));
                yBlack += 1;
                if (yBlack > 399)
                {
                    yBlack = 0;
                }
                directionBlack = 3;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(160, 82, 45))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(75, 0, 130));
                yBlack -= 1;
                if (yBlack < 0)
                {
                    yBlack = 399;
                }
                directionBlack = 1;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(75, 0, 130))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(30, 114, 255));
                yBlack -= 1;
                if (yBlack < 0)
                {
                    yBlack = 399;
                }
                directionBlack = 1;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(30, 114, 255))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(0, 255, 255));
                yBlack += 1;
                if (yBlack > 399)
                {
                    yBlack = 0;
                }
                directionBlack = 3;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(0, 255, 255))
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
        public static void MoveDown()
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
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(255, 0, 0));
                xBlack -= 1;
                if (xBlack < 0)
                {
                    xBlack = 399;
                }
                directionBlack = 4;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(255, 0, 0))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(255, 140, 0));
                xBlack -= 1;
                if (xBlack < 0)
                {
                    xBlack = 399;
                }
                directionBlack = 4;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(255, 140, 0))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(124, 252, 0));
                xBlack -= 1;
                if (xBlack < 0)
                {
                    xBlack = 399;
                }
                directionBlack = 4;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(124, 252, 0))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(255, 20, 147));
                xBlack += 1;
                if (xBlack > 399)
                {
                    xBlack = 0;
                }
                directionBlack = 2;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(255, 20, 147))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(0, 100, 0));
                xBlack -= 1;
                if (xBlack < 0)
                {
                    xBlack = 399;
                }
                directionBlack = 4;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(0, 100, 0))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(148, 0, 211));
                xBlack += 1;
                if (xBlack > 399)
                {
                    xBlack = 0;
                }
                directionBlack = 2;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(148, 0, 211))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(160, 82, 45));
                xBlack -= 1;
                if (xBlack < 0)
                {
                    xBlack = 399;
                }
                directionBlack = 4;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(160, 82, 45))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(75, 0, 130));
                xBlack += 1;
                if (xBlack > 399)
                {
                    xBlack = 0;
                }
                directionBlack = 2;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(75, 0, 130))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(30, 114, 255));
                xBlack += 1;
                if (xBlack > 399)
                {
                    xBlack = 0;
                }
                directionBlack = 2;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(30, 114, 255))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(0, 255, 255));
                xBlack -= 1;
                if (xBlack < 0)
                {
                    xBlack = 399;
                }
                directionBlack = 4;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(0, 255, 255))
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
        public static void MoveLeft()
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
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(255, 0, 0));
                yBlack -= 1;
                if (yBlack < 0)
                {
                    yBlack = 399;
                }
                directionBlack = 1;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(255, 0, 0))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(255, 140, 0));
                yBlack -= 1;
                if (yBlack < 0)
                {
                    yBlack = 399;
                }
                directionBlack = 1;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(255, 140, 0))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(124, 252, 0));
                yBlack -= 1;
                if (yBlack < 0)
                {
                    yBlack = 399;
                }
                directionBlack = 1;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(124, 252, 0))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(255, 20, 147));
                yBlack += 1;
                if (yBlack > 399)
                {
                    yBlack = 0;
                }
                directionBlack = 3;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(255, 20, 147))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(0, 100, 0));
                yBlack -= 1;
                if (yBlack < 0)
                {
                    yBlack = 399;
                }
                directionBlack = 1;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(0, 100, 0))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(148, 0, 211));
                yBlack += 1;
                if (yBlack > 399)
                {
                    yBlack = 0;
                }
                directionBlack = 3;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(148, 0, 211))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(160, 82, 45));
                yBlack -= 1;
                if (yBlack < 0)
                {
                    yBlack = 399;
                }
                directionBlack = 1;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(160, 82, 45))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(75, 0, 130));
                yBlack += 1;
                if (yBlack > 399)
                {
                    yBlack = 0;
                }
                directionBlack = 3;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(75, 0, 130))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(30, 114, 255));
                yBlack += 1;
                if (yBlack > 399)
                {
                    yBlack = 0;
                }
                directionBlack = 3;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(30, 114, 255))
            {
                bmp.SetPixel(xBlack, yBlack, Color.FromArgb(0, 255, 255));
                yBlack -= 1;
                if (yBlack < 0)
                {
                    yBlack = 399;
                }
                directionBlack = 1;
                return;
            }
            if (bmp.GetPixel(xBlack, yBlack) == Color.FromArgb(0, 255, 255))
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
    }
}
