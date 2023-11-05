namespace Library.Data
{
    public class Member
    {
        public Member()
        {
            BooksBorrowed = new List<Book>();
        }
        public string Email { get; set; }
        public string Name { get; set; }
        public List<Book> BooksBorrowed { get; set; }
        public MemberType Type { get; set; }
        public virtual int Limit()
        {
            throw new NotImplementedException();
        }
    }
}