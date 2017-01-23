/*В этом проекте будет применятся порождающий паттерн Abstract Factory,
 * поскольку возможно перенесение приложения из консольного вида на WinForms
 * или куда-нибудь ещё.
 * Структурные паттерны применятся не будут, поскольку система игры достаточно проста
 * и не предполагает изменений по ходу игры или в будущем
 */
using System;

namespace SnakeGame
{
	class Program
	{
		public static void Main(string[] args)
		{
			GameProcess process = new ConsoleGameProcess(new ConsoleSnakeGameFactory());
			process.Run();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}