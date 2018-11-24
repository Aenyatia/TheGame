namespace TheGame.Core.Weapons
{
	public sealed class Sword : Weapon, IWeapon
	{
		public Sword(string name, int attackDamage)
			: base(name, attackDamage)
		{
		}

		public void Hit(IAttackable target)
		{
			target.TakeDamage(AttackDamage);
		}
	}
}
