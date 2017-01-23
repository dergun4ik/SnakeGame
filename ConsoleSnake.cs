using System;
using System.Collections.Generic;

namespace SnakeGame
{
	/// <summary>
	/// Консольная "змейка", наследующая от абстрактной "змейки"
	/// </summary>
	public class ConsoleSnake : Snake
	{
		List<Point> body;
		Direction moveDirect;
		
		// поскольку "игрок" может воздействовать на направление движения "змейки"
		// делаем открытое свойство для установки направление,
		// но информацию о направлении делаем закрытой, поскольку другим объектам игры,
		// кроме самой "змейки", она не нужна
		public Direction MoveDirect{
			private get {
				return moveDirect;
			}
			
			set {
				this.moveDirect = value;
			}
		}
		
		public ConsoleSnake(){
			this.BodyInitialize(new Point());
			this.MoveDirect = Direction.NOMOVE;
		}
		
		private void BodyInitialize(Point initPoint){
			body = new List<Point>(3);
			body.Add(initPoint);
			body.Add(new Point(initPoint.X + 1, initPoint.Y));
			body.Add(new Point(initPoint.X + 2, initPoint.Y));
		}
		
		public override void Move()
		{
			for (int i = body.Count - 1; i > 0; i--) {
				body[i] = body[i - 1].Clone() as Point;
			}
			
			switch (this.MoveDirect) {
				case Direction.LEFT:
					body[0].X--;
					break;
				case Direction.UP:
					body[0].Y--;
					break;
				case Direction.RIGHT:
					body[0].X++;
					break;
				case Direction.DOWN:
					body[0].Y++;
					break;
					default: break;
			}
			
			if (this.BumpBodyCheck())
				throw new BumpConsoleException(body[0]);
		}
		
		public override void Eat()
		{
			this.Enhance();
		}
		
		protected override void Enhance()
		{
			Point tail = body[body.Count - 1];
			
			switch (this.MoveDirect) {
				case Direction.LEFT:					
					body.Add(new Point(tail.X + 1, tail.Y));
					break;
				case Direction.UP:
					body.Add(new Point(tail.X, tail.Y - 1));
					break;
				case Direction.RIGHT:
					body.Add(new Point(tail.X - 1, tail.Y));
					break;
				case Direction.DOWN:
					body.Add(new Point(tail.X, tail.Y + 1));
					break;
					default: break;
			}	
		}
		
		protected override bool BumpBodyCheck()
		{
			for (int i = 1; i < body.Count - 1; i++) {
				if (body[0].CompareTo(body[i]) == 0)
					return true;
			}
			
			return false;
		}
		
		public override bool BumpFieldBorderCheck(Field f)
		{
			ConsoleField cf = f as ConsoleField;
			
			if (body[0].X < 0 || body[0].Y < 0 ||
			    body[0].X >= cf.Width || body[0].Y >= cf.Height)
				return true;
			
			return false;
		}
		
		public List<Point> GetBody(){
			return this.body;
		}
	}
	
	public enum Direction {
		NOMOVE, LEFT, UP, RIGHT, DOWN
	}
	
	public class BumpConsoleException : Exception{
		
		public BumpConsoleException(Point p) : 
			base("\"Змейка\" наткнулась на какое-то препятствие в точке (" +
			     p.X + "," + p.Y + ")!"){
			
		}
	}
}
