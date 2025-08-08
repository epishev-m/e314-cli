using System.Text.RegularExpressions;

namespace E314.Cli;

public partial interface IUnityVersion
{
	[GeneratedRegex(@"^\d{4}\.\d+$")]
	private static partial Regex RegexVersion();
}
