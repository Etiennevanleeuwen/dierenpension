using System.ComponentModel.DataAnnotations;
using Blazoropdracht;

public class Reservation : IValidatableObject
{
    public int Id { get; set; }
    public int PetId { get; set; }
    public Pet? Pet { get; set; }
    public int CageId { get; set; }
    public Cage? Cage { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (EndDate < StartDate)
            yield return new ValidationResult(
                "End date cannot be before start date.",
                [nameof(EndDate)]);
    }
}