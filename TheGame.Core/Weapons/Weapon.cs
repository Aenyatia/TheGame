namespace TheGame.Core.Weapons
{
	public abstract class Weapon : IWeapon
	{
		public string Name { get; set; }

		public int AttackDamage { get; set; }
		public double ArmorPenetration { get; set; }

		protected Weapon(string name, int attackDamage, double armorPenetration = 0.0)
		{
			Name = name;
			AttackDamage = attackDamage;
			ArmorPenetration = armorPenetration;
		}

		public void Hit(IAttackable target)
		{
			var penetration = (int)(target.Defense * ArmorPenetration);

			target.TakeDamage(AttackDamage - (target.Defense - penetration));
		}
	}
}
