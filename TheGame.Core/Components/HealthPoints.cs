namespace TheGame.Core.Components
{
	public class HealthPoints
	{
		public int CurrentHealthPoints { get; set; }
		public int MaxHealthPoints { get; set; }

		public HealthPoints(int health)
		{
			CurrentHealthPoints = MaxHealthPoints = health;
		}

		public void ChangeCurrentHealthPoints(int value)
		{
			CurrentHealthPoints = CurrentHealthPoints - value < 0
				? CurrentHealthPoints = 0
				: CurrentHealthPoints - value;
		}

		public void ChangeMaxHealthPoints(int value)
		{
			MaxHealthPoints += value;
		}
	}
}
