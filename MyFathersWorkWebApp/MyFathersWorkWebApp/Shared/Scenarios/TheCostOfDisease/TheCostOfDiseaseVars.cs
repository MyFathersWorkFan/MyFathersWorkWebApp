namespace MyFathersWorkWebApp;

public class TheCostOfDiseaseVars
{
    public Affiliation   Wolves       { get; set; }
    public Affiliation   Hunters      { get; set; }
    public int           Tracker      { get; set; } // Rename to -> SuspicionMarkerPos
    public bool          Creepy4      { get; set; }
    public bool          Seedy        { get; set; }
    public bool          Sane3        { get; set; }
    public string        Gen1Creep    { get; set; } = string.Empty;
    public string        Gen1Sane     { get; set; } = string.Empty;
    public bool          Vacation     { get; set; } = false;
    public string        Mayor        { get; set; } = string.Empty;
    public BankOrLibrary Building     { get; set; } = BankOrLibrary.None;
    public int           CharityTotal { get; set; } = 0;
    public string        Charity      { get; set; } = string.Empty;

    public void Reset()
    {
        Wolves       = Affiliation.Good;
        Hunters      = Affiliation.Evil;
        Tracker      = 0;
        Creepy4      = false;
        Seedy        = false;
        Sane3        = false;
        Gen1Creep    = string.Empty;
        Gen1Sane     = string.Empty;
        Vacation     = false;
        Mayor        = string.Empty;
        Building     = BankOrLibrary.None;
        CharityTotal = 0;
        Charity      = string.Empty;
    }
}