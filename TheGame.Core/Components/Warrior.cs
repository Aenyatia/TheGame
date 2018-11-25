namespace TheGame.Core.Components
{
	public class Warrior : Unit
	{
		public Stamina Stamina { get; set; }

		public Warrior(HealthPoints health, Stamina stamina)
			: base(health)
		{
			Stamina = stamina;
		}
	}
}
