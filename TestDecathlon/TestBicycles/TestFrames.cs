using Decathlon.Bicycles.Frames;

namespace TestDecathlon.TestBicycles
{
    [TestClass]
    public class TestFrames
    {
        [TestMethod]
        public void TestAluminiumFrame()
        {
            IFrame frame = new AluminiumFrame();
            Assert.AreEqual(frame.GetCost(), 300);
        }

        [TestMethod]
        public void TestBronzeFrame()
        {
            IFrame frame = new BronzeFrame();
            Assert.AreEqual(frame.GetCost(), 150);
        }
    }
}