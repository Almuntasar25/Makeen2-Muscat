namespace day8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //date d = new date(1, 2, 2000);
            //Console.WriteLine(d.ToString());

            Student student= new Student("ahmed", 1);
            Student student1 = new Student("ahmed", 1);

            //teacher t1 = new teacher();

            student.name = "A";

            Console.WriteLine(student.name);

            Console.WriteLine(student.sayHi());

            person person = student;
            Console.WriteLine(person.GetType());

            student.name = "student";
            Console.WriteLine(student.ToString());
            Console.WriteLine(student.ToString);

            


        }
       
        public abstract class person 
        {
            public string name;
            public int id;

            public person(string name, int id)
            {
                this.name = name;
                this.id=id;
            }

            public virtual string sayHi()
            {
                return "Hi person ";
            }

        }
        public class Student : person
        {

            public Student (string name , int id) :base(name,id) {
            

            }
            public string ToString()
            {
                return $"name: {name}";
            }

            public override string sayHi()
            {

                return base.sayHi() + " " + " you are student ";
            }

        }

        //public override string ToString()
        //{
        //    //return $"the {name}";
        //}
        //public class teacher : person { }
        //{


        //}


    }
}
