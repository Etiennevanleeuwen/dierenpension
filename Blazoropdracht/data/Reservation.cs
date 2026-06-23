using Blazoropdracht;

public class Reservation
{
    public int Id { get; set; }
    public int PetId { get; set; }
    public Pet? Pet { get; set; }
    public int CageId { get; set; }
    public Cage? Cage { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
}