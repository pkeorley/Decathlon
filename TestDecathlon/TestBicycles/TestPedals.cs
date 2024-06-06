using Decathlon.Bicycles.Pedals;

namespace TestDecathlon.TestBicycles
{
    [TestClass]
    public class TestPedals
    {
        [TestMethod]
        public void TestWoodenPedal()
        {
            IPedal pedal = new WoodenPedal();
            Assert.AreEqual(pedal.GetCost(), 50);
        }
    }
}
