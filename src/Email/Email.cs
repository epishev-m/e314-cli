namespace E314.Cli;

public sealed class Email(string value) : IEmail
{
	public string Value() => value;
}
