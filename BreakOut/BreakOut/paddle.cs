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
    /// Adds capability for a movable paddle
    /// </summary>
    public class Paddle : Wall
    {
        ////////// Variables ///////////

        public bool GoUp { get; set; }
        public bool GoDown { get; set; }
        private int speed = 15;

        private int topBound;
        private int bottomBound;


        ////////// Events and Methods ///////////
        public void Slide()
        {
            if(GoUp)
            {
                if (Top > topBound)
                {
                    Top -= speed;
                }
            }

            if(GoDown)
            {
                if(Bottom < bottomBound)
                {
                    Top += speed;
                }
            }
        }

        public void SetBounds(int topBounds, int bottomBounds)
        {
            topBound = topBounds;
            bottomBound = bottomBounds;
        }
    }
}
