using TheGame.Core.Components;

namespace TheGame.Console
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var dagger = BronBuilder.Create("Dagger", 10, WeaponType.Dagger)
				.DodajWymaganie(Attribute.Dexterity(10))
				.DodajWymaganie(Attribute.Strength(12))
				.DodajObrazenia(Damage.BladeDamage(100))
				.Build();

			var sword = BronBuilder.Create("Sword", 20, WeaponType.Sword)
				.DodajWymaganie(Attribute.Strength(50))
				.DodajObrazenia(Damage.BladeDamage(100))
				.DodajObrazenia(Damage.IceDamage(10))
				.DodajOdpornosc(Resistance.IceResistance(10))
				.Build();

			var axe = BronBuilder.Create("Axe", 30, WeaponType.Axe)
				.DodajWymaganie(Attribute.Strength(200))
				.DodajWymaganie(Attribute.StaminaPoints(500))
				.DodajObrazenia(Damage.ImpactDamage(200))
				.DodajAtrybut(Attribute.Strength(20))
				.DodajOdpornosc(Resistance.MissilesResistance(5))
				.Build();

			var bow = BronBuilder.Create("Bow", 1, WeaponType.Bow)
				.Build();

			System.Console.WriteLine(dagger);
			System.Console.WriteLine(sword);
			System.Console.WriteLine(axe);
			System.Console.WriteLine(bow);

			System.Console.ReadLine();
		}
	}
}
