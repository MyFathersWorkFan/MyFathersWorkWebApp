namespace MyFathersWorkConsole;

public static partial class Scenario
{
    private static void MethodHospital1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("THRIVING IN ADVERSITY - Early Years");
        Console.Write("</bold>");
        Console.WriteLine();
        StaticGameState.round = 7;
        Console.WriteLine();
        if (StaticGameState.twopage == 0 || StaticGameState.twopage == "")
        {
            Console.Write("<setupStyle>");
            Console.Write("<bold>");
            Console.Write("SETUP");
            Console.Write("</bold>");
            if (StaticGameState.seedy == "yes")
            {
                StaticGameState._SetupImage = "AngryMobSetup2";
                Console.WriteLine();
            }
            else
            {
                StaticGameState._SetupImage = "AngryMobSetup1";
                Console.WriteLine();
            }

            Console.WriteLine();
            if (StaticGameState.building == "bank")
            {
                Console.Write("Turn to page 4 of the Village Chronicle.");
            }
            else
            {
                Console.Write("Turn to page 5 of the Village Chronicle.");
            }

            Console.WriteLine();
            Console.Write("Place the Suspicion marker on space ");
            Console.Write("<bold>");
            if (StaticGameState.players > 3 && (StaticGameState.Hospital1 == 0 || StaticGameState.Hospital1 == ""))
            {
                StaticGameState.Hospital1 = 1;
                StaticGameState.tracker = int.Parse(StaticGameState.tracker) - 1;
            }

            Console.Write(StaticGameState.tracker);
            Console.Write("</bold>");
            Console.Write(" ");
            Console.Write("and the ");
            Console.Write("<sprite=\"AngryMob_Icon\" index=0>");
            Console.Write(" ");
            Console.Write("token ");
            if (StaticGameState.seedy == "yes")
            {
                Console.Write("<bold>");
                Console.Write("two");
                Console.Write("</bold>");
                Console.Write(" spaces to the left (due to some seedy dealings).");
            }
            else
            {
                Console.Write("one space to the left.");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Then, place a ");
            Console.Write("<sprite=\"Storybook\" index=0>");
            Console.Write(" ");
            Console.Write("token on ");
            Console.Write("<bold>");
            Console.Write("space 35");
            Console.Write("</bold>");
            Console.Write(" ");
            Console.Write("of the VP track. ");
            if (StaticGameState.players == 3)
            {
                Console.Write("Then, since this is a 3 player game, pass the starting player marker clockwise 1 additional time.");
            }

            Console.Write("</setupStyle>");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<sprite=\"Storybook\" index=0>");
        Console.Write("<bold>");
        Console.Write(" Board of Trustees");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write(
            "Due to the efforts of your family, the Hospital has graciously awarded you with a seat on the Hospital's board of trustees. All players MUST personally visit the Hospital at least one time during this Generation by placing their Self on the Hospital space in town.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("The ");
        Console.Write("<bold>");
        Console.Write("first time");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("you visit the Hospital with your Self, ");
        optionsManager.AddOption("HospitalVisitCheck", MethodHospitalVisitCheck);
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<italic>");
        Console.Write("(If, for any reason, you have not visited the Hospital by the end of this Generation, lose 6VP and an Estate Upgrade of your choice, if possible.)");
        Console.Write("</italic>");
        Console.Write("</hubDetails>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<bold>");
        Console.Write("Hospital");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write("For an explanation of the Hospital action space, ");
        optionsManager.AddOption("HospitalDefine", MethodHospitalDefine);
        Console.Write("</hubDetails>");
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.cured == 0)
        {
            Console.Write("<hubTitle>");
            Console.Write("<sprite=\"Storybook\" index=0>");
            Console.Write("<bold>");
            Console.Write(" The Cure");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("Whenever a player completes the ");
            Console.Write("<bold>");
            Console.Write("Yellow Fever Inoculation ");
            Console.Write("</bold>");
            optionsManager.AddOption("YellowFeverCureSignin", MethodYellowFeverCureSignin);
            Console.Write("</hubDetails>");
        }

        if (StaticGameState.cured == 1)
        {
            Console.Write("<hubTitle>");
            Console.Write("<sprite=\"Storybook\" index=0>");
            Console.Write("<bold>");
            Console.Write(" The Panacea");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("Whenever a player completes the ");
            Console.Write("<bold>");
            Console.Write("Panacea");
            Console.Write("</bold>");
            optionsManager.AddOption("Panacea", MethodPanacea);
            Console.Write("</hubDetails>");
        }

        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.sciadv == 0)
        {
            Console.Write("<hubTitle>");
            Console.Write("<sprite=\"Storybook\" index=0>");
            Console.Write("<bold>");
            Console.Write(" Scientific Advances");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("If a player completes a total of 3 B or C-Level ");
            Console.Write(StaticGameState.sci3);
            Console.Write(" Experiments this Generation, ");
            optionsManager.AddOption("Trigger3Experiments", MethodTrigger3Experiments);
            Console.Write("</hubDetails>");
            Console.WriteLine();
            Console.WriteLine();
        }

        if (StaticGameState.trigger35 == 0)
        {
            Console.Write("<hubTitle>");
            Console.Write("<sprite=\"Storybook\" index=0>");
            Console.Write("<bold>");
            Console.Write(" Victory Ahead");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("If a player reaches or passes the Storybook token on space 35 of the Victory Point Track, ");
            optionsManager.AddOption("Trigger35Points", MethodTrigger35Points);
            Console.Write("</hubDetails>");
        }

        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<bold>");
        Console.Write("University Symposium");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write("At the end of the second round, a Symposium in the field of ");
        Console.Write(StaticGameState.sci3);
        Console.Write(" ");
        Console.Write("will be held to determine the fate of a ");
        Console.Write("<bold>");
        Console.Write("University");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("in town in the spot where the Traveling Caravan resides. Success will be determined by our combined dedication to completing ");
        Console.Write(StaticGameState.sci3);
        Console.Write(" ");
        Console.Write("Experiments.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click here at the end of the round to move to the next round...", passage3_Fragment_0);
        Console.Write("</hook>");
        Console.Write("</hubDetails>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage3_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.PrintEndOfTheRoundText("Hospital1", MethodImmortality);
        optionsManager.PresentOptions();
    }


