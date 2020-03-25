using Command_Pattern_Kata_App.Interfaces;
using System;

namespace Command_Pattern_Kata_App.Commands
{
    public class GatherCommand : ICommand
    {
        private IUnit unit;

        public GatherCommand(IUnit unit)
        {
            this.unit = unit;
        }

        public bool CanExecute()
        {
            return this.unit.Minerals == 0;
        }

        public void Execute()
        {
            bool canRun = this.CanExecute();

            if (canRun)
            { 
                this.unit.Minerals += 5;
                Console.WriteLine("Gather. Total minerals are : " + unit.Minerals);
            }
            else
            {
                Console.WriteLine("You can't Gather, not minerals. The total minerals are: " + unit.Minerals);
            }
        }
    }
}
