namespace TheGame.Core.Components
{
	public class Fireball
	{
		public Damage Damage { get; set; }

		public void T()
		{
			Damage = Damage.FireDamage(10);
		}
	}
}
