using Hero_Journey;
using System;

namespace Monsters
{
    public class Goblin
    {
        private int health;
        private int damage;
        private string name;
        public Goblin(int health, int damage)
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
            if (hero.Health > 0)
            { 
             Thread.Sleep(2000);
             Console.WriteLine($"The {name} attacks you and deals {damage} damage!");
             hero.Health -= damage;
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