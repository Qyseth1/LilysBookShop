using SharedLibrary.Commands;
using Shop.Data;
using Shop.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace LilysBookShop.ViewModels
{
    public class MainViewModel
    {
        private readonly UserRepository _userRepository;

        public ObservableCollection<User> Users { get; } = new();

        public ICommand SaveCommand { get; }
        public ICommand NewCommand { get; }
        public ICommand OpenCommand { get; }
        public ICommand ExitCommand { get; }
        public ICommand AboutCommand { get; }

        public MainViewModel(UserRepository userRepository)
        {
            _userRepository = userRepository;

            SaveCommand = new Command(Save);
            NewCommand = new Command(New);
            OpenCommand = new Command(Open);
            ExitCommand = new Command(Exit);
            AboutCommand = new Command(About);
        }

        // for now... for the test, dont use async void!!!... AsyncCommand must be implemented. 
        private async void Save()
        {
            await LoadUsersAsync();
        }

        public async Task LoadUsersAsync()
        {
            var users = await _userRepository.GetUsersAsync();

            Users.Clear();

            foreach (var user in users)
            {
                Users.Add(user);
            }
        }

        private void New()
        {
        }

        private void Open()
        {
        }

        private void Exit()
        {
            //Application.Current.Shutdown();
        }

        private void About()
        {
        }
    }
}
