using System;

namespace Hero_Journey
{
    public class Hero(int health, int mana, int level)
    {
        private int health = health;
        private int mana = mana;
        private int level = level;
        private string name;

        public int Health
        {
            get { return health; }
            set { health = value; }
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
            set => name = Console.ReadLine();
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