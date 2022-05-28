using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{

    class Triangle
    {
        private static double a;
        private static double b;
        private static double c;

        public static double Perimeter()
        {
            double p = (a + b + c) / 2;
            return p;
        }
        public static double Area(double p)
        {
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public static bool TriangleChecker()
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                return false;
            }   
            else
            {
                return true;
            }
                
        }

        public Triangle(double aSide1,double aSide2,double aSide3)
        {
            a = aSide1;
            b = aSide2;
            c = aSide3;
        }
    }




    
}
