using Command_Pattern_Kata_App.Commands;
using Command_Pattern_Kata_App.Interfaces;
using System.Collections.Generic;

namespace Command_Pattern_Kata_App
{
    public class Probe : IUnit
    {
        public Queue<ICommand> Commands { get; set; }

        public int Minerals { get; set; }

        public Point Position { get; set; }

        public Probe()
        {
            this.Minerals = 0;
            this.Position = new Point();
            this.Commands = new Queue<ICommand>();
        }

        public void Move(int x, int y)
        {
            Commands.Enqueue(new MoveCommand(this, x, y));
        }

        public void Gather()
        {
            Commands.Enqueue(new GatherCommand(this));
        }
    }
}
