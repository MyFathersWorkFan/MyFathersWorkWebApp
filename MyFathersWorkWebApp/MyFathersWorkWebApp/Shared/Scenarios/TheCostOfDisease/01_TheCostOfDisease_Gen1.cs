namespace MyFathersWorkWebApp;

public static partial class TheCostOfDisease
{
    private static void Fever1(GlobalData globalData)
    {
        // Round 1 -> Fever1
        // Round 2 -> Fever2
        // Round 3 -> Fever3
        globalData.ActiveHub = new()
        {
            Title    = globalData.GetScenarioLocalizedTag("Fever_Title"),
            Subtitle = globalData.GetScenarioLocalizedTag("Global_EarlyYears")
        };

        GameplayHubSection hospital = new GameplayHubSection
        {
            Main       = true,
            Title      = globalData.GetScenarioLocalizedTag("Fever1_Hospital_Title"),
            ShouldShow = () => true
        };

        hospital.AddElement(globalData.GetScenarioLocalizedTag("Fever1_Hospital_Content0"));
        hospital.AddElement(globalData.GetScenarioLocalizedTag("Fever1_Hospital_Content1"));

        GameplayHubSection bank = new GameplayHubSection
        {
            Main       = false,
            Title      = globalData.GetScenarioLocalizedTag("Fever1_Bank_Title"),
            ShouldShow = () => globalData.TheCostOfDiseaseVars.Building == BankOrLibrary.Bank
        };

        bank.AddElement(globalData.GetScenarioLocalizedTag("Fever1_Bank_Content"));

        GameplayHubSection library = new GameplayHubSection
        {
            Main       = false,
            Title      = globalData.GetScenarioLocalizedTag("Fever1_Library_Title"),
            ShouldShow = () => globalData.TheCostOfDiseaseVars.Building == BankOrLibrary.Library
        };

        library.AddElement(globalData.GetScenarioLocalizedTag("Fever1_Library_Content"));

        GameplayHubSection creepy = new GameplayHubSection
        {
            Main       = false,
            Title      = globalData.GetScenarioLocalizedTag("Fever1_Creepy_Title"),
            ShouldShow = () => !globalData.TheCostOfDiseaseVars.Creepy4
        };

        creepy.AddElement(globalData.GetScenarioLocalizedTag("Fever1_Creepy_Content"));
        creepy.AddElement(globalData.GetScenarioLocalizedTag("Global_ClickHere"), Gen1CreepyTrack);

        GameplayHubSection sane = new GameplayHubSection
        {
            Main       = false,
            Title      = globalData.GetScenarioLocalizedTag("Fever1_Sane_Title"),
            ShouldShow = () => !globalData.TheCostOfDiseaseVars.Sane3
        };

        sane.AddElement(globalData.GetScenarioLocalizedTag("Fever1_Sane_Content"));
        sane.AddElement(globalData.GetScenarioLocalizedTag("Global_ClickHere"), Gen1SanityTrack);

        GameplayHubSection endEarlyMiddle = new GameplayHubSection
        {
            Main       = false,
            Title      = globalData.GetScenarioLocalizedTag("Fever1_End_Title"),
            ShouldShow = () => globalData.Years is Years.Early or Years.Middle
        };
        
        endEarlyMiddle.AddElement(globalData.GetScenarioLocalizedTag("Fever1_End_Content"));
        endEarlyMiddle.AddElement(globalData.GetScenarioLocalizedTag("Global_ClickHereContinueNextRound"), Fever1_0, true);

        GameplayHubSection endLate = new GameplayHubSection
        {
            Main       = false,
            Title      = globalData.GetScenarioLocalizedTag("Global_EndOfGeneration_Title"),
            ShouldShow = () => globalData.Years is Years.Late
        };
        
        endLate.AddElement(globalData.GetScenarioLocalizedTag("Global_ClickAtTheEndOfGeneration"), Fever1_0);

        globalData.ActiveHub.Sections.Add(hospital);
        globalData.ActiveHub.Sections.Add(bank);
        globalData.ActiveHub.Sections.Add(library);
        globalData.ActiveHub.Sections.Add(creepy);
        globalData.ActiveHub.Sections.Add(sane);
        globalData.ActiveHub.Sections.Add(endEarlyMiddle);
        globalData.ActiveHub.Sections.Add(endLate);
    }

