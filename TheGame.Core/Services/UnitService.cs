using TheGame.Core.People;

namespace TheGame.Core.Services
{
	public class UnitService
	{
		public void LevelUp(Unit unit)
		{
			if (unit.Experience >= unit.ExperienceToLevelUp)
				unit.LevelUp();
		}
	}
}
