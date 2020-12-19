using System.Collections;

namespace firstSQL
{
	class Container : IEnumerator
	{
		public object? Current { get; }

		public bool MoveNext()
		{
			throw new System.NotImplementedException();
		}

		public void Reset()
		{
			throw new System.NotImplementedException();
		}

	}
}
