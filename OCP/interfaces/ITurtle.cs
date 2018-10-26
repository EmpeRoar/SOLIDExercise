using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.interfaces
{
    public interface ITurtle
    {
        int XPos { get; set; }
        int YPos { get; set; }
        IFace Face { get; set; }
        ITurtle Execute(ICommand command);
    }
}
