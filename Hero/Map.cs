using System;
using Hero_Journey;
using Hero_Weapon;
public class Ui
{
    public static void WeaponStats()
    {
        Random random = new Random();
        int A = random.Next(5, 100);
        int B = random.Next(30, 100);
        Weapon weapon = new Weapon(A, B);

        weapon.Type = "Random";

        Console.WriteLine($"A {weapon.Type}");
        Console.WriteLine($"Would you like to name your {weapon.Type}");
        string answer = Console.ReadLine().ToLower();
        if (answer == "yes")
        {
            Console.WriteLine($"How do u want to name your {weapon.Type}?");
            weapon.Name = "No name";
        }
        else
        {
            weapon.Name = weapon.Type;
        }


            weapon.ShowWeapon();
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

    public static void Main(string[] args)
    {
        Hero hero = new Hero(100, 50, 1);
        Console.WriteLine("Welcome to |Hero of the Landscape| ");
        Console.WriteLine("Please enter your hero's name:");
        hero.Name = "No Name";
        Console.WriteLine($"Hello {hero.Name}!");
        Console.WriteLine("Welcome to the journey of your lifetime!");
        
        Console.WriteLine($"Now.... you run up to a chest.... You open the chest and you find weapon and it is...");
        WeaponStats();
        Console.WriteLine("Now you can start your journey!");
        ShowMap();
        string direction = Console.ReadLine().ToLower();
        switch (direction)
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
        }
    }
}
