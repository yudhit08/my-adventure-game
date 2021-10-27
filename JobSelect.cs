using System;

namespace My_Adventure_Game_2._0
{
    class JobSelect
    {
        public void jobSelect()
        {
            Player novice = new Player();
            Story gameStory = new Story();
            Treasure newTreasure = new Treasure();
            Console.WriteLine("Now you can select your job");
            Console.WriteLine("(1) Knight");
            Console.WriteLine("(2) Rogue");
            Console.WriteLine("(3) Wizard");
            Console.WriteLine("(4) Priest");
            Console.Write("Select your job : ");
            string playerSelect = Console.ReadLine();

            if (playerSelect == "1")
            {
                Console.WriteLine("System : Job has been selected");
                Console.WriteLine("System : Now you play as a Knight ->");
                gameStory.mainStory();
                Knight player = new Knight();
                lavaHound lavaHound = new lavaHound();
                Encounter encounter02 = new Encounter(player, lavaHound);
                newTreasure.Gift(0);
                soulEater soulEater = new soulEater();
                Encounter encounter03 = new Encounter(player, soulEater);
                newTreasure.Gift(0);
                flameDemonKing flameDemonKing = new flameDemonKing();
                Console.WriteLine(flameDemonKing.Name+"[Level 50, Grand Lord] is SUMMONING....");
                Encounter bossEncounter = new Encounter(player, flameDemonKing);
                if (flameDemonKing.Health <= 0)
                {
                    gameStory.winStory();
                }
            }
            else if (playerSelect == "2")
            {
                Console.WriteLine("System : Job has been selected");
                Console.WriteLine("System : Now you play as a Rogue");
                gameStory.mainStory();
                Rogue player = new Rogue();
                lavaHound lavaHound = new lavaHound();
                Encounter encounter02 = new Encounter(player, lavaHound);
                newTreasure.Gift(0);
                soulEater soulEater = new soulEater();
                Encounter encounter03 = new Encounter(player, soulEater);
                newTreasure.Gift(0);
                flameDemonKing flameDemonKing = new flameDemonKing();
                Console.WriteLine(flameDemonKing.Name+"[Level 50, Grand Lord] is SUMMONING....");
                Encounter bossEncounter = new Encounter(player, flameDemonKing);
                if (flameDemonKing.Health <= 0)
                {
                    gameStory.winStory();
                }
            }
            else if (playerSelect == "3")
            {
                Console.WriteLine("System : Job has been selected");
                Console.WriteLine("System : Now you play as a Wizard");
                gameStory.mainStory();
                Wizard player = new Wizard();
                lavaHound lavaHound = new lavaHound();
                Encounter encounter02 = new Encounter(player, lavaHound);
                newTreasure.Gift(0);
                soulEater soulEater = new soulEater();
                Encounter encounter03 = new Encounter(player, soulEater);
                newTreasure.Gift(0);
                flameDemonKing flameDemonKing = new flameDemonKing();
                Console.WriteLine(flameDemonKing.Name+"[Level 50, Grand Lord] is SUMMONING....");
                Encounter bossEncounter = new Encounter(player, flameDemonKing);
                if (flameDemonKing.Health <= 0)
                {
                    gameStory.winStory();
                }
            }
            else if (playerSelect == "4")
            {
                Console.WriteLine("System : Job has been selected");
                Console.WriteLine("System : Now you play as a Priest");
                gameStory.mainStory();
                Priest player = new Priest();
                lavaHound lavaHound = new lavaHound();
                Encounter encounter02 = new Encounter(player, lavaHound);
                newTreasure.Gift(0);
                soulEater soulEater = new soulEater();
                Encounter encounter03 = new Encounter(player, soulEater);
                newTreasure.Gift(0);
                flameDemonKing flameDemonKing = new flameDemonKing();
                Console.WriteLine(flameDemonKing.Name+"[Level 50, Grand Lord] is SUMMONING....");
                Encounter bossEncounter = new Encounter(player, flameDemonKing);
                if (flameDemonKing.Health <= 0)
                {
                    gameStory.winStory();
                }
            }
        } 
    }
}