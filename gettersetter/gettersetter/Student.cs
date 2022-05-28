using System;
using System.Collections.Generic;
using System.Text;

namespace gettersetter
{
    class Student
    {
        public static string name;
        public static string surname;
        private static string id;

        public Student(string aName, string aSurname, string aId)
        {
            name = aName;
            surname = aSurname;
            Id = aId;
        }
        public string Id
        {
            get { return id; }
            set
            {
                if(value.Length!=7)
                {
                    Console.WriteLine("Invalid Id");
                }
                else
                {
                    value = Id;
                    Console.WriteLine($"Welcome {name} {surname}");
                    
                }
            }
        }
       
      
    }
}
