using Spectre.Console;

namespace E314.Cli;

public partial interface IAuthor
{
	public sealed class InputName(string defaultValue) : IName
	{
		public string Value() => AnsiConsole.Ask("[yellow]Enter author name[/]", defaultValue);
	}
}
