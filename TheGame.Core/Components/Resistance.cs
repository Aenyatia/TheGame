namespace TheGame.Core.Components
{
	public class Resistance
	{
		public DamageType Type { get; private set; }
		public int Value { get; private set; }

		private Resistance(DamageType type, int value)
		{
			Type = type;
			Value = value;
		}

		public static Resistance BladeResistance(int value)
			=> new Resistance(DamageType.Blade, value);

		public static Resistance ImpactResistance(int value)
			=> new Resistance(DamageType.Impact, value);

		public static Resistance MissilesResistance(int value)
			=> new Resistance(DamageType.Missiles, value);

		public static Resistance FireResistance(int value)
			=> new Resistance(DamageType.Fire, value);

		public static Resistance IceResistance(int value)
			=> new Resistance(DamageType.Ice, value);

		public static Resistance LightningResistance(int value)
			=> new Resistance(DamageType.Lightning, value);
	}
}
