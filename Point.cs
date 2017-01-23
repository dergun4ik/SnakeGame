using System;

namespace SnakeGame
{
	/// <summary>
	/// Вспомогательный класс, описывающий точку
	/// в двумерном пространстве
	/// </summary>
	public class Point : IComparable, ICloneable
	{
		public int X{
			get;
			set;
		}
		
		public int Y{
			get;
			set;
		}
		
		public Point(int x = 0, int y = 0)
		{
			this.X = x;
			this.Y = y;
		}
		
		public int CompareTo(object obj){
			Point objPoint = null;
			
			if (!(obj is Point))
				return -1;
			else 
				objPoint = obj as Point;
			
			if (this.X == objPoint.X && this.Y == objPoint.Y)
				return 0;
			else return 1;
		}
		
		public object Clone(){
			return new Point(this.X, this.Y);
		}
	}
}
