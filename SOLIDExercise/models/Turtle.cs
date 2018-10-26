using OCP.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.models
{
    public class Turtle : ITurtle
    {

        public int XPos { get; set; }
        public int YPos { get; set; }
        public IFace Face { get; set; }

        public ITurtle Execute(ICommand command)
        {
            return command.Execute(this);
        }
    }
}
