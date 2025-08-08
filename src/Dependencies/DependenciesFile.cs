namespace E314.Cli;

public sealed class DependenciesFile(IModulesFile file) : IDependencies
{
	public IReadOnlyList<IModule> Modules() => file.Read();
}
