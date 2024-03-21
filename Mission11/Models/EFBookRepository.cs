
namespace Mission11.Models
{
    public class EFBookRepository : IBookRepository
    {
        public BookContext _context;
        public EFBookRepository(BookContext temp)
        {
            _context = temp;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
