using LSP.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.models
{
    public abstract class Animal : IAnimal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Eat");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("Sleep");
        }

        public virtual void Sound()
        {
            Console.WriteLine("Sound");
        }

        public virtual void Travel()
        {
            Console.WriteLine("Travel");
        }
    }
}
