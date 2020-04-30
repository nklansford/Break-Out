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
    /// A generic wall for more specific walls to inherit from
    /// </summary>
    public class Wall : PictureBox
    {
        public bool DoesBounce { get; set; }
        
        public Wall()
        {
            DoesBounce = true;
        }

        public virtual void WallHit()
        {
            
        }
    }
}
