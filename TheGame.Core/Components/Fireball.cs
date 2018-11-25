namespace TheGame.Core.Components
{
	public class Fireball
	{
		public Damage Damage { get; set; }

		public void T()
		{
			Damage = new Damage
			{
				Value = 10,
				Type = DamageType.Fire
			};
		}
	}
}
