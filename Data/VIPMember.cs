namespace Library.Data
{
    public class VIPMember : Member
    {
        public override int Limit()
        {
            return 10 - BooksBorrowed.Count;
        }
    }
}