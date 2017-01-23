using System;
using System.Collections.Generic;

namespace SnakeGame
{
	/// <summary>
	/// Класс-клиент
	/// </summary>
	public class GameProcess
	{
		protected Field gamefield;
		protected Snake snake;
		protected List<SnakeGameObject> list;
		
		public GameProcess(SnakeGameFactory gp){
			gamefield = gp.CreateField();
			snake = gp.CreateSnake();
			list = new List<SnakeGameObject>();
		}
		
		public virtual void Run(){
			
		}
	}
}