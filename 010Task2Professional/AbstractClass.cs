using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010Task2Professional
{
    abstract class AbstractClass
    {
        protected abstract void Speed();
        protected abstract void Wheel();
        public void TemplateMethod() {
            this.Speed();
            this.Wheel();
        }

      
    }
    class Car : AbstractClass
    {
        protected override void Speed()
        {
            Console.WriteLine("Автомобиль едет со скоростью 120 км/ч");
        }
        protected override void Wheel()
        {
            Console.WriteLine("У автомобиля вращается все 4 колеса");
            Console.WriteLine(new string('-', 40));
        }
        
    }
    class Bike : AbstractClass {
        protected override void Speed()
        {
            Console.WriteLine("Мотоцикл едет со скоростью 150 км/ч");
        }
        protected override void Wheel()
        {
            Console.WriteLine("У мотоцикла вращается все 2 колеса");
        }
    }
  
}
