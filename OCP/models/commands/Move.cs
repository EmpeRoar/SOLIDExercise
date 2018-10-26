using OCP.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.models.commands
{
    public class Move : ICommand
    {
        ITurtle _turtle;

        ITurtle Implement(Func<ITurtle, ITurtle> execute)
        {
            return execute(_turtle);
        }

        public ITurtle Execute(ITurtle turtle)
        {
            _turtle = turtle;
            turtle = Implement(turtle.Face.Movement);
            return turtle;
        }
    }
}
