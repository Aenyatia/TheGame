using TheGame.Core.Weapons;

namespace TheGame.Core.Enemies
{
	public abstract class Foe : IAttackable
	{
		public string Name { get; set; }
		public int HealthPoints { get; set; }
		public IWeapon Weapon { get; set; }
		public int Experience { get; set; }
		public int Defense => 0;

		protected Foe(string name, int healthPoints, int experience, IWeapon weapon)
		{
			Name = name;
			HealthPoints = healthPoints;
			Experience = experience;
			Weapon = weapon;
		}

		public bool IsALife()
		{
			return HealthPoints > 0;
		}

		public void TakeDamage(int damage)
		{
			HealthPoints -= damage;
		}
	}
}
