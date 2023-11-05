using Library.Data;

namespace Library.Services
{
    internal class MemberService
    {
        // Hide details about class and only allow user to interact with public methods (Encapsulation)
        private readonly BookService _bookService = new();
        private Member Member { get; set; }

        public MemberService(string email)
        {
            Member = DbContext.GetMemberByEmail(email);

            // Both VIPMember and NormalMember are inherit from Member class (Inheritance)
            switch (Member.Type)
            {
                case MemberType.VIP:
                    Member = new VIPMember();
                    break;
                case MemberType.Normal:
                    Member = new NormalMember();
                    break;
            }
        }

        public int BorrowBook(string bookCode)
        {
            // Book service responsibility to update quantity and orther stuff and Member class does not care the implementation (Abstraction)
            _bookService.Borrow(bookCode);

            // We don't know how the book service handle logic get by code. We only know it's will return the book. That's what we need (Abstraction)
            Book book = _bookService.GetBookFromCode(bookCode);
            Member.BooksBorrowed.Add(book);

            // For each member type have diffrent limitation of book can borrow (Polymorphism)
            return Member.Limit();
        }

        public int ReturnBook(string bookCode)
        {
            // Book responsibility to update quantity and orther stuff and Member class does not care
            _bookService.Return(bookCode);

            return Member.Limit();
        }

        public List<Book> GetBooksBorrowed()
        {
            return Member.BooksBorrowed;
        }
    }
}