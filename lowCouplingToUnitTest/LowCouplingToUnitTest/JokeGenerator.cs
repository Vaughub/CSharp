using System;
using System.Threading.Tasks;

namespace LowCouplingToUnitTest
{
	public class JokeGenerator
    {
	    private IJokesApi FetchJokes { get; }

	    public JokeGenerator(IJokesApi jokes)
	    {
		    FetchJokes = jokes;
	    }

	    public async Task<string> GetJokeWithWordTwoTimes(string word)
        {
            var jokes = await FetchJokes.GettingJokes(word);

            foreach (var joke in jokes)
            {
                var firstPosition = joke.IndexOf(word, StringComparison.OrdinalIgnoreCase);
                if (firstPosition == -1) continue;
                var secondPosition = joke.IndexOf(word, firstPosition + 1, StringComparison.OrdinalIgnoreCase);
                if (secondPosition != -1) return joke;
            }

            return null;
        }
    }
}
