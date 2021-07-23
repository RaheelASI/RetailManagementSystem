using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTMWPFUserInterface
{
    public class Calculations : ICalculations
    {
        public List<string> Register { get; set; } = new List<string>();

        public double addDouble(int x, int y)
        {
            return x + y;
        }

    }
}
