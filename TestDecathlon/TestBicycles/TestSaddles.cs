using Decathlon.Bicycles.Saddles;

namespace TestDecathlon.TestBicycles
{
    [TestClass]
    public class TestSaddles
    {
        [TestMethod]
        public void TestLeatherSaddle()
        {
            ISaddle saddle = new LeatherSaddle();
            Assert.AreEqual(saddle.GetCost(), 350);
        }

        [TestMethod]
        public void TestWoodenSaddle()
        {
            ISaddle saddle = new WoodenSaddle();
            Assert.AreEqual(saddle.GetCost(), 100);
        }
    }
}