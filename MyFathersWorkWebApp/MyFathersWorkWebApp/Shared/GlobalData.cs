namespace MyFathersWorkWebApp;

public class GlobalData
{
    public Dictionary<string, Dictionary<string, string>> UI_Localization                { get; }      = new();
    public Dictionary<string, string>                     Scenario_Localization          { get; set; } = new();
    public Dictionary<string, string>                     Scenario_Gameplay_Localization { get; set; } = new();

    public string               Language             { get; set; } = "English";
    public ScenarioId           ScenarioId           { get; set; }
    public int                  PlayersNum           { get; set; }
    public string               PlayerAName          { get; set; } = string.Empty;
    public string               PlayerBName          { get; set; } = string.Empty;
    public string               PlayerCName          { get; set; } = string.Empty;
    public string               PlayerDName          { get; set; } = string.Empty;
    public string               TownName             { get; set; } = string.Empty;
    public Years                Years                { get; set; } = Years.Early;
    public Generation           Generation           { get; set; } = Generation.First;
    public TheCostOfDiseaseVars TheCostOfDiseaseVars { get; set; } = new();
    public GameplayHub?         ActiveHub            { get; set; }
    public GameplayWindow?      ActiveWindow         { get; set; }
    public GameplayPopup?       ActivePopup          { get; set; }
    public GameplayInputPopup?  ActiveInputPopup     { get; set; }

    public string GetLocalizedUITag(string tag)
    {
        if (UI_Localization.TryGetValue(Language, out Dictionary<string, string>? value))
        {
            if (value.TryGetValue(tag, out string? translation)) return translation;
            return $"Missing Translation -> {Language}/{tag}";
        }

        return $"Missing Language -> {Language}";
    }

    public string GetScenarioLocalizedTag(string tag)
    {
        if (Scenario_Localization.TryGetValue(tag, out string? value)) return value;
        if (Scenario_Gameplay_Localization.TryGetValue(tag, out value)) return value;
        return $"Missing Scenario Translation -> {tag}";
    }

    public string GetLocalizedPlayerNumber()
    {
        return PlayersNum switch
        {
            2 => GetLocalizedUITag("Players_NumTwo"),
            3 => GetLocalizedUITag("Players_NumThree"),
            4 => GetLocalizedUITag("Players_NumFour"),
            _ => GetLocalizedUITag($"Players_Num{PlayersNum}")
        };
    }

    public string GetPlayerNameByIndex(int index)
    {
        return index switch
        {
            0 => PlayerAName,
            1 => PlayerBName,
            2 => PlayerCName,
            3 => PlayerDName,
            _ => string.Empty
        };
    }

    public void ShowEndOfRoundPopUp(Action<GlobalData> nextCallback, Action beforeNextCallback)
    {
        ActivePopup = new GameplayPopup
        {
            Title      = GetScenarioLocalizedTag("Global_EndOfRound_Title"),
            ImageSrc   = "MFWlogo",
            ButtonText = GetScenarioLocalizedTag("Global_Confirm"),
            OnClose    = _ =>
            {
                if (Years == Years.Late)
                {
                    Years      =  Years.Early;
                    Generation += 1;
                }
                else
                {
                    Years += 1;
                }

                beforeNextCallback();
                nextCallback(this);
            }
        };

        string yearsTag = Years switch
        {
            Years.Early  => "Global_EarlyYears",
            Years.Middle => "Global_MiddleYears",
            Years.Late   => "Global_LateYears",
            _            => string.Empty
        };

        string generationTag = Generation switch
        {
            Generation.First  => "Global_FirstGeneration",
            Generation.Second => "Global_SecondGeneration",
            Generation.Third  => "Global_ThirdGeneration",
            _                 => string.Empty
        };

        ActivePopup.Description =  GetScenarioLocalizedTag("Global_EndOfRound_Content_0").Format(GetScenarioLocalizedTag(yearsTag), GetScenarioLocalizedTag(generationTag));
        ActivePopup.Description += "<br />";

        if (Years is Years.Early or Years.Middle)
        {
            string yearsTagPlus = (Years + 1) switch
            {
                Years.Early  => "Global_EarlyYears",
                Years.Middle => "Global_MiddleYears",
                Years.Late   => "Global_LateYears",
                _            => string.Empty
            };
            
            ActivePopup.Description += GetScenarioLocalizedTag("Global_EndOfRound_Content_1").Format(GetScenarioLocalizedTag(yearsTagPlus));
        }
        else
        {
            ActivePopup.Description += GetScenarioLocalizedTag("Global_EndOfRound_Content_2");
        }
    }
}