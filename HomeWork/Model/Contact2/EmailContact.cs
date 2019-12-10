using System;

namespace HomeWork.Model.Contact2
{
    public class EmailContact : ContactBase
    {
        public override string PhoneCode
        {
            get => throw new NotSupportedException();
            set => throw new NotSupportedException();
        }

        public override string ToString()
        {
            return $"Id={Id}, Value={Value}";
        }
    }
}