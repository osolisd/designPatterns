namespace Command_Pattern_Kata_App.Interfaces
{
    public interface ICommand
    {
        void Execute();
        bool CanExecute();
    }
}
