namespace Projekt_zaliczenie.Models;

public class RocketStatus
{
    public int Id { get; set; }
    public string Status { get; set; }
    public List<Mission> Missions { get; set; }
}