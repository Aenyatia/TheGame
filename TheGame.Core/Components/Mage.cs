namespace TheGame.Core.Components
{
	public class Mage : Unit
	{
		public ManaPoints ManaPoints { get; set; }

		public Mage(HealthPoints health, ManaPoints mana)
			: base(health)
		{
			ManaPoints = mana;
		}
	}
}
