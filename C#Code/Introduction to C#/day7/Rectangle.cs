using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    internal class Rectangle
    {
        private readonly double length = 4;
        private readonly double width = 8;
        private readonly string color = "black";

        public Rectangle(string color) : this(3, 4, color)
{
    this.color = color;
}


        public Rectangle(double length, double width, string color)
        {
            // valedation 
            if (length > 0 && width > 0)
            {
                this.length = length;
                this.width = width;
                this.color = color;
            }
            else
            {

                this.length = length;
                this.width = width;
                this.color = color;
            }
        }


        public double Area(double length, double width)
        {
            return length * width;

        }

        public string getInfo()
        {
            return ($" length= {length} \n width= {width} \n color: {color} \n area = {Area(length, width)}");
        }


    }
}

