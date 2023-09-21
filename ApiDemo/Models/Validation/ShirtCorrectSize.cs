using System.ComponentModel.DataAnnotations;

namespace ApiDemo.Models.Validation;

public class ShirtCorrectSize : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        var shirt = validationContext.ObjectInstance as Shirt;

        if (shirt != null && !string.IsNullOrWhiteSpace(shirt.Gender))
        {
            if (shirt.Gender.Equals("men", StringComparison.OrdinalIgnoreCase) && shirt.Size < 8)
            {
                return new ValidationResult("For men the shirt size has to be greater than 8");
            }
            else if(shirt.Gender.Equals("female", StringComparison.OrdinalIgnoreCase) && shirt.Size < 6)
            {
                return new ValidationResult("For women the shirt size has to be greater than 6");
            }
        }
        return ValidationResult.Success;
    }
}