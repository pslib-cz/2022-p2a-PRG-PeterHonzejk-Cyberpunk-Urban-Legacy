using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_Cyberpunk_Pokemon_battle_minigame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cyberblaze = new Pokemon("Cyberblaze", 200, 40, 40);
            var nanoclaw = new Pokemon("Nanoclaw", 200, 50, 50);
            string choice;
            bool usedChargeUp = false;
            bool usedSystemRestore = false;

            Console.WriteLine("As you reach out, your hand successfully grasps the control panel, revealing its true nature as the interface for Cyberblaze, a magnificent cybernetically enhanced horse!");
            Console.WriteLine("You select Nanoclaw as the target and are presented with a selection of four moves: Volt Tackle, an electric-type attack move; Inferno Blast, a powerful fire-type attack move; Charge Up, a move that boosts your attack; and System Restore, a move that provides healing abilities.");

            while (true)
            {
                Console.WriteLine("Choose Cyberblaze's move: (1) Volt Tackle, (2) Inferno Blast [" + cyberblaze.InfernoBlastUses + "/5], (3) Charge Up, (4) System Restore");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        cyberblaze.VoltTackle(nanoclaw);
                        break;
                    case "2":
                        cyberblaze.InfernoBlast(nanoclaw);
                        break;
                    case "3":
                        cyberblaze.ChargeUp();
                        usedChargeUp = true;
                        break;
                    case "4":
                        cyberblaze.SystemRestore();
                        usedSystemRestore = true;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Cyberblaze uses Volt Tackle by default.");
                        Console.ResetColor();
                        cyberblaze.VoltTackle(nanoclaw);
                        break;
                }

                Console.WriteLine("Cyberblaze HP: " + cyberblaze.HP + "/" + cyberblaze.MaxHP);
                Console.WriteLine("Nanoclaw HP: " + nanoclaw.HP + "/" + nanoclaw.MaxHP);

                if (nanoclaw.CheckIfFainted())
                {
                    if (usedChargeUp && usedSystemRestore)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Cyberblaze wins!");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("Cyberblaze did not use all moves. Nanoclaw wins by default!");
                    }
                    break;
                }

                nanoclaw.MoveCounter++;
                if (nanoclaw.MoveCounter % 10 == 0)
                {
                    nanoclaw.MegaBite(cyberblaze);
                }
                else if (nanoclaw.MoveCounter % 5 == 0 && nanoclaw.HP < nanoclaw.MaxHP)  // Only heal if HP is below maximum
                {
                    nanoclaw.SystemRestore();
                }
                else if (nanoclaw.MoveCounter % 2 == 0)
                {
                    nanoclaw.CyberScratch(cyberblaze);
                }
                else
                {
                    nanoclaw.NanoBite(cyberblaze);
                }

                if (cyberblaze.CheckIfFainted())
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nanoclaw wins!");
                    Console.ResetColor();
                    break;
                }
            }
        }
    }
}
