using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse.Robot
{
    public class RobotLoaderHeavy : RobotLoader
    {
        public const int MaxWeight = 100;
        public RobotLoaderHeavy(string modelNumber)
            : base(modelNumber)
        {
        }
    }
}
