using System;

namespace Snippet3
{
    class Animal
    {
        protected string Food;
        protected string Activity;
    }

    class Cat : Animal
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Food = "Mouse";
            cat.Activity = "laze around";
            Console.WriteLine("The Cat loves to eat " + cat.Food + ".");
            Console.WriteLine("The Cat loves to " + cat.Activity + ".");
        }
    }
}
