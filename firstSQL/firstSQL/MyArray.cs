using System;
using System.Collections;

namespace firstSQL
{
	class MyArray<T>
	{
		private T[] Data { get; set; }
		public int Length { get; private set; }

		public MyArray()
		{
			Data = new T[2];
		}

		public MyArray(int length)
		{
			Data = new T[length];
		}

		public T this[int i]
		{
			get => Data[i];
			set => Data[i] = value;
		}

		public void Add(T value)
		{
			if (Length >= Data.Length)
			{
				var newCapacity = Data.Length + 1;
				var newData = new T[newCapacity];
				Array.ConstrainedCopy(
					Data,
					0,
					newData,
					0,
					Data.Length
				);
				Data = newData;
			}

			var index = Length;
			Data[index] = value;
			Length++;
		}

	}
}
