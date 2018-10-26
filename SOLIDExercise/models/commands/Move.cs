﻿using OCP.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.models.commands
{
    public class Move : ICommand
    {
        public ITurtle Execute(ITurtle turtle)
        {
            turtle = turtle.Face.Direction(turtle);
            return turtle;
        }
    }
}
