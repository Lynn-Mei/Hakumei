using Logic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace HMI.Items
{
    /// <summary>
    /// An interface that generalizes the drawing behaviour of a graphic item
    /// <author>Lynn Mei</author>
    /// </summary>
    public interface IDrawable
    {
        /// <summary>
        /// Standard Method to draw a graphical item
        /// </summary>
        /// <author>Lynn Mei</author>
        /// <returns>Success of the operation</returns>
        public void draw(SpriteBatch spriteBatch);

    }
}
