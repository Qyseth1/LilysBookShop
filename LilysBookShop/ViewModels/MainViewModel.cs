using SharedLibrary.Commands;
using SharedLibrary.Interfaces.Services;
using System.Windows.Input;

namespace LilysBookShop.ViewModels
{
    public class MainViewModel
    {
        private readonly IMessageService _messageService;

        public ICommand SaveCommand { get; }
        public ICommand NewCommand { get; }
        public ICommand OpenCommand { get; }
        public ICommand ExitCommand { get; }
        public ICommand AboutCommand { get; }


        public MainViewModel(IMessageService messageService)
        {
            _messageService = messageService;

            SaveCommand = new Command(Save);
            NewCommand = new Command(New);
            OpenCommand = new Command(Open);
            ExitCommand = new Command(Exit);
            AboutCommand = new Command(About);
        }


        private void Save()
        {
            _messageService.Show("Saved!", "Save");
        }


        private void New()
        {
            _messageService.Show("New clicked");
        }


        private void Open()
        {
            _messageService.Show("Open clicked");
        }


        private void Exit()
        {
            System.Windows.Application.Current.Shutdown();
        }


        private void About()
        {
            _messageService.Show("WPF Menu Example\nVersion 1.0", "About");
        }
    }
}
