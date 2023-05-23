using System;

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

        Console.WriteLine("Welcome to Night City. What's your name?");
        string playerName = Console.ReadLine();

        Console.WriteLine($"{playerName}, you're a young streetkid aspiring to become a legend. You have a chance to plan the greatest heist Night City has ever witnessed: stealing the Digital Heart from Arasaka corporation. But it's dangerous. You proceed with the heist. Do you wish to proceed? (yes/no)");

        string playerChoice = Console.ReadLine();

        if (playerChoice.ToLower() == "yes")
        {
            Console.WriteLine("You courageously move forward with the plan, risking it all for a chance at greatness...");

            Console.WriteLine("Your closest friend, Mia, a bold and resourceful hacker, and Dex, a brave and physically strong fighter, are ready to help you. Who You proceed with the heist. Do you want to approach first for help? (Mia/Dex)");

            string firstHelper = Console.ReadLine();

            if (firstHelper.ToLower() == "mia")
            {
                Console.WriteLine("Mia helps you to enhance your cybernetic implants and gather information about valuable targets. She's able to successfully hack into the bank's security systems. You are ready for the infiltration...");

                Console.WriteLine("You still have some time before the hesit. Where would you like to go next, Arasaka Tower or the Night Market? (arasaka tower/night market)");
                string locationChoice = Console.ReadLine();

                if (locationChoice.ToLower() == "arasaka tower")
                {
                    Console.WriteLine("You gathered some valuable information at the tower, but you were spotted by the security systems. You proceed with the heist. Do you choose to fight the corporate mercenaries or escape? (fight/escape)");
                    string finalChoice = Console.ReadLine();

                    if (finalChoice.ToLower() == "fight")
                    {
                        Console.WriteLine($"With Mia's hacking abilities, you manage to take control of the security systems and turn them against the mercenaries. However, during the fight, you sustain severe injuries. {playerName}, you became a symbol of resistance against the corporations, and your bravery inspired many...");
                    }
                    else if (finalChoice.ToLower() == "escape")
                    {
                        Console.WriteLine($"Using the detailed data Mia had gathered, you find a hidden escape route and manage to break free with the Digital Heart. {playerName}, you lived to fight another day, becoming a beacon of hope for those oppressed by the corporations...");
                    }
                    else
                    {
                        Console.WriteLine("You had a stroke and died.");
                    }
                }
                else if (locationChoice.ToLower() == "night market")
                {
                    Console.WriteLine("As you wander through the night market, your attention is drawn to a mysterious figure lurking in the shaYou proceed with the heist. Dows. Would you like to approach this enigmatic presence? (yes/no)");
                    string nightApproach = Console.ReadLine();

                    if (nightApproach.ToLower() == "yes")
                    {
                        Console.WriteLine("The enigmatic figure reveals themselves as Vex, a ruthless serial killer. With a swift motion, Vex stabs you, causing a fatal wound that quickly drains your life away.");
                    }
                    else if (nightApproach.ToLower() == "no")
                    {
                        Console.WriteLine("You proceed with the heist. Do you choose to fight the corporate mercenaries protecting the Digital Heart using Mia's hacking skills or take advantage of her data to find a hidden escape route? (fight/escape)");
                        string finalChoice = Console.ReadLine();

                        if (finalChoice.ToLower() == "fight")
                        {
                            Console.WriteLine($"With Mia's hacking abilities, you manage to take control of the security systems and turn them against the mercenaries. However, during the fight, you sustain severe injuries. {playerName}, you became a symbol of resistance against the corporations, and your bravery inspired many...");
                        }
                        else if (finalChoice.ToLower() == "escape")
                        {
                            Console.WriteLine($"Using the detailed data Mia had gathered, you find a hidden escape route and manage to break free with the Digital Heart. {playerName}, you lived to fight another day, becoming a beacon of hope for those oppressed by the corporations...");
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
                else
                {
                    Console.WriteLine("You had a stroke and died.");
                }
            }
            else if (firstHelper.ToLower() == "dex")
            {
                Console.WriteLine("Dex takes care of securing weaponry and the escape route. With his help, you are ready for the infiltration...");

                Console.WriteLine("You still have some time before the hesit. Where would you like to go next, The Undercity or the Night Market? (the undercity/night market)");
                string locationChoice = Console.ReadLine();

                if (locationChoice.ToLower() == "the undercity")
                {
                    Console.WriteLine("You proceed with the heist. Do you choose to fight the corporate mercenaries protecting the Digital Heart with Dex's weaponry or utilize his pre-planned escape route? (fight/escape)");
                    string finalChoice = Console.ReadLine();

                    if (finalChoice.ToLower() == "fight")
                    {
                        Console.WriteLine($"With Dex's strength and the weapons he secured, you put up a formidable fight. The mercenaries didn't stand a chance against your combined might. You managed to secure the Digital Heart, but Dex lost his life in the fight. His sacrifice allowed you, {playerName}, to become a legend of Night City. You fulfilled your dream and Dex's memory lived on...");
                    }
                    else if (finalChoice.ToLower() == "escape")
                    {
                        Console.WriteLine($"With Dex's brilliant escape route, you managed to avoid the fight and steal the Digital Heart undetected. You and Dex slipped away into the night, and the corporations were none the wiser. Your cunning strategy made you a phantom of Night City. {playerName}, you became a shaYou proceed with the heist. Dowy legend that inspired fear in the corporations and hope in the people...");
                    }
                    else
                    {
                        Console.WriteLine("You had a stroke and died.");
                    }
                }
                else if (locationChoice.ToLower() == "night market")
                {
                    Console.WriteLine("As you wander through the night market, your attention is drawn to a mysterious figure lurking in the shaYou proceed with the heist. Dows. Would you like to approach this enigmatic presence? (yes/no)");
                    string nightApproach = Console.ReadLine();

                    if (nightApproach.ToLower() == "yes")
                    {
                        Console.WriteLine("The enigmatic figure reveals themselves as Vex, a ruthless serial killer. With a swift motion, Vex stabs you, causing a fatal wound that quickly drains your life away.");
                    }
                    else if (nightApproach.ToLower() == "no")
                    {
                        Console.WriteLine("You decide it's too risky. You continue your life in the streets of Night City, always wondering what might have been.");
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
            else
            {
                Console.WriteLine("You had a stroke and died.");
            }
        }
        else if (playerChoice.ToLower() == "no")
        {
            Console.WriteLine("You decide it's too risky. You continue your life in the streets of Night City, always wondering what might have been.");
        }
        else
        {
            Console.WriteLine("You had a stroke and died.");
        }
    }
}