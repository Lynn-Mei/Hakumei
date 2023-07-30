using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Generation.Ressources
{
    public interface IRessourceBatch
    {
        public List<IRessource> Get();
        public void Add(IRessource r);
    }
}
