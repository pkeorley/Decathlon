using Decathlon.Bicycles.Frames;
using Decathlon.Bicycles.Pedals;
using Decathlon.Bicycles.Saddles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decathlon.Bicycles
{
    public class Bicycle : ICost
    {
        private IFrame _frame;
        private ISaddle _saddle;
        private IPedal _pedal;

        public Bicycle(IFrame frame, ISaddle saddle, IPedal pedal)
        {
            _frame = frame;
            _saddle = saddle;
            _pedal = pedal;
        }

        public IFrame Frame { get => _frame; set => _frame = value; }
        public ISaddle Saddle { get => _saddle; set => _saddle = value; }
        public IPedal Pedal { get => _pedal; set => _pedal = value; }

        public double GetCost()
        {
            return _frame.GetCost() + _saddle.GetCost() + _pedal.GetCost();
        }
    }
}
