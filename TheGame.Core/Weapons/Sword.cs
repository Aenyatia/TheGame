namespace TheGame.Core.Weapons
{
	public sealed class Sword : Weapon
	{
		public Sword(string name, int attackDamage)
			: base(name, attackDamage)
		{
		}

		public override void Hit(IAttackable target)
		{
			target.TakeDamage(AttackDamage);
		}
	}
}
