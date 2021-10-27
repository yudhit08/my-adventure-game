using System;

namespace My_Adventure_Game_2._0
{
    class Knight : Player
    {
        public int Rage { get; set; }
        public static int stunDuration = 3;
        
        public Knight()
        {
            Health = 250;
            attackPower = 15;
            Rage = 0;
        }
        public override void Skill(Enemy enemy)
        {
            Console.WriteLine("Skill : Ground Splitter");
            if (Rage >= 2)
            {
                stunDuration = 3;
                Console.WriteLine("BASH...");
                Console.WriteLine($"{enemy.Name} is being stunned for {stunDuration} second");
                enemy.isStunned = true;
                enemy.getHit(3 * attackPower);
                Rage = Rage - 2;
            }
            else
            {
                Console.WriteLine("Rage : "+Rage);
                Console.WriteLine("Your Rage is to low...");
            }
        }
        public override void Defend()
        {
            Console.WriteLine("Defend!!!");
            Console.WriteLine("Generating Rage...");
            Rage++;
            Console.WriteLine("Rage : "+Rage);
        }
    }
}