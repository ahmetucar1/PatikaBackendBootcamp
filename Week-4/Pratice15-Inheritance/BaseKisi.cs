namespace Person
{
    public abstract class BasePerson
    {
        //Properties
        public string Name { get; set; }
        public string Surname { get; set; }

        //Main Method
        public abstract void Introduction();
    }

    //Student Class
    public class Student:BasePerson
    {
        public int StudentNumber { get; set;}

        //Constructor Method
        public override void Introduction() 
        {
            Console.WriteLine($"Öğrenci Adı: {Name}\nÖğrenci Soyadı: {Surname}\nÖğrenci Numarası: {StudentNumber}");
        }
    }

     //Teacher Class
    public class Teacher:BasePerson
    {
        public decimal Salary { get; set; }

        //Constructor Method
        public override void Introduction()
        {
            Console.WriteLine($"Öğretmen Adı: {Name}\nÖğretmen Soyadı: {Surname}\nMaaş Bilgisi: {Salary}");
            
        }
    }
}