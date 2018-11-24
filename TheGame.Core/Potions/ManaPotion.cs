using TheGame.Core.People;

namespace TheGame.Core.Potions
{
	public sealed class ManaPotion : Potion, IUsable
	{
		public ManaPotion(string name, int points)
			: base(name, points)
		{
		}

		public void Use(Unit unit)
		{
			unit.ManaPoints = unit.ManaPoints + Points > unit.MaxMana
				? unit.MaxMana
				: unit.ManaPoints + Points;
		}
	}
}
