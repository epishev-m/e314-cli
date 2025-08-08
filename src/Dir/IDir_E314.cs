namespace E314.Cli;

public partial interface IDir
{
	public sealed class E314(string dir) : IDir
	{
		public E314() : this(new Dir().Value())
		{
			Create();
		}

		public string Value() => Path.Combine(dir, ".e314");

		public void Create() => Directory.CreateDirectory(Value());

		public bool Exists() => Directory.Exists(Value());
	}
}
