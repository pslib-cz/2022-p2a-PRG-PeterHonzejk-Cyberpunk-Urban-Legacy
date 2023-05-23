using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_Hangman_minigame
{
    class Hangman
    {
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
            Console.WriteLine("You have ten attempts to guess the password and unlock the vault.\n");

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
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You managed to hack into the vault!");
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
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Regrettably, your unsuccessful attempt to unlock the vault triggers a fatal response, resulting in a fatal discharge of electricity that ends your life.");
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

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        private void GenerateRandomPassword()
        {
            Random random = new Random();
            int index = random.Next(passwords.Length);
            password = passwords[index];

            maskedPassword = new char[password.Length];
            for (int i = 0; i < password.Length; i++)
            {
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
