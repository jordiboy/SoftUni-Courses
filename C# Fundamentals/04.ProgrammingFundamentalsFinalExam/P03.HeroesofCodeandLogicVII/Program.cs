using System;
using System.Collections.Generic;

namespace P03.HeroesofCodeandLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var heroes = new Dictionary<string, int[]>();

            for (int i = 0; i < n; i++)
            {
                string[] hero = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string heroname = hero[0];
                int hp = int.Parse(hero[1]);
                int mp = int.Parse(hero[2]);

                if (!heroes.ContainsKey(heroname))
                {
                    heroes.Add(heroname, new int[2]);
                }

                heroes[heroname][0] = hp;
                heroes[heroname][1] = mp;
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] commandArgs = command
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgs[0];
                string heroName = commandArgs[1];

                if (action == "CastSpell")
                {
                    int mpNeed = int.Parse(commandArgs[2]);
                    string spellName = commandArgs[3];

                    if (heroes[heroName][1] >= mpNeed)
                    {
                        heroes[heroName][1] -= mpNeed;

                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName][1]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (action == "TakeDamage")
                {
                    int damage = int.Parse(commandArgs[2]);
                    string attacker = commandArgs[3];

                    heroes[heroName][0] -= damage;

                    if (heroes[heroName][0] > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName][0]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");

                        heroes.Remove(heroName);
                    }
                }
                else if (action == "Recharge")
                {
                    int rechargeAmounth = int.Parse(commandArgs[2]);

                    if (heroes[heroName][1] + rechargeAmounth > 200)
                    {
                        int diff = 200 - heroes[heroName][1];
                        heroes[heroName][1] = 200;

                        Console.WriteLine($"{heroName} recharged for {diff} MP!");
                    }
                    else
                    {
                        heroes[heroName][1] += rechargeAmounth;
                        Console.WriteLine($"{heroName} recharged for {rechargeAmounth} MP!");
                    }
                }
                else if (action == "Heal")
                {
                    int rechargeAmounth = int.Parse(commandArgs[2]);

                    if (heroes[heroName][0] + rechargeAmounth > 100)
                    {
                        int diff = 100 - heroes[heroName][0];
                        heroes[heroName][0] = 100;

                        Console.WriteLine($"{heroName} healed for {diff} HP!");
                    }
                    else
                    {
                        heroes[heroName][0] += rechargeAmounth;

                        Console.WriteLine($"{heroName} healed for {rechargeAmounth} HP!");
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var hero in heroes)
            {
                Console.WriteLine($"{hero.Key}");
                Console.WriteLine($"  HP: {hero.Value[0]}");
                Console.WriteLine($"  MP: {hero.Value[1]}");
            }
        }
    }
}
