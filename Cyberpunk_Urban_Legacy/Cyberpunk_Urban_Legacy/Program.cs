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

                    if (inventory.Contains("Cyberblaze"))
                    {
                        Console.WriteLine("\nMia");
                    }
                    if (inventory.Contains("AdminKey"))
                    {
                        Console.WriteLine("\nCipher");
                    }
                    if (inventory.Contains("Katana"))
                    {
                        Console.WriteLine("\nDex");
                    }
                    if (inventory.Contains("Cyberblaze") && inventory.Contains("Katana"))
                    {
                        Console.WriteLine("\nMia and Dex");
                    }
                    if (inventory.Contains("Cyberblaze") && inventory.Contains("AdminKey"))
                    {
                        Console.WriteLine("\nMia and Cipher");
                    }
                    if (inventory.Contains("AdminKey") && inventory.Contains("Katana"))
                    {
                        Console.WriteLine("\nCipher and Dex");
                    }
                    if (inventory.Contains("Cyberblaze") && inventory.Contains("AdminKey") && inventory.Contains("Katana"))
                    {
                        Console.WriteLine("\nMia, Dex, and Cipher");
                    }

                    string heistChoice = Console.ReadLine().ToLower();

                    while (heistChoice != "mia" && heistChoice != "cipher" && heistChoice != "dex" && heistChoice != "mia dex" && heistChoice != "mia cipher" && heistChoice != "dex cipher" && heistChoice != "mia dex cipher")
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nInvalid input. Please enter the name(s) of the character(s) you want to bring along.");
                        Console.ResetColor();
                        heistChoice = Console.ReadLine().ToLower();
                    }

                    // Code to handle the chosen character in the heist scenario
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
                        if (inventory.Contains("Cyberblaze") && inventory.Contains("AdminKey") && inventory.Contains("Katana"))
                        {
                            Console.WriteLine("\nYou choose to proceed to the heist. Who will you bring along?");

                            if (inventory.Contains("Cyberblaze"))
                            {
                                Console.WriteLine("\nMia");
                            }
                            if (inventory.Contains("AdminKey"))
                            {
                                Console.WriteLine("\nCipher");
                            }
                            if (inventory.Contains("Katana"))
                            {
                                Console.WriteLine("\nDex");
                            }
                            if (inventory.Contains("Cyberblaze") && inventory.Contains("AdminKey"))
                            {
                                Console.WriteLine("\nMia and Cipher");
                            }
                            if (inventory.Contains("Cyberblaze") && inventory.Contains("Katana"))
                            {
                                Console.WriteLine("\nMia and Dex");
                            }
                            if (inventory.Contains("AdminKey") && inventory.Contains("Katana"))
                            {
                                Console.WriteLine("\nCipher and Dex");
                            }

                            string heistChoice = Console.ReadLine().ToLower();

                            while (heistChoice != "mia" && heistChoice != "cipher" && heistChoice != "dex" && heistChoice != "mia cipher" && heistChoice != "mia dex" && heistChoice != "dex cipher")
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("\nInvalid input. Please enter the name(s) of the character(s) you want to bring along.");
                                Console.ResetColor();
                                heistChoice = Console.ReadLine().ToLower();
                            }

                            // Code to handle the chosen character in the heist scenario
                        }
                        else
                        {
 
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
    }
}
