using System;
using System.Collections.Generic;

namespace Cyberpunk_Urban_Legacy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = new List<string>();

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

                if (inventory.Contains("Cyberblaze") && inventory.Contains("AdminKey") && inventory.Contains("Katana"))
                {
                    Console.WriteLine("\nYou are well prepared and ready to proceed with the heist. Who will you bring along?");

                    PerformHeist();
                }
                else
                {
                    Console.WriteLine("\nDo you want to proceed with the preparations or go to the heist? (prepare/heist)");
                    string preparationChoice = Console.ReadLine();

                    while (preparationChoice.ToLower() != "prepare" && preparationChoice.ToLower() != "heist")
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nInvalid input. Please enter 'prepare' or 'heist'.");
                        Console.ResetColor();
                        preparationChoice = Console.ReadLine();
                    }

                    if (preparationChoice.ToLower() == "prepare")
                    {
                        if (inventory.Contains("Cyberblaze") && inventory.Contains("AdminKey"))
                        {
                            // Code for the Night Market scenario with Dex here
                        }
                        else if (inventory.Contains("Cyberblaze") && inventory.Contains("Katana"))
                        {
                            // Code for the Undercity scenario with Cipher here
                        }
                        else if (inventory.Contains("AdminKey") && inventory.Contains("Katana"))
                        {
                            // Code for the Arasaka Tower scenario with Mia here
                        }
                        else if (inventory.Contains("Cyberblaze"))
                        {
                            Console.WriteLine("\nWhere would you like to go next?");
                            Console.WriteLine("Arasaka Tower (tower)");
                            Console.WriteLine("Night Market (market)");
                            string locationChoice = Console.ReadLine();

                            if (locationChoice == "tower")
                            {
                                Console.WriteLine("\nYou decide to go to the Undercity to gather more information.");
                                // Code for the Undercity scenario with Cipher here
                            }
                            else if (locationChoice == "market")
                            {
                                Console.WriteLine("\nYou decide to go to the Night Market to gather more information.");
                                // Code for the Night Market scenario with Dex here
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\nInvalid input. Please enter a valid location.");
                                Console.ResetColor();
                            }
                        }
                        else if (inventory.Contains("AdminKey"))
                        {
                            Console.WriteLine("\nWhere would you like to go next?");
                            Console.WriteLine("Arasaka Tower (tower)");
                            Console.WriteLine("Night Market (market)");
                            string locationChoice = Console.ReadLine();

                            if (locationChoice == "tower")
                            {
                                Console.WriteLine("\nYou decide to go to Arasaka Tower to gather more information.");
                                // Code for the Arasaka Tower scenario with Mia here
                            }
                            else if (locationChoice == "market")
                            {
                                Console.WriteLine("\nYou decide to go to the Night Market to gather more information.");
                                // Code for the Night Market scenario with Dex here
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\nInvalid input. Please enter a valid location.");
                                Console.ResetColor();
                            }
                        }
                        else if (inventory.Contains("Katana"))
                        {
                            Console.WriteLine("\nWhere would you like to go next?");
                            Console.WriteLine("Arasaka Tower (tower)");
                            Console.WriteLine("Undercity with (undercity)");
                            string locationChoice = Console.ReadLine();

                            if (locationChoice == "tower")
                            {
                                Console.WriteLine("\nYou decide to go to Arasaka Tower to gather more information.");
                                // Code for the Arasaka Tower scenario with Mia here
                            }
                            else if (locationChoice == "undercity")
                            {
                                Console.WriteLine("\nYou decide to go to the Undercity to gather more information.");
                                // Code for the Undercity scenario with Cipher here
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\nInvalid input. Please enter a valid location.");
                                Console.ResetColor();
                            }
                        }
                    }
                    else if (preparationChoice.ToLower() == "heist")
                    {
                        Console.WriteLine("\nYou choose to proceed to the heist.");

                        if (inventory.Count == 0)
                        {
                            Console.WriteLine("\nYou decide to go alone.");
                            // Code for the heist scenario when going alone
                        }
                        else
                        {
                            PerformHeist();
                        }
                    }
                }
            }
            else if (importantChoice.ToLower() == "no")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"\n{playerName}, you decide it's too risky. You continue your life in the streets of Night City, always wondering what might have been.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nInvalid input. Please enter 'yes' or 'no'.");
                Console.ResetColor();
            }
        }

        static void PerformHeist()
        {
            if (inventory.Count > 0)
            {
                Console.WriteLine("\nWill you bring anyone or go alone? (mia/dex/cipher/miaanddex/miaandcipher/dexandcipher/everyone/alone)");

                string heistChoice = Console.ReadLine().ToLower();

                while (heistChoice != "mia" && heistChoice != "cipher" && heistChoice != "dex" && heistChoice != "miaanddex" && heistChoice != "miaandcipher" && heistChoice != "dexandcipher" && heistChoice != "everyone" && heistChoice != "alone")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nInvalid input. Please enter the name(s) of the character(s) you want to bring along.");
                    Console.ResetColor();
                    heistChoice = Console.ReadLine().ToLower();
                }

                if (heistChoice == "mia")
                {

                }
                else if (heistChoice == "cipher")
                {

                }
                else if (heistChoice == "dex")
                {

                }
                else if (heistChoice == "miaanddex")
                {

                }
                else if (heistChoice == "miaandcipher")
                {

                }
                else if (heistChoice == "dexandcipher")
                {

                }
                else if (heistChoice == "everyone")
                {

                }
                else if (heistChoice == "alone")
                {

                }
            }
            else
            {
                Console.WriteLine("\nYou decide to go alone.");
                // Code for the heist scenario when going alone
            }
        }
    }
}

