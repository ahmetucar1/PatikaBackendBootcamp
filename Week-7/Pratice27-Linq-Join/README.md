LINQ GroupJoin Example

Overview

This project demonstrates how to use the GroupJoin method in C# LINQ to join two lists: Students and Classes. The GroupJoin method groups students based on their ClassId and associates them with their respective classes.

Technologies Used

C#

.NET Framework / .NET Core

LINQ

Code Explanation

Define Classes:

Students class contains StudentId, StudentName, and ClassId.

Classes class contains ClassId and ClassName.

Create Lists:

A list of students (student)

A list of classes (classes)

GroupJoin Method:

Joins students with their respective classes based on ClassId.

Groups students under their class.

Output Results:

Displays class names and lists students registered in each class.

Code Example

using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> student = new List<Students>
            {
                new Students {StudentId = 1, StudentName = "Hülya", ClassId = 1},
                new Students {StudentId = 2, StudentName = "İrem", ClassId = 1},
                new Students {StudentId = 3, StudentName = "Ali", ClassId = 1},
            };

            List<Classes> classes = new List<Classes>
            {
                new Classes {ClassId = 1, ClassName = "Bilgisayar"},
                new Classes {ClassId = 2, ClassName = "Matematik"}
            };

            var StudentAndClass = classes.GroupJoin(
                student,
                cls => cls.ClassId,
                std => std.ClassId,
                (class1, studentGroup) => new
                {
                    ClassName = class1.ClassName,
                    Students = studentGroup
                }
            );

            foreach (var s in StudentAndClass)
            {
                Console.WriteLine("Ders Adı: " + s.ClassName);
                Console.WriteLine("Derse kayıtlı olan öğrenciler:");
                
                foreach (var item in s.Students)
                {
                    Console.WriteLine(item.StudentName);
                }
                Console.WriteLine();
            }
        }
    }
}

How to Run

Open the project in Visual Studio or a .NET-supported IDE.

Compile and run the program.

The console will display the class names and the students enrolled in each class.

Expected Output

Ders Adı: Bilgisayar
Derse kayıtlı olan öğrenciler:
Hülya
İrem
Ali

Ders Adı: Matematik
Derse kayıtlı olan öğrenciler:

Author

Your Name

License

This project is open-source and can be used for educational purposes.

