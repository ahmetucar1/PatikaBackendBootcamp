namespace Pratice16
{

    //Main Class
    public class BaseGeometricShape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        //Main Method
        public virtual void AreaCalculation()
        {
            int area = Width * Height;
            Console.WriteLine($"Alan = {area}");
        }
    }

     //Inheritance Square Class and base Method
    public class Square : BaseGeometricShape
    {
        public override void AreaCalculation()
        {
            base.AreaCalculation();
        }
    }

     //Inheritance Rectangle Class and base Method
    public class Rectangle : BaseGeometricShape
    {
        public override void AreaCalculation()
        {
            base.AreaCalculation();
        }
    }

     //Inheritance Square Class and ovirride Method
    public class RightTriangle : BaseGeometricShape
    {
        public override void AreaCalculation()
        {
            int area = (Width * Height) / 2;
            Console.WriteLine($"Alan = {area}");
        }
    }
}
