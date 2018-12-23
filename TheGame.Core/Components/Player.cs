using System.Linq;

namespace TheGame.Core.Components
{
	public class Player
	{
		public HealthPoints HealthPoints { get; set; } = new HealthPoints(100);
		public Bron Bron { get; set; }
		public LightArmor Armor { get; set; }

		public void Attack(Player player)
		{
			Bron.Attack(this, player);
		}

		public void TakeDamage(int value)
		{
			HealthPoints.CurrentHealthPoints -= value;
		}
	}

	public class AttackService
	{
		public static int Attack(Player player, Player enemy)
		{
			var dmg = 0;

			foreach (var damage in player.Bron.Obrazenia)
			{
				if (damage.Type == DamageType.Blade && enemy.Armor.Resistances.Any(r => r.Type == DamageType.Blade))
				{
					dmg += damage.Value - enemy.Armor.Resistances.Single(r => r.Type == DamageType.Blade).Value;
					continue;
				}

				if (damage.Type == DamageType.Fire && enemy.Armor.Resistances.Any(r => r.Type == DamageType.Fire))
				{
					dmg += damage.Value - enemy.Armor.Resistances.Single(r => r.Type == DamageType.Fire).Value;
					continue;
				}
			}

			return dmg;
		}
	}
}
