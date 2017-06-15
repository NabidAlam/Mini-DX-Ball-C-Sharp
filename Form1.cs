using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        int speed = 3;
        int vdir = +1;
        int slide_speed = 10;


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
           
            
                ball.Top += (vdir*speed);
   
            
            
        }


         int hdir = +1;

        private void horz_Tick(object sender, EventArgs e)
        {
            if (ball.Left < 0)
            {
                hdir = +1;
                
            }

            else if (ball.Left > (this.Width - ball.Width) )
            {
                hdir = -1;
            }

            ball.Left += (hdir*speed);
            
        }

         bool _left = false;
         bool _right = false;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //active

            if (e.KeyCode==Keys.Right)
            {
                _right = true;
            }

            else if (e.KeyCode== Keys.Left)
            {
                _left = true;
            }

            else if (e.KeyCode== Keys.Escape)
            {
                //pause game
                
                vert.Enabled = horz.Enabled = false;
                
            }

            else if (e.KeyCode == Keys.End)
            {
                //resume game
                vert.Enabled = horz.Enabled = true;
                

            }



        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //inactive
            if (e.KeyCode==Keys.Left || e.KeyCode== Keys.Right)
            {
                _right = _left = false; 

            }

        }

        private void key_watch_Tick(object sender, EventArgs e)
        {
            if (_right && slider.Left< (this.Width- slider.Width))
            {
                slider.Left = slider.Left + 10;

            }

            else if (_left && slider.Left > 0)
            {
                slider.Left = slider.Left - 10;

            }
        }




    }
}
