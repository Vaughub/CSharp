using System;
using System.Collections;

namespace randomSquares
{
	class Box
	{
		public int X { get; }
		public int Y { get; }
		public int StartY => Y;
		public int EndY => Y + Height;
		public int Width { get; }
		public int Height { get; }
		private int _minimumSize = 3;
		public ConsoleColor color;
		public Box(Random random, int maxX, int maxY)
		{
			ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
			Width = random.Next(_minimumSize, maxX);
			Height = random.Next(_minimumSize, maxY);
			X = random.Next(1, maxX - Width);
			Y = random.Next(1, maxY - Height);
			color = colors[random.Next(1, 15)];
		}
	}
}
