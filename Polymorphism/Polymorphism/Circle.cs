using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Circle:Figure
    {
        private double radius;
        public Circle(double radius)
        {  
            this.radius = radius;
        }

        public override void Square() 
        {
            double s;
            s = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Площадь круга с радиусом {radius} равна: {Math.Round(s, 2)}");

        }
    }
}
