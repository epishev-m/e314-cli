namespace E314.Cli;

public partial interface IRepo
{
	string Path();

	string Url();

	bool Clone();
}
