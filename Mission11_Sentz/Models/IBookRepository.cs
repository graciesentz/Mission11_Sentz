namespace Mission11_Sentz.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
