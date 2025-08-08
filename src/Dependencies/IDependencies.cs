namespace E314.Cli;

public partial interface IDependencies
{
	public IReadOnlyList<IModule> Modules();
}
