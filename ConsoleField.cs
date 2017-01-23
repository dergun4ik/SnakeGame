using System;
using System.Collections.Generic;

namespace SnakeGame
{
	/// <summary>
	/// Игровое поле в консоли,
	/// наследуемое от абстрактного игрового поля
	/// </summary>
	public class ConsoleField : Field
	{
		public int Width{
			get;
			private set;
		}
		
		public int Height{
			get;
			private set;
		}
		
		public ConsoleField(int w = 20, int h = 20)
		{
			this.Width = w;
			this.Height = h;
		}
		
		public override void Show(Snake s, List<SnakeGameObject> objList)
		{
			Console.Clear();
			
			if (!(s is ConsoleSnake))
				throw new Exception("Тип змейки не тот!");
			ConsoleSnake snake = s as ConsoleSnake;
			
			// выводим верхнюю строку
			for (int i = 0; i <= Width + 1; i++) {
				Console.Write("-");
			}
			Console.WriteLine();
			
			// выводим середину
			for (int i = 0; i < Height; i++) {
				Console.Write("-");
				for (int j = 0; j < Width; j++) {
					bool occupiedPlace = false;
					// проверяем, не совпадает ли каждая точка "тела" "змейки"
					// с данной клеткой игрового поля
					foreach (Point part in snake.GetBody()) {
						if (part.X == j && part.Y == i){
							Console.Write("*");
							occupiedPlace = true;
							break;
						}
					}
					if (!occupiedPlace){
						// перебираем все игровые объекты
						foreach (SnakeGameObject obj in objList) {
							if (!(obj is ConsoleSnakeGameObject))
								throw new Exception("Тип игрового объекта не тот!");
							ConsoleSnakeGameObject gameObject = obj as ConsoleSnakeGameObject;
							// и проверяем, не совпадает ли каждая точка "игрового объекта"
							// с данной клеткой игрового поля
							foreach (Point part in gameObject.GetBody()) {
								if (part.X == j && part.Y == i){
									Console.Write("%");
									occupiedPlace = true;
									break;
								}
							}
						}
					}
					if (!occupiedPlace)
						Console.Write(" ");
				}
				Console.WriteLine("-");
			}
			
			// выводим нижнюю строку
			for (int i = 0; i <= Width + 1; i++) {
				Console.Write("-");
			}
			Console.WriteLine();
		}
	}
}
