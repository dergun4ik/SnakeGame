using System;

namespace SnakeGame
{
	/// <summary>
	/// Класс, переопределяющий игровой процесс для консоли
	/// </summary>
	public class ConsoleGameProcess : GameProcess
	{
		public ConsoleGameProcess(SnakeGameFactory f) : base(f)
		{
			
		}
		
		public override void Run()
		{
			try {			
				this.gamefield.Show(this.snake, this.list);
				
				ConsoleField myfield = this.gamefield as ConsoleField;
				ConsoleSnake mySnake = this.snake as ConsoleSnake;
				
				ConsoleKeyInfo cki = Console.ReadKey();
				
				while (cki.Key != ConsoleKey.Escape) {
					switch (cki.Key) {
						case ConsoleKey.LeftArrow:
							mySnake.MoveDirect = Direction.LEFT;
							break;
						case ConsoleKey.UpArrow:
							mySnake.MoveDirect = Direction.UP;
							break;
						case ConsoleKey.RightArrow:
							mySnake.MoveDirect = Direction.RIGHT;
							break;
						case ConsoleKey.DownArrow:
							mySnake.MoveDirect = Direction.DOWN;
							break;
							default: break;
					}
					mySnake.Move();
					if (mySnake.BumpFieldBorderCheck(myfield))
						throw new BumpConsoleException(mySnake.GetBody()[0]);
					myfield.Show(snake, list);
					
					cki = Console.ReadKey();
				}
			} catch (Exception ex) {
				Console.WriteLine(ex.Message);
			}
		}
	}
}
