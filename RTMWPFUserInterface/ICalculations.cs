using System.Collections.Generic;

namespace RTMWPFUserInterface
{
    public interface ICalculations
    {
        List<string> Register { get; set; }

        double addDouble(int x, int y);
    }
}