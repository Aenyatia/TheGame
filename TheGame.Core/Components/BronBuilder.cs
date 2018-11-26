using System.Collections.Generic;

namespace TheGame.Core.Components
{
	public class BronBuilder
	{
		private readonly string _name;
		private readonly int _value;
		private readonly WeaponType _type;

		private readonly IList<Attribute> _req = new List<Attribute>();
		private readonly IList<Damage> _dmg = new List<Damage>();
		private readonly IList<Resistance> _res = new List<Resistance>();
		private readonly IList<Attribute> _atr = new List<Attribute>();

		public BronBuilder(string name, int value, WeaponType type)
		{
			_name = name;
			_value = value;
			_type = type;
		}

		public static BronBuilder Create(string name, int value, WeaponType type)
		{
			return new BronBuilder(name, value, type);
		}

		public BronBuilder DodajWymaganie(Attribute attr)
		{
			_req.Add(attr);
			return this;
		}

		public BronBuilder DodajObrazenia(Damage dmg)
		{
			_dmg.Add(dmg);
			return this;
		}

		public BronBuilder DodajOdpornosc(Resistance res)
		{
			_res.Add(res);
			return this;
		}

		public BronBuilder DodajAtrybut(Attribute attr)
		{
			_atr.Add(attr);
			return this;
		}

		public Bron Build()
		{
			return new Bron(_name, _value, _type, _req, _dmg, _res, _atr);
		}
	}
}
