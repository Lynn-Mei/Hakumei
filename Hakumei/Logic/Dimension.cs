using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    /// <summary>
    /// Generalizes objects with height and weight property
    /// </summary>
    public class Dimension:Coordinates
    {
        private int height;
        private int width;

        public int Height { get { return height; } set { height = value; } }
        public int Width { get { return width; } set { width = value; } }

        public Dimension(int x, int y, int height, int width):base(x,y) 
        {
            this.height = height;
            this.width = width;
        }
    }
}
