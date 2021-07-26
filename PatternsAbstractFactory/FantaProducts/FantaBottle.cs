using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsAbstractFactory
{
    class FantaBottle:AbstractBottle
    {
        public override void Interact(AbstractWater water, AbstractCover cover, AbstractEtiketka etiketka)
        {
            Console.WriteLine(this + " Бутылкага суу куйабыз " + water + " крышкасын жабазбыз " + cover + " Этикетка чаптайбыз " + etiketka);
        }
        public override void InteractCover(AbstractCover cover)
        {
            Console.WriteLine(this + "interactsCover with " + cover);
        }
        public override void InteractEtiket(AbstractEtiketka etiketka)
        {
            Console.WriteLine(this + "interactsEtikets with " + etiketka);
        }
    }
}
