using System;

namespace My_Adventure_Game_2._0
{
    class Rogue : Player
    {
        public int comboPoint { get; set; }
        Random rnd = new Random();
        public Rogue()
        {
            Health = 250;
            attackPower = 6;
            comboPoint = 0;
        }
        public override void Skill(Enemy enemy)
        {
            if(comboPoint > 3)
            {
                Console.WriteLine("Skill : Phantom Execution");
                for (int i = 0; i <= comboPoint; i++)
                {
                    Console.WriteLine("TING TING TING...");
                    enemy.getHit(attackPower + rnd.Next(6,9));
                }
                comboPoint = comboPoint - 4;
            }
            else
            {
                Console.WriteLine("Combo Point : "+comboPoint);
                Console.WriteLine("Combo Point is not Enough");
            }
        }
        public override void Defend()
        {
            Console.WriteLine("Defend!!!");
            Console.WriteLine("Generating Combo Point");
            comboPoint++;
            Console.WriteLine("Combo Point : "+comboPoint);
        }
    }
}