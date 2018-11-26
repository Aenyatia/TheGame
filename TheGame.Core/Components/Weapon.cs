namespace TheGame.Core.Components
{
	public class Weapon : IWeapon
	{
		public string Name { get; }
		public int Value { get; }

		public Damage Damage { get; set; }

		protected Weapon(string name, int value, Damage damage)
		{
			Name = name;
			Value = value;
			Damage = damage;
		}
	}
}
