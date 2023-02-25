
using System.Drawing;
using System;
using System.Windows.Forms;

namespace Particles1
{
    public class Particle2
    {
        public int r, transparency, color;
        public PointF p, v;
        public Color c;

        public int lifeSpan, counter;
        static Random newLifeRnd;
        public Size xSize;

        public Particle2 (Random rnd, Size s, int lifeSpan)
        {
            p = new PointF(rnd.Next(60, s.Width - 60), 0); 
            color = rnd.Next(7);
            xSize = s;
            r = rnd.Next(10, 50);
            v = new PointF(0, rnd.Next(5, 20)); 
            this.lifeSpan = counter = lifeSpan;
            newLifeRnd = rnd;
            transparency = 255;
        }

        public void MoveParticle(PictureBox pct)
        {
            p.X += v.X;
            p.Y += v.Y;

            switch (lifeSpan) //Depending the lifeSpan value of each particle it will be the opacity it will have.
            {
                case 80:
                    transparency = 127;
                    break;
                case 60:
                    transparency = 64;
                    break;
                case 40:
                    transparency = 32;
                    break;
                case 20:
                    transparency = 16;
                    break;
                case 10:
                    transparency = 8;
                    break;
                case 0: //When the lifeSpan is 0 the particle will reset with a new color, size, position, and speed. The lifeSpan and transparency will reset again to 100 and 255 respectively.
                    p = new PointF(newLifeRnd.Next(60, xSize.Width - 60), 0);
                    r = newLifeRnd.Next(10, 50);
                    v = new PointF(0, newLifeRnd.Next(5, 20)); 
                    lifeSpan = counter;
                    transparency = 255;
                    color = newLifeRnd.Next(7);
                    break;
                default:
                    break;
            }
            if (p.X < 0 || p.X + 20 > pct.Width) //When the particle goes beyond the limits of the canvas (in the x axis), it will reset with a new color, size, position, and speed. The lifeSpan and transparency will reset again to 100 and 255 respectively.
            {
                p = new PointF(newLifeRnd.Next(60, xSize.Width - 60), 0);
                r = newLifeRnd.Next(10, 50);
                v = new PointF(0, newLifeRnd.Next(5, 20));
                lifeSpan = counter;
                transparency = 255;
                color = newLifeRnd.Next(7);

            }
            if (p.Y + 20 > pct.Height + 70) //When the particle goes beyond the limits of the canvas (in the y axis), it will reset with a new color, size, position, and speed. The lifeSpan and transparency will reset again to 100 and 255 respectively.
            {
                p = new PointF(newLifeRnd.Next(60, xSize.Width - 60), 0);
                r = newLifeRnd.Next(10, 50);
                v = new PointF(0, newLifeRnd.Next(5, 20)); 
                lifeSpan = counter;
                transparency = 255;
                color = newLifeRnd.Next(7);
            }
            lifeSpan--;
        }
    }
}