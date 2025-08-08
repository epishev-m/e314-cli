using System.Text;

namespace E314.Cli;

public partial interface IName
{
	public sealed class DisplayName(IName name) : IName
	{
		public string Value() => $"E314.{new PascalCase(name).Value()}";
	}
}
