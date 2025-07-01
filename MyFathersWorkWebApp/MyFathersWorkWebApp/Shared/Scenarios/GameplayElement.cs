namespace MyFathersWorkWebApp;

public class GameplayElement
{
    public string              Content     { get; } = string.Empty;
    public Action<GlobalData>? Callback    { get; set; }
    public bool                FromNewLine { get; set; }
    
    public GameplayElement(string content, Action<GlobalData>? callback = null, bool fromNewLine = false)
    {
        Content     = content;
        Callback    = callback;
        FromNewLine = fromNewLine;
    }
}