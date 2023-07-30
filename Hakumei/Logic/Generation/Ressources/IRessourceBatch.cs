using Logic.Generation.Ressources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMI
{
    public interface IRessourceBatch
    {
        public List<IRessource> Get();
        public void Add(IRessource r);
    }
}
