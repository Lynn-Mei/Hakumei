using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMI
{
    public class GameScreen:Game1
    {
        private IRessourceBatch ressources;
        public IRessourceBatch Ressources { get { return ressources; } }
        public GameScreen()
        {
            this.UnitTestGetRessourceBatch();
        }

        public void Replace(GameScreen gameScreen)
        {
            base.GameScreen = gameScreen;
            base.LoadContent();
        }

        private void UnitTestGetRessourceBatch()
        {
            ressources = new RessourceBatch();
            //Make a unit test
            
        }

    }
}
