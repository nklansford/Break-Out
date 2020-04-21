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
        int gameScore = 0;

        ////////// Events and Methods ///////////
        public BreakOut()
        {
            InitializeComponent();
            Paddle paddle = new Paddle();
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void score_Click(object sender, EventArgs e)
        {

        }

        // key up and down events used to be here, moved to paddle class

        private void timer_Tick(object sender, EventArgs e)
        {
            score.Text = "Score: " + gameScore;
        }
    }
}
