using NUnit.Framework;
using Restub.Tests.Github;

namespace PeekalinkSdk.Tests
{
    [TestFixture]
    public class PeekalinkTests : TestBase
    {
        private PeekalinkClient Client = new PeekalinkClient(Env("API_KEY"))
        {
            Tracer = TestContext.Progress.WriteLine,
        };

        [Test]
        public void PreviewWorks()
        {
            var preview = Client.Preview("https://github.com/restub/restub");
            Assert.IsNotNull(preview);
        }

        [Test]
        public void IsAvailableWorks()
        {
            var isAvailable = Client.IsAvailable("https://github.com/restub/restub");
            Assert.IsTrue(isAvailable);
        }
    }
}