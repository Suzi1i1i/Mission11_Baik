namespace Mission11.Models
{
    public class EFBookRepo: IBookRepo
    {
        private BookContext _context;
        public EFBookRepo(BookContext temp)
        {
            _context = temp;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
