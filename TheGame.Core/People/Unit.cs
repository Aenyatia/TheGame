using TheGame.Core.Armors;
using TheGame.Core.Weapons;

namespace TheGame.Core.People
{
	public abstract class Unit : IAttackable
	{
		public string Name { get; set; }
		public int Level { get; set; }
		public int Experience { get; set; }
		public int ExperienceToLevelUp { get; set; }

		public int MaxHealth { get; set; }
		public int HealthPoints { get; set; }

		public int MaxMana { get; set; }
		public int ManaPoints { get; set; }

		public int Defense => Armor?.GetDefense() ?? 0;
		public bool IsAlive => HealthPoints > 0;

		public IWeapon Weapon { get; set; }
		public IArmor Armor { get; set; }

		protected Unit(string name, int healthPoints, int manaPoints)
		{
			Name = name;
			MaxHealth = HealthPoints = healthPoints;
			MaxMana = ManaPoints = manaPoints;

			Level = 1;
			Experience = 0;
			ExperienceToLevelUp = 50;
		}

		public void LevelUp()
		{
			Level++;
			MaxHealth += 50;
			MaxMana += 25;
			ExperienceToLevelUp *= 2;
		}

		public void EquipWeapon(IWeapon weapon)
		{
			Weapon = weapon;
		}

		public void EquipArmor(IArmor armor)
		{
			Armor = armor;
		}

		public void TakeDamage(int damage)
		{
			HealthPoints = HealthPoints - damage < 0
				? HealthPoints = 0
				: HealthPoints - damage;
		}

		public void UseItem(IUsable item)
		{
			item.Use(this);
		}

		public void AttactTarget(IAttackable target)
		{
			Weapon.Hit(target);
		}

	}
}
