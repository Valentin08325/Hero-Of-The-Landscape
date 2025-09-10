using Hero_Journey;
using System;

namespace Monsters
{
    public class Monster
    {
        private int health;
        private int damage;
        private string name;
        public Monster(int health, int damage)
        {
            this.health = health;
            this.damage = damage;
            this.name = "Goblin";
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public int Damage
        {
            get { return damage; }
        }
        public string Name
        {
            get { return name; }
        }
        public void Attack(Hero hero)
        {
            Random random = new Random();
            int newDamage = random.Next(1, Damage);
            if (newDamage == Damage)
            {
                Console.WriteLine("Critical hit!");
            }

            if (hero.Health > 0)
            { 
             Thread.Sleep(2000);
             Console.WriteLine($"The {name} attacks you and deals {newDamage} damage!");
             hero.Health -= newDamage;
            }
            else
            {
                Console.WriteLine("The hero fell!");
            }
        }
        public void ShowStats()
        {
            Console.WriteLine($"Monster: {name}, Health: {health}, Damage: {damage}");
        }
    }
}