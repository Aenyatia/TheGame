namespace TheGame.Core.Components
{
	public abstract class Armor
	{
		public string Name { get; set; }
		public int Value { get; set; }

		protected Armor(string name, int value)
		{
			Name = name;
			Value = value;
		}
	}
}
