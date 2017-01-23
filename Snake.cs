using System;

namespace SnakeGame
{
	/// <summary>
	/// Абстрактный класс "змейки"
	/// </summary>
	public abstract class Snake
	{
		// абстрактный метод, описывающий движение "змейки"
		public abstract void Move();
		
		// абстрактный метод, описывающий процесс "питания" "змейки"
		public abstract void Eat();
		
		// абстрактный метод, описывающий процесс увеличения тела "змейки"
		// сделан защищённым, поскольку процесс увеличения не связан
		// ни с какими внешними факторами
		protected abstract void Enhance();
		
		// абстрактный метод, проверяющий, не столкнулась ли "змейка" с самой собой
		protected abstract bool BumpBodyCheck();
		
		// абстрактный метод, проверяющий, не столкнулась ли "змейка" с краем игрового поля
		public abstract bool BumpFieldBorderCheck(Field f);
	}
}