    private static void Fever1_0(GlobalData globalData)
    {
        globalData.ShowEndOfRoundPopUp(globalData.Years switch
        {
            Years.Early  => FeverServe1,
            Years.Middle => S5Special1,
            Years.Late   => FeverHeart,
            _            => _ => { }
        }, () =>
        {
            if (globalData.Generation == Generation.Second) globalData.ActiveHub = null;
            else
            {
                globalData.ActiveHub!.Subtitle = globalData.GetScenarioLocalizedTag(globalData.Years switch
                {
                    Years.Early  => "Global_EarlyYears",
                    Years.Middle => "Global_MiddleYears",
                    Years.Late   => "Global_LateYears",
                    _            => string.Empty
                });
            }
        });
    }

    #region Gen1CreepyTrack

    private static void Gen1CreepyTrack(GlobalData globalData)
    {
        globalData.ActiveWindow = new GameplayWindow
        {
            Title    = globalData.GetScenarioLocalizedTag("Gen1CreepyTrack_Title"),
            Subtitle = string.Empty
        };

        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Gen1CreepyTrack_Content0"));
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Gen1CreepyTrack_Content1"), true);
        globalData.ActiveWindow.AddAllPlayersNamesAsOptions(globalData, Gen1CreepyTrack_0);
    }

    private static void Gen1CreepyTrack_0(string creepName, GlobalData globalData)
    {
        globalData.TheCostOfDiseaseVars.Gen1Creep = creepName;
        globalData.TheCostOfDiseaseVars.Creepy4   = true;
        Gen1CreepyTrackRes(globalData);
    }

    private static void Gen1CreepyTrackRes(GlobalData globalData)
    {
        globalData.ActiveWindow = new GameplayWindow
        {
            Title    = globalData.GetScenarioLocalizedTag("Gen1CreepyTrackRes_Title"),
            Subtitle = string.Empty
        };

        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Global_DoNotOtherPlayersSee").Format(globalData.TheCostOfDiseaseVars.Gen1Creep));
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Global_OnceYouAreReady"), Gen1CreepyTrackRes_0, true);
    }

    private static void Gen1CreepyTrackRes_0(GlobalData globalData)
    {
        if (globalData.TheCostOfDiseaseVars.Hunters == Affiliation.Evil) Gen1CreepyTrackRes_1(globalData);
        else Gen1CreepyTrackRes_2(globalData);
    }

    private static void Gen1CreepyTrackRes_1(GlobalData globalData)
    {
        globalData.ActiveWindow = new GameplayWindow
        {
            Title    = globalData.GetScenarioLocalizedTag("Gen1CreepyTrackRes_Title"),
            Subtitle = string.Empty
        };

        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Gen1CreepyTrackRes_1_Content").Format(globalData.TheCostOfDiseaseVars.Gen1Creep));
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Global_Choose"),               true);
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Gen1CreepyTrackRes_1_Accept"), Gen1CreepyYes, true);
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Gen1CreepyTrackRes_1_Accept_Desc"));
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Gen1CreepyTrackRes_1_Refuse"), Gen1CreepyNo, true);
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Gen1CreepyTrackRes_1_Refuse_Desc"));
    }

    private static void Gen1CreepyTrackRes_2(GlobalData globalData)
    {
        globalData.ActiveWindow = new GameplayWindow
        {
            Title    = globalData.GetScenarioLocalizedTag("Gen1CreepyTrackRes_Title"),
            Subtitle = string.Empty
        };

        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Gen1CreepyTrackRes_2_Content").Format(globalData.TheCostOfDiseaseVars.Gen1Creep));
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Global_Choose"),               true);
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Gen1CreepyTrackRes_2_Accept"), Gen1CreepyYes, true);
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Gen1CreepyTrackRes_2_Accept_Desc"));
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Gen1CreepyTrackRes_2_Refuse"), Gen1CreepyNo, true);
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Gen1CreepyTrackRes_2_Refuse_Desc"));
    }

    private static void Gen1CreepyYes(GlobalData globalData)
    {
        globalData.TheCostOfDiseaseVars.Seedy = true;
        if (globalData.TheCostOfDiseaseVars.Hunters == Affiliation.Evil) Gen1CreepyYes_A(globalData);
        else Gen1CreepyYes_B(globalData);
    }

    private static void Gen1CreepyYes_A(GlobalData globalData)
    {
        globalData.ActiveWindow = new GameplayWindow
        {
            Title    = globalData.GetScenarioLocalizedTag("Gen1CreepyYes_Title"),
            Subtitle = string.Empty
        };

        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Gen1CreepyYes_A_Content"));
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Global_ClickHereToContinue"), Gen1CreepyYes_A0, true);
    }

