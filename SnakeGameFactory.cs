using System;

namespace SnakeGame
{
	/// <summary>
	/// Класс "абстрактной фабрики", который будет
	/// порождать игровые объекты
	/// </summary>
	public abstract class SnakeGameFactory
	{
		public abstract Field CreateField();
		public abstract Snake CreateSnake();
	}
}
