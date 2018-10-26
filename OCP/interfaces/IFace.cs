using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.interfaces
{
    public interface IFace
    {
        Func<ITurtle, ITurtle> Movement { get; }
        IFace Left { get; set; }
        IFace Right { get; set; }
    }
}
