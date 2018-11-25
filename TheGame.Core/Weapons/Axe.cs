namespace TheGame.Core.Weapons
{
	public sealed class Axe : Weapon
	{
		public double ArmorPenetration { get; }

		public Axe(string name, int attackDamage, int armorPenetration)
			: base(name, attackDamage)
		{
			ArmorPenetration = armorPenetration;
		}

		public override void Hit(IAttackable target)
		{
			var pen = (int)(target.Defense * ArmorPenetration);

			target.TakeDamage(AttackDamage - (target.Defense - pen));
		}
	}
}
