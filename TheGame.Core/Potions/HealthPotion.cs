using TheGame.Core.People;

namespace TheGame.Core.Potions
{
	public sealed class HealthPotion : Potion, IUsable
	{
		public HealthPotion(string name, int points)
			: base(name, points)
		{
		}

		public void Use(Unit unit)
		{
			unit.HealthPoints = unit.HealthPoints + Points > unit.MaxHealth
				? unit.MaxHealth
				: unit.HealthPoints + Points;
		}
	}
}
