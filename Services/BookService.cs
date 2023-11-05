using Library.Data;

namespace Library.Services
{
    public class BookService
    {
        public void Borrow(string code)
        {
            Book book = GetBookFromCode(code);
            book.Quantity--;
            DbContext.Update(book);
        }

        public void Return(string code)
        {
            Book book = GetBookFromCode(code);
            book.Quantity++;
            DbContext.Update(book);
        }

        public Book GetBookFromCode(string code)
        {
            Book book = DbContext.GetBookByCode(code);
            return book;
        }
    }
}