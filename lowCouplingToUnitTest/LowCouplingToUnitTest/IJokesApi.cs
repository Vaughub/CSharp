using System.Collections.Generic;
using System.Threading.Tasks;

namespace LowCouplingToUnitTest
{
	public interface IJokesApi
	{
		public Task<IEnumerable<string>> GettingJokes(string word);
	}
}
