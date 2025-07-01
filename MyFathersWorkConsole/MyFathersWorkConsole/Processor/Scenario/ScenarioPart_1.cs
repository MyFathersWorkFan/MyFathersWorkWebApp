namespace MyFathersWorkConsole;

public static partial class Scenario
{
    private static void MethodTheBank()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Bank");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("Gain $2.");
        optionsManager.PresentOptions();
    }


    private static void MethodHospital()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Hospital");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("Look through the deck of your choice to find an Experiment of your choice and draw it into your hand. ");
        Console.Write("<italic>");
        Console.Write("(Once complete, shuffle the deck.)");
        Console.Write("</italic>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("You have until the beginning of your next turn to complete this action ");
        Console.Write("<italic>");
        Console.Write("(allow other players to begin their turn while you choose).");
        Console.Write("</italic>");
        optionsManager.PresentOptions();
    }


    private static void MethodHubertusWolves1()
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
        optionsManager.AddOption("Once you are ready", passage46_Fragment_1);
        Console.Write("</hook>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage46_Fragment_0()
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

    private static void passage46_Fragment_1()
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
        optionsManager.AddOption("join and pledge my service to your cause.", passage46_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("...have decided to ");
        optionsManager.AddOption("RefusalWolves", MethodRefusalWolves);
        optionsManager.PresentOptions();
    }

    private static void passage46_Fragment_2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Once you are ready", passage46_Fragment_1);
        optionsManager.PresentOptions();
    }


    private static void MethodCureMoonSick1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Moon Sickness");
        Console.Write("</bold>");
        Console.WriteLine();
        if (StaticGameState.round == 13)
        {
            Console.Write("What a horrible night to have a curse!");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(
                "They wrote of torn clothing, strange awakenings half-naked in the gardens at the edge of their Estate, of blood speckled about their boots and dried streaks from the corners of their lips. Lingering lucid memories of stalking prey in the woods haunted their dreams yet filled them with a terrible energy!");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(
                "When they discovered the eviscerated body of one of their servants skewered upon the metal fence that lined the grounds, the bestial teeth and claw marks told a new story. They steeled their mind against the distraction, recommitting themselves with deadly focus to the task at hand.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hook>");
            optionsManager.AddOption("Click to continue...", passage47_Fragment_0);
            Console.Write("</hook>");
        }
        else
        {
            Console.Write("They could not dwell on the news of yet another victim within their household for long as more pressing matters of scientific import weighed upon their every waking hour. ");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(
                "For theirs was a dismal, macabre occupation. They measured each moment in dark pen strokes, the incision of a sterilized blade, or the ebullition of glowing liquid in a graduated flask. The loss of a servant was unfortunate, not for the life it represented, but for the distinct lapse in efficiency procuring a new servant would cause.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<hook>");
            optionsManager.AddOption("Click to continue...", passage47_Fragment_2);
            Console.Write("</hook>");
        }

        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage47_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", MethodHuntround1);
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "CompulsionBack";
        Console.WriteLine();
        Console.Write("All players with a ");
        Console.Write("<bold>");
        Console.Write("Disease Experiment");
        Console.Write("</bold>");
        Console.Write(" in their Stored Experiments ");
        Console.Write("<bold>");
        Console.Write("draw a Compulsion and gain a Body.");
        Console.Write("</bold>");
        Console.Write("</setupStyleEvnt>");
        Console.WriteLine();
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage47_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage47_Fragment_0);
        optionsManager.PresentOptions();
    }

    private static void passage47_Fragment_2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", MethodMayorResolveHunters);
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "CompulsionBack";
        Console.WriteLine();
        Console.Write("All players with a ");
        Console.Write("<bold>");
        Console.Write("Disease Experiment");
        Console.Write("</bold>");
        Console.Write(" in their Stored Experiments ");
        Console.Write("<bold>");
        Console.Write("draw a Compulsion and gain a Body.");
        Console.Write("</bold>");
        Console.Write("</setupStyleEvnt>");
        Console.WriteLine();
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage47_Fragment_3()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage47_Fragment_2);
        optionsManager.PresentOptions();
    }


    private static void Methodbar1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("SWORN STATEMENT - Case ");
        Console.Write(new Random().Next(1, 999 + 1));
        Console.Write(" -HDG- ");
        Console.Write(new Random().Next(1, 999 + 1));
        Console.Write("</bold>");
        Console.WriteLine();
        StaticGameState.bar1 = StaticGameState.GetRandom(new[]
        {
            1,
            2
        });
        Console.WriteLine();
        if (StaticGameState.bar1 == 1)
        {
            Console.Write("After a brief excursion to the local pub, I happened to engage in a spirited conversation with the ");
            Console.Write("<bold>");
            Console.Write("Blacksmith’s");
            Console.Write("</bold>");
            Console.Write(
                " son. Being slightly out of my wits, his slightly improper offer to accompany him home to his chateau for further libations appealed. We engaged in a delightful conversation, so intriguing in fact, that I accepted his generous offer of temporary lodging for the evening. I will spare the details of our respectable and entirely benign conversation.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(
                "We both decided to disrobe as any person would when making nightly preparations for sleep. Regrettably, though I cannot recollect how it occurred, the Blacksmith was unpleased to discover us similarly nude and entwined in this state the next morning, surrounded by several defiled tools from the forge. Our family’s reputation was certainly sullied at the Blacksmith and I resolved to avoid it in the future.");
        }
        else
        {
            Console.Write("After a brief excursion to the local pub, I happened to engage in a spirited conversation with the ");
            Console.Write("<bold>");
            Console.Write("Blacksmith’s");
            Console.Write("</bold>");
            Console.Write(
                " daughter. While I am unable to discern the reasoning behind my actions, I have since apologized for my repeated comments besmirching her virtuous nature; comments which apparently resulted in a minor altercation with a gentlemen or two at the fine establishment.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(
                "It was around midnight that I decided to make a quiet exit, in order to properly avoid any further antagonism. My clothes, soiled and bloodied by the ensuing brawl, were found discarded along the muddy trek to the Blacksmith's forge. While I have no recollection of the ensuing events, multiple witnesses attest that I then proceeded to brand the blacksmith's dog and passed out naked in the slack tub. Our family’s reputation was certainly sullied at the Blacksmith and I resolved to avoid it in the future.");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<setupStyle>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "Creepy_Icon";
        Console.WriteLine();
        Console.Write("Place a ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("token on the ");
        Console.Write("<bold>");
        Console.Write("Blacksmith");
        Console.Write("</bold>");
        Console.Write(". When a player takes an action at this location, they ");
        Console.Write("<bold>");
        Console.Write("gain 1 ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("for every ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("token on that location.");
        Console.Write("</setupStyle>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void Methodbar2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("SWORN STATEMENT - Case ");
        Console.Write(new Random().Next(1, 999 + 1));
        Console.Write("-HDG-");
        Console.Write(new Random().Next(1, 999 + 1));
        Console.Write("</bold>");
        Console.WriteLine();
        StaticGameState.bar2 = StaticGameState.GetRandom(new[]
        {
            1,
            2
        });
        Console.WriteLine();
        if (StaticGameState.bar2 == 1)
        {
            Console.Write(
                "While many first-hand accounts from the townsfolk may not corroborate my story, I cannot conceal my disgust with the insinuation. The stable hand and I were simply enjoying a midnight ride in the nearby beet fields in the spirit of the season. Due to my enhanced state of inebriation, I may have chosen the incorrect steed for our excursion.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(
                "I awoke in the stables beside my porcine companion, who had been outfitted with a leather riding saddle. The gate to their pen had been left open and the entire pig population of the town was scattered throughout the streets.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(
                "I would also like to note that the charges of public nudity against me are warrantless, as upon discovery of my predicament that morning, I hastily endeavored to hide my shame and purchase new clothing from a local tailor as would be customary in such a situation. Our family’s reputation was certainly sullied at the ");
            Console.Write("<bold>");
            Console.Write("Farmer’s Market");
            Console.Write("</bold>");
            Console.Write(" and I resolved to avoid it in the future.");
        }
        else
        {
            Console.Write(
                "I find the accusations toward my conduct and character most disturbing. To insinuate that I was openly consorting with individuals of ill-repute and offered compensation for illicit activities, why it is as absurd as the other charges against me from that evening.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(
                "While I admit to having a few additional libations, it is most presumptuous to believe that just because I was found near the open door of my carriage in the buff, covered in tomato paste, with lipstick impressions across the entirety of my form, that I would be held responsible for the debasing of a bushel of cherry tomatoes and several other vegetable stocks.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Despite my personal objections, I have summarily reimbursed the stall owner for their produce and discretion in the matter. Our family’s reputation was certainly sullied at the ");
            Console.Write("<bold>");
            Console.Write("Farmer’s Market");
            Console.Write("</bold>");
            Console.Write(" and I resolved to avoid it in the future.");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<setupStyle>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "Creepy_Icon";
        Console.WriteLine();
        Console.Write("Place a ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("token on the ");
        Console.Write("<bold>");
        Console.Write("Farmer's Market");
        Console.Write("</bold>");
        Console.Write(". When a player takes an action at this location, they ");
        Console.Write("<bold>");
        Console.Write("gain 1 ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("for every ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("token on that location.");
        Console.Write("</setupStyle>");
        optionsManager.PresentOptions();
    }


    private static void Methodbar3()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("SWORN STATEMENT - Case ");
        Console.Write(new Random().Next(1, 999 + 1));
        Console.Write("-HDG-");
        Console.Write(new Random().Next(1, 999 + 1));
        Console.Write("</bold>");
        Console.WriteLine();
        StaticGameState.bar3 = StaticGameState.GetRandom(new[]
        {
            1,
            2
        });
        Console.WriteLine();
        if (StaticGameState.bar3 == 1)
        {
            Console.Write("It was very much in poor taste for a ");
            Console.Write("<bold>");
            Console.Write("fortune teller");
            Console.Write("</bold>");
            Console.Write(
                " to summarily dismiss my romantic advances given my current social status and level of wealth. However, I admit that my inebriated reaction to steal and destroy her Tarot deck was highly juvenile. And the public defiling of said Tarot cards afterwards was certainly not in keeping with the standards of my aristocratic upbringing.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(
                "I have since reimbursed the Fortune Teller for her ruined Tarot cards, and apologized to the Sheriff for my display of public nudity. Our family’s reputation was certainly sullied at the Fortune Teller and I resolved to avoid it in the future.");
        }
        else
        {
            Console.Write(
                "During a spirited conversation at the local pub, I was informed of a fine establishment with premium snuff and tobacco on the outskirts of town. While I cannot recall if I partook, I was made aware that this establishment promoted opium use, which is a vile indulgence indeed. Sadly, I admit poor judgement in not exiting the premises immediately upon this discovery and my subsequent refusal to leave after four hours had elapsed.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(
                "An exchange of bitter words may have occurred, which resulted in myself yelling expletives and unfortunate ethnic slurs which I would dare not repeat. At some point my clothes had vanished, so I was at a distinct physical disadvantage when I was swiftly removed from the area, not without sustaining several bruises from the scuffle (which, to note, I have not pressed charges for). Our family’s reputation was certainly sullied at the ");
            Console.Write("<bold>");
            Console.Write("Fortune Teller");
            Console.Write("</bold>");
            Console.Write(" and I resolved to avoid it in the future.");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<setupStyle>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "Creepy_Icon";
        Console.WriteLine();
        Console.Write("Place a ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("token on the ");
        Console.Write("<bold>");
        Console.Write("Fortune Teller");
        Console.Write("</bold>");
        Console.Write(". When a player takes an action at this location, they ");
        Console.Write("<bold>");
        Console.Write("gain 1 ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("for every ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("token on that location.");
        Console.Write("</setupStyle>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void Methodbar4()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("SWORN STATEMENT - Case ");
        Console.Write(new Random().Next(1, 999 + 1));
        Console.Write("-HDG-");
        Console.Write(new Random().Next(1, 999 + 1));
        Console.Write("</bold>");
        Console.WriteLine();
        StaticGameState.bar4 = StaticGameState.GetRandom(new[]
        {
            1,
            2
        });
        Console.WriteLine();
        if (StaticGameState.bar4 == 1)
        {
            Console.Write("The celebration had been exceedingly rowdy. I could not recall whose birthday or anniversary was being celebrated, but I could remember my celebratory stilted walk to the ");
            Console.Write("<bold>");
            Console.Write("General Store");
            Console.Write("</bold>");
            Console.Write(" near midnight. In my admittedly intoxicated state, I required sustenance.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(
                "Unfortunately, my hunger pangs may have overtaken my sensibilities. A rock may have been plunged through the front window, and I may have been discovered the next morning by the constabulary, passed out naked on the wooden floor, surrounded by several empty cartons of canned sardines, the contents of which may have been returned to the same general area in a more semi-digested form. Our family’s reputation was certainly sullied at the General Store and I resolved to avoid it in the future.");
        }

        if (StaticGameState.bar4 == 2)
        {
            Console.Write(
                "The proprietors of the General Store, Hagen and Mabel Varga, are respectable, upstanding citizens of whom I have a deep respect. Their fine emporium of quality products is a grand example of successful private business ownership that positively serves the community.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(
                "My unfortunate public statements to the contrary in a loud and admittedly inebriated state were categorically untrue and misinformed. My subsequent scrawling of expletives upon their business' front window - with a crude writing medium that I will not elaborate upon - was brash and reckless.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("I regret that my nude form was discovered curled up at their doorstep by the constabulary. Our family’s reputation was certainly sullied at the General Store and I resolved to avoid it in the future.");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<setupStyle>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "Creepy_Icon";
        Console.WriteLine();
        Console.Write("Place a ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("token on the ");
        Console.Write("<bold>");
        Console.Write("General Store");
        Console.Write("</bold>");
        Console.Write(". When a player takes an action at this location, they ");
        Console.Write("<bold>");
        Console.Write("gain 1 ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("for every ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("token on that location.");
        Console.Write("</setupStyle>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void Methodbar5()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("SWORN STATEMENT - Case ");
        Console.Write(new Random().Next(1, 999 + 1));
        Console.Write("-HDG-");
        Console.Write(new Random().Next(1, 999 + 1));
        Console.Write("</bold>");
        Console.WriteLine();
        StaticGameState.bar5 = StaticGameState.GetRandom(new[]
        {
            1,
            2
        });
        Console.WriteLine();
        if (StaticGameState.bar5 == 1)
        {
            Console.Write(
                "I vaguely remember the phrase that began the argument, but the stitches above my left eye from a shattered glass mug jogged my recollection of the ensuing brawl. A quick nightcap turned into an extended stay of tumbled barstools, belligerence, and wild accusations. My injuries must have been extensive as my memory ceased soon after.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(
                "My displeased spouse informed me that I was currently the height of gossip within the town. First-hand accounts - of which I cannot confirm given my state of awareness - described how I spat blood in a nurse’s face, tore off my leggings (and undergarments), tried to punch the vicar thrice, and defiled myself in the lobby. Our family’s reputation was certainly sullied at the ");
            Console.Write("<bold>");
            Console.Write("Hospital");
            Console.Write("</bold>");
            Console.Write(" and I resolved to avoid it in the future.");
        }

        if (StaticGameState.bar5 == 2)
        {
            Console.Write(
                "I should not have attempted to perform a surgical procedure in my state. Nor should I have locked myself in the surgical arena with a patient, barred the door, and undressed, dousing myself in a carbolic acid solution for the purposes of sterilization. However, my honor had been questioned at the pub and I deemed it only necessary to demonstrate my surgical prowess.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(
                "The demonstration of my experimentation capabilities - which are normally formidable, I might add - turned into a series of unfortunate mishaps and misunderstandings. The unfortunate patient has since made a full recovery and has already received a generous stipend in recompense and the hospital a donation with which to cleanse the arena of the admittedly large quantity of blood on the walls, seating, instruments, and ceiling. Our family’s reputation was certainly sullied at the ");
            Console.Write("<bold>");
            Console.Write("Hospital");
            Console.Write("</bold>");
            Console.Write(" and I resolved to avoid it in the future.");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<setupStyle>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "Creepy_Icon";
        Console.WriteLine();
        Console.Write("Place a ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("token on the ");
        Console.Write("<bold>");
        Console.Write("Hospital");
        Console.Write("</bold>");
        Console.Write(". When a player takes an action at this location, they ");
        Console.Write("<bold>");
        Console.Write("gain 1 ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("for every ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("token on that location.");
        Console.Write("</setupStyle>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void Methodbar6()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("SWORN STATEMENT - Case ");
        Console.Write(new Random().Next(1, 999 + 1));
        Console.Write("-HDG-");
        Console.Write(new Random().Next(1, 999 + 1));
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "Although witnesses claim that I had carried a makeshift torch several blocks to the destination, my ignition of nearby gasoline reserves was entirely accidental. My intent, of course, was a comical reenactment of the wiles of recent angry mobs; clearly satirical in nature. A vaudevillian parody. However, the French performance art overtones due to my regrettable nudity were not considered with high regard. The resulting blaze that consumed over half of the Laborer’s Union building that night was also not met with the warmest of receptions.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Honestly, the Laborer’s Union building had not been updated for years. It was overdue for renovations. However, our family’s reputation was certainly sullied at the ");
        Console.Write("<bold>");
        Console.Write("Laborer’s Union");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("and I resolved to avoid it in the future.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<setupStyle>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "Creepy_Icon";
        Console.WriteLine();
        Console.Write("Place a ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("token on the ");
        Console.Write("<bold>");
        Console.Write("Laborer's Union");
        Console.Write("</bold>");
        Console.Write(". When a player takes an action at this location, they ");
        Console.Write("<bold>");
        Console.Write("gain 1 ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("for every ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("token on that location.");
        Console.Write("</setupStyle>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void Methodbar7()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("SWORN STATEMENT - Case ");
        Console.Write(new Random().Next(1, 999 + 1));
        Console.Write("-HDG-");
        Console.Write(new Random().Next(1, 999 + 1));
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "While the cemetery has certainly been a crucial source of ingredients for my experiments - acquired by pruning local flora and herbs - calling attention to this fact very loudly while inside the local pub was probably a mistake. Openly inviting all patrons to join me in the cemetery to kick over headstones and then running directly to said location to do so was a clear error of judgement. My alleged indecent exposure whilst doing so, also unfortunate.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("After being treated for a sprained ankle, I spent a night half-remembered in the local police station. Our family’s reputation was certainly sullied at the ");
        Console.Write("<bold>");
        Console.Write("Cemetery");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("and I resolved to avoid it in the future.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<setupStyle>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "Creepy_Icon";
        Console.WriteLine();
        Console.Write("Place a ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("token on the ");
        Console.Write("<bold>");
        Console.Write("Cemetery");
        Console.Write("</bold>");
        Console.Write(". When a player takes an action at this location, they ");
        Console.Write("<bold>");
        Console.Write("gain 1 ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("for every ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("token on that location.");
        Console.Write("</setupStyle>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void Method4Note()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("Big Things Needed:");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Place and Hook up triggers for example.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("CREEPY 4");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Hunters = Evil");
        Console.WriteLine();
        Console.Write("$2 > Gain $2. > Start of Gen 2 Angry Mob moves 1.");
        Console.WriteLine();
        Console.Write("No > 50% Lose 1 Creepy. > Gain SHRINE");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Wolves = Evil");
        Console.WriteLine();
        Console.Write("Perform Experiment > Perform Experiment. > Start of Gen 2 Angry Mob moves 1.");
        Console.WriteLine();
        Console.Write("No > 50% Lose 1 Creepy. > Gain READING ROOM");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("SANITY 3");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Yes > Pay $1. Gain Knowledge. Discard a Compulsion to Gain 1 more Knowledge. > Gen2 Start, Gain a Maladjustment / Lose 3VP.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("No > Gain 1 Creepy and $1. / Gain Nothing > Gen2 Extra Refusal Action = OR Gen2 Extra Hospital Action");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("(could make another option if they don't refuse, but good for now)");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Needs 1 or 2 Storybook tokens with consequence passages. Look in notes.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Mayor Token Bonus/Negative for 3rd Generation (could be different for Library or Bank choice)");
        Console.WriteLine();
        Console.Write("Charity Token Bonus/Negative for 3rd Generation");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Immortality Bonus/Negative for 3rd Generation. (could be different for choosing Engineering, Chemistry, Biology, Occult)");
        Console.WriteLine();
        Console.Write("Disease Bonus/Negative for 2nd Gen and 3rd Generation. (could be different for Hunters or Wolves)");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Go through and ADD pass the start player marker 1 additional time: At the start of every Generation.");
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.players == 3)
        {
            Console.Write("Pass the Start Player marker to the next player in clockwise order 1 additional time.");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Probably should have a card or token for +2 points (Chem, Eng, Bio, Occ)");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(StaticGameState.mayor);
        Console.WriteLine();
        Console.Write(StaticGameState.charity);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodUnicure()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Carefully hand the Storybook to ");
        Console.Write(StaticGameState.fevercure);
        Console.Write(". This choice is read and made within view all players.");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Local Scientist Discovers Inoculation for Yellow Fever");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write(
            "The local headlines were inevitable. While history may ascribe a later date to this monumental event due to the volatile nature of simply injecting oneself with the viscous black and yellow vomit of an infected individual, it was an unsettling leap forward in our understanding of antibodies and herd immunity.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("The scientific establishment");
        if (StaticGameState.uni == "no")
        {
            Console.Write(", although pensive about my recent lecture, ");
        }

        Console.Write("was thrilled by the discovery of a cure for the pervasive disease. Dr. ");
        Console.Write(StaticGameState.fevercure);
        Console.Write(" ");
        Console.Write(
            "Jr. was urged to release their curious methodology in a series of published journal entries to offer peer review and additional critique. However, they were reticent to immediately share findings before obtaining a patent. This knowledge could provide a lucrative financial outlet.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Make a Choice to Publish or Patent");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("To ");
        Console.Write("<bold>");
        Console.Write("publish");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("the cure in a medical journal and ");
        Console.Write("<bold>");
        Console.Write("gain ");
        Console.Write(StaticGameState.fevervp);
        Console.Write("VP");
        Console.Write("</bold>");
        Console.Write(", ");
        optionsManager.AddOption("Unicure1", MethodUnicure1);
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("To ");
        Console.Write("<bold>");
        Console.Write("patent");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("the cure and sell the process to world governments and ");
        Console.Write("<bold>");
        Console.Write("gain $");
        Console.Write(StaticGameState.fevermoney);
        Console.Write("</bold>");
        Console.Write(", ");
        optionsManager.AddOption("Unicure2", MethodUnicure2);
        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodPanacea()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("A Cure for All");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write(
            "It seemed that finally, after years of tireless dedication, a solution to the ails of all men had been formulated. The family was divided on the efficacy of this course of action, but one individual forged ahead recklessly, headless to their warnings.");
        Console.WriteLine();
        StaticGameState.twopage = 1;
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Which individual completed the Panacea Experiment?");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Dr. " + (string)StaticGameState.nameA + " Jr.", passage57_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Dr. " + (string)StaticGameState.nameB + " Jr.", passage57_Fragment_1);
        Console.Write("</hook>");
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.players > 2)
        {
            Console.Write("<hook>");
            optionsManager.AddOption("Dr. " + (string)StaticGameState.nameC + " Jr.", passage57_Fragment_2);
            Console.Write("</hook>");
            Console.WriteLine();
            Console.WriteLine();
        }

        if (StaticGameState.players > 3)
        {
            Console.Write("<hook>");
            optionsManager.AddOption("Dr. " + (string)StaticGameState.nameD + " Jr.", passage57_Fragment_3);
            Console.Write("</hook>");
            Console.WriteLine();
            Console.WriteLine();
        }

        if (StaticGameState.players > 4)
        {
            Console.Write("<hook>");
            optionsManager.AddOption("Dr. " + (string)StaticGameState.nameE + " Jr.", passage57_Fragment_4);
            Console.Write("</hook>");
            Console.WriteLine();
        }

        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage57_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.panacure = StaticGameState.nameA;
        MethodPanaceaMessage();
        optionsManager.PresentOptions();
    }

    private static void passage57_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.panacure = StaticGameState.nameB;
        MethodPanaceaMessage();
        optionsManager.PresentOptions();
    }

    private static void passage57_Fragment_2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.panacure = StaticGameState.nameC;
        MethodPanaceaMessage();
        optionsManager.PresentOptions();
    }

    private static void passage57_Fragment_3()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.panacure = StaticGameState.nameD;
        MethodPanaceaMessage();
        optionsManager.PresentOptions();
    }

    private static void passage57_Fragment_4()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.panacure = StaticGameState.nameE;
        MethodPanaceaMessage();
        optionsManager.PresentOptions();
    }


    private static void MethodPanacea1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("A Weapon Published");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write(
            "In a shocking display of altruism, the findings were published in a series of medical journals at the behest of the university's administration. The published work was controversial, but considered revolutionary, as the strength of the failed ");
        Console.Write("<bold>");
        Console.Write("Panacea");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("had several alternative applications.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "The local population, while grateful for the additional tourism, were less than consoled. As much as it was innovative, it was also a secretly manufactured chemical so devastating that all organic matter deteriorated within minutes of it's application.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click to continue...", passage58_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage58_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.WriteLine();
        optionsManager.AddOption("Continue...", ((StaticGameState.round == 7) ? MethodHospital1 : ((StaticGameState.round == 8) ? MethodHospital2 : MethodHospital3)));
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "S1_Pancea";
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Gain ");
        Console.Write(StaticGameState.GetRandom(new[]
        {
            2,
            3,
            4
        }));
        Console.Write("VP.");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("Also, Gain ");
        Console.Write("<bold>");
        Console.Write("1");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write(".");
        Console.Write("</setupStyleEvnt>");
        optionsManager.PresentOptions();
    }

    private static void passage58_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage58_Fragment_0);
        optionsManager.PresentOptions();
    }


    private static void MethodPanaceaTooOld()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Too Old");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("With only a few years left in their existence, and hence the existence of their familial rivals, ");
        Console.Write(StaticGameState.panacure);
        Console.Write(" ");
        Console.Write("realized that it was too late for their creation to have a critical effect on their endeavors.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("This crucial realization was certainly prompted by the entire reserves of the concoction being exhausted one evening when testing the local livestock. Ah, how the mind fades with old age!");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click to continue...", passage59_Fragment_0);
        Console.Write("</hook>");
        optionsManager.PresentOptions();
    }

    private static void passage59_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", MethodHospital3);
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "S1_Pancea";
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Move forward 1 space on the ");
        Console.Write("<sprite=\"Insanity_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("Track.");
        Console.Write("</bold>");
        Console.Write("</setupStyleEvnt>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage59_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage59_Fragment_0);
        optionsManager.PresentOptions();
    }


    private static void MethodPanaceaUnleash()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("\"April Fools Day\" - Journal Entry - 1882");
        if (StaticGameState.panacure == StaticGameState.nameA)
        {
            StaticGameState.tempjournal = StaticGameState.nameB;
        }
        else
        {
            StaticGameState.tempjournal = StaticGameState.nameA;
        }

        Console.Write(" ");
        Console.Write(StaticGameState.tempjournal);
        Console.Write(" ");
        Console.Write("Jr.");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write(
            "It was a fine summer morning when I heard a piercing scream from the garden. While I had grown relatively accustomed to this cry of distress in my experimentations, it was decidedly peculiar to hear the sound over morning coffee and crepes.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "After sashing my robe about me, I exited the manor in time to witness the final moments of a servant tending to the trimming. With a quick lurch, they turned towards me, now beyond sound as their facial features collapsed inwardly. Sanguine chunks of flesh fell to the ground and sizzled like bacon grease on the grass. Within seconds, the human figure that once tended to our garden was a sloshy pile of pink and white froth on the lawn and whatever substance had caused it had seeped deep into the ground, creating a considerable hole in the landscaping.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("I took a sip of coffee and examined a nearby glass vial labeled as \"vital elixir for use in the prevention of disease.\" I recognized our dear cousin's penmanship instantly; the prankster!");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("However, unfortunately, another servant stood slack-jawed near the gate, having witnessed the entire spectacle. It would be difficult to replace this worker.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click to continue...", passage60_Fragment_0);
        Console.Write("</hook>");
        optionsManager.PresentOptions();
    }

    private static void passage60_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.WriteLine();
        optionsManager.AddOption("Continue...", MethodHospital3);
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "S1_Pancea";
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("The player who completed the Panacea Experiment moves forward one space on the ");
        Console.Write("<sprite=\"Insanity_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("Track.");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("All other players must immediately return one Servant piece to the game box. This piece cannot be hired again.");
        Console.Write("</bold>");
        Console.Write("</setupStyleEvnt>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage60_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage60_Fragment_0);
        optionsManager.PresentOptions();
    }


    private static void MethodSymposiumEvent3()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("The Fate of the Lecture Series");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write(
            "If it amounted to anything, those in attendance were certainly astonished by the eccentricities witnessed that day. Some weaker-willed individuals were prone to nausea and fainting spells during the speeches, clearly in deference to the astounding breadth of visionary experimentation.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("But, were their efforts enough to sway the most notable scientific minds of the time?");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("SYMPOSIUM RESULT");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Add up the total number of ");
        Console.Write(StaticGameState.sci3);
        Console.Write(" ");
        Console.Write("Experiments completed by ALL players.");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("If the total is less than ");
        Console.Write("<bold>");
        Console.Write(StaticGameState.symp);
        Console.Write("</bold>");
        Console.Write(", ");
        optionsManager.AddOption("SymposiumFail", MethodSymposiumFail);
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("If the total is equal to or greater than ");
        Console.Write("<bold>");
        Console.Write(StaticGameState.symp);
        Console.Write("</bold>");
        Console.Write(", ");
        optionsManager.AddOption("SymposiumMiddle", MethodSymposiumMiddle);
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("However, if the total is equal to or greater than ");
        Console.Write("<bold>");
        if (StaticGameState.players == 2)
        {
            Console.Write(StaticGameState.symp + 2);
        }
        else if (StaticGameState.players == 3)
        {
            Console.Write(StaticGameState.symp + 2);
        }
        else if (StaticGameState.players == 4)
        {
            Console.Write(StaticGameState.symp + 3);
        }
        else if (StaticGameState.players == 5)
        {
            Console.Write(StaticGameState.symp + 4);
        }
        else
        {
            Console.Write(StaticGameState.symp + 2);
        }

        Console.Write("</bold>");
        Console.Write(", ");
        optionsManager.AddOption("SymposiumSuccess", MethodSymposiumSuccess);
        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodUnicure2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Patented!");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write(StaticGameState.fevercure);
        Console.Write(" ");
        Console.Write("Jr. was known for their incisive wit and even more acute business dealings. Shirking the potential admiration of medical elites, ");
        Console.Write(StaticGameState.fevercure);
        Console.Write(" ");
        Console.Write(
            "hastily submitted a patent for this breakthrough in disease prevention. While it ensured a hefty sum for royalties, the locals eyed this new development as yet another attempt by aloof eccentrics to toy with the lives of the poor and their wariness increased.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click to continue...", passage62_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage62_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.pub = "no";
        StaticGameState.cured = 1;
        optionsManager.AddOption("Continue...", MethodPanaceaIntro);
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "AngryMob_Icon";
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Gain $");
        Console.Write(StaticGameState.fevermoney);
        Console.Write(".");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("Then, move the ");
        Console.Write("<sprite=\"AngryMob_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("marker ");
        Console.Write("<bold>");
        Console.Write("1 space");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("to the ");
        Console.Write("<bold>");
        Console.Write("left.");
        Console.Write("</bold>");
        Console.Write("</setupStyleEvnt>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage62_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage62_Fragment_0);
        optionsManager.PresentOptions();
    }


    private static void MethodUnicure1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Published!");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("While inevitably the findings were deemed underdeveloped by the prevailing medical institutions, the discussion they set forth resulted in the name ");
        Console.Write(StaticGameState.fevercure);
        Console.Write(" ");
        Console.Write("being bandied about for years to come. The release of this knowledge even had a minor sedative effect on the locals; those poor, gullible wretches.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click to continue...", passage63_Fragment_0);
        Console.Write("</hook>");
        optionsManager.PresentOptions();
    }

    private static void passage63_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.pub = "yes";
        StaticGameState.cured = 1;
        optionsManager.AddOption("Continue...", MethodPanaceaIntro);
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "AngryMob_Icon";
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Gain ");
        Console.Write(StaticGameState.fevervp);
        Console.Write("VP.");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("Then, move the ");
        Console.Write("<sprite=\"AngryMob_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("marker ");
        Console.Write("<bold>");
        Console.Write("2 spaces");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("to the right.");
        Console.Write("</setupStyleEvnt>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage63_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage63_Fragment_0);
        optionsManager.PresentOptions();
    }


    private static void MethodLosingOrderAid()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        if (StaticGameState.society == "Order of St. Hubertus")
        {
            if (StaticGameState.hcount == 0)
            {
                MethodEvilWolvesEventStart();
            }
            else
            {
                Console.Write("<bold>");
                Console.Write("Despite the Hunters' Loss");
                Console.Write("</bold>");
                Console.WriteLine();
                Console.Write(
                    "It was during a period of adjustment to their new surroundings that customary preparations were made to redecorate the west wing of the manor in a more modern style to which they were accustomed. Expecting a delivery of druggets from a Persian carpeter, instead they were greeted by a strapping young man in a burgundy leather coat. He tipped his wide-brimmed hat solemnly.");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write(
                    "\"Your family has made a contribution to our Fraternity and we are here to repay that debt through service,\" the young man stated, pulling back his shirt sleeve to reveal a tattoo of a bow and arrow. He then exited to the servant's quarters without further instruction.");
                Console.WriteLine();
                Console.WriteLine();
                if (StaticGameState.allyA != "hunters" && StaticGameState.allyB != "hunters" && StaticGameState.allyC != "hunters" && StaticGameState.allyD != "hunters")
                {
                    optionsManager.AddOption("EvilWolvesEventStart", MethodEvilWolvesEventStart);
                }
                else
                {
                    Console.Write("<hook>");
                    optionsManager.AddOption("Click to continue...", passage64_Fragment_0);
                    Console.Write("</hook>");
                }
            }
        }
        else if (StaticGameState.wcount == 0)
        {
            MethodTaxesEventStart();
        }
        else
        {
            Console.Write("<bold>");
            Console.Write("Despite the wolves' Loss");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write(
                "It was during a period of adjustment to their new surroundings that customary preparations were made to redecorate the west wing of the manor in a more modern style to which they were accustomed. Expecting a delivery of druggets from a Turkish carpeter, instead they were greeted by a strapping young man in a gray cloak. He tipped his fur cap solemnly.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(
                "\"Your family has made a contribution to our Order and we are here to repay that debt through service,\" the young man stated, pulling back his shirt sleeve to reveal a tattoo of a wolf's head. He then exited to the servant's quarters without further instruction.");
            Console.WriteLine();
            Console.WriteLine();
            if (StaticGameState.allyA != "wolves" && StaticGameState.allyB != "wolves" && StaticGameState.allyC != "wolves" && StaticGameState.allyD != "wolves")
            {
                optionsManager.AddOption("TaxesEventStart", MethodTaxesEventStart);
            }
            else
            {
                Console.Write("<hook>");
                optionsManager.AddOption("Click to continue...", passage64_Fragment_2);
                Console.Write("</hook>");
            }
        }

        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage64_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", MethodEvilWolvesEventStart);
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "GainServantFromLost";
        Console.WriteLine();
        if (StaticGameState.allyA == "hunters")
        {
            Console.Write(StaticGameState.nameA);
            Console.Write(" III ");
            Console.Write("<bold>");
            Console.Write("immediately gains 1 Servant from Lost and $1");
            Console.Write("</bold>");
            Console.Write(".");
            Console.WriteLine();
        }

        if (StaticGameState.allyB == "hunters")
        {
            Console.Write(StaticGameState.nameB);
            Console.Write(" III ");
            Console.Write("<bold>");
            Console.Write("immediately gains 1 Servant from Lost and $1");
            Console.Write("</bold>");
            Console.Write(".");
            Console.WriteLine();
        }

        if (StaticGameState.allyC == "hunters")
        {
            Console.Write(StaticGameState.nameC);
            Console.Write(" III ");
            Console.Write("<bold>");
            Console.Write("immediately gains 1 Servant from Lost and $1");
            Console.Write("</bold>");
            Console.Write(".");
            Console.WriteLine();
        }

        if (StaticGameState.allyD == "hunters")
        {
            Console.Write(StaticGameState.nameD);
            Console.Write(" III ");
            Console.Write("<bold>");
            Console.Write("immediately gains 1 Servant from Lost and $1");
            Console.Write("</bold>");
            Console.Write(".");
            Console.WriteLine();
        }

        if (StaticGameState.allyE == "hunters")
        {
            Console.Write(StaticGameState.nameE);
            Console.Write(" III ");
            Console.Write("<bold>");
            Console.Write("immediately gains 1 Servant from Lost and $1");
            Console.Write("</bold>");
            Console.Write(".");
            Console.WriteLine();
        }

        if (StaticGameState.allyA != "hunters" && StaticGameState.allyB != "hunters" && StaticGameState.allyC != "hunters" && StaticGameState.allyD != "hunters")
        {
            Console.Write(StaticGameState.nameA);
            Console.Write(" III ");
            Console.Write("<bold>");
            Console.Write("immediately gains 1 Servant from Lost and $1");
            Console.Write("</bold>");
            Console.Write(".");
            Console.WriteLine();
        }

        Console.Write("</setupStyleEvnt>");
        optionsManager.PresentOptions();
    }

    private static void passage64_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage64_Fragment_0);
        optionsManager.PresentOptions();
    }

    private static void passage64_Fragment_2()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", MethodTaxesEventStart);
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "GainServantFromLost";
        Console.WriteLine();
        if (StaticGameState.allyA == "wolves")
        {
            Console.Write(StaticGameState.nameA);
            Console.Write(" III ");
            Console.Write("<bold>");
            Console.Write("immediately gains 1 Servant from Lost and $1");
            Console.Write("</bold>");
            Console.Write(".");
            Console.WriteLine();
        }

        if (StaticGameState.allyB == "wolves")
        {
            Console.Write(StaticGameState.nameB);
            Console.Write(" III ");
            Console.Write("<bold>");
            Console.Write("immediately gains 1 Servant from Lost and $1");
            Console.Write("</bold>");
            Console.Write(".");
            Console.WriteLine();
        }

        if (StaticGameState.allyC == "wolves")
        {
            Console.Write(StaticGameState.nameC);
            Console.Write(" III ");
            Console.Write("<bold>");
            Console.Write("immediately gains 1 Servant from Lost and $1");
            Console.Write("</bold>");
            Console.Write(".");
            Console.WriteLine();
        }

        if (StaticGameState.allyD == "wolves")
        {
            Console.Write(StaticGameState.nameD);
            Console.Write(" III ");
            Console.Write("<bold>");
            Console.Write("immediately gains 1 Servant from Lost and $1");
            Console.Write("</bold>");
            Console.Write(".");
            Console.WriteLine();
        }

        if (StaticGameState.allyE == "wolves")
        {
            Console.Write(StaticGameState.nameE);
            Console.Write(" III ");
            Console.Write("<bold>");
            Console.Write("immediately gains 1 Servant from Lost and $1");
            Console.Write("</bold>");
            Console.Write(".");
            Console.WriteLine();
        }

        if (StaticGameState.allyA != "wolves" && StaticGameState.allyB != "wolves" && StaticGameState.allyC != "wolves" && StaticGameState.allyD != "wolves")
        {
            Console.Write(StaticGameState.nameA);
            Console.Write(" III ");
            Console.Write("<bold>");
            Console.Write("immediately gains 1 Servant from Lost and $1");
            Console.Write("</bold>");
            Console.Write(".");
            Console.WriteLine();
        }

        Console.Write("</setupStyleEvnt>");
        optionsManager.PresentOptions();
    }

    private static void passage64_Fragment_3()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage64_Fragment_2);
        optionsManager.PresentOptions();
    }
    
    private static void MethodElecY()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Anger and Resentment");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "At the next town meeting, the townspeople were furious to discover a government official sent to survey a new extension to the electrical grid. The cousins' actions were noted in the minutes from that event where they disclosed their ");
        Console.Write("<bold>");
        Console.Write("support for the installation of electricity");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("and the proposed installation of it at zero cost to the town.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "In a mad display of various ignorances, an angry mob began to form in the center of town, forcing the scientists to retreat by carriage. The crowd soon burst into riotous fury, cursing the government and destroying everything in sight. The riot of 1912 is noted within town archives as the most violent in recorded history. The mob's flaming torches set the Hospital ablaze, leaving multiple individuals severely injured or deceased as they continued into the nearby hills.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("While the people's specific grievance had been long forgotten by the time the mob reached the steps of their estates, it was no less malicious in its issuance of flawed justice.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click to continue...", passage69_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage69_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.peeps = 0;
        optionsManager.AddOption("Continue...", ((StaticGameState.imm == "none") ? MethodNoUni3 : MethodDetEffectRandom));
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "DiscardEstateUpgrade_Icon";
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("Each player (regardless of their vote) must choose and discard an Estate Upgrade ");
        Console.Write("<italic>");
        Console.Write("(not a Storage Shed).");
        Console.Write("</italic>");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Any player that voted ");
        Console.Write("<bold>");
        Console.Write("Nay");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("loses 1 ");
        Console.Write("<sprite=\"Creepy_Icon\" index=0>");
        Console.Write(".");
        Console.Write("</setupStyleEvnt>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage69_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage69_Fragment_0);
        optionsManager.PresentOptions();
    }


    private static void MethodElecN()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Celebration and Anger");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("The townspeople sifted through the cousins' erudite proposal at the next town meeting and realized that they intended to ");
        Console.Write("<bold>");
        Console.Write("support their ridiculous distrust of modern convenience");
        Console.Write("</bold>");
        Console.Write(". That evening, a celebratory mob congregated in town with various primitive lighting devices - given the lack of electricity - to cheer and chant their approval.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "Fueled by alcohol and inspired by ignorant revelry, the gathering quickly devolved into a riotous mass. Chanting loudly in crass language, they tore down the central streets of the village, leaving nothing untouched in their destructive path.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "In the morning, as the misty streets revealed themselves, the devastation and regret became clear as crystal. Newspapers of the time displayed pictures of the aftermath: the Hospital ablaze, the Town Hall left in smoldering ruins. They hastily rebuilt as best they could, but it would never be the same.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click to continue...", passage70_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage70_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        StaticGameState.peeps = 1;
        optionsManager.AddOption("Continue...", ((StaticGameState.imm == "none") ? MethodNoUni3 : MethodDetEffectRandom));
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "AngryMob_Icon";
        Console.WriteLine();
        Console.Write("Return the ");
        Console.Write("<sprite=\"AngryMob_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("token to its starting location.");
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.players == 2)
        {
            Console.Write("The player that won the vote also receives ");
            Console.Write("<bold>");
            Console.Write("1 Ingredient or Knowledge");
            Console.Write("</bold>");
            Console.Write(" of their choice.");
        }
        else
        {
            Console.Write("Any player that voted ");
            Console.Write("<bold>");
            Console.Write("Yay");
            Console.Write("</bold>");
            Console.Write(" receives ");
            Console.Write("<bold>");
            Console.Write("1 Ingredient or Knowledge");
            Console.Write("</bold>");
            Console.Write(" of their choice.");
        }

        Console.Write("</setupStyleEvnt>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage70_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage70_Fragment_0);
        optionsManager.PresentOptions();
    }


    private static void MethodLettercode()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Surprising Correspondence");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "As the welcome from the townspeople was considerably icy, the cousins were amused to receive a plain letter of correspondence sealed with wax. No return address was provided and no watermarks offered evidence as to their origin. Perhaps this mystery, they surmised, would afford them more than simple seclusion in this dreary countryside.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Little did they realize how instrumental this stealthful exchange would prove over the next several decades.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click here to continue...", passage71_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        if (StaticGameState.letterSetRandomize == 0 || StaticGameState.letterSetRandomize == "")
        {
            StaticGameState.letter =
            [
                1,
                2,
                3,
                4,
                5,
                6
            ];
            StaticGameState.letter.Shuffle();
            StaticGameState.pa = StaticGameState.letter[0];
            StaticGameState.pb = StaticGameState.letter[1];
            StaticGameState.pc = StaticGameState.letter[2];
            StaticGameState.pd = StaticGameState.letter[3];
            StaticGameState.pe = StaticGameState.letter[4];
        }

        if (StaticGameState.pa == 1)
        {
            StaticGameState.let1 = StaticGameState.nameA;
        }

        if (StaticGameState.pa == 2)
        {
            StaticGameState.let2 = StaticGameState.nameA;
        }

        if (StaticGameState.pa == 3)
        {
            StaticGameState.let3 = StaticGameState.nameA;
        }

        if (StaticGameState.pa == 4)
        {
            StaticGameState.let4 = StaticGameState.nameA;
        }

        if (StaticGameState.pa == 5)
        {
            StaticGameState.let5 = StaticGameState.nameA;
        }

        if (StaticGameState.pa == 6)
        {
            StaticGameState.let6 = StaticGameState.nameA;
        }

        if (StaticGameState.pb == 1)
        {
            StaticGameState.let1 = StaticGameState.nameB;
        }

        if (StaticGameState.pb == 2)
        {
            StaticGameState.let2 = StaticGameState.nameB;
        }

        if (StaticGameState.pb == 3)
        {
            StaticGameState.let3 = StaticGameState.nameB;
        }

        if (StaticGameState.pb == 4)
        {
            StaticGameState.let4 = StaticGameState.nameB;
        }

        if (StaticGameState.pb == 5)
        {
            StaticGameState.let5 = StaticGameState.nameB;
        }

        if (StaticGameState.pb == 6)
        {
            StaticGameState.let6 = StaticGameState.nameB;
        }

        if (StaticGameState.pc == 1)
        {
            StaticGameState.let1 = ((StaticGameState.players == 3)
                ? StaticGameState.nameC
                : StaticGameState.GetRandom(new[]
                {
                    StaticGameState.nameA,
                    StaticGameState.nameB
                }));
        }

        if (StaticGameState.pc == 2)
        {
            StaticGameState.let2 = ((StaticGameState.players == 3)
                ? StaticGameState.nameC
                : StaticGameState.GetRandom(new[]
                {
                    StaticGameState.nameA,
                    StaticGameState.nameB
                }));
        }

        if (StaticGameState.pc == 3)
        {
            StaticGameState.let3 = ((StaticGameState.players == 3)
                ? StaticGameState.nameC
                : StaticGameState.GetRandom(new[]
                {
                    StaticGameState.nameA,
                    StaticGameState.nameB
                }));
        }

        if (StaticGameState.pc == 4)
        {
            StaticGameState.let4 = ((StaticGameState.players == 3)
                ? StaticGameState.nameC
                : StaticGameState.GetRandom(new[]
                {
                    StaticGameState.nameA,
                    StaticGameState.nameB
                }));
        }

        if (StaticGameState.pc == 5)
        {
            StaticGameState.let5 = ((StaticGameState.players == 3)
                ? StaticGameState.nameC
                : StaticGameState.GetRandom(new[]
                {
                    StaticGameState.nameA,
                    StaticGameState.nameB
                }));
        }

        if (StaticGameState.pc == 6)
        {
            StaticGameState.let6 = ((StaticGameState.players == 3)
                ? StaticGameState.nameC
                : StaticGameState.GetRandom(new[]
                {
                    StaticGameState.nameA,
                    StaticGameState.nameB
                }));
        }

        if (StaticGameState.pd == 1)
        {
            StaticGameState.let1 = ((StaticGameState.players == 4)
                ? StaticGameState.nameD
                : ((StaticGameState.players == 3)
                    ? StaticGameState.GetRandom(new[]
                    {
                        StaticGameState.nameA,
                        StaticGameState.nameB,
                        StaticGameState.nameC
                    })
                    : StaticGameState.GetRandom(new[]
                    {
                        StaticGameState.nameA,
                        StaticGameState.nameB
                    })));
        }

        if (StaticGameState.pd == 2)
        {
            StaticGameState.let2 = ((StaticGameState.players == 4)
                ? StaticGameState.nameD
                : ((StaticGameState.players == 3)
                    ? StaticGameState.GetRandom(new[]
                    {
                        StaticGameState.nameA,
                        StaticGameState.nameB,
                        StaticGameState.nameC
                    })
                    : StaticGameState.GetRandom(new[]
                    {
                        StaticGameState.nameA,
                        StaticGameState.nameB
                    })));
        }

        if (StaticGameState.pd == 3)
        {
            StaticGameState.let3 = ((StaticGameState.players == 4)
                ? StaticGameState.nameD
                : ((StaticGameState.players == 3)
                    ? StaticGameState.GetRandom(new[]
                    {
                        StaticGameState.nameA,
                        StaticGameState.nameB,
                        StaticGameState.nameC
                    })
                    : StaticGameState.GetRandom(new[]
                    {
                        StaticGameState.nameA,
                        StaticGameState.nameB
                    })));
        }

        if (StaticGameState.pd == 4)
        {
            StaticGameState.let4 = ((StaticGameState.players == 4)
                ? StaticGameState.nameD
                : ((StaticGameState.players == 3)
                    ? StaticGameState.GetRandom(new[]
                    {
                        StaticGameState.nameA,
                        StaticGameState.nameB,
                        StaticGameState.nameC
                    })
                    : StaticGameState.GetRandom(new[]
                    {
                        StaticGameState.nameA,
                        StaticGameState.nameB
                    })));
        }

        if (StaticGameState.pd == 5)
        {
            StaticGameState.let5 = ((StaticGameState.players == 4)
                ? StaticGameState.nameD
                : ((StaticGameState.players == 3)
                    ? StaticGameState.GetRandom(new[]
                    {
                        StaticGameState.nameA,
                        StaticGameState.nameB,
                        StaticGameState.nameC
                    })
                    : StaticGameState.GetRandom(new[]
                    {
                        StaticGameState.nameA,
                        StaticGameState.nameB
                    })));
        }

        if (StaticGameState.pd == 6)
        {
            StaticGameState.let6 = ((StaticGameState.players == 4)
                ? StaticGameState.nameD
                : ((StaticGameState.players == 3)
                    ? StaticGameState.GetRandom(new[]
                    {
                        StaticGameState.nameA,
                        StaticGameState.nameB,
                        StaticGameState.nameC
                    })
                    : StaticGameState.GetRandom(new[]
                    {
                        StaticGameState.nameA,
                        StaticGameState.nameB
                    })));
        }

        if (StaticGameState.pe == 1)
        {
            StaticGameState.let1 = ((StaticGameState.players == 5)
                ? StaticGameState.nameE
                : ((StaticGameState.players == 4)
                    ? StaticGameState.GetRandom(new[]
                    {
                        StaticGameState.nameA,
                        StaticGameState.nameB,
                        StaticGameState.nameC,
                        StaticGameState.nameD
                    })
                    : ((StaticGameState.players == 3)
                        ? StaticGameState.GetRandom(new[]
                        {
                            StaticGameState.nameA,
                            StaticGameState.nameB,
                            StaticGameState.nameC
                        })
                        : StaticGameState.GetRandom(new[]
                        {
                            StaticGameState.nameA,
                            StaticGameState.nameB
                        }))));
        }

        if (StaticGameState.pe == 2)
        {
            StaticGameState.let2 = ((StaticGameState.players == 5)
                ? StaticGameState.nameE
                : ((StaticGameState.players == 4)
                    ? StaticGameState.GetRandom(new[]
                    {
                        StaticGameState.nameA,
                        StaticGameState.nameB,
                        StaticGameState.nameC,
                        StaticGameState.nameD
                    })
                    : ((StaticGameState.players == 3)
                        ? StaticGameState.GetRandom(new[]
                        {
                            StaticGameState.nameA,
                            StaticGameState.nameB,
                            StaticGameState.nameC
                        })
                        : StaticGameState.GetRandom(new[]
                        {
                            StaticGameState.nameA,
                            StaticGameState.nameB
                        }))));
        }

        if (StaticGameState.pe == 3)
        {
            StaticGameState.let3 = ((StaticGameState.players == 5)
                ? StaticGameState.nameE
                : ((StaticGameState.players == 4)
                    ? StaticGameState.GetRandom(new[]
                    {
                        StaticGameState.nameA,
                        StaticGameState.nameB,
                        StaticGameState.nameC,
                        StaticGameState.nameD
                    })
                    : ((StaticGameState.players == 3)
                        ? StaticGameState.GetRandom(new[]
                        {
                            StaticGameState.nameA,
                            StaticGameState.nameB,
                            StaticGameState.nameC
                        })
                        : StaticGameState.GetRandom(new[]
                        {
                            StaticGameState.nameA,
                            StaticGameState.nameB
                        }))));
        }

        if (StaticGameState.pe == 4)
        {
            StaticGameState.let4 = ((StaticGameState.players == 5)
                ? StaticGameState.nameE
                : ((StaticGameState.players == 4)
                    ? StaticGameState.GetRandom(new[]
                    {
                        StaticGameState.nameA,
                        StaticGameState.nameB,
                        StaticGameState.nameC,
                        StaticGameState.nameD
                    })
                    : ((StaticGameState.players == 3)
                        ? StaticGameState.GetRandom(new[]
                        {
                            StaticGameState.nameA,
                            StaticGameState.nameB,
                            StaticGameState.nameC
                        })
                        : StaticGameState.GetRandom(new[]
                        {
                            StaticGameState.nameA,
                            StaticGameState.nameB
                        }))));
        }

        if (StaticGameState.pe == 5)
        {
            StaticGameState.let5 = ((StaticGameState.players == 5)
                ? StaticGameState.nameE
                : ((StaticGameState.players == 4)
                    ? StaticGameState.GetRandom(new[]
                    {
                        StaticGameState.nameA,
                        StaticGameState.nameB,
                        StaticGameState.nameC,
                        StaticGameState.nameD
                    })
                    : ((StaticGameState.players == 3)
                        ? StaticGameState.GetRandom(new[]
                        {
                            StaticGameState.nameA,
                            StaticGameState.nameB,
                            StaticGameState.nameC
                        })
                        : StaticGameState.GetRandom(new[]
                        {
                            StaticGameState.nameA,
                            StaticGameState.nameB
                        }))));
        }

        if (StaticGameState.pe == 6)
        {
            StaticGameState.let6 = ((StaticGameState.players == 5)
                ? StaticGameState.nameE
                : ((StaticGameState.players == 4)
                    ? StaticGameState.GetRandom(new[]
                    {
                        StaticGameState.nameA,
                        StaticGameState.nameB,
                        StaticGameState.nameC,
                        StaticGameState.nameD
                    })
                    : ((StaticGameState.players == 3)
                        ? StaticGameState.GetRandom(new[]
                        {
                            StaticGameState.nameA,
                            StaticGameState.nameB,
                            StaticGameState.nameC
                        })
                        : StaticGameState.GetRandom(new[]
                        {
                            StaticGameState.nameA,
                            StaticGameState.nameB
                        }))));
        }

        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage71_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", MethodGen1InsanityYes);
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SPECIAL SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "S1_LetterBACK";
        Console.WriteLine();
        Console.Write("Retrieve the ");
        Console.Write("<bold>");
        Console.Write("Letter");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("cards from the Scenario box. Keep them seal side up and consult the number on the back of each letter:");
        Console.WriteLine();
        if (StaticGameState.letterSetRandomize == 0 || StaticGameState.letterSetRandomize == "")
        {
            StaticGameState.letter =
            [
                1,
                2,
                3,
                4,
                5,
                6
            ];
            StaticGameState.letter.Shuffle();
            StaticGameState.pa = StaticGameState.letter[0];
            StaticGameState.pb = StaticGameState.letter[1];
            StaticGameState.pc = StaticGameState.letter[2];
            StaticGameState.pd = StaticGameState.letter[3];
            StaticGameState.pe = StaticGameState.letter[4];
        }

        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write(StaticGameState.nameA);
        Console.Write(" ");
        Console.Write("collects letter number ");
        Console.Write(StaticGameState.pa);
        Console.Write("</bold>");
        Console.Write(".");
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write(StaticGameState.nameB);
        Console.Write(" ");
        Console.Write("collects letter number ");
        Console.Write(StaticGameState.pb);
        Console.Write("</bold>");
        Console.Write(".");
        Console.WriteLine();
        if (StaticGameState.players > 2)
        {
            Console.Write("<bold>");
            Console.Write(StaticGameState.nameC);
            Console.Write(" collects letter number ");
            Console.Write(StaticGameState.pc);
            Console.Write("</bold>");
            Console.Write(".");
            Console.WriteLine();
        }

        if (StaticGameState.players > 3)
        {
            Console.Write("<bold>");
            Console.Write(StaticGameState.nameD);
            Console.Write(" collects letter number ");
            Console.Write(StaticGameState.pd);
            Console.Write("</bold>");
            Console.Write(".");
            Console.WriteLine();
        }

        if (StaticGameState.players > 4)
        {
            Console.Write("<bold>");
            Console.Write(StaticGameState.nameE);
            Console.Write(" collects letter number ");
            Console.Write(StaticGameState.pe);
            Console.Write("</bold>");
            Console.Write(".");
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.Write("Once all players have received their correspondence, they may read the reverse side secretly.");
        Console.Write("</setupStyleEvnt>");
        if (StaticGameState.pa == 1)
        {
            StaticGameState.let1 = StaticGameState.nameA;
        }

        if (StaticGameState.pa == 2)
        {
            StaticGameState.let2 = StaticGameState.nameA;
        }

        if (StaticGameState.pa == 3)
        {
            StaticGameState.let3 = StaticGameState.nameA;
        }

        if (StaticGameState.pa == 4)
        {
            StaticGameState.let4 = StaticGameState.nameA;
        }

        if (StaticGameState.pa == 5)
        {
            StaticGameState.let5 = StaticGameState.nameA;
        }

        if (StaticGameState.pa == 6)
        {
            StaticGameState.let6 = StaticGameState.nameA;
        }

        if (StaticGameState.pb == 1)
        {
            StaticGameState.let1 = StaticGameState.nameB;
        }

        if (StaticGameState.pb == 2)
        {
            StaticGameState.let2 = StaticGameState.nameB;
        }

        if (StaticGameState.pb == 3)
        {
            StaticGameState.let3 = StaticGameState.nameB;
        }

        if (StaticGameState.pb == 4)
        {
            StaticGameState.let4 = StaticGameState.nameB;
        }

        if (StaticGameState.pb == 5)
        {
            StaticGameState.let5 = StaticGameState.nameB;
        }

        if (StaticGameState.pb == 6)
        {
            StaticGameState.let6 = StaticGameState.nameB;
        }

        if (StaticGameState.pc == 1)
        {
            StaticGameState.let1 = StaticGameState.nameC;
        }

        if (StaticGameState.pc == 2)
        {
            StaticGameState.let2 = StaticGameState.nameC;
        }

        if (StaticGameState.pc == 3)
        {
            StaticGameState.let3 = StaticGameState.nameC;
        }

        if (StaticGameState.pc == 4)
        {
            StaticGameState.let4 = StaticGameState.nameC;
        }

        if (StaticGameState.pc == 5)
        {
            StaticGameState.let5 = StaticGameState.nameC;
        }

        if (StaticGameState.pc == 6)
        {
            StaticGameState.let6 = StaticGameState.nameC;
        }

        if (StaticGameState.pd == 1)
        {
            StaticGameState.let1 = StaticGameState.nameD;
        }

        if (StaticGameState.pd == 2)
        {
            StaticGameState.let2 = StaticGameState.nameD;
        }

        if (StaticGameState.pd == 3)
        {
            StaticGameState.let3 = StaticGameState.nameD;
        }

        if (StaticGameState.pd == 4)
        {
            StaticGameState.let4 = StaticGameState.nameD;
        }

        if (StaticGameState.pd == 5)
        {
            StaticGameState.let5 = StaticGameState.nameD;
        }

        if (StaticGameState.pd == 6)
        {
            StaticGameState.let6 = StaticGameState.nameD;
        }

        if (StaticGameState.pe == 1)
        {
            StaticGameState.let1 = StaticGameState.nameE;
        }

        if (StaticGameState.pe == 2)
        {
            StaticGameState.let2 = StaticGameState.nameE;
        }

        if (StaticGameState.pe == 3)
        {
            StaticGameState.let3 = StaticGameState.nameE;
        }

        if (StaticGameState.pe == 4)
        {
            StaticGameState.let4 = StaticGameState.nameE;
        }

        if (StaticGameState.pe == 5)
        {
            StaticGameState.let5 = StaticGameState.nameE;
        }

        if (StaticGameState.pe == 6)
        {
            StaticGameState.let6 = StaticGameState.nameE;
        }

        optionsManager.PresentOptions();
    }

    private static void passage71_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("click here to continue...", passage71_Fragment_0);
        optionsManager.PresentOptions();
    }


    private static void MethodNoUni3b()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("One Last Attempt");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "Weary with age and weakened by a brief resurgence of Yellow Fever left uncured, the scientists' last days are spent wheezing and frail. Would this final crucial moment be filled with a single triumph that would secure irrefutable proof of their scientific legacy?");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Any player with a token that is not currently overtaken by the ");
        Console.Write("<sprite=\"AngryMob_Icon\" index=0>");
        Console.Write(" ");
        Console.Write("receives ");
        Console.Write("<bold>");
        Console.Write("one final Perform Experiment action");
        Console.Write("</bold>");
        Console.Write(".");
        Console.WriteLine();
        Console.WriteLine();
        optionsManager.AddOption("Scoring", MethodScoring);
        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodEnvelopes()
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
        optionsManager.AddOption("Once you are ready", passage73_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        StaticGameState.devpage = 1;
        optionsManager.PresentOptions();
    }

    private static void passage73_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Secret Meeting");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write(
            "When I arrived at the location, I went about my business as normal. As I was leaving, I felt a gentle tap on my shoulder. A woman dressed in traditional garb tipped her wool cap and bid me follow her to a wooden bench nearby.");
        Console.WriteLine();
        Console.WriteLine();
        ispasscode = true;
        ispopup = true;
        optionsManager.AddOption("EnvPasscode", MethodEnvPasscode);
        optionsManager.PresentOptions();
    }

    private static void passage73_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Once you are ready", passage73_Fragment_0);
        optionsManager.PresentOptions();
    }


    private static void MethodBuildingsEnd()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Good or Evil Intent");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write(
            "As they entered their twilight years, the results of the family's investigative efforts became known. The town, no longer in complete poverty, began to attract new interest from those with both genuine and nefarious motivations. The true intent of the family members was revealed.");
        Console.WriteLine();
        StaticGameState.gen3pg = 0;
        Console.WriteLine();
        if (StaticGameState.exposeA > 0)
        {
            StaticGameState.goodcount = int.Parse(StaticGameState.goodcount) + 1;
            Console.Write("The evil activities of the ");
            Console.Write(StaticGameState.ba);
            Console.Write(" were ");
            Console.Write("<bold>");
            Console.Write("thwarted");
            Console.Write("</bold>");
            Console.Write(" by our efforts. Place the ");
            Console.Write(StaticGameState.ba);
            Console.Write(" tile to the side of the play area within reach.");
            Console.WriteLine();
            if (StaticGameState.pAA == "yes")
            {
                Console.Write(StaticGameState.nameA);
                Console.Write(" gains 3VP for Exposing the threat.");
                Console.WriteLine();
            }

            if (StaticGameState.pBA == "yes")
            {
                Console.Write(StaticGameState.nameB);
                Console.Write(" gains 3VP for Exposing the threat.");
                Console.WriteLine();
            }

            if (StaticGameState.pCA == "yes")
            {
                Console.Write(StaticGameState.nameC);
                Console.Write(" gains 3VP for Exposing the threat.");
                Console.WriteLine();
            }

            if (StaticGameState.pDA == "yes")
            {
                Console.Write(StaticGameState.nameD);
                Console.Write(" gains 3VP for Exposing the threat.");
                Console.WriteLine();
            }

            if (StaticGameState.pEA == "yes")
            {
                Console.Write(StaticGameState.nameE);
                Console.Write(" gains 3VP for Exposing the threat.");
                Console.WriteLine();
            }
        }
        else
        {
            Console.Write("The evil activities of the ");
            Console.Write(StaticGameState.ba);
            Console.Write(" were ");
            Console.Write("<bold>");
            Console.Write("successful");
            Console.Write("</bold>");
            Console.Write(" because of our collective efforts to obscure and conceal. Place the ");
            Console.Write(StaticGameState.ba);
            Console.Write(" tile to the side of the play area within reach.");
            Console.WriteLine();
        }

        Console.WriteLine();
        if (StaticGameState.exposeB > 0)
        {
            StaticGameState.goodcount = int.Parse(StaticGameState.goodcount) + 1;
            Console.Write("The evil activities of the ");
            Console.Write(StaticGameState.bb);
            Console.Write(" were ");
            Console.Write("<bold>");
            Console.Write("thwarted");
            Console.Write("</bold>");
            Console.Write(" by our efforts. Place the ");
            Console.Write(StaticGameState.bb);
            Console.Write(" tile to the side of the play area within reach.");
            Console.WriteLine();
            if (StaticGameState.pAB == "yes")
            {
                Console.Write(StaticGameState.nameA);
                Console.Write(" gains 3VP for Exposing the threat.");
                Console.WriteLine();
            }

            if (StaticGameState.pBB == "yes")
            {
                Console.Write(StaticGameState.nameB);
                Console.Write(" gains 3VP for Exposing the threat.");
                Console.WriteLine();
            }

            if (StaticGameState.pCB == "yes")
            {
                Console.Write(StaticGameState.nameC);
                Console.Write(" gains 3VP for Exposing the threat.");
                Console.WriteLine();
            }

            if (StaticGameState.pDB == "yes")
            {
                Console.Write(StaticGameState.nameD);
                Console.Write(" gains 3VP for Exposing the threat.");
                Console.WriteLine();
            }

            if (StaticGameState.pEB == "yes")
            {
                Console.Write(StaticGameState.nameE);
                Console.Write(" gains 3VP for Exposing the threat.");
                Console.WriteLine();
            }
        }
        else
        {
            Console.Write("The evil activities of the ");
            Console.Write(StaticGameState.bb);
            Console.Write(" were ");
            Console.Write("<bold>");
            Console.Write("successful");
            Console.Write("</bold>");
            Console.Write(" because of our collective efforts to obscure and conceal. Place the ");
            Console.Write(StaticGameState.bb);
            Console.Write(" tile to the side of the play area within reach.");
            Console.WriteLine();
        }

        Console.WriteLine();
        if (StaticGameState.exposeC > 0)
        {
            StaticGameState.goodcount = int.Parse(StaticGameState.goodcount) + 1;
            Console.Write("The evil activities of the ");
            Console.Write(StaticGameState.bc);
            Console.Write(" were ");
            Console.Write("<bold>");
            Console.Write("thwarted");
            Console.Write("</bold>");
            Console.Write(" by our efforts. Place the ");
            Console.Write(StaticGameState.bc);
            Console.Write(" tile to the side of the play area within reach.");
            Console.WriteLine();
            if (StaticGameState.pAC == "yes")
            {
                Console.Write(StaticGameState.nameA);
                Console.Write(" gains 3VP for Exposing the threat.");
                Console.WriteLine();
            }

            if (StaticGameState.pBC == "yes")
            {
                Console.Write(StaticGameState.nameB);
                Console.Write(" gains 3VP for Exposing the threat.");
                Console.WriteLine();
            }

            if (StaticGameState.pCC == "yes")
            {
                Console.Write(StaticGameState.nameC);
                Console.Write(" gains 3VP for Exposing the threat.");
                Console.WriteLine();
            }

            if (StaticGameState.pDC == "yes")
            {
                Console.Write(StaticGameState.nameD);
                Console.Write(" gains 3VP for Exposing the threat.");
                Console.WriteLine();
            }

            if (StaticGameState.pEC == "yes")
            {
                Console.Write(StaticGameState.nameE);
                Console.Write(" gains 3VP for Exposing the threat.");
                Console.WriteLine();
            }
        }
        else
        {
            Console.Write("The evil activities of the ");
            Console.Write(StaticGameState.bc);
            Console.Write(" were ");
            Console.Write("<bold>");
            Console.Write("successful");
            Console.Write("</bold>");
            Console.Write(" because of our collective efforts to obscure and conceal. Place the ");
            Console.Write(StaticGameState.bc);
            Console.Write(" tile to the side of the play area within reach.");
            Console.WriteLine();
        }

        Console.WriteLine();
        optionsManager.AddOption("MostInvestigated", MethodMostInvestigated);
        Console.WriteLine();
        optionsManager.PresentOptions();
    }
    
    private static void MethodReminderroundEnd()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("End of round");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("Perform all End of round actions and prepare for the next round of play.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("NOTE");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.Write("<italic>");
        Console.Write("This message will appear at the end of every round in the final version, but NOT in this prototype. When rounds 1 & 2 of a Generation are over, you will always perform all End of round actions ");
        Console.Write("<bold>");
        Console.Write("BEFORE");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("resolving any new ");
        Console.Write("<bold>");
        Console.Write("Storybook Events");
        Console.Write("</bold>");
        Console.Write(". ");
        Console.Write("</italic>");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        optionsManager.AddOption("FeverServe1", MethodFeverServe1);
        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodProsperityHunterIntro()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("GENERATION III:");
        Console.WriteLine();
        Console.Write("The Fraternity of Hunters");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "The disease had revealed a much deeper evil than the family could have ever expected: An evil ignorance that dwells within the minds of the people. It had not only left the previous generation in shambles, but imbued the townsfolk with a profound, insatiable fear, even as the town returned to relative stability. During the day, the people watched the forests, glimpsing dark shadows flitting between the trees. At night, they steeled themselves against the wailing howls of unseen terrors, dreading that their children would be stolen away from their beds.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "That was until the Fraternity of Hunters, emboldened by the success of their clandestine operations, emerged from the shadows on the night of a blood red moon. They wore long-tail coats of black, burgundy, and dark leather, a wooden cross hanging either from their necks or dangling from their sides. They clutched crossbows, whips, and daggers freshly glimmering with crimson fluid. Their blood-stained attire and steel-eyed gaze evoked the undaunted presence of ones who had peered into the void and returned forever changed.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "Their stated goal: to slay every last beast in the land and return those who had unleashed this foul plague back to the depths of hell from whence they came. The Fraternity turned the fear of the populace to their advantage. They fed the superstitions of the people, blaming the sickness and disease on fiendish creatures from the dark.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "While they did not require monetary compensation in return, what they did ask was much more severe. Their sanguine efforts could not be completed in isolation, so on nights when the blood moon rose high in the evening sky, a handful of townsfolk were chosen to assist the Hunters' party and venture into the unknown. The next morning, the surviving Hunters would return, their garments speckled in the blood of the beasts and holding aloft the severed trophies of monsters slain in the wilderness. It was only a matter of time before they would call upon the family.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "Perhaps driven by a sense of limited time or jealousy over the Hunters' ability to frighten the townsfolk even moreso than their own actions, the cousins continued their meticulous labors in earnest. However, they were deeply unaware of just how intertwined their fates would be to the Fraternity.");
        Console.WriteLine();
        Console.WriteLine();
        optionsManager.AddOption("HuntersHUBcode", MethodHuntersHUBcode);
        Console.WriteLine();
        Console.WriteLine();
        StaticGameState.prosp = 1;
        StaticGameState.huntcount = 0;
        StaticGameState.gen3pg = 0;
        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodDiseaseConsequence()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Inescapable Plague");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "While their parents may have escaped the harshness of the Yellow Fever epidemic thanks to their aristocratic distance from the populace, the young scientists were unable to avoid the effects of such dismal environs. As the years passed, they found themselves stricken with a chronic illness that would remain with them for their entire lives. The enfeeblement haunted their work, insomuch that many weeks at a time were spent in isolation and bed rest.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("In their individual ways, the group set to work on something to alleviate or cure these symptoms, knowing that if they were unsuccessful, ");
        Console.Write("<bold>");
        Console.Write("the disease would carry over to their progeny.");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("<hook>");
        optionsManager.AddOption("Click to continue...", passage84_Fragment_0);
        Console.Write("</hook>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage84_Fragment_0()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Continue...", MethodLettercode);
        Console.Write("<setupStyleEvnt>");
        Console.Write("<bold>");
        Console.Write("SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "S1_DiseaseExperiment";
        Console.WriteLine();
        Console.Write("Retrieve the Hereditary Disease cards from the Scenario box. Shuffle them and ");
        Console.Write("<bold>");
        Console.Write("deal one Disease card face-up");
        Console.Write("</bold>");
        Console.Write(" ");
        Console.Write("to each player near their Masterwork. Return the remaining Hereditary Disease cards to the box.");
        Console.Write("</setupStyleEvnt>");
        Console.WriteLine();
        optionsManager.PresentOptions();
    }

    private static void passage84_Fragment_1()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        optionsManager.AddOption("Click to continue...", passage84_Fragment_0);
        optionsManager.PresentOptions();
    }


    private static void MethodHospitalDefine()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("Hospital");
        Console.Write("</bold>");
        Console.Write("<line-height=400%>");
        Console.WriteLine();
        Console.Write("</line-height>");
        Console.Write("<align=\"center\">");
        Console.Write("<line-height=400%>");
        Console.Write("<size=200>");
        Console.Write("<sprite=\"Hospital1\" index=0>");
        Console.Write("</size>");
        Console.Write("</align>");
        Console.Write("</line-height>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Look through the Experiment deck of your choice to find an Experiment of your choice and draw it into your hand. ");
        Console.Write("<italic>");
        Console.Write("(Once complete, shuffle the deck.)");
        Console.Write("</italic>");
        Console.WriteLine();
        StaticGameState.twopage = 1;
        Console.WriteLine();
        Console.Write("You have until the beginning of your next turn to complete this action ");
        Console.Write("<italic>");
        Console.Write("(allow other players to begin their turn while you choose).");
        Console.Write("</italic>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("NOTE: You may take the Hospital action with any legal token, but you must only click on the Storybook prompt the <b>first time</b> you visit the Hospital with your Self.");
        Console.WriteLine();
        Console.WriteLine();
        optionsManager.AddOption("Hospital1", MethodHospital1);
        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void MethodDevastationIntro()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("<bold>");
        Console.Write("GENERATION II:");
        Console.WriteLine();
        Console.Write("The Epidemic Strikes");
        Console.Write("</bold>");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "Following a bitter winter in 1862, a second epidemic descended upon the village in all its visceral and bloody force. This time, however, the town was unable to recover. Buildings were left to rot as the sick fled into the countryside. Some escaped to shelter in camps near Bucharest, while the less fortunate collapsed on the icy pathways along the journey, their frozen flesh left to thaw along muddy roadsides with the change of seasons. Lost and hopeless without aid, the town dwindled until only the barest of amenities remained.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "The desolation to which the family returned was unlike anything they had experienced in their short lifetime and the joys of youthful marriage were swiftly eclipsed by the reality of disease. Those who had stubbornly refused to join the others in mass exodus burned incense in their homes to prevent miasmatic transference of the fever; a practice quickly adopted within the family's estates. For years, the ominous tintinnabulation echoed across the stricken valley each night to ward off the disease even as the cemetery was inundated with new bodies.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "For most, this environment of sullen quiet and isolation would cause one to question their sanity, but for the scientists, this time was marked by a signature productivity. Perhaps the thought of redemption drove them forward or the constant reminder of their own mortality with each passing moment. Either way, they each toiled away in their studies, confident that through tragedy their family's legacy would finally be secured forever in the annals of science!");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(
            "And the country began to take notice of their activities; though not in the academic manner which they anticipated. Shadowy figures kept their watchful eye on the region with mysterious intentions. Unaware of the sinister machinations afoot, the scientists blindly immersed themselves in their work. They would soon find themselves confronted by a choice that would rock the very foundations of scientific (and rational) thought as they understood it.");
        Console.WriteLine();
        Console.WriteLine();
        optionsManager.AddOption("DiseaseConsequence", MethodDiseaseConsequence);
        Console.WriteLine();
        StaticGameState.letter =
        [
            1,
            2,
            3,
            4,
            5
        ];
        StaticGameState.letter.Shuffle();
        StaticGameState.letterA = StaticGameState.letter[0];
        StaticGameState.letterB = StaticGameState.letter[1];
        StaticGameState.letterC = StaticGameState.letter[2];
        StaticGameState.letA = 0;
        StaticGameState.letB = 0;
        StaticGameState.letC = 0;
        StaticGameState.goodcount = 0;
        StaticGameState.refusaltoken = "no";
        StaticGameState.sick = 0;
        StaticGameState.devpage = 0;
        StaticGameState.let1 = 0;
        StaticGameState.let2 = 0;
        StaticGameState.let3 = 0;
        StaticGameState.let4 = 0;
        StaticGameState.let5 = 0;
        StaticGameState.let6 = 0;
        StaticGameState.wcount = 0;
        StaticGameState.hcount = 0;
        StaticGameState.gen3pg = 0;
        StaticGameState.allyA = 0;
        StaticGameState.allyB = 0;
        StaticGameState.allyC = 0;
        StaticGameState.allyD = 0;
        StaticGameState.allyE = 0;
        StaticGameState.most = 0;
        StaticGameState.playA = 0;
        StaticGameState.playB = 0;
        StaticGameState.playC = 0;
        StaticGameState.playD = 0;
        StaticGameState.playE = 0;
        StaticGameState.exposeA = 0;
        StaticGameState.exposeB = 0;
        StaticGameState.exposeC = 0;
        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void Method5Note()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("NOTES:");
        Console.WriteLine();
        Console.Write("PROBLEM w/ Stables Code - Need Stables to open 2nd round when a refusal occurs AND also if a player does not have a meeting.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("SPECIFIC ON LETTER - WHAT DO THEY PROVIDE");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Hereditary Disease cards list a Storybook token. Either cut Storybook token or determine where this is referenced.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Go back and be more SPECIFIC on the gains for each group. Can even make them variable each game BUT:");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Help GOOD = 3VP for helping Expose a Building.");
        Console.WriteLine();
        Console.Write("Help EVIL = Vanity Upgrade + 4VP only if you WIN.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("BuildplayA could have individual descriptions for each location. May add later code below.");
        Console.WriteLine();
        Console.WriteLine();
        if (!(StaticGameState.ba == "Hardware Store") && !(StaticGameState.ba == "Wire Service") && !(StaticGameState.ba == "Book Store") && !(StaticGameState.ba == "Warehouse"))
        {
            StaticGameState.ba = "Pet Store";
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Make sure Page 11 is correct. I think it's fine. Library/Bank check it!");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(StaticGameState.pa);
        Console.Write(", ");
        Console.Write(StaticGameState.allyA);
        Console.WriteLine();
        Console.Write(StaticGameState.pb);
        Console.Write(", ");
        Console.Write(StaticGameState.allyB);
        Console.WriteLine();
        Console.Write(StaticGameState.pc);
        Console.Write(", ");
        Console.Write(StaticGameState.allyC);
        Console.WriteLine();
        Console.Write(StaticGameState.pd);
        Console.Write(", ");
        Console.Write(StaticGameState.allyD);
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(StaticGameState.playA);
        Console.WriteLine();
        Console.Write(StaticGameState.playB);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Hereditary Diseases assigned to players due to the town not building a Hospital.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("The Fight over the TRUE followers of St. Hubertus. -Wolves or Hunters-");
        Console.WriteLine();
        Console.Write("At start of Generation, one faction is randomly assigned EVIL and one is assigned GOOD. O");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Letters =");
        Console.WriteLine();
        Console.Write("Player receives an assigned letter numbered 1-6.");
        Console.WriteLine();
        Console.Write("Each letter has a password and a meeting place on the reverse side.");
        Console.WriteLine();
        Console.Write("Player can visit the meeting place or NOT.");
        Console.WriteLine();
        Console.Write("At meeting place, they enter password and get an offer from the appropriate faction, with a potential reward for their help.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("NOT: if the player chooses NOT to meet up or types in the wrong password as a goof. They are accosted by a random faction during the second round Event with a special sad note added.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("EVIL offers a free Estate Upgrade and 4VP as long as they WIN. You gotta win though.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Buildings =");
        Console.WriteLine();
        Console.Write("The game assigns three Buildings to be built randomly.");
        Console.WriteLine();
        Console.Write("One of those buildings is either the Bank or Library GUARANTEED.");
        Console.WriteLine();
        Console.Write("The game keeps track of whether players, once a place has been investigated, decide to conceal or reveal the building's intentions.");
        Console.WriteLine();
        Console.Write("At End of Generation - each building is checked to see if the votes to reveal are more than conceal. If a building's intent is concealed, the player");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Event GOOD/BAD -");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("GOOD -");
        Console.WriteLine();
        Console.Write("BAD - Cure for a price.");
        Console.WriteLine();
        Console.Write("already cured? Gain any knowledge.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Mind control");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("End =");
        Console.WriteLine();
        Console.Write("The player that investigates the most times receives a bonus/negative.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Other Possible Ideas Not Implemented:");
        Console.WriteLine();
        Console.Write("Place a Storybook token on space 35 of the Point track.");
        Console.WriteLine();
        Console.Write("<heading>");
        Console.Write("ERROR!");
        Console.Write("</heading>");
        Console.Write("If a player completes 3 Occult Experiments this Generation.");
        Console.WriteLine();
        Console.Write("<heading>");
        Console.Write("ERROR!");
        Console.Write("</heading>");
        StaticGameState.round = 13;
        Console.WriteLine();
        Console.Write("<bold>");
        Console.Write("SETUP");
        Console.Write("</bold>");
        StaticGameState._SetupImage = "AngryMobSetup1";
        Console.WriteLine();
        if (StaticGameState.society == "Order of St. Hubertus")
        {
            Console.Write("Turn to page ");
            Console.Write("<bold>");
            Console.Write("17");
            Console.Write("</bold>");
            Console.Write("of the Village Chronicle. Place the 2 ");
            Console.Write("<bold>");
            Console.Write("Biology Master's Study");
            Console.Write("</bold>");
            Console.Write("tiles into play near the other Vanity Estate Upgrades. Place the Suspicion Marker on space ");
            Console.Write("<bold>");
            StaticGameState.tracker = int.Parse(StaticGameState.tracker) - 2;
            if (StaticGameState.players == 4)
            {
                StaticGameState.tracker = int.Parse(StaticGameState.tracker) - 1;
            }

            if (StaticGameState.players == 5)
            {
                StaticGameState.tracker = int.Parse(StaticGameState.tracker) - 1;
            }

            Console.Write(StaticGameState.tracker);
            Console.Write("</bold>");
            Console.Write("and the ");
            Console.Write("<sprite=\"AngryMob_Icon\" index=0>");
            Console.Write("token one space to the left. ");
            Console.Write("<italic>");
            Console.Write("Pass the Starting Player token as normal.");
            Console.Write("</italic>");
            if (StaticGameState.players == 3)
            {
                Console.Write("Then, since this is a 3 player game, pass the starting player marker clockwise 1 additional time.");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Place a ");
            Console.Write("<sprite=\"Storybook\" index=0>");
            Console.Write("token directly on top of the ");
            Console.Write("<sprite=\"AngryMob_Icon\" index=0>");
            Console.Write("token.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<bold>");
            Console.Write("SPECIAL SETUP");
            Console.Write("</bold>");
            StaticGameState._SetupImage = "S1_Suspicious_Building";
            Console.WriteLine();
            if (StaticGameState.exposeA > 0)
            {
                Console.Write("Place the ");
                Console.Write(StaticGameState.ba);
                Console.Write("tile over spot A on the Village Chronicle. ");
                Console.WriteLine();
            }

            if (StaticGameState.exposeB > 0)
            {
                Console.Write("Place the ");
                Console.Write(StaticGameState.bb);
                Console.Write("tile over spot B on the Village Chronicle. ");
                Console.WriteLine();
            }

            if (StaticGameState.exposeC > 0)
            {
                Console.Write("Place the ");
                Console.Write(StaticGameState.bc);
                Console.Write("tile over spot C on the Village Chronicle.");
            }

            Console.Write("Return all other Exposed Building tiles to the scenario box.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<bold>");
            Console.Write("Acceptance");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("Caretaker pieces can now take actions in Town as well as in the Estates. ");
            Console.Write("<italic>");
            Console.Write("The same Town placement rules for Servants apply to Caretaker pieces.");
            Console.Write("</italic>");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<bold>");
            Console.Write("School for Hybridized Individuals");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("When a player visits the ");
            Console.Write("<bold>");
            Console.Write("School for Hybridized Individuals");
            Console.Write("</bold>");
            Console.Write(", they ");
            Console.Write("<bold>");
            Console.Write("pay $1");
            Console.Write("</bold>");
            Console.Write("to gain a ");
            Console.Write("<bold>");
            Console.Write("Caretaker");
            Console.Write("</bold>");
            Console.Write("piece from Lost. ");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<bold>");
            Console.Write("Experiments are Feared");
            Console.Write("</bold>");
            Console.Write("Anytime a player takes the Perform an Experiment Estate action, they gain 1 ");
            Console.Write("<sprite=\"Creepy_Icon\" index=0>");
            Console.Write(".");
            Console.Write("<sprite=\"Storybook\" index=0>");
            Console.Write("<bold>");
            Console.Write("Angry Mob");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("Any time the ");
            Console.Write("<sprite=\"AngryMob_Icon\" index=0>");
            Console.Write("token moves, move the Storybook token along with it. If the ");
            Console.Write("<sprite=\"AngryMob_Icon\" index=0>");
            Console.Write("overtakes a player, complete the current action and then ");
            optionsManager.AddOption("AngryMobStorybook", MethodAngryMobStorybook);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<bold>");
            Console.Write("Biology Achievement");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("When you gain a Vanity Estate Upgrade, the Biology Master's Study is part of the available pool to build as normal.");
            Console.WriteLine();
            Console.WriteLine();
            optionsManager.AddOption("WolvesEco-Friendly", MethodWolvesEcoFriendly);
        }
        else
        {
            Console.Write("Turn to page ");
            Console.Write("<bold>");
            Console.Write("15");
            Console.Write("</bold>");
            Console.Write("of the Village Chronicle. Place the 2 ");
            Console.Write("<bold>");
            Console.Write("Engineering Master's Study");
            Console.Write("</bold>");
            Console.Write("tiles into play near the other Vanity Estate Upgrades. The Suspicion Marker remains in the same space and the ");
            Console.Write("<sprite=\"AngryMob_Icon\" index=0>");
            Console.Write("token is reset 1 space to the left. ");
            Console.Write("<italic>");
            Console.Write("Pass the Starting Player token as normal.");
            Console.Write("</italic>");
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
                Console.Write("tile over spot A on the Village Chronicle. ");
                Console.WriteLine();
            }

            if (StaticGameState.exposeB > 0)
            {
                Console.Write("Place the ");
                Console.Write(StaticGameState.bb);
                Console.Write("tile over spot B on the Village Chronicle. ");
                Console.WriteLine();
            }

            if (StaticGameState.exposeC > 0)
            {
                Console.Write("Place the ");
                Console.Write(StaticGameState.bc);
                Console.Write("tile over spot C on the Village Chronicle.");
            }

            Console.Write("Return all other Exposed Building tiles to the scenario box.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<bold>");
            Console.Write("Hunter's Haven");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("For each visit to the Hunter's Haven, pay 1 Occult Knowledge cube to lose 2 ");
            Console.Write("<sprite=\"Insanity_Icon\" index=0>");
            Console.Write(". ");
            Console.Write("<italic>");
            Console.Write("(You cannot use Journaled Knowledge to pay this cost.)");
            Console.Write("</italic>");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<bold>");
            Console.Write("Engineering Achievement");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("When you gain a Vanity Estate Upgrade, the ");
            Console.Write("<bold>");
            Console.Write("Engineering Master's Study");
            Console.Write("</bold>");
            Console.Write("is part of the available pool to build as normal.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("<bold>");
            Console.Write("Endless Hunt");
            Console.Write("</bold>");
            Console.WriteLine();
            Console.Write("At the end of the round, two of the scientists will be chosen to participate in the ");
            Console.Write("<bold>");
            Console.Write("Night of the Hunt.");
            Console.Write("</bold>");
            Console.Write("This invitation cannot be refused.");
            Console.WriteLine();
            Console.WriteLine();
            optionsManager.AddOption("CharityAwardGood", MethodCharityAwardGood);
        }

        Console.WriteLine();
        optionsManager.PresentOptions();
    }


    private static void Method6Note()
    {
        Console.Clear();
        ScenarioOptionsManager optionsManager = new ScenarioOptionsManager();
        Console.Write("Choose 35VP negative - last place player");
        Console.WriteLine();
        Console.Write("Introduce Yellow Fever Innoculation - must be tested on someone");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Charity/Mayor? choose 3 Sciences for symposium.");
        Console.WriteLine();
        Console.Write("End of Generation Science Bonus.");
        Console.WriteLine();
        Console.Write("1st Immortality token. Infinity Token placed on 3rd level of track.");
        Console.WriteLine();
        Console.Write("2nd Symposium - If more, Uni is built. If middle, Yellow Fever determines. If low, no Uni. (3 narratives presented)");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Could potentially write a short excerpt from each Symposium speech. This could also be based on how effective the players were.");
        Console.WriteLine();
        StaticGameState.sci3 = "Biology";
        Console.WriteLine();
        StaticGameState.sci3 = "Chemistry";
        Console.WriteLine();
        StaticGameState.sci3 = "Engineering";
        Console.WriteLine();
        Console.WriteLine();
        if (StaticGameState.sci3 == "Biology")
        {
            Console.Write(
                "Within minutes, a pool of blood that could not begin to be contained by the hastily tarped flooring caused the lower row in the theater to move to the second level. Conflicting theories of homeopathic remedies, misasmatic transference of disease, and the efficacy of good and bad Earth were debunked with live displays and bacterial cultures. By the end, ");
        }

        StaticGameState.sci3 = "Chemistry";
        StaticGameState.sci3 = "Engineering";
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("NOTE: Do not have a thing to attack other players with YELLOW FEVER.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Replace Stasis Chamber to this side. Doesn't make sense on the other side.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Also, now that this side deals with finding the secret to immortality. Eternal life.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Scientific \"biological immortality\":");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("WHO WANTS TO LIVE FOREVER");
        Console.WriteLine();
        Console.Write("Ways to become Immortal:");
        Console.WriteLine();
        Console.Write("Biology -");
        Console.WriteLine();
        Console.Write("Chemistry -");
        Console.WriteLine();
        Console.Write("Engineering -");
        Console.WriteLine();
        Console.Write("Occult -");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Put a Storybook token on the end of the Research Track of your choice. If/when this track is complete, click on the Storybook icon.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Gift of immortality is of course a free caretaker disc that can take double town actions once per round.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Maybe move up the Panacea and Yellow Fever cures.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        optionsManager.PresentOptions();
    }
}