    private static void Gen1CreepyYes_A0(GlobalData globalData)
    {
        globalData.ActivePopup = new GameplayPopup
        {
            Title       = globalData.GetScenarioLocalizedTag("Global_SpecialSetup"),
            Description = globalData.GetScenarioLocalizedTag("Gen1CreepyYes_A0"),
            ImageSrc    = "Money_Icon",
            ButtonText  = globalData.GetScenarioLocalizedTag("Global_Accept"),
            OnClose     = _ => { }
        };
    }

    private static void Gen1CreepyYes_B(GlobalData globalData)
    {
        globalData.ActiveWindow = new GameplayWindow
        {
            Title    = globalData.GetScenarioLocalizedTag("Gen1CreepyYes_Title"),
            Subtitle = string.Empty
        };

        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Gen1CreepyYes_B_Content").Format(globalData.TheCostOfDiseaseVars.Gen1Creep));
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Global_ClickHereToContinue"), Gen1CreepyYes_B0, true);
    }

    private static void Gen1CreepyYes_B0(GlobalData globalData)
    {
        globalData.ActivePopup = new GameplayPopup
        {
            Title       = globalData.GetScenarioLocalizedTag("Global_SpecialSetup"),
            Description = globalData.GetScenarioLocalizedTag("Gen1CreepyYes_B0"),
            ImageSrc    = "MFWlogo",
            ButtonText  = globalData.GetScenarioLocalizedTag("Global_Accept"),
            OnClose     = _ => { }
        };
    }

    private static void Gen1CreepyNo(GlobalData globalData)
    {
        globalData.TheCostOfDiseaseVars.Seedy = false;

        globalData.ActiveWindow = new GameplayWindow
        {
            Title    = globalData.GetScenarioLocalizedTag("Gen1CreepyNo_Title"),
            Subtitle = string.Empty
        };

        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Gen1CreepyNo_Content").Format(globalData.TheCostOfDiseaseVars.Gen1Creep));
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Global_ClickHereToContinue"), Gen1CreepyNo_0, true);
    }

    private static void Gen1CreepyNo_0(GlobalData globalData)
    {
        globalData.ActivePopup = new GameplayPopup
        {
            Title       = globalData.GetScenarioLocalizedTag("Global_SpecialSetup"),
            ImageSrc    = "Creepy_Icon",
            Description = "",
            ButtonText  = globalData.GetScenarioLocalizedTag("Global_Accept"),
            OnClose     = _ => { }
        };

        if (new List<int> { 1, 2 }.GetRandom() == 1)
        {
            globalData.ActivePopup.Description += globalData.GetScenarioLocalizedTag("Gen1CreepyNo_0_Content0");
        }
        
        globalData.ActivePopup.Description += globalData.GetScenarioLocalizedTag("Gen1CreepyNo_0_Content1");
    }

    #endregion Gen1CreepyTrack

    #region Gen1SanityTrack

    private static void Gen1SanityTrack(GlobalData globalData)
    {
        globalData.ActiveWindow = new GameplayWindow
        {
            Title    = globalData.GetScenarioLocalizedTag("Gen1SanityTrack_Title"),
            Subtitle = string.Empty
        };

        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Gen1SanityTrack_Content0"));
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Gen1SanityTrack_Content1"), true);
        globalData.ActiveWindow.AddAllPlayersNamesAsOptions(globalData, Gen1SanityTrack_0);
    }

    private static void Gen1SanityTrack_0(string saneName, GlobalData globalData)
    {
        globalData.TheCostOfDiseaseVars.Gen1Sane = saneName;
        globalData.TheCostOfDiseaseVars.Sane3    = true;
        Gen1SanityTrackRes(globalData);
    }

    private static void Gen1SanityTrackRes(GlobalData globalData)
    {
        globalData.ActiveWindow = new GameplayWindow
        {
            Title    = globalData.GetScenarioLocalizedTag("Gen1SanityTrack_Title"),
            Subtitle = string.Empty
        };

        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Global_DoNotOtherPlayersSee").Format(globalData.TheCostOfDiseaseVars.Gen1Sane));
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Global_OnceYouAreReady"), Gen1SanityTrackRes_0, true);
    }

