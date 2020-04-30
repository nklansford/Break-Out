using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakOut
{
    public class Ball : PictureBox
    {
        private int speedX;
        private int speedY;

        public Ball()
        {
            speedX = 10;
            speedY = 10;
        }

        public void BallMove()
        {
            Left += speedX;
            Top += speedY;
        }

        public bool IsBallHitting(Wall wall)
        {
            if(Bounds.IntersectsWith(wall.Bounds))
            {
                return true;
            }
            return false;
            //if()
            //{
            //    ballX = -ballX;
            //    ballY = -ballY;
            //}
        }
    }
}
