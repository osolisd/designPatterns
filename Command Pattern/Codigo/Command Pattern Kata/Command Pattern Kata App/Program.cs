using Command_Pattern_Kata_App.Interfaces;
using System;

namespace Command_Pattern_Kata_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Probe probe = new Probe();

            string option = "";
            Random random = new Random();

            while(option != "E")
            {
                Console.WriteLine("Command Pattern Kata");
                Console.WriteLine("Press A to execute all commands");
                Console.WriteLine("Press G to enqueue gather");
                Console.WriteLine("Press M to enqueue move");
                Console.WriteLine("Press E to exit");
                option = Console.ReadLine().ToUpper();

                
                if (option == "M")
                {
                    int x = random.Next(0, 9);
                    int y = random.Next(0, 9);
                    probe.Move(x, y);
                }
                else if (option == "G")
                {
                    probe.Gather();
                }
                else if(option == "A")
                {
                    while (probe.Commands.Count > 0)
                    {
                        ICommand command = probe.Commands.Dequeue();
                        command.Execute();
                    }
                }
                else if(option == "E")
                {
                    break;
                }

                //Console.WriteLine("Command Pattern Kata");
                //Console.WriteLine("Press A to execute all commands");
                //Console.WriteLine("Press G to enqueue gather");
                //Console.WriteLine("Press M to enqueue move");
                //Console.WriteLine("Press E to exit");

            }
        }
    }
}
