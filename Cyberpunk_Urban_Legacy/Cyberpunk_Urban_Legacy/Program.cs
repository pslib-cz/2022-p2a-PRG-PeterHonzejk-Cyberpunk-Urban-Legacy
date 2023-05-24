using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_Urban_Legacy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Cyberpunk");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Urban");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Legacy");
            Console.ResetColor();

            Console.WriteLine("\nWelcome to Night City. What's your name?");
            string playerName = Console.ReadLine();

            Console.WriteLine($"\n{playerName}, you're a young streetkid aspiring to become a legend. You have a chance to plan the greatest heist Night City has ever witnessed: stealing the Digital Heart from Arasaka corporation. But it's dangerous. You proceed with the heist. Do you wish to proceed? (yes/no)");

            string playerChoice = Console.ReadLine();

            if (playerChoice.ToLower() == "yes")
            {
                Console.WriteLine("\nYou courageously move forward with the plan, risking it all for a chance at greatness.");

                Console.WriteLine("\nYour closest friend, Mia, a bold and resourceful hacker, and Dex, a brave and physically strong fighter, are ready to help you. Who do you want to approach first for help? (Mia/Dex)");

                string firstHelper = Console.ReadLine();

                if (firstHelper.ToLower() == "mia")
                {
                    Console.WriteLine("\nMia helps you to enhance your cybernetic implants and gather information about valuable targets.");

                    Console.WriteLine("\nYou still have some time before the hesit. Where would you like to go next, Arasaka Tower or the Night Market? (tower/market)");
                    string locationChoice = Console.ReadLine();

                    if (locationChoice.ToLower() == "tower")
                    {
                        Console.WriteLine("\nYou arrive at Arasaka Tower. The security is tight. You need to find a way to get in. Do you sneak in or force your way in? (sneak/force)");
                        string arasakaTowerChoice = Console.ReadLine();

                        if (arasakaTowerChoice.ToLower() == "sneak")
                        {
                            Console.WriteLine("\nAfter successfully sneaking into the Arasaka tower and gathering crucial information about the bank, you encounter one of Arasaka's best security measures: Nanoclaw, a cybernetically enhanced tiger. You notice something resembling a gamepad on the desk next to you. Will you try to reach for it or make a run for it? (reach/run)");
                            string nanoclawChoice = Console.ReadLine();

                            if (nanoclawChoice.ToLower() == "reach")
                            {
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

                                    if (cyberblaze.CheckIfFainted())
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\nNanoclaw wins!");
                                        // ending
                                        Console.ResetColor();
                                        break;
                                    }

                                    Console.WriteLine("Cyberblaze HP: " + cyberblaze.HP + "/" + cyberblaze.MaxHP);
                                    Console.WriteLine("Nanoclaw HP: " + nanoclaw.HP + "/" + nanoclaw.MaxHP);


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
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\nYou had a stroke and died.");
                                Console.ResetColor();
                            }
                        }
                        else if (arasakaTowerChoice.ToLower() == "force")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"\nMia was unfortuneatly shot while trying to breach the highly advanced security systems of the Arasaka. Despite your best efforts, both of you were overwhelmed by Arasaka's powerful mercenaries. {playerName}, your sacrifice would be remembered as a courageous stand against impossible odds, inspiring others to fight against oppression.");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\nYou had a stroke and died.");
                            Console.ResetColor();
                        }
                    }
                    else if (locationChoice.ToLower() == "market")
                    {
                        Console.WriteLine("\nAs you wander through the night market, your attention is drawn to a mysterious figure lurking in the shadows. Would you like to approach this enigmatic presence? (yes/no)");
                        string nightApproach = Console.ReadLine();

                        if (nightApproach.ToLower() == "yes")
                        {
                            Console.WriteLine("\nThe enigmatic figure unveils their true identity as Vex, a ruthless serial killer who delights in playing a deadly game of Tic-Tac-Toe. The stakes are high, as losing or tieing means facing a gruesome fate—being mercilessly slashed in half.");
                            // change to Tic-Tac-Toe minigame good ending (vex helps you) / death ending (vex stabs mia)
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
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\nYou had a stroke and died.");
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\nYou had a stroke and died.");
                            Console.ResetColor();
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nYou had a stroke and died.");
                        Console.ResetColor();
                    }
                }
                else if (firstHelper.ToLower() == "dex")
                {
                    Console.WriteLine("\nDex takes care of securing weaponry and the escape route. With his help, you are ready for the infiltration.");

                    Console.WriteLine("\nYou still have some time before the heist. Where would you like to go next, The Undercity or the Night Market? (undercity/night market)");
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
                            Hangman game = new Hangman();
                            game.PlayGame();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\nYou had a stroke and died.");
                            Console.ResetColor();
                        }
                    }
                    else if (locationChoice.ToLower() == "night market")
                    {
                        Console.WriteLine("\nAs you wander through the night market, your attention is drawn to a mysterious figure lurking in the shadows. Would you like to approach this enigmatic presence? (yes/no)");
                        string nightApproach = Console.ReadLine();

                        if (nightApproach.ToLower() == "yes")
                        {
                            Console.WriteLine("\nThe enigmatic figure unveils their true identity as Vex, a ruthless serial killer who delights in playing a deadly game of Tic-Tac-Toe. The stakes are high, as losing or tieing means facing a gruesome fate—being mercilessly slashed in half.");
                            // change to Tic-Tac-Toe minigame good ending (vex helps you) / death ending (vex stabs dex)
                        }
                        else if (nightApproach.ToLower() == "no")
                        {
                            Console.WriteLine("\nYou proceed with the heist but after securing the Digital Hear youre ambushed by Arasaka's mercenaries. Do you choose to fight the corporate mercenaries with Dex's weaponry or utilize his pre-planned escape route? (fight/escape)");
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
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\nYou had a stroke and died.");
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\nYou had a stroke and died.");
                            Console.ResetColor();
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nYou had a stroke and died.");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nYou had a stroke and died.");
                    Console.ResetColor();
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
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nYou had a stroke and died.");
                Console.ResetColor();
            }
        }
    }
}
