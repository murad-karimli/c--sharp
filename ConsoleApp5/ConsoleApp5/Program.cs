using System;

namespace ConsoleApp5
{
    class Program
    {
        enum Week
        { 
            monday=1,
            thusday,
            wednesday,
            fouthday,
            friday,
            saturday,
            sunday
        }
        public delegate void mathoo(int a, int b);

        static void topla(int a ,int b)
        {
            Console.WriteLine(a+b);
        }
        static void vur(int a,int b )
        {
            Console.WriteLine(a*b);
        }
        static void bol(int a, int b)
        {
            Console.WriteLine(a/b);
        }
        static void cix(int a, int b)
        {
            Console.WriteLine(a-b);
        }

        static void Main(string[] args)
        {
            
            mathoo emeller = new mathoo(topla);
            emeller += vur;
            emeller += bol;
            emeller += cix;
            emeller(40, 4);
           
    }
}
}
