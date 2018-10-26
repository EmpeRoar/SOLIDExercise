using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.interfaces
{
    public interface IFace
    {
        Func<ITurtle, ITurtle> Direction { get; }
        IFace Left { get; set; }
        IFace Right { get; set; }
    }
}
