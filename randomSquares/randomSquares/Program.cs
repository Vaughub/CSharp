using System;

namespace randomSquares
{
	internal class Program
	{
		private static int _width = 40;
		private static int _height = 20;

		static void Main(string[] args)
		{
			while (true)
			{
				Box[] boxes = CreateBoxes();
				Show(boxes);
				Console.WriteLine("(press enter for new. ctrl+c=exit)");
				Console.ReadLine();
				Console.Clear();
			}
		}

		private static Box[] CreateBoxes()
		{
			Random random = new Random();
			Box[] boxes = new Box[3];
			for (int i = 0; i < boxes.Length; i++)
			{
				boxes[i] = new Box(random, _width, _height);
			}
			return boxes;
		}

		private static void Show(Box[] boxes)
		{
			VirtualScreen screen = new VirtualScreen(_width, _height);
			foreach (Box box in boxes)
			{
				screen.Add(box);
			}
			screen.Show();
		}
	}
}
