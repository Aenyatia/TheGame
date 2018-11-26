namespace TheGame.Core.Components
{
	public abstract class Armor
	{
		public string Name { get; set; }
		public int Value { get; set; }

		public ArmorType Type { get; set; }

		public int Blade { get; set; }
		public int Impact { get; set; }
		public int Missiles { get; set; }
		public int Fire { get; set; }
		public int Ice { get; set; }
		public int Lightning { get; set; }

		protected Armor(string name, int value, ArmorType type, int blade, int impact, int missiles, int fire, int ice, int lightning)
		{
			Name = name;
			Value = value;
		}

		protected Armor(string name, int value)
		{
			Name = name;
			Value = value;
		}
	}
}
