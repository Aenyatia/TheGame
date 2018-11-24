namespace TheGame.Core.Weapons
{
	public abstract class Weapon
	{
		public string Name { get; protected set; }
		public int AttackDamage { get; protected set; }

		protected Weapon(string name, int attackDamage)
		{
			Name = name;
			AttackDamage = attackDamage;
		}
	}
}
