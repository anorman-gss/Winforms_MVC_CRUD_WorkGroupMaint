namespace Winforms_MVC_CRUD.Services
{
    public interface ILogger
    {
        void Error(string message);
        void Info(string message);
        void Warn(string message);
    }
}