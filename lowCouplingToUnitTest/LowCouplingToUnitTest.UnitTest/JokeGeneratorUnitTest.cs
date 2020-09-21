using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace LowCouplingToUnitTest.UnitTest
{
    public class JokeGeneratorUnitTest
    {
        [Test]
        public async Task Test1()
        {
            var fetchJokesMock = new Mock<IJokesApi>();
            fetchJokesMock.Setup(m => m.GettingJokes(It.IsAny<string>()))
	            .ReturnsAsync(new[]
	            {
		            "aa bb cc",
		            "aa bb aa",
                    "cc bb cc",
                    "aa aa aa"
	            });
            var jGenerator = new JokeGenerator(fetchJokesMock.Object);
            var jokeWithWordTwoTimes = await jGenerator.GetJokeWithWordTwoTimes("aa");
            Assert.AreEqual("aa bb aa", jokeWithWordTwoTimes);
        }

        [Test]
        public async Task Test2()
        {
	        var fetchJokesMock = new Mock<IJokesApi>();
	        fetchJokesMock.Setup(m => m.GettingJokes(It.IsAny<string>()))
		        .ReturnsAsync(new[]
		        {
			        "aa bb cc",
			        "aa bb aa",
			        "cc bb cc",
			        "aa aa aa"
		        });
	        var jGenerator = new JokeGenerator(fetchJokesMock.Object);
	        var jokeWithWordTwoTimes = await jGenerator.GetJokeWithWordTwoTimes("bb");
            Assert.IsNull(jokeWithWordTwoTimes);
        }
    }
}