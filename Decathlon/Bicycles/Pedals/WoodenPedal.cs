using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decathlon.Bicycles.Pedals
{
    public class WoodenPedal : IPedal
    {
        public double GetCost()
        {
            return 50;
        }
    }
}
