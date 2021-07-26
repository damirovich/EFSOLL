using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsAbstractFactory
{
    class FantaFactory:AbstractFactory
    {
        public override AbstractWater CreateWarter()
        {
            return new FantaWarter();
        }
        public override AbstractCover CreateCover()
        {
            return new FantaCover();
        }
        public override AbstractBottle CreateBottle()
        {
            return new FantaBottle();
        }
        public override AbstractEtiketka CreateEtiket()
        {
            return new FantaEitket();
        }
    }
}
