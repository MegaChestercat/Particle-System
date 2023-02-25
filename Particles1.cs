using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Particles1
{
    public partial class Particles1 : Form
    {

        //For using this Form it is necessary to set it on the method Application.Run() of the Program class.

        Canvas canvas;

        public Particles1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            canvas = new Canvas(PCT_CANVAS);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            canvas.CreateParticle();
        }
    }
}
