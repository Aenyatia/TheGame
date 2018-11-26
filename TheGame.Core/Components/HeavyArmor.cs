namespace TheGame.Core.Components
{
	public class HeavyArmor : Armor
	{
		public HeavyArmor(string name, int value, int blade, int impact, int missiles, int fire, int ice, int lightning)
			: base(name, value, ArmorType.HeavyArmor, blade, impact, missiles, fire, ice, lightning)
		{
		}
	}
}
