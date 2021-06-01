using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse.Robot
{
    public class RobotLoaderEasy : RobotLoader
    {
        public const int MaxWeight = 50;
        public RobotLoaderEasy(string modelNumber)
            : base(modelNumber)
        {
        }
    }
}
