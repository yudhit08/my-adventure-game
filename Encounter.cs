using System;

namespace My_Adventure_Game_2._0
{
    class Encounter
    {
        public Encounter(Player player, Enemy enemy)
        {
            Story gameStory = new Story();
            Console.WriteLine($"You are encountering {enemy.Name}");
            Console.WriteLine($"{enemy.Name} is attacking you....");
            Console.WriteLine("Choose your action : ");
            Console.WriteLine("(1) Single Attack");
            Console.WriteLine("(2) Skill");
            Console.WriteLine("(3) Defend");
            Console.WriteLine("(4) Run Away");
            if (Knight.stunDuration <= 0)
            {
                enemy.isStunned = false;
            }

            while (!enemy.isDead && !player.isDead && !player.isRunning)
            {
                Console.Write("Choose your action : ");
                string playerAction = Console.ReadLine();
                Random rnd = new Random();
                switch(playerAction)
                {
                    case "1":
                    Console.WriteLine("You are doing single attack");
                    enemy.getHit(player.attackPower);
                    if (!enemy.isStunned)
                    {
                        player.getHit(enemy.attackPower);   
                    }
                    player.Exp += 0.3f;
                    Console.WriteLine("Exp = "+player.Exp);
                    Console.WriteLine("Player Health : "+player.Health+" || Enemy Health : "+enemy.Health);
                    Console.WriteLine();
                    break;

                    case "2":
                    player.Skill(enemy);
                    player.Exp += 0.7f;
                    Console.WriteLine("Exp = "+player.Exp);
                    Console.WriteLine("Player Health : "+player.Health+" || Enemy Health : "+enemy.Health);
                    Console.WriteLine();
                    break;

                    case "3":
                    player.Defend();
                    if (!enemy.isStunned)
                    {
                        if(rnd.Next(0,10) < 3) 
                        {
                            enemy.Skill(player);
                        }
                    }
                    player.Exp += 0.1f;
                    Console.WriteLine("Exp = "+player.Exp);
                    Console.WriteLine("Player Health : "+player.Health+" || Enemy Health : "+enemy.Health);
                    Console.WriteLine();
                    break;

                    case "4":
                    player.isRunning = true;
                    Console.WriteLine("You are attempt to run away");
                    player.Exp = 0;
                    Console.WriteLine();
                    break;
                }
                if (enemy.isStunned)
                {
                    Knight.stunDuration--;
                }
            }
            if (enemy.isDead)
            {
                Console.WriteLine("\nYou get "+player.Exp+" experience");
                Console.WriteLine("Level UP");
                player.Health += 100;
                player.attackPower += 9;
                Console.WriteLine("Player Health : "+player.Health);  
            }
            else if(player.isDead)
            {
                gameStory.loseStory();
                Console.WriteLine("Closing...");
                Environment.Exit(0);
            }
        }
    }
}
