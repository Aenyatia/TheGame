using TheGame.Core.Weapons;

namespace TheGame.Core.Enemies
{
	public class Zombie : Foe
	{
		public Zombie(string name, int healthPoints, int experience, IWeapon weapon)
			: base(name, healthPoints, experience, weapon)
		{
		}
	}
}
