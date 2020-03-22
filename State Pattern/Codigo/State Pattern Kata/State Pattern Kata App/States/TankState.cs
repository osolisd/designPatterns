using State_Pattern_Kata_App.Context;
using State_Pattern_Kata_App.Interface;
using System;

namespace State_Pattern_Kata_App.States
{
    public class TankState : IState
    {
        Tank tank;

        public TankState(Tank tank)
        {
            this.tank = tank;
        }

        public int Damage { 
            get; 
            private set ; 
        }
        public bool CanMove { 
            get; 
            private set; 
        }

        public void Move()
        {
            this.Damage = 5;
            this.CanMove = true;
        }

        public void NoMove()
        {
            Console.WriteLine("You can Move");
        }
    }
}
