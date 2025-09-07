using System;

namespace Hero_Journey
{
    public class Hero
    {
        private int health;
        private int mana;
        private int level;
        private string name;
        public Hero(int health, int mana, int level)
        {
            this.health = health;
            this.mana = mana;
            this.level = level;
        }

        public int Health
        {
            get { return health; }
        }
        public int Mana
        {
            get { return mana; }
        }
        public int Level
        {
            get { return level; }
        }
        public string Name
        {
            set { name = Console.ReadLine(); }
            get { return name; }
        }
        public void ShowHero()
        {
            Console.WriteLine($"Name: {name}, Health: {health}, Mana: {mana}, Level: {level}");
        }
        public void ShowMana()
        {
            Console.WriteLine($"Mana: {mana}");
        }
    }
}