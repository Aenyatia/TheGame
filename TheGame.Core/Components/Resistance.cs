namespace TheGame.Core.Components
{
	public class Resistance
	{
		public DamageType DamageType { get; set; }
		public int Value { get; set; }

		public Resistance(DamageType type, int value)
		{
			DamageType = type;
			Value = value;
		}
	}
}
