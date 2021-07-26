using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsAbstractFactory
{
    abstract class AbstractFactory
    {
        public abstract AbstractWater CreateWarter();
        public abstract AbstractCover CreateCover();
        public abstract AbstractBottle CreateBottle();
        public abstract AbstractEtiketka CreateEtiket();
       
    }
}
