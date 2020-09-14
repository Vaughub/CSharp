using System;
using System.Text;

namespace adventureRoom2
{
	class Player
	{
		public Key[] InventoryKeys { get; set; }
		public int Position { get; set; }

		public Player()
		{
			InventoryKeys = new Key[10];
			Position = 0;
		}

		public string CheckInventory()
		{
			var txtBuilder = new StringBuilder();
			txtBuilder.AppendLine("Inventory:");
			foreach (var key in InventoryKeys) if (key != Key.None) txtBuilder.AppendLine($"   {key} key");
			return txtBuilder.Length < 13 ? "   Empty" : txtBuilder.ToString();
		}
	}
}