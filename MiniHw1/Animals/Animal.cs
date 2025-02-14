using MiniHw1.Interfaces;

namespace MiniHw1.Animals;

public abstract class Animal : IAlive, IInventory
{
    public int Number { get; set; }
    public string Name { get; set; }
    public int Health { get; set; }
    public int Food { get; set; }

    protected Animal(int number, string name, int health, int food)
    {
        Number = number;
        Name = name;
        Health = health;
        Food = food;
    }
}
