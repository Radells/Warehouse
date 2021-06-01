using System;

namespace Warehouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage storage = new Storage();
            QueueStorage queueStorage = new QueueStorage();
            Product[] product =
            {
                new Product(20),
                new Product(40),
                new Product(10),
                new Product(60),
                new Product(70)
            };
            Manager manager = new Manager();
            manager.CreateRobot(false, "b550g");
            manager.CreateRobot(true, "b450h");
            queueStorage.AddQueue(product);
            manager.Accept(queueStorage, storage);
            manager.Accept(queueStorage, storage);
            manager.Accept(queueStorage, storage);
            manager.Accept(queueStorage, storage);
            manager.Accept(queueStorage, storage);
            storage.GetInfo();
            manager.GiveAway(storage, 2);
            Console.WriteLine("----");
            storage.GetInfo();

        }
    }
}
