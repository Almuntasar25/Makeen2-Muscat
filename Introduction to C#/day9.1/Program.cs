namespace day9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Sulem", 20, "Muscat");
            Person P2 = new Person("Ahmed", 30, "nizwa");
            Person P3 = new Person("sulah", 30, "nizwa");
            Person P4 = new Person("sultan", 30, "nizwa");
            Person P5 = new Person("mohammd", 30, "nizwa");

            string person_data = p1.PersonData(); //  person_dataتخزن القيمة الراجعة م المثود و تتخزن في متغير
            Console.WriteLine(p1.PersonData()); //  mathodطباعة القيمة المرجعة من

            Person[] people = { p1, P2, P3, P4, P5 };

            foreach (Person person in people)
            {
                Console.WriteLine(person.PersonData());


            }

            Student s1 = new Student(3.4 , "Sulem", 20, "Muscat");
            Console.WriteLine(s1.PersonData());

        }
        public class Person
        {
            public string name;
            public int age;
            public string address;

            // CONSTRACTOR**************

            public Person(string name, int age, string address)//انشاء object 
            {
                this.name = name;// "object" لتثيت قيمة المتغير في
                this.age = age;
                this.address = address;
            }

            //public void PersonData()
            //{
            //    Console.WriteLine($"This person is {name} , He is {age} , yers old , He is from {address}");

            //}
            public string PersonData()
            {
                return $"This person is {name} , He is {age} , yers old , He is from {address}";

            }
        }

        public class Student : Person // الوراثة من كلاس preson
        {
            public double GPA;
            public Student(double GPA, string name, int age, string address) : base(name, age, address)
            {// "نستخدم base"  personمعرفة البيانات الموروثة من كلاس الاب   
                
                    this.GPA = GPA;
                
            }

            public override string PersonData() // تمت اضافة نفس الدالة 
            {
                return $"This person is {name} , He is {age} , yers old , He is from {address} the GPA {GPA}" ;

            }




        }
    }
}



