namespace E314.Cli;

public partial interface ITextFile : IFile
{
	string Read();

	void Write(string content);
}
