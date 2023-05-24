using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_Urban_Legacy
{
    public class Pokemon
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public int BaseAttack { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int InfernoBlastUses { get; set; }
        public int MoveCounter { get; set; }  // Added move counter for Nanoclaw

        public Pokemon(string name, int hp, int attack, int defense)
        {
            Name = name;
            HP = hp;
            MaxHP = hp;
            BaseAttack = attack;
            Attack = attack;
            Defense = defense;
            InfernoBlastUses = 5;
            MoveCounter = 0;  // Initialize move counter
        }

        public void VoltTackle(Pokemon opponent)
        {
            int damage = Attack / 2 - opponent.Defense / 4;
            if (damage < 0) damage = 0;
            opponent.HP -= damage;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Name} used Volt Tackle on {opponent.Name} and dealt {damage} damage!");
            Console.ResetColor();
        }

        public void InfernoBlast(Pokemon opponent)
        {
            if (InfernoBlastUses <= 0)
            {
                Console.WriteLine($"{Name} is out of Inferno Blast uses!");
                return;
            }

            int damage = Attack - opponent.Defense / 2;
            if (damage < 0) damage = 0;
            opponent.HP -= damage;
            InfernoBlastUses--;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Name} used Inferno Blast on {opponent.Name} and dealt {damage} damage!");
            Console.ResetColor();
        }

        public void NanoBite(Pokemon opponent)
        {
            int damage = Attack - opponent.Defense / 2;
            if (damage < 0) damage = 0;
            opponent.HP -= damage;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Name} used Nano Bite on {opponent.Name} and dealt {damage} damage!");
            Console.ResetColor();
        }

        public void MegaBite(Pokemon opponent)
        {
            int damage = Attack * 2 - opponent.Defense;
            if (damage < 0) damage = 0;
            opponent.HP -= damage;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Name} used Mega Bite on {opponent.Name} and dealt {damage} damage!");
            Console.ResetColor();
        }

        public void CyberScratch(Pokemon opponent)
        {
            int damage = Attack / 3 - opponent.Defense / 5;
            if (damage < 0) damage = 0;
            opponent.HP -= damage;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Name} used Cyber Scratch on {opponent.Name} and dealt {damage} damage!");
            Console.ResetColor();
        }

        public void ChargeUp()
        {
            Attack += 5;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{Name} used Charge Up and increased attack by 5!");
            Console.ResetColor();
        }

        public void SystemRestore()
        {
            int restoreAmount = MaxHP / 4;
            if (HP + restoreAmount > MaxHP)
            {
                restoreAmount = MaxHP - HP;
            }
            HP += restoreAmount;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{Name} used System Restore and restored {restoreAmount} HP!");
            Console.ResetColor();
        }

        public bool CheckIfFainted()
        {
            if (HP <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{Name} has fainted!");
                Console.ResetColor();
                return true;
            }
            return false;
        }

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

    nanoclaw.MoveCounter++;
                                        if (nanoclaw.MoveCounter % 10 == 0)
                                        {
                                            nanoclaw.MegaBite(cyberblaze);
                                        }
                                        else if (nanoclaw.MoveCounter % 5 == 0 && nanoclaw.HP < nanoclaw.MaxHP)
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

Console.WriteLine("Cyberblaze HP: " + cyberblaze.HP + "/" + cyberblaze.MaxHP);
Console.WriteLine("Nanoclaw HP: " + nanoclaw.HP + "/" + nanoclaw.MaxHP);


if (nanoclaw.CheckIfFainted())
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Cyberblaze wins!");
    Console.ResetColor();
    Console.WriteLine("With the heist executed flawlessly, Nanoclaw lies defeated at your feet, a mere memory of its former threat. Empowered by Cyberblaze, you seize the Digital Heart, a symbol of your victory over Arasaka's tyranny. Your names echo through Night City as legends, inspiring a resolute resistance against the corporations. Together, you ignite a revolution, toppling the oppressive regime and ushering in a new era of freedom and hope.");
}
                                    }
    }
}
