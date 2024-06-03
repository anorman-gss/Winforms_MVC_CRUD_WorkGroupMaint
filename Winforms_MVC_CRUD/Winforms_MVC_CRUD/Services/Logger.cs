using System;

namespace Winforms_MVC_CRUD.Services
{
    public class Logger : ILogger
    {
        public void Info(string message)
        {
            Console.WriteLine($"INFO: {message}");
        }

        public void Warn(string message)
        {
            Console.WriteLine($"WARNING: {message}");
        }

        public void Error(string message)
        {
            Console.WriteLine($"ERROR: {message}");
        }
    }
}
