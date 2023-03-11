namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(10);
            FigureSquare figureSquare = new FigureSquare(5);
            Rectangle rectangle = new Rectangle(3, 4);

            circle.Square();
            figureSquare.Square();
            rectangle.Square();
        }
    }
}