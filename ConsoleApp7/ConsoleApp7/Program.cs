using System;

namespace ConsoleApp7
{
    class Program
    {
        public delegate void Triangle(int a);
        static void tr1(int i)
        {
            int j;
            while(i>0)
            {
                j = i;
                while(j>0)
                {
                    Console.Write(i);
                    j--;
                }
                Console.WriteLine();
                i--;
            }
        }

        static void Main(string[] args)
        {
            Triangle trs1 = new Triangle(tr1);
            trs1(10);
            
        }
    }
}
