namespace E314.Cli;

public sealed class Url(string value) : IUrl
{
	public Url() : this(string.Empty)
	{
	}

	public string Value()
	{
		return value;
	}
}
