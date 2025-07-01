namespace MyFathersWorkConsole;

public static partial class Scenario
{
    private static void MethodImmortalitySetup()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", ((StaticGameState.seedy == "no") ? MethodGen1CreepyRefuseBonus : ((StaticGameState.seedy == "yes") ? MethodGen1CreepyAgreedReturn : MethodHospital2)));
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("To Infinity");
        Console.Write("</bold>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "StorybookToken";
        Console.WriteLine();
        Console.Write("Give each player a ");
        Console.Write("<bold>");
        Console.Write("<sprite=\"Storybook\" index=0>");
        Console.Write(" ");
        Console.Write("token");
        Console.Write("</bold>");
        Console.Write(".");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Each player chooses an incomplete track of their choice in their Journal and places their ");
        Console.Write("<sprite=\"Storybook\" index=0>");
        Console.Write(" ");
        Console.Write("token on the third level of that track.");
        Console.Write("</setupStyleEvnt>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage224_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", ((StaticGameState.seedy == "no") ? MethodGen1CreepyRefuseBonus : ((StaticGameState.seedy == "yes") ? MethodGen1CreepyAgreedReturn : MethodHospital2)));
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "StorybookToken";
        Console.WriteLine();
        Console.Write("Give each player a ");
        Console.Write("<bold>");
        Console.Write("<sprite=\"Storybook\" index=0>");
        Console.Write(" ");
        Console.Write("token");
        Console.Write("</bold>");
        Console.Write(".");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Each player chooses an incomplete track of their choice in their Journal and places their ");
        Console.Write("<sprite=\"Storybook\" index=0>");
        Console.Write(" ");
        Console.Write("token on the third level of that track.");
        Console.Write("</setupStyleEvnt>");
        optionsManager.PresentOptions();
    }

