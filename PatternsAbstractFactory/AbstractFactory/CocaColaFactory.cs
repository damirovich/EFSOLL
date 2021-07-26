using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsAbstractFactory
{
    class CocaColaFactory:AbstractFactory
    {
        public override AbstractWater CreateWarter()
        {
            return new CocaColaWater();
        }
        public override AbstractCover CreateCover()
        {
            return new CocaColaCover();
        }
        public override AbstractBottle CreateBottle()
        {
            return new CocaColaBottle();
        }
        public override AbstractEtiketka CreateEtiket()
        {
            return new CocaColaEtiket();
        }

    }
}
