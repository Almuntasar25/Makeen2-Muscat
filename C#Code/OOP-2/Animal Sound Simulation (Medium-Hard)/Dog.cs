using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Sound_Simulation__Medium_Hard_
{
    class Dog : Animal
    {
        public Dog(string n) : base(n)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine(Name + " says Woof!");
        }
    }

}
