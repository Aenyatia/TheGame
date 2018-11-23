namespace TheGame.Core.Potions
{
	public abstract class Potion
	{
		public string Name { get; set; }
		public int RestorePoints { get; set; }

		protected Potion(string name, int restorePoints)
		{
			Name = name;
			RestorePoints = restorePoints;
		}
	}
}
