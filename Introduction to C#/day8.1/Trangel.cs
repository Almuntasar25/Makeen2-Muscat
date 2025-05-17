using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8._1
{
    internal class Trangel : Shape
    {
        public double hight { get; set; }
        public double width { get; set; }

        public Trangel(string name, string color, double hight, double width) : base(name, color)
        {
            this.hight = hight;
            this.width = width;
        }

        public double Area()
        {
            return 0.5 * hight * width;
        }
        public override string ToString()
        {

            return base.ToString();

        }
    }
}
