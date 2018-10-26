using OCP.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.models.faces
{
    public class North : IFace
    {
        public IFace Left { get; set; }
        public IFace Right { get; set; }
        
        public Func<ITurtle, ITurtle> Movement
        {
            get
            {
                return (turtle) =>
                {
                    turtle.YPos++;
                    return turtle;
                };
            }
        }
    }
}
