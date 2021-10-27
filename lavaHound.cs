using System;

namespace My_Adventure_Game_2._0
{
    class lavaHound : Enemy
    {
        public lavaHound()
        {
            Health = 150;
            attackPower = 15;
            Name = "Lava Hound";
            Console.WriteLine();
            Console.WriteLine(Name+"[Level 7, Elite] is blocking your way");
        }
        public override void Skill(Player player)
        {
            Console.WriteLine("FIRE CLAWS...");
            player.getHit(2 * attackPower);
        }
    }
}