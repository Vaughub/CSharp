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
				screen.AddColor(box);
			}
			screen.Show();
		}
	}




	//private static void Main(string[] args)
	//{


	//	//Random random = new Random();
	//	//Box vBox = new Box(random, 40, 10);
	//	//VirtualScreen tre = new VirtualScreen(100, 25);
	//	//tre.Add(vBox);
	//	//tre.Show();

	//	//Screen vRee = new Screen();
	//	//VirtualScreenRow vScreen1 = new VirtualScreenRow(20);
	//	//VirtualScreenRow vScreen2 = new VirtualScreenRow(20);
	//	//VirtualScreenRow vScreen3 = new VirtualScreenRow(20);
	//	//vScreen1.AddBoxTopRow(5, 3);
	//	//vScreen2.AddBoxMiddleRow(4, 5);
	//	//vScreen3.AddBoxBottomRow(3, 7);
	//	//vScreen1.Show();
	//	//vScreen2.Show();
	//	//vScreen3.Show();
	//	//Console.WriteLine(vScreen.Show());
	//	//Console.WriteLine("kek");
	//	//vScreen.AddHorizontal();
	//	//vScreen.AddUpperRightCorner();
	//	//Console.WriteLine(vScreen.GetCharacter());
	//}
}
