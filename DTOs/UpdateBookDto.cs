using System.ComponentModel.DataAnnotations;
namespace GerenciadorDeLivraria.DTOs;

public class UpdateBookDto
{
    [Required]
    [MinLength(2)]
    [MaxLength(120)]
    public string Title { get; set; } = string.Empty;

    [Required]
    [MinLength(2)]
    [MaxLength(120)]
    public string Author { get; set; } = string.Empty;

    [Required]
    public string Genre { get; set; } = string.Empty;

    [Required]
    [Range(0, double.MaxValue, ErrorMessage = "O preço deve ser maior ou igual a 0.")]
    public decimal Price { get; set; }

    [Required]
    [Range(0, int.MaxValue, ErrorMessage = "O estoque deve ser maior ou igual a 0.")]
    public int Stock { get; set; }
}
