using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Logic.Generation.Ressources
{
    public class Custom2dTexture:IRessource
    {
        public string Name { get => "Custom2dTexture"; }

        private int r=0;
        private int g=0;
        private int b=0;
        private int a=0;
        public void setColor(int r, int g, int b, int a)
        {
            this.r = r;
            this.g = g;
            this.b = b;
            this.a = a;
        }
        public int[] Color
        {
            get { return new int[] { r, g, b, a}; }
        }
    }
}
