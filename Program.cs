using E314.Cli;
using Spectre.Console.Cli;

var app = new CommandApp();

app.Configure(config =>
{
	config.SetApplicationName("e314");

	config.AddCommand<InitCommand>("init")
		.WithDescription("Initialize a new project");

	config.AddCommand<LsCommand>("ls")
		.WithDescription("Display the list of e314 modules");

	config.AddBranch("clone", cloneCommand =>
	{
		cloneCommand.SetDescription("Clone a e314 modules");
		cloneCommand.SetDefaultCommand<CloneCommand>();

		cloneCommand.AddCommand<CloneAllCommand>("all")
			.WithDescription("Clone all e314 modules");

		cloneCommand.AddCommand<CloneCommand>("indexes")
			.WithDescription("Clone e314 modules by indexes");
	});

	config.AddBranch("new", newCommand =>
	{
		newCommand.SetDescription("Create a new e314 module");
		newCommand.SetDefaultCommand<NewUpmProjectCommand>();

		newCommand.AddCommand<NewUpmCommand>("upm")
			.WithDescription("Create a new e314 module upm");

		newCommand.AddCommand<NewUpmProjectCommand>("upm-project")
			.WithDescription("Create a new e314 module upm project");
	});
});

app.Run(args);
