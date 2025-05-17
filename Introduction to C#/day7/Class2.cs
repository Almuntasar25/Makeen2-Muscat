using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    internal class Empioyee
    {
        public int id;
        public string name;
        public double salary;
        public Empioyee(int id ,string name ,double salary) { 
            this.id = id;
            this.name = name;
            this.salary = salary;

        }

        public Empioyee(string name) {
            name =  name;
        }

        public string GetData()
        {
            return $"{name}- {id} - {salary}";
            
        }
    }
}
