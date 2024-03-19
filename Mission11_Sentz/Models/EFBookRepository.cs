namespace Mission11_Sentz.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookstoreContext _bookstoreContext;
        public EFBookRepository(BookstoreContext temp)
        {
            _bookstoreContext = temp;
        }

        public IQueryable<Book> Books => _bookstoreContext.Books;
    }
}
