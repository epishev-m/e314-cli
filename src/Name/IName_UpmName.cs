namespace E314.Cli;

public partial interface IName
{
	public sealed class UpmName(IName name) : IName
	{
		public string Value() => $"com.e314.{new KebabCase(name).Value()}";
	}
}