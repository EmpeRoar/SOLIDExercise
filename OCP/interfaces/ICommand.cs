using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.interfaces
{
    public interface ICommand
    {
        ITurtle Execute(ITurtle turtle);
    }
}
