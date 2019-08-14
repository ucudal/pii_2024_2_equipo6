using ClassLibrary;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TestsExample
    {

        private Train train;

        [SetUp]
        public void Setup()
        {
            this.train = new Train();
        }

        [Test]
        public void StartTrain()
        {
            Assert.NotNull(train);
            train.StartEngines();
            Assert.True(train.IsStartedEngine);
        }
    }
}