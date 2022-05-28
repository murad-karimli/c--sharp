using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Triangle caculator2 = new Triangle(3, 4, 13);
            
            double HalfOfPerimeter = Triangle.Perimeter();
            if ((Triangle.TriangleChecker()==true))
            {
                Console.WriteLine(Triangle.Area(HalfOfPerimeter));
            }
            else
            {
                Console.WriteLine("It is not a triangle");
            }
                

        }
    }
}
