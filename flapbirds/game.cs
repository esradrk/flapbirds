using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace flapbirds
{
    public partial class game : Form
    {
        int boruhizi = 8;
        int gravity = 10;
        int score = 0;
        gamestart games = new gamestart();
        public game(gamestart games)
        {
            InitializeComponent(); 
            this.games=games;
            this.games.Hide();     

        }

        private void timergameEvent(object sender, EventArgs e)
        {
           
            flappy.Top += gravity;
            borualt.Left -= boruhizi;
            boruust.Left -= boruhizi;
            skortext.Text = "Score: " + score;
            if (borualt.Left < -150)
            {
                borualt.Left = 800;
                score++;
            }
            if (boruust.Left < -180)
            {
                boruust.Left = 950;
                score++;
            }
            if (flappy.Bounds.IntersectsWith(borualt.Bounds) || flappy.Bounds.IntersectsWith(boruust.Bounds) || flappy.Bounds.IntersectsWith(ground.Bounds))
            {
                endgame();
            }
            if (score > 5)
            {
                boruhizi = 15;


            }
            if (flappy.Top < -25)
            {
                endgame();
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }
        private void endgame()
        {
            timergame.Stop(); 
            skortext.Text = "Game Over!";
        }

    }
}
