namespace TheGame.Core.Components
{
	public class Unit
	{
		public HealthPoints HealthPoints { get; set; }

		public Unit(HealthPoints health)
		{
			HealthPoints = health;
		}

		public void TakeDamage(int value)
		{
			HealthPoints.ChangeCurrentHealthPoints(value);
		}

		public bool IsAlive()
		{
			return HealthPoints.CurrentHealthPoints > 0;
		}
	}
}
