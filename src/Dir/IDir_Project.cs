namespace E314.Cli;

public partial interface IDir
{
	public sealed class Project(string name) : IDir
	{
		public Project(IProjectInfo projectInfo) : this(
			new IName.KebabCase(
				new IName.E314(projectInfo.Name()))
				.Value())
		{
			Create();
		}

		public string Value() => Path.Combine(Environment.CurrentDirectory, name);

		public void Create() => Directory.CreateDirectory(Value());

		public bool Exists() => Directory.Exists(Value());
	}
}
