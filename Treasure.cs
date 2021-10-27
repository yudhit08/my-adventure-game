using System;

namespace My_Adventure_Game_2._0
{
    class Treasure
    {
        public void intro(int gacha){
            Console.WriteLine("\nCongratulation... you have got a Gold Treasure Chest");
            Console.WriteLine("But, it was locked, you need 4 combinations code to open it...");
            Console.WriteLine("You can try it only 5 times, if you can't find the code, the treasure will disappear");
        }
        public void Gift(int gacha)
        {
            intro(gacha);
            
            Player player = new Player();
            Knight player1 = new Knight();
            Rogue player2 = new Rogue();
            Wizard player3 = new Wizard();
            Priest player4 = new Priest();
            Random rnd = new Random();   

            int codeA = rnd.Next(0,2);   
            int codeB = rnd.Next(0,2);   
            int codeC = rnd.Next(0,2);
            int codeD = rnd.Next(0,2);

            int hasilTambah = 0; 
            int hasilKali = 0;

            hasilTambah = codeA + codeB + codeC + codeD;   
            hasilKali = codeA * codeB * codeC * codeD;     

            string repeat = "yes";

            while (gacha < 5 && repeat == "yes")
            {
                Console.WriteLine("\nTotal Try : "+gacha);
                Console.WriteLine("Add result = "+hasilTambah);
                Console.WriteLine("Multiply result = "+hasilKali);
                Console.Write("\nFirst Code : ");
                string tebakanA = Console.ReadLine();
                Console.Write("Second code : "); 
                string tebakanB = Console.ReadLine();
                Console.Write("Third code : ");
                string tebakanC = Console.ReadLine();
                Console.Write("Fourth code : ");
                string tebakanD = Console.ReadLine();
                Console.WriteLine("Your code : "+tebakanA+" "+tebakanB+" "+tebakanC+" "+tebakanD+" ?");

                int tebakA = Convert.ToInt32(tebakanA);
                int tebakB = Convert.ToInt32(tebakanB);
                int tebakC = Convert.ToInt32(tebakanC);
                int tebakD = Convert.ToInt32(tebakanD);

                if(codeA == tebakA && codeB == tebakB && codeC == tebakC && codeD == tebakD){
                    Console.WriteLine("YOUR CODE IS RIGHT...");
                    Console.WriteLine("OPENING TREASURE CHEST...");
                    int giftTreasure = rnd.Next(5,15);
                    
                    player.attackPower += giftTreasure;
                    player1.attackPower += giftTreasure;
                    player2.attackPower += giftTreasure;
                    player3.attackPower += giftTreasure;
                    player4.attackPower += giftTreasure;
                    Console.WriteLine("You get "+giftTreasure+" point of Attack Power");
                    
                    repeat = "no";
                }
                else
                {
                    Console.WriteLine("YOUR CODE IS WRONG...");
                    gacha++;
                    repeat = "yes";
                }
                if (gacha == 5)
                {
                    Console.WriteLine("Sorry you cant open Treasure Chest, Treasure Chest is gone...");
                }
            }
        }
    }
}
