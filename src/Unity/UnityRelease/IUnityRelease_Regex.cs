using System.Text.RegularExpressions;

namespace E314.Cli;

public partial interface IUnityRelease
{
	[GeneratedRegex(@"^\d+[abf]\d+$")]
	private static partial Regex Regex();
}
