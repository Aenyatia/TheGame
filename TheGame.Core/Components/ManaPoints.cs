namespace TheGame.Core.Components
{
	public class ManaPoints
	{
		public int CurrentManaPoints { get; set; }
		public int MaxManaPoints { get; set; }

		public ManaPoints(int value)
		{
			CurrentManaPoints = MaxManaPoints = value;
		}
	}
}
