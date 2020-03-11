using System;
using System.Collections.Generic;
using System.Text;

namespace RPS.Library
{
    public interface IRPSStrategy
    {
        string CounterStrategy(List<string> result, string playerHand);  //changed result from string to List<string>
        string CopyStrategy(string playerHand);
    }
}
