using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace FlappyBirdForSkillshare
{
    public partial class Form1 : Form
    {

        SoundPlayer jumpmusic = new SoundPlayer(@"C:\Users\realcjsphotography\OneDrive\Desktop\Resources\jump.wav");
        SoundPlayer crashmusic = new SoundPlayer(@"C:\Users\realcjsphotography\OneDrive\Desktop\Resources\crash.wav");


        int gravity = 8;
        int pipespeed = 8;
        int score = 0;



        public Form1()
        {
            InitializeComponent();
            restart.Hide();
        }

        private void gamekeysup(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void gamekeysdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -10;
                jumpmusic.Play();
            }
        }

        private void gametimerevent(object sender, EventArgs e)
        {
            flappybird.Top += gravity;
            pipebottom.Left -= pipespeed;
            pipetop.Left -= pipespeed;
            scoretext.Text = "Score :" + score;

            if(pipebottom.Left < - 150)
            {
                pipebottom.Left = 530;
                score++;
            }

            if (pipetop.Left < -180)
            {
                pipetop.Left = 510;
                score++;
            }

            if(flappybird.Bounds.IntersectsWith(pipebottom.Bounds) ||
                flappybird.Bounds.IntersectsWith(pipetop.Bounds) ||
                flappybird.Bounds.IntersectsWith(ground.Bounds)
                )
            {
                endGame();
                crashmusic.Play();
            }

            if(score > 10)

            {
                pipespeed = 15;
            }

            if(flappybird.Top < -25)
            {
                endGame();

            }


           
        }

        private void endGame()
        {
            gametimer.Stop();
            scoretext.Text = "Game Over!!!";
            restart.Show();
        }

        private void restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
