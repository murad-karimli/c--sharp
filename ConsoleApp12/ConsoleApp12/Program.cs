using System;
namespace enum_example4
{
    class Program
    {
        public enum DayofWeek
        {
            Sunday = 1, Monday, Tuesday = 1, Wednesday, Thursday = 2, Friday, Saturday
        }
        static void Main(string[] args)
        {
            string[] values = Enum.GetNames(typeof(DayofWeek));
            for (int i=0;i<values.Length;i++)
            {
                Console.WriteLine(values[i]);
            }
            Console.WriteLine();
            int[] n = (int[])Enum.GetValues(typeof(DayofWeek));
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i]);
            }
            Console.ReadLine();
        }
    }
}