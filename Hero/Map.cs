using System;
using Hero_Journey;
using Hero_Weapon;
using Goblins;
using Microsoft.VisualBasic.FileIO;
public class Ui
{

    public static void ShowMap()
    {
        Console.WriteLine("You are in a dark forest. Paths lead north, south, east, and west.");
        Console.WriteLine("What direction do you want to go?");
        Console.WriteLine("1. North");
        Console.WriteLine("2. South");
        Console.WriteLine("3. East");
        Console.WriteLine("4. West");
    }

    public static void Main(string[] args)
    {
        Hero hero = new Hero(100, 50, 1);
        Console.WriteLine("Welcome to |Hero of the Landscape| ");
        Console.ReadLine();
        Console.WriteLine("Please enter your hero's name:");

        hero.Name = "No Name";
        Console.WriteLine($"Hello {hero.Name}!");
        Console.ReadLine();
        Console.WriteLine("Welcome to the journey of your lifetime!");
        Console.ReadLine();

        Console.WriteLine($"Now.... you run up to a chest.... You open the chest and you find weapon and it is...");
        Console.ReadLine();

        Random random = new Random();
        int A = random.Next(5, 100);
        int B = random.Next(30, 100);
        Weapon weapon = new Weapon(A,B);
        Console.WriteLine($"A {weapon.Type}");
        weapon.ShowWeapon();
        Console.ReadLine();

        Goblin goblin = new Goblin(50, 10);

        Console.WriteLine($"Now... Lest test what you can do with your weapon!\nAttack the {goblin.Name}! ");
        Console.ReadLine();
        goblin.ShowStats();
        Console.ReadLine();

        Console.WriteLine("What do u want to do?\n1.Attack\n2._____");
        /*
        string option = Console.ReadLine();

        if(option == "1" || option.ToLower() == "attack")
        {
            weapon.Attack(goblin);
            goblin.ShowStats();
        }
        else
        {
            Console.WriteLine("You did nothing and the goblin attacks you!\nYou took 10 damage.");
            hero.Health -= 10;
            hero.Level += 1;
            hero.ShowHero();
        }
        */
        // ShowMap();
        //string direction = Console.ReadLine().ToLower();
        /*  switch (direction)
          {
              case "1":
              case "north":
                  Console.WriteLine("You head north into the mountains.");
                  break;
              case "2":
              case "south":
                  Console.WriteLine("You head south into the desert.");
                  break;
              case "3":
              case "east":
                  Console.WriteLine("You head east into the forest.");
                  break;
              case "4":
              case "west":
                  Console.WriteLine("You head west into the ocean.");
                  break;
              default:
                  Console.WriteLine("Invalid direction. Please choose north, south, east, or west.");
                  break;
          }*/

        string option = Console.ReadLine();
        if (option == "1" || option.ToLower() == "attack")
        {
            weapon.Attack(goblin);
            goblin.ShowStats();
        }
        else
        {
            Console.WriteLine("You did nothing and the goblin attacks you!\nYou took 10 damage.");
            hero.Health -= 10;
            hero.Level += 1;
            hero.ShowHero();
        }

        goblin.Attack(hero);
    }

   
}
