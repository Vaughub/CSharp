using System;
using System.Collections.Generic;
using System.Text;

namespace threeInRow
{
	class BoardView
	{
		public static void Show(BoardModel z)
		{
			Console.Clear();
			Console.WriteLine("  a b c ");
			Console.WriteLine(" ┌─────┐");
			Console.WriteLine("1│" + z.route[0] + " " + z.route[3] + " " + z.route[6] + "│");
			Console.WriteLine("2│" + z.route[1] + " " + z.route[4] + " " + z.route[7] + "│");
			Console.WriteLine("3│" + z.route[2] + " " + z.route[5] + " " + z.route[8] + "│");
			Console.WriteLine(" └─────┘");
		}
	}
}
