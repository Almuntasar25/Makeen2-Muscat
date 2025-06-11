using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace day8._1
{
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
}
    

