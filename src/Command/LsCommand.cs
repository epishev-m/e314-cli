using Spectre.Console.Cli;

namespace E314.Cli;

internal sealed class LsCommand : Command
{
	public override int Execute(CommandContext context)
	{
		new IModulesFile.Display(
				new ModulesFile())
			.Print();
		return 0;
	}
}
