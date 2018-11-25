namespace TheGame.Core.Components
{
	public class Weapon : IWeapon
	{
		public string Name { get; }
		public int Value { get; }

		protected Weapon(string name, int value)
		{
			Name = name;
			Value = value;
		}
	}
}