    private static void MethodDevastation1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Devastation - Early Years");
        Console.Write("</bold>");
        Console.WriteLine();
        ispasscode = true;
        StaticGameState.round = 4;
        Console.WriteLine();
        if (StaticGameState.devpage == 0 || StaticGameState.devpage == "")
        {
            Console.Write("<setupStyle>");
            Console.Write("<bold>");
            Console.Write("SETUP");
            Console.Write("</bold>");
            if (StaticGameState.seedy == "yes")
            {
                StaticGameState._SetupImage = "AngryMobSetup2";
                Console.WriteLine();
            }
            else
            {
                StaticGameState._SetupImage = "AngryMobSetup1";
                Console.WriteLine();
            }

            Console.Write("Turn to page ");
            if (StaticGameState.building == "bank")
            {
                Console.Write("<bold>");
                Console.Write("12");
                Console.Write("</bold>");
            }
            else
            {
                Console.Write("<bold>");
                Console.Write("13");
                Console.Write("</bold>");
            }

            Console.Write(" of the Village Chronicle. Place the Suspicion marker on space ");
            Console.Write("<bold>");
            if (StaticGameState.Devastation1 == 0 || StaticGameState.Devastation1 == "")
            {
                StaticGameState.Devastation1 = 1;
                StaticGameState.tracker = int.Parse(StaticGameState.tracker) + 2;
                if (StaticGameState.players == 4)
                {
                    StaticGameState.tracker = int.Parse(StaticGameState.tracker) + 3;
                }

                if (StaticGameState.players == 5)
                {
                    StaticGameState.tracker = int.Parse(StaticGameState.tracker) + 3;
                }
            }

            Console.Write(StaticGameState.tracker);
            Console.Write("</bold>");
            Console.Write(" and the ");
            Console.Write("<sprite=\"AngryMob_Icon\" index=0>");
            Console.Write(" token ");
            if (StaticGameState.seedy == "yes")
            {
                Console.Write("<bold>");
                Console.Write("two");
                Console.Write("</bold>");
                Console.Write(" spaces to the left (due to some seedy dealings).");
            }
            else
            {
                Console.Write("one space to the left.");
            }

            Console.Write(" Pass the Start Player token to the player with the ");
            Console.Write("<sprite=\"S1_HeartToken\" index=0>");
            Console.Write(".");
            Console.Write("</setupStyle>");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<sprite=\"Storybook\" index=0>");
        Console.Write("<bold>");
        Console.Write(" Clandestine Meetings");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write("When a player reveals their Sealed Envelope card, complete the location's action and then ");
        optionsManager.AddOption("Envelopes", MethodEnvelopes);
        Console.Write("</hubDetails>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<sprite=\"Storybook\" index=0>");
        Console.Write("<bold>");
        Console.Write(" Relief from Disease");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write("A \"Hereditary Disease\" Experiment card can be completed by taking the Perform Experiment action as normal. Completing this Experiment will allow you to ");
        Console.Write("<bold>");
        Console.Write("ignore all ill effects");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("from Disease between rounds.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("When a player completes their Hereditary Disease Experiment, ");
        optionsManager.AddOption("HereditaryDiseaseComplete", MethodHereditaryDiseaseComplete);
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click here at the end of the round to move to the next round...", passage04_Fragment_0);
        Console.Write("</hook>");
        Console.Write("</hubDetails>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage04_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.PrintEndOfTheRoundText("Devastation1", MethodChanges);
        optionsManager.PresentOptions();
    }

    private static void MethodNoUni1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("THE CRAWL - Early Years");
        Console.Write("</bold>");
        Console.WriteLine();
        StaticGameState.round = 16;
        Console.WriteLine();
        if (StaticGameState.gen3pg == 0 || StaticGameState.gen3pg == "")
        {
            Console.Write("<setupStyle>");
            Console.Write("<bold>");
            Console.Write("SETUP");
            Console.Write("</bold>");
            StaticGameState._SetupImage = "AngryMobSetup1";
            Console.WriteLine();
            Console.Write("Turn to ");
            Console.Write("<bold>");
            Console.Write("page 8");
            Console.Write("</bold>");
            Console.Write(" ");
            Console.Write("of the Village Chronicle. Retrieve the ");
            Console.Write("<sprite=\"Creepy_Icon\" index=0>");
            Console.Write(" ");
            Console.Write("tokens from the box.");
            Console.WriteLine();
            Console.Write("Place the Suspicion Marker on space ");
            Console.Write("<bold>");
            if (StaticGameState.players == 2)
            {
                Console.Write("5");
            }
            else if (StaticGameState.players == 3)
            {
                Console.Write("6");
            }
            else if (StaticGameState.players == 4)
            {
                Console.Write("7");
            }
            else if (StaticGameState.players == 5)
            {
                Console.Write("8");
            }
            else
            {
                Console.Write("5");
            }

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
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<sprite=\"Storybook\" index=0>");
        Console.Write(" ");
        Console.Write("<bold>");
        Console.Write("PUB");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write("If your token is overtaken by the ");
        Console.Write("<sprite=\"AngryMob_Icon\" index=0>");
        Console.Write(", in addition to visiting the Church you can also visit any Pub. When you visit a Pub marked with a ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("and 0 symbol, ");
        Console.Write("<bold>");
        Console.Write("reset your ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("to zero");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("by buying a couple rounds at the Pub. Then, immediately ");
        optionsManager.AddOption("Barventures", MethodBarventures);
        Console.Write("</hubDetails>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<bold>");
        Console.Write("MASTERWORK");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write("A Masterwork can be completed by taking the Perform Experiment action and paying all of its costs.");
        Console.Write("</hubDetails>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<sprite=\"Storybook\" index=0>");
        Console.Write(" ");
        Console.Write("<bold>");
        Console.Write("Masterwork Recipe");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write("To check your Masterwork Cost, ");
        optionsManager.AddOption("MWTemp", MethodMWTemp);
        Console.Write("</hubDetails>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<sprite=\"Storybook\" index=0>");
        Console.Write(" ");
        Console.Write("<bold>");
        Console.Write("Completed Masterwork");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write("If you are completing a Masterwork, ");
        optionsManager.AddOption("MWCompleteName", MethodMWCompleteName);
        Console.Write("</hubDetails>");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<bold>");
        Console.Write("Knowledge");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write("At the end of each round, each player will ");
        Console.Write("<bold>");
        Console.Write("move one space forward on the ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("Track for each Knowledge cube in their Estate");
        Console.Write("</bold>");
        Console.Write(".");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click here at the end of the round to move to the next round...", passage11_Fragment_0);
        Console.Write("</hook>");
        Console.Write("</hubDetails>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage11_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.PrintEndOfTheRoundText("NoUni1", MethodroundEndKnowledge);
        optionsManager.PresentOptions();
    }


    private static void MethodHospitalintro()
    {
        Console.Write("<bold>");
        Console.Write("GENERATION II:");
        Console.WriteLine();
        Console.Write("Thriving in Adversity");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("It is said that springtime under the watchful eye of the snow-tipped Carpathian mountains is a wondrous sight to behold. A single excursion in these rolling hills amongst the paths that split green grass is said to reinvigorate the lonely traveler. It is common to catch the aroma of sweet bread in the air, the sounds of babbling streams with moss-covered roots sipping the cool waters, and the richness of golden honey sunsets illuminating the countryside. If but for one season, a certain blitheness, a blissful simplicity of purpose alights the torch of poetry in the dark minds of men.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Therefore, perhaps it is most appropriate that the return of the scientists coincided with this season, as thanks to their predecessors' aid the town had become rejuvenated. The ashen grayness that once dominated the small town had been brightened, like the azalea flowers and crocus that now bloomed in window boxes along the streets.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("The new hospital had become a site of great hope and strength for the people and the town was able to weather the disease even while the newspapers described the bleakness of the surrounding cities. Due to the work of their progenitors, honorary positions on the board of trustees at the hospital were awarded to their sons and daughters; positions which they sadly could not refuse. However, this controlled proximity to the ravages of disease also offered a boon for scientific inquiries and exploration.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("This serendipitous push forward in disease prevention attracted the attention of not only the diocese, but also the scientific community hoping to replicate their success. There were even rumors of a government-sponsored university; a prospect that caused great tension within the church and the townsfolk used to their isolated and bucolic existences.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("The possibilities for advancement - and exploitation - seemed limitless. But, would their ingenious and unorthodox ambitions prove too unconventional for the cautious minds of academia? Or would the pressures of rejection from their peers break their indomitable spirit?");
        Console.WriteLine();
        
        if (StaticGameState.building == "bank")
        {
            StaticGameState.hos = 4;
        }
        else
        {
            StaticGameState.hos = 5;
        }

        StaticGameState.twopage = 0;
        StaticGameState.life = 0;
        StaticGameState.fevervp = StaticGameState.GetRandom(new[]
        {
            4,
            5,
            6,
            7
        });
        StaticGameState.fevermoney = StaticGameState.GetRandom(new[]
        {
            8,
            9,
            10,
            11
        });
        StaticGameState.gen3pg = 0;
        StaticGameState.setinf = 0;
        StaticGameState.pana = 0;
        StaticGameState.hospA = 0;
        StaticGameState.hospB = 0;
        StaticGameState.hospC = 0;
        StaticGameState.hospD = 0;
        StaticGameState.hospE = 0;
        StaticGameState.cured = 0;
        StaticGameState.sciadv = 0;
        StaticGameState.trigger35 = 0;
        StaticGameState.lifeA = 0;
        StaticGameState.lifeB = 0;
        StaticGameState.lifeC = 0;
        StaticGameState.lifeD = 0;
        StaticGameState.lifeE = 0;
        StaticGameState.life = 0;
        StaticGameState.hospcount = 0;
        Console.WriteLine();
        optionsManager.AddOption("EradicateDisease", MethodEradicateDisease);
        optionsManager.PresentOptions();
    }


    private static void MethodScoring()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Scoring");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("Each Estate Upgrade is worth 1VP.");
        Console.WriteLine();
        Console.Write("Add any additional points from Vanity Estate Upgrades.");
        Console.WriteLine();
        Console.Write("Score -3VP for any Maladjustments gained at the End of this Generation.");
        Console.WriteLine();
        if (StaticGameState.lycan == "yes")
        {
            Console.Write("Check to make sure the player with ");
            Console.Write("<bold>");
            Console.Write("Lycanthropic Strength");
            Console.Write("</bold>");
            Console.Write(" completed their Masterwork. If they did not, they ");
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
            Console.Write(" completed their Masterwork. If they did not, they ");
            Console.Write("<bold>");
            Console.Write("lose 5VP.");
            Console.Write("</bold>");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click to tabulate scores for posterity...", passage13_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage13_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodUniversityIntro()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("GENERATION III:");
        Console.WriteLine();
        Console.Write("The University Advances");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        StaticGameState.theme = StaticGameState.GetRandom(new[]
        {
            "\"Chemistry\"",
            "\"Engineering\"",
            "\"Biology\""
        });
        Console.WriteLine();
        Console.Write(
            "They observed the city from the windows of their manor; watched as men in their brown sack suits and women with sashes tied firmly about their waists wandered the bustling sidewalks and modern pathways that winded throughout the university. What was once a bucolic and unknown region had developed into a thriving metropolis.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "And yet, it was that very same prosperity of the city that taunted them. Was it not their family's genius, their forebear's business acumen and ambition that exiled disease from the country? Was it not their shrewd antecedents that secured the government's funding of a university — the same who entered into this generation with the secret to eternal life?");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "Still the townsfolk eyed them as they would a foreigner, with silent judgement in their hearts. While the administration of the university offered assistance and reached out with kind words of encouragement, it was clear to the family that their presence was not truly appreciated. With each passing day, their resentment grew deeper. It seethed under the surface of their ambitious, technical labors.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "Science should not be contained by the arbitrary limits of ethics. They believed that this was their chance to legitimize the family's research and to prove that bold, swift, and unmitigatable genius would propel the world forward. The ends would justify the means. From darkness, an electric spark would form to capture the entire scientific world within its grasp!");
        Console.WriteLine();
        Console.WriteLine();
        optionsManager.AddOption("UniMayor", MethodUniMayor);
        Console.WriteLine();
        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodNoUniversityIntro()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("GENERATION III:");
        Console.WriteLine();
        Console.Write("DROWN YOUR SORROWS");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "They arrived by coach on a cold day in autumn, summoned from studies abroad in order to claim an inheritance that, despite their reticence, carried with it an extraordinary wealth that they could not resist. The once bright village they remembered from their eccentric youth was mired in gray fog that clung to the ashen streets. Their carriage nearly unchained itself in the deep muddy ruts of the dilapidated roads nearby.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "Not much is written about this time aside from journal entries from the young scientists that all echo an immediate revulsion towards the circumstances in which they found themselves and the sense of despair among the townsfolk. Photographs show us some evidence that the hospital was still in operation but its facilities had fallen into disrepair. The university that had once represented a bastion of new science was reduced to rubble, and in its place a disreputable tavern emerged.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "In fact, several public houses had been built upon the main thoroughfare. When the government denied the town a university, the backlash from the peasantry was swift. The citizens developed a sharp distrust of modern advances in science and medicine and were wary of those who displayed signs of intelligence. The grudge they harbored even prevented the extension of the electrical grid to a town in most desperate need of modern updates.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "There was an emptiness in the dusty hallways and barren passageways of the ruined Estates and this hollowness pressed upon the cousins' minds most forcefully. For years, they would be forced into secrecy, listless and isolated from their colleagues, their sense of ambition cut short at the most crucial interval. And while a visit to one of the spirited establishments would help quell the masses, the indulgence only made the gravity of the situation wear more heavily upon their features.");
        Console.WriteLine();
        Console.WriteLine();
        StaticGameState.final5 = 3;
        StaticGameState.bar = 0;
        Console.WriteLine();
        optionsManager.AddOption("CreepyStar", MethodCreepyStar);
        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodENDWolvesEvil1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Local Legends");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write(
            "Three generations of diligent scientific minds, toiling at an unspeakable work, surrounded by decaying stone walls, their ignoble experimentations tucked away amongst the deep forests and well-worn dirt roads that traverse the gray countryside.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "Could the family's indifference to the plight of the diseased truly be blamed for how the pandemic consumed the region? Is it possible that they assisted a supernatural force that could ingrain themselves so deeply in a small town's infrastructure that an entire populace would be turned into monsters themselves? Or that a counter-agent could be procured and unleashed to undo an evil curse?");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "Unearthing this mystery took considerable effort as the history of the region had all but been forgotten and the memory of several eccentric entrepreneurs isolated in aristocratic circles had faded away, obscured by time like the mists that still hang over this small valley. But whether truth or fiction, ");
        Console.Write(StaticGameState.townname);
        Console.Write(
            "'s residents cling to these superstitions in whispered conversations. On nights when strange sounds emerged from the fog, they turned their gaze towards the grim chateaus in the distance and wondered what strange machinations were contained within.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("THE END?");
        optionsManager.PresentOptions();
    }


    private static void MethodENDHuntersEvil1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Their Own Destiny");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write(
            "The impressive victory over the forces of superstition within the city marked a turning point in the acceptance of scientific experimentation and progress across the entire country. And while their work had done nothing to spare the community from future epidemics, their fears now abated, allowing them to expand deeper into the valley. Lucrative silver mining operations appeared and with it came even more opportunities for the family to invest.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "Tall tales once told to frighten children were now believed to be real, macabre stories of true horrible scientific experiments. And after the hideous experiments let loose were wrangled once again, the respect and fear the people had for the family was demonstrable. For the family, this veneration meant a guarantee of autonomy and resources.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "But their fame was merely relegated to the Hungarian hillsides. They had weathered the storm, but now it was time to summon and control the tempest! With their legacy firmly cemented, they stood perched upon the precipice of true scientific discovery, confident and ready for their next moment of brilliance.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("THE END?");
        optionsManager.PresentOptions();
    }


    private static void MethodENDWolvesGood1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("There Could Never Be Peace");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write(
            "There is not much possibility to confirm the notes I have herein on a society of monsters. I have scoured the surviving journal entries, newspaper clippings, and ephemera collected on a visit to the crumbling estates outside of ");
        Console.Write(StaticGameState.townname);
        Console.Write(". Or what remains of ");
        Console.Write(StaticGameState.townname);
        Console.Write(". Some locals in the areas surrounding the site swear by the stories, but the ensuing decades have made the information scarce and proof even more so.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("The final notes and news clippings available declare that a peace between monster and man finally seemed like an imminent possibility after recent talks with the government. However, it was only weeks later that ");
        Console.Write(StaticGameState.townname);
        Console.Write(" ");
        Console.Write(
            "became yet another casualty of the War to End All Wars. Despite the suspicious distance between the front lines and southeastern Hungary, an evening air raid resulted in a heavy firebomb and phosgene attack that devastated the city, leaving zero known survivors.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "As the cousins were vacationing along the Mediterranean at the time, this devastating loss was more one of property and potential opportunity. They were quick to salvage what remained of their experimentations and carry on again in their summer homes. The family had already established a name for themselves across the region, but what they had hoped would change the course of the world would have to wait as it was once again rebuilt.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "So like the monsters that once attempted to create their own utopian city hidden amongst the rolling hills and forests, the world was not yet ready for the family. But, like a phoenix rising reborn from the embers of destruction, it was assured that they would someday return to shock the world once again.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("THE END?");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodENDHunterGood1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("To Be Rid of Evil");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write(
            "When disease wreaked havoc across the countryside, they remained safe in isolation, steadfast in their determination to complete a work that would transform our understanding of the world. And when an evil presence burrowed its ghastly business underneath the rebuilding town of ");
        Console.Write(StaticGameState.townname);
        Console.Write(", the family ruthlessly exposed their efforts. Their contributions of time and resources to battle away the creatures when they threatened to overtake the countryside shone like a lighthouse in a storm.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "The evil scourge, once a plague of disease and then again a plague of horrors from beyond, had been vanquished, leaving only the knowledge gleaned from their very existence to strengthen the family's pursuits. Though they were unhappy to share the same luminous spotlight with the Fraternity, the fame was grand enough to sate them. The city, the country, and nearly the entirety of Eastern Europe now knew their name.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("It was a time of peace, but not a time of rest. They had so much more science to explore and so many new generations to do it. The world would soon quiver at the very mention of that family!");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("THE END?");
        optionsManager.PresentOptions();
    }


    private static void MethodENDNoUniGood()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("A Legacy Will Live On");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "This manuscript is dedicated to Dr. Ensign Benwallis who is survived by his two children, daughter, Celia Benwallis Cartwright and son, Ensign Benwallis Jr. It is with heavy heart that his story ends somewhere within these pages, though we endeavor to see his words live on. The research required for his later notes was known to have exacerbated his dipsomania. His untimely exit remains a stark reminder of the perils of inebriation.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("The family that commissioned his work has dedicated three percent of the proceeds from the publication of this document to the family of Dr. Benwallis. It is");
        if (StaticGameState.uni == "yes")
        {
            Console.Write(", as individuals associated with the original University groundbreaking,");
        }

        Console.Write(" ");
        Console.Write("the absolute least they could do.");
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.peeps == 0)
        {
            Console.Write("With the introduction of electricity to the region, we have already seen a marked increase in literacy percentages in the county. We are hopeful that this will attract an audience for this scholarly work.");
        }

        if (StaticGameState.peeps == 1)
        {
            Console.Write(
                "While we do not have hope for its continued publication within Hungary due to the region's continued lapse in general education capabilities and lack of connections to the electrical grid, we hope that individuals within other European markets will enjoy such a unique biography.");
        }

        Console.Write(" ");
        Console.Write("The eccentric and infamous scientific legacy of the family will undoubtedly leave its mark for many years to come.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("THE END?");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodS5Specialbar1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Hungarian Bright");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write(
            "While the cousins thrived in the lamplit tenebrosity of their basement laboratories and spent many evenings observing the melancholic, ashen mists that enveloped the nearby village, the lack of modern convenience - of light and electricity which had been granted across all of Europe - had become a detriment to their experimental capabilities.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "One particularly chill evening in winter, a meeting was called at the Town Hall, in which the topic of electricity and connection to the national grid was reintroduced. However, possibly fueled by many in attendance having already given patronage to the local pub, the icy mood of the meeting suddenly erupted into a fiery debate. The meeting soon descended into chaos and was adjourned as a minor brawl spilled out into the snow-covered streets. It appeared as if nothing would be done without intervention.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "With their influence amongst aristocratic circles, it would only take a minute amount of effort for the cousins to levy outside approval for the installation of an electrical grid. But were they aligned in their desire to agitate the masses?");
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.players == 2)
        {
            optionsManager.AddOption("2p-S5SpecialVoteALT", Method2pS5SpecialVoteALT);
        }
        else
        {
            optionsManager.AddOption("S5SpecialVote", MethodS5SpecialVote);
        }

        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodSymposiumFail()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Symposium Failure");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("\"Preposterous. A vaudevillian side-show.\" The scathing negative reviews were most predominant. ");
        Console.Write(StaticGameState.GetRandom(new[]
        {
            "Then, we were treated to a ghastly vivisection of a wailing goat while an electrical device stimulated the nervous reflexes. Had I known, I would have brought an umbrella.",
            "Steam shot from the abominable contraption's eye sockets as the speaker mumbled a rhythmic incantation that, if it had any effect at all, was to cause a ringing in my ears for hours afterward."
        }));
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("A professional scolding soon followed from notable experts in the ");
        Console.Write(StaticGameState.sci3);
        Console.Write(" ");
        Console.Write("field. Accused of peddling contentious pseudo-science, the cousins were informed that they would not be receiving any invitations for lecture opportunities in the future.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("The family returned home, each writing scathing remarks within their respective journals. They concluded that while they were no longer welcome at the University, \"they were also never planning to return anyway.\"");
        Console.WriteLine();
        Console.WriteLine();
        StaticGameState.uni = "no";
        StaticGameState.final5 = 5;
        if (StaticGameState.pana == "unleash")
        {
            optionsManager.AddOption("PanaceaUnleash", MethodPanaceaUnleash);
        }
        else
        {
            optionsManager.AddOption("Hospital3", MethodHospital3);
        }

        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodSymposiumSuccess()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Symposium Success");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("\"Eccentric, but certainly well-documented,\" the succinct, blood-stained note stated. \"I expected the worst when Dr. ");
        Console.Write(StaticGameState.nameB);
        Console.Write(" ");
        Console.Write("II began their presentation by ");
        Console.Write(StaticGameState.GetRandom(new[]
        {
            "strumming a popular tune on the vocal chords of an otter.",
            "winding up the gear mechanism of an automaton with sharpened blades for hands.",
            "creating a salt circle with a sack-doll at the center and then asking for a blood sample from someone in the audience.",
            "exploding a vial of acid using another, stronger vial of acid to 'get our attention'."
        }));
        Console.Write(" ");
        Console.Write("But, by the hour mark, the speech really hit its stride.\"");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "A mixture of befuddled excitement and intrigue swept through the halls of academia. Yet, the professors all agreed that despite a lack of traditional form, it was the inexorably excitable demeanor of the cousins that so enamored them.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("The Symposium had been a rousing success. Finally their work was becoming noted!");
        Console.WriteLine();
        StaticGameState.uni = "yes";
        StaticGameState.final5 = 6;
        Console.WriteLine();
        if (StaticGameState.pana == "unleash")
        {
            optionsManager.AddOption("PanaceaUnleash", MethodPanaceaUnleash);
        }
        else
        {
            optionsManager.AddOption("Hospital3", MethodHospital3);
        }

        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodS5HospA1Yes()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Immortality Advances");
        Console.Write("</bold>");
        Console.WriteLine("END OF GENERATION SETUP" + "Remove all player pieces from the board and perform the End of a Generation. Any <sprite=\"StorybookToken\" index=0> tokens remaining on a player's Journal Track are returned to the supply.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("The ");
        Console.Write("<bold>");
        Console.Write(StaticGameState.life);
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("scientists reveled in the suspicious glances of the townsfolk whenever they strolled through town, their visages spotless and unaging. Surely, the indefinite extension of their lives was a true marvel.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "They remained in the village, tending their estates into advanced ages unheard of in this Victorian era, seemingly untouched by time. The additional scientific advances made possible by this remarkable vitality guided the town towards a more modern direction.");
        Console.WriteLine();
        Console.WriteLine();
        optionsManager.AddOption("UniversityIntro", MethodUniversityIntro);
        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodForScience()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Award the Prize");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("It was inescapable. The most prestigious award in science and all the conventional praise, scrutiny, and adoration it engendered was thrust upon one of the family.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "For a normal scientist, it should be the pinnacle of achievements; an honor that would ensure their name etched forever in the halls of academia. And that was just it. To be revered fondly by the same association that simultaneously despises the very source of the family's infamous ingenuity. Not to mention the additional obligations from the cursed establishment would pull them from their work up until their final hours.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("No, for them, this honor was the proverbial final nail in the coffin.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click to continue...", passage25_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage25_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.WriteLine();
        optionsManager.AddOption("Continue...", MethodScoring);
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("The ");
        StaticGameState._SetupImage = "Creepy_Icon";
        Console.Write("<bold>");
        Console.Write("least ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("player ");
        Console.Write("<bold>");
        Console.Write("loses 7VP.");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("<italic>");
        Console.Write("(If there is a tie, ALL tied players ");
        Console.Write("<bold>");
        Console.Write("lose 4VP");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("instead.)");
        Console.WriteLine();
        Console.Write("</italic>");
        Console.WriteLine();
        Console.Write("</setupStyleEvnt>");
        optionsManager.PresentOptions();
    }


    private static void MethodSanityCheck()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Final Clarity");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("The boundary between mental instability and genius had been tested. It was this acuity, this willingness to find the perfect balance between madness and determination that defined the lives of this infamous family circle.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Continue to Final Scoring", passage26_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage26_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", MethodForScience);
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "Insanity_Icon";
        Console.Write("All players with their token on space ");
        Console.Write(StaticGameState.mental);
        Console.Write(" ");
        Console.Write("of the ");
        Console.Write("<sprite=\"Insanity_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("Track ");
        Console.Write("<bold>");
        Console.Write("gain 5VP");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("each.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("If ");
        Console.Write(StaticGameState.saneplayer);
        Console.Write(" ");
        Console.Write("has their token on space ");
        Console.Write(StaticGameState.mental);
        Console.Write(", they ");
        Console.Write("<bold>");
        Console.Write("gain ");
        Console.Write(StaticGameState.GetRandom(new[]
        {
            8,
            9
        }));
        Console.Write("VP");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("instead.");
        Console.Write("</setupStyleEvnt>");
        optionsManager.PresentOptions();
    }


    private static void MethodBarventures()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Bar-venture");
        Console.Write("</bold>");
        StaticGameState.barin = StaticGameState.GetRandom(new[]
        {
            1,
            2,
            3
        });
        StaticGameState.gen3pg = 1;
        Console.WriteLine();
        if (StaticGameState.barin == 1)
        {
            Console.Write("<italic>");
            Console.Write("Local records from this time show a shocking number of legal depositions submitted on the behalf of the family due to minor incidents at one of the town's drinking establishments. A pertinent example is included below.");
            Console.Write("</italic>");
        }
        else if (StaticGameState.barin == 2)
        {
            Console.Write("<italic>");
            Console.Write("As your historical curator, I humbly submit this legal document in its entirety as an example of the colorful \"adventures\" remarked upon by locals during my research into the family's past.");
            Console.Write("</italic>");
        }
        else
        {
            Console.Write("<italic>");
            Console.Write("It is in the interest of thoroughness that I include this legal note. Maybe it is of some ");
            Console.Write(StaticGameState.GetRandom(new[]
            {
                "historical",
                "comical",
                "scientific"
            }));
            Console.Write(" value? The sheer number of embarrassing anecdotes does offer insight into the character of the scientists, though it certainly does not paint them in a favorable light.");
            Console.Write("</italic>");
        }

        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.round == 16)
        {
            StaticGameState.GetRandom(new[]
            {
                Methodbar1,
                Methodbar2,
                Methodbar3,
                Methodbar4,
                Methodbar5,
                Methodbar6,
                Methodbar7
            }).Invoke();
        }
        else if (StaticGameState.round == 17)
        {
            StaticGameState.GetRandom(new[]
            {
                Methodbar1,
                Methodbar2,
                Methodbar3,
                Methodbar4,
                Methodbar5,
                Methodbar6,
                Methodbar7
            }).Invoke();
        }
        else
        {
            StaticGameState.GetRandom(new[]
            {
                Methodbar1,
                Methodbar2,
                Methodbar3,
                Methodbar4,
                Methodbar6,
                Methodbar7
            }).Invoke();
        }

        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.round == 16)
        {
            optionsManager.AddOption("NoUni1", MethodNoUni1);
        }
        else if (StaticGameState.round == 17)
        {
            optionsManager.AddOption("NoUni2", MethodNoUni2);
        }
        else
        {
            optionsManager.AddOption("NoUni3", MethodNoUni3);
        }

        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void MethodChanges()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("A Return to Civility");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "Though the decayed trails that led to the village caused a carriage to jostle and creak most violently, a brisk, morning ride allowed the aging aristocrats a chance to escape the stale air of their stone manors and ruminate on the melancholic, dour beauty of the region.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "It was upon these morning rides that they were able to observe a sudden and peculiar transformation occurring within the town. Crews of hired laborers arrived to clear several of the empty lots in the village and construct new foundations. Within weeks, these vacant lots were filled by nondescript buildings of various purposes.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Armed with an inimitable curiosity and thirst for knowledge, the cousins could not resist further investigation.");
        Console.WriteLine();
        StaticGameState.devpage = 0;
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click to continue...", passage31_Fragment_0);
        Console.Write("</hook>");
        optionsManager.PresentOptions();
    }

    private static void passage31_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.WriteLine();
        optionsManager.AddOption("Continue...", MethodDiseases1);
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "S1_LetterBACK";
        Console.WriteLine();
        Console.Write("All players discard their Letter cards to the box.");
        Console.Write("</setupStyleEvnt>");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        StaticGameState.build =
        [
            1,
            2,
            3,
            4,
            5
        ];
        if (StaticGameState.building == "bank")
        {
            StaticGameState.build.Remove(2);
        }
        else
        {
            StaticGameState.build.Remove(3);
        }

        StaticGameState.build.Shuffle();
        StaticGameState.buildA = StaticGameState.build[0];
        StaticGameState.buildB = StaticGameState.build[1];
        if (StaticGameState.building == "bank")
        {
            StaticGameState.buildC = 2;
        }
        else if (StaticGameState.building == "library")
        {
            StaticGameState.buildC = 3;
        }
        else
        {
            StaticGameState.buildC = StaticGameState.build[2];
        }

        if (StaticGameState.buildA == 1)
        {
            StaticGameState.ba = "Hardware Store";
        }
        else if (StaticGameState.buildA == 2)
        {
            StaticGameState.ba = "Wire Service";
        }
        else if (StaticGameState.buildA == 3)
        {
            StaticGameState.ba = "Book Store";
        }
        else if (StaticGameState.buildA == 4)
        {
            StaticGameState.ba = "Warehouse";
        }
        else
        {
            StaticGameState.ba = "Pet Store";
        }

        if (StaticGameState.buildB == 1)
        {
            StaticGameState.bb = "Hardware Store";
        }
        else if (StaticGameState.buildB == 2)
        {
            StaticGameState.bb = "Wire Service";
        }
        else if (StaticGameState.buildB == 3)
        {
            StaticGameState.bb = "Book Store";
        }
        else if (StaticGameState.buildB == 4)
        {
            StaticGameState.bb = "Warehouse";
        }
        else
        {
            StaticGameState.bb = "Pet Store";
        }

        if (StaticGameState.buildC == 1)
        {
            StaticGameState.bc = "Hardware Store";
        }
        else if (StaticGameState.buildC == 2)
        {
            StaticGameState.bc = "Wire Service";
        }
        else if (StaticGameState.buildC == 3)
        {
            StaticGameState.bc = "Book Store";
        }
        else if (StaticGameState.buildC == 4)
        {
            StaticGameState.bc = "Warehouse";
        }
        else
        {
            StaticGameState.bc = "Pet Store";
        }

        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage31_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage31_Fragment_0);
        optionsManager.PresentOptions();
    }


    private static void MethodDevastation3()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Devastation - Late Years");
        Console.Write("</bold>");
        Console.WriteLine();
        StaticGameState.round = 6;
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<sprite=\"Storybook\" index=0>");
        Console.Write(" ");
        Console.Write("<bold>");
        Console.Write(" Suspicion");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write(
            "When a player visits one of the three Suspicious locations, they may investigate the location by secretly picking it up and looking at its reverse side. Then, click on the appropriate location below to choose whether to reveal or conceal the secrets underneath.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Investigate " + (string)StaticGameState.ba, passage32_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Investigate " + (string)StaticGameState.bb, passage32_Fragment_1);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Investigate " + (string)StaticGameState.bc, passage32_Fragment_2);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<italic>");
        Console.Write("You may visit the same Building multiple times.");
        Console.Write("</italic>");
        Console.Write(" ");
        Console.Write("At the end of the Generation, if a Building has been revealed more times than concealed, the work will be ");
        Console.Write("<bold>");
        Console.Write("Exposed");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("for the world to see.");
        Console.Write("</hubDetails>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<sprite=\"Storybook\" index=0>");
        Console.Write(" ");
        Console.Write("<bold>");
        Console.Write(" Relief from Disease");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write("A \"Hereditary Disease\" Experiment card can be completed by taking the Perform Experiment action as normal. Completing this Experiment will allow you to ");
        Console.Write("<bold>");
        Console.Write("ignore all ill effects");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("from Disease between rounds.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("When a player completes their Hereditary Disease Experiment, ");
        optionsManager.AddOption("HereditaryDiseaseComplete", MethodHereditaryDiseaseComplete);
        Console.Write("</hubDetails>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<sprite=\"Storybook\" index=0>");
        Console.Write(" ");
        Console.Write("<bold>");
        Console.Write(" Stable Hand");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write("When a player visits the Stables, they may ");
        optionsManager.AddOption("RefusalEvent", MethodRefusalEvent);
        Console.Write(" ");
        Console.Write("<italic>");
        Console.Write("If you have joined a faction, this action will have no effect.");
        Console.Write("</italic>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click here at the end of the Generation to Determine the Fate of the Town.", passage35_Fragment_3);
        Console.Write("</hook>");
        Console.Write("</hubDetails>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage32_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.inv = StaticGameState.ba;
        MethodBuildingSignin();
        optionsManager.PresentOptions();
    }

    private static void passage32_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.inv = StaticGameState.bb;
        MethodBuildingSignin();
        optionsManager.PresentOptions();
    }

