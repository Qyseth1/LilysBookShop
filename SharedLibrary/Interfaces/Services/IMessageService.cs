namespace SharedLibrary.Interfaces.Services
{
    public interface IMessageService
    {
        void Show(string message, string title);
        void Show(string message);
    }
}
