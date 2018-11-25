using System.Collections.Generic;

namespace TheGame.Core.Components
{
	public class Sword : Weapon
	{
		public IList<Damage> Damages { get; set; }

		protected Sword(string name, int value)
			: base(name, value)
		{
		}
	}
}
