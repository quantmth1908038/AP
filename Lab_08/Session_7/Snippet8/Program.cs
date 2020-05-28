using System;

namespace Snippet8
{
    class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Every animal eats something");
        }

        protected void DoSomething()
        {
            Console.WriteLine("Every animal does something");
        }

    }

    class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cat loves to eat the mouse");

        }

        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Eat();

        }
    }
}
