using System;

namespace gettersetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Student NewStudent = new Student("Murad", "Karimli", "1624322");
            Console.WriteLine(NewStudent.Id);
          
        }
    }
}
