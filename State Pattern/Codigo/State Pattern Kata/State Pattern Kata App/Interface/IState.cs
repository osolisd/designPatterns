namespace State_Pattern_Kata_App.Interface
{
    public interface IState
    {
        int Damage { get; }

        bool CanMove { get; }

        void Move();

        void NoMove();
    }
}