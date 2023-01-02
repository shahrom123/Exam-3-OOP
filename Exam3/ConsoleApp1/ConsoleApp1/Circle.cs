
namespace ConsoleApp1
{
    public class Circle
    {

        public double _radius;
        public const double _pi = 3.14;
        public Circle(){}
        public Circle(double radius)
        {
            _radius = radius;

        }
        public double GetRadius()
        {
            return _radius;
        }
        public void SetRadius(double radius)
        {
            _radius = radius; 
        }
        public void GetArea()
        {
            Console.WriteLine(_radius * _radius * double.Pi);

        }
        public  double GetCircumference()
        {
            return 2 * _pi * _radius;
        }
        public string ToString()
        {
            return _radius.ToString();
        }

    }
}
