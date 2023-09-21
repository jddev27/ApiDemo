using System.ComponentModel.DataAnnotations;
using ApiDemo.Models.Validation;

namespace ApiDemo.Models;

public class Shirt
{
    public int Id { get; set; }
    [Required]
    public string? Brand { get; set; }
    [Required]
    public string? Color { get; set; }
    [ShirtCorrectSize]
    public int  Size { get; set; }
    [Required]
    public string? Gender { get; set; }
    public double Price { get; set; }
}