using System;
using System.Xml;

namespace _27_06_20_Decorator_design_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();

            Shape redCircle = new RedShapeDecorator(new Circle());

            Shape redrectangle = new RedShapeDecorator(new Rectangle());

            Console.WriteLine("Circle wirg normal border:");
            circle.Draw();
            Console.WriteLine();

            Console.WriteLine("Circle of red border:");
            redCircle.Draw();
            Console.WriteLine();

            Console.WriteLine("Rectangle of red border:");
            redrectangle.Draw();



        }
    }
}
