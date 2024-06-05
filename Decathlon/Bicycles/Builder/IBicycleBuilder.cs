using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decathlon.Bicycles.Builder
{
    public interface IBicycleBuilder
    {
        Bicycle GetBicycle(BicycleType type);
    }
}
