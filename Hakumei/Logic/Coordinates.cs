using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    /// <summary>
    /// Generalizes items which have a set of coordinates as attributes
    /// </summary>
    public class Coordinates
    {
        protected int x;
        protected int y;

        /// <summary>
        /// The Horizontal coordinate
        /// </summary>
        public int X { get { return x; } set { x = value; } }
        /// <summary>
        /// The Vertical coordinate
        /// </summary>
        public int Y { get { return y; } set { y = value; } }

        public Coordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        
        }
    }
}
