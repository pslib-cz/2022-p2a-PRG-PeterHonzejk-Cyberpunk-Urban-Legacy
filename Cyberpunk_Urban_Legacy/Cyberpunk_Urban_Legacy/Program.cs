using System;
using System.IO;
using System.Xml.Schema;

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

                Console.WriteLine("Do you choose to fight the corporate mercenaries protecting the Digital Heart using Mia's hacking skills or take advantage of her data to find a hidden escape route? (fight/escape)");
                string finalChoice = Console.ReadLine();

                // Save game state
                File.AppendAllText(@"gamestate.txt", "\n" + finalChoice);

                if (finalChoice.ToLower() == "fight")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"With Mia's hacking abilities, you manage to take control of the security systems and turn them against the mercenaries. However, during the fight, you sustain severe injuries. {playerName}, you became a symbol of resistance against the corporations, and your bravery inspired many...");
                    Console.ResetColor();
                }
                else if (finalChoice.ToLower() == "escape")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Using the detailed data Mia had gathered, you find a hidden escape route and manage to break free with the Digital Heart. {playerName}, you lived to fight another day, becoming a beacon of hope for those oppressed by the corporations...");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("You had a stroke and died.");
                }
            }
            else if (firstHelper.ToLower() == "dex")
            {
                Console.WriteLine("Dex takes care of securing weaponry and the escape route. With his help, you are ready for the infiltration...");

                // Further game logic, choices, and consequences would be implemented here.
                
                // Final Choices

                Console.WriteLine("Do you choose to fight the corporate mercenaries protecting the Digital Heart with Dex's weaponry or utilize his pre-planned escape route? (fight/escape)");
                string finalChoice = Console.ReadLine();

                // Save game state
                File.AppendAllText(@"gamestate.txt", "\n" + finalChoice);

                if (finalChoice.ToLower() == "fight")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"With Dex's strength and the weapons he secured, you put up a formidable fight. The mercenaries didn't stand a chance against your combined might. You managed to secure the Digital Heart, but Dex lost his life in the fight. His sacrifice allowed you, {playerName}, to become a legend of Night City. You fulfilled your dream and Dex's memory lived on...");
                    Console.ResetColor();
                }
                else if (finalChoice.ToLower() == "escape")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"With Dex's brilliant escape route, you managed to avoid the fight and steal the Digital Heart undetected. You and Dex slipped away into the night, and the corporations were none the wiser. Your cunning strategy made you a phantom of Night City. {playerName}, you became a shadowy legend that inspired fear in the corporations and hope in the people...");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("You had a stroke and died.");
                }
            }
            else
            {        
                Console.WriteLine("You had a stroke and died.");
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
            Console.WriteLine("You had a stroke and died.");
        }
    }
}