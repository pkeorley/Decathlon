using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decathlon.Bicycles.Frames
{
    public class AluminiumFrame : IFrame
    {
        public double GetCost()
        {
            return 300;
        }
    }
}
