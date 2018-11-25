using System.Collections.Generic;

namespace TheGame.Core.Components
{
	public sealed class LightArmor : Armor
	{
		public IList<Resistance> Resistances { get; }

		public LightArmor(string name, int value, IList<Resistance> resistances)
			: base(name, value)
		{
			Resistances = resistances;
		}
	}
}
