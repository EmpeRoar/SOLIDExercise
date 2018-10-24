using System;

namespace OCP
{
    public interface IFace
    {
        ITurtleState Execute(ITurtleState turtle);
    }

    public class North : IFace
    {
        public ITurtleState Execute(ITurtleState turtle)
        {
            throw new NotImplementedException();
        }
    }
    public class South : IFace
    {
        public ITurtleState Execute(ITurtleState turtle)
        {
            throw new NotImplementedException();
        }
    }

    public class East : IFace
    {
        public ITurtleState Execute(ITurtleState turtle)
        {
            throw new NotImplementedException();
        }
    }

    public class West : IFace
    {
        public ITurtleState Execute(ITurtleState turtle)
        {
            throw new NotImplementedException();
        }
    }



    public interface ICommand
    {
        ITurtleState Execute(ITurtleState turtle);
    }

    public class Move : ICommand
    {
        public ITurtleState Execute(ITurtleState turtleState)
        {
            turtleState.Xpos++;
            return turtleState;
        }
    }

    public class Back : ICommand
    {
        public ITurtleState Execute(ITurtleState turtleState)
        {
            turtleState.Xpos--;
            return turtleState;
        }
    }

    public class Left : ICommand
    {
        public ITurtleState Execute(ITurtleState turtleState)
        {
            return turtleState;
        }
    }

    public class Right : ICommand
    {
        public ITurtleState Execute(ITurtleState turtleState)
        {
            return turtleState;
        }
    }

    public class Report : ICommand
    {
        public ITurtleState Execute(ITurtleState turtleState)
        {
            Console.WriteLine($"Report: {turtleState.Xpos} {turtleState.Ypos}");
            return turtleState;
        }
    }

    public interface ITurtleState
    {
        int Xpos { get; set; }
        int Ypos { get; set; }
        string Facing { get; set; }
    }

    public interface ITurtle
    {
        void Execute(ICommand command);
    }

    public class TurtleState : ITurtleState
    {
        public int Xpos { get; set; }
        public int Ypos { get; set; }
        public string Facing { get; set; }
    }

    public class Turtle : ITurtle
    {
        public ITurtleState _turtleState;

        public Turtle(ITurtleState turtleState)
        {
            _turtleState = turtleState;
        }
        
        public void Execute(ICommand command)
        {
            _turtleState = command.Execute(_turtleState);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var turtle = new Turtle(new TurtleState() { Xpos = 0, Ypos = 0 });
            turtle.Execute(new Move());
            turtle.Execute(new Move());
            turtle.Execute(new Move());
            turtle.Execute(new Move());
            turtle.Execute(new Back());
            turtle.Execute(new Report());
            Console.ReadLine();
        }
    }
}
