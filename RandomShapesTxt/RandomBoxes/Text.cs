using System;

namespace RandomBoxes
{
	class Text : Shape
	{
		private string txt = "Hello!";

		public Text(int x, int y, Random random) : base(random)
		{
			X = x;
			Y = y;
		}

		public override string GetCharacter(int row, int col)
		{
			if (row != Y || col < X || col >= X + txt.Length) return null;
			var index = col - X;
			return txt[index].ToString();
		}

	}
}
