using System;
using System.Collections.Generic;

namespace SnakeGame
{
	/// <summary>
	/// Абстрактный класс игровых объектов консольной версии игры,
	/// наследуется от абстрактного класса игровых объектов
	/// </summary>
	public abstract class ConsoleSnakeGameObject : SnakeGameObject
	{
		protected List<Point> body;
		
		public abstract List<Point> GetBody();
	}
	
}
