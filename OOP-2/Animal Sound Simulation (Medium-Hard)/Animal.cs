using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Sound_Simulation__Medium_Hard_
{
    abstract class Animal
    {
        public string Name;

        public Animal(string n)
        {
            Name = n;
        }

        public abstract void MakeSound();
    }

}
