namespace TheGame.Core.Components
{
	public class Attribute
	{
		public AtributeType Type { get; set; }
		public int Value { get; set; }

		protected Attribute(AtributeType type, int value)
		{
			Type = type;
			Value = value;
		}

		public static Attribute Strength(int value)
			=> new Attribute(AtributeType.Strength, value);

		public static Attribute Dexterity(int value)
			=> new Attribute(AtributeType.Dexterity, value);

		public static Attribute Intelligance(int value)
			=> new Attribute(AtributeType.Intelligance, value);

		public static Attribute HealthPoints(int value)
			=> new Attribute(AtributeType.HealthPoints, value);

		public static Attribute ManaPoints(int value)
			=> new Attribute(AtributeType.ManaPoints, value);

		public static Attribute StaminaPoints(int value)
			=> new Attribute(AtributeType.StaminaPoints, value);
	}
}
