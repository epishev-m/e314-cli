namespace E314.Cli;

public partial interface IUrl
{
	public sealed class Empty : IUrl
	{
		public string Value() => string.Empty;
	}
}
