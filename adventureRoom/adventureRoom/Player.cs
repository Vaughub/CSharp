using System.Text;

namespace adventureRoom
{
	class Player
	{
		public int Position { get; set; }
		public Keys[] Content { get; set; }

		public Player()
		{
			Position = 0;
			Content = new Keys[5];
		}

		public string CheckInventory()
		{
			var txtBuilder = new StringBuilder();
			foreach (var keys in Content)
			{
				if (keys != Keys.None) txtBuilder.AppendLine($"{keys} key");
			}

			return txtBuilder.Length == 0 ? "You got nothing in inventory" : txtBuilder.ToString();
		}
	}
}