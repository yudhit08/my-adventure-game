using System;

namespace My_Adventure_Game_2._0
{
    class Story
    {
        public void Intro1()
        {
            Console.WriteLine("Credit : Yudhitya M. Renandra(2107110516)");
            Console.WriteLine("UTS DASAR PEMROGRAMAN");
            Console.WriteLine("Note : Press ENTER to continue...");
            Console.WriteLine("\n====================");
            Console.WriteLine("Warrior : Hello Adventurer! Welcome to Gods Domain ->");
            Console.ReadKey();
            Console.WriteLine("Warrior : You are play as a Novice now ->");
            Console.ReadKey();
            Console.WriteLine("Warrior : To select your job, first you must defeat the minion in Lake Town City ->");
            Console.ReadKey();
            Console.WriteLine("System : Normal Quest 'Defeat the minion in Lake Town City' ->");
            Console.ReadKey();
            Console.WriteLine("Reward : You can access Adventurer Association to select your job ->");
        }
        public void Intro2()
        {
            Console.WriteLine("\nSystem : Normal Quest has been Finished ->");
            Console.ReadKey();
            Console.WriteLine("Warrior : Wow you are best player I have ever seen in Gods Domain ->");
            Console.ReadKey();
            Console.WriteLine("Priest : And look handsome too ->");
            Console.ReadKey();
            Console.WriteLine("Rogue : I want to fight with you ->");
            Console.ReadKey();
            Console.WriteLine("Warrior : Hahaha... Okey now you can select your job... ->");
            Console.ReadKey();
            Console.WriteLine("System : There are 4 jobs in Gods Domain 'Knight, Rogue, Wizard and Priest' ->");
            Console.ReadKey();
        }
        public void mainStory()
        {
            Console.WriteLine("\nALERT!!!");
            Console.ReadKey();
            Console.WriteLine("System : You have made Flame Demon King angry! ->");
            Console.ReadKey();
            Console.WriteLine("System : Kill him before he kills you! ->");
            Console.ReadKey();
            Console.WriteLine("System : Epic Quest 'Defeat the Flame Demon King in Black Dragon Empire to Save Gods Domain' ->");
            Console.ReadKey();
            Console.WriteLine("Reward : Gold Key from Fallen Angel to open gate to Heavenly Land ->");
            Console.ReadKey();
            Console.WriteLine("Pinalty : If you fail, your Account will be reset and say good bye to your achievement ->");
            Console.ReadKey();
            Console.WriteLine("Warrior : Oh My God, who made Flame Demon King angry ->");
            Console.ReadKey();
            Console.WriteLine("Priest : I hope someone can beat Him ->");
            Console.ReadKey();
        }
        public void loseStory()
        {
            Console.WriteLine("\nSystem : Epic Quest has been FAILED, your account will be reset and you will lost your achievement... ->");
            Console.ReadKey();
            Console.WriteLine("Log out in 3 seconds... ->");
            Console.ReadKey();
        }
        public void winStory()
        {
            Console.WriteLine("\nSystem : Congratulation... Flame Demon King has been defeated ->");
            Console.ReadKey();
            Console.WriteLine("System : Here your reward ->");
            Console.ReadKey();
            Console.WriteLine("GOLD KEY");
            Console.WriteLine("'Gold Key is a Artifact from Fallen Angel, It can be used to open the gate to Heavenly Land' ->");
            Console.ReadKey();
            Console.WriteLine("DEMON KING : HAHAHAHA.... The thing I was looking for all this time has been found ->");
            Console.ReadKey();
            Console.WriteLine("DEMON KING : It's time to revenge ->");
            Console.ReadKey();
            Console.WriteLine("The End...");
        }
    }
}