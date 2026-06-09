namespace Blazoropdracht;

public class Pet
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int ClientId { get; set; }
    public Client? Client { get; set; }

    public Pet() { }

    public Pet(string name, Client client)
    {
        Name = name;
        Client = client ?? throw new ArgumentNullException(nameof(client));
        ClientId = client.Id;
    }
}