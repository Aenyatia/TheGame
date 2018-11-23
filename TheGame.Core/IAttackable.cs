namespace TheGame.Core
{
	public interface IAttackable
	{
		int Defense { get; }

		void TakeDamage(int damage);
	}
}
