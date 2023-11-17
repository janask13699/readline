using System;

namespace read_readline
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Woof!");
            Console.WriteLine("The dog is barking.");
        }
    }

    
}
