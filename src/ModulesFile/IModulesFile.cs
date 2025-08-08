namespace E314.Cli;

public partial interface IModulesFile
{
	IReadOnlyList<IModule> Read();
}
