﻿using FluentAssertions;
using TheGame.Core.Armors;
using TheGame.Core.Enemies;
using TheGame.Core.People;
using TheGame.Core.Potions;
using TheGame.Core.Services;
using TheGame.Core.Weapons;
using Xunit;

namespace TheGame.Tests
{
	public class FightServiceTests
	{
		[Fact]
		public void Test()
		{
			var fightService = new FightService();

			var shadowArmor = new Armor("Shadow Light", 10);

			var axe = new Axe("Black Axe", 50);
			var sword = new Sword("Excalibur", 25);
			var bow = new Bow("Nordmar Curse", 30);

			var healthPotion = new HealthPotion("Small HP", 10);
			var manaPotion = new ManaPotion("Small MP", 5);

			var geralt = new Player("Geralt", 100, 100);
			var banditMelee = new Bandit("Rouge", 80, 80);
			var banditRange = new Bandit("Sneeky", 50, 100);
			var zombieOne = new Zombie("Zom", 20, 40, axe);
			var zombieTwo = new Zombie("Zom", 20, 40, axe);

			geralt.EquipWeapon(sword);
			banditMelee.EquipWeapon(axe);
			banditRange.EquipWeapon(bow);

			geralt.AttactTarget(banditMelee);
			geralt.AttactTarget(banditRange);
			geralt.AttactTarget(banditRange);

			banditMelee.IsAlive.Should().BeTrue();
			banditRange.IsAlive.Should().BeFalse();
			banditMelee.HealthPoints.Should().Be(55);

			banditMelee.UseItem(healthPotion);
			banditMelee.HealthPoints.Should().Be(65);
			banditMelee.ManaPoints.Should().Be(80);
			banditMelee.UseItem(manaPotion);
			banditMelee.ManaPoints.Should().Be(80);

			fightService.Fight(geralt, zombieOne);
			geralt.Experience.Should().Be(40);

			fightService.Fight(geralt, zombieTwo);
			geralt.Experience.Should().Be(80);
			geralt.Level.Should().Be(2);
			geralt.MaxHealth.Should().Be(150);
			geralt.MaxMana.Should().Be(125);
			geralt.ExperienceToLevelUp.Should().Be(100);

			geralt.EquipArmor(shadowArmor);
			banditMelee.AttactTarget(geralt);
			geralt.HealthPoints.Should().NotBe(60);
			geralt.HealthPoints.Should().Be(55);
		}
	}
}
