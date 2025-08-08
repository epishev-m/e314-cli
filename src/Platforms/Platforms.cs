namespace E314.Cli;

public sealed class Platforms(IReadOnlyList<string> platforms) : IPlatforms
{
	public Platforms() : this([])
	{
	}

	public IReadOnlyList<string> Values() => platforms;
}
