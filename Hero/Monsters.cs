using Hero_Journey;
using Hero_Weapon;
using System;

namespace Goblins
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
            Console.WriteLine($"The {name} attacks you and deals {damage} damage!");
            hero.Health -= damage;
        }
        public void ShowStats()
        {
            Console.WriteLine($"Monster: {name}, Health: {health}, Damage: {damage}");
        }
    }
}