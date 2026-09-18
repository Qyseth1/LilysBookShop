using Shop.Data;
using Shop.Models;
using System.Collections.ObjectModel;

namespace LilysBookShop.ViewModels
{
    public class UsersViewModel
    {
        private readonly UserRepository _userRepository;

        public ObservableCollection<User> Users { get; } = new();

        public UsersViewModel(UserRepository userRepository)
        {
            _userRepository = userRepository;
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
    }
}
