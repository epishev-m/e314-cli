namespace E314.Cli;

public interface IJsonFile
{
	T Read<T>();

	void Write<T>(T obj);
}
