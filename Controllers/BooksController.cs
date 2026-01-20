using GerenciadorDeLivraria.Domain.Entities;
using GerenciadorDeLivraria.Domain.Enums;
using GerenciadorDeLivraria.DTOs;
using GerenciadorDeLivraria.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeLivraria.Controllers;

[ApiController]
[Route("api/books")]

public class BooksController : ControllerBase
{
    private readonly IBookRepository _repository;

    public BooksController(IBookRepository repository)
    {
        _repository = repository;
    }

    [HttpPost]
    public IActionResult Create(CreateBookDto dto)
    {
        if (_repository.Exists(dto.Title, dto.Author))
            return Conflict("Livro já cadastrado");

        if(!Enum.TryParse<BookGenre>(dto.Genre, true, out var genre))
            return BadRequest("Gênero inválido");

        var book = new Book(dto.Title, dto.Author, genre, dto.Price, dto.Stock);
        _repository.Add(book);

        return CreatedAtAction(nameof(GetById), new { id = book.Id }, book);
    }

    [HttpGet]
    public IActionResult GetAll()
        => Ok(_repository.GetAll());

    [HttpGet("{id}")]
    public IActionResult GetById(Guid id)
    {
        var book = _repository.GetById(id);
        if (book is null)
            return NotFound();

        return Ok(book);
    }

    [HttpPut("{id}")]
    public IActionResult Update(Guid id, UpdateBookDto dto)
    {
        var book = _repository.GetById(id);

        if (book is null)
            return NotFound();

        if (_repository.Exists(dto.Title, dto.Author, id))
            return Conflict("Livro já cadastrado");

        if (!Enum.TryParse<BookGenre>(dto.Genre, true, out var genre))
            return BadRequest("Gênero inválido");

        book.Update(dto.Title, dto.Author, genre, dto.Price, dto.Stock);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        var book = _repository.GetById(id);
        if (book is null)
            return NotFound();

        _repository.Remove(book);
        return NoContent();
    }
}
