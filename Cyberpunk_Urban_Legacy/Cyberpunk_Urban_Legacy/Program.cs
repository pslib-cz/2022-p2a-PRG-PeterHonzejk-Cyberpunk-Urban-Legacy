using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.ResetColor();
        // Name
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Cyberpunk");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Urban");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Legacy");
        Console.ResetColor();

        // Introduction
        Console.WriteLine("Welcome to Night City. What's your name?");
        string playerName = Console.ReadLine();

        // Present the initial situation and choice
        Console.WriteLine($"{playerName}, you're a young streetkid aspiring to become a legend. You have a chance to plan the greatest heist Night City has ever witnessed: stealing the Digital Heart from Arasaka corporation. But it's dangerous. Do you wish to proceed? (yes/no)");

        string playerChoice = Console.ReadLine();
        List<string> inventory = new List<string>();

        // If the player chooses to proceed...
        if (playerChoice.ToLower() == "yes")
        {
            Console.WriteLine("You courageously move forward with the plan, risking it all for a chance at greatness...");

            // Introduce Mia, Dex, and Rico
            Console.WriteLine("Your closest friends, Mia, a bold and resourceful hacker, Dex, a brave and physically strong fighter, and Rico, a well-connected fixer, are ready to help you. Who do you want to approach first for help? (Mia/Dex/Rico)");

            string firstHelper = Console.ReadLine();

            // Save game state
            File.WriteAllText(@"gamestate.txt", firstHelper);

            if (firstHelper.ToLower() == "mia")
            {
                Console.WriteLine("Mia helps you to enhance your cybernetic implants and gather information about valuable targets. She's able to successfully hack into Arasaka's security systems.");
                inventory.Add("Hacking Skills");

                Console.WriteLine("You can now choose to attempt the heist or get more help. What do you want to do? (heist/more help)");
                string miaChoice = Console.ReadLine();

                if (miaChoice.ToLower() == "heist")
                {
                    // Proceed to heist
                }
                else if (miaChoice.ToLower() == "more help")
                {
                    // Go to Dex or Rico
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please restart the game and try again.");
                }
            }
            else if (firstHelper.ToLower() == "dex")
            {
                Console.WriteLine("Dex takes care of securing weaponry and the escape route. With his help, you feel ready for the infiltration...");
                inventory.Add("Heavy Gun");
                inventory.Add("Body Armor");

                Console.WriteLine("You can now choose to attempt the heist or get more help. What do you want to do? (heist/more help)");
                string dexChoice = Console.ReadLine();

                if (dexChoice.ToLower() == "heist")
                {
                    // Proceed to heist
                }
                else if (dexChoice.ToLower() == "more help")
                {
                    // Go to Mia or Rico
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please restart the game and try again.");
                }
            }
            else if (firstHelper.ToLower() == "rico")
            {
                Console.WriteLine("Rico uses his connections to get you inside Afterlife, a popular bar for mercenaries. Inside, you meet several potential allies. Who do you want to recruit for your heist? (hacker/fighter)");

                string recruit = Console.ReadLine();

                // Save game```csharp
                // Save game state
                File.AppendAllText(@"gamestate.txt", "\n" + recruit);

                if (recruit.ToLower() == "hacker")
                {
                    Console.WriteLine("You recruit a talented hacker who helps you in bypassing security systems of Arasaka. You now have an advantage in the upcoming heist.");
                    inventory.Add("Hacker Ally");
                }
                else if (recruit.ToLower() == "fighter")
                {
                    Console.WriteLine("You recruit a tough fighter who will provide extra muscle for your heist. You now have an advantage in the upcoming combat situations.");
                    inventory.Add("Fighter Ally");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please restart the game and try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please restart the game and try again.");
            }

            Console.WriteLine("With your team and preparations complete, you're ready to attempt the daring heist. Do you wish to proceed? (yes/no)");
            string heistChoice = Console.ReadLine();

            if (heistChoice.ToLower() == "yes")
            {
                Console.WriteLine("Your heart pounds in your chest as you and your team infiltrate the Arasaka corporation...");

                if (inventory.Contains("Hacking Skills") && inventory.Contains("Hacker Ally"))
                {
                    Console.WriteLine("Using your enhanced hacking skills and your hacker ally, you manage to infiltrate Arasaka's security systems with ease. You successfully steal the Digital Heart, becoming a legend in Night City. Congratulations, you've completed the game!");
                }
                else if (inventory.Contains("Heavy Gun") || inventory.Contains("Body Armor"))
                {
                    Console.WriteLine("You storm the Arasaka corporation with brute force, taking down anyone who stands in your way. You successfully steal the Digital Heart, but not without leaving a trail of chaos behind. You become a feared figure in Night City. Congratulations, you've completed the game!");
                }
                else
                {
                    Console.WriteLine("Despite your best efforts, you fail to steal the Digital Heart. But this is just one setback in the grand scheme of things. You learn from your mistakes and vow to keep trying. Night City hasn't seen the last of you yet.");
                }
            }
            // If the player chooses not to proceed...
            else if (playerChoice.ToLower() == "no")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You decide it's too risky. You continue your life in the streets of Night City, always wondering what might have been...");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please restart the game and try again.");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice. Please restart the game and try again.");
        }
    }
}