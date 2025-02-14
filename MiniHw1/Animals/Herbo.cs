namespace MiniHw1.Animals;

public abstract class Herbo : Animal
{
    public uint Kindness { get; set; }

    protected Herbo(int number, string name, int health, int food, uint kindness)
        : base(number, name, health, food)
    {
        if (kindness > 10)
        {
            throw new ArgumentOutOfRangeException($"Kindness level must be in range [0; 10], " +
                                                      $"but was provided {kindness}");
        }

        Kindness = kindness;
    }

    public bool IsFriendly()
    {
        return Kindness > 5;
    }
}
