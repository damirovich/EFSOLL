using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsAbstractFactory
{
    abstract class AbstractBottle
    {
        public abstract void Interact(AbstractWater water, AbstractCover cover, AbstractEtiketka etiketka);
        public abstract void InteractCover(AbstractCover cover);
        public abstract void InteractEtiket(AbstractEtiketka etiketka);
    }
}
