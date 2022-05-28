using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array =
            {
                      { 1, 24, 6, 7, 33, 5 },
                             { 3,5,7,6,3,7},
                           { 3,6,9,3,2,3}
            };
            int max;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                
                for (int j = 0; j < array.GetLength(0); j++)
                    max = array[i, 0];
                {
                if(array[i,0]<array[i,j])
                {
                    max = array[i, j];
                }
                Console.WriteLine(max);
            }
            



        } }

    }
            
        }
    

