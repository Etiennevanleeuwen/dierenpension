using System.ComponentModel.DataAnnotations;
public class Client
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Address { get; set; } = "";
    public string Zipcode { get; set; } = "";
    public string City { get; set; } = "";

    [Required(ErrorMessage = "Telefoonnummer is verplicht")]
    [Phone(ErrorMessage = "Voer een geldig telefoonnummer in")]
    public string Phone { get; set; } = "";

    [Required(ErrorMessage = "E-mailadres is verplicht")]
    [EmailAddress(ErrorMessage = "Voer een geldig e-mailadres in")]
    public string Email { get; set; } = "";
}