using System;

namespace My_Adventure_Game_2._0
{
    class Wizard : Player
    {
        public int Mana { get; set; }
        public Wizard()
        {
            Health = 250;
            Mana = 0;
            attackPower = 10;
        }
        public override void Skill(Enemy enemy)
        {
            Console.WriteLine("Skill : Meteor Shower");
            if (Mana >= 10)
            {
                Console.WriteLine("WUSH...");
                enemy.getHit(5 * attackPower);
                Mana = Mana - 10;
            }
            else
            {
                Console.WriteLine("Mana : "+Mana);
                Console.WriteLine("Your Mana is too low");
            }

        }
        public override void Defend()
        {
            Console.WriteLine("Defend!!!");
            Console.WriteLine("Generating your Mana");
            Mana += 4;
            Console.WriteLine("Mana : "+Mana);
        }
    }
}