using Lukinha.Errors;

namespace Lukinha.Projects
{
	public class MvcProject
	{
		public static void Create(string[] args)
		{
			string dirname = new DirectoryInfo(".").FullName;

			string project_name = (args.Length == 3) ? args[2] : "mvc";

			if (Directory.Exists($"{dirname}/{project_name}"))
			{
				new FileError($"diretório [{project_name}] já existe.");
				return;
			}
			else
			{
				try
				{
					Directory.CreateDirectory($"{dirname}/{project_name}");
				}
				catch
				{
					return;
				}

				string[] folders = {
						"App",
						"App/Model",
						"App/View",
						"App/View/modules",
						"App/Controller",
						"App/DAO",
						"Database"
					};

				foreach (string folder in folders)
				{
					try
					{
						Directory.CreateDirectory($"{dirname}/{project_name}/{folder}");
					}
					catch
					{
						return;
					}
				}

				string[] files = {
						"App/index.php",
						"App/config.php",
						"App/autoload.php",
						"App/rotas.php",
						"App/Model/Model.php",
						"App/DAO/DAO.php",
						"App/Controller/Controller.php"
					};

				foreach (string file in files)
				{
					try
					{
						File.Create($"{dirname}/{project_name}/{file}");
					}
					catch
					{
						return;
					}
				}

				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine($"Criado [{project_name}].");
				Console.ResetColor();
			}
		}
	}
}