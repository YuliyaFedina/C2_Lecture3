namespace HomeWork.Model.Contact2
{
    public class PhoneContact : ContactBase
    {
        public override string PhoneCode { get; set; }
        
        public override string ToString()
        {
            return $"Id={Id}, Value={"(" + PhoneCode + ")" + Value}";
        }
    }
}