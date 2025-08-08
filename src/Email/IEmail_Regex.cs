using System.Text.RegularExpressions;

namespace E314.Cli;

public partial interface IEmail
{
	[GeneratedRegex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")]
	private static partial Regex Regex();
}
