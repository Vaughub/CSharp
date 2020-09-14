namespace adventureRoom2
{
	class Door
	{
		public DoorColor DoorColor { get; set; }
		public bool DoorOpen { get; set; }

		public Door(DoorColor doorColor)
		{
			DoorColor = doorColor;
			DoorOpen = false;
		}
	}
}