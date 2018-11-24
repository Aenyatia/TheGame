namespace TheGame.Core.Weapons
{
	public sealed class Bow : Weapon, IWeapon
	{
		public Bow(string name, int attackDamage)
			: base(name, attackDamage)
		{
		}

		public void Hit(IAttackable target)
		{
			target.TakeDamage(AttackDamage);
		}
	}
}
