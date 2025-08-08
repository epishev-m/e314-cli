using Spectre.Console.Cli;

namespace E314.Cli;

public sealed class CloneAllCommand : Command
{
	public override int Execute(CommandContext context)
	{
		new IModulesFile.Clone(
				new ModulesFile())
			.Execute();
		return 0;
	}
}
