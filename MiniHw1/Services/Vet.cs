using MiniHw1.Animals;
using MiniHw1.Interfaces;

namespace MiniHw1.Services;

public class Vet : IHealthChecker
{
    public bool CheckHealth(Animal animal)
    {
        return animal.Health > 5;
    }
}
