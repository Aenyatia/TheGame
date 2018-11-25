namespace TheGame.Core
{
	public interface IItem
	{
		string Name { get; }
		string Description { get; }
		int Value { get; }
	}
}
