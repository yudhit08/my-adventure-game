using System;

namespace My_Adventure_Game_2._0
{
    class Minion : Enemy
    {
        public Minion()
        {
            Health = 100;
            attackPower = 5;
            Name = "Minion";
            Console.WriteLine();
            Console.WriteLine(Name+"[Level 1, Common] is blocking your way");
        }
        public override void Skill(Player player)
        {
            Console.WriteLine("SPEAR THRUST...");
            base.Skill(player);
        }
    }
}