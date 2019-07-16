using NUnit.Framework;

namespace Winap.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            var winnap = global::Winap.Setup();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}