using TheGame.Core.Enemies;
using TheGame.Core.People;

namespace TheGame.Core.Services
{
	public class FightService
	{
		private readonly UnitService _unitService;

		public FightService()
		{
			_unitService = new UnitService();
		}

		public void Fight(Unit unit, Foe foe)
		{
			unit.AttactTarget(foe);

			if (foe.IsALife())
				return;

			unit.Experience += foe.Experience;
			_unitService.LevelUp(unit);
		}
	}
}
