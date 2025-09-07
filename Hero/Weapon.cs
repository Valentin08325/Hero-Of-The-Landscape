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
      
        set
        {
            name = Console.ReadLine();
            
        }
        get { return name; }
    }
    public int Damage
    {
        
        get { return damage; }
    }
    public int Durability
    { 
        get { return durability; }
    }
    public void ShowWeapon()
    {
        Console.WriteLine($"Type: {type}, Weapon: {name}, Damage: {Damage}, Durability: {Durability}");
    }
}