using TheGame.Core.People;

namespace TheGame.Core.Potions
{
	public class HealthPotion : Potion, IUsable
	{
		public HealthPotion(string name, int restorePoints)
			: base(name, restorePoints)
		{
		}

		public void Use(Unit unit)
		{
			unit.HealthPoints = unit.HealthPoints + RestorePoints > unit.MaxHealth
				? unit.MaxHealth
				: unit.HealthPoints + RestorePoints;
		}
	}
}
