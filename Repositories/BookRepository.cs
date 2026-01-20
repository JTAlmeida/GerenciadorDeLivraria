using GerenciadorDeLivraria.Domain.Entities;
namespace GerenciadorDeLivraria.Repositories;

public class BookRepository : IBookRepository
{
    private static readonly List<Book> _books = [];

    public IEnumerable<Book> GetAll() => _books;

    public Book? GetById(Guid id) 
        => _books.FirstOrDefault(b => b.Id == id);

    public void Add(Book book) 
        => _books.Add(book);
    
    public void Remove(Book book) 
        => _books.Remove(book);

    public bool Exists(string title, string author, Guid? ignoreId = null)
    => _books.Any(b => 
       b.Title == title && 
       b.Author == author && 
       (!ignoreId.HasValue || b.Id != ignoreId));
}