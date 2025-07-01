namespace MyFathersWorkWebApp;

public class GameplayWindow
{
    public string                Title    { get; set; } = string.Empty;
    public string                Subtitle { get; set; } = string.Empty;
    public List<GameplayElement> Elements { get; }      = new();

    public void AddElement(string content, bool fromNewLine = false)
    {
        Elements.Add(new GameplayElement(content, null, fromNewLine));
    }
    
    public void AddElement(string content, Action<GlobalData>? callback, bool fromNewLine = false)
    {
        Elements.Add(new GameplayElement(content, callback, fromNewLine));
    }

    public void AddAllPlayersNamesAsOptions(GlobalData globalData, Action<string, GlobalData> nextCallback)
    {
        AddElement(globalData.PlayerAName, data => nextCallback(data.PlayerAName, data), true);
        AddElement(globalData.PlayerBName, data => nextCallback(data.PlayerBName, data), true);
        if (globalData.PlayersNum >= 3) AddElement(globalData.PlayerCName, data => nextCallback(data.PlayerCName, data), true);
        if (globalData.PlayersNum >= 4) AddElement(globalData.PlayerDName, data => nextCallback(data.PlayerDName, data), true);
    }
}