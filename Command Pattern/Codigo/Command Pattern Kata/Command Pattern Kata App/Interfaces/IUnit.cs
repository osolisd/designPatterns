namespace Command_Pattern_Kata_App.Interfaces
{
    public interface IUnit
    {
        int Minerals { get; set; }
        Point Position { get; set; }

        void Move(int x, int y);
        void Gather();
    }
}
