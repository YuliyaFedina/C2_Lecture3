using System;

namespace HomeWork.Infrastructure
{
    public class ExceptionHandler : IHandler
    {
        private readonly FileLogger _fileLogger = new FileLogger();

        public void Handle(Exception e)
        {
            if (e is ArgumentNullException)
            {
                Console.WriteLine(e.Message);
            }
            else if (e is InvalidOperationException)
            {
                throw new Exception("Custom exception", e);
            }
            else
            {
                _fileLogger.Log(e);
            }
        }
    }
}
