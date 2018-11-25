namespace TheGame.Core.Weapons
{
	public abstract class Weapon : IItem, IWeapon
	{
		public string Name { get; protected set; }
		public string Description { get; protected set; }
		public int Value { get; protected set; }

		public int AttackDamage { get; protected set; }

		protected Weapon(string name, int attackDamage)
		{
			Name = name;
			AttackDamage = attackDamage;
		}

		public abstract void Hit(IAttackable target);
	}
}
