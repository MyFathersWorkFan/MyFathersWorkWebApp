namespace MyFathersWorkConsole;

public static partial class Scenario
{
    private static void MethodImmortality()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Overcoming Death");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write(
            "If not now, then when? The cousins pored over this question. How long would they remain relegated to an eccentric footnote murmured amongst the townspeople? Why must they toil in their most important labors under the cover of darkness and stone like vermin? A deep restlessness had set into the minds of each, and even on the cusp of approval from the academic community, they could not quell these thoughts.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("It was trivial to discuss meager experimentations when the solidification of such a poignant legacy repeated fruitlessly generation upon generation. If only time was no longer an obstacle.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "They vowed to accumulate a wealth of knowledge in their fields of expertise that far surpassed the pitiable ruminations of ancient scholars. Perhaps if they pushed forward into the unknown they would harness new and untold powers. Their evening conversations spurred them to devise a way to cheat the most sacred and inevitable truth of existence.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("For if life can be taken and altered by humanity into its most cruel and twisted form, surely that same spark could be endlessly preserved!");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click to continue...", passage89_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage89_Fragment_0()
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


    private static void MethodDeteriorationHub()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.round == 16)
        {
            MethodNoUni2();
        }
        else if (StaticGameState.round == 17)
        {
            MethodNoUni3();
        }
        else if (StaticGameState.round == 19)
        {
            MethodUniversity2();
        }
        else
        {
            MethodUniversity3();
        }

        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodDetEffect1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Major Deleterious Effect");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "It could not continue. Sick and unable to heal again, stumbling blindly until the bones were brittle enough to snap, their bodies had finally failed them. And when the mind had joined the fragile physical form in its inability to perform the most basic of functions, the struggle ceased.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Death in all its inevitability had finally claimed them.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Unfortunately, their body was in such an advanced state of degradation it could not even be used for further experimentation. This made the grief more substantial.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click to continue...", passage91_Fragment_1);
        Console.Write("</hook>");
        optionsManager.PresentOptions();
    }

    private static void passage91_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.det1 = "visited";
        StaticGameState.killed = "yes";
        MethodDeteriorationHub();
        optionsManager.PresentOptions();
    }

    private static void passage91_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.det1 = "visited";
        StaticGameState.killed = "yes";
        optionsManager.AddOption("Continue...", MethodDeteriorationHub);
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "S1_Immortality";
        Console.WriteLine();
        Console.Write("Any player with an ");
        Console.Write("<bold>");
        Console.Write("Immortality card");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("discards a ");
        Console.Write("<bold>");
        Console.Write("Caretaker");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("to Lost.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Discard all ");
        Console.Write("<bold>");
        Console.Write("Immortality cards");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("to the scenario box.");
        Console.Write("</setupStyleEvnt>");
        optionsManager.PresentOptions();
    }

    private static void passage91_Fragment_2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage91_Fragment_1);
        optionsManager.PresentOptions();
    }


    private static void MethodDetEffect2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Minor Deleterious Effect");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "They feared that their hasty solution had borne upon them irreversible effects. The interior withered, the skin grayed and sagged translucently against the sinewy veins beneath. The ultimate cure had become a curse and life was like a festering wound that cut deeper with each passing day. Still, they continued on in their work, hoping the effects were temporary but fearing the worst. It took more and more resources to quell their pain each day.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click to continue...", passage92_Fragment_1);
        Console.Write("</hook>");
        optionsManager.PresentOptions();
    }

    private static void passage92_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        MethodDeteriorationHub();
        optionsManager.PresentOptions();
    }

    private static void passage92_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.det2 = "visited";
        optionsManager.AddOption("Continue...", MethodDeteriorationHub);
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "S1_Immortality";
        Console.WriteLine();
        Console.Write("Any player with an ");
        Console.Write("<bold>");
        Console.Write("Immortality card");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("discards an ");
        Console.Write("<bold>");
        Console.Write("Ingredient");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("<italic>");
        Console.Write("if possible");
        Console.Write("</italic>");
        Console.Write(" ");
        Console.Write("and ");
        Console.Write("<bold>");
        Console.Write("draws a Compulsion");
        Console.Write("</bold>");
        Console.Write(".");
        Console.Write("</setupStyleEvnt>");
        optionsManager.PresentOptions();
    }

    private static void passage92_Fragment_2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage92_Fragment_1);
        optionsManager.PresentOptions();
    }


    private static void MethodDetEffect3()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Minor Deleterious Effect");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "All and all, the continued effects of their approach to Immortality had fared exceptionally well. While the skin displayed liver spots and an amount of vigor had been lost as the blood cooled with age, the effects were only a distraction. At most, a gangrenous finger had to be excised once every few years, but what was one extraneous extremity compared to the ability to assist in the most important scientific discoveries the world had ever known?");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click to continue...", passage93_Fragment_1);
        Console.Write("</hook>");
        optionsManager.PresentOptions();
    }

    private static void passage93_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        MethodDeteriorationHub();
        optionsManager.PresentOptions();
    }

    private static void passage93_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.det3 = "visited";
        optionsManager.AddOption("Continue...", MethodDeteriorationHub);
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "S1_Immortality";
        Console.WriteLine();
        Console.Write("Any player with an ");
        Console.Write("<bold>");
        Console.Write("Immortality card");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("loses ");
        Console.Write("<bold>");
        Console.Write(StaticGameState.GetRandom(new[]
        {
            1,
            2
        }));
        Console.Write("VP");
        Console.Write("</bold>");
        Console.Write(".");
        Console.Write("</setupStyleEvnt>");
        optionsManager.PresentOptions();
    }

    private static void passage93_Fragment_2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage93_Fragment_1);
        optionsManager.PresentOptions();
    }


    private static void MethodDetEffect4()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("No Effect");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "The unthinkable had been achieved. Whether by sheer providence or remarkable display of intellect, the solution to immortality appeared to have worked! In fact, the effects were so remarkable that many witness accounts of the day observed that the aging process appeared to have reversed. While still aged by all accounts, their individual treatise on Immortality appeared to have succeeded.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("At least, for now.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click to continue...", passage94_Fragment_0);
        Console.Write("</hook>");
        optionsManager.PresentOptions();
    }

    private static void passage94_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.det4 = "visited";
        MethodDeteriorationHub();
        optionsManager.PresentOptions();
    }


    private static void MethodInfinityClick2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("The ");
        Console.Write(StaticGameState.GetRandom(new[]
        {
            "Secret to",
            "Marvelous",
            "Discovering",
            "Forward to"
        }));
        Console.Write(" ");
        Console.Write("Infinity Journal Entry ");
        Console.Write(StaticGameState.tempinf);
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("There is no doubt in my ");
        Console.Write(StaticGameState.GetRandom(new[]
        {
            "immaculate brain",
            "inestimable mind"
        }));
        Console.Write(". With this research completed, ");
        Console.Write(StaticGameState.GetRandom(new[]
        {
            "I have surely unlocked a most flawless scheme to extend my existence indefinitely!",
            "the world will tremble at the mere utterance of my name."
        }));
        Console.Write(" ");
        Console.Write("The ravages of time will no longer have an effect on my work and I will be free to face the ");
        Console.Write(StaticGameState.GetRandom(new[]
        {
            "infinite",
            "future"
        }));
        Console.Write(" ");
        Console.Write("unimpeded by this mortal coil!");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click to continue...", passage95_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage95_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", MethodImmortalityMWUpdate);
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "S1_Immortality";
        Console.WriteLine();
        if (StaticGameState.setinf == 0)
        {
            Console.Write("Retrieve the ");
            Console.Write("<bold>");
            Console.Write("Immortality cards");
            Console.Write("</bold>");
            Console.Write(" from the scenario box. Shuffle them face down and place them nearby.");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Draw 2 Immortality cards. Look at both of them and choose one as your secret to Eternal Life. Discard the other.");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("Then, discard the ");
        Console.Write("<sprite=\"Storybook\" index=0>");
        Console.Write(" ");
        Console.Write("token to the supply.");
        Console.Write("</setupStyleEvnt>");
        optionsManager.PresentOptions();
    }

    private static void passage95_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage95_Fragment_0);
        optionsManager.PresentOptions();
    }


    private static void MethodInfinityClick1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Research Completed");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write(
            "It seemed unimaginable; not simply a cure for all disease, but a mysterious contrivance to extend life indefinitely. Perhaps, those that pursued this heretical course of action should not have postulated, \"could it be done?\" Instead, they might have asked themselves, \"but at what cost?\"");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Which player has completed the third level of their Journal's Research Track?");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Dr. " + (string)StaticGameState.nameA, passage96_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Dr. " + (string)StaticGameState.nameB, passage96_Fragment_1);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.players > 2)
        {
            Console.Write("<hook>");
            optionsManager.AddOption("Dr. " + (string)StaticGameState.nameC, passage96_Fragment_2);
            Console.Write("</hook>");
            Console.WriteLine();
            Console.WriteLine();
        }

        if (StaticGameState.players > 3)
        {
            Console.Write("<hook>");
            optionsManager.AddOption("Dr. " + (string)StaticGameState.nameD, passage96_Fragment_3);
            Console.Write("</hook>");
            Console.WriteLine();
            Console.WriteLine();
        }

        if (StaticGameState.players > 4)
        {
            Console.Write("<hook>");
            optionsManager.AddOption("Dr. " + (string)StaticGameState.nameE, passage96_Fragment_4);
            Console.Write("</hook>");
            Console.WriteLine();
        }

        optionsManager.PresentOptions();
    }

    private static void passage96_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.tempinf = StaticGameState.nameA;
        StaticGameState.lifeA = "yes";
        StaticGameState.life = StaticGameState.life + 1;
        MethodInfinityClick2();
        optionsManager.PresentOptions();
    }

    private static void passage96_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.tempinf = StaticGameState.nameB;
        StaticGameState.lifeB = "yes";
        StaticGameState.life = StaticGameState.life + 1;
        MethodInfinityClick2();
        optionsManager.PresentOptions();
    }

    private static void passage96_Fragment_2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.tempinf = StaticGameState.nameC;
        StaticGameState.lifeC = "yes";
        StaticGameState.life = StaticGameState.life + 1;
        MethodInfinityClick2();
        optionsManager.PresentOptions();
    }

    private static void passage96_Fragment_3()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.tempinf = StaticGameState.nameD;
        StaticGameState.lifeD = "yes";
        StaticGameState.life = StaticGameState.life + 1;
        MethodInfinityClick2();
        optionsManager.PresentOptions();
    }

    private static void passage96_Fragment_4()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.tempinf = StaticGameState.nameE;
        StaticGameState.lifeE = "yes";
        StaticGameState.life = StaticGameState.life + 1;
        MethodInfinityClick2();
        optionsManager.PresentOptions();
    }


    private static void MethodUniImmortal()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.life == 0)
        {
            MethodUniEquity();
        }
        else
        {
            Console.Write("<bold>");
            Console.Write("Immortality");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(
                "Claiming an inheritance whilst one's parent still lives on; this foreign concept was decidedly unnerving both for the returning youths and their unaware spouses. However, after the initial shock of encountering a surprisingly spry parent tending to the Estate, the additional help did prove useful.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("For those whose parents had chosen a more amenable fate, having no secrets to conceal caused less suspicion during interactions with the local populace.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hook>");
            optionsManager.AddOption("Click to continue...", passage97_Fragment_0);
            Console.Write("</hook>");
        }

        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage97_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", MethodUniEquity);
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "GainCaretakerFromLost";
        Console.WriteLine();
        if (StaticGameState.lifeA == "yes")
        {
            Console.Write(StaticGameState.nameA);
            Console.Write(" retrieves a Caretaker piece from lost.");
            Console.WriteLine();
        }

        if (StaticGameState.lifeB == "yes")
        {
            Console.Write(StaticGameState.nameB);
            Console.Write(" retrieves a Caretaker piece from lost.");
            Console.WriteLine();
        }

        if (StaticGameState.lifeC == "yes")
        {
            Console.Write(StaticGameState.nameC);
            Console.Write(" retrieves a Caretaker piece from lost.");
            Console.WriteLine();
        }

        if (StaticGameState.lifeD == "yes")
        {
            Console.Write(StaticGameState.nameD);
            Console.Write(" retrieves a Caretaker piece from lost.");
            Console.WriteLine();
        }

        if (StaticGameState.lifeE == "yes")
        {
            Console.Write(StaticGameState.nameE);
            Console.Write(" retrieves a Caretaker piece from lost.");
            Console.WriteLine();
        }

        if (StaticGameState.lifeA != "yes" && StaticGameState.lifeB != "yes" && StaticGameState.lifeC != "yes" && StaticGameState.lifeD != "yes" && StaticGameState.lifeE != "yes")
        {
            Console.Write(StaticGameState.nameA);
            Console.Write(" retrieves a Caretaker piece from lost.");
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.Write("Any player who did not receive a Caretaker for Immortality ");
        Console.Write("<bold>");
        Console.Write("Loses 2 ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("<italic>");
        Console.Write("(2 spaces to the left)");
        Console.Write("</italic>");
        Console.Write(" ");
        Console.Write("at the start of this Generation.");
        Console.Write("</setupStyleEvnt>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage97_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage97_Fragment_0);
        optionsManager.PresentOptions();
    }


    private static void MethodImmortalNoUni()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.life == 0)
        {
            MethodPanaceaUnleashCons1();
        }
        else
        {
            Console.Write("<bold>");
            Console.Write("Immortality");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write(
                "Claiming an inheritance whilst one's parent still lives on; this foreign concept was decidedly unnerving both for the returning youths and their unaware spouses. However, after the initial shock of encountering a surprisingly spry parent tending to the Estate, the additional help did prove useful.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("For those whose parents had chosen a more amenable fate, having no secrets to conceal caused less suspicion during interactions with the local populace.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hook>");
            optionsManager.AddOption("Click to continue...", passage98_Fragment_0);
            Console.Write("</hook>");
        }

        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage98_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", MethodPanaceaUnleashCons1);
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "Creepy_Icon";
        Console.WriteLine();
        if (StaticGameState.lifeA == "yes")
        {
            Console.Write(StaticGameState.nameA);
            Console.Write(" III retrieves a Caretaker from lost.");
            Console.WriteLine();
        }

        if (StaticGameState.lifeB == "yes")
        {
            Console.Write(StaticGameState.nameB);
            Console.Write(" III retrieves a Caretaker from lost.");
            Console.WriteLine();
        }

        if (StaticGameState.lifeC == "yes")
        {
            Console.Write(StaticGameState.nameC);
            Console.Write(" III retrieves a Caretaker from lost.");
            Console.WriteLine();
        }

        if (StaticGameState.lifeD == "yes")
        {
            Console.Write(StaticGameState.nameD);
            Console.Write(" III retrieves a Caretaker from lost.");
            Console.WriteLine();
        }

        if (StaticGameState.lifeE == "yes")
        {
            Console.Write(StaticGameState.nameE);
            Console.Write(" III retrieves a Caretaker from lost.");
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Any player who did not receive a Caretaker for Immortality ");
        Console.Write("<bold>");
        Console.Write("Loses 2 ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("<italic>");
        Console.Write("(2 spaces to the left)");
        Console.Write("</italic>");
        Console.Write(" ");
        Console.Write("at the start of this Generation.");
        Console.Write("</setupStyleEvnt>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage98_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage98_Fragment_0);
        optionsManager.PresentOptions();
    }


    private static void MethodS5HospA1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.S5HospA1nextPsg == "" || StaticGameState.S5HospA1nextPsg == 0)
        {
            if (StaticGameState.players == 2)
            {
                if (StaticGameState.life >= StaticGameState.GetRandom(new[]
                    {
                        1,
                        2
                    }))
                {
                    StaticGameState.S5HospA1nextPsg = "S5HospA1Yes";
                }
                else
                {
                    StaticGameState.S5HospA1nextPsg = "S5HospA1No";
                }
            }
            else if (StaticGameState.players == 3)
            {
                if (StaticGameState.life >= 2)
                {
                    StaticGameState.S5HospA1nextPsg = "S5HospA1Yes";
                }
                else
                {
                    StaticGameState.S5HospA1nextPsg = "S5HospA1No";
                }
            }
            else if (StaticGameState.players == 4)
            {
                if (StaticGameState.life >= StaticGameState.GetRandom(new[]
                    {
                        2,
                        3
                    }))
                {
                    StaticGameState.S5HospA1nextPsg = "S5HospA1Yes";
                }
                else
                {
                    StaticGameState.S5HospA1nextPsg = "S5HospA1No";
                }
            }
            else if (StaticGameState.players == 5)
            {
                if (StaticGameState.life >= StaticGameState.GetRandom(new[]
                    {
                        2,
                        3,
                        4
                    }))
                {
                    StaticGameState.S5HospA1nextPsg = "S5HospA1Yes";
                }
                else
                {
                    StaticGameState.S5HospA1nextPsg = "S5HospA1No";
                }
            }
            else
            {
                StaticGameState.S5HospA1nextPsg = "S5HospA1No";
            }
        }

        if (StaticGameState.S5HospA1nextPsg == "S5HospA1Yes") MethodS5HospA1Yes();
        else MethodS5HospA1No();
        optionsManager.PresentOptions();
    }


    private static void MethodS5HospA1No()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Death Becomes Us");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine("END OF GENERATION SETUP" + "Remove all player pieces from the board and perform the End of a Generation. Any <sprite=\"StorybookToken\" index=0> tokens remaining on a player's Journal Track are returned to the supply.");
        Console.WriteLine();
        Console.Write("As their bodies withered with time, the failures of their equally outdated scientific pursuits weighed heavily on their deteriorating minds. With only ");
        Console.Write("<bold>");
        Console.Write(StaticGameState.life);
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("of them discovering the way towards ");
        Console.Write("<bold>");
        Console.Write("immortality");
        Console.Write("</bold>");
        Console.Write(", the cousins wallowed in their own ineptitude.");
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.uni == "yes")
        {
            Console.Write("With no further push from its energetic benefactors, the university was shunned, abandoned, and refitted.");
            Console.Write(" ");
        }

        Console.Write("With no sounds of screams and explosions echoing down from the hillsides, the townsfolk lost their sense of purpose. A thick fog of ignorance fell across the populace as they returned to the old ways with a righteous fervor.");
        Console.WriteLine();
        Console.WriteLine();
        optionsManager.AddOption("RippedMasterwork", MethodRippedMasterwork);
        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodDevEventCure()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("An Alternative Cure");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("An envoy from the ");
        if (StaticGameState.wolves == "evil")
        {
            Console.Write("<bold>");
            Console.Write("Order of St. Hubertus");
            Console.Write("</bold>");
        }

        if (StaticGameState.hunters == "evil")
        {
            Console.Write("<bold>");
            Console.Write("Fraternity of Hunters");
            Console.Write("</bold>");
        }

        Console.Write(" ");
        Console.Write("arrived bearing an interesting narrative and a shimmering tincture of liquid. She visited each of the manors in turn unable to conceal her wicked grin and laughter as she did so.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "\"The brotherhood has heard of your suffering and we wish to offer an exchange. For a meager bit of knowledge, we present a cure. Drink of this liquid and your dreaded affliction will cease,\" she said as a bolt of lightning arced across the sky above.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click to continue...", passage101_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage101_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", MethodDiseases2);
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "ExperimentBBack";
        Console.WriteLine();
        Console.Write("Each player, in turn order, may choose to discard a completed B-Level Experiment ");
        Console.Write("<italic>");
        Console.Write("(to the bottom of the deck)");
        Console.Write("</italic>");
        Console.Write(" ");
        Console.Write("to place their ");
        Console.Write("<bold>");
        Console.Write("Hereditary Disease Experiment");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("into their ");
        Console.Write("<bold>");
        Console.Write("Stored Experiments");
        Console.Write("</bold>");
        Console.Write(". <i>They will no longer be affected by Disease events.</i>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Any player that has already completed their <b>Hereditary Disease Experiment</b> cannot choose this action.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Continue once all players have made their decision.");
        Console.Write("</setupStyleEvnt>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage101_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("click here to continue...", passage101_Fragment_0);
        optionsManager.PresentOptions();
    }


    private static void MethodEnvPasscode()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.WriteLine("Enter the secret password on your envelope.");
        StaticGameState.password = Console.ReadLine()!;
        MethodPasscodechk();
        Console.WriteLine();
        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodHubertusWolves2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.meet == 0 || StaticGameState.meet == "")
        {
            MethodFailedMeeting();
        }

        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Carefully pick up the storybook and do not allow any other players to see the screen.");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click to continue...", passage103_Fragment_1);
        Console.Write("</hook>");
        optionsManager.PresentOptions();
    }

    private static void passage103_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
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

        MethodHubertusConfirmation();
        optionsManager.PresentOptions();
    }

    private static void passage103_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Upon a Secret Meeting - Letter - ");
        Console.Write(StaticGameState.GetRandom(new[]
        {
            "April",
            "August",
            "October"
        }));
        Console.Write(" ");
        Console.Write(new Random().Next(1, 29 + 1));
        Console.Write(", 1865");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("I, ");
        Console.Write(StaticGameState.meet);
        Console.Write(", am writing this letter to you after my meeting with an associate of the International Order of St. Hubertus. Our conversation was brief, but the resulting knowledge has piqued my curiosities.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("It has been revealed to me that your intentions are ");
        if (StaticGameState.wolves == "evil")
        {
            Console.Write(
                "nefarious. The malevolent Order is consumed with greed, seeking to unearth the ancient secrets in this area and use this power to alter humanity and spread a plague of monstrous entities across the world. You only asked for your work to remain ");
            Console.Write("<bold>");
            Console.Write("concealed");
            Console.Write("</bold>");
            Console.Write(".");
        }
        else if (StaticGameState.wolves == "good")
        {
            Console.Write(
                "demonstrably positive. The Order is only concerned with establishing a safe haven for those afflicted by disease. Your representative even revealed a physical peculiarity that had elongated her cuspids into sharp points. She left swiftly before nightfall, ignoring my pleas for her to remain, but she urged me to ");
            Console.Write("<bold>");
            Console.Write("investigate");
            Console.Write("</bold>");
            Console.Write(" the secret workings soon to become apparent.");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Being intimately familiar with matters of the occult, this admission is unsurprising. My apprehensions are only related to how your actions will impact my ability to advance my scientific studies most generously.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("It is with sincerity that I:");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("...have decided to ");
        Console.Write("<hook>");
        optionsManager.AddOption("join and pledge my service to your cause.", passage103_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("...have decided to ");
        optionsManager.AddOption("RefusalWolves", MethodRefusalWolves);
        optionsManager.PresentOptions();
    }

    private static void passage103_Fragment_2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Once you are ready", passage103_Fragment_1);
        optionsManager.PresentOptions();
    }


    private static void MethodDiseases1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.disease1 = StaticGameState.GetRandom(new[]
        {
            1,
            2
        });
        if (StaticGameState.disease1 == 1)
        {
            Console.Write("<bold>");
            Console.Write("A Year of Sickness");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("Even the most agile mind cannot willingly escape the frailness of the human form. As such, the foul plague upon the household syphoned a considerable energy from their work and left them bed-ridden for months on end. ");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hook>");
            optionsManager.AddOption("Click to continue...", passage104_Fragment_0);
            Console.Write("</hook>");
        }

        if (StaticGameState.disease1 == 2)
        {
            Console.Write("<bold>");
            Console.Write("Rest and Time");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write(
                "It seemed that the cousins were fortunate in their early years. Even the most agile mind cannot willingly escape the frailness of the human form. However, with a strict regimen of rest, diet, and bloodletting, these deficiencies could mostly be nullified.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hook>");
            optionsManager.AddOption("Click to continue...", passage104_Fragment_2);
            Console.Write("</hook>");
        }

        Console.WriteLine();
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage104_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", ((StaticGameState.seedy == "no") ? MethodGen1CreepyRefusalBuild : MethodDevastation2));
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "S1_DiseaseExperiment";
        Console.WriteLine();
        Console.Write("All players that have not completed the ");
        Console.Write("<bold>");
        Console.Write("Hereditary Disease Experiment");
        Console.Write("</bold>");
        Console.Write(" must ");
        Console.Write("<bold>");
        Console.Write("discard a Knowledge cube to the supply");
        Console.Write("</bold>");
        Console.Write(" or ");
        Console.Write("<bold>");
        Console.Write("lose 2VP");
        Console.Write("</bold>");
        Console.Write(".");
        Console.Write("</setupStyleEvnt>");
        optionsManager.PresentOptions();
    }

    private static void passage104_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage104_Fragment_0);
        optionsManager.PresentOptions();
    }

    private static void passage104_Fragment_2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", ((StaticGameState.seedy == "no") ? MethodGen1CreepyRefusalBuild : MethodDevastation2));
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "S1_DiseaseExperiment";
        Console.WriteLine();
        Console.Write("The Hereditary disease has no effect.");
        Console.Write("</setupStyleEvnt>");
        optionsManager.PresentOptions();
    }

    private static void passage104_Fragment_3()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage104_Fragment_2);
        optionsManager.PresentOptions();
    }


    private static void MethodHubertusWolves3()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.meet == 0 || StaticGameState.meet == "")
        {
            MethodFailedMeeting();
        }

        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Carefully pick up the storybook and do not allow any other players to see the screen.");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Once you are ready", passage105_Fragment_1);
        Console.Write("</hook>");
        optionsManager.PresentOptions();
    }

    private static void passage105_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
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

        MethodHubertusConfirmation();
        optionsManager.PresentOptions();
    }

    private static void passage105_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Upon a Secret Meeting - Letter - ");
        Console.Write(StaticGameState.GetRandom(new[]
        {
            "April",
            "August",
            "October"
        }));
        Console.Write(" ");
        Console.Write(new Random().Next(1, 29 + 1));
        Console.Write(", 1865");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("I, ");
        Console.Write(StaticGameState.meet);
        Console.Write(", am writing this letter to you after my meeting with an associate of the International Order of St. Hubertus. Our conversation was brief, but the resulting knowledge has piqued my curiosities.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("It has been revealed to me that your intentions are ");
        if (StaticGameState.wolves == "evil")
        {
            Console.Write(
                "nefarious. The malevolent Order is consumed with greed, seeking to unearth the ancient secrets in this area and use this power to alter humanity and spread a plague of monstrous entities across the world. You only asked for your work to remain ");
            Console.Write("<bold>");
            Console.Write("concealed");
            Console.Write("</bold>");
            Console.Write(".");
        }
        else
        {
            Console.Write(
                "demonstrably positive. The Order is only concerned with establishing a safe haven for those afflicted by disease. Your representative even revealed a physical peculiarity that had elongated her cuspids into sharp points. She left swiftly before nightfall, ignoring my pleas for her to remain, but she urged me to ");
            Console.Write("<bold>");
            Console.Write("investigate");
            Console.Write("</bold>");
            Console.Write(" the secret workings soon to become apparent.");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Being intimately familiar with matters of the occult, this admission is unsurprising. My apprehensions are only related to how your actions will impact my ability to advance my scientific studies most generously.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("It is with sincerity that I:");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("...have decided to ");
        Console.Write("<hook>");
        optionsManager.AddOption("join and pledge my service to your cause.", passage105_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("...have decided to ");
        optionsManager.AddOption("RefusalWolves", MethodRefusalWolves);
        optionsManager.PresentOptions();
    }

    private static void passage105_Fragment_2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Once you are ready", passage105_Fragment_1);
        optionsManager.PresentOptions();
    }


    private static void MethodHubertusHunters1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.meet == 0 || StaticGameState.meet == "")
        {
            MethodFailedMeeting();
        }

        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Carefully pick up the storybook and do not allow any other players to see the screen.");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Once you are ready", passage106_Fragment_1);
        Console.Write("</hook>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage106_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.meet == StaticGameState.nameA)
        {
            StaticGameState.allyA = "hunters";
        }

        if (StaticGameState.meet == StaticGameState.nameB)
        {
            StaticGameState.allyB = "hunters";
        }

        if (StaticGameState.meet == StaticGameState.nameC)
        {
            StaticGameState.allyC = "hunters";
        }

        if (StaticGameState.meet == StaticGameState.nameD)
        {
            StaticGameState.allyD = "hunters";
        }

        if (StaticGameState.meet == StaticGameState.nameE)
        {
            StaticGameState.allyE = "hunters";
        }

        MethodHuntersConfirmation();
        optionsManager.PresentOptions();
    }

    private static void passage106_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Upon a Secret Meeting - Letter - ");
        Console.Write(StaticGameState.GetRandom(new[]
        {
            "April",
            "August",
            "October"
        }));
        Console.Write(" ");
        Console.Write(new Random().Next(1, 29 + 1));
        Console.Write(", 1865");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("I, ");
        Console.Write(StaticGameState.meet);
        Console.Write(", am writing this letter to you after my meeting with an associate of the International Fraternity of Hunters. Our secret conversation over brunch was quite revealing, and the resulting knowledge has piqued my interests.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("It has been revealed to me that your intentions are ");
        if (StaticGameState.hunters == "evil")
        {
            Console.Write(
                "amusingly exploitative. The Fraternity hopes to use the recent epidemic as a cover for their activities to unearth ancient supernatural secrets in the region and use them for monetary and political gain. Although I remain skeptical, if these labors are successful, I will be deeply interested in the results. You only asked for your work to remain ");
            Console.Write("<bold>");
            Console.Write("concealed");
            Console.Write("</bold>");
            Console.Write(".");
        }
        else
        {
            Console.Write(
                "good. It was astute for you to note how oddly silent the town has remained over the last few years. Keeping a watchful eye over the proceedings, the Fraternity appears only concerned with rooting out who or what is behind this veil of secrecy. You've urged me to ");
            Console.Write("<bold>");
            Console.Write("investigate");
            Console.Write("</bold>");
            Console.Write(" the secret workings soon to become apparent.");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Being an entrepreneur myself, in a fashion, these goals are not so misaligned with my own. My apprehensions are only related to how your actions will impact my ability to advance my scientific studies most generously.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("It is with sincerity that I:");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("...have decided to ");
        Console.Write("<hook>");
        optionsManager.AddOption("join and pledge my service to your cause.", passage106_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("...have decided to ");
        optionsManager.AddOption("RefusalHunters", MethodRefusalHunters);
        optionsManager.PresentOptions();
    }

    private static void passage106_Fragment_2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Once you are ready", passage106_Fragment_1);
        optionsManager.PresentOptions();
    }


    private static void MethodDevastationFate1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Strong Alliance");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine("END OF GENERATION SETUP" + "Remove all player pieces from the board and Perform the End of a Generation. Return any remaining <sprite=\"StorybookToken\" index=0> tokens to the supply.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("The ties that bound the family to these secret warring factions changed the course of history.");
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.society == "Fraternity of Hunters")
        {
            if (StaticGameState.hunters == "evil")
            {
                Console.Write("While secrets could not forever be kept, the silent assistance of ");
                Console.Write(StaticGameState.playtxt);
                Console.Write(" influential members of the upper crust ensured that the ");
                Console.Write("<bold>");
                Console.Write("Hunters");
                Console.Write("</bold>");
                Console.Write(" could progress in their endeavors long enough to make their presence integral to the town. For a price, they swore to protect all citizens from the disease and darkness that had enveloped the countryside.");
                Console.WriteLine();
                Console.WriteLine();
                optionsManager.AddOption("HelpingEvil", MethodHelpingEvil);
            }
            else
            {
                Console.Write("By exposing the nefarious work of the ");
                Console.Write("<bold>");
                Console.Write("Order of St. Hubertus,");
                Console.Write("</bold>");
                Console.Write(" the additional attention forced them to leave the region. Motivated by the promise of swift justice, the ");
                Console.Write("<bold>");
                Console.Write("Fraternity of Hunters");
                Console.Write("</bold>");
                Console.Write(" created a stronghold in the town. They swore at all costs to protect the town from the evils that roamed the land.");
                Console.WriteLine();
                Console.WriteLine();
                optionsManager.AddOption("ProsperityHunterIntro", MethodProsperityHunterIntro);
            }
        }
        else if (StaticGameState.wolves == "evil")
        {
            Console.Write("While secrets could not forever be kept, the silent assistance of ");
            Console.Write(StaticGameState.playtxt);
            Console.Write(" influential members of the upper crust ensured that the ");
            Console.Write("<bold>");
            Console.Write("Order");
            Console.Write("</bold>");
            Console.Write(" could progress in their endeavors long enough to make their presence integral to the town. They immediately began to advance their schemes.");
            Console.WriteLine();
            Console.WriteLine();
            optionsManager.AddOption("HelpingEvil", MethodHelpingEvil);
        }
        else
        {
            Console.Write("By exposing the insidious deeds of the ");
            Console.Write("<bold>");
            Console.Write("Fraternity of Hunters,");
            Console.Write("</bold>");
            Console.Write(" the additional attention forced them to quit the region. Motivated by the promise of swift justice, the ");
            Console.Write("<bold>");
            Console.Write("Order of St. Hubertus");
            Console.Write("</bold>");
            Console.Write(" created a stronghold in the town. They swore to provide a haven for all outcasts.");
            Console.WriteLine();
            Console.WriteLine();
            optionsManager.AddOption("ProsperityWolvesIntro", MethodProsperityWolvesIntro);
        }

        optionsManager.PresentOptions();
    }


    private static void MethodHubertusHunters2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.meet == 0 || StaticGameState.meet == "")
        {
            MethodFailedMeeting();
        }

        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Carefully pick up the storybook and do not allow any other players to see the screen.");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Once you are ready", passage108_Fragment_1);
        Console.Write("</hook>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage108_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.meet == StaticGameState.nameA)
        {
            StaticGameState.allyA = "hunters";
        }

        if (StaticGameState.meet == StaticGameState.nameB)
        {
            StaticGameState.allyB = "hunters";
        }

        if (StaticGameState.meet == StaticGameState.nameC)
        {
            StaticGameState.allyC = "hunters";
        }

        if (StaticGameState.meet == StaticGameState.nameD)
        {
            StaticGameState.allyD = "hunters";
        }

        if (StaticGameState.meet == StaticGameState.nameE)
        {
            StaticGameState.allyE = "hunters";
        }

        MethodHuntersConfirmation();
        optionsManager.PresentOptions();
    }

    private static void passage108_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Upon a Secret Meeting - Letter - ");
        Console.Write(StaticGameState.GetRandom(new[]
        {
            "April",
            "August",
            "October"
        }));
        Console.Write(" ");
        Console.Write(new Random().Next(1, 29 + 1));
        Console.Write(", 1865");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("I, ");
        Console.Write(StaticGameState.meet);
        Console.Write(", am writing this letter to you after my meeting with an associate of the International Fraternity of Hunters. Our secret conversation over brunch was quite revealing, and the resulting knowledge has piqued my interests.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("It has been revealed to me that your intentions are ");
        if (StaticGameState.hunters == "evil")
        {
            Console.Write(
                "amusingly exploitative. The Fraternity hopes to use the recent epidemic as a cover for their activities to unearth ancient, supernatural secrets in the region and use them for monetary and political gain. Although I remain skeptical, if these labors are successful, I will be deeply interested in the results. You only asked for your work to remain ");
            Console.Write("<bold>");
            Console.Write("concealed");
            Console.Write("</bold>");
            Console.Write(".");
        }
        else
        {
            Console.Write(
                "good. It was astute for you to note how oddly silent the town has remained over the last few years. Keeping a watchful eye over the proceedings, the Fraternity appears only concerned with rooting out who or what is behind this veil of secrecy. You've urged me to ");
            Console.Write("<bold>");
            Console.Write("investigate");
            Console.Write("</bold>");
            Console.Write(" the secret workings soon to become apparent.");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Being an entrepreneur myself, in a fashion, these goals are not so misaligned with my own. My apprehensions are only related to how your actions will impact my ability to advance my scientific studies most generously.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("It is with sincerity that I:");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("...have decided to ");
        Console.Write("<hook>");
        optionsManager.AddOption("join and pledge my service to your cause.", passage108_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("...have decided to ");
        optionsManager.AddOption("RefusalHunters", MethodRefusalHunters);
        optionsManager.PresentOptions();
    }

    private static void passage108_Fragment_2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Once you are ready", passage108_Fragment_1);
        optionsManager.PresentOptions();
    }


    private static void MethodHubertusHunters3()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.meet == 0 || StaticGameState.meet == "")
        {
            MethodFailedMeeting();
        }

        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Carefully pick up the storybook and do not allow any other players to see the screen.");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Once you are ready", passage109_Fragment_1);
        Console.Write("</hook>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage109_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.meet == StaticGameState.nameA)
        {
            StaticGameState.allyA = "hunters";
        }

        if (StaticGameState.meet == StaticGameState.nameB)
        {
            StaticGameState.allyB = "hunters";
        }

        if (StaticGameState.meet == StaticGameState.nameC)
        {
            StaticGameState.allyC = "hunters";
        }

        if (StaticGameState.meet == StaticGameState.nameD)
        {
            StaticGameState.allyD = "hunters";
        }

        if (StaticGameState.meet == StaticGameState.nameE)
        {
            StaticGameState.allyE = "hunters";
        }

        MethodHuntersConfirmation();
        optionsManager.PresentOptions();
    }

    private static void passage109_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Upon a Secret Meeting - Letter - ");
        Console.Write(StaticGameState.GetRandom(new[]
        {
            "April",
            "August",
            "October"
        }));
        Console.Write(" ");
        Console.Write(new Random().Next(1, 29 + 1));
        Console.Write(", 1865");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("I, ");
        Console.Write(StaticGameState.meet);
        Console.Write(", am writing this letter to you after my meeting with an associate of the International Fraternity of Hunters. Our secret conversation over brunch was quite revealing, and the resulting knowledge has piqued my interests.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("It has been revealed to me that your intentions are ");
        if (StaticGameState.hunters == "evil")
        {
            Console.Write(
                "amusingly exploitative. The Fraternity hopes to use the recent epidemic as a cover for their activities to unearth ancient, supernatural secrets in the region and use them for monetary and political gain. Although I remain skeptical, if these labors are successful, I will be deeply interested in the results. You only asked for your work to remain ");
            Console.Write("<bold>");
            Console.Write("concealed");
            Console.Write("</bold>");
            Console.Write(".");
        }
        else
        {
            Console.Write(
                "good. It was astute for you to note how oddly silent the town has remained over the last few years. Keeping a watchful eye over the proceedings, the Fraternity appears only concerned with rooting out who or what is behind this veil of secrecy. You've urged me to ");
            Console.Write("<bold>");
            Console.Write("investigate");
            Console.Write("</bold>");
            Console.Write(" the secret workings soon to become apparent.");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Being an entrepreneur myself, in a fashion, these goals are not so misaligned with my own. My apprehensions are only related to how your actions will impact my ability to advance my scientific studies most generously.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("It is with sincerity that I:");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("...have decided to ");
        Console.Write("<hook>");
        optionsManager.AddOption("join and pledge my service to your cause.", passage109_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("...have decided to ");
        optionsManager.AddOption("RefusalHunters", MethodRefusalHunters);
        optionsManager.PresentOptions();
    }

    private static void passage109_Fragment_2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Once you are ready", passage109_Fragment_1);
        optionsManager.PresentOptions();
    }


    private static void MethodPasscodechk()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.password == "alpha")
        {
            StaticGameState.meet = StaticGameState.let1;
            MethodHubertusWolves1();
        }
        else if (StaticGameState.password == "moon")
        {
            StaticGameState.meet = StaticGameState.let2;
            MethodHubertusWolves2();
        }
        else if (StaticGameState.password == "howl")
        {
            StaticGameState.meet = StaticGameState.let3;
            MethodHubertusWolves3();
        }
        else if (StaticGameState.password == "right")
        {
            StaticGameState.meet = StaticGameState.let4;
            MethodHubertusHunters1();
        }
        else if (StaticGameState.password == "cross")
        {
            StaticGameState.meet = StaticGameState.let5;
            MethodHubertusHunters2();
        }
        else if (StaticGameState.password == "bolt")
        {
            StaticGameState.meet = StaticGameState.let6;
            MethodHubertusHunters3();
        }
        else if (StaticGameState.password == "Alpha")
        {
            StaticGameState.meet = StaticGameState.let1;
            MethodHubertusWolves1();
        }
        else if (StaticGameState.password == "Moon")
        {
            StaticGameState.meet = StaticGameState.let2;
            MethodHubertusWolves2();
        }
        else if (StaticGameState.password == "Howl")
        {
            StaticGameState.meet = StaticGameState.let3;
            MethodHubertusWolves3();
        }
        else if (StaticGameState.password == "Right")
        {
            StaticGameState.meet = StaticGameState.let4;
            MethodHubertusHunters1();
        }
        else if (StaticGameState.password == "Cross")
        {
            StaticGameState.meet = StaticGameState.let5;
            MethodHubertusHunters2();
        }
        else if (StaticGameState.password == "Bolt")
        {
            StaticGameState.meet = StaticGameState.let6;
            MethodHubertusHunters3();
        }
        else
        {
            MethodFailedMeeting();
        }

        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodBuildingSignin()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Investigation");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write(
            "After visiting the establishment, the peculiar attitude of the workers and the pristine furnishings further piqued their curiosity. Several days later, they decided to forgo their scientific obligations for one evening and investigate the ");
        Console.Write(StaticGameState.inv);
        Console.Write(".");
        Console.WriteLine();
        StaticGameState.devpage = 1;
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Please choose which player is making this investigation:");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption((string)StaticGameState.nameA, passage111_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption((string)StaticGameState.nameB, passage111_Fragment_1);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.players > 2)
        {
            Console.Write("<hook>");
            optionsManager.AddOption((string)StaticGameState.nameC, passage111_Fragment_2);
            Console.Write("</hook>");
        }

        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.players > 3)
        {
            Console.Write("<hook>");
            optionsManager.AddOption((string)StaticGameState.nameD, passage111_Fragment_3);
            Console.Write("</hook>");
        }

        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.players > 4)
        {
            Console.Write("<hook>");
            optionsManager.AddOption((string)StaticGameState.nameE, passage111_Fragment_4);
            Console.Write("</hook>");
        }

        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage111_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        MethodBuildplayA();
        optionsManager.PresentOptions();
    }

    private static void passage111_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        MethodBuildplayB();
        optionsManager.PresentOptions();
    }

    private static void passage111_Fragment_2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        MethodBuildplayC();
        optionsManager.PresentOptions();
    }

    private static void passage111_Fragment_3()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        MethodBuildplayD();
        optionsManager.PresentOptions();
    }

    private static void passage111_Fragment_4()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        MethodBuildplayE();
        optionsManager.PresentOptions();
    }


    private static void MethodBuildplayA()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Do not allow the other players to see the Storybook while making the decision below.");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Continuing Investigation - Compiled Journal Entries of ");
        Console.Write(StaticGameState.nameA);
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.inv == StaticGameState.ba)
        {
            Console.Write("I arrived at the ");
            Console.Write(StaticGameState.ba);
            Console.Write(" under cover of darkness. I was ill-suited for such stealthy missions, but I kept my cloak and collar about my neck to conceal my identity in case I was discovered.");
        }
        else if (StaticGameState.inv == StaticGameState.bb)
        {
            Console.Write("A thick fog shrouded my approach on the cool night that I chose to investigate the ");
            Console.Write(StaticGameState.bb);
            Console.Write(". I asked the carriage driver to await my return on the outskirts of town, while I stole away into the empty streets. Nary a soul was about on this evening, and I was soon inside without arousing suspicion.");
        }
        else
        {
            Console.Write("To my chagrin, a ");
            Console.Write(StaticGameState.GetRandom(new[]
            {
                "gentleman",
                "gentlewoman"
            }));
            Console.Write(
                " stood near the front door of the building. At this late hour, I could only assume that they were standing guard. Not to be thwarted so easily, I tilted my hat to obscure my face and stalked into the alley behind. The lock on the rear door was a trifle for my tools, and I entered without a sound.");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("I could either provide evidence to help ");
        Console.Write("<bold>");
        Console.Write("expose");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("the secret inner workings of the building or I could ");
        Console.Write("<bold>");
        Console.Write("conceal");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("the truth and allow the work to continue. ");
        Console.Write("<bold>");
        Console.Write("The decision was clear to me:");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        StaticGameState.playA = int.Parse(StaticGameState.playA) + 1;
        Console.Write("<hook>");
        optionsManager.AddOption("I exposed the truth.", passage112_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("I concealed the true purpose.", passage112_Fragment_1);
        Console.Write("</hook>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage112_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.inv == StaticGameState.ba)
        {
            StaticGameState.pAA = "yes";
            StaticGameState.exposeA = int.Parse(StaticGameState.exposeA) + 1;
        }

        if (StaticGameState.inv == StaticGameState.bb)
        {
            StaticGameState.pAB = "yes";
            StaticGameState.exposeB = int.Parse(StaticGameState.exposeB) + 1;
        }

        if (StaticGameState.inv == StaticGameState.bc)
        {
            StaticGameState.pAC = "yes";
            StaticGameState.exposeC = int.Parse(StaticGameState.exposeC) + 1;
        }

        MethodExposeConfirmation();
        optionsManager.PresentOptions();
    }

    private static void passage112_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.inv == StaticGameState.ba)
        {
            StaticGameState.exposeA = int.Parse(StaticGameState.exposeA) - 1;
        }

        if (StaticGameState.inv == StaticGameState.bb)
        {
            StaticGameState.exposeB = int.Parse(StaticGameState.exposeB) - 1;
        }

        if (StaticGameState.inv == StaticGameState.bc)
        {
            StaticGameState.exposeC = int.Parse(StaticGameState.exposeC) - 1;
        }

        MethodConcealConfirmation();
        optionsManager.PresentOptions();
    }


    private static void MethodExposeConfirmation()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Exposed");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("I knew it was the correct decision. To allow this terrible work to continue unabated would not align with my own crucial endeavors. But, would my cousins feel the same way?");
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.round == 5)
        {
            optionsManager.AddOption("Devastation2", MethodDevastation2);
        }
        else
        {
            optionsManager.AddOption("Devastation3", MethodDevastation3);
        }

        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodConcealConfirmation()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Concealed");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("Knowledge may have been my main pursuit when investigating the suspicious building, but now with a complete understanding of the devious machinations inside, I decided to err on the side of secrecy. But would this be enough?");
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.round == 5)
        {
            optionsManager.AddOption("Devastation2", MethodDevastation2);
        }
        else
        {
            optionsManager.AddOption("Devastation3", MethodDevastation3);
        }

        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodBuildplayB()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Do not allow the other player's to see the Storybook while making the decision below.");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Continuing Investigation - Compiled Journal Entries of ");
        Console.Write(StaticGameState.nameB);
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.inv == StaticGameState.ba)
        {
            Console.Write("I arrived at the ");
            Console.Write(StaticGameState.ba);
            Console.Write(" under cover of darkness. I was ill-suited for such stealthy missions, but I kept my cloak and collar about my neck to conceal my identity in case I was discovered.");
        }
        else if (StaticGameState.inv == StaticGameState.bb)
        {
            Console.Write("A thick fog shrouded my approach on the cool night that I chose to investigate the ");
            Console.Write(StaticGameState.bb);
            Console.Write(". I asked the carriage driver to await my return on the outskirts of town, while I stole away into the empty streets. Nary a soul was about on this evening, and I was soon inside without arousing suspicion.");
        }
        else
        {
            Console.Write("To my chagrin, a ");
            Console.Write(StaticGameState.GetRandom(new[]
            {
                "gentleman",
                "gentlewoman"
            }));
            Console.Write(
                " stood near the front door of the building. At this late hour, I could only assume that they were standing guard. Not to be thwarted so easily, I tilted my hat to obscure my face and stalked into the alley behind. The lock on the rear door was a trifle for my tools, and I entered without a sound.");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("I could either provide evidence to help ");
        Console.Write("<bold>");
        Console.Write("expose");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("the secret inner workings of the building or I could ");
        Console.Write("<bold>");
        Console.Write("conceal");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("the truth and allow the work to continue. ");
        Console.Write("<bold>");
        Console.Write("The decision was clear to me:");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        StaticGameState.playB = int.Parse(StaticGameState.playB) + 1;
        Console.Write("<hook>");
        optionsManager.AddOption("I exposed the truth.", passage115_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("I concealed the true purpose.", passage115_Fragment_1);
        Console.Write("</hook>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage115_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.inv == StaticGameState.ba)
        {
            StaticGameState.pBA = "yes";
            StaticGameState.exposeA = int.Parse(StaticGameState.exposeA) + 1;
        }

        if (StaticGameState.inv == StaticGameState.bb)
        {
            StaticGameState.pBB = "yes";
            StaticGameState.exposeB = int.Parse(StaticGameState.exposeB) + 1;
        }

        if (StaticGameState.inv == StaticGameState.bc)
        {
            StaticGameState.pBC = "yes";
            StaticGameState.exposeC = int.Parse(StaticGameState.exposeC) + 1;
        }

        MethodExposeConfirmation();
        optionsManager.PresentOptions();
    }

    private static void passage115_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.inv == StaticGameState.ba)
        {
            StaticGameState.exposeA = int.Parse(StaticGameState.exposeA) - 1;
        }

        if (StaticGameState.inv == StaticGameState.bb)
        {
            StaticGameState.exposeB = int.Parse(StaticGameState.exposeB) - 1;
        }

        if (StaticGameState.inv == StaticGameState.bc)
        {
            StaticGameState.exposeC = int.Parse(StaticGameState.exposeC) - 1;
        }

        MethodConcealConfirmation();
        optionsManager.PresentOptions();
    }


    private static void MethodBuildplayC()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Do not allow the other player's to see the Storybook while making the decision below.");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Continuing Investigation - Compiled Journal Entries of ");
        Console.Write(StaticGameState.nameC);
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.inv == StaticGameState.ba)
        {
            Console.Write("I arrived at the ");
            Console.Write(StaticGameState.ba);
            Console.Write(" under cover of darkness. I was ill-suited for such stealthy missions, but I kept my cloak and collar about my neck to conceal my identity in case I was discovered.");
        }
        else if (StaticGameState.inv == StaticGameState.bb)
        {
            Console.Write("A thick fog shrouded my approach on the cool night that I chose to investigate the ");
            Console.Write(StaticGameState.bb);
            Console.Write(". I asked the carriage driver to await my return on the outskirts of town, while I stole away into the empty streets. Nary a soul was about on this evening, and I was soon inside without arousing suspicion.");
        }
        else
        {
            Console.Write("To my chagrin, a ");
            Console.Write(StaticGameState.GetRandom(new[]
            {
                "gentleman",
                "gentlewoman"
            }));
            Console.Write(
                " stood near the front door of the building. At this late hour, I could only assume that they were standing guard. Not to be thwarted so easily, I tilted my hat to obscure my face and stalked into the alley behind. The lock on the rear door was a trifle for my tools, and I entered without a sound.");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("I could either provide evidence to help ");
        Console.Write("<bold>");
        Console.Write("expose");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("the secret inner workings of the building or I could ");
        Console.Write("<bold>");
        Console.Write("conceal");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("the truth and allow the work to continue. ");
        Console.Write("<bold>");
        Console.Write("The decision was clear to me:");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        StaticGameState.playC = int.Parse(StaticGameState.playC) + 1;
        Console.Write("<hook>");
        optionsManager.AddOption("I exposed the truth.", passage116_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("I concealed the true purpose.", passage116_Fragment_1);
        Console.Write("</hook>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage116_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.inv == StaticGameState.ba)
        {
            StaticGameState.pCA = "yes";
            StaticGameState.exposeA = int.Parse(StaticGameState.exposeA) + 1;
        }

        if (StaticGameState.inv == StaticGameState.bb)
        {
            StaticGameState.pCB = "yes";
            StaticGameState.exposeB = int.Parse(StaticGameState.exposeB) + 1;
        }

        if (StaticGameState.inv == StaticGameState.bc)
        {
            StaticGameState.pCC = "yes";
            StaticGameState.exposeC = int.Parse(StaticGameState.exposeC) + 1;
        }

        MethodExposeConfirmation();
        optionsManager.PresentOptions();
    }

    private static void passage116_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.inv == StaticGameState.ba)
        {
            StaticGameState.exposeA = int.Parse(StaticGameState.exposeA) - 1;
        }

        if (StaticGameState.inv == StaticGameState.bb)
        {
            StaticGameState.exposeB = int.Parse(StaticGameState.exposeB) - 1;
        }

        if (StaticGameState.inv == StaticGameState.bc)
        {
            StaticGameState.exposeC = int.Parse(StaticGameState.exposeC) - 1;
        }

        MethodConcealConfirmation();
        optionsManager.PresentOptions();
    }


    private static void MethodBuildplayD()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Do not allow the other players to see the Storybook while making the decision below.");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Continuing Investigation - Compiled Journal Entries of ");
        Console.Write(StaticGameState.nameD);
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.inv == StaticGameState.ba)
        {
            Console.Write("I arrived at the ");
            Console.Write(StaticGameState.ba);
            Console.Write(" under cover of darkness. I was ill-suited for such stealthy missions, but I kept my cloak and collar about my neck to conceal my identity in case I was discovered.");
        }
        else if (StaticGameState.inv == StaticGameState.bb)
        {
            Console.Write("A thick fog shrouded my approach on the cool night that I chose to investigate the ");
            Console.Write(StaticGameState.bb);
            Console.Write(". I asked the carriage driver to await my return on the outskirts of town, while I stole away into the empty streets. Nary a soul was about on this evening, and I was soon inside without arousing suspicion.");
        }
        else
        {
            Console.Write("To my chagrin, a ");
            Console.Write(StaticGameState.GetRandom(new[]
            {
                "gentleman",
                "gentlewoman"
            }));
            Console.Write(
                " stood near the front door of the building. At this late hour, I could only assume that they were standing guard. Not to be thwarted so easily, I tilted my hat to obscure my face and stalked into the alley behind. The lock on the rear door was a trifle for my tools, and I entered without a sound.");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("I could either provide evidence to help ");
        Console.Write("<bold>");
        Console.Write("expose");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("the secret inner workings of the building or I could ");
        Console.Write("<bold>");
        Console.Write("conceal");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("the truth and allow the work to continue. ");
        Console.Write("<bold>");
        Console.Write("The decision was clear to me:");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        StaticGameState.playD = int.Parse(StaticGameState.playD) + 1;
        Console.Write("<hook>");
        optionsManager.AddOption("I exposed the truth.", passage117_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("I concealed the true purpose.", passage117_Fragment_1);
        Console.Write("</hook>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage117_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.inv == StaticGameState.ba)
        {
            StaticGameState.pDA = "yes";
            StaticGameState.exposeA = int.Parse(StaticGameState.exposeA) + 1;
        }

        if (StaticGameState.inv == StaticGameState.bb)
        {
            StaticGameState.pDB = "yes";
            StaticGameState.exposeB = int.Parse(StaticGameState.exposeB) + 1;
        }

        if (StaticGameState.inv == StaticGameState.bc)
        {
            StaticGameState.pDC = "yes";
            StaticGameState.exposeC = int.Parse(StaticGameState.exposeC) + 1;
        }

        MethodExposeConfirmation();
        optionsManager.PresentOptions();
    }

    private static void passage117_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.inv == StaticGameState.ba)
        {
            StaticGameState.exposeA = int.Parse(StaticGameState.exposeA) - 1;
        }

        if (StaticGameState.inv == StaticGameState.bb)
        {
            StaticGameState.exposeB = int.Parse(StaticGameState.exposeB) - 1;
        }

        if (StaticGameState.inv == StaticGameState.bc)
        {
            StaticGameState.exposeC = int.Parse(StaticGameState.exposeC) - 1;
        }

        MethodConcealConfirmation();
        optionsManager.PresentOptions();
    }


    private static void MethodBuildplayE()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Do not allow the other players to see the Storybook while making the decision below.");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Continuing Investigation - Compiled Journal Entries of ");
        Console.Write(StaticGameState.nameE);
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.inv == StaticGameState.ba)
        {
            Console.Write("I arrived at the ");
            Console.Write(StaticGameState.ba);
            Console.Write(" under cover of darkness. I was ill-suited for such stealthy missions, but I kept my cloak and collar about my neck to conceal my identity in case I was discovered.");
        }
        else if (StaticGameState.inv == StaticGameState.bb)
        {
            Console.Write("A thick fog shrouded my approach on the cool night that I chose to investigate the ");
            Console.Write(StaticGameState.bb);
            Console.Write(". I asked the carriage driver to await my return on the outskirts of town, while I stole away into the empty streets. Nary a soul was about on this evening, and I was soon inside without arousing suspicion.");
        }
        else
        {
            Console.Write("To my chagrin, a ");
            Console.Write(StaticGameState.GetRandom(new[]
            {
                "gentleman",
                "gentlewoman"
            }));
            Console.Write(
                " stood near the front door of the building. At this late hour, I could only assume that they were standing guard. Not to be thwarted so easily, I tilted my hat to obscure my face and stalked into the alley behind. The lock on the rear door was a trifle for my tools, and I entered without a sound.");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("I could either provide evidence to help ");
        Console.Write("<bold>");
        Console.Write("expose");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("the secret inner workings of the building or I could ");
        Console.Write("<bold>");
        Console.Write("conceal");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("the truth and allow the work to continue. ");
        Console.Write("<bold>");
        Console.Write("The decision was clear to me:");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        StaticGameState.playE = int.Parse(StaticGameState.playE) + 1;
        Console.Write("<hook>");
        optionsManager.AddOption("I exposed the truth.", passage118_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("I concealed the true purpose.", passage118_Fragment_1);
        Console.Write("</hook>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage118_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.inv == StaticGameState.ba)
        {
            StaticGameState.pEA = "yes";
            StaticGameState.exposeA = int.Parse(StaticGameState.exposeA) + 1;
        }

        if (StaticGameState.inv == StaticGameState.bb)
        {
            StaticGameState.pEB = "yes";
            StaticGameState.exposeB = int.Parse(StaticGameState.exposeB) + 1;
        }

        if (StaticGameState.inv == StaticGameState.bc)
        {
            StaticGameState.pEC = "yes";
            StaticGameState.exposeC = int.Parse(StaticGameState.exposeC) + 1;
        }

        MethodExposeConfirmation();
        optionsManager.PresentOptions();
    }

    private static void passage118_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.inv == StaticGameState.ba)
        {
            StaticGameState.exposeA = int.Parse(StaticGameState.exposeA) - 1;
        }

        if (StaticGameState.inv == StaticGameState.bb)
        {
            StaticGameState.exposeB = int.Parse(StaticGameState.exposeB) - 1;
        }

        if (StaticGameState.inv == StaticGameState.bc)
        {
            StaticGameState.exposeC = int.Parse(StaticGameState.exposeC) - 1;
        }

        MethodConcealConfirmation();
        optionsManager.PresentOptions();
    }


    private static void MethodMostInvestigated()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        List<int> play = new List<int>(new int[]
        {
            StaticGameState.playA,
            StaticGameState.playB,
            StaticGameState.playC,
            StaticGameState.playD,
            StaticGameState.playE
        });
        int num = (from value in play
            where value == play.Max()
            select value).Count<int>();
        if (num > 1)
        {
            StaticGameState.most = 0;
        }
        else if (StaticGameState.playA > StaticGameState.Max(new int[]
                 {
                     StaticGameState.playB,
                     StaticGameState.playC,
                     StaticGameState.playD,
                     StaticGameState.playE
                 }))
        {
            StaticGameState.most = StaticGameState.nameA;
        }
        else if (StaticGameState.playB > StaticGameState.Max(new int[]
                 {
                     StaticGameState.playC,
                     StaticGameState.playD,
                     StaticGameState.playE
                 }))
        {
            StaticGameState.most = StaticGameState.nameB;
        }
        else if (StaticGameState.playC > int.Max(StaticGameState.playD, StaticGameState.playE))
        {
            StaticGameState.most = StaticGameState.nameC;
        }
        else if (StaticGameState.playD > StaticGameState.Max(new int[]
                 {
                     StaticGameState.playE
                 }))
        {
            StaticGameState.most = StaticGameState.nameD;
        }
        else
        {
            StaticGameState.most = StaticGameState.nameE;
        }

        if (StaticGameState.hunters == "evil")
        {
            if (StaticGameState.goodcount < 2)
            {
                StaticGameState.society = "Fraternity of Hunters";
            }
            else
            {
                StaticGameState.society = "Order of St. Hubertus";
            }
        }

        if (StaticGameState.hunters == "good")
        {
            if (StaticGameState.goodcount > 1)
            {
                StaticGameState.society = "Fraternity of Hunters";
            }
            else
            {
                StaticGameState.society = "Order of St. Hubertus";
            }
        }

        if (StaticGameState.most == 0 || StaticGameState.most == "" || string.IsNullOrEmpty(StaticGameState.most))
        {
            MethodDiseaseEnd();
        }
        else
        {
            Console.Write("<bold>");
            Console.Write("Most Investigations");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(StaticGameState.most);
            Console.Write(" ");
            Console.Write("performed the most investigative actions. This did not go unnoticed by the ");
            Console.Write(StaticGameState.society);
            Console.Write(", and despite their allegiances, they felt this exploratory spirit worthy of reward.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<bold>");
            Console.Write(StaticGameState.most);
            Console.Write(" ");
            Console.Write("immediately gains 4VP.");
            Console.Write("</bold>");
        }

        Console.WriteLine();
        Console.WriteLine();
        optionsManager.AddOption("DiseaseEnd", MethodDiseaseEnd);
        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodProsperity1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("The Good Fight - Early Years");
        Console.Write("</bold>");
        Console.WriteLine();
        StaticGameState.round = 13;
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.society == "Order of St. Hubertus")
        {
            if (StaticGameState.gen3pg == 0 || StaticGameState.gen3pg == "")
            {
                Console.Write("<setupStyle>");
                Console.Write("<bold>");
                Console.Write("SETUP");
                Console.Write("</bold>");
                StaticGameState._SetupImage = "AngryMobSetup1";
                Console.Write("Turn to page ");
                Console.Write("<bold>");
                Console.Write("17");
                Console.Write("</bold>");
                Console.Write(" of the Village Chronicle. Place the Suspicion Marker on space ");
                Console.Write("<bold>");
                if (StaticGameState.Prosperity1 == 0 || StaticGameState.Prosperity1 == "")
                {
                    StaticGameState.Prosperity1 = 1;
                    StaticGameState.tracker = int.Parse(StaticGameState.tracker) - 2;
                    if (StaticGameState.players == 4)
                    {
                        StaticGameState.tracker = int.Parse(StaticGameState.tracker) - 1;
                    }

                    if (StaticGameState.players == 5)
                    {
                        StaticGameState.tracker = int.Parse(StaticGameState.tracker) - 1;
                    }
                }

                Console.Write(StaticGameState.tracker);
                Console.Write("</bold>");
                Console.Write(" and the ");
                Console.Write("<sprite=\"AngryMob_Icon\" index=0>");
                Console.Write(" token one space to the left. ");
                Console.Write("<italic>");
                Console.Write("Pass the Starting Player token as normal.");
                Console.Write("</italic>");
                Console.Write(" ");
                if (StaticGameState.players == 3)
                {
                    Console.Write("Then, since this is a 3 player game, pass the starting player marker clockwise 1 additional time.");
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Place a ");
                Console.Write("<sprite=\"Storybook\" index=0>");
                Console.Write(" token directly on top of the ");
                Console.Write("<sprite=\"AngryMob_Icon\" index=0>");
                Console.Write(" token.");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("<bold>");
                Console.Write("SPECIAL SETUP");
                Console.Write("</bold>");
                StaticGameState._SetupImage = "S1_Suspicious_Building";
                if (StaticGameState.exposeA > 0)
                {
                    Console.Write("Place the ");
                    Console.Write(StaticGameState.ba);
                    Console.Write(" tile over spot A on the Village Chronicle. ");
                    Console.WriteLine();
                }

                if (StaticGameState.exposeB > 0)
                {
                    Console.Write("Place the ");
                    Console.Write(StaticGameState.bb);
                    Console.Write(" tile over spot B on the Village Chronicle. ");
                    Console.WriteLine();
                }

                if (StaticGameState.exposeC > 0)
                {
                    Console.Write("Place the ");
                    Console.Write(StaticGameState.bc);
                    Console.Write(" tile over spot C on the Village Chronicle. ");
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.Write("Return all other Exposed Building tiles to the scenario box.");
                Console.Write("</setupStyle>");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hubTitle>");
            Console.Write("<bold>");
            Console.Write("Acceptance");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("Caretaker pieces can now take actions in Town as well as in the Estates. ");
            Console.Write("<italic>");
            Console.Write("The same Town placement rules for Servants apply to Caretaker pieces.");
            Console.Write("</italic>");
            Console.Write("</hubDetails>");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hubTitle>");
            Console.Write("<bold>");
            Console.Write("School for Hybridized Individuals");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("When a player visits the ");
            Console.Write("<bold>");
            Console.Write("School for Hybridized Individuals");
            Console.Write("</bold>");
            Console.Write(", they ");
            Console.Write("<bold>");
            Console.Write("pay $1");
            Console.Write("</bold>");
            Console.Write(" to gain a ");
            Console.Write("<bold>");
            Console.Write("Caretaker");
            Console.Write("</bold>");
            Console.Write(" piece from Lost. ");
            Console.Write("</hubDetails>");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hubTitle>");
            Console.Write("<bold>");
            Console.Write("Experiments are Feared");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.Write("<hubDetails>");
            Console.Write("Anytime a player takes the Perform an Experiment Estate action, they gain 1 ");
            Console.Write("<sprite=\"Creepy_Icon\" index=0>");
            Console.Write(".");
            Console.Write("</hubDetails>");
            Console.Write("<hubTitle>");
            Console.Write("<sprite=\"Storybook\" index=0>");
            Console.Write(" ");
            Console.Write("<bold>");
            Console.Write("Angry Mob");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("Any time the ");
            Console.Write("<sprite=\"AngryMob_Icon\" index=0>");
            Console.Write(" token moves, move the Storybook token along with it. If the ");
            Console.Write("<sprite=\"AngryMob_Icon\" index=0>");
            Console.Write(" overtakes a player, complete the current action and then ");
            optionsManager.AddOption("AngryMobStorybook", MethodAngryMobStorybook);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hook>");
            optionsManager.AddOption("Click at the end of the round to continue...", passage119_Fragment_0);
            Console.Write("</hook>");
            Console.Write("</hubDetails>");
            Console.WriteLine();
        }
        else
        {
            if (StaticGameState.gen3pg == 0 || StaticGameState.gen3pg == "")
            {
                Console.Write("<setupStyle>");
                Console.Write("<bold>");
                Console.Write("SETUP");
                Console.Write("</bold>");
                StaticGameState._SetupImage = "AngryMobSetup1";
                Console.Write("Turn to page ");
                Console.Write("<bold>");
                Console.Write("15");
                Console.Write("</bold>");
                Console.Write(" of the Village Chronicle. Place the 2 ");
                Console.Write("<bold>");
                Console.Write("Engineering Master's Study");
                Console.Write("</bold>");
                Console.Write(" tiles into play near the other Vanity Estate Upgrades. The Suspicion Marker remains in the same space and the ");
                Console.Write("<sprite=\"AngryMob_Icon\" index=0>");
                Console.Write(" token is reset 1 space to the left. ");
                Console.Write("<italic>");
                Console.Write("Pass the Starting Player token as normal.");
                Console.Write("</italic>");
                Console.Write(" ");
                if (StaticGameState.players == 3)
                {
                    Console.Write("Then, since this is a 3-player game, pass the starting player marker clockwise 1 additional time.");
                }

                Console.WriteLine();
                Console.WriteLine();
                if (StaticGameState.exposeA > 0)
                {
                    Console.Write("Place the ");
                    Console.Write(StaticGameState.ba);
                    Console.Write(" tile over spot A on the Village Chronicle. ");
                    Console.WriteLine();
                }

                if (StaticGameState.exposeB > 0)
                {
                    Console.Write("Place the ");
                    Console.Write(StaticGameState.bb);
                    Console.Write(" tile over spot B on the Village Chronicle. ");
                    Console.WriteLine();
                }

                if (StaticGameState.exposeC > 0)
                {
                    Console.Write("Place the ");
                    Console.Write(StaticGameState.bc);
                    Console.Write(" tile over spot C on the Village Chronicle. ");
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.Write("Return all other Exposed Building tiles to the scenario box.");
                Console.Write("</setupStyle>");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hubTitle>");
            Console.Write("<bold>");
            Console.Write("Hunter's Haven");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("For each visit to the Hunter's Haven, pay 1 Occult Knowledge cube to lose 2 ");
            Console.Write("<sprite=\"Insanity_Icon\" index=0>");
            Console.Write(". ");
            Console.Write("<italic>");
            Console.Write("(You cannot use Journaled Knowledge to pay this cost.)");
            Console.Write("</italic>");
            Console.Write("</hubDetails>");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hubTitle>");
            Console.Write("<bold>");
            Console.Write("Engineering Achievement");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("When you gain a Vanity Estate Upgrade, the ");
            Console.Write("<bold>");
            Console.Write("Engineering Master's Study");
            Console.Write("</bold>");
            Console.Write(" is part of the available pool to build as normal.");
            Console.Write("</hubDetails>");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hubTitle>");
            Console.Write("<bold>");
            Console.Write("Endless Hunt");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("At the end of the round, two of the scientists will be chosen to participate in the ");
            Console.Write("<bold>");
            Console.Write("Night of the Hunt.");
            Console.Write("</bold>");
            Console.Write(" This invitation cannot be refused.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hook>");
            optionsManager.AddOption("Click at the end of the round to continue...", passage119_Fragment_1);
            Console.Write("</hook>");
            Console.WriteLine();
            Console.Write("</hubDetails>");
            Console.WriteLine();
        }

        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage119_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.PrintEndOfTheRoundText("Prosperity1", MethodWolvesEcoFriendly);
        optionsManager.PresentOptions();
    }

    private static void passage119_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.PrintEndOfTheRoundText("Prosperity1", MethodCharityAwardGood);
        optionsManager.PresentOptions();
    }


    private static void MethodProsperity2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Moving Forward - Middle Years");
        Console.Write("</bold>");
        Console.WriteLine();
        StaticGameState.round = 14;
        Console.WriteLine();
        if (StaticGameState.society == "Order of St. Hubertus")
        {
            Console.Write("<hubTitle>");
            Console.Write("<bold>");
            Console.Write("Acceptance");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("Caretaker pieces can now take actions in Town as well as in the Estates. ");
            Console.Write("<italic>");
            Console.Write("The same Town placement rules for Servants apply to Caretaker pieces.");
            Console.Write("</italic>");
            Console.Write("</hubDetails>");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hubTitle>");
            Console.Write("<bold>");
            Console.Write("School for Hybridized Individuals");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("When a player visits the ");
            Console.Write("<bold>");
            Console.Write("School for Hybridized Individuals");
            Console.Write("</bold>");
            Console.Write(", they ");
            Console.Write("<bold>");
            Console.Write("pay $1");
            Console.Write("</bold>");
            Console.Write(" to gain a ");
            Console.Write("<bold>");
            Console.Write("Caretaker");
            Console.Write("</bold>");
            Console.Write(" piece from Lost. ");
            Console.Write("</hubDetails>");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hubTitle>");
            Console.Write("<bold>");
            Console.Write("Experiments are Feared");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.Write("<hubDetails>");
            Console.Write("Anytime a player takes the Perform an Experiment Estate action, they gain 1 ");
            Console.Write("<sprite=\"Creepy_Icon\" index=0>");
            Console.Write(".");
            Console.Write("</hubDetails>");
            Console.Write("<hubTitle>");
            Console.Write("<bold>");
            Console.Write("Farmer's Market");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.Write("<hubDetails>");
            Console.Write("Due to the associated social stigma, the Farmer's Market now acts as a Creepy location. When you visit the Farmer's Market also ");
            Console.Write("<bold>");
            Console.Write("gain 1 ");
            Console.Write("<sprite=\"Creepy_Icon\" index=0>");
            Console.Write("</bold>");
            Console.Write(".");
            Console.Write("</hubDetails>");
            Console.Write("<hubTitle>");
            Console.Write("<sprite=\"Storybook\" index=0>");
            Console.Write("<bold>");
            Console.Write(" Angry Mob");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("Any time the ");
            Console.Write("<sprite=\"AngryMob_Icon\" index=0>");
            Console.Write(" token moves, move the ");
            Console.Write("<sprite=\"Storybook\" index=0>");
            Console.Write(" token along with it. If the ");
            Console.Write("<sprite=\"AngryMob_Icon\" index=0>");
            Console.Write(" token overtakes a player, complete the current action and then ");
            optionsManager.AddOption("AngryMobStorybook", MethodAngryMobStorybook);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hook>");
            optionsManager.AddOption("Click at the end of the round to continue...", passage120_Fragment_0);
            Console.Write("</hook>");
            Console.Write("</hubDetails>");
            Console.WriteLine();
            Console.WriteLine();
        }
        else
        {
            Console.Write("<hubTitle>");
            Console.Write("<bold>");
            Console.Write("Hunter's Haven");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("For each visit to the Hunter's Haven, pay 1 Occult Knowledge cube to lose 2 ");
            Console.Write("<sprite=\"Insanity_Icon\" index=0>");
            Console.Write(". ");
            Console.Write("<italic>");
            Console.Write("(You cannot use Journaled Knowledge to pay this cost.)");
            Console.Write("</italic>");
            Console.Write("</hubDetails>");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hubTitle>");
            Console.Write("<bold>");
            Console.Write("Engineering Achievement");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("When you gain a Vanity Estate Upgrade, the ");
            Console.Write("<bold>");
            Console.Write("Engineering Master's Study");
            Console.Write("</bold>");
            Console.Write(" is part of the available pool to build as normal.");
            Console.Write("</hubDetails>");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hubTitle>");
            Console.Write("<bold>");
            Console.Write("Endless Hunt");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("At the end of the round, two of the scientists will be chosen to participate in the ");
            Console.Write("<bold>");
            Console.Write("Night of the Hunt.");
            Console.Write("</bold>");
            Console.Write(" This invitation cannot be refused.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hook>");
            optionsManager.AddOption("Click at the end of the round to continue...", passage120_Fragment_1);
            Console.Write("</hook>");
            Console.Write("</hubDetails>");
        }

        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage120_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.PrintEndOfTheRoundText("Prosperity2", MethodGoodFrenzyEvent);
        optionsManager.PresentOptions();
    }

    private static void passage120_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.PrintEndOfTheRoundText("Prosperity2", MethodCureMoonSick1);
        optionsManager.PresentOptions();
    }


    private static void MethodProsperity3()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Moving Forward - Late Years");
        Console.Write("</bold>");
        Console.WriteLine();
        StaticGameState.round = 15;
        Console.WriteLine();
        if (StaticGameState.society == "Order of St. Hubertus")
        {
            Console.Write("<hubTitle>");
            Console.Write("<bold>");
            Console.Write("Acceptance");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("Caretaker pieces can now take actions in Town as well as in the Estates. ");
            Console.Write("<italic>");
            Console.Write("The same Town placement rules for Servants apply to Caretaker pieces.");
            Console.Write("</italic>");
            Console.Write("</hubDetails>");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hubTitle>");
            Console.Write("<bold>");
            Console.Write("School for Hybridized Individuals");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("When a player visits the ");
            Console.Write("<bold>");
            Console.Write("School for Hybridized Individuals");
            Console.Write("</bold>");
            Console.Write(", they ");
            Console.Write("<bold>");
            Console.Write("pay $1");
            Console.Write("</bold>");
            Console.Write(" to gain a ");
            Console.Write("<bold>");
            Console.Write("Caretaker");
            Console.Write("</bold>");
            Console.Write(" piece from Lost. ");
            Console.Write("</hubDetails>");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hubTitle>");
            Console.Write("<bold>");
            Console.Write("Experiments are Feared");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.Write("<hubDetails>");
            Console.Write("Anytime a player takes the Perform an Experiment Estate action, they gain 1 ");
            Console.Write("<sprite=\"Creepy_Icon\" index=0>");
            Console.Write(".");
            Console.Write("</hubDetails>");
            Console.Write("<hubTitle>");
            Console.Write("<bold>");
            Console.Write("Farmer's Market");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.Write("<hubDetails>");
            Console.Write("Due to the associated social stigma, the Farmer's Market now acts as a Creepy location. When you visit the Farmer's Market also ");
            Console.Write("<bold>");
            Console.Write("gain 1 ");
            Console.Write("<sprite=\"Creepy_Icon\" index=0>");
            Console.Write("</bold>");
            Console.Write(".");
            Console.Write("</hubDetails>");
            Console.Write("<hubTitle>");
            Console.Write("<sprite=\"Storybook\" index=0>");
            Console.Write("<bold>");
            Console.Write(" Angry Mob");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("Any time the ");
            Console.Write("<sprite=\"AngryMob_Icon\" index=0>");
            Console.Write(" token moves, move the ");
            Console.Write("<sprite=\"Storybook\" index=0>");
            Console.Write(" token along with it. If the ");
            Console.Write("<sprite=\"AngryMob_Icon\" index=0>");
            Console.Write(" token overtakes a player, complete the current action and then ");
            optionsManager.AddOption("AngryMobStorybook", MethodAngryMobStorybook);
            Console.Write("</hubDetails>");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hubTitle>");
            Console.Write("<bold>");
            Console.Write("Scientific Achievement");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("When you gain a Vanity Estate Upgrade, all remaining <b>Master's Study</b> tiles are part of the available pool to build as normal <i>(not Occult)</i>.");
            Console.WriteLine();
            Console.WriteLine();
            StaticGameState.ending = MethodENDWolvesGood1;
            Console.Write("<hook>");
            optionsManager.AddOption("Click at the end of the Generation to continue to Final Scoring...", passage121_Fragment_0);
            Console.Write("</hook>");
            Console.Write("</hubDetails>");
        }
        else
        {
            Console.Write("<hubTitle>");
            Console.Write("<bold>");
            Console.Write("Hunter's Haven");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("For each visit to the Hunter's Haven, pay 1 Occult Knowledge cube to lose 2 ");
            Console.Write("<sprite=\"Insanity_Icon\" index=0>");
            Console.Write(". ");
            Console.Write("<italic>");
            Console.Write("(You cannot use Journaled Knowledge to pay this cost.)");
            Console.Write("</italic>");
            Console.Write("</hubDetails>");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hubTitle>");
            Console.Write("<bold>");
            Console.Write("Scientific Achievement");
            Console.Write("</bold>");
            Console.Write("</hubTitle>");
            Console.WriteLine();
            Console.Write("<hubDetails>");
            Console.Write("When you gain a Vanity Estate Upgrade, all remaining <b>Master's Study</b> tiles are part of the available pool to build as normal <i>(not Occult)</i>.");
            Console.WriteLine();
            Console.WriteLine();
            StaticGameState.ending = MethodENDHunterGood1;
            Console.Write("<hook>");
            optionsManager.AddOption("Click at the end of the Generation to continue to Final Scoring...", passage121_Fragment_1);
            Console.Write("</hook>");
            Console.Write("</hubDetails>");
        }

        Console.WriteLine();
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage121_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.PrintEndOfTheRoundText("Prosperity3", MethodScoring);
        optionsManager.PresentOptions();
    }

    private static void passage121_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.PrintEndOfTheRoundText("Prosperity3", MethodScoring);
        optionsManager.PresentOptions();
    }


    private static void MethodTrigger35Points()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Carefully hand this storybook device to the player that just reached 35VP. This is read within view of all players.");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.thirtyFivevp == "creep")
        {
            Console.Write("<bold>");
            Console.Write("\"Nasty Rumors\" - Journal Entry, 1878");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write(
                "To reach the pinnacle of understanding, only to feel the cruel hand of treachery. The rest of the family was noticeably not distraught when a recent article in the regional newspaper spread an uncomfortable rumor about my personal hygiene.");
            Console.WriteLine();
            StaticGameState.twopage = 1;
            Console.WriteLine();
            Console.Write("I do not have time for this interruption! I do not smell like pickles! It is the formaldehyde solution for my most recent experiment. It is not the smell of pickles; it is the smell of SCIENCE!");
            Console.WriteLine();
            Console.WriteLine();
        }
        else
        {
            Console.Write("<bold>");
            Console.Write("\"Unfortunate Accident\" - Journal Entry, 1876");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("My work! My property! Sabotaged.");
            Console.WriteLine();
            StaticGameState.twopage = 1;
            Console.WriteLine();
            Console.Write(
                "I awoke this evening to find my home on fire and the culprits nowhere to be found. But, I know who did it. I could still smell the chemical reaction as the fires raged. I would have never expected my cousins to stoop to such a base level. Direct and blatant sabotage? Absolutely unconscionable.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("It will take weeks for my spouse to manage the removal of the damaged piece of our Estate. They are all just jealous of my genius!");
            Console.WriteLine();
            Console.WriteLine();
        }

        Console.Write("<hook>");
        optionsManager.AddOption("Click to return...", passage122_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage122_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", ((StaticGameState.round == 7) ? MethodHospital1 : ((StaticGameState.round == 8) ? MethodHospital2 : MethodHospital3)));
        StaticGameState.trigger35 = 1;
        Console.Write("<setupStyleEvnt>");
        if (StaticGameState.thirtyFivevp == "creep")
        {
            Console.Write("<bold>");
            Console.Write("SPECIAL SETUP");
            Console.Write("</bold>");
            StaticGameState._SetupImage = "Creepy_Icon";
            Console.WriteLine();
            Console.Write("Immediately ");
            Console.Write("<bold>");
            Console.Write("gain 2 ");
            Console.Write("<sprite=\"Creepy_Icon\" index=0>");
            Console.Write("</bold>");
            Console.Write(" and ");
            Console.Write("<bold>");
            Console.Write("gain 1 ");
            Console.Write("<sprite=\"Insanity_Icon\" index=0>");
            Console.Write("</bold>");
            Console.Write(".");
        }
        else
        {
            Console.Write("<bold>");
            Console.Write("SPECIAL SETUP");
            Console.Write("</bold>");
            StaticGameState._SetupImage = "DiscardEstateUpgrade_Icon";
            Console.WriteLine();
            Console.Write("Immediately ");
            Console.Write("<bold>");
            Console.Write("lose 4VP");
            Console.Write("</bold>");
            Console.Write(" and ");
            Console.Write("<bold>");
            Console.Write("discard an Estate Upgrade of your choice");
            Console.Write("</bold>");
            Console.Write(".");
        }

        Console.Write("</setupStyleEvnt>");
        optionsManager.PresentOptions();
    }

    private static void passage122_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to return...", passage122_Fragment_0);
        optionsManager.PresentOptions();
    }


    private static void MethodTrigger3Experiments()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Advancements in ");
        Console.Write(StaticGameState.sci3);
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Please click on the name of the scientist that completed a total of ");
        Console.Write("<bold>");
        Console.Write("3 B or C ");
        Console.Write(StaticGameState.sci3);
        Console.Write(" ");
        Console.Write("Experiments");
        Console.Write("</bold>");
        Console.Write(":");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Dr. " + (string)StaticGameState.nameA + " Jr.", passage123_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Dr. " + (string)StaticGameState.nameB + " Jr.", passage123_Fragment_1);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.players > 2)
        {
            Console.Write("<hook>");
            optionsManager.AddOption("Dr. " + (string)StaticGameState.nameC + " Jr.", passage123_Fragment_2);
            Console.Write("</hook>");
            Console.WriteLine();
            Console.WriteLine();
        }

        if (StaticGameState.players > 3)
        {
            Console.Write("<hook>");
            optionsManager.AddOption("Dr. " + (string)StaticGameState.nameD + " Jr.", passage123_Fragment_3);
            Console.Write("</hook>");
            Console.WriteLine();
            Console.WriteLine();
        }

        if (StaticGameState.players > 4)
        {
            Console.Write("<hook>");
            optionsManager.AddOption("Dr. " + (string)StaticGameState.nameE + " Jr.", passage123_Fragment_4);
            Console.Write("</hook>");
            Console.WriteLine();
            Console.WriteLine();
        }

        optionsManager.PresentOptions();
    }

    private static void passage123_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.gen2exp = StaticGameState.nameA;
        Method3ExperimentsRes();
        optionsManager.PresentOptions();
    }

    private static void passage123_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.gen2exp = StaticGameState.nameB;
        Method3ExperimentsRes();
        optionsManager.PresentOptions();
    }

    private static void passage123_Fragment_2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.gen2exp = StaticGameState.nameC;
        Method3ExperimentsRes();
        optionsManager.PresentOptions();
    }

    private static void passage123_Fragment_3()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.gen2exp = StaticGameState.nameD;
        Method3ExperimentsRes();
        optionsManager.PresentOptions();
    }

    private static void passage123_Fragment_4()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.gen2exp = StaticGameState.nameE;
        Method3ExperimentsRes();
        optionsManager.PresentOptions();
    }


    private static void MethodChooseScience()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Carefully hand the Storybook to ");
        Console.Write(StaticGameState.charity);
        Console.Write(". This choice is read and made within view of all players.");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("\"Universal Interest\" - Journal Entry - November, 1859 - ");
        Console.Write(StaticGameState.charity);
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "It has been three days since I received a letter from the Hungarian government and two days since my cousins deigned it necessary to make me the target of their ridicule. My parents cared deeply for this horrid community - a sentiment that those miscreants know nothing about!");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("I am not some groveler who needs confirmation from the stuffed shirts and upturned noses of European academies. But, getting to choose the ");
        Console.Write("<bold>");
        Console.Write("subject of the upcoming Symposium");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("that could very well determine if a ");
        Console.Write("<bold>");
        Console.Write("University");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("is built in ");
        Console.Write(StaticGameState.townname);
        Console.Write("?");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "My parents instilled into me a scientific vigor that far surpasses even the members of my own, somewhat beloved, family. As I returned from studies abroad, it was my own aptitudes that spearheaded my cousins into action. Damn them and their jibes! I will show them. In fact, I have already made my choice and penned my response. It will be I who will be doing the laughing in the end.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Choose which of the Sciences our family will focus upon this Generation:");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Chemistry", passage124_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Engineering", passage124_Fragment_1);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Biology", passage124_Fragment_2);
        Console.Write("</hook>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage124_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.sci3 = "Chemistry";
        Method35VP();
        optionsManager.PresentOptions();
    }

    private static void passage124_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.sci3 = "Engineering";
        Method35VP();
        optionsManager.PresentOptions();
    }

    private static void passage124_Fragment_2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.sci3 = "Biology";
        Method35VP();
        optionsManager.PresentOptions();
    }


    private static void MethodSymposiumEvent1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("A Collection of Esteemed Colleagues");
        Console.Write("</bold>");
        Console.WriteLine();
        StaticGameState.twopage = 0;
        Console.WriteLine();
        Console.Write("The journey to the newly created city of Budapest for the ");
        Console.Write(StaticGameState.sci3);
        Console.Write(" ");
        Console.Write("Symposium was uncharacteristically dour. However, this dreadful murkiness could not dampen the spirits of the ");
        Console.Write(StaticGameState.playtxt);
        Console.Write("; nor could the sojourn in the marginal accommodations prepared for their arrival. For the cousins, this recognition for their efforts to advance science at all costs was considerably well-deserved and long-overdue.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("The University was abuzz with activity as they attended various events and offered their prescribed greetings.");
        Console.WriteLine();
        Console.WriteLine();
        optionsManager.AddOption("SymposiumEvent2", MethodSymposiumEvent2);
        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodHUBExample()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.round == 1)
        {
            optionsManager.AddOption("Fever1", MethodFever1);
        }

        Console.WriteLine();
        if (StaticGameState.round == 2)
        {
            optionsManager.AddOption("Fever2", MethodFever2);
        }

        Console.WriteLine();
        if (StaticGameState.round == 3)
        {
            optionsManager.AddOption("Fever3", MethodFever3);
        }

        Console.WriteLine();
        if (StaticGameState.round == 4)
        {
            optionsManager.AddOption("Devastation1", MethodDevastation1);
        }

        Console.WriteLine();
        if (StaticGameState.round == 5)
        {
            optionsManager.AddOption("Devastation2", MethodDevastation2);
        }

        Console.WriteLine();
        if (StaticGameState.round == 6)
        {
            optionsManager.AddOption("Devastation3", MethodDevastation3);
        }

        Console.WriteLine();
        if (StaticGameState.round == 7)
        {
            optionsManager.AddOption("Hospital1", MethodHospital1);
        }

        Console.WriteLine();
        if (StaticGameState.round == 8)
        {
            optionsManager.AddOption("Hospital2", MethodHospital2);
        }

        Console.WriteLine();
        if (StaticGameState.round == 9)
        {
            optionsManager.AddOption("Hospital3", MethodHospital3);
        }

        Console.WriteLine();
        if (StaticGameState.round == 10)
        {
            optionsManager.AddOption("GloomyGothic1", MethodGloomyGothic1);
        }

        Console.WriteLine();
        if (StaticGameState.round == 11)
        {
            optionsManager.AddOption("GloomyGothic2", MethodGloomyGothic2);
        }

        Console.WriteLine();
        if (StaticGameState.round == 12)
        {
            optionsManager.AddOption("GloomyGothic3", MethodGloomyGothic3);
        }

        Console.WriteLine();
        if (StaticGameState.round == 13)
        {
            optionsManager.AddOption("Prosperity1", MethodProsperity1);
        }

        Console.WriteLine();
        if (StaticGameState.round == 14)
        {
            optionsManager.AddOption("Prosperity2", MethodProsperity2);
        }

        Console.WriteLine();
        if (StaticGameState.round == 15)
        {
            optionsManager.AddOption("Prosperity3", MethodProsperity3);
        }

        Console.WriteLine();
        if (StaticGameState.round == 16)
        {
            optionsManager.AddOption("NoUni1", MethodNoUni1);
        }

        Console.WriteLine();
        if (StaticGameState.round == 17)
        {
            optionsManager.AddOption("NoUni2", MethodNoUni2);
        }

        Console.WriteLine();
        if (StaticGameState.round == 18)
        {
            optionsManager.AddOption("NoUni3", MethodNoUni3);
        }

        Console.WriteLine();
        if (StaticGameState.round == 19)
        {
            optionsManager.AddOption("University1", MethodUniversity1);
        }

        Console.WriteLine();
        if (StaticGameState.round == 20)
        {
            optionsManager.AddOption("University2", MethodUniversity2);
        }

        Console.WriteLine();
        if (StaticGameState.round == 21)
        {
            optionsManager.AddOption("University3", MethodUniversity3);
        }

        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodSanityChoice()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.WriteLine();
        StaticGameState.gen3pg = 0;
        Console.Write("<bold>");
        Console.Write("Carefully hand the Storybook to ");
        Console.Write(StaticGameState.saneplayer);
        Console.Write(". This choice is read and made within view of all players.");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Journal Entry, ");
        Console.Write(StaticGameState.saneplayer);
        Console.Write(" ");
        Console.Write("- September, 1892");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write(
            "The fools! The utter fools! In their haste to return to their amateurish attempts at science, my dear, witless cousins have been overlooked by our colleagues at the university. And so it fell to me to advise them on this most important psychological matter!");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "My in-depth studies of phrenology and first-hand observation of brain function have allowed me to calculate with flawless accuracy the appropriate level of mental intensity needed to excel in science; the most proper balance of passion and ethical ambiguity.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("While, yes, we may ALL benefit from this assessment and yes, they did only consult me out of a sense of pity, it is I alone that will now control the fate of us all!");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("CHOOSE");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write(StaticGameState.saneplayer);
        Console.Write(" ");
        Console.Write("must now choose a numbered spot below on the ");
        Console.Write("<sprite=\"Insanity_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("Track.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("At the end of the Generation, any player whose piece is on this space will ");
        Console.Write("<bold>");
        Console.Write("gain 5VP");
        Console.Write("</bold>");
        Console.Write(".");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("3", passage127_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("4", passage127_Fragment_1);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("5", passage127_Fragment_2);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("6", passage127_Fragment_3);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("7", passage127_Fragment_4);
        Console.Write("</hook>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage127_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.mental = 3;
        MethodPanaceaUnleashCons2();
        optionsManager.PresentOptions();
    }

    private static void passage127_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.mental = 4;
        MethodPanaceaUnleashCons2();
        optionsManager.PresentOptions();
    }

    private static void passage127_Fragment_2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.mental = 5;
        MethodPanaceaUnleashCons2();
        optionsManager.PresentOptions();
    }

    private static void passage127_Fragment_3()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.mental = 6;
        MethodPanaceaUnleashCons2();
        optionsManager.PresentOptions();
    }

    private static void passage127_Fragment_4()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.mental = 7;
        MethodPanaceaUnleashCons2();
        optionsManager.PresentOptions();
    }


    private static void MethodLycanthropicMessage()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("The Form of the Wolf");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("Confirming the existence of individuals with the ability to change into an animal form had remarkable consequences. It is possible that it has even disrupted the studies of one of our kin.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Does any player have the ");
        Console.Write("<bold>");
        Console.Write("Lycanthropic Strength");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("Masterwork Experiment?");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Yes.", passage128_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        optionsManager.AddOption("WolvesSetupGen3", MethodWolvesSetupGen3);
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage128_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.lycan = "yes";
        MethodLycanEvil();
        optionsManager.PresentOptions();
    }


    private static void MethodLycanEvil()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Strength Can Be Mine");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("Their existence was proven. Now, could the catalyst of this truly powerful transformation be replicated? And how could it be further strengthened?");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click to continue...", passage129_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage129_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", MethodWolvesSetupGen3);
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "S1_MWUpdateLycanthropic";
        Console.WriteLine();
        Console.Write("Retrieve the ");
        Console.Write("<bold>");
        Console.Write("Lycanthropic Strength");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("Update card from the scenario box and give it to the player working towards this Masterwork.");
        Console.Write("</setupStyleEvnt>");
        optionsManager.PresentOptions();
    }

    private static void passage129_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage129_Fragment_0);
        optionsManager.PresentOptions();
    }


    private static void MethodWolvesSetupGen3()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", MethodGloomyGothic1);
        StaticGameState.gen3pg = 0;
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "StorybookToken";
        Console.Write("Each player retrieves a ");
        Console.Write("<bold>");
        Console.Write("Storybook token");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("and places it on their Masterwork.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<italic>");
        Console.Write("When a player completes their Masterwork, they will consult the Storybook for a special message from the Order.");
        Console.Write("</italic>");
        Console.Write("</setupStyleEvnt>");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodHospitalVisitCheck()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("A Compulsory Visitation");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("The ");
        Console.Write(StaticGameState.townname);
        Console.Write(" ");
        Console.Write(
            "General Hospital was one of the first hospitals in the region. Established in 1865, it was instrumental in changing the public perception of a hospital from a place you go to die to a place of healing with the most modern advances in medicine.");
        Console.WriteLine();
        StaticGameState.twopage = 1;
        Console.WriteLine();
        Console.Write("On the day of the visit, several nurses bandied about, treating patients from nearby villages with symptoms of the Yellow Fever");
        if (StaticGameState.pub == "yes")
        {
            Console.Write(" and using the innoculation techniques that the family had recently published");
        }

        Console.Write(".");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Click on the name of the player ");
        Console.Write("<bold>");
        Console.Write("visiting the Hospital");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("today:");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Dr. " + (string)StaticGameState.nameA + " Jr.", passage130_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Dr. " + (string)StaticGameState.nameB + " Jr.", passage130_Fragment_1);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.players > 2)
        {
            Console.Write("<hook>");
            optionsManager.AddOption("Dr. " + (string)StaticGameState.nameC + " Jr.", passage130_Fragment_2);
            Console.Write("</hook>");
            Console.WriteLine();
            Console.WriteLine();
        }

        if (StaticGameState.players > 3)
        {
            Console.Write("<hook>");
            optionsManager.AddOption("Dr. " + (string)StaticGameState.nameD + " Jr.", passage130_Fragment_3);
            Console.Write("</hook>");
            Console.WriteLine();
            Console.WriteLine();
        }

        if (StaticGameState.players > 4)
        {
            Console.Write("<hook>");
            optionsManager.AddOption("Dr. " + (string)StaticGameState.nameE + " Jr.", passage130_Fragment_4);
            Console.Write("</hook>");
            Console.WriteLine();
        }

        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage130_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.hospsign = StaticGameState.nameA;
        if (StaticGameState.hospsign == StaticGameState.nameA && StaticGameState.hospA == "yes")
        {
            MethodHospitalVisitReject();
        }
        else if (StaticGameState.hospsign == StaticGameState.nameB && StaticGameState.hospB == "yes")
        {
            MethodHospitalVisitReject();
        }
        else if (StaticGameState.hospsign == StaticGameState.nameC && StaticGameState.hospC == "yes")
        {
            MethodHospitalVisitReject();
        }
        else if (StaticGameState.hospsign == StaticGameState.nameD && StaticGameState.hospD == "yes")
        {
            MethodHospitalVisitReject();
        }
        else if (StaticGameState.hospsign == StaticGameState.nameE && StaticGameState.hospE == "yes")
        {
            MethodHospitalVisitReject();
        }
        else
        {
            MethodHospitalVisitCheck2();
        }

        optionsManager.PresentOptions();
    }

    private static void passage130_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.hospsign = StaticGameState.nameB;
        if (StaticGameState.hospsign == StaticGameState.nameA && StaticGameState.hospA == "yes")
        {
            MethodHospitalVisitReject();
        }
        else if (StaticGameState.hospsign == StaticGameState.nameB && StaticGameState.hospB == "yes")
        {
            MethodHospitalVisitReject();
        }
        else if (StaticGameState.hospsign == StaticGameState.nameC && StaticGameState.hospC == "yes")
        {
            MethodHospitalVisitReject();
        }
        else if (StaticGameState.hospsign == StaticGameState.nameD && StaticGameState.hospD == "yes")
        {
            MethodHospitalVisitReject();
        }
        else if (StaticGameState.hospsign == StaticGameState.nameE && StaticGameState.hospE == "yes")
        {
            MethodHospitalVisitReject();
        }
        else
        {
            MethodHospitalVisitCheck2();
        }

        optionsManager.PresentOptions();
    }

    private static void passage130_Fragment_2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.hospsign = StaticGameState.nameC;
        if (StaticGameState.hospsign == StaticGameState.nameA && StaticGameState.hospA == "yes")
        {
            MethodHospitalVisitReject();
        }
        else if (StaticGameState.hospsign == StaticGameState.nameB && StaticGameState.hospB == "yes")
        {
            MethodHospitalVisitReject();
        }
        else if (StaticGameState.hospsign == StaticGameState.nameC && StaticGameState.hospC == "yes")
        {
            MethodHospitalVisitReject();
        }
        else if (StaticGameState.hospsign == StaticGameState.nameD && StaticGameState.hospD == "yes")
        {
            MethodHospitalVisitReject();
        }
        else if (StaticGameState.hospsign == StaticGameState.nameE && StaticGameState.hospE == "yes")
        {
            MethodHospitalVisitReject();
        }
        else
        {
            MethodHospitalVisitCheck2();
        }

        optionsManager.PresentOptions();
    }

    private static void passage130_Fragment_3()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.hospsign = StaticGameState.nameD;
        if (StaticGameState.hospsign == StaticGameState.nameA && StaticGameState.hospA == "yes")
        {
            MethodHospitalVisitReject();
        }
        else if (StaticGameState.hospsign == StaticGameState.nameB && StaticGameState.hospB == "yes")
        {
            MethodHospitalVisitReject();
        }
        else if (StaticGameState.hospsign == StaticGameState.nameC && StaticGameState.hospC == "yes")
        {
            MethodHospitalVisitReject();
        }
        else if (StaticGameState.hospsign == StaticGameState.nameD && StaticGameState.hospD == "yes")
        {
            MethodHospitalVisitReject();
        }
        else if (StaticGameState.hospsign == StaticGameState.nameE && StaticGameState.hospE == "yes")
        {
            MethodHospitalVisitReject();
        }
        else
        {
            MethodHospitalVisitCheck2();
        }

        optionsManager.PresentOptions();
    }

    private static void passage130_Fragment_4()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.hospsign = StaticGameState.nameE;
        if (StaticGameState.hospsign == StaticGameState.nameA && StaticGameState.hospA == "yes")
        {
            MethodHospitalVisitReject();
        }
        else if (StaticGameState.hospsign == StaticGameState.nameB && StaticGameState.hospB == "yes")
        {
            MethodHospitalVisitReject();
        }
        else if (StaticGameState.hospsign == StaticGameState.nameC && StaticGameState.hospC == "yes")
        {
            MethodHospitalVisitReject();
        }
        else if (StaticGameState.hospsign == StaticGameState.nameD && StaticGameState.hospD == "yes")
        {
            MethodHospitalVisitReject();
        }
        else if (StaticGameState.hospsign == StaticGameState.nameE && StaticGameState.hospE == "yes")
        {
            MethodHospitalVisitReject();
        }
        else
        {
            MethodHospitalVisitCheck2();
        }

        optionsManager.PresentOptions();
    }


    private static void MethodHospitalVisitCheck2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Carefully pick up the Storybook and do not allow any other players to see the screen.");
        Console.Write("</bold>");
        Console.WriteLine();
        StaticGameState.hospentry = StaticGameState.GetRandom(new[]
        {
            1,
            2
        });
        Console.WriteLine();
        if (StaticGameState.hospentry == 1)
        {
            Console.Write("<bold>");
            Console.Write("Visitation Report: Dr. ");
            Console.Write(StaticGameState.hospsign);
            Console.Write(" - Notes submitted by Nurse Varga");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("Dr. ");
            Console.Write(StaticGameState.hospsign);
            Console.Write(" seemed in a hurry. Dismissed each area as sterile and uninspired. Until we arrived at the operating room. Immediately became enraptured, fixated, and I had to thrice repeat myself before they responded.");
            Console.WriteLine();
            Console.WriteLine();
            if (StaticGameState.GetRandom(new[]
                {
                    1,
                    2
                }) == 1)
            {
                Console.Write("\"This is all wrong. What do they teach in these surgeon schools?\" Dr. ");
                Console.Write(StaticGameState.hospsign);
                Console.Write(
                    " asked, clearly not expecting an answer and brazenly entered the operating room to accost the surgeons on duty. They retrieved a scalpel and insisting on completing the operation themselves. I have never seen so much blood.");
            }
            else
            {
                Console.Write(
                    "Their response was muffled and I was unable to stop them from entering the theater. Their face was etched in a hideous grin as they stood at the center with their hands raised into the air. At this point, they either refused to listen or entered a catatonic state which left them motionless for nearly an hour.");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("At this point, ");
            Console.Write(StaticGameState.hospsign);
            Console.Write(" had to be escorted by security from the premises. They are barred from any further tours of the facilities.");
        }
        else
        {
            Console.Write("<bold>");
            Console.Write("Visitation Report: Dr. ");
            Console.Write(StaticGameState.hospsign);
            Console.Write(" - Notes submitted by Nurse Varga");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("Relatively uneventful visit, though unsettling. Dr. ");
            Console.Write(StaticGameState.hospsign);
            Console.Write(" requested a tour through the wards.");
            Console.WriteLine();
            Console.WriteLine();
            if (StaticGameState.GetRandom(new[]
                {
                    1,
                    2
                }) == 1)
            {
                Console.Write("Mostly disinterested and silent. However, our visit to the morgue was longer than to my liking. Dr. ");
                Console.Write(StaticGameState.hospsign);
                Console.Write(" kept insisting on inspecting the more extreme cases, excitedly asking questions while I unsuccessfully attempted to stop them from physically handling the deceased.");
            }
            else
            {
                Console.Write("At one juncture, Dr. ");
                Console.Write(StaticGameState.hospsign);
                Console.Write(
                    " approached a patient in the hallway that had been confined to a bath chair. Unprompted, they began a through examination of the individual, palpating their hairline and skull with their fingers. To my dismay, they were enraptured by a rash along the patients cheek which was covered in small protusions and red boils. They insisted on collecting several samples of the fluid they produced.");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("After requesting access to more severe emergency cases, we walked the grounds. They kept stating that the facilities were \"unimpressive compared to their own.\" I shudder to think on what that phrase means.");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click to continue...", passage131_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage131_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.hospcount = StaticGameState.hospcount + 1;
        if (StaticGameState.hospsign == StaticGameState.nameA)
        {
            StaticGameState.hospA = "yes";
        }
        else if (StaticGameState.hospsign == StaticGameState.nameB)
        {
            StaticGameState.hospB = "yes";
        }
        else if (StaticGameState.hospsign == StaticGameState.nameC)
        {
            StaticGameState.hospC = "yes";
        }
        else if (StaticGameState.hospsign == StaticGameState.nameD)
        {
            StaticGameState.hospD = "yes";
        }
        else if (StaticGameState.hospsign == StaticGameState.nameE)
        {
            StaticGameState.hospE = "yes";
        }

        MethodGen1InsanityNoExtraAction();
        optionsManager.PresentOptions();
    }
}