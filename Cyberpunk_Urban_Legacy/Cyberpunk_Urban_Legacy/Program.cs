using System;
using System.Collections.Generic;

namespace Cyberpunk_Urban_Legacy
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> endings = new List<string>();
            bool gameContinue = true;

            // Prompt for player's name
            Console.WriteLine("\nWelcome to Night City. What's your name?");
            string playerName = Console.ReadLine();

            // save game state with the unlocked endings and player's name !!!
            
            // Game loop until all endings are unlocked
            while (gameContinue == true)
            {
                if (endings.Count == 17)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nYou have unlocked all endings.");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nCongratulations!");
                    Console.ResetColor();
                    gameContinue = false;
                }
                else
                {
                    if (endings.Count >= 1)
                    {
                        Console.WriteLine($"\nYou have unlocked {endings.Count} out of 17 possible endings.");
                        Console.WriteLine("\nYou have unlocked the following ending/s so far:");
                        foreach (var ending in endings)
                        {
                            Console.WriteLine(ending);
                        }
                    }

                    // Introduction and choice to proceed with the heist
                    Console.WriteLine($"\n{playerName}, you're a young streetkid aspiring to become a legend. You have a chance to plan the greatest heist Night City has ever witnessed: stealing the Digital Heart from Arasaka corporation. But it's dangerous. Do you wish to proceed? (yes/no)");

                    bool preparationsContinue = true;
                    List<string> inventory = new List<string>();
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
                        // Player chooses to proceed with the heist
                        Console.WriteLine("\nYou courageously move forward with the plan, risking it all for a chance at greatness.");

                        while (preparationsContinue == true)
                        {
                            if (inventory.Contains("Cyberblaze") && inventory.Contains("AdminKey") && inventory.Contains("Katana"))
                            {
                                // Player has all items and can proceed to the heist
                                Console.WriteLine("\nYou are well prepared and ready to proceed with the heist. Will you bring anyone along? (mia/dex/ciper/miadex/miacipher/dexcipher/everyone/alone)");

                                string heistChoice = Console.ReadLine();

                                // Check the chosen heist option and play the corresponding scenario
                                if (heistChoice.ToLower() == "mia")
                                {
                                    // Heart of Shadows ending
                                    // Maa is a Techie and brings along the cybernetically enhanced horse, Cyberblaze that she helped you to steal from the Arasaka tower
                                    // Mia sacrifices herself to save the player but the Digital Heart is destroyed
                                    endings.Add("Heart of Shadows");
                                    string continueChoice = Console.ReadLine();
                                    while (continueChoice.ToLower() != "yes" && continueChoice.ToLower() != "no")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("\nInvalid input. Please enter 'yes' or 'no'.");
                                        Console.ResetColor();
                                        continueChoice = Console.ReadLine();
                                    }
                                    if (continueChoice.ToLower() == "yes")
                                    {
                                        Console.WriteLine("\nYou continue playing.");
                                        preparationsContinue = false;

                                    }
                                    else if (continueChoice.ToLower() == "no")
                                    {
                                        Console.WriteLine("\nYou quit the game.");
                                        gameContinue = false;
                                    }
                                }
                                else if (heistChoice.ToLower() == "cipher")
                                {
                                    // Code of Sacrifice ending
                                    // Cipher is a Netrunner and brings along the Admin Key that he helped you obtain from the drone in Undercity
                                    // Cipher sacrifices himself to save the playerbut the Digital Heart is destroyed
                                    endings.Add("Code of Sacrifice");
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("\nYou have unlocked the Code of Sacrifice ending. Would you like to continue playing? (yes/no)");
                                    Console.ResetColor();
                                    string continueChoice = Console.ReadLine();
                                    while (continueChoice.ToLower() != "yes" && continueChoice.ToLower() != "no")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("\nInvalid input. Please enter 'yes' or 'no'.");
                                        Console.ResetColor();
                                        continueChoice = Console.ReadLine();
                                    }
                                    if (continueChoice.ToLower() == "yes")
                                    {
                                        Console.WriteLine("\nYou continue playing.");
                                        preparationsContinue = false;

                                    }
                                    else if (continueChoice.ToLower() == "no")
                                    {
                                        Console.WriteLine("\nYou quit the game.");
                                        gameContinue = false;
                                    }
                                }
                                else if (heistChoice.ToLower() == "dex")
                                {
                                    // Nomadic Heroism ending
                                    // Dex is a Nomad and brings along the Katana that he helped you obtain from Vex in the Night Market
                                    // Dex sacrifices himself to save the player but the Digital Heart is destroyed
                                    endings.Add("Nomadic Heroism");
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("\nYou have unlocked the Nomadic Heroism ending. Would you like to continue playing? (yes/no)");
                                    Console.ResetColor();
                                    string continueChoice = Console.ReadLine();
                                    while (continueChoice.ToLower() != "yes" && continueChoice.ToLower() != "no")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("\nInvalid input. Please enter 'yes' or 'no'.");
                                        Console.ResetColor();
                                        continueChoice = Console.ReadLine();
                                    }
                                    if (continueChoice.ToLower() == "yes")
                                    {
                                        Console.WriteLine("\nYou continue playing.");
                                        preparationsContinue = false;

                                    }
                                    else if (continueChoice.ToLower() == "no")
                                    {
                                        Console.WriteLine("\nYou quit the game.");
                                        gameContinue = false;
                                    }
                                }
                                else if (heistChoice.ToLower() == "miadex")
                                {
                                    // Joint Sacrifice ending
                                    // Code for heist with Mia and Dex
                                    // The player sacrifices himself to save Mia and Dex and they steal the Digital Heart
                                    endings.Add("Joint Sacrifice");
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("\nYou have unlocked the Joint Sacrifice ending. Would you like to continue playing? (yes/no)");
                                    Console.ResetColor();
                                    string continueChoice = Console.ReadLine();
                                    while (continueChoice.ToLower() != "yes" && continueChoice.ToLower() != "no")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("\nInvalid input. Please enter 'yes' or 'no'.");
                                        Console.ResetColor();
                                        continueChoice = Console.ReadLine();
                                    }
                                    if (continueChoice.ToLower() == "yes")
                                    {
                                        Console.WriteLine("\nYou continue playing.");
                                        preparationsContinue = false;

                                    }
                                    else if (continueChoice.ToLower() == "no")
                                    {
                                        Console.WriteLine("\nYou quit the game.");
                                        gameContinue = false;
                                    }
                                }
                                else if (heistChoice.ToLower() == "miacipher")
                                {
                                    // United Resolve ending
                                    // Code for heist with Mia and Cipher
                                    // The player sacrifices himself to save Mia and Cipher and they steal the Digital Heart
                                    endings.Add("United Resolve");
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("\nYou have unlocked the United Resolve ending. Would you like to continue playing? (yes/no)");
                                    Console.ResetColor();
                                    string continueChoice = Console.ReadLine();
                                    while (continueChoice.ToLower() != "yes" && continueChoice.ToLower() != "no")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("\nInvalid input. Please enter 'yes' or 'no'.");
                                        Console.ResetColor();
                                        continueChoice = Console.ReadLine();
                                    }
                                    if (continueChoice.ToLower() == "yes")
                                    {
                                        Console.WriteLine("\nYou continue playing.");
                                        preparationsContinue = false;

                                    }
                                    else if (continueChoice.ToLower() == "no")
                                    {
                                        Console.WriteLine("\nYou quit the game.");
                                        gameContinue = false;
                                    }
                                }
                                else if (heistChoice.ToLower() == "dexcipher")
                                {
                                    // Covert Alliance ending
                                    // Code for heist with Dex and Cipher
                                    // The player sacrifices himself to save Dex and Cipher and they steal the Digital Heart
                                    endings.Add("Covert Alliance");
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("\nYou have unlocked the Covert Alliance ending. Would you like to continue playing? (yes/no)");
                                    Console.ResetColor();
                                    string continueChoice = Console.ReadLine();
                                    while (continueChoice.ToLower() != "yes" && continueChoice.ToLower() != "no")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("\nInvalid input. Please enter 'yes' or 'no'.");
                                        Console.ResetColor();
                                        continueChoice = Console.ReadLine();
                                    }
                                    if (continueChoice.ToLower() == "yes")
                                    {
                                        Console.WriteLine("\nYou continue playing.");
                                        preparationsContinue = false;

                                    }
                                    else if (continueChoice.ToLower() == "no")
                                    {
                                        Console.WriteLine("\nYou quit the game.");
                                        gameContinue = false;
                                    }
                                }
                                else if (heistChoice.ToLower() == "everyone")
                                {
                                    // Unity of Shadows ending
                                    // Code for heist with everyone
                                    // Everyone survives and they steal the Digital Heart
                                    endings.Add("Unity of Shadows");
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("\nYou have unlocked the Unity of Shadows ending. Would you like to continue playing? (yes/no)");
                                    Console.ResetColor();
                                    string continueChoice = Console.ReadLine();
                                    while (continueChoice.ToLower() != "yes" && continueChoice.ToLower() != "no")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("\nInvalid input. Please enter 'yes' or 'no'.");
                                        Console.ResetColor();
                                        continueChoice = Console.ReadLine();
                                    }
                                    if (continueChoice.ToLower() == "yes")
                                    {
                                        Console.WriteLine("\nYou continue playing.");
                                        preparationsContinue = false;

                                    }
                                    else if (continueChoice.ToLower() == "no")
                                    {
                                        Console.WriteLine("\nYou quit the game.");
                                        gameContinue = false;
                                    }
                                }
                                else if (heistChoice.ToLower() == "alone")
                                {
                                    // Last Stand ending
                                    // Code for heist alone
                                    // The player dies and destroys the Digital Heart
                                    endings.Add("Last Stand");
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("\nYou have unlocked the Last Stand ending. Would you like to continue playing? (yes/no)");
                                    Console.ResetColor();
                                    string continueChoice = Console.ReadLine();
                                    while (continueChoice.ToLower() != "yes" && continueChoice.ToLower() != "no")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("\nInvalid input. Please enter 'yes' or 'no'.");
                                        Console.ResetColor();
                                        continueChoice = Console.ReadLine();
                                    }
                                    if (continueChoice.ToLower() == "yes")
                                    {
                                        Console.WriteLine("\nYou continue playing.");
                                        preparationsContinue = false;

                                    }
                                    else if (continueChoice.ToLower() == "no")
                                    {
                                        Console.WriteLine("\nYou quit the game.");
                                        gameContinue = false;
                                    }
                                }

                                while (heistChoice.ToLower() != "mia" && heistChoice.ToLower() != "cipher" && heistChoice.ToLower() != "dex" && heistChoice.ToLower() != "miadex" && heistChoice.ToLower() != "miacipher" && heistChoice.ToLower() != "dexcipher" && heistChoice.ToLower() != "everyone" && heistChoice.ToLower() != "alone")
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("\nInvalid input. Please enter a valid choice.");
                                    Console.ResetColor();
                                    heistChoice = Console.ReadLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nWhere would you like to go next? Arasaka tower, the Undercity or the Night market? (tower/undercity/market)");
                                string locationChoice = Console.ReadLine();

                                if (locationChoice == "tower")
                                {
                                    Console.WriteLine("\nYou arrive at Arasaka Tower. The security is tight. You need to find a way to get in. Do you sneak in or force your way in? (sneak/force)");
                                    string arasakaTowerChoice = Console.ReadLine();

                                    while (arasakaTowerChoice.ToLower() != "sneak" && arasakaTowerChoice.ToLower() != "force")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("\nInvalid input. Please enter 'sneak' or 'force'.");
                                        Console.ResetColor();
                                        arasakaTowerChoice = Console.ReadLine();
                                    }

                                    if (arasakaTowerChoice.ToLower() == "sneak")
                                    {
                                        Console.WriteLine("\nYou successfully sneak into the Arasaka tower and gather crucial information about the bank. Unfortunately, on your way out, you encounter one of Arasaka's best security measures: Nanoclaw, a cybernetically enhanced tiger. You notice something resembling a gamepad on the desk next to you. Will you try to reach for it or make a run for it? (reach/run)");
                                        string nanoclawChoice = Console.ReadLine();

                                        while (nanoclawChoice.ToLower() != "reach" && nanoclawChoice.ToLower() != "run")
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine("\nInvalid input. Please enter 'reach' or 'run'.");
                                            Console.ResetColor();
                                            nanoclawChoice = Console.ReadLine();
                                        }

                                        if (nanoclawChoice.ToLower() == "reach")
                                        {
                                            // Pokemon battle scenario
                                            bool continuePokemon = true;
                                            var cyberblaze = new Pokemon("Cyberblaze", 180, 40, 40);
                                            var nanoclaw = new Pokemon("Nanoclaw", 200, 50, 50);
                                            string choice;

                                            Console.WriteLine("\nAs you reach out, your hand successfully grasps the control panel, revealing its true nature as the interface for Cyberblaze, a magnificent cybernetically enhanced horse!");
                                            Console.WriteLine("\nYou select Nanoclaw as the target and are presented with a selection of four moves: Volt Tackle, an electric-type attack move; Inferno Blast, a powerful fire-type attack move; Charge Up, a move that boosts your attack; and System Restore, a move that provides healing abilities.");

                                            while (continuePokemon)
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
                                                        break;
                                                    case "4":
                                                        cyberblaze.SystemRestore();
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

                                                // Print Pokémon's HP
                                                Console.WriteLine("Cyberblaze HP: " + cyberblaze.HP + "/" + cyberblaze.MaxHP);
                                                Console.WriteLine("Nanoclaw HP: " + nanoclaw.HP + "/" + nanoclaw.MaxHP);

                                                // Check if Cyberblaze is fainted
                                                if (cyberblaze.CheckIfFainted())
                                                {
                                                    // Eternal Imprisonment ending
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("\nNanoclaw wins!");
                                                    Console.WriteLine("\nThe Nanoclaw mercilessly obliterates Cyberblaze. You are captured by Arasaka's security forces and sentenced to life in prison. The chilling echoes of your demise resonate, forever etching a tale of loss and devastation.. Your name is forgotten, your legacy erased.");
                                                    Console.ResetColor();
                                                    continuePokemon = false;
                                                    endings.Add("Eternal Imprisonment");
                                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                                    Console.WriteLine("\nYou have unlocked the Eternal Imprisonment ending. Would you like to continue playing? (yes/no)");
                                                    Console.ResetColor();
                                                    string continueChoice = Console.ReadLine();
                                                    while (continueChoice.ToLower() != "yes" && continueChoice.ToLower() != "no")
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                                        Console.WriteLine("\nInvalid input. Please enter 'yes' or 'no'.");
                                                        Console.ResetColor();
                                                        continueChoice = Console.ReadLine();
                                                    }
                                                    if (continueChoice.ToLower() == "yes")
                                                    {
                                                        Console.WriteLine("\nYou continue playing.");
                                                        preparationsContinue = false;

                                                    }
                                                    else if (continueChoice.ToLower() == "no")
                                                    {
                                                        Console.WriteLine("\nYou quit the game.");
                                                        gameContinue = false;
                                                    }
                                                }

                                                // Check if Nanoclaw is fainted
                                                if (nanoclaw.CheckIfFainted())
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                                    Console.WriteLine("\nCyberblaze wins!");
                                                    Console.ResetColor();
                                                    continuePokemon = false;
                                                    inventory.Add("Cyberblaze");
                                                }
                                            }
                                        }
                                        else if (nanoclawChoice.ToLower() == "run")
                                        {
                                            // Devoured Hope ending
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("\nYou run for your life, but Nanoclaw is too fast. You and Mia are torn to pieces.");
                                            Console.ResetColor();
                                            endings.Add("Devoured Hope");
                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            Console.WriteLine("\nYou have unlocked the Devoured Hope ending. Would you like to continue playing? (yes/no)");
                                            Console.ResetColor();
                                            string continueChoice = Console.ReadLine();
                                            while (continueChoice.ToLower() != "yes" && continueChoice.ToLower() != "no")
                                            {
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine("\nInvalid input. Please enter 'yes' or 'no'.");
                                                Console.ResetColor();
                                                continueChoice = Console.ReadLine();
                                            }
                                            if (continueChoice.ToLower() == "yes")
                                            {
                                                Console.WriteLine("\nYou continue playing.");
                                                preparationsContinue = false;

                                            }
                                            else if (continueChoice.ToLower() == "no")
                                            {
                                                Console.WriteLine("\nYou quit the game.");
                                                gameContinue = false;
                                            }
                                        }
                                    }
                                    else if (arasakaTowerChoice.ToLower() == "force")
                                    {
                                        // Overpowered Resistance ending
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine($"\nMia was unfortunately shot while trying to breach the highly advanced security systems of Arasaka. Despite your best efforts, both of you were overwhelmed by Arasaka's powerful mercenaries. Your sacrifice would be remembered as a courageous stand against impossible odds, inspiring others to fight against oppression.");
                                        Console.ResetColor();
                                        endings.Add("Overpowered Resistance");
                                        Console.ForegroundColor = ConsoleColor.Magenta;
                                        Console.WriteLine("\nYou have unlocked the Overpowered Resistance ending. Would you like to continue playing? (yes/no)");
                                        Console.ResetColor();
                                        string continueChoice = Console.ReadLine();
                                        while (continueChoice.ToLower() != "yes" && continueChoice.ToLower() != "no")
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine("\nInvalid input. Please enter 'yes' or 'no'.");
                                            Console.ResetColor();
                                            continueChoice = Console.ReadLine();
                                        }
                                        if (continueChoice.ToLower() == "yes")
                                        {
                                            Console.WriteLine("\nYou continue playing.");
                                            preparationsContinue = false;

                                        }
                                        else if (continueChoice.ToLower() == "no")
                                        {
                                            Console.WriteLine("\nYou quit the game.");
                                            gameContinue = false;
                                        }
                                    }
                                }
                                else if (locationChoice == "undercity")
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
                                        // Devastating Swarm ending
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\nYou shoot down the drone, but its distress signal brings a swarm of reinforcements. Overwhelmed, you and Dex tragically fall in the ensuing battle, leaving a legacy of unwavering determination against insurmountable odds.");
                                        Console.ResetColor();
                                        endings.Add("Devastating Swarm");
                                        Console.ForegroundColor = ConsoleColor.Magenta;
                                        Console.WriteLine("\nYou have unlocked the Devastating Swarm ending. Would you like to continue playing? (yes/no)");
                                        Console.ResetColor();
                                        string continueChoice = Console.ReadLine();
                                        while (continueChoice.ToLower() != "yes" && continueChoice.ToLower() != "no")
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine("\nInvalid input. Please enter 'yes' or 'no'.");
                                            Console.ResetColor();
                                            continueChoice = Console.ReadLine();
                                        }
                                        if (continueChoice.ToLower() == "yes")
                                        {
                                            Console.WriteLine("\nYou continue playing.");
                                            preparationsContinue = false;

                                        }
                                        else if (continueChoice.ToLower() == "no")
                                        {
                                            Console.WriteLine("\nYou quit the game.");
                                            gameContinue = false;
                                        }
                                    }
                                    else if (droneChoice.ToLower() == "hack")
                                    {
                                        PlayHangman(inventory, endings, ref preparationsContinue, ref gameContinue);
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("\nInvalid input. Please enter 'shoot' or 'hack'.");
                                        Console.ResetColor();
                                    }
                                }
                                else if (locationChoice == "market")
                                {
                                    Console.WriteLine("\nAs you wander through the night market, you see two people. A figure in the shadow and a little girl. Who will you ask for information? (figure/girl)");
                                    string nightApproach = Console.ReadLine();

                                    while (nightApproach.ToLower() != "figure" && nightApproach.ToLower() != "girl")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("\nInvalid input. Please enter 'figure' or 'girl'.");
                                        Console.ResetColor();
                                        nightApproach = Console.ReadLine();
                                    }

                                    if (nightApproach.ToLower() == "figure")
                                    {
                                        PlayTicTacToe(inventory, endings, ref preparationsContinue, ref gameContinue);
                                    }
                                    else if (nightApproach.ToLower() == "girl")
                                    {
                                        // Deceptive Innocence ending
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\r\nYou approach the innocent-looking little girl, she suddenly reveals a wicked smile and swiftly jabbsyou with a seemingly harmless toy. The poison coursing through your veins, your vision blurred, and darkness enveloped him, your final choice haunting you for eternity.");
                                        Console.ResetColor();
                                       
                                        endings.Add("Deceptive Innocence");
                                        Console.ForegroundColor = ConsoleColor.Magenta;
                                        Console.WriteLine("\nYou have unlocked the Deceptive Innocence ending. Would you like to continue playing? (yes/no)");
                                        Console.ResetColor();
                                        string continueChoice = Console.ReadLine();
                                        while (continueChoice.ToLower() != "yes" && continueChoice.ToLower() != "no")
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine("\nInvalid input. Please enter 'yes' or 'no'.");
                                            Console.ResetColor();
                                            continueChoice = Console.ReadLine();
                                        }
                                        if (continueChoice.ToLower() == "yes")
                                        {
                                            Console.WriteLine("\nYou continue playing.");
                                            preparationsContinue = false;

                                        }
                                        else if (continueChoice.ToLower() == "no")
                                        {
                                            Console.WriteLine("\nYou quit the game.");
                                            gameContinue = false;
                                        }
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("\nInvalid input. Please enter a valid answer.");
                                        Console.ResetColor();
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("\nInvalid input. Please enter a valid location.");
                                    Console.ResetColor();
                                }
                            }
                        }
                    }
                    else if (importantChoice.ToLower() == "no")
                    {
                        // Dreams Unfulfilled ending
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\nYou decide it's too risky. You continue your life in the streets of Night City, always wondering what might have been.");
                        Console.ResetColor();
                        endings.Add("Dreams Unfulfilled");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\nYou have unlocked the Dreams Unfulfilled ending. Would you like to continue playing? (yes/no)");
                        Console.ResetColor();
                        string continueChoice = Console.ReadLine();
                        while (continueChoice.ToLower() != "yes" && continueChoice.ToLower() != "no")
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\nInvalid input. Please enter 'yes' or 'no'.");
                            Console.ResetColor();
                            continueChoice = Console.ReadLine();
                        }
                        if (continueChoice.ToLower() == "yes")
                        {
                            Console.WriteLine("\nYou continue playing.");
                            preparationsContinue = false;

                        }
                        else if (continueChoice.ToLower() == "no")
                        {
                            Console.WriteLine("\nYou quit the game.");
                            gameContinue = false;
                        }
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

        static void PlayHangman(List<string> inventory, List<string> endings, ref bool preparationsContinue, ref bool gameContinue)
        {
            // Array of possible passwords for the game
            string[] passwords = {
                "NeonShadow",
                "CodeCyber",
                "SynthWave",
                "ByteBlade",
                "DigitalNexus",
                "CyberPulse",
                "QuantumByte",
                "Cybernetica",
                "TechBlitz",
                "NanoCipher"
            };

            string password;
            char[] maskedPassword;
            int attempts;
            List<char> guessedLetters;

            Console.WriteLine("You have ten attempts to guess the password and breach the drone's system.\n");

            Random random = new Random();
            int index = random.Next(passwords.Length);
            password = passwords[index];

            maskedPassword = new char[password.Length];
            for (int i = 0; i < password.Length; i++)
            {
                // Initialize masked password with asterisks (*) except for spaces
                if (password[i] != ' ')
                {
                    maskedPassword[i] = '*';
                }
                else
                {
                    maskedPassword[i] = ' ';
                }
            }

            attempts = 10;
            guessedLetters = new List<char>();

            while (true)
            {
                Console.WriteLine("Attempts Left: " + attempts);
                Console.WriteLine("Password: " + new string(maskedPassword));
                Console.Write("Guess a letter: ");
                char guess = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (char.IsLetter(guess))
                {
                    if (guessedLetters.Contains(guess))
                    {
                        Console.WriteLine("You already guessed that letter. Try again.");
                    }
                    else
                    {
                        guessedLetters.Add(guess);

                        bool correctGuess = false;
                        for (int i = 0; i < password.Length; i++)
                        {
                            if (char.ToUpper(password[i]) == guess)
                            {
                                maskedPassword[i] = password[i];
                                correctGuess = true;
                            }
                        }

                        if (correctGuess)
                        {
                            if (new string(maskedPassword) == password)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Successfully hacking into the drone grants you access to an admin key to Arasaka's network.");
                                Console.ResetColor();
                                inventory.Add("AdminKey");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Incorrect guess!");
                            attempts--;

                            if (attempts <= 0)
                            {
                                // Fatal Encryption ending
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Regrettably, your unsuccessful attempt to hack the drone triggers a fatal response, resulting in a wipe of memory that ends your life.");
                                Console.ResetColor();
                                endings.Add("Fatal Encryption");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("\nYou have unlocked the Fatal Encryption ending. Would you like to continue playing? (yes/no)");
                                Console.ResetColor();
                                string continueChoice = Console.ReadLine();
                                while (continueChoice.ToLower() != "yes" && continueChoice.ToLower() != "no")
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("\nInvalid input. Please enter 'yes' or 'no'.");
                                    Console.ResetColor();
                                    continueChoice = Console.ReadLine();
                                }
                                if (continueChoice.ToLower() == "yes")
                                {
                                    Console.WriteLine("\nYou continue playing.");
                                    preparationsContinue = false;

                                }
                                else if (continueChoice.ToLower() == "no")
                                {
                                    Console.WriteLine("\nYou quit the game.");
                                    gameContinue = false;
                                }
                                break;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid letter.");
                }

                Console.WriteLine();
            }
        }

        static void PlayTicTacToe(List<string> inventory, List<string> endings, ref bool preparationsContinue, ref bool gameContinue)
        {
            TicTacToeGame game = new TicTacToeGame();

            while (true)
            {
                game.DrawBoard();

                if (game.CheckWin('X'))
                {
                    Console.WriteLine("\nAs the final move falls into place, the silence hangs heavy in the air. The enigmatic figure, Vex, reveals a twisted smile. But wait! The impossible has happened. Victory is yours! A surge of relief washes over you as you escape the clutches of Vex's deadly game.");
                    inventory.Add("Katana");
                    break;
                }
                else if (game.CheckWin('O'))
                {
                    // Echoing Laughter ending
                    Console.WriteLine("\nDefeat engulfs you as the realization sinks in. Vex's twisted amusement grows, relishing in your demise. The slashes come swiftly, leaving no chance for redemption. Darkness takes hold, sealing your fate. Vex's laughter echoes through the Undercity, a chilling reminder of the price paid for failure.");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nDex selflessly intervenes, taking the fatal blow meant for you. His sacrifice fuels your determination to continue the fight against the corporations, carrying the weight of his memory.");
                    Console.ResetColor();
                    endings.Add("Echoing Laughter");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\nYou have unlocked the Echoing Laughter ending. Would you like to continue playing? (yes/no)");
                    Console.ResetColor();
                    string continueChoice = Console.ReadLine();
                    while (continueChoice.ToLower() != "yes" && continueChoice.ToLower() != "no")
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nInvalid input. Please enter 'yes' or 'no'.");
                        Console.ResetColor();
                        continueChoice = Console.ReadLine();
                    }
                    if (continueChoice.ToLower() == "yes")
                    {
                        Console.WriteLine("\nYou continue playing.");
                        preparationsContinue = false;

                    }
                    else if (continueChoice.ToLower() == "no")
                    {
                        Console.WriteLine("\nYou quit the game.");
                        gameContinue = false;
                    }
                }
                else if (game.IsBoardFull())
                {
                    // Twisted Stalemate ending
                    Console.WriteLine("\nThe game reaches a stalemate, a draw that should bring relief. However, Vex's sadistic nature knows no bounds. Ignoring the rules, Vex strikes with ruthless fury, mercilessly slaying you. The silence is shattered by their chilling laughter, as the enigmatic figure revels in the twisted delight of an unfinished game. The chance for a wish slips away, forever lost in the realm of shattered hopes and cruel fate.");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nDex selflessly intervenes, taking the fatal blow meant for you. His sacrifice fuels your determination to continue the fight against the corporations, carrying the weight of his memory.");
                    Console.ResetColor();
                    endings.Add("Twisted Stalemate");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\nYou have unlocked the Twisted Stalemate ending. Would you like to continue playing? (yes/no)");
                    Console.ResetColor();
                    string continueChoice = Console.ReadLine();
                    while (continueChoice.ToLower() != "yes" && continueChoice.ToLower() != "no")
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nInvalid input. Please enter 'yes' or 'no'.");
                        Console.ResetColor();
                        continueChoice = Console.ReadLine();
                    }
                    if (continueChoice.ToLower() == "yes")
                    {
                        Console.WriteLine("\nYou continue playing.");
                        preparationsContinue = false;


                    }
                    else if (continueChoice.ToLower() == "no")
                    {
                        Console.WriteLine("\nYou quit the game.");
                        gameContinue = false;
                    }
                }

                if (game.GetCurrentPlayer() == 'X')
                    PlayerMove(game);
                else
                    ComputerMove(game);
            }
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
}