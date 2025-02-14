namespace MiniHw1.Animals;

public abstract class Predator : Animal
{
	protected Predator(int number, string name, int health, int food)
		: base(number, name, health, food)
	{
	}
}
