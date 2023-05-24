using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_Cyberpunk_Pokemon_battle_minigame
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
    }
}
