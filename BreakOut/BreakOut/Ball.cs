using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakOut
{
    /// <summary>
    /// Noelle Lansford
    /// Jennifer Halder
    /// 
    /// Adds capabilty for a ball that checks if it hits walls
    /// </summary>
    public class Ball : PictureBox
    {
        private int speedX;
        private int speedY;

        public Ball()
        {
            speedX = 12;
            speedY = 12;
        }

        public void BallMove()
        {
            Left += speedX;
            Top += speedY;
        }

        public bool IsBallHitting(Wall wall)
        {
            if (wall.Bounds.IntersectsWith(Bounds))
            {
                int leftDifference = Math.Abs(wall.Right - Left);
                int rightDifference = Math.Abs(wall.Left - Right);
                int topDifference = Math.Abs(wall.Top - Bottom);
                int bottomDifference = Math.Abs(wall.Bottom - Top);

                if(Math.Min(leftDifference, rightDifference) < Math.Min(topDifference, bottomDifference))
                {
                    speedX = -speedX;
                }
                else
                {
                    speedY = -speedY;
                }
                return true;
            }
            return false;
        }
    }
}
