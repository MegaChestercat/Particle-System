
using System.Collections.Generic;
using System.Drawing;
using System;
using System.Windows.Forms;

namespace Particles1
{
    public class Canvas2
    {

        static Bitmap bmp;
        static Graphics g;
        PictureBox pct;
        List<Particle2> waterDrops;
        static Random rand = new Random();
        static int lifeSpan = 100;

        public Canvas2(PictureBox pct)
        {
            waterDrops = new List<Particle2>();
            this.pct = pct;
            bmp = new Bitmap(pct.Width, pct.Height);
            g = Graphics.FromImage(bmp);
            pct.Image = bmp;

            for (int i = 0; i < 100; i++)
            {
                waterDrops.Add(new Particle2(rand, bmp.Size, lifeSpan));
            }
            g.DrawImage(Resources.bg, 0, 0);
        }

        public void CreateWaterDrop()
        {
            g.Clear(Color.Black);
            g.DrawImage(Resources.bg, 0, 0);
            Particle2 p;

            for (int i = 0; i < waterDrops.Count; i++)
            {
                waterDrops[i].MoveParticle(pct);
                p = waterDrops[i];

                switch (p.color) //Here depending the color and the transparency it will be the particle that it will be drawn on the canvas.
                {
                    case 1:
                        if (p.transparency == 255 || (p.transparency < 255 && p.transparency > 127)) g.DrawImage(Resources.waterDropBlue255, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 127 || (p.transparency < 127 && p.transparency > 64)) g.DrawImage(Resources.waterDropBlue127, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 64 || (p.transparency < 64 && p.transparency > 32)) g.DrawImage(Resources.waterDropBlue64, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 32 || (p.transparency < 32 && p.transparency > 16)) g.DrawImage(Resources.waterDropBlue32, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 16 || (p.transparency < 16 && p.transparency > 8)) g.DrawImage(Resources.waterDropBlue16, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 8 || (p.transparency < 8 && p.transparency > 0)) g.DrawImage(Resources.waterDropBlue8, p.p.X, p.p.Y, p.r, p.r);
                        break;
                    case 2:
                        if (p.transparency == 255 || (p.transparency < 255 && p.transparency > 127)) g.DrawImage(Resources.waterDropRed255, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 127 || (p.transparency < 127 && p.transparency > 64)) g.DrawImage(Resources.waterDropRed127, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 64 || (p.transparency < 64 && p.transparency > 32)) g.DrawImage(Resources.waterDropRed64, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 32 || (p.transparency < 32 && p.transparency > 16)) g.DrawImage(Resources.waterDropRed32, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 16 || (p.transparency < 16 && p.transparency > 8)) g.DrawImage(Resources.waterDropRed16, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 8 || (p.transparency < 8 && p.transparency > 0)) g.DrawImage(Resources.waterDropRed8, p.p.X, p.p.Y, p.r, p.r);
                        break;
                    case 3:
                        if (p.transparency == 255 || (p.transparency < 255 && p.transparency > 127)) g.DrawImage(Resources.waterDropGreen255, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 127 || (p.transparency < 127 && p.transparency > 64)) g.DrawImage(Resources.waterDropGreen127, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 64 || (p.transparency < 64 && p.transparency > 32)) g.DrawImage(Resources.waterDropGreen64, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 32 || (p.transparency < 32 && p.transparency > 16)) g.DrawImage(Resources.waterDropGreen32, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 16 || (p.transparency < 16 && p.transparency > 8)) g.DrawImage(Resources.waterDropGreen16, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 8 || (p.transparency < 8 && p.transparency > 0)) g.DrawImage(Resources.waterDropGreen8, p.p.X, p.p.Y, p.r, p.r);
                        break;
                    case 4:
                        if (p.transparency == 255 || (p.transparency < 255 && p.transparency > 127)) g.DrawImage(Resources.waterDropBrown255, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 127 || (p.transparency < 127 && p.transparency > 64)) g.DrawImage(Resources.waterDropBrown127, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 64 || (p.transparency < 64 && p.transparency > 32)) g.DrawImage(Resources.waterDropBrown64, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 32 || (p.transparency < 32 && p.transparency > 16)) g.DrawImage(Resources.waterDropBrown32, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 16 || (p.transparency < 16 && p.transparency > 8)) g.DrawImage(Resources.waterDropBrown16, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 8 || (p.transparency < 8 && p.transparency > 0)) g.DrawImage(Resources.waterDropBrown8, p.p.X, p.p.Y, p.r, p.r);
                        break;
                    case 5:
                        if (p.transparency == 255 || (p.transparency < 255 && p.transparency > 127)) g.DrawImage(Resources.waterDropWhite255, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 127 || (p.transparency < 127 && p.transparency > 64)) g.DrawImage(Resources.waterDropWhite127, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 64 || (p.transparency < 64 && p.transparency > 32)) g.DrawImage(Resources.waterDropWhite64, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 32 || (p.transparency < 32 && p.transparency > 16)) g.DrawImage(Resources.waterDropWhite32, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 16 || (p.transparency < 16 && p.transparency > 8)) g.DrawImage(Resources.waterDropWhite16, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 8 || (p.transparency < 8 && p.transparency > 0)) g.DrawImage(Resources.waterDropWhite8, p.p.X, p.p.Y, p.r, p.r);
                        break;
                    case 6:
                        if (p.transparency == 255 || (p.transparency < 255 && p.transparency > 127)) g.DrawImage(Resources.waterDropGray255, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 127 || (p.transparency < 127 && p.transparency > 64)) g.DrawImage(Resources.waterDropGray127, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 64 || (p.transparency < 64 && p.transparency > 32)) g.DrawImage(Resources.waterDropGray64, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 32 || (p.transparency < 32 && p.transparency > 16)) g.DrawImage(Resources.waterDropGray32, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 16 || (p.transparency < 16 && p.transparency > 8)) g.DrawImage(Resources.waterDropGray16, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 8 || (p.transparency < 8 && p.transparency > 0)) g.DrawImage(Resources.waterDropGray8, p.p.X, p.p.Y, p.r, p.r);
                        break;
                    case 7:
                        break;
                    default:
                        if (p.transparency == 255 || (p.transparency < 255 && p.transparency > 127)) g.DrawImage(Resources.waterDropPurple255, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 127 || (p.transparency < 127 && p.transparency > 64)) g.DrawImage(Resources.waterDropPurple127, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 64 || (p.transparency < 64 && p.transparency > 32)) g.DrawImage(Resources.waterDropPurple64, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 32 || (p.transparency < 32 && p.transparency > 16)) g.DrawImage(Resources.waterDropPurple32, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 16 || (p.transparency < 16 && p.transparency > 8)) g.DrawImage(Resources.waterDropPurple16, p.p.X, p.p.Y, p.r, p.r);
                        else if (p.transparency == 8 || (p.transparency < 8 && p.transparency > 0)) g.DrawImage(Resources.waterDropPurple8, p.p.X, p.p.Y, p.r, p.r);
                        break;
                }
            }
            pct.Invalidate();
        }
    }
}