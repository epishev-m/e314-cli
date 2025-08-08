namespace E314.Cli;

public sealed class GitignoreFile(ITextFile templateFile, ITextFile outputFile) : IGitignoreFile
{
	public GitignoreFile(IDir dir) : this(
		new TextFile(
			new File("gitignore.txt", new IDir.Templates())),
		new TextFile(".gitignore", dir))
	{
	}

	public void Create()
	{
		var content = templateFile.Read();
		outputFile.Write(content);
	}
}
