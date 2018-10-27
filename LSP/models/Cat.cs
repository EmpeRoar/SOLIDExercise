using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.models
{
    public class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Meow!");
        }
    }
}
