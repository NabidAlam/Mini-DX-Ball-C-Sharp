using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_DX_Ball_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int vdir = +1;

        private void vert_Tick(object sender, EventArgs e)
        {
            if (ball.Top<0)
            {
                vdir = +1;
            }

            else if (ball.Top>(this.Height- ball.Height-slider.Height))
            {
                vdir = -1;
            }
            else
            {
                ball.Top += vdir;
   
            }
            
        }


        private int hdir = +1;

        private void horz_Tick(object sender, EventArgs e)
        {
            if (ball.Left < 0)
            {
                hdir = +1;
            }

            else if (ball.Left > (this.Width-ball.Width) )
            {
                hdir = -1;
            }

            else
            {
                ball.Height += hdir;
            }
        }




    }
}
