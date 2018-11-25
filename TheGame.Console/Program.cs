using TheGame.Core.Components;

namespace TheGame.Console
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var armor0 = LightArmorBuilder.Create("Robe0", 1)
				.Build();

			LightArmor armor1 = LightArmorBuilder.Create("Robe1", 100);

			var armor2 = LightArmorBuilder
				.Create("Robe2", 200)
				.BladeResistance(10)
				.FireResistance(10)
				.Build();

			var armor3 = LightArmorBuilder
				.Create("Robe3", 300)
				.Build();
		}
	}
}
