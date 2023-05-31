using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPlease press F11 to enter Fullscreen.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nThis game features auto-save. The game will save after each ending.");
            Console.ResetColor();

            List<string> endings = new List<string>();
            bool gameContinue = true;
            string playerName = "";

            // Check for an existing save and offer to load it
            string savePath = "savegame.dat";

            if (File.Exists(savePath))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nThere is a save game present. Do you want to load it or overwrite it? (load/overwrite)");
                Console.ResetColor();
                string answer = Console.ReadLine();

                if (answer.ToLower() == "load")
                {
                    var gameData = LoadGame();
                    endings = (List<string>)gameData["endings"];
                    playerName = (string)gameData["playerName"];
                }
                else if (answer.ToLower() == "overwrite")
                {
                    // Prompt for player's name
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nWelcome to Night City. What's your name?");
                    Console.ResetColor();
                    playerName = Console.ReadLine();
                }

                while (answer.ToLower() != "load" && answer.ToLower() != "overwrite")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInvalid input. Please type 'load' or 'overwrite'.");
                    Console.ResetColor();
                    answer = Console.ReadLine();
                }
            }

            // Game loop until all endings are unlocked or player quits
            while (gameContinue == true)
            {
                SaveGame(endings, playerName);

                if (endings.Count == 17)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\nYou have unlocked all endings.");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nCongratulations!");
                    Console.ResetColor();
                    // i gotta add something here
                    gameContinue = false;
                }
                else
                {
                    if (endings.Count >= 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine($"\nYou have unlocked {endings.Count} out of 17 possible endings.");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("You have reached the following ending/s so far:");
                        Console.ResetColor();

                        if (endings.Contains("Twisted Stalemate"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Twisted Stalemate");
                            Console.ResetColor();
                        }
                    }
                    if (endings.Contains("Eternal Imprisonmente"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Eternal Imprisonment");
                        Console.ResetColor();
                    }
                    if (endings.Contains("Devoured Hope"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Devoured Hope");
                        Console.ResetColor();
                    }
                    if (endings.Contains("Last Stand"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Last Stand");
                        Console.ResetColor();
                    }
                    if (endings.Contains("Fatal Encryption"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Fatal Encryption");
                        Console.ResetColor();
                    }
                    if (endings.Contains("Dreams Unfulfilled"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Dreams Unfulfilled");
                        Console.ResetColor();
                    }
                    if (endings.Contains("Deceptive Innocence"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Deceptive Innocence");
                        Console.ResetColor();
                    }
                    if (endings.Contains("Devastating Swarm"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Devastating Swarm");
                        Console.ResetColor();
                    }
                    if (endings.Contains("Overpowered Resistance"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Overpowered Resistance");
                        Console.ResetColor();
                    }
                    if (endings.Contains("United Resolve"))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("United Resolve");
                        Console.ResetColor();
                    }
                    if (endings.Contains("Heart of Shadows"))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Heart of Shadows");
                        Console.ResetColor();
                    }
                    if (endings.Contains("Code of Sacrifice"))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Code of Sacrifice");
                        Console.ResetColor();
                    }
                    if (endings.Contains("Nomadic Heroism"))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Nomadic Heroism");
                        Console.ResetColor();
                    }
                    if (endings.Contains("Joint Sacrifice"))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Joint Sacrifice");
                        Console.ResetColor();
                    }
                    if (endings.Contains("Echoing Laughter"))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Echoing Laughter");
                        Console.ResetColor();
                    }
                    if (endings.Contains("Covert Alliance"))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Covert Alliance");
                        Console.ResetColor();
                    }
                    if (endings.Contains("Unity of Shadows"))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Unity of Shadows");
                        Console.ResetColor();
                    }
                }

                // Introduction and choice to proceed with the heist
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\n{playerName}, you're a young streetkid aspiring to become a legend. You have a chance to plan the greatest heist Night City has ever witnessed: stealing the Digital Heart from Arasaka corporation. But it's dangerous. Do you wish to proceed? (yes/no)");
                Console.ResetColor();

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
                        if (inventory.Contains("Cyberblaze") && inventory.Contains("Admin Key") && inventory.Contains("Katana"))
                        {
                            // Player has all items and can proceed to the heist
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\nYou are well prepared and ready to proceed with the heist. Will you bring anyone along? (mia/dex/ciper/miadex/miacipher/dexcipher/everyone/alone)");
                            Console.ResetColor();

                            string heistChoice = Console.ReadLine();

                            // Check the chosen heist option and play the corresponding scenario
                            if (heistChoice.ToLower() == "mia")
                            {
                                // Heart of Shadows ending
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\nAs the neon-lit streets of Night City cast an eerie glow, you and Mia embark on your audacious heist to infiltrate the heavily fortified Arasaka Bank. With the cybernetically enhanced horse, Cyberblaze, by your side, Mia's expertise as a Techie shines as you navigate the complex security systems. In a critical moment, Mia sacrifices herself to save you, diverting the attention of Arasaka's forces. In the chaos that ensues, the Digital Heart is destroyed. Heartbroken but determined, you vow to honour Mia's memory by becoming the legend that Night City needs, fighting to bring down the oppressive corporations and restore freedom to the city.");
                                Console.ResetColor();
                                endings.Add("Heart of Shadows");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("\nYou have reached the Heart of Shadows ending. Would you like to continue playing? (yes/no)");
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
                            else if (heistChoice.ToLower() == "cipher")
                            {
                                // Code of Sacrifice ending
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\nUnder the cover of darkness, you and Cipher set your sights on the Arasaka Bank, armed with the Admin Key and your hacking prowess. Your seamless teamwork allows you to bypass the most advanced security measures. As you approach the vault, you face relentless opposition from Arasaka's private security forces. In a critical moment, Cipher selflessly sacrifices themselves to ensure your escape, buying precious time for you to seize the Digital Heart. Despite the artefact’s destruction, you are determined to carry on Cipher's legacy, exposing the corruption of the corporations and becoming a symbol of resistance in Night City.");
                                Console.ResetColor();
                                endings.Add("Code of Sacrifice");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("\nYou have reached the Code of Sacrifice ending. Would you like to continue playing? (yes/no)");
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
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\nWith the open road in your sights, you and Dex embark on your daring heist, with Dex offering their prized Katana as a symbol of trust and camaraderie. Dex's nomadic instincts and combat skills prove invaluable as you navigate the bank's intricate security systems. However, as you reach the final stage of the heist, you find yourself cornered by Arasaka's elite forces. In a moment of self-sacrifice, Dex makes a valiant stand, holding back your attackers and giving you an opportunity to seize the Digital Heart. With tears in your eyes, you escape the bank, clutching the artefact tightly and carrying the weight of Dex's sacrifice. Fuelled by grief and determination, you commit to fulfilling your fallen comrade's dream of a free Night City, wielding Dex's Katana as a symbol of your shared purpose and resilience against the oppressive corporations.   ");
                                Console.ResetColor();
                                endings.Add("Nomadic Heroism");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("\nYou have reached the Nomadic Heroism ending. Would you like to continue playing? (yes/no)");
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
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\nUnited by your shared goal, you, Mia, and Dex plan your heist, with Mia bringing Cyberblaze and Dex wielding the powerful Katana. In a display of remarkable teamwork, the trio navigates the formidable security systems of the Arasaka Bank. However, your path is fraught with danger, and you find yourselves facing insurmountable odds. Recognizing the dire situation, you make the ultimate sacrifice, diverting the attention of Arasaka's forces, allowing Mia and Dex to escape with the stolen Digital Heart. As your vision fades, you know your sacrifice was not in vain, for Mia and Dex carry on the fight, inspired by your selflessness.");
                                Console.ResetColor();
                                endings.Add("Joint Sacrifice");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("\nYou have reached the Joint Sacrifice ending. Would you like to continue playing? (yes/no)");
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
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\nIn the heist involving you, Mia, and Cipher, Mia brings along Cyberblaze, and Cipher brings along the Admin Key. You sacrifice yourself to save Mia and Cipher, and they successfully steal the Digital Heart. United in their resolve, Mia and Cipher forge a powerful alliance, vowing to use the stolen artefact to expose corporate corruption and ignite a revolution in Night City. They carry your memory in their hearts as they become a force to be reckoned with, a united front against the oppressive corporations.");
                                Console.ResetColor();
                                endings.Add("United Resolve");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("\nYou have reached the United Resolve ending. Would you like to continue playing? (yes/no)");
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
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\nGuided by Dex's nomadic skills and Cipher's hacking abilities, you manoeuvre through the shadows of the Arasaka Bank. Dex's Katana cuts through your enemies with lethal precision, while Cipher's expertise subverts security systems. In a critical moment, you make the ultimate sacrifice, ensuring Dex and Cipher's escape with the stolen Digital Heart. With the artefact in their possession, Dex and Cipher form a covert alliance, committed to dismantling the corporations and creating a better future for Night City. As they move forward, they carry your memory, their fallen comrade forever a symbol of bravery and sacrifice.");
                                Console.ResetColor();
                                endings.Add("Covert Alliance");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("\nYou have reached the Covert Alliance ending. Would you like to continue playing? (yes/no)");
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
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nAs the heist begins, you, Mia, Dex, and Cipher move in perfect harmony, utilizing Cyberblaze, the Katana, and the Admin Key to overcome every obstacle. With unwavering determination, you infiltrate the Arasaka Bank and successfully steal the Digital Heart. United as one, you become the embodiment of hope, inspiring a rebellion against the oppressive corporations. With the Digital Heart as your weapon and your friendship as your strength, you lead Night City towards a future of freedom and justice, your legend forever intertwined.");
                                Console.ResetColor();
                                endings.Add("Unity of Shadows");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("\nYou have reached the Unity of Shadows ending. Would you like to continue playing? (yes/no)");
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
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nAlone and facing insurmountable odds, you charge into the heart of the Arasaka Bank. In a final act of defiance, you sacrifice yourself to destroy the Digital Heart, ensuring that the artefact never falls into the hands of the corporations. Your last stand becomes a rallying cry for the resistance, inspiring others to join the fight against the oppressive regime. Though you are gone, your sacrifice ignites a spark of hope, a beacon that will guide Night City towards a brighter future.");
                                Console.ResetColor();
                                endings.Add("Last Stand");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("\nYou have reached the Last Stand ending. Would you like to continue playing? (yes/no)");
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
                                Console.WriteLine("\nInvalid input. Please enter a valid choice.");
                                Console.ResetColor();
                                heistChoice = Console.ReadLine();
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
                            string locationChoice;

                            if (inventory.Contains("Admin Key") && inventory.Contains("Katana"))
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\nYou decide to go to the Arasaka tower.");
                                Console.ResetColor();
                                locationChoice = "tower";
                            }
                            else if (inventory.Contains("Cyberblaze") && inventory.Contains("Katana"))
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\nYou decide to go to the Undercity.");
                                Console.ResetColor();
                                locationChoice = "undercity";
                            }
                            else if (inventory.Contains("Cyberblaze") && inventory.Contains("Admin Key"))
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\nYou decide to go to the Night Market.");
                                Console.ResetColor();
                                locationChoice = "market";
                            }
                            else if (inventory.Contains("Cyberblaze"))
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\nWhere would you like to go next? The Undercity or the Night Market? (undercity/market)");
                                Console.ResetColor();
                                locationChoice = Console.ReadLine();
                            }
                            else if (inventory.Contains("Admin Key"))
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\nWhere would you like to go next? Arasaka Tower or the Night Market? (tower/market)");
                                Console.ResetColor();
                                locationChoice = Console.ReadLine();
                            }
                            else if (inventory.Contains("Katana"))
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\nWhere would you like to go next? The Undercity or Arasaka Tower? (undercity/tower)");
                                Console.ResetColor();
                                locationChoice = Console.ReadLine();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\nWhere would you like to go first? Arasaka Tower, the Undercity, or the Night Market? (tower/undercity/market)");
                                Console.ResetColor();
                                locationChoice = Console.ReadLine();
                            }

                            if (inventory.Contains("Cyberblaze") && (locationChoice == "tower"))
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\nInvalid input. Please try again.");
                                Console.ResetColor();
                                locationChoice = Console.ReadLine();
                            }

                            if (inventory.Contains("Admin Key") && (locationChoice == "undercity"))
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\nInvalid input. Please try again.");
                                Console.ResetColor();
                                locationChoice = Console.ReadLine();
                            }

                            if (inventory.Contains("Katana") && (locationChoice == "market"))
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\nInvalid input. Please try again.");
                                Console.ResetColor();
                                locationChoice = Console.ReadLine();
                            }

                            while (locationChoice.ToLower() != "tower" && locationChoice.ToLower() != "undercity" && locationChoice.ToLower() != "market")
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\nInvalid input. Please enter a valid choice.");
                                Console.ResetColor();
                                locationChoice = Console.ReadLine();
                            }

                            if (locationChoice == "tower")
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\nYou arrive at Arasaka Tower. The security is tight. You need to find a way to get in. Do you sneak in or force your way in? (sneak/force)");
                                Console.ResetColor();
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
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("\nYou successfully sneak into the Arasaka tower and gather crucial information about the bank. Unfortunately, on your way out, you encounter one of Arasaka's best security measures: Nanoclaw, a cybernetically enhanced tiger. You notice something resembling a gamepad on the desk next to you. Will you try to reach for it or make a run for it? (reach/run)");
                                    Console.ResetColor();
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
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine("\nChoose Cyberblaze's move: (1) Volt Tackle, (2) Inferno Blast [" + cyberblaze.InfernoBlastUses + "/5], (3) Charge Up, (4) System Restore");
                                            Console.ResetColor();
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
                                                Console.WriteLine("Nanoclaw wins!");
                                                Console.WriteLine("\nThe Nanoclaw mercilessly obliterates Cyberblaze. You are captured by Arasaka's security forces and sentenced to life in prison. The chilling echoes of your demise resonate, forever etching a tale of loss and devastation.. Your name is forgotten, your legacy erased.");
                                                Console.ResetColor();
                                                continuePokemon = false;
                                                endings.Add("Eternal Imprisonment");
                                                Console.ForegroundColor = ConsoleColor.Magenta;
                                                Console.WriteLine("\nYou have reached the Eternal Imprisonment ending. Would you like to continue playing? (yes/no)");
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
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Cyberblaze wins!");
                                                Console.ResetColor();
                                                continuePokemon = false;
                                                inventory.Add("Cyberblaze");
                                                Console.ForegroundColor = ConsoleColor.Magenta;
                                                Console.WriteLine("\nMia managed to tame Cyberblaze and took it with her.");
                                                Console.ResetColor();
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
                                        Console.WriteLine("\nYou have reached the Devoured Hope ending. Would you like to continue playing? (yes/no)");
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
                                    Console.WriteLine("\nYou have reached the Overpowered Resistance ending. Would you like to continue playing? (yes/no)");
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
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\nWhile navigating the treacherous Undercity, an Arasaka drone ambushes you. Will you shoot it down or employ your hacking skills to gain control? (shoot/hack)");
                                Console.ResetColor();

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
                                    Console.WriteLine("\nYou have reached the Devastating Swarm ending. Would you like to continue playing? (yes/no)");
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
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\nAs you wander through the night market, you see two people. A figure in the shadow and a little girl. Who will you ask for information? (figure/girl)");
                                Console.ResetColor();
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
                                    Console.WriteLine("\nYou have reached the Deceptive Innocence ending. Would you like to continue playing? (yes/no)");
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
                    Console.WriteLine("\nYou have reached the Dreams Unfulfilled ending. Would you like to continue playing? (yes/no)");
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
                                Console.WriteLine("You have successfully hacked the drone!");
                                Console.ResetColor();
                                inventory.Add("Admin Key");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("\nCipher accesed the drone's system and found an admin key");
                                Console.ResetColor();
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
                                Console.WriteLine("\nYou have reached the Fatal Encryption ending. Would you like to continue playing? (yes/no)");
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
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nAs the final move falls into place, the silence hangs heavy in the air. The enigmatic figure, Vex, reveals a twisted smile. But wait! The impossible has happened. Victory is yours! A surge of relief washes over you as you escape the clutches of Vex's deadly game.");
                    Console.ResetColor();
                    inventory.Add("Katana");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\nVex gives you his katana as a reward for winning the game. Dex takes the katana with him.");
                    Console.ResetColor();
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
                    Console.WriteLine("\nYou have reached the Echoing Laughter ending. Would you like to continue playing? (yes/no)");
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
                    Console.WriteLine("\nYou have reached the Twisted Stalemate ending. Would you like to continue playing? (yes/no)");
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

        private static void SaveGame(List<string> endings, string playerName)
        {
            Dictionary<string, object> gameSave = new Dictionary<string, object>()
            {
                { "endings", endings },
                { "playerName", playerName }
            };

            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("savegame.dat", FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(stream, gameSave);
            }
        }

        private static Dictionary<string, object> LoadGame()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("savegame.dat", FileMode.Open, FileAccess.Read))
            {
                return (Dictionary<string, object>)formatter.Deserialize(stream);
            }
        }

    }
}