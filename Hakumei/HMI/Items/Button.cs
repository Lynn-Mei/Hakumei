using Logic;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMI.Items
{
    /// <summary>
    /// A standard graphical button
    /// <author>Lynn Mei</author>
    /// </summary>
    public class Button:Dimension,IDrawable
    {
        public Button(int x, int y, int h, int w):base(x,y,h,w)
        {
            
        }

        public void draw(SpriteBatch spriteBatch)
        {
            //spriteBatch.Draw();
        }
    }
}
