namespace E314.Cli;

public interface IYamlFile : ITextFile
{
	T Read<T>();

	void Write<T>(T obj);
}