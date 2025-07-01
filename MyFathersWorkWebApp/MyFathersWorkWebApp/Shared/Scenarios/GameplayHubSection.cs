namespace MyFathersWorkWebApp;

public class GameplayHubSection
{
    public bool                  Main       { get; set; }
    public string                Title      { get; set; } = string.Empty;
    public List<GameplayElement> Elements   { get; }      = new();
    public Func<bool>            ShouldShow { get; set; } = () => true;
    
    public void AddElement(string content, bool fromNewLine = false)
    {
        Elements.Add(new GameplayElement(content, null, fromNewLine));
    }
    
    public void AddElement(string content, Action<GlobalData>? callback, bool fromNewLine = false)
    {
        Elements.Add(new GameplayElement(content, callback, fromNewLine));
    }
}