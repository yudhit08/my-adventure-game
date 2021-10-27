using System;

namespace My_Adventure_Game_2._0
{
    class flameDemonKing : Enemy
    {
        public flameDemonKing()
        {
            Health = 1000;
            attackPower = 50;
            Name = "Flame Demon King";
        }
        public override void Skill(Player player)
        {
            Random rnd = new Random();
            if (rnd.Next(0,10) < 2)
            {
                Console.WriteLine("You will die little human...");
                Console.WriteLine("DIE!!!");
                player.getHit(player.Health);   
            }
            else
            {
                Console.WriteLine("REAL WORLD MANIPULATION...");
                attackPower = Convert.ToInt32(0.33 * player.Health);
                player.getHit(attackPower);        
            }
        }
    }
}