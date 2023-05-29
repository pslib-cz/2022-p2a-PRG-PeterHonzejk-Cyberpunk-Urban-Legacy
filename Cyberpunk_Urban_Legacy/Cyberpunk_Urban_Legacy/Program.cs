using System;
using System.Collections.Generic;

namespace Cyberpunk_Urban_Legacy
{
    // Abstract base class for heist scenarios
    abstract class Heist
    {
        // Abstract method for playing the heist
        public abstract void Play();
    }

    // Heist scenario with Mia
    class MiaHeist : Heist
    {
        public override void Play()
        {
            // Code for the heist with Mia
        }
    }

    // Heist scenario with Dex
    class DexHeist : Heist
    {
        public override void Play()
        {
            // Code for the heist with Dex
        }
    }

    // Heist scenario with Cipher
    class CipherHeist : Heist
    {
        public override void Play()
        {
            // Code for the heist with Cipher
        }
    }

    // Heist scenario with Mia and Dex
    class MiaDexHeist : Heist
    {
        public override void Play()
        {
            // Code for the heist with Mia and Dex
        }
    }

    // Heist scenario with Mia and Cipher
    class MiaCipherHeist : Heist
    {
        public override void Play()
        {
            // Code for the heist with Mia and Cipher
        }
    }

    // Heist scenario with Dex and Cipher
    class DexCipherHeist : Heist
    {
        public override void Play()
        {
            // Code for the heist with Dex and Cipher
        }
    }

    // Heist scenario with everyone
    class EveryoneHeist : Heist
    {
        public override void Play()
        {
            // Code for the heist with everyone
        }
    }

    // Heist scenario alone
    class AloneHeist : Heist
    {
        public override void Play()
        {
            // Code for the heist alone
        }
    }

    // Abstract base class for preparation scenarios
    abstract class Preparation
    {
        // Abstract method for preparation
        public abstract void Prepare();
    }

    // Preparation scenario at Night Market with Dex
    class NightMarketPreparation : Preparation
    {
        public override void Prepare()
        {
            // Code for the Night Market preparation with Dex
        }
    }

    // Preparation scenario in Undercity with Cipher
    class UndercityPreparation : Preparation
    {
        public override void Prepare()
        {
            // Code for the Undercity preparation with Cipher
        }
    }

