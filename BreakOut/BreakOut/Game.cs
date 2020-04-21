using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakOut
{
    public partial class BreakOut : Form
    {
        ////////// Variables ///////////
        private int gameScore;

        ////////// Methods ///////////
        public BreakOut()
        {
            InitializeComponent();
            UpdateScore(0);
        }

        public void UpdateScore(int brickScore)
        {
            gameScore = gameScore + brickScore;
            score.Text = "Score: " + gameScore;
        }

        ////////// Events ///////////
        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void score_Click(object sender, EventArgs e)
        {

        }
        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                paddle.GoUp = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                paddle.GoDown = true;
            }
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                paddle.GoUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                paddle.GoDown = false;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            paddle.Slide();
        }
    }
}
