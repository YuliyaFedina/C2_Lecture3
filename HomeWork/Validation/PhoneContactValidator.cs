using System;
using HomeWork.Infrastructure;
using HomeWork.Model.Contact2;

namespace HomeWork.Validation
{
    public class PhoneContactValidator : IValidator<PhoneContact>
    {
        private readonly FileLogger _fileLogger = new FileLogger();

        public bool IsValid(PhoneContact entity)
        {
            try
            {
                return entity.PhoneCode != null && entity.Value != null;
            }
            catch (Exception e)
            {
                _fileLogger.Log(e);
            }
            return true;
        }
    }
}