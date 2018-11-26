namespace TheGame.Core.Components
{
	public class ArmorBuilder
	{
		private readonly string _name;
		private readonly int _value;

		private int _blade = 0;

		public ArmorBuilder(string name, int value)
		{
			_name = name;
			_value = value;
		}

		public static ArmorBuilder Create(string name, int value)
		{
			return new ArmorBuilder(name, value);
		}

		public ArmorBuilder WithBladeResistance(int value)
		{
			_blade = value;
			return this;
		}

		public HeavyArmor Build()
		{
			return new HeavyArmor(_name, _value, _blade, 0, 0, 0, 0, 0);
		}

		public static implicit operator HeavyArmor(ArmorBuilder builder)
		{
			return builder.Build();
		}
	}
}
