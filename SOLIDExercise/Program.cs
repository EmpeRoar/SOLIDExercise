using OCP.models;
using OCP.models.commands;
using OCP.models.faces;
using System;

namespace OCP
{

    class Program
    {
        static void Main(string[] args)
        {
            var north = new North();
            var south = new South();
            var east = new East();
            var west = new West();

            north.Left = west;
            north.Right = east;
            east.Left = north;
            east.Right = south;
            south.Left = east;
            south.Right = west;
            west.Left = north;
            west.Right = south;


            var turtle = new Turtle()
            {
                XPos = 0,
                YPos = 0,
                Face = north
            };

            turtle.Execute(new Place(0,0, west));
            turtle.Execute(new Move());
            turtle.Execute(new Report());

            Console.ReadLine();
        }
    }
}