    // Preparation scenario at Arasaka Tower with Mia
    class ArasakaTowerPreparation : Preparation
    {
        public override void Prepare()
        {
            // Code for the Arasaka Tower preparation with Mia
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = new List<string>();
            List<string> endings = new List<string>();

            // Prompt for player's name
            Console.WriteLine("\nWelcome to Night City. What's your name?");
            string playerName = Console.ReadLine();


            // Introduction and choice to proceed with the heist
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
                // Player chooses to proceed with the heist
                Console.WriteLine("\nYou courageously move forward with the plan, risking it all for a chance at greatness.");

                while (true)
                {
                    if (inventory.Contains("Cyberblaze") && inventory.Contains("AdminKey") && inventory.Contains("Katana"))
                    {
                        // Player has all items and can proceed to the heist with the option to bring everyone along
                        Console.WriteLine("\nYou are well prepared and ready to proceed with the heist. Will you bring anyone along? (mia/dex/ciper/miadex/miacipher/dexcipher/everyone/alone)");

                        string heistChoice = Console.ReadLine();

                        // Check the chosen heist option and play the corresponding scenario
                        if (heistChoice.ToLower() == "mia")
                        {
                            Heist miaHeist = new MiaHeist();
                            miaHeist.Play();
                            break;
                        }
                        else if (heistChoice.ToLower() == "cipher")
                        {
                            Heist cipherHeist = new CipherHeist();
                            cipherHeist.Play();
                            break;
                        }
                        else if (heistChoice.ToLower() == "dex")
                        {
                            Heist dexHeist = new DexHeist();
                            dexHeist.Play();
                            break;
                        }
                        else if (heistChoice.ToLower() == "miadex")
                        {
                            Heist miaDexHeist = new MiaDexHeist();
                            miaDexHeist.Play();
                            break;
                        }
                        else if (heistChoice.ToLower() == "miacipher")
                        {
                            Heist miaCipherHeist = new MiaCipherHeist();
                            miaCipherHeist.Play();
                            break;
                        }
                        else if (heistChoice.ToLower() == "dexcipher")
                        {
                            Heist dexCipherHeist = new DexCipherHeist();
                            dexCipherHeist.Play();
                            break;
                        }
                        else if (heistChoice.ToLower() == "everyone")
                        {
                            Heist everyoneHeist = new EveryoneHeist();
                            everyoneHeist.Play();
                            break;
                        }
                        else if (heistChoice.ToLower() == "alone")
                        {
                            Heist aloneHeist = new AloneHeist();
                            aloneHeist.Play();
                            break;
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
                        // Player needs to choose between preparation and going directly to the heist
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
                            // Player chooses preparation, check the available options based on their inventory
                            if (inventory.Contains("Cyberblaze") && inventory.Contains("AdminKey"))
                            {
                                Preparation arasakaTowerPreparation = new ArasakaTowerPreparation();
                                arasakaTowerPreparation.Prepare();
                            }
                            else if (inventory.Contains("Cyberblaze") && inventory.Contains("Katana"))
                            {
                                Preparation undercityPreparation = new UndercityPreparation();
                                undercityPreparation.Prepare();
                            }
                            else if (inventory.Contains("AdminKey") && inventory.Contains("Katana"))
                            {
                                Preparation nightMarketPreparation = new NightMarketPreparation();
                                nightMarketPreparation.Prepare();
                            }
                            else if (inventory.Contains("Cyberblaze"))
                            {
                                Console.WriteLine("\nWhere would you like to go next? Undercity or the Night market? (undercity/market)");
                                string locationChoice = Console.ReadLine();

                                if (locationChoice == "undercity")
                                {
                                    Preparation undercityPreparation = new UndercityPreparation();
                                    undercityPreparation.Prepare();
                                }
                                else if (locationChoice == "market")
                                {
                                    Preparation nightMarketPreparation = new NightMarketPreparation();
                                    nightMarketPreparation.Prepare();
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
                                Console.WriteLine("\nWhere would you like to go next? Arasaka tower or the Night market? (tower/market)");
                                string locationChoice = Console.ReadLine();

                                if (locationChoice == "tower")
                                {
                                    Preparation arasakaTowerPreparation = new ArasakaTowerPreparation();
                                    arasakaTowerPreparation.Prepare();
                                }
                                else if (locationChoice == "market")
                                {
                                    Preparation nightMarketPreparation = new NightMarketPreparation();
                                    nightMarketPreparation.Prepare();
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
                                Console.WriteLine("\nWhere would you like to go next? Arasaka tower or the Undercity? (tower/undercity)");
                                string locationChoice = Console.ReadLine();

                                if (locationChoice == "tower")
                                {
                                    Preparation arasakaTowerPreparation = new ArasakaTowerPreparation();
                                    arasakaTowerPreparation.Prepare();
                                }
                                else if (locationChoice == "undercity")
                                {
                                    Preparation undercityPreparation = new UndercityPreparation();
                                    undercityPreparation.Prepare();
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
                            // Player chooses to proceed directly to the heist
                            Console.WriteLine("\nYou choose to proceed to the heist.");

                            if (inventory.Count == 0)
                            {
                                // Player has no items and proceeds alone
                                Heist aloneHeist = new AloneHeist();
                                aloneHeist.Play();
                                break;
                            }
                            else
                            {
                                if (inventory.Contains("Cyberblaze") && inventory.Contains("AdminKey"))
                                {
                                    Console.WriteLine("\nWill you bring anyone or go alone? (mia/cipher/mia¨cipher/alone)");

                                    string helpChoice = Console.ReadLine();

                                    while (helpChoice.ToLower() != "mia" && helpChoice.ToLower() != "cipher" && helpChoice.ToLower() != "miacipher" && helpChoice.ToLower() != "alone")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("\nInvalid input. Please enter a valid choice.");
                                        Console.ResetColor();
                                        helpChoice = Console.ReadLine();
                                    }

                                    if (helpChoice.ToLower() == "mia")
                                    {
                                        Heist miaHeist = new MiaHeist();
                                        miaHeist.Play();
                                        break;
                                    }
                                    else if (helpChoice.ToLower() == "cipher")
                                    {
                                        Heist cipherHeist = new CipherHeist();
                                        cipherHeist.Play();
                                        break;
                                    }
                                    else if (helpChoice.ToLower() == "miacipher")
                                    {
                                        Heist miaCipherHeist = new MiaCipherHeist();
                                        miaCipherHeist.Play();
                                        break;
                                    }
                                    else if (helpChoice.ToLower() == "alone")
                                    {
                                        Heist aloneHeist = new AloneHeist();
                                        aloneHeist.Play();
                                        break;
                                    }
                                }
                                else if (inventory.Contains("Cyberblaze") && inventory.Contains("Katana"))
                                {
                                    Console.WriteLine("\nWill you bring anyone or go alone? (mia/dex/miadex/alone)");

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
                                        Heist miaHeist = new MiaHeist();
                                        miaHeist.Play();
                                        break;
                                    }
                                    else if (helpChoice.ToLower() == "dex")
                                    {
                                        Heist dexHeist = new DexHeist();
                                        dexHeist.Play();
                                        break;
                                    }
                                    else if (helpChoice.ToLower() == "miadex")
                                    {
                                        Heist miaDexHeist = new MiaDexHeist();
                                        miaDexHeist.Play();
                                        break;
                                    }
                                    else if (helpChoice.ToLower() == "alone")
                                    {
                                        Heist aloneHeist = new AloneHeist();
                                        aloneHeist.Play();
                                        break;
                                    }
                                }
                                else if (inventory.Contains("AdminKey") && inventory.Contains("Katana"))
                                {
                                    Console.WriteLine("\nWill you bring anyone or go alone? (dex/cipher/dexcipher/alone)");

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
                                        Heist cipherHeist = new CipherHeist();
                                        cipherHeist.Play();
                                        break;
                                    }
                                    else if (helpChoice.ToLower() == "dex")
                                    {
                                        Heist dexHeist = new DexHeist();
                                        dexHeist.Play();
                                        break;
                                    }
                                    else if (helpChoice.ToLower() == "dexcipher")
                                    {
                                        Heist dexCipherHeist = new DexCipherHeist();
                                        dexCipherHeist.Play();
                                        break;
                                    }
                                    else if (helpChoice.ToLower() == "alone")
                                    {
                                        Heist aloneHeist = new AloneHeist();
                                        aloneHeist.Play();
                                        break;
                                    }
                                }
                                else if (inventory.Contains("AdminKey"))
                                {
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
                                        Heist cipherHeist = new CipherHeist();
                                        cipherHeist.Play();
                                        break;
                                    }
                                    else if (helpChoice.ToLower() == "alone")
                                    {
                                        Heist aloneHeist = new AloneHeist();
                                        aloneHeist.Play();
                                        break;
                                    }
                                }
                                else if (inventory.Contains("Cyberblaze"))
                                {
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
                                        Heist miaHeist = new MiaHeist();
                                        miaHeist.Play();
                                        break;
                                    }
                                    else if (helpChoice.ToLower() == "alone")
                                    {
                                        Heist aloneHeist = new AloneHeist();
                                        aloneHeist.Play();
                                        break;
                                    }
                                }
                                else if (inventory.Contains("Katana"))
                                {
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
                                        Heist dexHeist = new DexHeist();
                                        dexHeist.Play();
                                        break;
                                    }
                                    else if (helpChoice.ToLower() == "alone")
                                    {
                                        Heist aloneHeist = new AloneHeist();
                                        aloneHeist.Play();
                                        break;
                                    }
                                }
                            }
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