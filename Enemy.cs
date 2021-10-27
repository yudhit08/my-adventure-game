using System;

namespace My_Adventure_Game_2._0
{
    class Enemy
    {
        public int attackPower { get; set; }
        public string Name { get; set; }
        public int skillSlots { get; set; }
        public int Health { get; set; }
        public bool isDead { get; set; }
        public bool isStunned { get; set; }
        Random rnd = new Random();

        public Enemy()
        {
            Health = 100;
            skillSlots = 0;
            isDead = false;
        }
        public virtual void Skill(Player player)
        {
            attackPower = rnd.Next(3,7);
            player.getHit(attackPower);
        }
        public virtual void getHit(int hitValue)
        {
            Console.WriteLine($"{Name} Get hit by {hitValue}");
            Health -= hitValue;

            if (Health <= 0)
            {
                Health = 0;
                Die();
            } 
        }
        public void Die()
        {
            Console.WriteLine($"{Name} is Die");
            isDead = true;
        }
        public virtual void bossSkill(Player player)
        {
            player.getHit((int) 10 * attackPower);
        }
    }
}