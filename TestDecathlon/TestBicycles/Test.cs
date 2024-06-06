using Decathlon.Bicycles;
using Decathlon.Bicycles.Frames;
using Decathlon.Bicycles.Pedals;
using Decathlon.Bicycles.Saddles;

namespace TestDecathlon.TestBicycles
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestBicycle()
        {
            IFrame frame = new BronzeFrame();
            ISaddle saddle = new WoodenSaddle();
            IPedal pedal = new WoodenPedal();
            
            Bicycle bicycle = new Bicycle(frame, saddle, pedal);

            Assert.AreEqual(bicycle.GetCost(), 300);
        }
    }
}
