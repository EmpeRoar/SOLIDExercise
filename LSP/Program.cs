using LSP.models;
using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            dog.Sound();

            Animal cat = new Cat();
            cat.Sound();

            Console.ReadLine();
        }
    }
}
