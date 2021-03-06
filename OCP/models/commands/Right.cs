﻿using OCP.interfaces;
using OCP.models.faces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.models.commands
{
    public class Right : ICommand
    {
        public ITurtle Execute(ITurtle turtle)
        {
            turtle.Face = turtle.Face.Right;
            return turtle;
        }
    }
}
