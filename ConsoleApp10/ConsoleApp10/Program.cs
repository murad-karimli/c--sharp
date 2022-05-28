using System;

namespace ConsoleApp10
{
    class Program
    {
        public delegate void Arr(int[,] a);
       
        static void zero(int [,]a)
        {
            int sum;
            for(int i=0; i<a.GetLength(0);i++)
            {
                sum = 0;
                for(int k=0;k<a.GetLength(1);k++)
                {
                    sum += a[i, k];
                }
                for(int j=0;j<a.GetLength(1);j++)
                {

                    if((i+j) >=a.GetLength(1))
                    {
                        if(a[i,j]==0)
                        {
                            a[i, j] = sum / a.GetLength(1);
                        }
                    }
                }

            }
        }

        static void Main(string[] args)
        {
           
            int[,] a =
                {

                {1,3,6,2,6,4 },
                {3,7,89,45,3,4},
                {1,27,4,3,7,1},
                {1,2,67,9,4,2},
                {2,6,8,4,2,7 }
            };
            Arr ZERO = new Arr(zero);
            ZERO(a);

        }
    }
}
