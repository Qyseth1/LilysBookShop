using System.Windows.Input;

namespace SharedLibrary.Commands
{
    public class Command : ICommand
    {
        private readonly Action _execute;

        public event EventHandler? CanExecuteChanged;

        public Command(Action execute)
        {
            _execute = execute;
        }

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
            _execute();
        }
    }
}
