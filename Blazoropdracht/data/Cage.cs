public enum CageSize { S, M, L }

public class Cage
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public CageSize Size { get; set; }
}