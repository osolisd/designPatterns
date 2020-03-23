using State_Pattern_Kata_App.Context;
using State_Pattern_Kata_App.Interface;
using System;

namespace State_Pattern_Kata_App.States
{
    public class SiegeState : IState
    {
        Tank tank;

        public SiegeState(Tank tank)
        {
            this.tank = tank;
        }

        public int Damage
        {
            get;
            private set;
        }
        public bool CanMove
        {
            get;
            private set;
        }

        public void Move()
        {
            Console.WriteLine("You can not move");
        }

        public void NoMove()
        {
            this.Damage = 20;
            this.CanMove = false;
        }
    }
}
