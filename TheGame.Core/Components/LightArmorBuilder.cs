﻿using System.Collections.Generic;

namespace TheGame.Core.Components
{
	public class LightArmorBuilder
	{
		private readonly IList<Resistance> _resistances = new List<Resistance>();

		private readonly string _name;
		private readonly int _value;

		private LightArmorBuilder(string name, int value)
		{
			_name = name;
			_value = value;
		}

		public static LightArmorBuilder Create(string name, int value)
		{
			return new LightArmorBuilder(name, value);
		}

		public LightArmorBuilder BladeResistance(int value)
		{
			_resistances.Add(Resistance.BladeResistance(value));
			return this;
		}

		public LightArmorBuilder ImpactResistance(int value)
		{
			_resistances.Add(Resistance.ImpactResistance(value));
			return this;
		}

		public LightArmorBuilder MissilesResistance(int value)
		{
			_resistances.Add(Resistance.MissilesResistance(value));
			return this;
		}

		public LightArmorBuilder FireResistance(int value)
		{
			_resistances.Add(Resistance.FireResistance(value));
			return this;
		}

		public LightArmorBuilder IceResistance(int value)
		{
			_resistances.Add(Resistance.IceResistance(value));
			return this;
		}

		public LightArmorBuilder LightningResistance(int value)
		{
			_resistances.Add(Resistance.LightningResistance(value));
			return this;
		}

		public LightArmor Build()
		{
			return new LightArmor(_name, _value, _resistances);
		}

		public static implicit operator LightArmor(LightArmorBuilder builder)
		{
			return builder.Build();
		}
	}
}
