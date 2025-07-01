namespace MyFathersWorkWebApp;

public class GameplayInputPopup
{
    public string                     Message     { get; set; } = string.Empty;
    public string                     Placeholder { get; set; } = string.Empty;
    public string                     ButtonText  { get; set; } = string.Empty;
    public Func<string, bool>         Validate    { get; set; } = null!;
    public Action<string, GlobalData> OnClose     { get; set; } = null!;
}