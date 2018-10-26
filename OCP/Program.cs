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
            var northEast = new NorthEast();
            var east = new East();
            var south = new South();
            var west = new West();


            north.Left = west;
            north.Right = east;

            northEast.Left = north;
            northEast.Right = east;

            east.Left = northEast;
            east.Right = south;

            south.Left = east;
            south.Right = west;

            west.Left = south;
            west.Right = north;


            var turtle = new Turtle()
            {
                XPos = 0,
                YPos = 0,
                Face = north
            };

            turtle.Execute(new Place(0,0, northEast));
            turtle.Execute(new Move());
            turtle.Execute(new Move());
            turtle.Execute(new Move());

            turtle.Execute(new Report());
            Console.ReadLine();
        }
    }
}
