using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Generation.Ressources
{
    public class RessourceBatch : IRessourceBatch
    {
        private List<IRessource> ressources = new List<IRessource>();
        public void Add(IRessource r)
        {
            this.ressources.Add(r);
        }

        public List<IRessource> Get()
        {
            return ressources;
        }
    }
}
