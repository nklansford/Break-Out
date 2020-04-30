using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakOut
{
    public class Wall : PictureBox
    {
        public bool DoesBounce { get; set; }
        
        public Wall()
        {
            DoesBounce = true;
        }

        public virtual void WallHit()
        {
            // boink
        }
    }
}
