using System;

namespace ConsoleApp2
{
    class Program
    {
       static void print(int a)
        {
            Console.WriteLine($"| {a} |");
        }
        static void topla (int a ,int b)
        {
            print(a +b);
        }
        static void Main(string[] args)
        {
            int k = 7;
            int b = 26;
            topla(k,b);
            }
        }
    }

