using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Rectangle:FigureSquare
    {
        private double sideB;

        public Rectangle(double sideA, double sideB) : base(sideA)
        {
            this.sideB = sideB;
        }

        public override void Square()
        {
            double s;
            s = sideA * sideB;
            Console.WriteLine($"Площадь прямоугольника со сторонами {sideA}, {sideB} равна {Math.Round(s, 2)}");

        }
    }
}
