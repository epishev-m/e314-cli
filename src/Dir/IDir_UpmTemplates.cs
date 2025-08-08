namespace E314.Cli;

public partial interface IDir
{
	public sealed class Templates(string dir) : IDir
	{
		public Templates() : this(new IDir.E314().Value())
		{
			Create();
		}

		public string Value() => Path.Combine(dir, "templates");

		public void Create() => Directory.CreateDirectory(Value());

		public bool Exists() => Directory.Exists(Value());
	}
}
