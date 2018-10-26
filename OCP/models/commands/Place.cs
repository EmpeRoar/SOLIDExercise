using OCP.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.models.commands
{
    public class Place : ICommand
    {
        int _x;
        int _y;
        IFace _face;
        public Place(int x, int y, IFace face)
        {
            _x = x;
            _y = y;
            _face = face;
        }
        public ITurtle Execute(ITurtle turtle)
        {
            turtle.XPos = _x;
            turtle.YPos = _y;
            turtle.Face = _face;
            return turtle;
        }
    }
}
