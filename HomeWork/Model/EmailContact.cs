namespace HomeWork.Model
{
    internal class EmailContact : Contact
    {
        public override string ToString()
        {
            return string.Format("Id={0}, Value={1}", Id, Value);
        }
    }
}