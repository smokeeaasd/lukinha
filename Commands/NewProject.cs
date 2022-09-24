using Lukinha.Projects;
using Lukinha.Errors;

namespace Lukinha.Commands
{
	public class NewProject
	{
		public static void Run(string[] args)
		{
			if (args.Length < 2)
			{
				new ParamError("especifique o tipo de projeto a ser criado.");
				return;
			}
			
			if (args[1] == "php/mvc")
			{
				MvcProject.Create(args);
			}
		}
	}
}