using System;

namespace SnakeGame
{
	/// <summary>
	/// Класс конкретной "фабрики", которая будет
	/// порождать игровые объекты для консольной версии игры
	/// </summary>
	public class ConsoleSnakeGameFactory : SnakeGameFactory
	{
		public override Field CreateField()
		{
			return new ConsoleField();
		}
		
		public override Snake CreateSnake()
		{
			return new ConsoleSnake();
		}
	}
}
