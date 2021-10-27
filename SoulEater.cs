using System;

namespace My_Adventure_Game_2._0
{
    class soulEater : Enemy
    {
        public soulEater()
        {
            Health = 200;
            attackPower = 22;
            Name = "Soul Eater";
            Console.WriteLine();
            Console.WriteLine(Name+"[Level 17, Chieftain] is blocking your way");
        }
        public override void Skill(Player player)
        {
            Console.WriteLine("IRON SHELL COLLISION...");
            player.getHit(4 * attackPower);
        }
    }
}