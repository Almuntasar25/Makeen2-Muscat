
class Person {
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age) {
        Name = name;
        Age = age;
    }

    public void Introduce() {
        Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old.");
    }
}

class Student : Person {
    public string School { get; set; }

    public Student(string name, int age, string school)
        : base(name, age) {
        School = school;
    }

    public void Study() {
        Console.WriteLine($"{Name} is studying at {School}.");
    }
}

class Program {
    static void Main(string[] args)
    {
        Person p = new Person("Omar", 30);
        p.Introduce();

        Student s = new Student("Sara", 20, "AOU");
        s.Introduce();
        s.Study();
    }
}
