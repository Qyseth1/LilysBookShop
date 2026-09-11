using SharedLibrary.Interfaces.Services;
using System.Windows;

namespace SharedLibrary.Service
{
    public class MessageService : IMessageService
    {
        public void Show(string message, string title)
        {
            MessageBox.Show(message, title);
        }

        public void Show(string message)
        {
            MessageBox.Show(message);
        }
    }
}