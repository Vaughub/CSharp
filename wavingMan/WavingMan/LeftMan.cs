using System;

namespace WavingMan
{
	class LeftMan : Man
	{
		public LeftMan(int x, int y, int dx, int dy) : base(x, y, dx, dy)
		{
		}

		public override void Show()
		{
			SetCursorTop();
			SetCursorLeft();
			Console.WriteLine(ShouldWaveNextTime ? "\\o " : " o");
			SetCursorLeft();
			Console.WriteLine(ShouldWaveNextTime ? " |\\ " : "/|\\");
			//Console.WriteLine(" |\\ ");
			SetCursorLeft();
			Console.Write("/ \\");
			ShouldWaveNextTime = !ShouldWaveNextTime;
		}
	}
}
