using Spectre.Console;

namespace E314.Cli;

public partial interface IUnityVersion
{
	public sealed class Retry(IUnityVersion version) : IUnityVersion
	{
		public string Value()
		{
			while (true)
			{
				try
				{
					return version.Value();
				}
				catch (Exception ex)
				{
					AnsiConsole.MarkupLine($"[red]{ex.Message}[/]");
				}
			}
		}
	}
}