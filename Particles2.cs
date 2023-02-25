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
    public partial class Particles2 : Form
    {
        /*
         * Background image of Vita Leonis in Unsplash: https://unsplash.com/es/fotos/ZfRMc1_RUuA
         * Water Drop image retrieved from: https://www.freeiconspng.com/img/46380
         * For using this Form it is necessary to set it on the method Application.Run() of the Program class.*/

        Canvas2 canvas;
        
        public Particles2()
        {
            InitializeComponent();
        }

        private void Particles2_Load(object sender, EventArgs e)
        {
            canvas = new Canvas2(PCT_CANVAS);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            canvas.CreateWaterDrop();
        }
    }
}
