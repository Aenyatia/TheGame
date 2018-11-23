using TheGame.Core.People;

namespace TheGame.Core.Potions
{
	public class ManaPotion : Potion, IUsable
	{
		public ManaPotion(string name, int restorePoints)
			: base(name, restorePoints)
		{
		}

		public void Use(Unit unit)
		{
			unit.ManaPoints = unit.ManaPoints + RestorePoints > unit.MaxMana
				? unit.MaxMana
				: unit.ManaPoints + RestorePoints;
		}
	}
}
