
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace Particles1
{
    public class Canvas
    {
        static Bitmap bmp;
        static Graphics g;
        PictureBox pct;
        List<Particle> particles;
        static Random rand = new Random();
        static int lifeSpan = 100;

        public Canvas(PictureBox pct)
        {
            particles = new List<Particle>();
            this.pct = pct;
            bmp = new Bitmap(pct.Width, pct.Height);
            g = Graphics.FromImage(bmp);
            pct.Image = bmp;

            for (int i = 0; i < 100; i++)
            {
                particles.Add(new Particle(rand, bmp.Size, lifeSpan));
            }
        }

        public void CreateParticle()
        {
            g.Clear(Color.Black);
            Particle p;
            for (int i = 0; i < particles.Count; i++)
            {
                particles[i].MoveParticle(pct);
                p = particles[i];
                g.FillEllipse(new SolidBrush(particles[i].c), p.p.X, p.p.Y, p.r, p.r);
              
            }
            pct.Invalidate();
        }
    }
}