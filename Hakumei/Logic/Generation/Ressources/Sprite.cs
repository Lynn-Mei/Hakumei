using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Generation.Ressources
{
    public class Sprite:IRessource
    {
        public string Name { get => "Sprite"; }

        private string filename;
        public string Filename { get => filename; set => filename = value; }
    }
}
