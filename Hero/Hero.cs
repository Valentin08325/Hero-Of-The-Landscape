using System;

namespace Hero_Journey
{
    public class Hero
    {
        private int health;
        private int mana;
        private int level;
        private string name;

        public Hero(int health,int mana, int level)
        {
            this.health = health;
            this.mana = mana;
            this.level = level;
            this.name = "No Name";
        }

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
            set { level = value; }
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
        public void Spell()
        {

            if (level >= 1 && mana >= 10)
            {
                Console.WriteLine("You cast a spell!");
                mana -= 10;
            }
            else
            {
                Console.WriteLine("Not enough mana to cast a spell.");
            }
        }
    }
}