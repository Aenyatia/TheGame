namespace TheGame.Core.Weapons
{
	public sealed class Axe : Weapon, IWeapon
	{
		public int ArmorPenetration { get; }

		public Axe(string name, int attackDamage, int armorPenetration)
			: base(name, attackDamage)
		{
			ArmorPenetration = armorPenetration;
		}

		public void Hit(IAttackable target)
		{
			target.TakeDamage(AttackDamage);
		}
	}
}
