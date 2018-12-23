using System.Collections.Generic;

namespace TheGame.Core.Components
{
	public class Bron
	{
		public string Name { get; set; }
		public int Value { get; set; }
		public WeaponType Type { get; set; }

		public IList<Attribute> Wymagania { get; set; }
		public IList<Damage> Obrazenia { get; set; }
		public IList<Attribute> Atrybuty { get; set; }
		public IList<Resistance> Odpornosci { get; set; }

		public Bron(string name, int value, WeaponType type,
			IList<Attribute> wym, IList<Damage> dmg, IList<Resistance> odp, IList<Attribute> atr)
		{
			Name = name;
			Value = value;
			Type = type;
			Wymagania = wym;
			Obrazenia = dmg;
			Atrybuty = atr;
			Odpornosci = odp;
		}

		public void Attack(Player player, Player enemy)
		{
			var dmg = AttackService.Attack(player, enemy);

			enemy.TakeDamage(dmg);
		}

		public override string ToString()
		{
			var result = string.Empty;

			result += "Name: " + Name + "\n";
			result += "Gold value: " + Value + "\n";
			result += "Weapon type: " + Type + "\n";

			result += "Wymagania: \n";
			foreach (var item in Wymagania)
			{
				result += $"   {item.Type} | {item.Value} \n";
			}

			result += "Obrażenia: \n";
			foreach (var item in Obrazenia)
			{
				result += $"   {item.Type} | {item.Value} \n";
			}

			result += "Atrybuty: \n";
			foreach (var item in Atrybuty)
			{
				result += $"   {item.Type} | {item.Value} \n";
			}

			result += "Odpornosci: \n";
			foreach (var item in Odpornosci)
			{
				result += $"   {item.Type} | {item.Value} \n";
			}

			return result;
		}
	}
}
