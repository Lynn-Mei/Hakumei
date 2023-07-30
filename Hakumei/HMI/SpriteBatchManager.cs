using HMI.Items;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HMI
{
    public class SpriteBatchManager
    {
        private static SpriteBatch spriteBatch;
        private List<IDrawable> drawables = new List<IDrawable>();

        public static SpriteBatch SpriteBatch { get => spriteBatch; set { spriteBatch = value; } }
        
        public void Begin()
        {
            spriteBatch.Begin();
        }

        public void End()
        {
            spriteBatch.End();
        }

        public void Add(IDrawable drawable)
        {
            drawables.Add(drawable);
        }

        public void Remove(IDrawable drawable)
        {
            drawables.Remove(drawable);
        }

        /// <summary>
        /// Draws all the drawables of the spritebatch
        /// </summary>
        public void Draw()
        {
            foreach(IDrawable drawable in drawables)
            {
                drawable.draw(spriteBatch);
            }
        }

    }
}
