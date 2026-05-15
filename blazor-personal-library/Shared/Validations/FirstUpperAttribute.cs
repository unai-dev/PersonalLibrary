using System.ComponentModel.DataAnnotations;

namespace blazor_personal_library.Shared.Validations
{
    public class FirstUpperAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }

            var valueToString = value.ToString()!;
            var firstLetter = valueToString[0].ToString();

            if (firstLetter != firstLetter.ToUpper())
            {
                return new ValidationResult("The first letter may be upper");
            }

            return ValidationResult.Success;
        }
    }
}
