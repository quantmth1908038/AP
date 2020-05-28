using System;

namespace Animal
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Every animal eats something.");

        }
    }

    class Mammal : Animal
    {
        public void Feature()
        {
            Console.WriteLine("Mammals give birth to young ones.");
        }
    }

    class Dog : Mammal
    {
        public void Noise()
        {
            Console.WriteLine("Dog bark.");

        }
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Feature();
            dog.Noise();
        }

    }
}
