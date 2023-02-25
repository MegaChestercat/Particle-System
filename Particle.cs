using System.Drawing;
using System.Windows.Forms;
using System;

namespace Particles1
{
    public class Particle
    {
        public int r;
        public PointF p, v;
        public Color c;
        public int lifeSpan, counter;
        static Random newLifeRnd;
        public Size xSize;

        public Particle(Random rnd, Size s, int lifeSpan)
        {
            p = new PointF(rnd.Next(60, s.Width - 60), 0); 
            xSize = s;
            r = rnd.Next(10, 50);
            v = new PointF(0, rnd.Next(5, 20));
            c = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            this.lifeSpan = counter = lifeSpan;
            newLifeRnd = rnd;
        }

        public void MoveParticle(PictureBox pct)
        {
            p.X += v.X;
            p.Y += v.Y;

            switch (lifeSpan) //Depending the lifeSpan value of each particle it will be the opacity it will have.
            {
                case 80:
                    c = Color.FromArgb(127, c.R, c.G, c.B);
                    break;
                case 60:
                    c = Color.FromArgb(64, c.R, c.G, c.B);
                    break;
                case 40:
                    c = Color.FromArgb(32, c.R, c.G, c.B);
                    break;
                case 20:
                    c = Color.FromArgb(16, c.R, c.G, c.B);
                    break;
                case 10:
                    c = Color.FromArgb(8, c.R, c.G, c.B);
                    break;
                case 0: //When the lifeSpan is 0 the particle will reset with a new color, size, position, and speed. The lifeSpan will reset again to 100.
                    p = new PointF(newLifeRnd.Next(60, xSize.Width - 60), 0);
                    r = newLifeRnd.Next(10, 50);
                    v = new PointF(0, newLifeRnd.Next(5, 20)); 
                    c = Color.FromArgb(newLifeRnd.Next(255), newLifeRnd.Next(255), newLifeRnd.Next(255));
                    lifeSpan = counter;
                    break;
                default:
                    break;
            }
            if (p.X < 0 || p.X + r > pct.Width) //When the particle goes beyond the limits of the canvas (in the x axis), it will reset with a new color, size, position, and speed. The lifeSpan will reset again to 100.
            {
                p = new PointF(newLifeRnd.Next(60, xSize.Width - 60), 0);
                r = newLifeRnd.Next(10, 50);
                v = new PointF(0, newLifeRnd.Next(5, 20));
                c = Color.FromArgb(newLifeRnd.Next(255), newLifeRnd.Next(255), newLifeRnd.Next(255));
                lifeSpan = counter;

            }
            if(p.Y + r > pct.Height + 70) //When the particle goes beyond the limits of the canvas (in the y axis), it will reset with a new color, size, position, and speed. The lifeSpan will reset again to 100.
            {
                p = new PointF(newLifeRnd.Next(60, xSize.Width - 60), 0);
                r = newLifeRnd.Next(10, 50);
                v = new PointF(0, newLifeRnd.Next(1, 20)); 
                c = Color.FromArgb(newLifeRnd.Next(255), newLifeRnd.Next(255), newLifeRnd.Next(255));
                lifeSpan = counter;
            }
            lifeSpan--;
        }
    }
}