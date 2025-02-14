using MiniHw1.Animals;
using MiniHw1.Things;
using MiniHw1.Interfaces;

namespace MiniHw1.Services;

public class Zoo
{
	public List<Animal> _animals;
	public List<Thing> _things;
	private readonly IHealthChecker _healthChecker;

	public Zoo(IHealthChecker healthChecker)
	{
		_healthChecker = healthChecker;
		_animals = new List<Animal>();
		_things = new List<Thing>();
	}

	public void AddAnimal(Animal animal)
	{
		if (_healthChecker.CheckHealth(animal))
		{
			_animals.Add(animal);
		}
	}

	public void AddThing(Thing thing)
	{
		_things.Add(thing);
	}


	public int GetFood()
	{
		int result = 0;
		foreach (Animal animal in _animals)
		{
			result += animal.Food;
		}
		return result;
	}


	public List<Herbo> GetFriendly()
	{
        return _animals.OfType<Herbo>().Where(herbo => herbo.IsFriendly()).ToList();
    }
}