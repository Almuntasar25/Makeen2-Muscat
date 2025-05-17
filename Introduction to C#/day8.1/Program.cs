namespace day8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circal c =new Circal("Circal","blue");
            Console.WriteLine(c);

            Trangel t = new Trangel("tringel", "red", 7);
            Console.WriteLine(t);
        }
    }

    public class Shape
    {
        public string name { get; set; }
        public string color { get; set; }

        public Shape(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public double Area()
        {
            return 0;
        }

        public override string ToString()
        {
            return $"This shape name {name} >> color is {color} + the area {Area()} ";
        }
    }

    public class Circal : Shape
    {
        public const double PI = 3.14;
        public double radius { get; set; }

        public Circal( double radius , string name , string color) :base (name , color)
        {
            this.radius = radius;
        }
        public  double Area()
        {
            return PI * radius * radius;
        }
        public override string  ToString()
        {

            return base.ToString();

        }
    }

    internal class Trangel : Shape
    {
        public double hight {  get; set; }
        public double width { get; set; }

        public Trangel(string name , string color ,double hight, double width) : base(name, color)
        {
            this.hight= hight;
            this.width= width;
        }

        public  double Area()
        {
            return 0.5 * hight * width;
        }
        public override string ToString()
        {

            return base.ToString() ;

        }
    }
}
