using System.ComponentModel.DataAnnotations;

namespace Blazoropdracht;
public enum Diersoort { Hond, Kat, Cavia, Konijn, Vogel, Overig }
public class Pet
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int ClientId { get; set; }
    public Client? Client { get; set; }
    [Required(ErrorMessage = "Kies een diersoort")]
    public Diersoort Diersoort { get; set; }

    [Required(ErrorMessage = "Ras is verplicht")]
    public string Ras { get; set; } = "";

    public bool GebruiktMedicijnen { get; set; }

    [StringLength(200, ErrorMessage = "Maximaal 200 tekens")]
    public string? MedicijnBeschrijving { get; set; }

    public bool SpeeltGoedMetAndereHonden { get; set; }

    public bool IsGevaarlijk { get; set; }

    [StringLength(300)]
    public string? GedragsOpmerkingen { get; set; }
    public Pet() { }

    public Pet(string name, Client client)
    {
        Name = name;
        Client = client ?? throw new ArgumentNullException(nameof(client));
        ClientId = client.Id;
    }
} 