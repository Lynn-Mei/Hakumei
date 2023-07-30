using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMI.Items
{
    /// <summary>
    /// An interface that generalizes the drawing behaviour of a graphic item
    /// <author>Lynn Mei</author>
    /// </summary>
    public abstract class IDrawable
    {
        private static int x;
        private static int y;

        /// <summary>
        /// Standard Method to draw a graphical item
        /// </summary>
        /// <author>Lynn Mei</author>
        /// <returns>Success of the operation</returns>
        public bool draw()
        {
            bool drawn = false;
            try
            {
                //draw
                drawn = true;
            }catch(Exception e)
            {
                drawn = false;
            }
            return drawn;
        }

    }
}
