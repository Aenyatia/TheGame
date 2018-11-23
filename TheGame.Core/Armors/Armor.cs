namespace TheGame.Core.Armors
{
	public class Armor : IArmor
	{
		public string Name { get; set; }
		public int Defense { get; set; }

		public Armor(string name, int defense)
		{
			Name = name;
			Defense = defense;
		}

		public int GetDefense()
		{
			return Defense;
		}
	}
}
