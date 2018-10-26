﻿using OCP.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.models.faces
{
    public class NorthEast : IFace
    {
        public IFace Left { get; set; }
        public IFace Right { get; set; }

        public Func<ITurtle, ITurtle> Direction
        {
            get
            {
                return (turtle) =>
                {
                    turtle.XPos++;
                    turtle.YPos++;
                    return turtle;
                };
            }
        }
    }
}
