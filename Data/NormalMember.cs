namespace Library.Data
{
    public class NormalMember : Member
    {
        public override int Limit()
        {
            return 5 - BooksBorrowed.Count;
        }
    }
}