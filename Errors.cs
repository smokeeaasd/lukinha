namespace Lukinha.Errors
{
	abstract class Errors
	{
		protected string prefix = "Erro";

		protected void SendMessage(string message)
		{
			Console.ForegroundColor = ConsoleColor.DarkRed;

			Console.WriteLine($"{prefix}: {message}");

			Console.ResetColor();
		}
	}
	
	internal class ParamError : Errors
	{
		public ParamError(string message)
		{
			base.prefix = "Erro de parâmetro";

			base.SendMessage(message);
		}
	}

	internal class CommandError : Errors
	{
		public CommandError(string message)
		{
			base.prefix = "Erro de comando";

			base.SendMessage(message);
		}
	}

	internal class FileError : Errors
	{
		public FileError(string message)
		{
			base.prefix = "Erro de arquivo";

			base.SendMessage(message);
		}
	}
}