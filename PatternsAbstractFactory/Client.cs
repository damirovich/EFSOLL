using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsAbstractFactory
{
    class Client
    {
        private AbstractWater water;
        private AbstractCover cover;
        private AbstractBottle bottle;
        private AbstractEtiketka etiketka;

        public Client(AbstractFactory factory) {
            water = factory.CreateWarter();
            bottle = factory.CreateBottle();
            cover = factory.CreateCover();
            etiketka = factory.CreateEtiket();
        }
        public void Run() {
            bottle.Interact(water,cover,etiketka);

        }
    }
}
