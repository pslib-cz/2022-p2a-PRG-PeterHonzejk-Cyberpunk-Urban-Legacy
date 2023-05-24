using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_Urban_Legacy
{
    class Hangman
    {
        // Array of possible passwords for the game
        private string[] passwords = {
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

        private string password;
        private char[] maskedPassword;
        private int attempts;
        private List<char> guessedLetters;

        public void PlayGame()
        {
            Console.WriteLine("You have ten attempts to guess the password and breach the drone's system.\n");

            GenerateRandomPassword();

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
                            Console.WriteLine("Correct guess!");
                            if (new string(maskedPassword) == password)
                            {
                                // Success condition: the password has been fully guessed
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Successfully hacking into the drone grants you access to Arasaka's network. Infiltrating the bank, you encounter Arasaka's mercenaries, but your newfound control enables you to deactivate them effortlessly. With Dex by your side, you vanish into the shadows, spreading a formidable resistance against the corporations of Night City, leading the charge.");
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
                                // Failure condition: no attempts left
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Regrettably, your unsuccessful attempt to hack the drone triggers a fatal response, resulting in a wipe of memory that ends your life.");
                                Console.ResetColor();
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

        private void GenerateRandomPassword()
        {
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
        }
    }
}
