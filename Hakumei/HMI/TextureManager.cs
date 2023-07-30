using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HMI
{
    public class TextureManager
    {
        /*
         Developper note :
            Need to change the list to a dictionary
         
         
         */
        private static GraphicsDevice _device;
        private static List<Texture2D> textures2D = new List<Texture2D>();
        
        public static GraphicsDevice Device { get => _device; set { _device = value; } }

        public void AddTexture(Texture2D t)
        {
            textures2D.Add(t);
        }


    }
}
