using GerenciadorDeLivraria.Domain.Enums;
namespace GerenciadorDeLivraria.Domain.Entities;

public class Book : BaseEntity
{
    public string Title { get; private set; } = null!;
    public string Author { get; private set; } = null!;
    public BookGenre Genre { get; private set; }
    public decimal Price { get; private set; }
    public int Stock { get; private set; }

    public Book(string title, string author, BookGenre genre, decimal price, int stock)
    {
        Update(title, author, genre,price,stock);
    }

    public void Update(string title, string author, BookGenre genre, decimal price, int stock)
    {
        Title = title;
        Author = author;
        Genre = genre;
        Price = price;
        Stock = stock;
        UpdateTimestamp();
    }
}
