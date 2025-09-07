using Goblins;

namespace Hero_Weapon;

public class Weapon
{
    private string type;
    private string name;
    private int damage;
    private int durability;

    public Weapon(int damage, int durability)
    {
        this.damage = damage;
        this.durability = durability;
        this.Type = "";
        this.name = "No Name";
    }

    public string Type
    {
        set
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 4);
            if (randomNumber == 1)
            {
                type = "Sword";
            }
            else if (randomNumber == 2)
            {
                type = "Axe";
            }
            else if (randomNumber == 3)
            {
                type = "Bow";
            }
            else
            {
                type = "Wand";
            }
        }
        get { return type; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Damage
    {
        
        get { return damage; }
    }
    public int Durability
    { 
        get { return durability; }
    }

    public void Attack(Goblin goblin)
    {
        if (durability > 0)
        {
            durability -= 1;
            Random random = new Random();
            int damage = random.Next(1, 20);
            goblin.Health -= damage;
            if (goblin.Health < 0)
            {
                goblin.Health = 0;
            }
            if(goblin.Health == 0)
            {
                Console.WriteLine("Goblin is defeated!");
            }
            if (damage == 20)
            {
                Console.WriteLine("Critical Hit!");
            }
            Console.WriteLine($"You attack with your {type}, dealing {damage} damage. Durability left: {durability}");
            Console.ReadLine();
            Console.WriteLine($"Monster took {damage} damage.");
        }
        else
        {
            Console.WriteLine($"Your {name} is broken and can't be used.");
        }
    }
    public void ShowWeapon()
    {
        Console.WriteLine("Do you wanna give name to your weapon?");
        string option = Console.ReadLine().ToLower();
        if (option == "yes" || option == "y")
        {
            Console.WriteLine("Enter the name of your weapon:");
            string name_of_weapon = Console.ReadLine();

            Name = name_of_weapon;
            Console.WriteLine($"Type: {Type}, Weapon: {name}, Damage: {Damage}, Durability: {Durability}");
        }
        else
        { Console.WriteLine($"Type: {Type}, Weapon: {type}, Damage: {Damage}, Durability: {Durability}"); }
            
    }
}