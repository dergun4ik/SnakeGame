using System;
using System.Collections.Generic;

namespace SnakeGame
{
	/// <summary>
	/// Класс простых игровых квадратиков,
	/// появляющихся время от времени на поле
	/// </summary>
	public class ConSnGameSimpleSquare: ConsoleSnakeGameObject
	{
		public ConSnGameSimpleSquare(int x, int y){
			this.body.Add(new Point(x, y));
		}
		
		public override List<Point> GetBody()
		{
			return this.body;
		}
	}
}
