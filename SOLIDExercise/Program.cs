using System;

namespace OCP
{
   

    public interface ITurtle
    {
        
    }
    public class Turtle : ITurtle
    {
        public int XPos { get; set; } = 0;
        public int YPos { get; set; } = 0;
        public string Face { get; set; } = "NORTH";
    }

    public static class TurtleExt
    {
        public static Turtle Move(this Turtle turle)
        {
            turle.XPos++;
            return turle;
        }

        public static void Report(this Turtle turle)
        {
            Console.WriteLine($"Report: {turle.XPos} {turle.YPos} {turle.Face}");
            
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var turtle = new Turtle();
            turtle.Move();
            turtle.Move();
            turtle.Move();
            turtle.Move();
            turtle.Report();
            Console.ReadLine();
        }
    }
}
