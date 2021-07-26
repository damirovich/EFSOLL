using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsAbstractFactory
{
    class PepsiFactory:AbstractFactory
    {
        public override AbstractWater CreateWarter()
        {
            return new PepsiWater();
        }
        public override AbstractCover CreateCover()
        {
            return new PepsiCover();
        }
        public override AbstractBottle CreateBottle()
        {
            return new PepsiBottle();
        }
        public override AbstractEtiketka CreateEtiket()
        {
            return new PepsiEtiket();
        }
    }
}
