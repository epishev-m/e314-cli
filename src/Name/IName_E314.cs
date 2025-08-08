namespace E314.Cli;

public partial interface IName
{
	public sealed class E314(IName name) : IName
	{
		public string Value() => $"e314.{name.Value()}";
	}
}
