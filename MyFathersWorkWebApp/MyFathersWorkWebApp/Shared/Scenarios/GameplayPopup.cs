namespace MyFathersWorkWebApp;

public class GameplayPopup
{
    public string             Title       { get; set; } = string.Empty;
    public string             Description { get; set; } = string.Empty;
    public string             ImageSrc    { get; set; } = string.Empty;
    public string             ButtonText  { get; set; } = string.Empty;
    public Action<GlobalData> OnClose     { get; set; } = null!;
}