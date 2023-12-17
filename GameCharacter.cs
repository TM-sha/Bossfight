using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bossfight
{
    internal class GameCharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Stamina { get; set; }

        public GameCharacter(int health, int strength, int stamina, string name)
        {
            Health = health;
            Strength = strength;
            Stamina = stamina;
            OriginalStamina = Stamina;
            Name = name;
        }

        public int OriginalStamina;

        public void Fight(GameCharacter opponenet)
        {
            if (Stamina <= 0)
            {
                Console.WriteLine($"{Name} is out of stamina, the character must recharge.\n");
                Recharge();
            }
            else
            {
                Stamina -= 10;

                opponenet.Health -= Strength;
                Console.WriteLine($"{Name} attacked the enemy.\n" +
                                  $"{opponenet.Name} was dealt a damage of {Strength}.\n" +
                                  $"{opponenet.Name} has {opponenet.Health}Hp left.\n" +
                                  $"Stamina: {Stamina}\n");
                Thread.Sleep(1500);
            }
        }


        public void Recharge()
        {
            RechargeLog();
            Stamina = OriginalStamina;
        }

        private static void RechargeLog()
        {
            Console.Write("Recharging");

            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
            }
            Console.WriteLine("\n");

            //int index = 0;
            //while (index < 3)
            //{
            //    index++;
            //    Console.Write(index); //1,2,3
            //        ||
            //    Console.Write(index); //0,1,2
            //    index++;
            //}

            //int i = 0;
            //while (i < 3)
            //{
            //    i++;
            //    Console.Write(".");
            //}


            //Thread.Sleep(1000);
            //Console.Write(".");
            //
            //Console.Write(".");
            //Thread.Sleep(500);
            //Console.Write(".");
            //Thread.Sleep(500);
            //Console.Write(".\n");
            //Console.WriteLine();
        }
    }
}
