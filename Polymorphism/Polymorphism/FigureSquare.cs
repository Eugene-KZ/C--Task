using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class FigureSquare:Figure
    {
        private double sideA;

        public double SideA
        {
            get { return sideA; }
        }





        public FigureSquare(double sideA)
        {
            this.sideA = sideA;
        }

        public override void Square()
        {
            double s;
            s = Math.Pow(sideA, 2);
            Console.WriteLine($"Площадь квадрата со стороной {sideA} равна {Math.Round(s, 2)}");
        }
    }
}
