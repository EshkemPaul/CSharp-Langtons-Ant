using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Langton
{
    class RedDirections : Form1
    {
        public static void MoveUp()
        {
            if (bmp.GetPixel(xRed, yRed) == Color.FromArgb(255, 255, 255))
            {
                bmp.SetPixel(xRed, yRed, Color.FromArgb(255, 0, 0));
                xRed -= 1;
                if (xRed < 0)
                {
                    xRed = 399;
                }
                directionRed = 4;
            }
            else
            {
                bmp.SetPixel(xRed, yRed, Color.FromArgb(255, 255, 255));
                xRed += 1;
                if (xRed > 399)
                {
                    xRed = 0;
                }
                directionRed = 2;
            }
        }
        public static void MoveRight()
        {
            if (bmp.GetPixel(xRed, yRed) == Color.FromArgb(255, 255, 255))
            {
                bmp.SetPixel(xRed, yRed, Color.FromArgb(255, 0, 0));
                yRed -= 1;
                if (yRed < 0)
                {
                    yRed = 399;
                }
                directionRed = 1;
            }
            else
            {
                bmp.SetPixel(xRed, yRed, Color.FromArgb(255, 255, 255));
                yRed += 1;
                if (yRed > 399)
                {
                    yRed = 0;
                }
                directionRed = 3;
            }
        }
        public static void MoveDown()
        {
            if (bmp.GetPixel(xRed, yRed) == Color.FromArgb(255, 255, 255))
            {
                bmp.SetPixel(xRed, yRed, Color.FromArgb(255, 0, 0));
                xRed += 1;
                if (xRed > 399)
                {
                    xRed = 0;
                }
                directionRed = 2;
            }
            else
            {
                bmp.SetPixel(xRed, yRed, Color.FromArgb(255, 255, 255));
                xRed -= 1;
                if (xRed < 0)
                {
                    xRed = 399;
                }
                directionRed = 4;
            }
        }
        public static void MoveLeft()
        {
            if (bmp.GetPixel(xRed, yRed) == Color.FromArgb(255, 255, 255))
            {
                bmp.SetPixel(xRed, yRed, Color.FromArgb(255, 0, 0));
                yRed += 1;
                if (yRed > 399)
                {
                    yRed = 0;
                }
                directionRed = 3;
            }
            else
            {
                bmp.SetPixel(xRed, yRed, Color.FromArgb(255, 255, 255));
                yRed -= 1;
                if (yRed < 0)
                {
                    yRed = 399;
                }
                directionRed = 1;
            }
        }
    }
}
