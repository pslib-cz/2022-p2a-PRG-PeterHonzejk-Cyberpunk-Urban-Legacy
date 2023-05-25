using System;

namespace Cyberpunk_Urban_Legacy
{
    class Program
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

            /* 
             * The code prompts the user to enter their name and proceeds with a cyberpunk-themed interactive text adventure game.
             * The player takes on the role of a young streetkid aspiring to become a legend by planning the greatest heist in Night City.
             * The code presents a series of choices and scenarios that determine the outcome of the heist and the player's legacy.
             * The code includes different scenarios based on the player's choices, involving characters like Mia and Dex, and mini-games like Tic Tac Toe and Hangman.
             * The code handles user input, validates choices, and displays appropriate messages based on the game's progress and outcomes.
             */

            Console.WriteLine("\nWelcome to Night City. What's your name?");
            string playerName = Console.ReadLine();

            Console.WriteLine($"\n{playerName}, you're a young streetkid aspiring to become a legend. You have a chance to plan the greatest heist Night City has ever witnessed: stealing the Digital Heart from Arasaka corporation. But it's dangerous. Do you wish to proceed? (yes/no)");

            string playerChoice = Console.ReadLine();

            if (playerChoice.ToLower() == "yes")
            {
                Console.WriteLine("\nYou courageously move forward with the plan, risking it all for a chance at greatness.");

                Console.WriteLine("\nYour closest friend, Mia, a bold and resourceful hacker, and Dex, a brave and physically strong fighter, are ready to help you. Who do you want to approach first for help? (Mia/Dex)");

                string firstHelper = Console.ReadLine();

                if (firstHelper.ToLower() == "mia")
                {
                    Console.WriteLine("\nMia helps you enhance your cybernetic implants and gather information about valuable targets.");

                    Console.WriteLine("\nYou still have some time before the heist. Where would you like to go next, Arasaka Tower or the Night Market? (tower/market)");
                    string locationChoice = Console.ReadLine();

                    if (locationChoice.ToLower() == "tower")
                    {
                        Console.WriteLine("\nYou arrive at Arasaka Tower. The security is tight. You need to find a way to get in. Do you sneak in or force your way in? (sneak/force)");
                        string arasakaTowerChoice = Console.ReadLine();

                        if (arasakaTowerChoice.ToLower() == "sneak")
                        {
                            Console.WriteLine("\nYou successfully sneak into the Arasaka tower and gather crucial information about the bank. Unfortunately, on your way out, you encounter one of Arasaka's best security measures: Nanoclaw, a cybernetically enhanced tiger. You notice something resembling a gamepad on the desk next to you. Will you try to reach for it or make a run for it? (reach/run)");
                            string nanoclawChoice = Console.ReadLine();

                            if (nanoclawChoice.ToLower() == "reach")
                            {
                                // Pokemon battle scenario
                                var cyberblaze = new Pokemon("Cyberblaze", 200, 40, 40);
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
                                            Console.WriteLine("\nInvalid choice. Cyberblaze uses Volt Tackle by default.");
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
                                        Console.WriteLine("\nThe Nanoclaw mercilessly obliterates Cyberblaze. You are captured by Arasaka's security forces and sentenced to life in prison. The chilling echoes of your demise resonate, forever etching a tale of loss and devastation. Your name is forgotten, your legacy erased.");
                                        Console.ResetColor();
                                        break;
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
                                    }
                                }
                            }
                            else if (nanoclawChoice.ToLower() == "run")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nYou run for your life, but Nanoclaw is too fast. You and Mia are torn to pieces.");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine("\nInvalid choice. Please try again.");
                                continue;
                            }
                        }
                        else if (arasakaTowerChoice.ToLower() == "force")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"\nMia was unfortunately shot while trying to breach the highly advanced security systems of Arasaka. Despite your best efforts, both of you were overwhelmed by Arasaka's powerful mercenaries. Your sacrifice would be remembered as a courageous stand against impossible odds, inspiring others to fight against oppression.");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid choice. Please try again.");
                            continue;
                        }
                    }
                    else if (locationChoice.ToLower() == "market")
                    {
                        Console.WriteLine("\nAs you wander through the night market, your attention is drawn to a mysterious figure lurking in the shadows. Would you like to approach this enigmatic presence? (yes/no)");
                        string nightApproach = Console.ReadLine();

                        if (nightApproach.ToLower() == "yes")
                        {
                            // Tic Tac Toe game scenario
                            TicTacToeGame game = new TicTacToeGame();

                            while (true)
                            {
                                game.DrawBoard();

                                if (game.CheckWin('X'))
                                {
                                    Console.WriteLine("\nAs the final move falls into place, the enigmatic figure, Vex, reveals a twisted smile. But wait! The impossible has happened. Victory is yours! You escape the clutches of Vex's deadly game.");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nEmpowered by Vex's assistance, you cunningly steal the Digital Heart and swiftly dispatch the formidable Arasaka mercenaries. You rise as a legend of Night City, inspiring a resolute resistance against the oppressive corporations. Vex's legacy becomes intertwined with your triumph.");
                                    Console.ResetColor();
                                    break;
                                }
                                else if (game.CheckWin('O'))
                                {
                                    Console.WriteLine("\nDefeat engulfs you as the realization sinks in. Vex's twisted amusement grows, relishing in your demise. The slashes come swiftly, leaving no chance for redemption. Darkness takes hold, sealing your fate. Vex's laughter echoes through the Undercity, a chilling reminder of the price paid for failure.");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nMia arrives too late. Vex disappears, leaving a void in their wake. With your untimely demise, Mia carries the weight of loss, forever marked by the memory of your tragic end.");
                                    Console.ResetColor();
                                    break;
                                }
                                else if (game.IsBoardFull())
                                {
                                    Console.WriteLine("\nThe game reaches a stalemate, a draw that should bring relief. However, Vex's sadistic nature knows no bounds. Ignoring the rules, Vex strikes with ruthless fury, mercilessly slaying you. The silence is shattered by their chilling laughter, as the enigmatic figure revels in the twisted delight of an unfinished game. The chance for a wish slips away, forever lost in the realm of shattered hopes and cruel fate.");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nMia arrives too late. Vex disappears, leaving a void in their wake. With your untimely demise, Mia carries the weight of loss, forever marked by the memory of your tragic end.");
                                    Console.ResetColor();
                                    break;
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
                        else if (nightApproach.ToLower() == "no")
                        {
                            Console.WriteLine("\nYou proceed with the heist and arrive at the Bank. Do you choose to fight the corporate mercenaries protecting the Digital Heart using Mia's hacking skills or take advantage of her data to find a hidden escape route? (fight/escape)");
                            string finalChoice = Console.ReadLine();

                            if (finalChoice.ToLower() == "fight")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"\nWith Mia's hacking abilities, you manage to take control of the security systems and turn them against the mercenaries. However, during the fight, you sustain severe injuries. {playerName}, you became a symbol of resistance against the corporations, and your bravery inspired many.");
                                Console.ResetColor();
                            }
                            else if (finalChoice.ToLower() == "escape")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"\nUsing the detailed data Mia had gathered, you find a hidden escape route and manage to break free with the Digital Heart.  Mia sacrifices herself, allowing you, {playerName}, to escape and become a symbol of resistance in Night City, carrying on her legacy.");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine("\nInvalid choice. Please try again.");
                                continue;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid choice. Please try again.");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid choice. Please try again.");
                        continue;
                    }
                }
                else if (firstHelper.ToLower() == "dex")
                {
                    Console.WriteLine("\nDex takes care of securing weaponry and the escape route. With his help, you are ready for the infiltration.");

                    Console.WriteLine("\nYou still have some time before the heist. Where would you like to go next, The Undercity or the Night Market? (undercity/market)");
                    string locationChoice = Console.ReadLine();

                    if (locationChoice.ToLower() == "undercity")
                    {
                        Console.WriteLine("\nWhile navigating the treacherous Undercity, an Arasaka drone ambushes you. Will you shoot it down or employ your hacking skills to gain control? (shoot/hack)");
                        string droneChoice = Console.ReadLine();

                        if (droneChoice.ToLower() == "shoot")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nYou shoot down the drone, but its distress signal brings a swarm of reinforcements. Overwhelmed, you and Dex tragically fall in the ensuing battle, leaving a legacy of unwavering determination against insurmountable odds.");
                            Console.ResetColor();
                        }
                        else if (droneChoice.ToLower() == "hack")
                        {
                            // Hangman game scenario
                            Hangman game = new Hangman();
                            game.PlayGame();
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid choice. Please try again.");
                            continue;
                        }
                    }
                    else if (locationChoice.ToLower() == "market")
                    {
                        Console.WriteLine("\nAs you wander through the night market, your attention is drawn to a mysterious figure lurking in the shadows. Would you like to approach this enigmatic presence? (yes/no)");
                        string nightApproach = Console.ReadLine();

                        if (nightApproach.ToLower() == "yes")
                        {
                            // Tic Tac Toe game scenario
                            TicTacToeGame game = new TicTacToeGame();

                            while (true)
                            {
                                game.DrawBoard();

                                if (game.CheckWin('X'))
                                {
                                    Console.WriteLine("\nAs the final move falls into place, the silence hangs heavy in the air. The enigmatic figure, Vex, reveals a twisted smile. But wait! The impossible has happened. Victory is yours! A surge of relief washes over you as you escape the clutches of Vex's deadly game.");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nEmpowered by Vex's assistance, you cunningly steal the Digital Heart and swiftly dispatch the formidable Arasaka mercenaries. As legends of Night City, you and Mia rise as beacons of resistance against the oppressive corporations. Vex, their enigmatic presence fading into the shadows, leaves behind a legacy intertwined with your triumph.");
                                    Console.ResetColor();
                                    break;
                                }
                                else if (game.CheckWin('O'))
                                {
                                    Console.WriteLine("\nDefeat engulfs you as the realization sinks in. Vex's twisted amusement grows, relishing in your demise. The slashes come swiftly, leaving no chance for redemption. Darkness takes hold, sealing your fate. Vex's laughter echoes through the Undercity, a chilling reminder of the price paid for failure.");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nDex selflessly intervenes, taking the fatal blow meant for you. His sacrifice fuels your determination to continue the fight against the corporations, carrying the weight of his memory.");
                                    Console.ResetColor();
                                    break;
                                }
                                else if (game.IsBoardFull())
                                {
                                    Console.WriteLine("\nThe game reaches a stalemate, a draw that should bring relief. However, Vex's sadistic nature knows no bounds. Ignoring the rules, Vex strikes with ruthless fury, mercilessly slaying you. The silence is shattered by their chilling laughter, as the enigmatic figure revels in the twisted delight of an unfinished game. The chance for a wish slips away, forever lost in the realm of shattered hopes and cruel fate.");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nDex selflessly intervenes, taking the fatal blow meant for you. His sacrifice fuels your determination to continue the fight against the corporations, carrying the weight of his memory.");
                                    Console.ResetColor();
                                    break;
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
                        else if (nightApproach.ToLower() == "no")
                        {
                            Console.WriteLine("\nYou proceed with the heist but after securing the Digital Heart, you're ambushed by Arasaka's mercenaries. Do you choose to fight the corporate mercenaries with Dex's weaponry or utilize his pre-planned escape route? (fight/escape)");
                            string finalChoice = Console.ReadLine();

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
                            else
                            {
                                Console.WriteLine("\nInvalid choice. Please try again.");
                                continue;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid choice. Please try again.");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid choice. Please try again.");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid choice. Please try again.");
                    continue;
                }
            }
            else if (playerChoice.ToLower() == "no")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nYou decide it's too risky. You continue your life in the streets of Night City, always wondering what might have been.");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("\nInvalid choice. Please try again.");
                continue;
            }
        }
    }
}
