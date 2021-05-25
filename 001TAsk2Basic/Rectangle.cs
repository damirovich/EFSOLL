using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001TAsk2Basic
{
    public class Rectangle
    {
        private double side1;
        private double side2;

        public double Area
        {
            get
            {
                return AreaCalcu();
            }
        }
        public double Perimeter
        {
            get
            {
                return PerimeterCalcu();
            }
        }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalcu() {
            return side1 * side2;
        }
        public double PerimeterCalcu() 
        {
            return (side1 + side2) * 2;
        }

    }
}
