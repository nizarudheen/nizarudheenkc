using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool jumping = false; 
        int pipeSpeed =10;
        int gravity = 10; 
        int Inscore = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {




            pipedown.Left -= pipeSpeed;
            pipeup.Left -= pipeSpeed;
            bird.Top += gravity;


            if (pipedown.Left < -80) 
            { 
                pipedown.Left = 1000; 
                Inscore += 1;
            } 
            else if(pipeup.Left < -95) 
            { 
                pipeup.Left = 1100; Inscore += 1;
            }
            if (bird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            } 
            else if (bird.Bounds.IntersectsWith(pipedown.Bounds)) 
            { 
                endGame();
            }
            else if(bird.Bounds.IntersectsWith(pipeup.Bounds))
            {
                endGame(); 
            }
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {  
                jumping = true;
                gravity = -5; 
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            { jumping = false;
                gravity = 5;
            }
        }
        private void endGame()
        { 
            timer1.Stop();
            txt_game_over.Visible = true;
            //endText1.Visible = true; endText2.Visible = true; gameDesigner.Visible = true; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
       
    }
}
