using System;

namespace SolidPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {

            var rec = new Rectangle(3, 2);

            Rectangle a = new Square(5);

            a.Height = 6;

            Console.WriteLine($"Area is {rec.Area()}");
            Console.WriteLine($"Area is {a.Area()}");
        }
    }
}
