using System;
using HomeWork.Infrastructure;
using HomeWork.Model.Contact2;

namespace HomeWork.Validation
{
    public class EmailContactValidator : IValidator<EmailContact>
    {
        private readonly FileLogger _fileLogger = new FileLogger();

        public bool IsValid(EmailContact entity)
        {
            try
            {
                return !string.IsNullOrWhiteSpace(entity.Value);
            }
            catch (Exception e)
            {
                _fileLogger.Log(e);
            }
            return true;
        }
    }
}