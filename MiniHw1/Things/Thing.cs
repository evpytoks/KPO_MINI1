using MiniHw1.Interfaces;

namespace MiniHw1.Things;

public abstract class Thing : IInventory
{
    public int Number { get; set; }

    public Thing(int number)
    {
        Number = number;
    }
}

