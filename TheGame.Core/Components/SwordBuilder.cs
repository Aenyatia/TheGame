namespace TheGame.Core.Components
{
	public class SwordBuilder
	{
		private readonly string _name;
		private readonly int _value;
		private Damage _damage;
		private string _requirments;
		private Resistance _resistance;

		private SwordBuilder(string name, int value)
		{
			_name = name;
			_value = value;
		}

		public static SwordBuilder Create(string name, int value)
		{
			return new SwordBuilder(name, value);
		}

		public SwordBuilder AddDamage(Damage damage)
		{
			_damage = damage;
			return this;
		}

		public SwordBuilder AddRequirments(string name, int value)
		{
			_requirments = name;
			return this;
		}

		public SwordBuilder AddEffects(Resistance resistance)
		{
			_resistance = resistance;
			return this;
		}

		public Sword Build()
		{
			return new Sword(_name, _value, _damage);
		}
	}
}
