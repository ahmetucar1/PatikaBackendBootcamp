using System;

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
                                  student => student.ClassId,
                                  classes => classes.ClassId,
                                  (class1, studentGroup) => new 
                                  {
                                  ClassName = class1.ClassName,
                                  Student = studentGroup,
                                  }
                                 );

            foreach ( var s in StudentAndClass)
          {

            Console.WriteLine("Ders Adı: " +s.ClassName); 
            Console.WriteLine("Derse kayıtlı olan öğrenciler : " );

            foreach ( var item in s.Student)
          {
            Console.WriteLine(item.StudentName);
          }

          }
        }
    }
}
