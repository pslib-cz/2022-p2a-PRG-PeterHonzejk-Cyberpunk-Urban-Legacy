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

                while (true)
                {
                    if (inventory.Contains("Cyberblaze") && inventory.Contains("AdminKey") && inventory.Contains("Katana"))
                    {
                        Console.WriteLine("\nYou are well prepared and ready to proceed with the heist. Will you bring anyone along? (mia/dex/ciper/miadex/miacipher/dexcipher/everyone/alone)");


                        string heistChoice = Console.ReadLine();

                        if (heistChoice == "mia")
                        {

                        }
                        else if (heistChoice == "cipher")
                        {

                        }
                        else if (heistChoice == "dex")
                        {

                        }
                        else if (heistChoice == "miadex")
                        {

                        }
                        else if (heistChoice == "miacipher")
                        {

                        }
                        else if (heistChoice == "dexcipher")
                        {

                        }
                        else if (heistChoice == "everyone")
                        {

                        }
                        else if (heistChoice == "alone")
                        {

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
                                Console.WriteLine("\nWhere would you like to go next? Undercity or the Night market? (tower/market)");
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
                                Console.WriteLine("\nnWhere would you like to go next? Arasaka tower or the Night market? (tower/market)");
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
                                Console.WriteLine("\nnWhere would you like to go next? Arasaka tower or the Undercity? (tower/undercity)");
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
                                // Code for the heist scenario when going alone
                            }
                            else
                            {

                                if (inventory.Contains("Cyberblaze") && inventory.Contains("AdminKey"))
                                {
                                    Console.WriteLine("\nWill you bring anyone or go alone? (mia/cipher/miacipher/alone");

                                    string helpChoice = Console.ReadLine();
                                    
                                    while (helpChoice.ToLower() != "mia" && helpChoice.ToLower() != "cipher" && helpChoice.ToLower() != "miacipher" && helpChoice.ToLower() != "alone")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("\nInvalid input. Please enter a valid choice.");
                                        Console.ResetColor();
                                        helpChoice = Console.ReadLine();
                                    }
                                }
                                else if (inventory.Contains("Cyberblaze") && inventory.Contains("Katana"))
                                {
                                    Console.WriteLine("\nWill you bring anyone or go alone? (mia/dex/miadex/alone");

                                    string helpChoice = Console.ReadLine();

                                    while (helpChoice.ToLower() != "mia" && helpChoice.ToLower() != "dex" && helpChoice.ToLower() != "miadex" && helpChoice.ToLower() != "alone")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("\nInvalid input. Please enter a valid choice.");
                                        Console.ResetColor();
                                        helpChoice = Console.ReadLine();
                                    }

                                    if (helpChoice.ToLower() == "mia")
                                    {
                                        Console.WriteLine("\nYou decide to bring Mia along with you.");
                                        // Code for the heist scenario with Mia here
                                    }
                                    else if (helpChoice.ToLower() == "dex")
                                    {
                                        Console.WriteLine("\nYou decide to bring Dex along with you.");
                                        // Code for the heist scenario with Dex here
                                    }
                                    else if (helpChoice.ToLower() == "miadex")
                                    {
                                        Console.WriteLine("\nYou decide to bring Mia and Dex along with you.");
                                        // Code for the heist scenario with Mia and Dex here
                                    }
                                    else if (helpChoice.ToLower() == "alone")
                                    {
                                        Console.WriteLine("\nYou decide to go alone.");
                                        // Code for the heist scenario when going alone
                                    }
                                }
                                else if (inventory.Contains("AdminKey") && inventory.Contains("Katana"))
                                {
                                    Console.WriteLine("\nWill you bring anyone or go alone? (dex/cipher/dexcipher/alone");

                                    string helpChoice = Console.ReadLine();

                                    while (helpChoice.ToLower() != "cipher" && helpChoice.ToLower() != "dex" && helpChoice.ToLower() != "dexcipher" && helpChoice.ToLower() != "alone")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("\nInvalid input. Please enter a valid choice.");
                                        Console.ResetColor();
                                        helpChoice = Console.ReadLine();
                                    }

                                    if (helpChoice.ToLower() == "cipher")
                                    {
                                        Console.WriteLine("\nYou decide to bring Cipher along with you.");
                                        // Code for the heist scenario with Cipher here
                                    }
                                    else if (helpChoice.ToLower() == "dex")
                                    {
                                        Console.WriteLine("\nYou decide to bring Dex along with you.");
                                        // Code for the heist scenario with Dex here
                                    }
                                    else if (helpChoice.ToLower() == "dexcipher")
                                    {
                                        Console.WriteLine("\nYou decide to bring Dex and Cipher along with you.");
                                        // Code for the heist scenario with Dex and Cipher here
                                    }
                                    else if (helpChoice.ToLower() == "alone")
                                    {
                                        Console.WriteLine("\nYou decide to go alone.");
                                        // Code for the heist scenario when going alone
                                    }
                                }
                                else if (inventory.Contains("Cyberblaze"))
                                {
                                    Console.WriteLine("\nWill you bring along Mia or go alone? (mia/alone");

                                    string helpChoice = Console.ReadLine();

                                    while (helpChoice.ToLower() != "mia" && helpChoice.ToLower() != "alone")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("\nInvalid input. Please enter a valid choice.");
                                        Console.ResetColor();
                                        helpChoice = Console.ReadLine();
                                    }

                                    if (helpChoice.ToLower() == "mia")
                                    {
                                        Console.WriteLine("\nYou decide to bring Mia along with you.");
                                        // Code for the heist scenario with Mia here
                                    }
                                    else if (helpChoice.ToLower() == "alone")
                                    {
                                        Console.WriteLine("\nYou decide to go alone.");
                                        // Code for the heist scenario when going alone
                                    }
                                }
                                else if (inventory.Contains("AdminKey"))
                                {
                                    Console.WriteLine("\nWill you bring along Cipher or go alone? (cipher/alone");

                                    string helpChoice = Console.ReadLine();

                                    while (helpChoice.ToLower() != "cipher" && helpChoice.ToLower() != "alone")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("\nInvalid input. Please enter a valid choice.");
                                        Console.ResetColor();
                                        helpChoice = Console.ReadLine();
                                    }

                                    if (helpChoice.ToLower() == "cipher")
                                    {
                                        Console.WriteLine("\nYou decide to bring Cipher along with you.");
                                        // Code for the heist scenario with Cipher here
                                    }
                                    else if (helpChoice.ToLower() == "alone")
                                    {
                                        Console.WriteLine("\nYou decide to go alone.");
                                        // Code for the heist scenario when going alone
                                    }
                                }
                                else if (inventory.Contains("Katana"))
                                {
                                    Console.WriteLine("\nWill you bring along Dex or go alone? (dex/alone");

                                    string helpChoice = Console.ReadLine();

                                    while (helpChoice.ToLower() != "dex" && helpChoice.ToLower() != "alone")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("\nInvalid input. Please enter a valid choice.");
                                        Console.ResetColor();
                                        helpChoice = Console.ReadLine();
                                    }

                                    if (helpChoice.ToLower() == "dex")
                                    {
                                        Console.WriteLine("\nYou decide to bring Dex along with you.");
                                        // Code for the heist scenario with Dex here
                                    }
                                    else if (helpChoice.ToLower() == "alone")
                                    {
                                        Console.WriteLine("\nYou decide to go alone.");
                                        // Code for the heist scenario when going alone
                                    }
                                }
                                else
                                {
                                    // Code for the heist scenario when going alone
                                }

                            }
                        }
                    }
                }
            }
            else if (importantChoice.ToLower() == "no")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"\nYou decide it's too risky. You continue your life in the streets of Night City, always wondering what might have been.");
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
            