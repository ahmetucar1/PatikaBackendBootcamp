using System;
using System.Collections;
using Person;

namespace Pratik15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student Object
           Student student = new Student()
           {
              Name = "Ali",
              Surname = "Umur",
              StudentNumber = 123
           }; 

           //Teacher Object
           Teacher teacher = new Teacher()
           {
            Name = "Mustafa",
            Surname = "Azer",
            Salary = 20000
           };

           student.Introduction();
           teacher.Introduction();
        }
    }
}
