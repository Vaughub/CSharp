using System;

namespace randomSquares
{
	class VirtualScreenCell
	{
		public bool up { get; private set; }
		public bool down { get; private set; }
		public bool left { get; private set; }
		public bool right { get; private set; }
		public ConsoleColor color = ConsoleColor.White;
		public VirtualScreenCell()
		{
			up = false;
			down = false;
			left = false;
			right = false;
		}

		public char GetCharacter()
		{
			if (up && down && left && right) return '┼';
			if (down && left && right) return '┬';
			if (up && left && right) return '┴';
			if (up && down && right) return '├';
			if (up && down && left) return '┤';
			if (up && down) return '│';
			if (left && right) return '─';
			if (up && left) return '┘';
			if (up && right) return '└';
			if (down && left) return '┐';
			if (down && right) return '┌';
			return ' ';
		}

		public void AddHorizontal()
		{
			left = true;
			right = true;
		}

		public void AddVertical()
		{
			up = true;
			down = true;
		}

		public void AddLowerLeftCorner()
		{
			down = true;
			left = true;
		}

		public void AddUpperLeftCorner()
		{
			up = true;
			left = true;
		}

		public void AddLowerRightCorner()
		{
			down = true;
			right = true;
		}

		public void AddUpperRightCorner()
		{
			up = true;
			right = true;
		}
	}
}
