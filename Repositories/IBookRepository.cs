
using GerenciadorDeLivraria.Domain.Entities;
namespace GerenciadorDeLivraria.Repositories;

public interface IBookRepository
{
    IEnumerable<Book> GetAll();
    Book? GetById(Guid id);

    void Add(Book book);
    void Remove(Book book);

    bool Exists(string title, string author, Guid? ignoreId = null);
}
