using State_Pattern_Kata_App.Interface;
using State_Pattern_Kata_App.States;

namespace State_Pattern_Kata_App.Context
{
    public class Tank
    {
        IState tankState;
        IState siegeState;

        public bool CanMove 
        { 
            get; 
            private set; 
        }

        public int Damage
        {
            get;
            private set;
        }

        public IState State 
        { 
            get; 
            private set; 
        }

        public Tank()
        {
            this.tankState = new TankState(this);
            this.siegeState = new SiegeState(this);
            this.State = this.tankState;
            this.Move();
        }
        public void SetState(IState state)
        {
            this.State = state;
        }

        public IState GetState()
        {
            return this.State;
        }

        public IState GetSiegeState()
        {
            this.State = new SiegeState(this);
            return this.State;
        }

        public IState GeTankState()
        {
            this.State = new TankState(this);
            return this.State;
        }

        public void Move()
        {
            this.State.Move();
            this.Damage = this.State.Damage;
            this.CanMove = this.State.CanMove;
            this.SetState(this.siegeState);
        }

        public void NoMove()
        {
            this.State.NoMove();
            this.Damage = this.State.Damage;
            this.CanMove = this.State.CanMove;
            this.SetState(this.tankState);
        }
    }
}
