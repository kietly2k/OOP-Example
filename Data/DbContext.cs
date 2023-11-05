namespace Library.Data
{
    public static class DbContext
    {
        private static readonly List<Member> Members = new()
        {
            new() { Name = "John", Email = "john@gmail.com", Type = MemberType.Normal},
            new() { Name = "Jason", Email = "jason@gmail.com", Type = MemberType.Normal},
            new() { Name = "Tom", Email = "tom@tech.vn", Type = MemberType.VIP}
        };

        private static readonly List<Book> Books = new()
        {
            new() { Code= "001", Title= "The Age of A.I.", Author= "Henry Kissinger, Eric Schmidt, and Daniel Huttenlocher", PublishYear= "2022", Quantity = 5},
            new() { Code= "002", Title= "Doing Agile Right= Transformation without Chaos", Author= "Darrell K. Rigby, Sarah Elk, and Steve Berez", PublishYear= "2022", Quantity = 3},
            new() { Code= "003", Title= "Blockchain for Business", Author= "Jai Singh Arun, Jerry Cuomo and Nitin Gaur", PublishYear= "2019", Quantity = 12},
            new() { Code= "004", Title= "The Cybersecurity Playbook - How Every Leader and Employee Can Contribute to a Culture of Security", Author= "Allison Cerra", PublishYear= "2019", Quantity = 2},
            new() { Code= "005", Title= "Algorithms to Live By - The Computer Sciencecls of Human Decisions", Author= "Brian Christian and Tom Griffiths", PublishYear= "2016", Quantity = 3}
        };

        public static Member GetMemberByEmail(string email) => Members.First(x => x.Email == email);

        public static Book GetBookByCode(string code) => Books.First(x => x.Code == code);

        internal static void Update(Book bookUpdated)
        {
            Book book = Books.First(x => x.Id == bookUpdated.Id);
            book.Title = bookUpdated.Title;
            book.Code = bookUpdated.Code;
            book.PublishYear = bookUpdated.PublishYear;
            book.Author = bookUpdated.Author;
            book.Quantity = bookUpdated.Quantity;

            Console.WriteLine("Book saved");
        }
    }
}