using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakOut
{
    public class Paddle : PictureBox
    {
        ////////// Variables ///////////

        public bool GoUp { get; set; }
        public bool GoDown { get; set; }
        private int speed = 15;



        ////////// Events and Methods ///////////
        public void Slide()
        {
            if(GoUp)
            {
                Top -= speed;
            }

            if(GoDown)
            {
                Top += speed;
            }
        }
    }
}
