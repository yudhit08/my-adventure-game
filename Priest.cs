using System;

namespace My_Adventure_Game_2._0
{
    class Priest : Player
    {
        public int Mana { get; set; }
        public Priest()
        {
            Health = 250;
            Mana = 0;
            attackPower = 7;
        }
        public override void Skill(Enemy enemy)
        {
            Random rnd = new Random();
            Console.WriteLine("Skill : Blessing of Moon Goddess");
            if (Mana >= 30)
            {   
                Console.WriteLine("Healing for Everyone...");       
                Health = Health + 50;
                enemy.getHit(rnd.Next(6, 10));                
                Mana = Mana - 30;
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
            Console.WriteLine("Generating Mana");
            Mana += 10;
            Console.WriteLine("Mana : "+Mana);
        }
    }
}