    private static void passage224_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage224_Fragment_0);
        optionsManager.PresentOptions();
    }


    private static void MethodDiseases2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.Diseases2nextPsg == "" || StaticGameState.Diseases2nextPsg == 0)
        {
            StaticGameState.Diseases2nextPsg = StaticGameState.GetRandom(new[]
            {
                1,
                2
            });
        }

        StaticGameState.disease2 = StaticGameState.Diseases2nextPsg;
        StaticGameState.devpage = 0;
        if (StaticGameState.disease2 == 1)
        {
            Console.Write("<bold>");
            Console.Write("A Cleansing");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write(
                "When the symptoms grew too fierce, they locked themselves away inside one of the myriad rooms of their estate. This resulted in an unfortunate loss of productivity and an odiferous contamination. When chemicals would not suffice for cleansing, it was deemed necessary to burn the entire room and start again.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hook>");
            optionsManager.AddOption("Click to continue...", passage225_Fragment_0);
            Console.Write("</hook>");
        }
        else
        {
            Console.Write("<bold>");
            Console.Write("Wasted Potential");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write(
                "While the disease that plagued the scientists was manageable, the effects were still tiresome. Time spent advancing what they considered \"true science\" was instead squandered upon practical medical applications to assuage their own afflictions.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hook>");
            optionsManager.AddOption("Click to continue...", passage225_Fragment_2);
            Console.Write("</hook>");
        }

        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage225_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", ((StaticGameState.seedy == "yes") ? MethodGen1CreepyConcealExpose : MethodDevastation3));
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "DiscardEstateUpgrade_Icon";
        Console.WriteLine();
        Console.Write("All players that have not completed their ");
        Console.Write("<bold>");
        Console.Write("Hereditary Disease Experiment");
        Console.Write("</bold>");
        Console.Write(" must ");
        Console.Write("<bold>");
        Console.Write("discard an Estate Upgrade tile");
        Console.Write("</bold>");
        Console.Write(" to the box or ");
        Console.Write("<bold>");
        Console.Write("lose 3VP");
        Console.Write("</bold>");
        Console.Write(".");
        Console.Write("</setupStyleEvnt>");
        optionsManager.PresentOptions();
    }

    private static void passage225_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage225_Fragment_0);
        optionsManager.PresentOptions();
    }

    private static void passage225_Fragment_2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", ((StaticGameState.seedy == "yes") ? MethodGen1CreepyConcealExpose : MethodDevastation3));
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "S1_DiseaseExperiment";
        Console.WriteLine();
        Console.Write("All players that have not completed their ");
        Console.Write("<bold>");
        Console.Write("Hereditary Disease Experiment");
        Console.Write("</bold>");
        Console.Write(" must ");
        Console.Write("<bold>");
        Console.Write("lose 2VP");
        Console.Write("</bold>");
        Console.Write(".");
        Console.Write("</setupStyleEvnt>");
        optionsManager.PresentOptions();
    }

    private static void passage225_Fragment_3()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage225_Fragment_2);
        optionsManager.PresentOptions();
    }


    private static void MethodDiseaseEnd()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Longevity and Clarity");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write(
            "Notes from this time period detail potential blueprints for a special room; a sanguine coagulant encased in a glass bubble and fed with an electrical current. Although there are no further mentions of the device, peculiarities in historical accounts suggest that some in the next generation received advice and assistance from an unknown source.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click here to determine the fate of the town...", passage226_Fragment_0);
        Console.Write("</hook>");
        optionsManager.PresentOptions();
    }

    private static void passage226_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", MethodDiseaseEffect);
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "S1_EstateUpgradeBACK";
        Console.WriteLine();
        Console.Write("Retrieve the ");
        Console.Write("<bold>");
        Console.Write("Stasis Chamber Estate Upgrade tiles");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("from the Scenario box. Any player with a completed, face-down, ");
        Console.Write("<bold>");
        Console.Write("Hereditary Disease Experiment");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("has the option of building the Stasis Chamber in their Estate. Players with the Hereditary Disease Experiment ");
        Console.Write("<bold>");
        Console.Write("stored");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("cannot accept this bonus. ");
        Console.Write("<italic>");
        Console.Write("You must still pay $ if you would like to build this tile in a new plot, or you can replace an existing Estate tile.");
        Console.Write("</italic>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Then, discard any face-down Hereditary Disease cards to the scenario box, along with any remaining Stasis Chamber Estate Upgrades.");
        Console.Write("</setupStyleEvnt>");
        optionsManager.PresentOptions();
    }

    private static void passage226_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click here to determine the fate of the town...", passage226_Fragment_0);
        optionsManager.PresentOptions();
    }


    private static void MethodWolfJoin()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Order of St. Hubertus");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("A messenger in a gray cloak marked with the insignia of a wolf's head arrived at the estate one evening. They smiled and the gleam of their white teeth shone in the moonlight.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Pledge your service to the Order of St. Hubertus.", passage227_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Decide to do nothing instead.", passage227_Fragment_1);
        Console.Write("</hook>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage227_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.wcount = int.Parse(StaticGameState.wcount) + 1;
        if (StaticGameState.meet == StaticGameState.nameA)
        {
            StaticGameState.allyA = "wolves";
        }

        if (StaticGameState.meet == StaticGameState.nameB)
        {
            StaticGameState.allyB = "wolves";
        }

        if (StaticGameState.meet == StaticGameState.nameC)
        {
            StaticGameState.allyC = "wolves";
        }

        if (StaticGameState.meet == StaticGameState.nameD)
        {
            StaticGameState.allyD = "wolves";
        }

        if (StaticGameState.meet == StaticGameState.nameE)
        {
            StaticGameState.allyE = "wolves";
        }

        if (StaticGameState.round == 5)
        {
            MethodDevastation2();
        }
        else
        {
            MethodDevastation3();
        }

        optionsManager.PresentOptions();
    }

    private static void passage227_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.round == 5)
        {
            MethodDevastation2();
        }
        else
        {
            MethodDevastation3();
        }

        optionsManager.PresentOptions();
    }


    private static void MethodHelpingEvil()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("A Reward for Service");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("Upon receipt of their inheritance, the newest Generation of scientists were surprised to find a generous addendum attached by the ");
        Console.Write(StaticGameState.society);
        Console.Write(". Aside from the notoriety afforded by this gift, as promised, a permanent structure was to be erected on their properties to aid in their experimental pursuits.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click to continue...", passage228_Fragment_0);
        Console.Write("</hook>");
        optionsManager.PresentOptions();
    }

    private static void passage228_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", MethodHelpingEvil2);
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = ((StaticGameState.society == "Fraternity of Hunters") ? "S1_HunterToken" : "S1_WolfToken");
        Console.WriteLine();
        Console.Write("Retrieve the ");
        Console.Write("<bold>");
        Console.Write(StaticGameState.society);
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("tokens. Retrieve the ");
        Console.Write("<bold>");
        Console.Write("Master's Study");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("Vanity Estate Upgrades.");
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.society == "Fraternity of Hunters")
        {
            if (StaticGameState.allyA == "hunters")
            {
                Console.Write(StaticGameState.nameA);
                Console.Write(" III gains ");
                Console.Write("<bold>");
                Console.Write("4VP");
                Console.Write("</bold>");
                Console.Write(" and gains a ");
                Console.Write(StaticGameState.society);
                Console.Write(" token.");
                Console.WriteLine();
                Console.WriteLine();
            }

            if (StaticGameState.allyB == "hunters")
            {
                Console.Write(StaticGameState.nameB);
                Console.Write(" III gains ");
                Console.Write("<bold>");
                Console.Write("4VP");
                Console.Write("</bold>");
                Console.Write(" and gains a ");
                Console.Write(StaticGameState.society);
                Console.Write(" token.");
                Console.WriteLine();
                Console.WriteLine();
            }

            if (StaticGameState.players > 2 && StaticGameState.allyC == "hunters")
            {
                Console.Write(StaticGameState.nameC);
                Console.Write(" III gains ");
                Console.Write("<bold>");
                Console.Write("4VP");
                Console.Write("</bold>");
                Console.Write(" and gains a ");
                Console.Write(StaticGameState.society);
                Console.Write(" token.");
                Console.WriteLine();
                Console.WriteLine();
            }

            if (StaticGameState.players > 3 && StaticGameState.allyD == "hunters")
            {
                Console.Write(StaticGameState.nameD);
                Console.Write(" III gains ");
                Console.Write("<bold>");
                Console.Write("4VP");
                Console.Write("</bold>");
                Console.Write(" and gains a ");
                Console.Write(StaticGameState.society);
                Console.Write(" token.");
                Console.WriteLine();
                Console.WriteLine();
            }

            if (StaticGameState.players > 4 && StaticGameState.allyE == "hunters")
            {
                Console.Write(StaticGameState.nameE);
                Console.Write(" III gains ");
                Console.Write("<bold>");
                Console.Write("4VP");
                Console.Write("</bold>");
                Console.Write(" and gains a ");
                Console.Write(StaticGameState.society);
                Console.Write(" token.");
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        else
        {
            if (StaticGameState.allyA == "wolves")
            {
                Console.Write(StaticGameState.nameA);
                Console.Write(" III gains ");
                Console.Write("<bold>");
                Console.Write("4VP");
                Console.Write("</bold>");
                Console.Write(" and gains a ");
                Console.Write(StaticGameState.society);
                Console.Write(" token.");
                Console.WriteLine();
                Console.WriteLine();
            }

            if (StaticGameState.allyB == "wolves")
            {
                Console.Write(StaticGameState.nameB);
                Console.Write(" III gains ");
                Console.Write("<bold>");
                Console.Write("4VP");
                Console.Write("</bold>");
                Console.Write(" and gains a ");
                Console.Write(StaticGameState.society);
                Console.Write(" token.");
                Console.WriteLine();
                Console.WriteLine();
            }

            if (StaticGameState.players > 2 && StaticGameState.allyC == "wolves")
            {
                Console.Write(StaticGameState.nameC);
                Console.Write(" III gains ");
                Console.Write("<bold>");
                Console.Write("4VP");
                Console.Write("</bold>");
                Console.Write(" and gains a ");
                Console.Write(StaticGameState.society);
                Console.Write(" token.");
                Console.WriteLine();
                Console.WriteLine();
            }

            if (StaticGameState.players > 3 && StaticGameState.allyD == "wolves")
            {
                Console.Write(StaticGameState.nameD);
                Console.Write(" III gains ");
                Console.Write("<bold>");
                Console.Write("4VP");
                Console.Write("</bold>");
                Console.Write(" and gains a ");
                Console.Write(StaticGameState.society);
                Console.Write(" token.");
                Console.WriteLine();
                Console.WriteLine();
            }

            if (StaticGameState.players > 4 && StaticGameState.allyE == "wolves")
            {
                Console.Write(StaticGameState.nameE);
                Console.Write(" III gains ");
                Console.Write("<bold>");
                Console.Write("4VP");
                Console.Write("</bold>");
                Console.Write(" and gains a ");
                Console.Write(StaticGameState.society);
                Console.Write(" token.");
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        Console.WriteLine();
        Console.Write("</setupStyleEvnt>");
        optionsManager.PresentOptions();
    }

    private static void passage228_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage228_Fragment_0);
        optionsManager.PresentOptions();
    }


    private static void MethodHelpingEvil2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", ((StaticGameState.society == "Fraternity of Hunters") ? MethodGloomyHunterIntro : MethodGloomyWolvesIntro));
        Console.Write("<bold>");
        Console.Write("SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "S1_EstateUpgradeBACK";
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<setupStyleEvnt>");
        Console.Write("Then, starting with the player with the ");
        Console.Write("<bold>");
        Console.Write("most Victory Points");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("and continuing in descending order of points, each player with a ");
        Console.Write(StaticGameState.society);
        Console.Write(" ");
        Console.Write("token chooses a ");
        Console.Write("<bold>");
        Console.Write("Master's Study");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("to build on their Estate. No additional cost is paid for a new plot to place this tile. ");
        Console.Write("<italic>");
        Console.Write("(Ties are broken by the player that went later in turn order in the previous round.) Return all unclaimed tiles to the box.");
        Console.Write("</italic>");
        Console.Write("</setupStyleEvnt>");
        Console.WriteLine();
        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodMWTokenResolve()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("The Work is Complete");
        Console.Write("</bold>");
        Console.WriteLine();
        StaticGameState.gen3pg = 1;
        Console.WriteLine();
        Console.Write(
            "The gathering of clawed monstrosities celebrated with keening wails as the Masterwork was completed in all of its glory. Surely, the legacy of the family would be secured forever. Yet, the watchful, glowing eyes of the crowd did not share this same deference to sentimentality.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "A furious cacophony of growls sounded as the monsters surrounded the experiment. Some scribbled away at notes, copying the formulas and schematics as best as they could while others simply traced every minute detail with their fingers and observed with interest.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("It was clear that they would have been much more able to understand and reproduce the results of the experiment if they had been given earlier access to the cousin's work over the years.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click to continue...", passage229_Fragment_0);
        Console.Write("</hook>");
        optionsManager.PresentOptions();
    }

    private static void passage229_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", ((StaticGameState.round == 10) ? MethodGloomyGothic1 : ((StaticGameState.round == 11) ? MethodGloomyGothic2 : MethodGloomyGothic3)));
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "ScoreTrackMarker";
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Resolve your Masterwork as normal. Then, for each Experiment under your Masterwork, ");
        Console.Write("<bold>");
        Console.Write("lose 4VP");
        Console.Write("</bold>");
        Console.Write(". Discard all cards under your Masterwork.");
        Console.Write("</setupStyleEvnt>");
        optionsManager.PresentOptions();
    }

    private static void passage229_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click here to return...", passage229_Fragment_0);
        optionsManager.PresentOptions();
    }


    private static void MethodEvilsforgive()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.society == "Order of St. Hubertus")
        {
            Console.Write("<bold>");
            Console.Write("Forgiveness");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write(
                "The scientists' doubts were put at ease when a werewolf in a brown sack suit took to the podium to preside over a town meeting. A mixture of lycanthropic beings, horned beasts, and those still holding onto their humanity were in attendance outside the school. The force of the wolf's words caused tears to stream down their cheeks.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(
                "\"We want to shatter those unfortunate stereotypes. We hold no grudges. We want to work with you all, not against you. The child should not be punished for the sins of the father. You are all welcome.\" The werewolf blew their cold nose into their handkerchief as a rumbling cheer rose from the crowd.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("As a token of this myth-shattering event, many handshakes were exchanged that day and a promise was made to press forward into a more modern era; an era where science could improve their lives ten-fold!");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hook>");
            optionsManager.AddOption("Click to continue...", passage230_Fragment_0);
            Console.Write("</hook>");
        }
        else if (StaticGameState.hcount == 0)
        {
            MethodEquitableValues();
        }
        else
        {
            Console.Write("<bold>");
            Console.Write("Still Wary");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write(
                "In the evenings, the Fraternity gathered in the former Town Hall and celebrated their political takeover of the small town. Observers could hear their loud revelry echo through the streets late into the night. The townsfolk had no reason to doubt their loyalty as it appeared that their activities kept both sickness and superstitions at bay.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("For the family members that had aided them in their efforts, they wore wide false-smiles and offered toasts to their continued partnership. But, for those who had plotted against them, they remained wary.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hook>");
            optionsManager.AddOption("Click to continue...", passage230_Fragment_2);
            Console.Write("</hook>");
        }

        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage230_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", MethodEquitableValues);
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "S1_MastersStudy";
        Console.WriteLine();
        Console.Write("Retrieve the ");
        Console.Write("<bold>");
        Console.Write("Master's Study");
        Console.Write("</bold>");
        Console.Write(" Vanity Estate Upgrade tiles.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Choose:");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("Starting with the player in last place and continuing in ascending order by point total, each player chooses a ");
        Console.Write("<bold>");
        Console.Write("Master's Study");
        Console.Write("</bold>");
        Console.Write(" tile and adds it to their Estate. No additional cost is paid for a new plot to place this tile. ");
        Console.Write("<italic>");
        Console.Write("(Ties are broken by the player that went later in turn order in the previous round.)");
        Console.Write("</italic>");
        Console.Write("</setupStyleEvnt>");
        optionsManager.PresentOptions();
    }

    private static void passage230_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage230_Fragment_0);
        optionsManager.PresentOptions();
    }

    private static void passage230_Fragment_2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", MethodEquitableValues);
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "Creepy_Icon";
        Console.WriteLine();
        if (StaticGameState.allyA == "wolves")
        {
            Console.Write(StaticGameState.nameA);
            Console.Write(" III ");
            Console.Write("<bold>");
            Console.Write("immediately gains 1 ");
            Console.Write("<sprite=\"Creepy_Icon\" index=0>");
            Console.Write("</bold>");
            Console.Write(".");
            Console.WriteLine();
        }

        if (StaticGameState.allyB == "wolves")
        {
            Console.Write(StaticGameState.nameB);
            Console.Write(" III ");
            Console.Write("<bold>");
            Console.Write("immediately gains 1 ");
            Console.Write("<sprite=\"Creepy_Icon\" index=0>");
            Console.Write("</bold>");
            Console.Write(".");
            Console.WriteLine();
        }

        if (StaticGameState.allyC == "wolves")
        {
            Console.Write(StaticGameState.nameC);
            Console.Write(" III ");
            Console.Write("<bold>");
            Console.Write("immediately gains 1 ");
            Console.Write("<sprite=\"Creepy_Icon\" index=0>");
            Console.Write("</bold>");
            Console.Write(".");
            Console.WriteLine();
        }

        if (StaticGameState.allyD == "wolves")
        {
            Console.Write(StaticGameState.nameD);
            Console.Write(" III ");
            Console.Write("<bold>");
            Console.Write("immediately gains 1 ");
            Console.Write("<sprite=\"Creepy_Icon\" index=0>");
            Console.Write("</bold>");
            Console.Write(".");
            Console.WriteLine();
        }

        if (StaticGameState.allyE == "wolves")
        {
            Console.Write(StaticGameState.nameE);
            Console.Write(" III ");
            Console.Write("<bold>");
            Console.Write("immediately gains 1 ");
            Console.Write("<sprite=\"Creepy_Icon\" index=0>");
            Console.Write("</bold>");
            Console.Write(".");
        }

        if (!(StaticGameState.allyA == "wolves") || !(StaticGameState.allyB == "wolves") || !(StaticGameState.allyC == "wolves") || !(StaticGameState.allyD == "wolves") || !(StaticGameState.allyE == "wolves"))
        {
            Console.Write(StaticGameState.nameA);
            Console.Write(" III ");
            Console.Write("<bold>");
            Console.Write("immediately gains 1 ");
            Console.Write("<sprite=\"Creepy_Icon\" index=0>");
            Console.Write("</bold>");
            Console.Write(".");
        }

        Console.WriteLine();
        Console.Write("</setupStyleEvnt>");
        optionsManager.PresentOptions();
    }

    private static void passage230_Fragment_3()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage230_Fragment_2);
        optionsManager.PresentOptions();
    }


    private static void MethodSymposiumMiddle()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("A Cure for Yellow Fever");
        Console.Write("</bold>");
        Console.WriteLine();
        if (StaticGameState.SymposiumMiddlenextPsg == "" || StaticGameState.SymposiumMiddlenextPsg == 0)
        {
            StaticGameState.SymposiumMiddlenextPsg = StaticGameState.GetRandom(new[]
            {
                1,
                2,
                3
            });
        }

        StaticGameState.midquote = StaticGameState.SymposiumMiddlenextPsg;
        Console.WriteLine();
        Console.Write("\"Vague, tawdry.\" The notes from the lectures created a tableau of mixed reactions. ");
        if (StaticGameState.midquote == 1)
        {
            Console.Write("\"All angst and ambition without respect for traditional ethics or the scientific method. Unsupported hypotheses, and rapid-fire homeopathic conjecture.\"");
        }
        else if (StaticGameState.midquote == 2)
        {
            Console.Write("\"Of note, however, was one intriguing if not juvenile statement. I jotted the quote down for posterity and so that others at the state may enjoy it when I plaster the message all across the lavatories. The quote:");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("'It's simple. Wash your hands after you touch your butt.'\"");
        }
        else
        {
            Console.Write("\"Delightfully crude, but potentially insightful. Overall though, the lectures were amusing for what they lacked in substance.\"");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "At first they seemed intrigued, but the presentations, while exciting, proved to have only minimal scientific value in their eyes. It was decided by the majority to research any other notable discoveries in their portfolio before making their recommendations.");
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.pub == "yes")
        {
            Console.Write("And it was the ");
            Console.Write("<bold>");
            Console.Write("publication");
            Console.Write("</bold>");
            Console.Write(" of a ");
            Console.Write("<bold>");
            Console.Write("Yellow Fever");
            Console.Write("</bold>");
            Console.Write(" inoculation from an otherwise unknown town in Hungary that made their decision to build a University in the region much easier.");
            Console.WriteLine();
            Console.WriteLine();
            optionsManager.AddOption("SymposiumSuccess", MethodSymposiumSuccess);
        }
        else
        {
            Console.Write("And without the publication of a proposed ");
            Console.Write("<bold>");
            Console.Write("Yellow Fever");
            Console.Write("</bold>");
            Console.Write(" inoculation, their decision on the value of a university in a small town in Hungary was easy to make.");
            Console.WriteLine();
            Console.WriteLine();
            optionsManager.AddOption("SymposiumFail", MethodSymposiumFail);
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodPanaceaUnleashCons1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.pana == "unleash")
        {
            Console.Write("<bold>");
            Console.Write("Whispers Abate");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write(
                "With the passing of the generation, the hideous and well-founded rumors regarding the grisly demise and otherwise negative treatment of servants in the family's households faded into history. As considerably misguided as it was, the allure of steady employ once again attracted new applicants to the estates once more.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hook>");
            optionsManager.AddOption("Click to continue...", passage232_Fragment_0);
            Console.Write("</hook>");
        }
        else
        {
            MethodNewMaster();
        }

        optionsManager.PresentOptions();
    }

    private static void passage232_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", MethodNewMaster);
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "Servant";
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Any players with a Servant in the game box retrieves it from the box and adds it to Lost.");
        Console.Write("</setupStyleEvnt>");
        optionsManager.PresentOptions();
    }

    private static void passage232_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage232_Fragment_0);
        optionsManager.PresentOptions();
    }


    private static void MethodPanaceaUnleashCons2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.pana == "unleash")
        {
            Console.Write("<bold>");
            Console.Write("Whispers Abate");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write(
                "With the passing of the generation, the hideous and well-founded rumors regarding the grisly demise and otherwise negative treatment of servants within the family's households faded into history. As considerably misguided as it would have been, the allure of steady employ once again attracted new applicants to their estates.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hook>");
            optionsManager.AddOption("Click to continue...", passage233_Fragment_0);
            Console.Write("</hook>");
        }
        else
        {
            MethodUniversity1();
        }

        optionsManager.PresentOptions();
    }

    private static void passage233_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", MethodUniversity1);
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "Servant";
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Any players with a Servant in the game box may retrieve it from the box and place it in Lost.");
        Console.Write("</setupStyleEvnt>");
        optionsManager.PresentOptions();
    }

    private static void passage233_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage233_Fragment_0);
        optionsManager.PresentOptions();
    }


    private static void MethodTipsnTricks()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("It is almost never advantageous for all players to take the same route.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("All decisions carry with them consequences, both good and bad. ");
        optionsManager.PresentOptions();
    }


    private static void MethodNoHospitalCons()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("A Steady Focus");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write(
            "For members of this ignoble family, it was not uncommon for personal labors to consume an individual's waking thoughts and cause them to forget even the most simplistic of instructions. But for those that toiled endlessly on their infernal schemes, their reward - aside from obesity and appalling hygiene - was one of a deeper understanding.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click to continue...", passage235_Fragment_1);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage235_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", StaticGameState.GetRandom(new[]
        {
            MethodS5HospA1,
            MethodS5HospA2,
            MethodS5HospA3
        }));
        optionsManager.PresentOptions();
    }

    private static void passage235_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.NoHospitalConsnextPsg == "" || StaticGameState.NoHospitalConsnextPsg == 0)
        {
            StaticGameState.NoHospitalConsnextPsg = StaticGameState.GetRandom(new[]
            {
                MethodS5HospA1,
                MethodS5HospA2,
                MethodS5HospA3
            });
        }

        optionsManager.AddOption("Continue...", StaticGameState.NoHospitalConsnextPsg);
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "AdvanceJournalTrack";
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.hospA == 0 || StaticGameState.hospA == "")
        {
            Console.Write("<bold>");
            Console.Write("Dr. ");
            Console.Write(StaticGameState.nameA);
            Console.Write(" III");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("Move forward ");
            Console.Write("<bold>");
            Console.Write("1 level on the Journal Track of your choice");
            Console.Write("</bold>");
            Console.Write(".");
            Console.WriteLine();
            Console.WriteLine();
        }

        if (StaticGameState.hospB == 0 || StaticGameState.hospB == "")
        {
            Console.Write("<bold>");
            Console.Write("Dr. ");
            Console.Write(StaticGameState.nameB);
            Console.Write(" III");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("Move forward ");
            Console.Write("<bold>");
            Console.Write("1 level on the Journal Track of your choice");
            Console.Write("</bold>");
            Console.Write(".");
            Console.WriteLine();
            Console.WriteLine();
        }

        if (StaticGameState.players > 2 && (StaticGameState.hospC == 0 || StaticGameState.hospC == ""))
        {
            Console.Write("<bold>");
            Console.Write("Dr. ");
            Console.Write(StaticGameState.nameC);
            Console.Write(" III");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("Move forward ");
            Console.Write("<bold>");
            Console.Write("1 level on the Journal Track of your choice");
            Console.Write("</bold>");
            Console.Write(".");
            Console.WriteLine();
            Console.WriteLine();
        }

        if (StaticGameState.players > 3 && (StaticGameState.hospD == 0 || StaticGameState.hospD == ""))
        {
            Console.Write("<bold>");
            Console.Write("Dr. ");
            Console.Write(StaticGameState.nameD);
            Console.Write(" III");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("Move forward ");
            Console.Write("<bold>");
            Console.Write("1 level on the Journal Track of your choice");
            Console.Write("</bold>");
            Console.Write(".");
            Console.WriteLine();
            Console.WriteLine();
        }

        if (StaticGameState.players > 4 && (StaticGameState.hospE == 0 || StaticGameState.hospE == ""))
        {
            Console.Write("<bold>");
            Console.Write("Dr. ");
            Console.Write(StaticGameState.nameE);
            Console.Write(" III");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("Move forward ");
            Console.Write("<bold>");
            Console.Write("1 level on the Journal Track of your choice");
            Console.Write("</bold>");
            Console.Write(".");
            Console.WriteLine();
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.Write("</setupStyleEvnt>");
        optionsManager.PresentOptions();
    }

    private static void passage235_Fragment_2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("click here to determine the Fate of the Town.", passage235_Fragment_1);
        optionsManager.PresentOptions();
    }


    private static void MethodS5HospA3()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.pana == 0 || StaticGameState.pana == "")
        {
            Console.Write("<bold>");
            Console.Write("Relentless Opposition");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("The church's distrust of science has riled up the populace. Contributions to the Hospital's original construction notwithstanding, without the hope provided by a ");
            Console.Write("<bold>");
            Console.Write("Panacea");
            Console.Write("</bold>");
            Console.Write(" to remove ailments en masse, the townsfolk became determined to return to the old ways.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("A most pitiful display that led to stagnation and the return of the pestilence that once was eliminated from the land.");
            Console.WriteLine();
            Console.WriteLine();
            optionsManager.AddOption("RippedMasterwork", MethodRippedMasterwork);
        }
        else if (StaticGameState.pana == "unleash")
        {
            Console.Write("<bold>");
            Console.Write("Relentless Opposition");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("The church's distrust of science has riled up the populace. Contributions to the Hospital's original construction notwithstanding, the nonsensical decision to ");
            Console.Write("<bold>");
            Console.Write("unleash");
            Console.Write("</bold>");
            Console.Write(" the proposed Panacea resulted in a loss of the original formula. Without the hope provided by a ");
            Console.Write("<bold>");
            Console.Write("Panacea");
            Console.Write("</bold>");
            Console.Write(" to remove ailments en masse, the townsfolk became determined to return to the old ways.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("A most pitiful display that led to stagnation and the return of the pestilence that once was eliminated from the land.");
            Console.WriteLine();
            Console.WriteLine();
            optionsManager.AddOption("RippedMasterwork", MethodRippedMasterwork);
        }
        else
        {
            Console.Write("<bold>");
            Console.Write("The Allure of Discovery");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write(
                "While the Panacea proposed may not have approached the problem in an ethical nor fiscally responsible way, the simple gesture garnered much attention from the academic community. Along with the famed discovery of a \"cure\" for Yellow Fever, this potential for scientific advancement was too strong to ignore.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("The family soon found a rapt audience for their unconventional experimentations, despite all logic running counter to this development, and the city entered into a golden age of progress.");
            Console.WriteLine();
            Console.WriteLine();
            optionsManager.AddOption("UniversityIntro", MethodUniversityIntro);
        }

        Console.WriteLine("END OF GENERATION SETUP" + "Remove all player pieces from the board and perform the End of a Generation. Any <sprite=\"StorybookToken\" index=0> tokens remaining on a player's Journal Track are returned to the supply.");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodNewMaster3E()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.costE == "Biology")
        {
            StaticGameState.cost2E = "Animal";
        }

        if (StaticGameState.costE == "Engineering")
        {
            StaticGameState.cost2E = "Gear";
        }

        if (StaticGameState.costE == "Chemistry")
        {
            StaticGameState.cost2E = "Bottle";
        }

        Console.WriteLine("Give your creation a new, majestic name:");
        StaticGameState.creationE = Console.ReadLine()!;
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("The ");
        Console.Write(StaticGameState.GetRandom(new[]
        {
            "Infamous",
            "Transcendent",
            "Monumental",
            "Nefarious",
            "Unspeakable",
            "Legendary",
            "Noble",
            "Phenomenal",
            "Stunning",
            "Masterful",
            "Insidious"
        }));
        Console.Write(" ");
        Console.Write(StaticGameState.creationE);
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        MethodMWCreationHubE();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("With my own destiny determined, I resolved to forge a new path into the future and create my Masterwork.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("You may check the cost of completing your new Masterwork at any time by clicking on your name on the main Storybook screen.");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        optionsManager.AddOption("NewMHub", MethodNewMHub);
        optionsManager.PresentOptions();
    }


    private static void MethodMWCreationHubE()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.typeE == "creature")
        {
            Console.Write("<bold>");
            Console.Write(StaticGameState.creationE);
            Console.Write("</bold>");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<bold>");
            Console.Write("Cost:");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("2 Animals, 5 Biology, 1 ");
            Console.Write(StaticGameState.costE);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<bold>");
            Console.Write("Reward:");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("Gain 20VP.");
            Console.WriteLine();
            Console.Write("Gain 1 ");
            Console.Write("<sprite=\"Insanity_Icon\" index=0>");
            Console.Write(", Gain 2 ");
            Console.Write("<sprite=\"Creepy_Icon\" index=0>");
            Console.Write(", Move the ");
            Console.Write("<sprite=\"AngryMob_Icon\" index=0>");
            Console.Write(".");
            Console.WriteLine();
        }
        else if (StaticGameState.typeE == "power")
        {
            Console.Write("<bold>");
            Console.Write(StaticGameState.creationE);
            Console.Write("</bold>");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<bold>");
            Console.Write("Cost:");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("1 Animal, 1 ");
            Console.Write(StaticGameState.cost2E);
            Console.Write(", 3 Biology, 3 ");
            Console.Write(StaticGameState.costE);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<bold>");
            Console.Write("Reward:");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("Gain 19VP.");
            Console.WriteLine();
            Console.Write("Gain 1 ");
            Console.Write("<sprite=\"Insanity_Icon\" index=0>");
            Console.Write(", Gain 2 ");
            Console.Write("<sprite=\"Creepy_Icon\" index=0>");
            Console.Write(".");
            Console.WriteLine();
        }
        else if (StaticGameState.typeE == "robot")
        {
            Console.Write("<bold>");
            Console.Write(StaticGameState.creationE);
            Console.Write("</bold>");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<bold>");
            Console.Write("Cost:");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("2 Gears, 5 Engineering, 1 ");
            Console.Write(StaticGameState.costE);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<bold>");
            Console.Write("Reward:");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("Gain 20VP.");
            Console.WriteLine();
            Console.Write("Gain 1 ");
            Console.Write("<sprite=\"Insanity_Icon\" index=0>");
            Console.Write(", Gain 2 ");
            Console.Write("<sprite=\"Creepy_Icon\" index=0>");
            Console.Write(".");
            Console.WriteLine();
        }
        else if (StaticGameState.typeE == "weapon")
        {
            Console.Write("<bold>");
            Console.Write(StaticGameState.creationE);
            Console.Write("</bold>");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<bold>");
            Console.Write("Cost:");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("1 Gear, 1 ");
            Console.Write(StaticGameState.cost2E);
            Console.Write(", 4 Engineering, 2 ");
            Console.Write(StaticGameState.costE);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<bold>");
            Console.Write("Reward:");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("Gain 19VP.");
            Console.WriteLine();
            Console.Write("Gain 2 ");
            Console.Write("<sprite=\"Insanity_Icon\" index=0>");
            Console.Write(", Gain 1 ");
            Console.Write("<sprite=\"Creepy_Icon\" index=0>");
            Console.Write(".");
            Console.WriteLine();
        }
        else if (StaticGameState.typeE == "medicine")
        {
            Console.Write("<bold>");
            Console.Write(StaticGameState.creationE);
            Console.Write("</bold>");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<bold>");
            Console.Write("Cost:");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("2 Chemicals, 4 Chemistry, 2 ");
            Console.Write(StaticGameState.costE);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<bold>");
            Console.Write("Reward:");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("Gain 21VP.");
            Console.WriteLine();
            Console.Write("Gain 2 ");
            Console.Write("<sprite=\"Insanity_Icon\" index=0>");
            Console.Write(", Gain 2 ");
            Console.Write("<sprite=\"Creepy_Icon\" index=0>");
            Console.Write(".");
            Console.WriteLine();
        }
        else if (StaticGameState.typeE == "drug")
        {
            Console.Write("<bold>");
            Console.Write(StaticGameState.creationE);
            Console.Write("</bold>");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<bold>");
            Console.Write("Cost:");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("1 Bottle, 1 ");
            Console.Write(StaticGameState.cost2E);
            Console.Write(", 3 Chemistry, 3 ");
            Console.Write(StaticGameState.costE);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<bold>");
            Console.Write("Reward:");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("Gain 19VP.");
            Console.WriteLine();
            Console.Write("Gain 1 ");
            Console.Write("<sprite=\"Insanity_Icon\" index=0>");
            Console.Write(", Gain 2 ");
            Console.Write("<sprite=\"Creepy_Icon\" index=0>");
            Console.Write(".");
            Console.WriteLine();
        }
        else if (StaticGameState.typeE == "demon")
        {
            Console.Write("<bold>");
            Console.Write(StaticGameState.creationE);
            Console.Write("</bold>");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<bold>");
            Console.Write("Cost:");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("2 Bodies, 4 Occult, 1 ");
            Console.Write(StaticGameState.costE);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<bold>");
            Console.Write("Reward:");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("Gain 21VP.");
            Console.WriteLine();
            Console.Write("Gain 2 ");
            Console.Write("<sprite=\"Creepy_Icon\" index=0>");
            Console.Write(".");
            Console.WriteLine();
        }
        else
        {
            Console.Write("<bold>");
            Console.Write(StaticGameState.creationE);
            Console.Write("</bold>");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<bold>");
            Console.Write("Cost:");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("1 Body, 1 ");
            Console.Write(StaticGameState.cost2E);
            Console.Write(", 3 Occult, 3 ");
            Console.Write(StaticGameState.costE);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<bold>");
            Console.Write("Reward:");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("Gain 20VP.");
            Console.WriteLine();
            Console.Write("Gain 1 ");
            Console.Write("<sprite=\"Insanity_Icon\" index=0>");
            Console.Write(", Gain 2 ");
            Console.Write("<sprite=\"Creepy_Icon\" index=0>");
            Console.Write(", Move the ");
            Console.Write("<sprite=\"AngryMob_Icon\" index=0>");
            Console.Write(".");
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<i>Note: This Masterwork still requires 1 A Experiment, 2 B Experiments, and 3 C Experiments to be completed.</i>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodMWCompleteHubE()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write(StaticGameState.GetRandom(new[]
        {
            "The Work is Done",
            "I Have Done the Impossible",
            "My Legacy is Ensured",
            "AH HA HA HAAAAA!!!",
            "My Glorious Creation",
            "The Glory is Mine Forever!"
        }));
        Console.Write(" ");
        Console.Write("- ");
        Console.Write(StaticGameState.nameE);
        Console.Write(" ");
        Console.Write("- Journal Entry Excerpt");
        Console.Write("</bold>");
        Console.WriteLine();
        if (StaticGameState.typeE == "creature")
        {
            Console.Write("Upon the stroke of midnight, lightning struck metal, sending a terrible electrical current through the machinery. My creation awoke, and with wild eyes gazed upon me, its creator. I had done it! I had created life!");
        }
        else if (StaticGameState.typeE == "power")
        {
            Console.Write("To see my work in the flesh, to see ");
            Console.Write(StaticGameState.creationE);
            Console.Write(" finally realized; the passion of the moment overwhelmed my senses. I had done it. I shook my fist at God and all who doubted me! You were wrong! I am invincible!");
        }
        else if (StaticGameState.typeE == "robot")
        {
            Console.Write("A brief, blinding flash and the work was done. I threw my goggles to the floor to gaze upon my creation with my own eyes - ");
            Console.Write(StaticGameState.creationE);
            Console.Write(". The polished metal surface whirred with interior mechanisms churning - then, glorious motion! Oh wondrous automaton, with you by my side the scientific world will be humbled!");
        }
        else if (StaticGameState.typeE == "weapon")
        {
            Console.Write(
                "I seized the firing mechanism and squeezed the polished metal trigger. When the dust settled and my laboratory wall had been made to crumble into dust, I was unable to contain a sinister grin. The world would remember this day and the weapon I had wrought. My fame would be legendary.");
        }
        else if (StaticGameState.typeE == "medicine")
        {
            Console.Write("I tapped the glass bottle, watching the liquid inside swirl and glow with the purity of the mixture. The ");
            Console.Write(StaticGameState.creationE);
            Console.Write(
                " had been a stunning success and once mass production could be attained, my family's legacy would be secure. I laughed. Then, laughed again. My cacophonous laughter echoed off the stone walls of my estate for years to come.");
        }
        else if (StaticGameState.typeE == "drug")
        {
            Console.Write("I observed the effects as the syringe filled with ");
            Console.Write(StaticGameState.creationE);
            Console.Write(
                " emptied its contents into the unwilling test subject. Just as I had expected, the reaction was immediate and effusive. For so many years, I had toiled away in the solitude of my estate, and now as I wiped the tears from eyes, my beautiful creation was finally complete.");
        }
        else if (StaticGameState.typeD == "demon")
        {
            Console.Write("The world darkened around me as the ");
            Console.Write(StaticGameState.creationE);
            Console.Write(
                " emerged from a void-like rift in time and space. I could feel the immense power of the insidious being, the air hot with the energy of their presence. They turned to me and with a deep growl, they stated, \"Master.\" I had done it. I was now in control and the world would rue the day they doubted ");
            Console.Write(StaticGameState.nameE);
            Console.Write(" III!");
        }
        else
        {
            Console.Write("The preparations proved tedious, but the resulting wave of spiritual energy as the ritual was completed left me standing in awe of my creation. The ");
            Console.Write(StaticGameState.creationE);
            Console.Write(" was a brilliant success. And the powers I now harnessed were unthinkable!");
        }

        optionsManager.PresentOptions();
    }


    private static void MethodCureNegCons()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Distrust in Medicine");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write(
            "With the Hospital slowly falling into disrepair, the church took great measures to warn the populace of the dangers of inoculation, espousing the virtues of alternative homeopathic remedies and pious living. Inevitably, this led to clusters of Yellow Fever once again appearing within the region.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Having no target for their anger, in a befuddled daze, they turned against the scientist responsible for introducing the cure, without whom this self-inflicted moral dilemma would never have existed.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click to continue...", passage240_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage240_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", MethodOptiontoKillStart);
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "AngryMob_Icon";
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Move the ");
        Console.Write("<sprite=\"AngryMob_Icon\" index=0>");
        Console.Write(" token 1 space to the left. ");
        Console.Write("</bold>");
        if (StaticGameState.fevercure == "" || StaticGameState.fevercure == 0)
        {
            StaticGameState.fevercure = StaticGameState.nameA;
        }

        Console.Write(StaticGameState.fevercure);
        Console.Write(" immediately ");
        Console.Write("<bold>");
        Console.Write("gains 1 ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write("</bold>");
        Console.Write(" and ");
        Console.Write("<bold>");
        Console.Write("gains 1 ");
        Console.Write("<sprite=\"Insanity_Icon\" index=0>");
        Console.Write("</bold>");
        Console.Write(".");
        Console.Write("</setupStyleEvnt>");
        optionsManager.PresentOptions();
    }

    private static void passage240_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage240_Fragment_0);
        optionsManager.PresentOptions();
    }


    private static void MethodYellowFeverCureSignin()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Yellow Fever Inoculation");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write(
            "Through sheer perseverance and months of exposing both themselves, their spouse, all their servants, and several delivery persons to potential curing agents in different hues of yellow, a surprisingly effective solution was created that could be administered intravenously.");
        Console.WriteLine();
        StaticGameState.twopage = 1;
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Which individual completed the Yellow Fever Inoculation Experiment?");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Dr. " + (string)StaticGameState.nameA + " Jr.", passage241_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Dr. " + (string)StaticGameState.nameB + " Jr.", passage241_Fragment_1);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.players > 2)
        {
            Console.Write("<hook>");
            optionsManager.AddOption("Dr. " + (string)StaticGameState.nameC + " Jr.", passage241_Fragment_2);
            Console.Write("</hook>");
            Console.WriteLine();
            Console.WriteLine();
        }

        if (StaticGameState.players > 3)
        {
            Console.Write("<hook>");
            optionsManager.AddOption("Dr. " + (string)StaticGameState.nameD + " Jr.", passage241_Fragment_3);
            Console.Write("</hook>");
            Console.WriteLine();
            Console.WriteLine();
        }

        if (StaticGameState.players > 4)
        {
            Console.Write("<hook>");
            optionsManager.AddOption("Dr. " + (string)StaticGameState.nameE + " Jr.", passage241_Fragment_4);
            Console.Write("</hook>");
            Console.WriteLine();
        }

        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage241_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.fevercure = StaticGameState.nameA;
        MethodUnicure();
        optionsManager.PresentOptions();
    }

    private static void passage241_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.fevercure = StaticGameState.nameB;
        MethodUnicure();
        optionsManager.PresentOptions();
    }

    private static void passage241_Fragment_2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.fevercure = StaticGameState.nameC;
        MethodUnicure();
        optionsManager.PresentOptions();
    }

    private static void passage241_Fragment_3()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.fevercure = StaticGameState.nameD;
        MethodUnicure();
        optionsManager.PresentOptions();
    }

    private static void passage241_Fragment_4()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.fevercure = StaticGameState.nameE;
        MethodUnicure();
        optionsManager.PresentOptions();
    }


    private static void MethodUniversity()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("University");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("Pay $1 to gain a Caretaker from Lost and place it in your Quarters. ");
        optionsManager.PresentOptions();
    }


    private static void MethodChurch()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Charitable Church");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("Pay $ X/X/X to move 1/2/3 spaces backwards on the ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("Track.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<italic>");
        Console.Write("For example, if the cost is 1/2/3 and you pay $2, you will lose 2 Creepy.");
        Console.Write("</italic>");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodHardwareStore1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Hardware Store");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("Gain 1 Ingredient of your choice ");
        Console.Write("<italic>");
        Console.Write("(except bodies)");
        Console.Write("</italic>");
        Console.Write(".");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<italic>");
        Console.Write("If you place multiple pieces with this action, each Ingredient you gain may be of the same or a different type.");
        Console.Write("</italic>");
        optionsManager.PresentOptions();
    }


    private static void MethodBookStore3()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Book Store");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("Gain 1 Knowledge of your choice ");
        Console.Write("<italic>");
        Console.Write("(not Occult)");
        Console.Write("</italic>");
        Console.Write(".");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<italic>");
        Console.Write("If you place multiple pieces with this action, each Knowledge you gain may be of the same or a different type.");
        Console.Write("</italic>");
        optionsManager.PresentOptions();
    }


    private static void MethodWireService2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Wire Service");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("Gain $2.");
        optionsManager.PresentOptions();
    }


    private static void MethodWarehouse4()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Warehouse");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("For a single action, pay $1 any number of times to gain an equal number of Servants from Lost.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<italic>");
        Console.Write("Your Self can only perform this action once per visit.");
        Console.Write("</italic>");
        optionsManager.PresentOptions();
    }


    private static void MethodPetStore5()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Friendly Pet Store");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("Gain 2 Chemicals.");
        optionsManager.PresentOptions();
    }


    private static void Method3ExperimentsRes()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Advancements in ");
        Console.Write(StaticGameState.sci3);
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write(
            "As the years ambled onward and the peculiarities of their experimentations became more complex, it was not unheard of for the family to submit discoveries to scientific and medical journals. While most were summarily rejected, this constant stream of inquiries sometimes resulted in visits from interested parties.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("One such visitation occurred at the laboratory of ");
        Console.Write(StaticGameState.gen2exp);
        Console.Write(". While frightening to behold at first, they were intrigued by the exceedingly complex ");
        if (StaticGameState.sci3 == "Biology")
        {
            Console.Write("display of colorful Chemicals and unique specimens collected (and created) over time.");
        }

        if (StaticGameState.sci3 == "Chemistry")
        {
            Console.Write("labyrinthine weaving of rubber tubing, chemicals, and simmering beakers of various shapes and sizes along the walls.");
        }

        if (StaticGameState.sci3 == "Engineering")
        {
            Console.Write("vestibule filled with electrical coils, switches, dials, and several large metal cabinets with blinking red lights (a dazzling rarity in that age).");
        }

        Console.Write(" ");
        Console.Write("Certainly immense strides forward had been made in ");
        Console.Write(StaticGameState.sci3);
        Console.Write(".");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("It was only natural that they provided encouragement and financial resources to help preserve this unique arrangement. Especially after being informed that it was the only way they would leave the premises unaltered.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click to continue...", passage249_Fragment_1);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage249_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.WriteLine();
        if (StaticGameState.round == 7)
        {
            StaticGameState.sciadv = 1;
            MethodHospital1();
        }
        else if (StaticGameState.round == 8)
        {
            StaticGameState.sciadv = 1;
            MethodHospital2();
        }
        else
        {
            StaticGameState.sciadv = 1;
            MethodHospital3();
        }

        optionsManager.PresentOptions();
    }

    private static void passage249_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.sciadv = 1;
        optionsManager.AddOption("Continue...", ((StaticGameState.round == 7) ? MethodHospital1 : ((StaticGameState.round == 8) ? MethodHospital2 : MethodHospital3)));
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "S1_MastersStudy";
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Retrieve the ");
        Console.Write(StaticGameState.sci3);
        Console.Write(" ");
        Console.Write("Master's Study Vanity Estate Upgrade from the scenario box and add it to your Estate.");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("<italic>");
        Console.Write("You must still pay any required costs if you place it a new plot.");
        Console.Write("</italic>");
        Console.Write("</setupStyleEvnt>");
        optionsManager.PresentOptions();
    }

    private static void passage249_Fragment_2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage249_Fragment_1);
        optionsManager.PresentOptions();
    }


    private static void MethodPanaceaMessage()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Carefully pick up the Storybook and do not allow any other players to see the screen.");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Once you are ready", passage250_Fragment_4);
        Console.Write("</hook>");
        optionsManager.PresentOptions();
    }

    private static void passage250_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.cured = 2;
        StaticGameState.pana = "publish";
        MethodPanacea1();
        optionsManager.PresentOptions();
    }

    private static void passage250_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.cured = 2;
        StaticGameState.pana = "unleash";
        MethodHospital1();
        optionsManager.PresentOptions();
    }

    private static void passage250_Fragment_2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.cured = 2;
        StaticGameState.pana = "unleash";
        MethodHospital2();
        optionsManager.PresentOptions();
    }

    private static void passage250_Fragment_3()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.cured = 2;
        StaticGameState.pana = "unleash";
        MethodPanaceaTooOld();
        optionsManager.PresentOptions();
    }

    private static void passage250_Fragment_4()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Unintended Results");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write(
            "The dedication to the task was clear. My research unearthed several journals filled with line after line of a single mathematical formula, handwritten and repeated ad nauseam, followed by a chemical formula with slight alterations over time. The obsession literally spanned volumes and eventually paid large dividends.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "While technically the resulting solution did in fact \"cure\" all diseases, it also resulted in the death of the test subject, the liquification of their bones, dissolution of skin, and eventually five meters of solid ground in the affected area.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("A concoction such as this, despite its volatile nature, could offer legitimate scientific benefits upon publication. However, there were, of course, other options...");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("CHOOSE:");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Do you wish to publish your findings or would you like unleash your creation on your rivals?");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Publish my findings for fame.", passage250_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.round == 7)
        {
            Console.Write("<hook>");
            optionsManager.AddOption("Unleash my creation!", passage250_Fragment_1);
            Console.Write("</hook>");
        }
        else if (StaticGameState.round == 8)
        {
            Console.Write("<hook>");
            optionsManager.AddOption("Unleash my creation!", passage250_Fragment_2);
            Console.Write("</hook>");
        }
        else
        {
            Console.Write("<hook>");
            optionsManager.AddOption("Unleash my creation!", passage250_Fragment_3);
            Console.Write("</hook>");
        }

        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage250_Fragment_5()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Once you are ready", passage250_Fragment_4);
        optionsManager.PresentOptions();
    }


    private static void MethodImmortalityMWUpdate()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.setinf > 0)
        {
            if (StaticGameState.round == 8)
            {
                MethodHospital2();
            }
            else
            {
                MethodHospital3();
            }
        }

        Console.Write("<bold>");
        Console.Write("The True Secret");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("The family's pursuit of everlasting life brought new and inspirational concepts to the forefront. These ideas could verify the seemingly untenable Masterwork blueprints created by their Grandfather.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Does any player have the ");
        Console.Write("<bold>");
        Console.Write("Immortality");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("Masterwork Experiment?");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Yes.", passage251_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("No.", passage251_Fragment_1);
        Console.Write("</hook>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage251_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.immort = "yes";
        MethodImmortalityMWUpdate2();
        optionsManager.PresentOptions();
    }

    private static void passage251_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.setinf = 1;
        if (StaticGameState.round == 8)
        {
            MethodHospital2();
        }
        else
        {
            MethodHospital3();
        }

        optionsManager.PresentOptions();
    }


    private static void MethodImmortalityMWUpdate2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("The Possibility Exists");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("The thoughts consumed their waking hours, compelling them to action. Surely if a form of ");
        Console.Write("<bold>");
        Console.Write("Immortality");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write(
            "can be so readily created by the family, then a more perfected version was just on the horizon. It would need to be done. It had to be done, or the shame they felt would weigh heavily on everything their exceptional lineage had created thus far.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click to continue...", passage252_Fragment_1);
        Console.Write("</hook>");
        optionsManager.PresentOptions();
    }

    private static void passage252_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.setinf = 1;
        if (StaticGameState.round == 8)
        {
            MethodHospital2();
        }
        else
        {
            MethodHospital3();
        }

        optionsManager.PresentOptions();
    }

    private static void passage252_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.setinf = 1;
        optionsManager.AddOption("Continue...", ((StaticGameState.round == 8) ? MethodHospital2 : MethodHospital3));
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "S1_MWUpdateImmortality";
        Console.WriteLine();
        Console.Write("Retrieve the ");
        Console.Write("<bold>");
        Console.Write("Immortality");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("Masterwork Update card from the Scenario box and give it to the player working towards this Masterwork.");
        Console.Write("</setupStyleEvnt>");
        optionsManager.PresentOptions();
    }

    private static void passage252_Fragment_2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage252_Fragment_1);
        optionsManager.PresentOptions();
    }


    private static void MethodENDNOTE()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("Add to SCORING");
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.lycan == "yes")
        {
            Console.Write("Check to make sure the player with ");
            Console.Write("<bold>");
            Console.Write("Lycanthropic Strength");
            Console.Write("</bold>");
            Console.Write("completed their Masterwork. If they did not, they ");
            Console.Write("<bold>");
            Console.Write("lose 5VP.");
            Console.Write("</bold>");
        }

        if (StaticGameState.immort == "yes")
        {
            Console.Write("Check to make sure the player with ");
            Console.Write("<bold>");
            Console.Write("Immortality");
            Console.Write("</bold>");
            Console.Write("completed their Masterwork. If they did not, they ");
            Console.Write("<bold>");
            Console.Write("lose 5VP.");
            Console.Write("</bold>");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("NOT SURE HOW TO CODE TIE-BREAKERS:");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("I can compare scores with a few lines, but it doesn't take into account tied scores.");
        optionsManager.PresentOptions();
    }

    private static void MethodSymposiumEvent2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.players == 2)
        {
            StaticGameState.symp = new Random().Next(3, 4 + 1);
        }
        else if (StaticGameState.players == 3)
        {
            StaticGameState.symp = new Random().Next(4, 6 + 1);
        }
        else if (StaticGameState.players == 4)
        {
            StaticGameState.symp = new Random().Next(6, 8 + 1);
        }
        else if (StaticGameState.players == 5)
        {
            StaticGameState.symp = new Random().Next(8, 10 + 1);
        }

        Console.Write("<bold>");
        Console.Write("For the Advancement of ");
        Console.Write(StaticGameState.sci3);
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("The symposium began with a series of lectures from various noted ");
        if (StaticGameState.sci3 == "Biology")
        {
            Console.Write("biologists");
        }
        else if (StaticGameState.sci3 == "Chemistry")
        {
            Console.Write("chemists");
        }
        else
        {
            Console.Write("engineers");
        }

        Console.Write(" ");
        Console.Write("from Eastern Europe. When it was their time to present, each cousin in turn rolled in a large cart covered with a velvet blanket to conceal their work until the appropriate moment during the lecture.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "As noted by several critics, each family member went well over their allotted time, providing eye-opening live demonstrations during the peak of their lectures that required many in the first rows of the operating theater to change into a clean outfit after the end of the exhibition.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("The spirited presentations stunned the community to abject silence.");
        Console.WriteLine();
        Console.WriteLine();
        optionsManager.AddOption("SymposiumEvent3", MethodSymposiumEvent3);
        Console.WriteLine();
        optionsManager.PresentOptions();
    }
    
    private static void MethodUniversity1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("SEARCH FOR THE CURE - Early Years");
        Console.Write("</bold>");
        Console.WriteLine();
        StaticGameState.round = 19;
        Console.WriteLine();
        Console.Write("<setupStyle>");
        Console.Write("<bold>");
        Console.Write("SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "AngryMobSetup1";
        Console.WriteLine();
        Console.Write("Turn to page ");
        Console.Write("<bold>");
        Console.Write("10");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("of the Village Chronicle.");
        Console.WriteLine();
        Console.Write("Place the Suspicion Marker on space ");
        Console.Write("<bold>");
        if (StaticGameState.University1 == 0 || StaticGameState.University1 == "")
        {
            StaticGameState.University1 = 1;
            StaticGameState.tracker = int.Parse(StaticGameState.tracker) + 2;
            if (StaticGameState.players == 4)
            {
                StaticGameState.tracker = int.Parse(StaticGameState.tracker) + 1;
            }

            if (StaticGameState.players == 5)
            {
                StaticGameState.tracker = int.Parse(StaticGameState.tracker) + 1;
            }
        }

        Console.Write(StaticGameState.tracker);
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("and the ");
        Console.Write("<sprite=\"AngryMob_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("token one space to the left. ");
        if (StaticGameState.players == 3)
        {
            Console.Write("Then, since this is a 3-player game, pass the starting player marker clockwise 1 additional time.");
        }

        Console.Write("</setupStyle>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<bold>");
        Console.Write("Nobel Prize in Medicine");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write("The scientific world has finally taken notice of ");
        Console.Write(StaticGameState.townname);
        Console.Write(" ");
        Console.Write("and its ");
        Console.Write(StaticGameState.playtxt);
        Console.Write(" ");
        Console.Write("ingenious scholars. The absurdity of it all! Not only does this hamper their ability to experiment freely, it also gives their work mainstream merit.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("At the End of the Generation, the ");
        Console.Write("<bold>");
        Console.Write("least ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("player will be awarded this prestigious award and ");
        Console.Write("<bold>");
        Console.Write("lose 7VP.");
        Console.Write("</bold>");
        Console.Write("</hubDetails>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<bold>");
        Console.Write("Perfect Mental Balance");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write("At the end of the Generation, if your piece is on space ");
        Console.Write(StaticGameState.mental);
        Console.Write(" ");
        Console.Write("of the ");
        Console.Write("<sprite=\"Insanity_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("Track, you will ");
        Console.Write("<bold>");
        Console.Write("gain 5VP");
        Console.Write("</bold>");
        Console.Write(".");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click here at the end of the round to move to the next round...", passage258_Fragment_0);
        Console.Write("</hook>");
        Console.Write("</hubDetails>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage258_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.PrintEndOfTheRoundText("University1", MethodUniEquity1);
        optionsManager.PresentOptions();
    }


    private static void MethodEvilWolves1Note()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("CODE:");
        Console.WriteLine();
        Console.Write("LosingOrderAid entry should NOT appear if no one has joined the Losing faction.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("EVIL WOLVES -");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("EVIL bonus - players given a token");
        Console.WriteLine();
        Console.Write("GOOD penalty - can't use Monster Spawn in town. Gain Creepy.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Lycanthropic Strength check");
        Console.WriteLine();
        Console.Write("If Bank was built - Mayor Award.");
        Console.WriteLine();
        Console.Write("Masterwork Award - 1st to complete.");
        Console.WriteLine();
        Console.Write("Charity penalty - ??");
        Console.WriteLine();
        Console.Write("Ask for Experiments. Or Eat Servants. - those accepting the cure are unable to refuse. OR masterwork is shared.");
        Console.WriteLine();
        Console.Write("Occult Experiments encouraged");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Personal Event Bonus - Steal an Experiment that was donated.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("A VIAL to cleanse this evil from the land.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("SETUP");
        Console.WriteLine();
        Console.Write("Retrieve the Spawning Pods Vanity Estate Tile.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Spread their message of dreadful bloodlust and recruit others.");
        Console.WriteLine();
        Console.Write("They allow for Experiments in the City Limits. They know we can help and require it or they will eat our SERVANTS. But, each round they offer something in return for our sacrifice.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Something happens when a player completes a Masterwork. Place a Storybook token there.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("- Most Creepy Player");
        Console.WriteLine();
        Console.Write("- Player that donates the most Experiment cards total to the Monster cause");
        Console.WriteLine();
        Console.Write("will receive a Spawning Pods Vanity Estate Tile.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("EVENT? I like Revenge for the player that's losing. They choose a player to have to fight.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Could rename Labor to Human Jail");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Other ideas -");
        Console.WriteLine();
        Console.Write("Creepy Meter alteration. Could just be way less emphasis on Creepiness even though they still have a limit.");
        Console.WriteLine();
        Console.Write("Occult Experiments Encouraged - Most receives points.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("EVIL HUNTERS -");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("GOOD consequence - can't use token. Also move on Creepy.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("If Bank was built - Mayor Award");
        Console.WriteLine();
        Console.Write("Charity penalty - ??");
        Console.WriteLine();
        Console.Write("Chemistry Award");
        Console.WriteLine();
        Console.Write("1st round Vote - call the Hunters out as fakes, challenge them to a contest.");
        Console.WriteLine();
        Console.Write("- those accepting the cure are unable to plot against the Hunters cannot count their Experiments towards the Event.");
        Console.WriteLine();
        Console.Write("2nd round Event - donate experiments and add up VP - Either minor reward or donation of Experiment to release into the wild.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Chemistry Award given to player");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Building Gets Checked at end of every round. If a player hasn't performed the action, they take a penalty.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Hunters - MONSTERS ARE NOT REAL IN THIS LINE");
        Console.WriteLine();
        Console.Write("wealth, fame, and power. Something which they will fight to keep, but will not fight actual monsters.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("1st round - family meeting! Do we confront the liars and antagonize them (gain Creepy and potentially other negatives). Or do we allow them to continue their ruse (pay taxes and stay the course).");
        Console.WriteLine();
        Console.Write("VOTE - use Voting token.");
        Console.WriteLine();
        Console.Write("- players that accepted the CURE have their votes overturned.");
        Console.WriteLine();
        Console.Write("- most votes win.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Chemistry Experiments Encouraged");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("NOT IMPLEMENTED IDEAS:");
        Console.WriteLine();
        Console.Write("Gain the completed Experiment of another player. That player loses 3VP.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("EVENT? I like Revenge for the player that's losing. They choose a player to have to fight.");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodEvilWolvesEventStart()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("The Monster Without");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "The Order of St. Hubertus' Lodge held a dark secret in the miasmic recesses beneath the edifice above, and after navigating a steep spiraling stone staircase, the cousins found themselves in a large stone room: a makeshift laboratory deep enough beneath the earth that the walls were warm with heat. Glass baubles and pilfered tools were stacked haphazardly around several wooden workspaces with failed experiments and devices thrown into metal waste bins beneath.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "The Lodge's caretaker extended a long clawed hand towards the center of the room, where a large circular stone well squatted. When they peered inside, they saw the infernal spawning grounds. Slime-covered beasts wallowed within a murky pit sloshing with the putrid stench of rotten meat. They wailed in unseen torment as the caretakers of the Order snapped coiled whips to frighten the malformed wretches into submission.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("The caretaker spoke in a harsh, gravelly tone, \"You are free to use this place as you wish. All that we ask is for a single experiment when we call upon you. Alternatively, our children here are always so very hungry.\"");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("It was a dark boon indeed to be offered a place in town to ");
        Console.Write("<bold>");
        Console.Write("perform experiments");
        Console.Write("</bold>");
        Console.Write(", but what would this horrible convenience cost them?");
        Console.WriteLine();
        Console.WriteLine();
        optionsManager.AddOption("VialCharity", MethodVialCharity);
        optionsManager.PresentOptions();
    }


    private static void MethodNoUni3Note()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("Barventures -");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("MASTERWORK REMOVED");
        Console.WriteLine();
        Console.Write("Immortality reward");
        Console.WriteLine();
        Console.Write("(Panacea return)");
        Console.WriteLine();
        Console.Write("CREATE-A-MASTERWORK");
        Console.WriteLine();
        Console.Write("Storybook Event - Barventures");
        Console.WriteLine();
        Console.Write("Event - VOTE - to introduce Electricity to the town. They may not like it. It may not be worth the trouble, but the benefits could allow them to Experiment more quickly.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Reset Creepy Meter by visiiting Pub, then consult the Storybook.");
        Console.WriteLine();
        Console.Write("Knowledge is Creepy - gain Creepy for each Knowledge you have at the end of a round.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Create-A-Masterwork");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Kinda makes no sense that Immortality occurs along with MW destruction.");
        optionsManager.PresentOptions();
    }


    private static void MethodroundEndKnowledge()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("The Curse of Knowledge");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.round == 16)
        {
            Console.Write("The townsfolk chose to remain ignorant of the technological advances of the age. Not only did they begrudge and mistrust the wealth of knowledge that the cousins had accrued, they hated them for it.");
        }
        else
        {
            Console.Write(
                "The hostility had not abated. If anything, time had proven the townsfolk steadfast in their unsophisticated point of view. The perils of blind faith and excessive drink manifested in the gloom that surrounded the ashen streets.");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click to continue...", passage261_Fragment_0);
        Console.Write("</hook>");
        optionsManager.PresentOptions();
    }

    private static void passage261_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", ((StaticGameState.round == 16) ? MethodCureNegCons : MethodNoUniMayornCreepy));
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "Creepy_Icon";
        Console.WriteLine();
        Console.Write("Each player gains ");
        Console.Write("<bold>");
        Console.Write("1 ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("for ");
        Console.Write("<bold>");
        Console.Write("each");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("Knowledge cube in their Quarters.");
        Console.Write("</setupStyleEvnt>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage261_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage261_Fragment_0);
        optionsManager.PresentOptions();
    }


    private static void MethodHuntersHUBcode()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.mon =
        [
            "Strigoi",
            "Moon Presence",
            "Manticore",
            "Golem",
            "Wight",
            "Pricolici",
            "Troll",
            "Priest"
        ];
        StaticGameState.mon.Shuffle();
        StaticGameState.monster1 = StaticGameState.mon[0];
        StaticGameState.monster2 = StaticGameState.mon[1];
        StaticGameState.monster3 = StaticGameState.mon[2];
        StaticGameState.monster4 = StaticGameState.mon[3];
        StaticGameState.monster5 = StaticGameState.mon[4];
        StaticGameState.monster3 = StaticGameState.mon[5];
        StaticGameState.monster4 = StaticGameState.mon[6];
        StaticGameState.monster5 = StaticGameState.mon[7];
        StaticGameState.rew =
        [
            "Occult Knowledge",
            "Chemistry Knowledge",
            "Biology Knowledge",
            "Engineering Knowledge",
            "Chemicals",
            "Animals",
            "Gears",
            "$"
        ];
        StaticGameState.rew.Shuffle();
        StaticGameState.reward1 = StaticGameState.rew[0];
        StaticGameState.reward2 = StaticGameState.rew[1];
        StaticGameState.reward3 = StaticGameState.rew[2];
        StaticGameState.reward4 = StaticGameState.rew[3];
        StaticGameState.reward5 = StaticGameState.rew[4];
        StaticGameState.reward6 = StaticGameState.rew[5];
        StaticGameState.reward7 = StaticGameState.rew[6];
        StaticGameState.reward8 = StaticGameState.rew[7];
        if (StaticGameState.players == 3)
        {
            StaticGameState.hunttemp =
            [
                1,
                2,
                3
            ];
            StaticGameState.hunttemp.Shuffle();
            StaticGameState.hunt1a = StaticGameState.hunttemp[0];
            StaticGameState.hunt1b = StaticGameState.hunttemp[1];
            StaticGameState.hunt2a = StaticGameState.hunttemp[2];
            StaticGameState.hunt2b = StaticGameState.hunttemp[1];
        }

        if (StaticGameState.players == 4)
        {
            StaticGameState.hunttemp =
            [
                1,
                2,
                3,
                4
            ];
            StaticGameState.hunttemp.Shuffle();
            StaticGameState.hunt1a = StaticGameState.hunttemp[0];
            StaticGameState.hunt1b = StaticGameState.hunttemp[1];
            StaticGameState.hunt2a = StaticGameState.hunttemp[2];
            StaticGameState.hunt2b = StaticGameState.hunttemp[3];
        }

        if (StaticGameState.players == 5)
        {
            StaticGameState.hunttemp =
            [
                1,
                2,
                3,
                4,
                5
            ];
            StaticGameState.hunttemp.Shuffle();
            StaticGameState.hunt1a = StaticGameState.hunttemp[0];
            StaticGameState.hunt1b = StaticGameState.hunttemp[1];
            StaticGameState.hunt2a = StaticGameState.hunttemp[2];
            StaticGameState.hunt2b = StaticGameState.hunttemp[3];
            StaticGameState.hunt3a = StaticGameState.hunttemp[4];
        }

        if (StaticGameState.hunt1a == 1)
        {
            StaticGameState.h1a = StaticGameState.nameA;
        }

        if (StaticGameState.hunt1a == 2)
        {
            StaticGameState.h1a = StaticGameState.nameB;
        }

        if (StaticGameState.hunt1a == 3)
        {
            StaticGameState.h1a = StaticGameState.nameC;
        }

        if (StaticGameState.hunt1a == 4)
        {
            StaticGameState.h1a = StaticGameState.nameD;
        }

        if (StaticGameState.hunt1a == 5)
        {
            StaticGameState.h1a = StaticGameState.nameE;
        }

        if (StaticGameState.hunt1b == 1)
        {
            StaticGameState.h1b = StaticGameState.nameA;
        }

        if (StaticGameState.hunt1b == 2)
        {
            StaticGameState.h1b = StaticGameState.nameB;
        }

        if (StaticGameState.hunt1b == 3)
        {
            StaticGameState.h1b = StaticGameState.nameC;
        }

        if (StaticGameState.hunt1b == 4)
        {
            StaticGameState.h1b = StaticGameState.nameD;
        }

        if (StaticGameState.hunt1b == 5)
        {
            StaticGameState.h1b = StaticGameState.nameE;
        }

        if (StaticGameState.hunt2a == 1)
        {
            StaticGameState.h2a = StaticGameState.nameA;
        }

        if (StaticGameState.hunt2a == 2)
        {
            StaticGameState.h2a = StaticGameState.nameB;
        }

        if (StaticGameState.hunt2a == 3)
        {
            StaticGameState.h2a = StaticGameState.nameC;
        }

        if (StaticGameState.hunt2a == 4)
        {
            StaticGameState.h2a = StaticGameState.nameD;
        }

        if (StaticGameState.hunt2a == 5)
        {
            StaticGameState.h2a = StaticGameState.nameE;
        }

        if (StaticGameState.hunt2b == 1)
        {
            StaticGameState.h2b = StaticGameState.nameA;
        }

        if (StaticGameState.hunt2b == 2)
        {
            StaticGameState.h2b = StaticGameState.nameB;
        }

        if (StaticGameState.hunt2b == 3)
        {
            StaticGameState.h2b = StaticGameState.nameC;
        }

        if (StaticGameState.hunt2b == 4)
        {
            StaticGameState.h2b = StaticGameState.nameD;
        }

        if (StaticGameState.hunt2b == 5)
        {
            StaticGameState.h2b = StaticGameState.nameE;
        }

        if (StaticGameState.hunt1c == 1)
        {
            StaticGameState.h2c = StaticGameState.nameA;
        }

        if (StaticGameState.hunt1c == 2)
        {
            StaticGameState.h2c = StaticGameState.nameB;
        }

        if (StaticGameState.hunt1c == 3)
        {
            StaticGameState.h2c = StaticGameState.nameC;
        }

        if (StaticGameState.hunt1c == 4)
        {
            StaticGameState.h2c = StaticGameState.nameD;
        }

        if (StaticGameState.hunt1c == 5)
        {
            StaticGameState.h2c = StaticGameState.nameE;
        }

        if (StaticGameState.players == 2)
        {
            StaticGameState.h1a = StaticGameState.nameA;
            StaticGameState.h2a = StaticGameState.nameA;
            StaticGameState.h1b = StaticGameState.nameB;
            StaticGameState.h2b = StaticGameState.nameB;
        }

        Console.WriteLine();
        MethodEvilsforgive();
        optionsManager.PresentOptions();
    }


    private static void MethodTieredRewards1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Reckoning");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("The messenger from the Order thanked the scientists and vowed to return once again after a time.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click to continue...", passage263_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage263_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", MethodGloomyGothic2);
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "S1_WolfToken";
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Any player that donated an ");
        Console.Write("<bold>");
        Console.Write("A Experiment");
        Console.Write("</bold>");
        Console.Write(":");
        Console.WriteLine();
        Console.Write(StaticGameState.GetRandom(new[]
        {
            "Gain 1VP.",
            "Gain an ingredient of your choice.",
            "Receives no bonus.",
            "Loses 1VP. The Order is unpleased with this meager offering."
        }));
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Any player that donated a ");
        Console.Write("<bold>");
        Console.Write("B Experiment");
        Console.Write("</bold>");
        Console.Write(":");
        Console.WriteLine();
        Console.Write(StaticGameState.GetRandom(new[]
        {
            "Gain a Knowledge of your choice.",
            "Gain $2.",
            "Gain 2VP."
        }));
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Any player that donated a ");
        Console.Write("<bold>");
        Console.Write("C Experiment");
        Console.Write("</bold>");
        Console.Write(":");
        Console.WriteLine();
        Console.Write(StaticGameState.GetRandom(new[]
        {
            "Gain 4VP.",
            "Gain $4."
        }));
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Any player that chose not to donate ");
        Console.Write("<bold>");
        Console.Write("returns a Servant to Lost");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("and ");
        Console.Write("<bold>");
        Console.Write("gains 1 ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write("</bold>");
        Console.Write(". ");
        Console.Write("<i>If you cannot lose a Servant, lose 3VP instead.</i>");
        Console.Write("</setupStyleEvnt>");
        optionsManager.PresentOptions();
    }

    private static void passage263_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage263_Fragment_0);
        optionsManager.PresentOptions();
    }


    private static void MethodCannotParticipate()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("In the Blood");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("However, at their final moment of triumph, an unfortunate occurrence in the family's past could have potentially unraveled their attempt to overthrow the Hunters' dominion over this fair village.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "In the interim evenings before the event could begin, for some, the very thought of confronting the Hunters made them desperately ill. It was as if some occult power had a hold over their senses. This nausea quickly turned to resolve and some even questioned why they had ever doubted the veracity of the Hunters' claims.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("But, how could their parents have envisioned a strong curse would have been placed upon them when they decided to accept the ");
        Console.Write("<bold>");
        Console.Write("cure");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("so many years ago?");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click to continue...", passage264_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage264_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", MethodHunterConf2);
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "S1_DiseaseExperiment";
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Any player with a ");
        Console.Write("<bold>");
        Console.Write("STORED Hereditary Disease Experiment");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("card cannot donate an Experiment to this Event. They immediately ");
        Console.Write("<bold>");
        Console.Write("Lose 1 ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("and return the stored ");
        Console.Write("<bold>");
        Console.Write("Hereditary Disease Experiment");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("to the scenario box.");
        Console.Write("</setupStyleEvnt>");
        optionsManager.PresentOptions();
    }

    private static void passage264_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage264_Fragment_0);
        optionsManager.PresentOptions();
    }
}