    private static void passage32_Fragment_2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.inv = StaticGameState.bc;
        MethodBuildingSignin();
        optionsManager.PresentOptions();
    }

    private static void passage35_Fragment_3()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.PrintEndOfTheRoundText("Devastation3", MethodBuildingsEnd);
        optionsManager.PresentOptions();
    }


    private static void MethodDevastation2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Devastation - Middle Years");
        Console.Write("</bold>");
        Console.WriteLine();
        StaticGameState.round = 5;
        Console.WriteLine();
        if (StaticGameState.devpage == 0 || StaticGameState.devpage == "")
        {
            Console.Write("<setupStyle>");
            Console.Write("<bold>");
            Console.Write("SETUP");
            Console.Write("</bold>");
            StaticGameState._SetupImage = "S1_Suspicious_Building";
            Console.WriteLine();
            Console.Write("Turn to page ");
            Console.Write("<bold>");
            Console.Write("14");
            Console.Write("</bold>");
            Console.Write(" ");
            Console.Write("of the Village Chronicle. Retrieve the ");
            Console.Write("<bold>");
            Console.Write("Suspicious Building");
            Console.Write("</bold>");
            Console.Write(" ");
            Console.Write("tiles, leaving them building side up.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Place a storybook token on the ");
            Console.Write("<bold>");
            Console.Write("Stables");
            Console.Write("</bold>");
            Console.Write(".");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Place the Building marked ");
            Console.Write("<bold>");
            Console.Write(StaticGameState.ba);
            Console.Write("</bold>");
            Console.Write(" ");
            Console.Write("on the A Building location.");
            Console.WriteLine();
            Console.Write("Place the Building marked ");
            Console.Write("<bold>");
            Console.Write(StaticGameState.bb);
            Console.Write("</bold>");
            Console.Write(" ");
            Console.Write("on the B Building location.");
            Console.WriteLine();
            Console.Write("Place the Building marked ");
            Console.Write("<bold>");
            Console.Write(StaticGameState.bc);
            Console.Write("</bold>");
            Console.Write(" ");
            Console.Write("on the C Building location.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Return the remaining tiles to the scenario box.");
            Console.Write("</setupStyle>");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<sprite=\"Storybook\" index=0>");
        Console.Write(" ");
        Console.Write("<bold>");
        Console.Write(" Suspicion");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write(
            "When a player visits one of the three Suspicious locations, they may investigate the location by secretly picking it up and looking at its reverse side. Then, click on the appropriate location below to choose whether to reveal or conceal the secrets underneath.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Investigate " + (string)StaticGameState.ba, passage33_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Investigate " + (string)StaticGameState.bb, passage33_Fragment_1);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Investigate " + (string)StaticGameState.bc, passage33_Fragment_2);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<italic>");
        Console.Write("You may visit the same Building multiple times.");
        Console.Write("</italic>");
        Console.Write(" ");
        Console.Write("At the end of the Generation, if a Building has been revealed more times than concealed, the work will be ");
        Console.Write("<bold>");
        Console.Write("Exposed");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("for the world to see.");
        Console.Write("</hubDetails>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<sprite=\"Storybook\" index=0>");
        Console.Write(" ");
        Console.Write("<bold>");
        Console.Write(" Relief from Disease");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write("A \"Hereditary Disease\" Experiment card can be completed by taking the Perform Experiment action as normal. Completing this Experiment will allow you to ");
        Console.Write("<bold>");
        Console.Write("ignore all ill effects");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("from Disease between rounds.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("When a player completes their Hereditary Disease Experiment, ");
        optionsManager.AddOption("HereditaryDiseaseComplete", MethodHereditaryDiseaseComplete);
        Console.Write("</hubDetails>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<sprite=\"Storybook\" index=0>");
        Console.Write(" ");
        Console.Write("<bold>");
        Console.Write(" Stable Hand");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write("When a player visits the Stables, they may ");
        optionsManager.AddOption("RefusalEvent", MethodRefusalEvent);
        Console.Write(" ");
        Console.Write("<italic>");
        Console.Write("If you have joined a faction, this action will have no effect.");
        Console.Write("</italic>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click here at the end of the round for a Special Event...", passage36_Fragment_3);
        Console.Write("</hook>");
        Console.Write("</hubDetails>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage33_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.inv = StaticGameState.ba;
        MethodBuildingSignin();
        optionsManager.PresentOptions();
    }

    private static void passage33_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.inv = StaticGameState.bb;
        MethodBuildingSignin();
        optionsManager.PresentOptions();
    }

    private static void passage33_Fragment_2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.inv = StaticGameState.bc;
        MethodBuildingSignin();
        optionsManager.PresentOptions();
    }

    private static void passage36_Fragment_3()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.PrintEndOfTheRoundText("Devastation2", MethodDevEventCure);
        optionsManager.PresentOptions();
    }


    private static void MethodHospital2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("THRIVING IN ADVERSITY - Middle Years");
        Console.Write("</bold>");
        Console.WriteLine();
        StaticGameState.round = 8;
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<sprite=\"Storybook\" index=0>");
        Console.Write("<bold>");
        Console.Write(" Board of Trustees");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write("All players MUST place their Self on the Hospital space in town once this generation. ");
        Console.Write("<italic>");
        Console.Write("(If, for any reason, you have not visited the Hospital by the end of this Generation, lose 6VP and an Estate Upgrade of your choice, if possible.)");
        Console.Write("</italic>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("The <b>first time</b> you visit the Hospital with your Self, ");
        optionsManager.AddOption("HospitalVisitCheck", MethodHospitalVisitCheck);
        Console.Write("</hubDetails>");
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.cured == 0)
        {
            Console.Write("<hubTitle>");
            Console.Write("<sprite=\"Storybook\" index=0>");
            Console.Write("<bold>");
            Console.Write(" The Cure");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("Whenever a player completes the ");
            Console.Write("<bold>");
            Console.Write("Yellow Fever Inoculation ");
            Console.Write("</bold>");
            optionsManager.AddOption("YellowFeverCureSignin", MethodYellowFeverCureSignin);
            Console.Write("</hubDetails>");
        }

        if (StaticGameState.cured == 1)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hubTitle>");
            Console.Write("<sprite=\"Storybook\" index=0>");
            Console.Write("<bold>");
            Console.Write(" The Panacea");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("Whenever a player completes the ");
            Console.Write("<bold>");
            Console.Write("Panacea");
            Console.Write("</bold>");
            optionsManager.AddOption("Panacea", MethodPanacea);
            Console.Write("</hubDetails>");
        }

        if (StaticGameState.trigger35 == 0)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hubTitle>");
            Console.Write("<sprite=\"Storybook\" index=0>");
            Console.Write("<bold>");
            Console.Write(" Victory Ahead");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("If a player reaches or passes the Storybook token on space 35 of the Victory Point Track, ");
            optionsManager.AddOption("Trigger35Points", MethodTrigger35Points);
            Console.Write("</hubDetails>");
            Console.WriteLine();
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<sprite=\"Storybook\" index=0>");
        Console.Write(" ");
        Console.Write("<bold>");
        Console.Write("The Secret to Immortality");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write("If any player reaches the third level of research on the Journal Track with their Storybook token, ");
        optionsManager.AddOption("InfinityClick1", MethodInfinityClick1);
        Console.Write("</hubDetails>");
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.sciadv == 0)
        {
            Console.Write("<hubTitle>");
            Console.Write("<sprite=\"Storybook\" index=0>");
            Console.Write("<bold>");
            Console.Write(" Scientific Advances");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("If a player completes a total of 3 B or C-Level ");
            Console.Write(StaticGameState.sci3);
            Console.Write(" Experiments this Generation, ");
            optionsManager.AddOption("Trigger3Experiments", MethodTrigger3Experiments);
            Console.Write("</hubDetails>");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<bold>");
        Console.Write("University Symposium");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write("At the end of the second round, a Symposium in the field of ");
        Console.Write(StaticGameState.sci3);
        Console.Write(" ");
        Console.Write("will be held to determine the fate of a ");
        Console.Write("<bold>");
        Console.Write("University");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("in town in the spot where the Traveling Caravan resides. Success will be determined by our combined dedication to completing ");
        Console.Write(StaticGameState.sci3);
        Console.Write(" ");
        Console.Write("Experiments.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click here at the end of the round to attend the " + (string)StaticGameState.sci3 + " " + "Symposium.", passage34_Fragment_0);
        Console.Write("</hook>");
        Console.Write("</hubDetails>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage34_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.PrintEndOfTheRoundText("Hospital2", MethodSymposiumEvent1);
        optionsManager.PresentOptions();
    }


    private static void MethodHospital3()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("THRIVING IN ADVERSITY - Late Years");
        Console.Write("</bold>");
        Console.WriteLine();
        StaticGameState.round = 9;
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.uni == "yes" && StaticGameState.twopage == 0)
        {
            Console.Write("<setupStyle>");
            Console.Write("<bold>");
            Console.Write("SETUP");
            Console.Write("</bold>");
            StaticGameState._SetupImage = "VillageChronicleCover";
            Console.WriteLine();
            if (StaticGameState.building == "bank")
            {
                Console.Write("Turn to page ");
                Console.Write("<bold>");
                Console.Write("6");
                Console.Write("</bold>");
                Console.Write(" of the Village Chronicle.");
            }
            else
            {
                Console.Write("Turn to page ");
                Console.Write("<bold>");
                Console.Write("7");
                Console.Write("</bold>");
                Console.Write(" of the Village Chronicle.");
            }

            Console.Write("</setupStyle>");
            Console.WriteLine();
            Console.WriteLine();
        }

        Console.Write("<hubTitle>");
        Console.Write("<sprite=\"Storybook\" index=0>");
        Console.Write(" ");
        Console.Write("<bold>");
        Console.Write("Board of Trustees");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write("All players MUST place their Self on the Hospital space in town once this generation. ");
        Console.Write("<italic>");
        Console.Write("(If, for any reason, you have not visited the Hospital by the end of this Generation, lose 6VP and an Estate Upgrade of your choice, if possible.)");
        Console.Write("</italic>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("The <b>first time</b> you visit the Hospital with your Self, ");
        optionsManager.AddOption("HospitalVisitCheck", MethodHospitalVisitCheck);
        Console.Write("</hubDetails>");
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.cured == 0)
        {
            Console.Write("<hubTitle>");
            Console.Write("<sprite=\"Storybook\" index=0>");
            Console.Write("<bold>");
            Console.Write(" The Cure");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("Whenever a player completes the ");
            Console.Write("<bold>");
            Console.Write("Yellow Fever Inoculation ");
            Console.Write("</bold>");
            optionsManager.AddOption("YellowFeverCureSignin", MethodYellowFeverCureSignin);
            Console.Write("</hubDetails>");
        }

        if (StaticGameState.cured == 1)
        {
            Console.Write("<hubTitle>");
            Console.Write("<sprite=\"Storybook\" index=0>");
            Console.Write("<bold>");
            Console.Write(" The Panacea");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("Whenever a player completes the ");
            Console.Write("<bold>");
            Console.Write("Panacea ");
            Console.Write("</bold>");
            optionsManager.AddOption("Panacea", MethodPanacea);
            Console.Write("</hubDetails>");
        }

        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.trigger35 == 0)
        {
            Console.Write("<hubTitle>");
            Console.Write("<sprite=\"Storybook\" index=0>");
            Console.Write("<bold>");
            Console.Write(" Victory Ahead");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("If a player reaches or passes the Storybook token on space 35 of the Victory Point Track, ");
            optionsManager.AddOption("Trigger35Points", MethodTrigger35Points);
            Console.Write("</hubDetails>");
            Console.WriteLine();
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.sciadv == 0)
        {
            Console.Write("<hubTitle>");
            Console.Write("<sprite=\"Storybook\" index=0>");
            Console.Write("<bold>");
            Console.Write(" Scientific Advances");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("If a player completes a total of 3 B or C-Level ");
            Console.Write(StaticGameState.sci3);
            Console.Write(" Experiments this Generation, ");
            optionsManager.AddOption("Trigger3Experiments", MethodTrigger3Experiments);
            Console.Write("</hubDetails>");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<sprite=\"Storybook\" index=0>");
        Console.Write(" ");
        Console.Write("<bold>");
        Console.Write("The Secret");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write("If any player reaches the third level of research on the Journal Track with their Storybook token, ");
        optionsManager.AddOption("InfinityClick1", MethodInfinityClick1);
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click here at the end of the Generation to continue...", passage35_Fragment_0);
        Console.Write("</hook>");
        Console.Write("</hubDetails>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage35_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.PrintEndOfTheRoundText("Hospital3", MethodHospitalNegative);
        optionsManager.PresentOptions();
    }


    private static void MethodNoUni2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("THE CRAWL - Middle Years");
        Console.Write("</bold>");
        Console.WriteLine();
        StaticGameState.round = 17;
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<sprite=\"Storybook\" index=0>");
        Console.Write(" ");
        Console.Write("<bold>");
        Console.Write("PUB");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write("If your token is overtaken by the ");
        Console.Write("<sprite=\"AngryMob_Icon\" index=0>");
        Console.Write(", in addition to visiting the Church you can also visit any Pub. When you visit a Pub marked with a ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("and 0 symbol, ");
        Console.Write("<bold>");
        Console.Write("reset your ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("to zero");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("by buying a couple rounds at the Pub. Then, immediately ");
        optionsManager.AddOption("Barventures", MethodBarventures);
        Console.Write("</hubDetails>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<bold>");
        Console.Write("MASTERWORK");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write("A Masterwork can be completed by taking the Perform Experiment action and paying all of its costs.");
        Console.Write("</hubDetails>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<sprite=\"Storybook\" index=0>");
        Console.Write(" ");
        Console.Write("<bold>");
        Console.Write("Masterwork Recipe");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write("To check your Masterwork Cost, ");
        optionsManager.AddOption("MWTemp", MethodMWTemp);
        Console.Write("</hubDetails>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<sprite=\"Storybook\" index=0>");
        Console.Write(" ");
        Console.Write("<bold>");
        Console.Write("Completed Masterwork");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write("If you are completing a Masterwork, ");
        optionsManager.AddOption("MWCompleteName", MethodMWCompleteName);
        Console.Write("</hubDetails>");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<bold>");
        Console.Write("Knowledge");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write("At the end of each round, each player will ");
        Console.Write("<bold>");
        Console.Write("move one space forward on the ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("Track for each Knowledge cube in their Estate");
        Console.Write("</bold>");
        Console.Write(".");
        Console.Write("</hubDetails>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<sprite=\"Storybook\" index=0>");
        Console.Write(" ");
        Console.Write("<bold>");
        Console.Write("Second round Event");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write("<hook>");
        optionsManager.AddOption("Click here at the end of the second round for a special event.", passage36_Fragment_0);
        Console.Write("</hook>");
        Console.Write("</hubDetails>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage36_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.PrintEndOfTheRoundText("NoUni2", MethodroundEndKnowledge);
        optionsManager.PresentOptions();
    }


    private static void MethodNoUni3()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("THE CRAWL - Late Years");
        Console.Write("</bold>");
        Console.WriteLine();
        StaticGameState.round = 18;
        Console.WriteLine();
        if (StaticGameState.gen3pg == 0 || StaticGameState.gen3pg == "")
        {
            Console.Write("<setupStyle>");
            Console.Write("<bold>");
            Console.Write("SETUP");
            Console.Write("</bold>");
            StaticGameState._SetupImage = "Creepy_Icon";
            Console.WriteLine();
            Console.Write("Remove all ");
            Console.Write("<sprite=\"Creepy_Icon\" index=0>");
            Console.Write(" ");
            Console.Write("tokens from the board. Turn to page ");
            Console.Write("<bold>");
            Console.Write("9");
            Console.Write("</bold>");
            Console.Write(" ");
            Console.Write("of the Village Chronicle.");
            Console.Write("</setupStyle>");
        }

        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.peeps == 1)
        {
            Console.Write("<hubTitle>");
            Console.Write("<bold>");
            Console.Write("Like Us");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("The townspeople express regret for their actions and offer assistance in the family's endeavors.");
            Console.WriteLine();
            Console.WriteLine();
            StaticGameState.ending = MethodENDNoUniGood;
            Console.Write("Any player with a token that is not currently overtaken by the ");
            Console.Write("<sprite=\"AngryMob_Icon\" index=0>");
            Console.Write(" receives ");
            Console.Write("<bold>");
            Console.Write("one final Perform Experiment action");
            Console.Write("</bold>");
            Console.Write(" at the end of this round.");
            Console.Write("</hubDetails>");
        }

        if (StaticGameState.peeps == 0)
        {
            Console.Write("<hubTitle>");
            Console.Write("<bold>");
            Console.Write("A Step Forward");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("The townspeople begrudgingly accept the conveniences provided by access to electricity and while no apologies are offered, no further actions are taken as retribution.");
            Console.Write("</hubDetails>");
            Console.WriteLine();
            Console.WriteLine();
            StaticGameState.ending = MethodENDNoUniGood;
            Console.Write("<hubTitle>");
            Console.Write("<bold>");
            Console.Write("The Power of Electricity");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("During a ");
            Console.Write("<bold>");
            Console.Write("Perform Experiment");
            Console.Write("</bold>");
            Console.Write(" action, choose a type of Knowledge. ");
            Console.Write("<bold>");
            Console.Write("Ignore that Knowledge type when paying the costs of any B or C-Level Experiment. ");
            Console.Write("</bold>");
            Console.Write("<italic>");
            Console.Write("For example, if you choose Chemistry and an Experiment card has a 2 Chemistry cost, you pay 0 Chemistry to complete it.");
            Console.Write("</italic>");
            Console.Write("</hubDetails>");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<sprite=\"Storybook\" index=0>");
        Console.Write(" ");
        Console.Write("<bold>");
        Console.Write("PUB");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write("If your token is overtaken by the ");
        Console.Write("<sprite=\"AngryMob_Icon\" index=0>");
        Console.Write(", in addition to visiting the Church you can also visit any Pub. When you visit a Pub marked with a ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("and 0 symbol, ");
        Console.Write("<bold>");
        Console.Write("reset your ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("to zero");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("by buying a couple rounds at the Pub. Then, immediately ");
        optionsManager.AddOption("Barventures", MethodBarventures);
        Console.Write("</hubDetails>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<bold>");
        Console.Write("MASTERWORK");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write("A Masterwork can be completed by taking the Perform Experiment action and paying all of its costs.");
        Console.Write("</hubDetails>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<sprite=\"Storybook\" index=0>");
        Console.Write(" ");
        Console.Write("<bold>");
        Console.Write("Masterwork Recipe");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write("To check your Masterwork Cost, ");
        optionsManager.AddOption("MWTemp", MethodMWTemp);
        Console.Write("</hubDetails>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<sprite=\"Storybook\" index=0>");
        Console.Write(" ");
        Console.Write("<bold>");
        Console.Write("Completed Masterwork");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write("If you are completing a Masterwork, ");
        optionsManager.AddOption("MWCompleteName", MethodMWCompleteName);
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click here at the end of the Generation for Final Scoring and to Determine the Fate of the Town.", passage37_Fragment_0);
        Console.Write("</hook>");
        Console.Write("</hubDetails>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage37_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.peeps == 1)
        {
            StaticGameState.PrintEndOfTheRoundText("NoUni3", MethodNoUni3b);
        }
        else
        {
            StaticGameState.PrintEndOfTheRoundText("NoUni3", MethodScoring);
        }

        optionsManager.PresentOptions();
    }


    private static void MethodUniversity2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("SEARCH FOR THE CURE - Middle Years");
        Console.Write("</bold>");
        Console.WriteLine();
        StaticGameState.round = 20;
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hubTitle>");
        Console.Write("<bold>");
        Console.Write("The Ultimate Disease");
        Console.Write("</bold>");
        Console.Write("</hubTitle>");
        Console.WriteLine();
        Console.Write("<hubDetails>");
        Console.Write("At the end of this round, players will be given the opportunity to contribute 1 ");
        Console.Write("<bold>");
        Console.Write("Chemistry or Occult");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("Experiment to create and unleash a new disease upon the town.");
        Console.Write("</hubDetails>");
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
        optionsManager.AddOption("Click here at the end of the round for a special event.", passage38_Fragment_0);
        Console.Write("</hook>");
        Console.Write("</hubDetails>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage38_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.PrintEndOfTheRoundText("University2", MethodUniEvent2UltimateDisease);
        optionsManager.PresentOptions();
    }


    private static void MethodUniversity3()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("SEARCH FOR THE CURE - Late Years");
        Console.Write("</bold>");
        Console.WriteLine();
        StaticGameState.round = 21;
        Console.WriteLine();
        if (StaticGameState.ultimate == "yes")
        {
            Console.Write("<setupStyle>");
            Console.Write("<bold>");
            Console.Write("SETUP");
            Console.Write("</bold>");
            StaticGameState._SetupImage = "VillageChronicleCover";
            Console.WriteLine();
            Console.Write("Turn to page ");
            Console.Write("<bold>");
            Console.Write("11");
            Console.Write("</bold>");
            Console.Write("in the Village Chronicle.");
            Console.Write("</setupStyle>");
        }

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
        StaticGameState.ending = MethodENDUniGood;
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click here at the end of the Generation for Final Scoring and to Determine the Fate of the Town.", passage39_Fragment_0);
        Console.Write("</hook>");
        Console.Write("</hubDetails>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage39_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.PrintEndOfTheRoundText("University3", MethodSanityCheck);
        optionsManager.PresentOptions();
    }
    
    private static void MethodLibrary()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Library");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("Gain 1 Knowledge of your choice. ");
        Console.Write("<italic>");
        Console.Write("(Not Occult.)");
        Console.Write("</italic>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<italic>");
        Console.Write("If you place multiple pieces with this action, each Knowledge you gain may be of the same or a different type.");
        Console.Write("</italic>");
        optionsManager.PresentOptions();
    }


    private static void MethodGen1Church()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Charitable Church");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("Pay $0/1/2 to gain 1/2/3 ");
        Console.Write("<sprite=\"S1_HeartToken\" index=0>");
        Console.Write(" ");
        Console.Write("Heart tokens and move an equal number of spaces backwards on the ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("Track.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<italic>");
        Console.Write("For example: If you pay $1, you will gain 2 ");
        Console.Write("<sprite=\"S1_HeartToken\" index=0>");
        Console.Write(" ");
        Console.Write("Heart tokens and move 2 spaces backwards.");
        Console.Write("</italic>");
        optionsManager.PresentOptions();
    }
}