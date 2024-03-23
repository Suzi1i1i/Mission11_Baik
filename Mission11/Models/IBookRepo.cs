namespace Mission11.Models
{
    public interface IBookRepo
    {
        public IQueryable<Book> Books { get; }
    }
}
