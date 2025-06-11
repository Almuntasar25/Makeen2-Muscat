namespace Animal_Sound_Simulation__Medium_Hard_
{
    internal class Program
    { 
        static void MakeAllSounds(List<Animal> animals)
            {
                for (int i = 0; i < animals.Count; i++)
                {
                    animals[i].MakeSound();
                }
            }
        static void Main(string[] args)
        {
           

            Dog dog1 = new Dog("Rex");
                Cat cat1 = new Cat("Luna");
                Cow cow1 = new Cow("Bella");

                List<Animal> animalList = new List<Animal>();
                animalList.Add(dog1);
                animalList.Add(cat1);
                animalList.Add(cow1);

                MakeAllSounds(animalList);
            }
        }
    }
    

