using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_Urban_Legacy
{
    class OldProgram
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            string asciiArt = @"
   _____      _                                 _      _    _      _                   _                                 
  / ____|    | |                               | |    | |  | |    | |                 | |                                
 | |    _   _| |__   ___ _ __ _ __  _   _ _ __ | | __ | |  | |_ __| |__   __ _ _ __   | |     ___  __ _  __ _  ___ _   _ 
 | |   | | | | '_ \ / _ \ '__| '_ \| | | | '_ \| |/ / | |  | | '__| '_ \ / _` | '_ \  | |    / _ \/ _` |/ _` |/ __| | | |
 | |___| |_| | |_) |  __/ |  | |_) | |_| | | | |   <  | |__| | |  | |_) | (_| | | | | | |___|  __/ (_| | (_| | (__| |_| |
  \_____\__, |_.__/ \___|_|  | .__/ \__,_|_| |_|_|\_\  \____/|_|  |_.__/ \__,_|_| |_| |______\___|\__, |\__,_|\___|\__, |
         __/ |               | |                                                                   __/ |            __/ |
        |___/                |_|                                                                  |___/            |___/ ";
            Console.WriteLine(asciiArt);
            Console.ResetColor();

            Console.WriteLine("\nWelcome to Night City. What's your name?");
            string playerName = Console.ReadLine();

            Console.WriteLine($"\n{playerName}, you're a young streetkid aspiring to become a legend. You have a chance to plan the greatest heist Night City has ever witnessed: stealing the Digital Heart from Arasaka corporation. But it's dangerous. Do you wish to proceed? (yes/no)");

            string importantChoice = Console.ReadLine();

            while (importantChoice.ToLower() != "yes" && importantChoice.ToLower() != "no")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nInvalid input. Please enter 'yes' or 'no'.");
                Console.ResetColor();
                importantChoice = Console.ReadLine();
            }

            if (importantChoice.ToLower() == "yes")
            {
                Console.WriteLine("\nYou courageously move forward with the plan, risking it all for a chance at greatness.");

                /*
                * if the player doesnt have all items, he will be presented with the choice between going to the heist or preparing (preparationChoice)
                * if the player has all items, he will be immediately sent to the heist
                */

                /* if player chooses the heist option he will be presented with these choices based on the items in their inventory:
                 * Cyberblaze (Mia): player sacrifaces themsels to save Mia (medium - yellow)
                 * newItem (Mia): Mia sacrifices herself to save the player (medium - yellow)
                 * Katana (Dex): player sacrifices themselves to save Dex (medium - yellow)
                 * Admin key (Dex): Dex sacrifices himself to save the player (medium - yellow)
                 * every item: best ending (everyone survives) (good - green)
                 * no items: worst ending (player is tortured, snitches on Mia and Dex and everyone dies) (bad - red)   
                */

                /*
                * if the player doesnt have both items from Mia and Dex, he will be presented with this choice:
                * if he already has Čyberblaze and newItem in his inventory, he will be immediately sent to Dex
                * if he already has Admin key and Katana in his inventory, he will be immediately sent to Mia
                */

                Console.WriteLine("\nYour closest friend, Mia, a bold and resourceful hacker, and Dex, a brave and physically strong fighter, are ready to help you. Who do you want to approach for help? (Mia/Dex)");

                string preparationHelper = Console.ReadLine();

                while (preparationHelper.ToLower() != "mia" && preparationHelper.ToLower() != "dex")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nInvalid input. Please enter 'Mia' or 'Dex'.");
                    Console.ResetColor();
                    preparationHelper = Console.ReadLine();
                }

                if (preparationHelper.ToLower() == "mia")

                /*
                * if the player doesnt have the items Cyberblaze and newItem, he will be presented wuth this choice: Where would you like to go next, Arasaka Tower or the newLocation? (tower/new)
                * if he already has Cybarblaze in his inventory, he will be immediately sent to newLocation
                * if he already has newItem in his inventory, he will be immediately sent to Arasaka Tower
                */
                {
                    Console.WriteLine("\nWhere would you like to go next, Arasaka Tower or the newLocation? (tower/new)");
                    string locationChoice = Console.ReadLine();

                    while (locationChoice.ToLower() != "tower" && locationChoice.ToLower() != "market")
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nInvalid input. Please enter 'tower' or 'market'.");
                        Console.ResetColor();
                        locationChoice = Console.ReadLine();
                    }

                    if (locationChoice.ToLower() == "tower")
                    {

                        Console.WriteLine("\nYou arrive at Arasaka Tower. The security is tight. You need to find a way to get in. Do you sneak in or force your way in? (sneak/force)");
                        string infiltrationChoice = Console.ReadLine();

                        while (infiltrationChoice.ToLower() != "sneak" && infiltrationChoice.ToLower() != "force")
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\nInvalid input. Please enter 'sneak' or 'force'.");
                            Console.ResetColor();
                            infiltrationChoice = Console.ReadLine();
                        }

                        if (infiltrationChoice.ToLower() == "sneak")
                        {
                            Console.WriteLine("\nYou successfully sneak into the Arasaka tower and gather crucial information about the bank. Unfortunately, on your way out, you encounter one of Arasaka's best security measures: Nanoclaw, a cybernetically enhanced tiger. You notice something resembling a gamepad on the desk next to you. Will you try to reach for it or make a run for it? (reach/run)");
                            string threatChoice = Console.ReadLine();

                            while (threatChoice.ToLower() != "reach" && threatChoice.ToLower() != "run")
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\nInvalid input. Please enter 'reach' or 'run'.");
                                Console.ResetColor();
                                threatChoice = Console.ReadLine();
                            }

                            if (threatChoice.ToLower() == "reach")
                            {
                                // Pokemon battle scenario
                                var cyberblaze = new Pokemon("Cyberblaze", 180, 40, 40);
                                var nanoclaw = new Pokemon("Nanoclaw", 200, 50, 50);
                                string choice;
                                bool usedChargeUp = false;
                                bool usedSystemRestore = false;

                                Console.WriteLine("\nAs you reach out, your hand successfully grasps the control panel, revealing its true nature as the interface for Cyberblaze, a magnificent cybernetically enhanced horse!");
                                Console.WriteLine("\nYou select Nanoclaw as the target and are presented with a selection of four moves: Volt Tackle, an electric-type attack move; Inferno Blast, a powerful fire-type attack move; Charge Up, a move that boosts your attack; and System Restore, a move that provides healing abilities.");

                                while (true)
                                {
                                    Console.WriteLine("\nChoose Cyberblaze's move: (1) Volt Tackle, (2) Inferno Blast [" + cyberblaze.InfernoBlastUses + "/5], (3) Charge Up, (4) System Restore");
                                    choice = Console.ReadLine();

                                    switch (choice)
                                    {
                                        case "1":
                                            cyberblaze.VoltTackle(nanoclaw);
                                            break;
                                        case "2":
                                            cyberblaze.InfernoBlast(nanoclaw);
                                            break;
                                        case "3":
                                            cyberblaze.ChargeUp();
                                            usedChargeUp = true;
                                            break;
                                        case "4":
                                            cyberblaze.SystemRestore();
                                            usedSystemRestore = true;
                                            break;
                                        default:
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("\nInvalid imput. Cyberblaze uses Volt Tackle by default.");
                                            Console.ResetColor();
                                            cyberblaze.VoltTackle(nanoclaw);
                                            break;
                                    }

                                    // Nanoclaw's moves and behavior
                                    nanoclaw.MoveCounter++;
                                    if (nanoclaw.MoveCounter % 10 == 0)
                                    {
                                        nanoclaw.MegaBite(cyberblaze);
                                    }
                                    else if (nanoclaw.MoveCounter % 5 == 0 && nanoclaw.HP < nanoclaw.MaxHP)
                                    {
                                        nanoclaw.CircuitReboot();
                                    }
                                    else if (nanoclaw.MoveCounter % 2 == 0)
                                    {
                                        nanoclaw.CyberScratch(cyberblaze);
                                    }
                                    else
                                    {
                                        nanoclaw.NanoBite(cyberblaze);
                                    }

                                    // Check if Cyberblaze is fainted
                                    if (cyberblaze.CheckIfFainted())
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\nNanoclaw wins!");
                                        Console.WriteLine("\nThe Nanoclaw mercilessly obliterates Cyberblaze. You are captured by Arasaka's security forces and sentenced to life in prison. The chilling echoes of your demise resonate, forever etching a tale of loss and devastation.. Your name is forgotten, your legacy erased.");
                                        Console.ResetColor();
                                        break;
                                        // prison ending (bad - red)
                                    }

                                    // Print Pokémon's HP
                                    Console.WriteLine("Cyberblaze HP: " + cyberblaze.HP + "/" + cyberblaze.MaxHP);
                                    Console.WriteLine("Nanoclaw HP: " + nanoclaw.HP + "/" + nanoclaw.MaxHP);

                                    // Check if Nanoclaw is fainted
                                    if (nanoclaw.CheckIfFainted())
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("\nCyberblaze wins!");
                                        Console.ResetColor();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("\nNanoclaw lies defeated at your feet, a mere memory of its former threat. Empowered by Cyberblaze, you seize the Digital Heart, a symbol of your victory over Arasaka's tyranny. Your names echo through Night City as legends, inspiring a resolute resistance against the corporations. Together, you ignite a revolution, toppling the oppressive regime and ushering in a new era of freedom and hope.");
                                        Console.ResetColor();
                                        // add Cyberblaze item to inventory
                                        // go back to preparationChoice
                                    }
                                }
                            }
                            else if (threatChoice.ToLower() == "run")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nYou run for your life, but Nanoclaw is too fast. You and Mia are torn to pieces.");
                                Console.ResetColor();
                                // torn to pieces ending (bad - red) 
                            }
                        }
                        else if (infiltrationChoice.ToLower() == "force")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"\nMia was unfortunately shot while trying to breach the highly advanced security systems of Arasaka. Despite your best efforts, both of you were overwhelmed by Arasaka's powerful mercenaries. Your sacrifice would be remembered as a courageous stand against impossible odds, inspiring others to fight against oppression.");
                            Console.ResetColor();
                            // shot ending (bad - red)
                        }
                    }
                    else if (locationChoice.ToLower() == "market")
                    {
                        /* 
                         * new choice - either start minigame or new bad ending (bad - red)
                         * if win: add newItem to inventory and go back to preparationChoice
                         * if lose: new bad ending (bad - red)
                        */
                    }

                else if (preparationHelper.ToLower() == "dex")
                {     
                /*
                * if the player doesnt have the items Admin key and Katana, he will be presented wuth this choice: Where would you like to go next, Arasaka Tower or the newLocation? (tower/new)
                * if he already has Katana in his inventory, he will be immediately sent to Undercity
                * if he already has Admin keay in his inventory, he will be immediately sent to Night Market
                */

                    Console.WriteLine("\nWhere would you like to go, The Undercity or the Night Market? (undercity/market)");
                    string locationChoice = Console.ReadLine();

                    while (locationChoice.ToLower() != "undercity" && locationChoice.ToLower() != "market")
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nInvalid input. Please enter 'undercity' or 'market'.");
                        Console.ResetColor();
                        locationChoice = Console.ReadLine();
                    }

                    if (locationChoice.ToLower() == "undercity")
                    {
                        Console.WriteLine("\nWhile navigating the treacherous Undercity, an Arasaka drone ambushes you. Will you shoot it down or employ your hacking skills to gain control? (shoot/hack)");
                        string droneChoice = Console.ReadLine();

                        while (droneChoice.ToLower() != "shoot" && droneChoice.ToLower() != "hack")
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\nInvalid input. Please enter 'shoot' or 'hack'.");
                            Console.ResetColor();
                            droneChoice = Console.ReadLine();
                        }

                        if (droneChoice.ToLower() == "shoot")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nYou shoot down the drone, but its distress signal brings a swarm of reinforcements. Overwhelmed, you and Dex tragically fall in the ensuing battle, leaving a legacy of unwavering determination against insurmountable odds.");
                            Console.ResetColor();
                            // swarmed ending (bad - red)
                        }
                        else if (droneChoice.ToLower() == " ")
                        {
                            // Hangman game scenario
                            Hangman game = new Hangman();
                            game.PlayGame();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\nInvalid input. Please enter 'shoot' or 'hack'.");
                            Console.ResetColor();
                        }
                    }
                    else if (locationChoice.ToLower() == "market")
                    {
                        Console.WriteLine("\nAs you wander through the night market, your attention is drawn to a mysterious figure lurking in the shadows. Would you like to approach this enigmatic presence? (yes/no)");
                        string marketApproach = Console.ReadLine();

                            // replace the choice betewwn yes and no in marketApproach with to choice to either approach the figure (Vex) which will lead to a new minigame or to approach a little girl which will lead to a new bad ending where the palyer gets stabbed by the girl (bad - red)

                            while (marketApproach.ToLower() != "yes" && marketApproach.ToLower() != "no")
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\nInvalid input. Please enter 'yes' or 'no'.");
                            Console.ResetColor();
                            marketApproach = Console.ReadLine();
                        }

                        if (marketApproach.ToLower() == "yes")
                        {
                            // Tic Tac Toe game scenario
                            TicTacToeGame game = new TicTacToeGame();

                            while (true)
                            {
                                game.DrawBoard();

                                if (game.CheckWin('X'))
                                {
                                    Console.WriteLine("\nAs the final move falls into place, the silence hangs heavy in the air. The enigmatic figure, Vex, reveals a twisted smile. But wait! The impossible has happened. Victory is yours! A surge of relief washes over you as you escape the clutches of Vex's deadly game.");
                                    // add Katana item to inventory and go back to preparationChoice
                                    break;
                                }
                                else if (game.CheckWin('O'))
                                {
                                    Console.WriteLine("\nDefeat engulfs you as the realization sinks in. Vex's twisted amusement grows, relishing in your demise. The slashes come swiftly, leaving no chance for redemption. Darkness takes hold, sealing your fate. Vex's laughter echoes through the Undercity, a chilling reminder of the price paid for failure.");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nDex selflessly intervenes, taking the fatal blow meant for you. His sacrifice fuels your determination to continue the fight against the corporations, carrying the weight of his memory.");
                                    Console.ResetColor();
                                    break;
                                    // Dex slashed ending (bad - red)
                                }
                                else if (game.IsBoardFull())
                                {
                                    Console.WriteLine("\nThe game reaches a stalemate, a draw that should bring relief. However, Vex's sadistic nature knows no bounds. Ignoring the rules, Vex strikes with ruthless fury, mercilessly slaying you. The silence is shattered by their chilling laughter, as the enigmatic figure revels in the twisted delight of an unfinished game. The chance for a wish slips away, forever lost in the realm of shattered hopes and cruel fate.");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nDex selflessly intervenes, taking the fatal blow meant for you. His sacrifice fuels your determination to continue the fight against the corporations, carrying the weight of his memory.");
                                    Console.ResetColor();
                                    break;
                                    // Dex slashed ending (bad - red)
                                }

                                if (game.GetCurrentPlayer() == 'X')
                                    PlayerMove(game);
                                else
                                    ComputerMove(game);
                            }

                            static void PlayerMove(TicTacToeGame game)
                            {
                                Console.WriteLine("\nEnter a number (1-9) to make your move: ");
                                int position;
                                bool isValidInput = int.TryParse(Console.ReadLine(), out position);
                                position--;

                                if (isValidInput && game.MakeMove(position))
                                {
                                    game.DrawBoard();
                                }
                                else
                                {
                                    Console.WriteLine("\nInvalid move! Try again.");
                                    PlayerMove(game);
                                }
                            }

                            static void ComputerMove(TicTacToeGame game)
                            {
                                int position = game.GetRandomMove();
                                game.MakeMove(position);
                                game.DrawBoard();
                            }
                        }
                        else if (marketApproach.ToLower() == "no")
                        {
                           // replace with little girl ending (bad - red)
                                Console.WriteLine("\nYou proceed with the heist but after securing the Digital Heart, you're ambushed by Arasaka's mercenaries. Do you choose to fight the corporate mercenaries with Dex's weaponry or utilize his pre-planned escape route? (fight/escape)");
                            string finalChoice = Console.ReadLine();

                            while (finalChoice.ToLower() != "fight" && finalChoice.ToLower() != "escape")
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\nInvalid input. Please enter 'fight' or 'escape'.");
                                Console.ResetColor();
                                finalChoice = Console.ReadLine();
                            }

                            if (finalChoice.ToLower() == "fight")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"\nWith Dex's strength and the weapons he secured, you put up a formidable fight. The mercenaries didn't stand a chance against your combined might. You managed to secure the Digital Heart, but Dex lost his life in the fight. His sacrifice allowed you, {playerName}, to become a legend of Night City. You fulfilled your dream and Dex's memory lived on.");
                                Console.ResetColor();
                            }
                            else if (finalChoice.ToLower() == "escape")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"\nUtilizing Dex's ingenious escape route, you successfully seize the Digital Heart. As Arasaka's mercenaries close in, you valiantly hold them off but tragically succumb to your injuries. Dex ensures your legacy lives on, spreading tales of your unmatched bravery throughout Night City. You, {playerName}, forever remain a revered legend, inspiring countless others in their fight for freedom.");
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\nInvalid input. Please enter 'yes' or 'no'.");
                            Console.ResetColor();
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nInvalid input. Please enter 'undercity' or 'market'.");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nInvalid input. Please enter 'mia' or 'dex'.");
                    Console.ResetColor();
                }
            }
            else if (importantChoice.ToLower() == "no")
            {
                // 
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nYou decide it's too risky. You continue your life in the streets of Night City, always wondering what might have been.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nInvalid input. Please enter 'yes' or 'no'.");
                Console.ResetColor();
            }
        }
    }
}