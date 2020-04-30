using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakOut
{
    /// <summary>
    /// Noelle Lansford
    /// Jennifer Halder
    /// 
    /// The Game of Breakout
    /// </summary>
    public partial class Game : Form
    {
        ////////// Variables ///////////
        private int gameScore;
        List<Wall> allWalls;
        private int brickCounter;
        SoundPlayer backgroundMusic = new SoundPlayer(Resource1.background_music);
        SoundPlayer loseSound = new SoundPlayer(Resource1.loseSound);
        SoundPlayer winSound = new SoundPlayer(Resource1.winSound);

        ////////// Methods ///////////
        public Game()
        {
            InitializeComponent();
            UpdateScore(0);
            paddle.SetBounds(topWall.Bottom, bottomWall.Top);
            InitializeWallList();
            brickCounter = 55;
            backgroundMusic.PlayLooping();
        }

        public void InitializeWallList()
        {
            allWalls = new List<Wall>();
            allWalls.Add(paddle);
            allWalls.Add(losingWall);
            allWalls.Add(topWall);
            allWalls.Add(rightWall);
            allWalls.Add(bottomWall);
            allWalls.Add(brick1);
            allWalls.Add(brick2);
            allWalls.Add(brick3);
            allWalls.Add(brick4);
            allWalls.Add(brick5);
            allWalls.Add(brick6);
            allWalls.Add(brick7);
            allWalls.Add(brick8);
            allWalls.Add(brick9);
            allWalls.Add(brick10);
            allWalls.Add(brick11);
            allWalls.Add(brick12);
            allWalls.Add(brick13);
            allWalls.Add(brick14);
            allWalls.Add(brick15);
            allWalls.Add(brick16);
            allWalls.Add(brick17);
            allWalls.Add(brick18);
            allWalls.Add(brick19);
            allWalls.Add(brick20);
            allWalls.Add(brick21);
            allWalls.Add(brick22);
            allWalls.Add(brick23);
            allWalls.Add(brick24);
            allWalls.Add(brick25);
            allWalls.Add(brick26);
            allWalls.Add(brick27);
            allWalls.Add(brick28);
            allWalls.Add(brick29);
            allWalls.Add(brick30);
            allWalls.Add(brick31);
            allWalls.Add(brick32);
            allWalls.Add(brick33);
            allWalls.Add(brick34);
            allWalls.Add(brick35);
            allWalls.Add(brick36);
            allWalls.Add(brick37);
            allWalls.Add(brick38);
            allWalls.Add(brick39);
            allWalls.Add(brick40);
            allWalls.Add(brick41);
            allWalls.Add(brick42);
            allWalls.Add(brick43);
            allWalls.Add(brick44);
            allWalls.Add(brick45);
            allWalls.Add(brick46);
            allWalls.Add(brick47);
            allWalls.Add(brick48);
            allWalls.Add(brick49);
            allWalls.Add(brick50);
            allWalls.Add(brick51);
            allWalls.Add(brick52);
            allWalls.Add(brick53);
            allWalls.Add(brick54);
            allWalls.Add(brick55);
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
            ball.BallMove();
            paddle.Slide();

            if(paddle.Bounds.IntersectsWith(topWall.Bounds))
            {
                paddle.GoUp = false;
            }

            if(paddle.Bounds.IntersectsWith(bottomWall.Bounds))
            {
                paddle.GoDown = false;
            }

            foreach (Wall item in allWalls)
            {
                if(item.DoesBounce && ball.IsBallHitting(item))
                {
                    if(item is Brick)
                    {
                        item.DoesBounce = false;
                        item.Visible = false;
                        if (item.Tag == "points10")
                        {
                            UpdateScore(10);
                        }
                        else if(item.Tag == "points20")
                        {
                            UpdateScore(20);
                        }
                        else if(item.Tag == "points30")
                        {
                            UpdateScore(30);
                        }
                        else if(item.Tag == "points40")
                        {
                            UpdateScore(40);
                        }
                        else if(item.Tag == "points50")
                        {
                            UpdateScore(50);
                        }

                        brickCounter--;

                        if (brickCounter <= 0)
                        {
                            timer.Stop();
                            backgroundMusic.Stop();
                            YouWin.Visible = true;
                            winSound.Play();
                        }

                    }

                    else if(item is LosingWall)
                    {
                        timer.Stop();
                        backgroundMusic.Stop();
                        YouLose.Visible = true;
                        loseSound.Play();
                    }
                }
            }
        }
    }
}
