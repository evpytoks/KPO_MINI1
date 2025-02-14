using Microsoft.Extensions.DependencyInjection;
using MiniHw1.Animals;
using MiniHw1.Things;
using MiniHw1.Services;
using MiniHw1.Interfaces;
using System;

namespace MiniHw1;

internal class Program
{
    static void Main()
    {
        var services = new ServiceCollection()
           .AddSingleton<IHealthChecker, Vet>()
           .AddSingleton<Zoo>()
           .BuildServiceProvider();

        var zoo = services.GetRequiredService<Zoo>();

        zoo.AddThing(new Computer(1));
        zoo.AddThing(new Computer(2));
        zoo.AddThing(new Table(3));

        zoo.AddAnimal(new Monkey(1, "Катя", 10, 5, 10));
        zoo.AddAnimal(new Rabbit(2, "Паша", 3, 1, 4));
        zoo.AddAnimal(new Tiger(3, "Даня", 4, 3));
        zoo.AddAnimal(new Wolf(4, "Олег", 7, 10));
        zoo.AddAnimal(new Rabbit(5, "Даша", 6, 9, 4));

        Console.WriteLine("Все животные в зоопарке:");
        foreach(Animal animal in zoo._animals)
        {
            Console.WriteLine(animal.Number);
        }

        Console.WriteLine("Все предметы в зоопарке:");
        foreach (Thing thing in zoo._things)
        {
            Console.WriteLine(thing.Number);
        }

        Console.WriteLine("Кол-во еды ежесуточно:");
        Console.WriteLine(zoo.GetFood());

        Console.WriteLine("Все добрые животные:");
        foreach(Animal animal in zoo.GetFriendly())
        {
            Console.WriteLine(animal.Number);
        }
    }
}