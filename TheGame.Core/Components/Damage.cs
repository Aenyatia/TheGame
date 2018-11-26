namespace TheGame.Core.Components
{
	public sealed class Damage
	{
		public DamageType Type { get; private set; }
		public int Value { get; private set; }

		private Damage(DamageType type, int value)
		{
			Type = type;
			Value = value;
		}

		public static Damage BladeDamage(int value)
			=> new Damage(DamageType.Blade, value);

		public static Damage ImpactDamage(int value)
			=> new Damage(DamageType.Impact, value);

		public static Damage MissilesDamage(int value)
			=> new Damage(DamageType.Missiles, value);

		public static Damage FireDamage(int value)
			=> new Damage(DamageType.Fire, value);

		public static Damage IceDamage(int value)
			=> new Damage(DamageType.Ice, value);

		public static Damage LightningDamage(int value)
			=> new Damage(DamageType.Lightning, value);
	}
}
