namespace HomeWork.Model.Contact2
{
    public class ContactBase : IEntity
    {
        public long Id { get; set; }
        public virtual string Value { get; set; }

        public virtual string PhoneCode { get; set; }
    }
}