using System;
using Hero_Journey;
using Hero_Weapon;
using Monsters;
using Microsoft.VisualBasic.FileIO;
using System.Threading.Tasks;
public class Ui
{
   
    static Hero hero;
    static Weapon weapon;
    static Goblin goblin;
    public static void CombatSystem()
    {
        while (hero.Health > 0 || goblin.Health > 0)
        {

            Options();
            if (goblin.Health <= 0)
            {
                Console.WriteLine("You defeated the goblin!");
                hero.Level += 1;
                break;
            }
            else if (hero.Health <= 0)
            {
                Console.WriteLine("You have been defeated by the goblin. Game Over.");
                break;
            }
            else
            {

                goblin.Attack(hero);
                WaitTwoSeconds();
                hero.ShowStats();
                WaitTwoSeconds();
            }

        }
    }
    public static void Options()
    {
        Console.WriteLine("What do u want to do?\n1.Attack\n2.Spell");
        string option = Console.ReadLine();
        if (option == "1" || option.ToLower() == "attack")
        {
            weapon.Attack(goblin);
            WaitTwoSeconds();
            goblin.ShowStats();
        }
        else if (option == "2" || option.ToLower() == "spell")
        {

           if(hero.Level >= 1)
            {
                int spelldmg = hero.Mana + hero.Level;
                hero.Spell();
                WaitTwoSeconds();
                goblin.Health -= spelldmg;
                Console.WriteLine($"You cast a spell dealing {spelldmg} damage.");
                WaitTwoSeconds();
                goblin.ShowStats();
                WaitTwoSeconds();
                hero.ShowStats();
            }
            else
            {
                Console.WriteLine("You need to be at least level 1 to cast a spell.");
            }
            return;
        }
    }
    public static void ShowMap()
    {
        Console.WriteLine("You are in a dark forest. Paths lead north, south, east, and west.");
        Console.WriteLine("What direction do you want to go?");
        Console.WriteLine("1. North");
        Console.WriteLine("2. South");
        Console.WriteLine("3. East");
        Console.WriteLine("4. West");
    }
    public static void WaitTwoSeconds()
    {
        Task.Delay(2000).Wait();
    }
    public static void Main(string[] args)
    {
        hero = new Hero(100, 50, 2); /**/
        Console.WriteLine("Welcome to |Hero of the Landscape| ");
        WaitTwoSeconds();
        Console.WriteLine("Please enter your hero's name:");

        hero.Name = "No Name";
        Console.WriteLine($"Hello {hero.Name}!");
        WaitTwoSeconds();
        hero.ShowStats();
        WaitTwoSeconds();

        Console.WriteLine("Welcome to the journey of your lifetime!");
        WaitTwoSeconds();

        Console.WriteLine($"Now.... you run up to a chest.... \nYou open the chest and you find weapon and it is...");
        WaitTwoSeconds();

        Random random = new Random();
        int A = random.Next(5, 100); // damage
        int B = random.Next(30, 100); //durability
        weapon = new Weapon(A, B); /**/
        Console.WriteLine($"A {weapon.Type}");
        weapon.ShowWeapon();
        WaitTwoSeconds();


        goblin = new Goblin(50, 10); /**/

        Console.WriteLine($"Now... Lest test what you can do with your weapon!\nAttack the {goblin.Name}! ");
        WaitTwoSeconds();
        goblin.ShowStats();
        WaitTwoSeconds();

        CombatSystem();

        Console.WriteLine("GOOD JOB! YOU DID THE DEMO!");
    }  
}