    private static void Gen1SanityTrackRes_0(GlobalData globalData)
    {
        globalData.ActiveWindow = new GameplayWindow
        {
            Title    = globalData.GetScenarioLocalizedTag("Gen1SanityTrack_Title"),
            Subtitle = string.Empty
        };

        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Gen1SanityTrackRes_0_Content").Format(globalData.TheCostOfDiseaseVars.Gen1Sane));
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Global_Choose"), true);
        globalData.ActiveWindow.Elements.Add(new GameplayElement(globalData.GetScenarioLocalizedTag("Gen1SanityTrackRes_0_Accept"), Gen1SanityYes, true));
        globalData.ActiveWindow.Elements.Add(new GameplayElement(globalData.GetScenarioLocalizedTag("Gen1SanityTrackRes_0_Accept_Desc")));
        globalData.ActiveWindow.Elements.Add(new GameplayElement(globalData.GetScenarioLocalizedTag("Gen1SanityTrackRes_0_Refuse"), Gen1SanityNo, true));
        globalData.ActiveWindow.Elements.Add(new GameplayElement(globalData.GetScenarioLocalizedTag("Gen1SanityTrackRes_0_Refuse_Desc")));
    }

    private static void Gen1SanityYes(GlobalData globalData)
    {
        globalData.ActiveWindow = new GameplayWindow
        {
            Title    = globalData.GetScenarioLocalizedTag("Gen1SanityYes_Title"),
            Subtitle = string.Empty
        };

        globalData.TheCostOfDiseaseVars.Vacation = true;

        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Gen1SanityYes_Content").Format(globalData.TheCostOfDiseaseVars.Gen1Sane));
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Global_ClickHereToContinue"), Gen1SanityYes_0, true);
    }

    private static void Gen1SanityYes_0(GlobalData globalData)
    {
        globalData.ActivePopup = new GameplayPopup
        {
            Title       = globalData.GetScenarioLocalizedTag("Global_SpecialSetup"),
            ImageSrc    = "AnyKnowledge_Icon",
            Description = globalData.GetScenarioLocalizedTag("Gen1SanityYes_0_Content"),
            ButtonText  = globalData.GetScenarioLocalizedTag("Global_Accept"),
            OnClose     = _ => { }
        };
    }

    private static void Gen1SanityNo(GlobalData globalData)
    {
        globalData.ActiveWindow = new GameplayWindow
        {
            Title    = globalData.GetScenarioLocalizedTag("Gen1SanityNo_Title"),
            Subtitle = string.Empty
        };

        globalData.TheCostOfDiseaseVars.Vacation = false;

        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Gen1SanityNo_Content").Format(globalData.TheCostOfDiseaseVars.Gen1Sane));
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Global_ClickHereToContinue"), Gen1SanityNo_0, true);
    }

    private static void Gen1SanityNo_0(GlobalData globalData)
    {
        globalData.ActivePopup = new GameplayPopup
        {
            Title       = globalData.GetScenarioLocalizedTag("Global_SpecialSetup"),
            ImageSrc    = "Creepy_Icon",
            Description = "",
            ButtonText  = globalData.GetScenarioLocalizedTag("Global_Accept"),
            OnClose     = _ => { }
        };

        if (new List<int> { 1, 2 }.GetRandom() == 1)
        {
            globalData.ActivePopup.Description += globalData.GetScenarioLocalizedTag("Gen1SanityNo_0_Content0");
        }
        
        globalData.ActivePopup.Description += globalData.GetScenarioLocalizedTag("Gen1SanityNo_0_Content1");
    }

    #endregion Gen1SanityTrack

    #region End of The Round

