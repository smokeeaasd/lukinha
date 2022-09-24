using Lukinha.Commands;

namespace Lukinha
{
	internal class Program
	{
		static void Main(string[] args)
		{
			if (args.Length == 0) return;

			switch (args[0])
			{
				case "new":
					NewProject.Run(args);
				break;

				case ".exit":
				return;

				default:
					new Errors.CommandError($"comando não encontrado: [{args[0]}]");
				break;
			}
		}
	}
}