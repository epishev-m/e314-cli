using Spectre.Console;

namespace E314.Cli;

public partial interface IEmail
{
	public sealed class Input : IEmail
	{
		public string Value()
		{
			while (true)
			{
				var email = AnsiConsole.Ask<string>("[yellow]Enter email:[/]");
				if (!string.IsNullOrWhiteSpace(email)) return email;
			}
		}
	}
}
