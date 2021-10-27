using System;

namespace My_Adventure_Game_2._0
{
    class Player
    {
        public int attackPower { get; set; }
        public string Name { get; set; }
        public int skillSlots { get; set; }
        public int Health { get; set; }
        public bool isDead { get; set; }
        public float Exp { get; set; }
        public bool isRunning { get; set; }
        Random rnd = new Random();

        public Player()
        {
            Health = 100;
            skillSlots = 0;
            isDead = false;
            Exp = 0f;
            attackPower = rnd.Next(7, 10);
        }
        public virtual void Skill(Enemy enemy)
        {
            if (skillSlots >= 2)
            {
                Console.WriteLine("Skill : Berserk");
                attackPower = rnd.Next(8,12) * 2;
                enemy.getHit(attackPower);
                skillSlots = 0;   
            }
            else
            {
                Console.WriteLine("Skill SLots : "+skillSlots);
                Console.WriteLine("Your Skill Slots is not enough");
                getHit(rnd.Next(1, 5));
            }
        }
        public virtual void Defend()
        {
            Console.WriteLine("Defend!!!");
            Console.WriteLine("Generating Skill Slots");
            skillSlots++;
            Console.WriteLine("Skill Slots : "+skillSlots);
        }
        public virtual void getHit(int hitValue)
        {
            Console.WriteLine($"You get hit by {hitValue}");
            Health -= hitValue;

            if (Health <= 0)
            {
                Health = 0;
                Die();
            } 
        }
        public void Die()
        {
            Console.WriteLine($"You are Die");
            isDead = true;
        }
    }
}