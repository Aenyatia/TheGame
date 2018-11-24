namespace TheGame.Core.Potions
{
	public abstract class Potion
	{
		public string Name { get; protected set; }
		public int Points { get; protected set; }

		protected Potion(string name, int points)
		{
			Name = name;
			Points = points;
		}
	}
}
