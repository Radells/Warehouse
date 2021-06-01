using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse.Robot
{
    public abstract class RobotLoader
    {
        public string ModelNumber { get; }
        public DateTime DateCreate { get; }
        public bool ReadyToGo { get; set; }
        public RobotLoader(string modelNumber)
        {
            ModelNumber = modelNumber;
            DateCreate = DateTime.UtcNow;
            ReadyToGo = true;
        }
        public void Signal()
        {
            Console.WriteLine($"Робот модели {ModelNumber} был создан");
            Console.WriteLine($"Время создания {DateCreate}");
        }
    }
}
