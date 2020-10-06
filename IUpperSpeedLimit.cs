using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsoleApp
{
    public interface IUpperSpeedLimit
    {
        void SetUpperSpeedLimit(int speedLimit);

        int SpeedLimit { get; }
    }
}