    private static void FeverServe1(GlobalData globalData)
    {
        globalData.ActiveWindow = new GameplayWindow
        {
            Title    = globalData.GetScenarioLocalizedTag("FeverServe1_Title"),
            Subtitle = string.Empty
        };

        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("FeverServe1_Content").Format(globalData.GetLocalizedPlayerNumber()));
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Global_ClickHereToContinue"), FeverServe1_0, true);
    }

    private static void FeverServe1_0(GlobalData globalData)
    {
        globalData.ActivePopup = new GameplayPopup
        {
            Title       = globalData.GetScenarioLocalizedTag("Global_Setup"),
            ImageSrc    = "GainServantFromLost",
            Description = globalData.GetScenarioLocalizedTag("FeverServe1_0_Content"),
            ButtonText  = globalData.GetScenarioLocalizedTag("Global_Accept"),
            OnClose     = _ => { }
        };
    }

    private static void FeverHeart(GlobalData globalData)
    {
        globalData.ActiveInputPopup = new GameplayInputPopup
        {
            Message     = globalData.GetScenarioLocalizedTag("FeverHeart_Content"),
            ButtonText  = globalData.GetScenarioLocalizedTag("Global_Confirm"),
            Placeholder = "0",
            Validate = value =>
            {
                if (!int.TryParse(value, out int x)) return false;
                if (x < 0) return false;
                if (x > 100) return false;
                return true;
            },
            OnClose = FeverHeart_0
        };
    }

    private static void FeverHeart_0(string numberOfHearts, GlobalData globalData)
    {
        globalData.TheCostOfDiseaseVars.CharityTotal = int.Parse(numberOfHearts);

        globalData.ActiveWindow = new GameplayWindow
        {
            Title    = globalData.GetScenarioLocalizedTag("FeverHeart_0_Title"),
            Subtitle = string.Empty
        };

        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("FeverHeart_0_Content"));
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Global_ClickHereToContinue"), FeverHeart2, true);
    }

    #endregion End of The Round

    #region S5Special1

    private static void S5Special1(GlobalData globalData)
    {
        globalData.ActiveWindow = new GameplayWindow
        {
            Title    = globalData.GetScenarioLocalizedTag("S5Special1_Title"),
            Subtitle = string.Empty
        };

        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("S5Special1_Content0"));
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("S5Special1_Content1"));
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Global_ClickHereToContinue"), S5Special1A, true);
    }

    private static void S5Special1A(GlobalData globalData)
    {
        globalData.ActiveWindow = new GameplayWindow
        {
            Title    = globalData.GetScenarioLocalizedTag("S5Special1A_Title"),
            Subtitle = string.Empty
        };

        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("S5Special1A_Content"));
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Global_ClickHereAfterBid"), S5Special1B, true);
    }

    private static void S5Special1B(GlobalData globalData)
    {
        globalData.ActiveWindow = new GameplayWindow
        {
            Title    = globalData.GetScenarioLocalizedTag("S5Special1B_Title"),
            Subtitle = string.Empty
        };

        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("S5Special1B_Content0").Format(globalData.TownName));
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("S5Special1B_Content1").Format(globalData.TownName), true);
        globalData.ActiveWindow.AddAllPlayersNamesAsOptions(globalData, S5Special1B_0);
    }

    private static void S5Special1B_0(string mayor, GlobalData globalData)
    {
        globalData.TheCostOfDiseaseVars.Mayor = mayor;
        S5SpecialSetup1(globalData);
    }

    private static void S5SpecialSetup1(GlobalData globalData)
    {
        globalData.ActivePopup = new GameplayPopup
        {
            Title       = globalData.GetScenarioLocalizedTag("Global_Setup"),
            ImageSrc    = "S1_MayorCoin",
            Description = globalData.GetScenarioLocalizedTag("S5SpecialSetup1_Content").Format(globalData.TheCostOfDiseaseVars.Mayor),
            ButtonText  = globalData.GetScenarioLocalizedTag("Global_Accept"),
            OnClose     = S5SpecialSetup1B
        };
    }

    private static void S5SpecialSetup1B(GlobalData globalData)
    {
        globalData.ActiveWindow = new GameplayWindow
        {
            Title    = globalData.GetScenarioLocalizedTag("S5SpecialSetup1B_Title"),
            Subtitle = string.Empty
        };

        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("S5SpecialSetup1B_Content"));
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("S5SpecialSetup1B_Bank"),    data => S5SpecialSetup1B_0(BankOrLibrary.Bank,    data), true);
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("S5SpecialSetup1B_Library"), data => S5SpecialSetup1B_0(BankOrLibrary.Library, data), true);
    }

    private static void S5SpecialSetup1B_0(BankOrLibrary bankOrLibrary, GlobalData globalData)
    {
        globalData.TheCostOfDiseaseVars.Building = bankOrLibrary;
        FeverServe2(globalData);
    }

    private static void FeverServe2(GlobalData globalData)
    {
        globalData.ActiveWindow = new GameplayWindow
        {
            Title    = globalData.GetScenarioLocalizedTag("FeverServe2_Title"),
            Subtitle = string.Empty
        };

        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("FeverServe2_Content"));
        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Global_ClickHereToContinue"), FeverServe2_0, true);
    }

    private static void FeverServe2_0(GlobalData globalData)
    {
        globalData.ActivePopup = new GameplayPopup
        {
            Title       = globalData.GetScenarioLocalizedTag("Global_Setup"),
            ImageSrc    = "GainServantFromLost",
            Description = globalData.GetScenarioLocalizedTag("FeverServe2_0_Content"),
            ButtonText  = globalData.GetScenarioLocalizedTag("Global_Accept"),
            OnClose     = FeverServe2_1
        };
    }

    private static void FeverServe2_1(GlobalData globalData)
    {
        globalData.ActivePopup = new GameplayPopup
        {
            Title      = globalData.GetScenarioLocalizedTag("Global_Setup"),
            ImageSrc   = "VillageChronicleCover",
            ButtonText = globalData.GetScenarioLocalizedTag("Global_Accept"),
            OnClose    = _ => { }
        };

        globalData.ActivePopup.Description = globalData.GetScenarioLocalizedTag("FeverServe2_1_Content0").Format(globalData.TheCostOfDiseaseVars.Building == BankOrLibrary.Bank ? "2" : "3");

        if (globalData.TheCostOfDiseaseVars.Building == BankOrLibrary.Bank) globalData.ActivePopup.Description += $"<br /> {globalData.GetScenarioLocalizedTag("FeverServe2_1_Content1").Format(globalData.TheCostOfDiseaseVars.Mayor)}";
    }

    #endregion S5Special1

    #region Resolving Hearts

    private static void FeverHeart2(GlobalData globalData)
    {
        globalData.ActivePopup = new GameplayPopup
        {
            Title       = globalData.GetScenarioLocalizedTag("Global_SpecialSetup"),
            ImageSrc    = "S1_HeartToken",
            Description = globalData.GetScenarioLocalizedTag("FeverHeart2_Content"),
            ButtonText  = globalData.GetScenarioLocalizedTag("Global_Accept"),
            OnClose     = FeverHeart2_0
        };
    }

    private static void FeverHeart2_0(GlobalData globalData)
    {
        globalData.ActiveWindow = new GameplayWindow
        {
            Title    = globalData.GetScenarioLocalizedTag("FeverHeart2_0_Title"),
            Subtitle = string.Empty
        };

        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("FeverHeart2_0_Content"));
        globalData.ActiveWindow.AddAllPlayersNamesAsOptions(globalData, FeverHeart2_1);
    }

    private static void FeverHeart2_1(string heartPlayer, GlobalData globalData)
    {
        globalData.TheCostOfDiseaseVars.Charity = heartPlayer;

        globalData.ActivePopup = new GameplayPopup
        {
            Title       = globalData.GetScenarioLocalizedTag("Global_EndOfGeneration_Title"),
            ImageSrc    = "MFWlogo",
            Description = globalData.GetScenarioLocalizedTag("FeverHeart2_1_Content"),
            ButtonText  = globalData.GetScenarioLocalizedTag("Global_Confirm"),
            OnClose     = new List<Action<GlobalData>> { S5Fate1, S5Fate2 }.GetRandom()
        };
    }

    private static void S5Fate1(GlobalData globalData)
    {
        globalData.ActiveWindow = new GameplayWindow
        {
            Title    = globalData.GetScenarioLocalizedTag("S5Fate1_Title"),
            Subtitle = string.Empty
        };

        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("S5Fate1_Content0").Format(globalData.TownName));

        if (globalData.TheCostOfDiseaseVars.Building == BankOrLibrary.Bank)
        {
            globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("S5Fate1_Content1"), true);
            globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Global_ClickHereToContinue"), HospitalIntro, true);
        }
        else
        {
            globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("S5Fate1_Content2"), true);
            globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Global_ClickHereToContinue"), DevastationIntro, true);
        }
    }

    private static void S5Fate2(GlobalData globalData)
    {
        globalData.ActiveWindow = new GameplayWindow
        {
            Title    = globalData.GetScenarioLocalizedTag("S5Fate2_Title"),
            Subtitle = string.Empty
        };

        globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("S5Fate2_Content0"));

        int heartNeeded = globalData.PlayersNum switch
        {
            2 => 3,
            3 => 6,
            _ => 8 // 4 players
        };

        heartNeeded += new List<int> { 1, 2, 3, 4, 5, 6 }.GetRandom();

        if (globalData.TheCostOfDiseaseVars.CharityTotal > heartNeeded)
        {
            globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("S5Fate2_Content1").Format(heartNeeded.ToString()), true);
            globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Global_ClickHereToContinue"), HospitalIntro, true);
        }
        else
        {
            globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("S5Fate2_Content2").Format(heartNeeded.ToString()), true);
            globalData.ActiveWindow.AddElement(globalData.GetScenarioLocalizedTag("Global_ClickHereToContinue"), DevastationIntro, true);
        }
    }

    #endregion Resolving Hearts
}