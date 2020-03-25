using Command_Pattern_Kata_App.Interfaces;
using System;

namespace Command_Pattern_Kata_App.Commands
{
    public class MoveCommand : ICommand
    {
        private IUnit unit;
        private int x;
        private int y;

        public MoveCommand(IUnit unit, int x, int y)
        {
            this.unit = unit;
            this.x = x;
            this.y = y;
        }

        public bool CanExecute()
        {
            return true;
        }

        public void Execute()
        {
            this.unit.Position.Y = this.y;
            this.unit.Position.X = this.x;
            Console.WriteLine("Move to position: " +this.unit.Position.X + "," + this.unit.Position.Y);
        }
    }
}
