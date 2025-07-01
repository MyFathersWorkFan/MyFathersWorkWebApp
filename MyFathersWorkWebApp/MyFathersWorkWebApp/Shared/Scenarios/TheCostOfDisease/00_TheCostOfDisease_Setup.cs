namespace MyFathersWorkWebApp;

public static partial class TheCostOfDisease
{
    public static void Init(GlobalData globalData)
    {
        globalData.ActiveWindow = new GameplayWindow
        {
            Title    = globalData.GetScenarioLocalizedTag("Init_Title"),
            Subtitle = string.Empty
        };

        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Init_Main").Format(globalData.GetLocalizedPlayerNumber()));
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Global_ClickHereToContinue"), ImmortalitySetup, true);
    }

    private static void ImmortalitySetup(GlobalData globalData)
    {
        globalData.ActiveWindow = new GameplayWindow
        {
            Title    = globalData.GetScenarioLocalizedTag("Immortality_Title"),
            Subtitle = string.Empty
        };

        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Immortality_Content"));
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Global_ClickHereToContinue"), ScenarioStart, true);
    }

    private static void ScenarioStart(GlobalData globalData)
    {
        globalData.ActiveWindow = new GameplayWindow
        {
            Title    = globalData.GetScenarioLocalizedTag("ScenarioStart_Title"),
            Subtitle = globalData.GetScenarioLocalizedTag("ScenarioStart_SubTitle")
        };

        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("ScenarioStart_Content"));
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Global_ClickHereToContinue"), Dubious, true);

        List<Affiliation> affiliations;

        if (globalData.TownName == "Rage")
        {
            affiliations = [Affiliation.Evil, Affiliation.Good];
        }
        else if (globalData.TownName == "Kraven")
        {
            affiliations = [Affiliation.Good, Affiliation.Evil];
        }
        else
        {
            affiliations = [Affiliation.Good, Affiliation.Evil];
            affiliations.Shuffle();
        }

        globalData.TheCostOfDiseaseVars.Wolves  = affiliations[0];
        globalData.TheCostOfDiseaseVars.Hunters = affiliations[1];
    }

    private static void Dubious(GlobalData globalData)
    {
        globalData.ActiveWindow = new GameplayWindow
        {
            Title    = globalData.GetScenarioLocalizedTag("Dubious_Title"),
            Subtitle = string.Empty
        };

        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Dubious_Content"));
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Global_ClickHereToContinue"), Dubious_0, true);
    }

    private static void Dubious_0(GlobalData globalData)
    {
        globalData.ActivePopup = new GameplayPopup
        {
            Title       = globalData.GetScenarioLocalizedTag("Global_Setup"),
            Description = globalData.GetScenarioLocalizedTag("Dubious_0_Content"),
            ImageSrc    = "S1_DubiousBartering",
            ButtonText  = globalData.GetScenarioLocalizedTag("Global_Accept"),
            OnClose     = SpecialGen1
        };
    }

    private static void SpecialGen1(GlobalData globalData)
    {
        globalData.ActivePopup = new GameplayPopup
        {
            Title       = globalData.GetScenarioLocalizedTag("Global_SpecialSetup"),
            Description = globalData.GetScenarioLocalizedTag("SpecialGen1_Content"),
            ImageSrc    = "StorybookToken",
            ButtonText  = globalData.GetScenarioLocalizedTag("Global_Accept"),
            OnClose     = FirstTimeSuspicion
        };
    }

    private static void FirstTimeSuspicion(GlobalData globalData)
    {
        globalData.TheCostOfDiseaseVars.Tracker = globalData.PlayersNum switch
        {
            2 => new List<int> { 6, 7 }.GetRandom(),
            3 => new List<int> { 7, 8 }.GetRandom(),
            _ => new List<int> { 9, 10, 11 }.GetRandom() // 4
        };

        globalData.ActivePopup = new GameplayPopup
        {
            Title       = globalData.GetScenarioLocalizedTag("Global_Setup"),
            Description = globalData.GetScenarioLocalizedTag("FirstTimeSuspicion_Content").Format(globalData.TheCostOfDiseaseVars.Tracker.ToString()),
            ImageSrc    = "AngryMobSetup1",
            ButtonText  = globalData.GetScenarioLocalizedTag("Global_Accept"),
            OnClose     = FirstPlayer
        };
    }

    private static void FirstPlayer(GlobalData globalData)
    {
        string firstPlayerName = globalData.PlayersNum switch
        {
            2 => new List<string> { globalData.PlayerAName, globalData.PlayerBName }.GetRandom(),
            3 => new List<string> { globalData.PlayerAName, globalData.PlayerBName, globalData.PlayerCName }.GetRandom(),
            _ => new List<string> { globalData.PlayerAName, globalData.PlayerBName, globalData.PlayerDName }.GetRandom() // 4
        };

        globalData.ActivePopup = new GameplayPopup
        {
            Title       = globalData.GetScenarioLocalizedTag("Global_Setup"),
            Description = globalData.GetScenarioLocalizedTag("FirstPlayer_Content").Format(firstPlayerName),
            ImageSrc    = "StartPlayerToken",
            ButtonText  = globalData.GetScenarioLocalizedTag("Global_Accept"),
            OnClose     = Fever1
        };
    }
}