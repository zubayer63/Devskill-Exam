using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Student> student = new List<Student>
           {
               new Student(){name= "Rahim", age=29},
               new Student(){name= "Karim", age=30},
               new Student(){name= "Ashiq", age=23},
               new Student(){name= "Masud", age=30},
               new Student(){name= "Ashiq", age=30},



           };
            var sortList = student.OrderBy(s => s.name).ThenByDescending(s => s.age);
            foreach (var item in sortList)
            {
                Console.WriteLine(item.name + " " + item.age);
            }
        }
    }

    class Student
    {
        public string name
        {
            get;
            set;
        }
        public int age
        {
            get;
            set;
        }
    }
}
