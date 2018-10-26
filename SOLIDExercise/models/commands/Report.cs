using OCP.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.models.commands
{
    public class Report : ICommand
    {
        public ITurtle Execute(ITurtle turtle)
        {
            Console.WriteLine($"{turtle.XPos} {turtle.YPos} {turtle.Face.GetType().Name}");
            return turtle;
        }
    }
}
