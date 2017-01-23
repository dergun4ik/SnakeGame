using System;
using System.Collections.Generic;

namespace SnakeGame
{
	/// <summary>
	/// Абстрактный класс игрового поля
	/// </summary>
	public abstract class Field
	{
		public abstract void Show(Snake snake, List<SnakeGameObject> objList);
	}
}
