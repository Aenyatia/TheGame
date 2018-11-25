namespace TheGame.Core.Components
{
	public class MageBuilder
	{
		public HealthPoints HealthPoints { get; set; }
		public ManaPoints ManaPoints { get; set; }

		public MageBuilder AddHealth(int value)
		{
			HealthPoints = new HealthPoints(value);
			return this;
		}

		public MageBuilder AddMana(int value)
		{
			ManaPoints = new ManaPoints(value);
			return this;
		}

		public Mage Build()
		{
			return new Mage(HealthPoints, ManaPoints);
		}
	}
}
