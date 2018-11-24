using TheGame.Core;
using TheGame.Core.Repositories;

namespace TheGame.Application
{
	public class Service
	{
		private readonly IWeaponRepository _weaponRepository;
		private readonly IUnitRepository _unitRepository;

		public Service(IWeaponRepository weaponRepository, IUnitRepository unitRepository)
		{
			_weaponRepository = weaponRepository;
			_unitRepository = unitRepository;
		}

		public void EquipWeapon(int unitId, int weaponId)
		{
			var unit = _unitRepository.GetUnit(unitId);
			var weapon = _weaponRepository.GetWeapon(weaponId);

			unit.EquipWeapon(weapon);
		}
	}
}
