using State_Pattern_Kata_App.Context;
using State_Pattern_Kata_App.Interface;
using State_Pattern_Kata_App.States;
using System;

namespace State_Pattern_Kata_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("State Pattern Kata");
            Console.WriteLine();

            Tank tank = new Tank();

            Console.WriteLine("Damages are: " + tank.Damage);
            string canMove = tank.CanMove ? "SI" : "NO";
            Console.WriteLine("Can tank Move?: " + canMove);
            Console.WriteLine();

            tank.NoMove();

            Console.WriteLine("Damages are: " + tank.Damage);
            canMove = tank.CanMove ? "SI" : "NO";
            Console.WriteLine("Can tank Move?: " + canMove);
            Console.WriteLine();

            tank.Move();

            Console.WriteLine("Damages are: " + tank.Damage);
            canMove = tank.CanMove ? "SI" : "NO";
            Console.WriteLine("Can tank Move?: " + canMove);
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
