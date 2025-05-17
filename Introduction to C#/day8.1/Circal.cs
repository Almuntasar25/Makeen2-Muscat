using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8._1
{
    public class Circal : Shape
    {
        public const double PI = 3.14;
        public double radius { get; set; }

        public Circal(double radius, string name, string color) : base(name, color)
        {
            this.radius = radius;
        }
        public double Area()
        {
            return PI * radius * radius;
        }
        public override string ToString()
        {

            return base.ToString();

        }
    }
}
