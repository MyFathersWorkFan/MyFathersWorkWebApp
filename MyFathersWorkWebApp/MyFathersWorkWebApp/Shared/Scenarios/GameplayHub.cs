namespace MyFathersWorkWebApp;

public class GameplayHub
{
    public string                   Title    { get; set; } = string.Empty;
    public string                   Subtitle { get; set; } = string.Empty;
    public List<GameplayHubSection> Sections { get; set; } = new();
}