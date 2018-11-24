using TheGame.Core.Weapons;

namespace TheGame.Core.Repositories
{
	public interface IWeaponRepository
	{
		IWeapon GetWeapon(int weaponId);
	}
}
