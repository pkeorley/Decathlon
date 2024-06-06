using Decathlon.Bicycles.Frames;
using Decathlon.Bicycles.Pedals;
using Decathlon.Bicycles.Saddles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decathlon.Bicycles.Builder
{
    public class DefaultBicycleBuilder : IBicycleBuilder
    {
        public Bicycle GetBicycle(BicycleType type)
        {
            switch (type)
            {
                default:
                    return null;
                case BicycleType.RetroBicycle:
                    return new Bicycle(new BronzeFrame(), new WoodenSaddle(), new WoodenPedal());
                case BicycleType.PlusBicycle:
                    return new Bicycle(new AluminiumFrame(), new LeatherSaddle(), new WoodenPedal());
            }
        }
    }
}
