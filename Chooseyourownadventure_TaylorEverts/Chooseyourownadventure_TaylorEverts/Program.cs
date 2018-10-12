using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chooseyourownadventure_TaylorEverts
{
    class Program
    {
        static void Main()
        {
            
            Choice1();

        }
        // break out choices as different methods and call them
        // can do input validation with uh whats her butt oh yeah switch loops

        static void Restart()
        {
            while (true)
            {
                Console.WriteLine("Would you like to restart? (y/n)");
                string yesorno = Console.ReadLine();
                if (yesorno == "y")
                {
                    Main();
                }
                else if (yesorno == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, I didn't recognize that. Please try again.\n");
                    continue;
                }
            }
        }
        static void Choice1()
        {
            string choice;
            while (true)
            {
                Console.WriteLine("Welcome to the Dev.Build(2.0) Choose Your Own Adventure Game!\n" +
                "Will you be playing as the Wizard, Rogue, or Barbarian?\n" +
                "(enter \"w\" for Wizard, \"r\" for Rogue, or \"b\" for Barbarian)\n");
                choice = Console.ReadLine().ToLower();
                if(choice != "w" && choice != "r" && choice != "b")
                {
                    Console.WriteLine("\nInput not valid. Please try again.\n");
                    continue;
                }
                break;
            }
            switch(choice)
            {
                case "w":
                    Console.WriteLine("Excellent Choice. We'll be playing the Wizard.\n");
                    break;
                case "r":
                    Console.WriteLine("I really don't trust rogueish types. We're going to play" +
                        " the Wizard\n");
                    break;
                case "b":
                    Console.WriteLine("Eh, I don't know about primitive angry dudes. Better" +
                        " choose the Wizard\n");
                    break;
            }
            Choice2();
        }
        static void Choice2()
        {
            string choice;
            while (true)
            {
                Console.WriteLine("You awake as the Wizard, keen and mighty. For ages have you studied the secrets\n" +
                    "of the magical arts, and your devotion yielded you untold power, the likes of which could\n" +
                    "bend the very fabric of reality to your will. You're kinda hungry, though. Whats for breakfast?\n\n" +
                    "You see a table before you, upon which rests a platter of steak and eggs, and a chalice of what\n" +
                    "appears to be a steaming, bubbling liquid. You notice a faintly skull-shaped waft of smoke rise from\n" +
                    "the glass after a few moments of looking at it.\n(enter \"s\" for Steak and Eggs or \"b\" for " +
                    "the glass of bubbling liquid)\n");
                choice = Console.ReadLine().ToLower();
                if (choice != "s" && choice != "b")
                {
                    Console.WriteLine("\nInput not valid. Please try again.\n");
                    continue;
                }
                break;
            }
            switch (choice)
            {
                case "s":
                    Console.WriteLine("You approach the table and sit down to your meal of steak, cheese-eggs,\n" +
                        "and Welch's Grape. It's the bomb-diggity.\n\n");
                    Choice3();
                    break;
                case "b":
                    Console.WriteLine("You approach the table and seize the glass in your hand.\n" +
                        "Your countless centuries of study have taught you nothing. The glass was obviously\n" +
                        "poison. I mean it had a literal skull made of smoke rising from it. What were you thinking?\n" +
                        "\n\nYOU DIED");
                    Restart();
                    break;
            }

        }
        static void Choice3()
        {
            string choice;
            while (true)
            {
                Console.WriteLine("Wow. Breakfast was delicious. Whomever thought of steak for breakfast was a bloody mad genius\n" +
                    "You spend a few moments thinking about other luxury foods that could be eaten for breakfast.\n" +
                    "Calviar and eggs? Eh, cliche. Eggs with saffron? Eh, derivative.\n\n" +
                    "This questioning goes a bit longer until you remember you forgot to pick up your apprentice from soccer practice.\n\n" +
                    "\"Fizzlesticks!\" you say aloud, appalled at your own foul language. You depart immediately. Which means of\n" +
                    "transportation do you take? (enter \"l\" for Old Log, \"d\" for Dragon, or \"a\" for Brad's Honda Accord)\n\n");
                choice = Console.ReadLine().ToLower();
                if (choice != "l" && choice != "d" && choice != "a")
                {
                    Console.WriteLine("\nInput not valid. Please try again.\n");
                    continue;
                }
                break;
            }
            switch (choice)
            {
                case "l":
                    Console.WriteLine("You sit on the log. It's just a log. Nothing happens. You're late to pick up Apprentice Brad\n" +
                        "and you have to listen to a passive aggressive conversation the entire ride home, ruining your day.\n" +
                        "DAY RUINED");
                    Restart();
                    break;
                case "d":
                    Console.WriteLine("You hop on your trusty dragon, Puff, Scourge of High Rock, and take to the skies to pick up Brad.\n " +
                        "\"Never fear, Brad!\", you shout, \"I'm on the way!\"");
                    Choice3Branch1();
                    break;
                case "a":
                    Console.WriteLine("You forget where you put the keys for a moment, eventually remembering they were still in your\n" +
                        "other robes from last night. You retrive them and hop in the car, taking the highway to the fields");
                    Choice3Branch2();
                    break;
            }

        }
        static void Choice3Branch1()
        {
            string choice;
            while (true)
            {
                Console.WriteLine("As you soar along the skies, a sense of superiority starts to overcome you. Everyone\n" +
                    "looks so small from up here. Maybe its not because of depth perception and optics, maybe its because you're\n" +
                    "just a better person. With his fire breathing abilities and your magic prowess, you and Puff could dominate the ground\n" +
                    "dwellers and rule from on high. At the same time, you're still late to pick up Brad. What do you do?\n\n" +
                    "(enter \"m\" for megalomania, \"d\" to Dab, or \"b\" to continue picking up Brad)\n\n");
                choice = Console.ReadLine().ToLower();
                if (choice != "m" && choice != "d" && choice != "b")
                {
                    Console.WriteLine("\nInput not valid. Please try again.\n");
                    continue;
                }
                break;
            }
            switch (choice)
            {
                case "m":
                    Console.WriteLine("Your thirst for power overcomes you. You raise your hands above your head and begin an\n" +
                        "incantation. The skies darken and Puff lets loose a billow of white hot fire, silhouetted as lightning and thunder\n" +
                        "crashes upon the ground, sending scared civilians skittering off in every direction. A new dark age has begun.\n\n" +
                        "SELF IMPORTANCE\n");
                    Restart();
                    break;
                case "d":
                    Console.WriteLine("You let go of Puff to perform the Dab, realizing only moments too late you needed those same hands to\n" +
                        "hold on to Puff. You fall off and die.\n\n" +
                        "DABBED\n");
                    Restart();
                    break;
                case "b":
                    Console.WriteLine("Despite the call to power, you resist and continue with your errand.\n\n");
                    Choice3Branch1Branch1();
                    break;
            }

        }
        static void Choice3Branch2()
        {
            string choice;
            while (true)
            {
                Console.WriteLine("The Accord proves roadworthy and you quickly arrive at the Soccer fields. You see\n" +
                    "Brad alone, crying on a bench near on the visitors side of the field. You approach and try of think of something\n" +
                    "to say. A few things come to mind.\n\n" +
                    "(enter \"p\" for \"Suck it up, panzy\", \"d\" to Dab, or \"b\" \"Hey Buckarro. Sorry I'm late. Lets go home.\"\n\n");
                choice = Console.ReadLine().ToLower();
                if (choice != "p" && choice != "d" && choice != "b")
                {
                    Console.WriteLine("\nInput not valid. Please try again.\n");
                    continue;
                }
                break;
            }
            switch (choice)
            {
                case "p":
                    Console.WriteLine("Brad cries and runs away\n\n" +
                        "WEAKLING");
                    Restart();
                    break;
                case "d":
                    Console.WriteLine("You dab so hard there is a thermonuclear fission event in the immediate viscinity, tearing a hole in reality" +
                        "DAB NUKE\n");
                    Restart();
                    break;
                case "b":
                    Console.WriteLine("You go home.\n\n" + "RUNNING OUT OF TIME FOR ASSESSMENT\n");
                    Restart();
                    break;
            }

        }
        static void Choice3Branch1Branch1()
        {
            string choice;
            while (true)
            {
                Console.WriteLine("The dragon proves skyworthy and you quickly arrive at the Soccer fields. You see\n" +
                    "Brad alone, crying on a bench near on the visitors side of the field. You approach and try of think of something\n" +
                    "to say. A few things come to mind.\n\n" +
                    "(enter \"p\" for \"Isn't this dragon, sick, bro?\", \"d\" to Dab, or \"b\" \"Hey Buckarro. Sorry I'm late. Lets go home.\"\n\n");
                choice = Console.ReadLine().ToLower();
                if (choice != "p" && choice != "d" && choice != "b")
                {
                    Console.WriteLine("\nInput not valid. Please try again.\n");
                    continue;
                }
                break;
            }
            switch (choice)
            {
                case "p":
                    Console.WriteLine("Brad nods and agrees.\n\n" +
                        "SICK DRAGON");
                    Choice3Branch1Branch2();
                    break;
                case "d":
                    Console.WriteLine("You dab so hard there is a thermonuclear fission event in the immediate viscinity, tearing a hole in reality" +
                        "DAB NUKE\n");
                    Restart();
                    break;
                case "b":
                    Console.WriteLine("You go home.\n\n" + "RUNNING OUT OF TIME FOR ASSESSMENT\n");
                    Restart();
                    break;
            }

        }
        static void Choice3Branch1Branch2()
        {
            string choice;
            while (true)
            {
                Console.WriteLine("You run out of time your assessment. What do you do?\n\n" +
                    "(enter \"c\" to cry, or \"p\" to not be as clever as you could be on the final choice.\n\n");
                choice = Console.ReadLine().ToLower();
                if (choice != "p" && choice != "c")
                {
                    Console.WriteLine("\nInput not valid. Please try again.\n");
                    continue;
                }
                break;
            }
            switch (choice)
            {
                case "p":
                    Console.WriteLine("You get a good assessment grade even though its not as cool as it could have been. Darn.\n\n" +
                        "COOL--");
                    Restart();
                    break;
                case "c":
                    Console.WriteLine("You cry but whatever real men show their feelings" +
                        "EMOTIONAL INTELLIGENCE\n");
                    Restart();
                    break;
            }

        }

    }
}
