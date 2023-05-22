using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.ResetColor();
        // Introduction
        Console.WriteLine("Welcome to Night City. What's your name?");
        string playerName = Console.ReadLine();

        // Present the initial situation and choice
        Console.WriteLine($"{playerName}, you're a young streetkid aspiring to become a legend. You have a chance to plan the greatest heist Night City has ever witnessed: stealing the Digital Heart from Arasaka corporation. But it's dangerous. Do you wish to proceed? (yes/no)");

        string playerChoice = Console.ReadLine();

        // If the player chooses to proceed...
        if (playerChoice.ToLower() == "yes")
        {
            Console.WriteLine("You courageously move forward with the plan, risking it all for a chance at greatness...");

            // Introduce Mia and Dex
            Console.WriteLine("Your closest friend, Mia, a bold and resourceful hacker, and Dex, a brave and physically strong fighter, are ready to help you. Who do you want to approach first for help? (Mia/Dex)");

            string firstHelper = Console.ReadLine();

            // Save game state
            File.WriteAllText(@"gamestate.txt", firstHelper);

            if (firstHelper.ToLower() == "mia")
            {
                Console.WriteLine("Mia helps you to enhance your cybernetic implants and gather information about valuable targets. She's able to successfully hack into the bank's security systems. You are ready for the infiltration...");

                // Further game logic, choices, and consequences would be implemented here.
                // For now, let's head to the final choice.

                Console.WriteLine("Do you choose to fight the corporate mercenaries protecting the Digital Heart or find a hidden escape route? (fight/escape)");
                string finalChoice = Console.ReadLine();

                // Save game state
                File.AppendAllText(@"gamestate.txt", "\n" + finalChoice);

                if (finalChoice.ToLower() == "fight")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Despite your best efforts, the odds were overwhelming. You fought valiantly, {playerName}, but you were severely wounded. You became a legend, a symbol of resistance against the corporations. Your legacy lived on...");
                    Console.ResetColor();
                }
                else if (finalChoice.ToLower() == "escape")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Using your wit, you find a hidden escape route and manage to break free. {playerName}, you lived to fight another day and continued to rise against the corporations, inspiring the people of Night City...");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please restart the game and try again.");
                }
            }
            else if (firstHelper.ToLower() == "dex")
            {
                Console.WriteLine("Dex takes care of securing weaponry and the escape route. With his help, you are ready for the infiltration...");

                // Further game logic, choices, and consequences would be implemented here.
                // For now, let's head to the final choice.

                Console.WriteLine("Do you choose to fight the corporate mercenaries protecting the Digital Heart or find a hidden escape route? (fight/escape)");
                string finalChoice = Console.ReadLine();

                // Save game state
                File.AppendAllText(@"gamestate.txt", "\n" + finalChoice);

                if (finalChoice.ToLower() == "fight")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Despite your best efforts, the odds were overwhelming. You fought valiantly, {playerName}, but you were severely wounded.You became a legend, a symbol of resistance against the corporations. Your legacy lived on...");
                    Console.ResetColor();
                }
                else if (finalChoice.ToLower() == "escape")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Using your wit, you find a hidden escape route and manage to break free. {playerName}, you lived to fight another day and continued to rise against the corporations, inspiring the people of Night City...");
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
}
