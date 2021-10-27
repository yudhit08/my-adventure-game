using System;

namespace My_Adventure_Game_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Story gameStory = new Story();
            gameStory.Intro1();
            Player player = new Player();
            
            Console.Write("\nWhat is your name? ");
            player.Name = Console.ReadLine();
            
            Console.Write($"\nHi {player.Name}, Ready to Explore Gods Domain(y/n)? ");
            string bReady = Console.ReadLine();

            if (bReady == "y")
            {
                Minion minion = new Minion();
                Encounter encounter01 = new Encounter(player, minion);
                gameStory.Intro2();
                if (player.Exp >= 1.0f)
                {
                    JobSelect newJob = new JobSelect();
                    newJob.jobSelect();
                }
            }
            else
            {
                Console.WriteLine("Good Bye");
            }
            Console.ReadLine();
        }
    }
}
