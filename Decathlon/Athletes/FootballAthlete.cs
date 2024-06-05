using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decathlon.Athletes
{
    public class FootballAthlete : IAthlete
    {
        private string _dorsal;

        public string GetDorsal()
        {
            if (_dorsal == null)
            {
                throw new Exception("Dorsal is null");
            }
            return _dorsal;
        }

        public void SetDorsal(string dorsal)
        {
            if (dorsal == null)
            {
                throw new ArgumentNullException("Dorsal cannot be null");
            }
            if (dorsal.Trim().Length == 2)
            {
                throw new ArgumentException("Dorsal must be exactly 2 digits");
            }
            if (!dorsal.All(char.IsDigit))
            {
                throw new ArgumentException("Dorsal must contain only numeric characters");
            }

            _dorsal = dorsal;
        }

        public int GetMetresRun()
        {
            return 50;
        }
    }
}
