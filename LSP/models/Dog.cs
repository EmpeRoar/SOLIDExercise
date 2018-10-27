using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.models
{
    public class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Woof!");
        }
    }
}
