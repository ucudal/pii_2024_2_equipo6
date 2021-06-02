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
        public void StartTrainTest()
        {
            Assert.NotNull(train);
            train.StartEngines();
            Assert.True(train.IsEngineStarted);
        }

        [Test]
        public void StopTrainTest()
        {
            Assert.NotNull(train);
            train.StartEngines();
            train.StopEngines();
            Assert.False(train.IsEngineStarted);
        }
    }
}