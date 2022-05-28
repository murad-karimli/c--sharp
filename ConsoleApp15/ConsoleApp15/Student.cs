using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    class Student
    {
        public int lessonsinaweek;
        public int absence;
        static bool absen(int hours,int absence1)
        {
            if(hours/8>=absence1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Student(int a, int b)
        {
            a = lessonsinaweek;
            b = absence;
            if (Student.absen(a,b))
            {
                Console.WriteLine("kesilmemisiz");
            }
            else
            {
                Console.WriteLine("kesildiniz");
            }
        }
        

    }
}

        
    

