using TheGame.Core.Weapons;

namespace TheGame.Core
{
	public class SwordBuilder
	{
		private string _name;
		private string _description;
		private int _value;

		public SwordBuilder WithName(string name)
		{
			_name = name;
			return this;
		}

		public SwordBuilder WithDescription(string description)
		{
			_description = description;
			return this;
		}

		public SwordBuilder WithValue(int value)
		{
			_value = value;
			return this;
		}

		public Sword Build()
		{
			return new Sword(_name, _value);
		}
	}
}
