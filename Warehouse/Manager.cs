using System;
using System.Collections.Generic;
using System.Text;
using Warehouse.Robot;

namespace Warehouse
{
    public class Manager
    {
        public List<RobotLoader> robotLoaders = new List<RobotLoader>();
        public void CreateRobot(bool easy, string numberModel)
        {
            if (easy)
            {
                RobotLoaderEasy newRobot = new RobotLoaderEasy(numberModel);
                newRobot.Signal();
                robotLoaders.Add(newRobot);
            }
            else
            {
                RobotLoaderHeavy newRobot = new RobotLoaderHeavy(numberModel);
                newRobot.Signal();
                robotLoaders.Add(newRobot);
            }
        }
        public void Accept(QueueStorage queueStorage, Storage storage)
        {
            if(queueStorage.products.Peek().Weight < 50)
            {
                for(var i = 0; i < robotLoaders.Count; i++)
                {
                    if (robotLoaders[i].ReadyToGo && robotLoaders[i] is RobotLoaderEasy)
                    {
                        Product product = queueStorage.products.Dequeue();
                        product.ID = storage.storageProducts.Count;
                        storage.storageProducts.Add(product);
                    }
                    else
                    {
                        if( i == robotLoaders.Count)
                        {
                            Console.WriteLine("Нет свободных роботов для легких грузов");
                        }
                    }
                }
            }
            else
            {
                for (var i = 0; i < robotLoaders.Count; i++)
                {
                    if (robotLoaders[i].ReadyToGo && robotLoaders[i] is RobotLoaderHeavy)
                    {
                        Product product = queueStorage.products.Dequeue();
                        product.ID = storage.storageProducts.Count;
                        storage.storageProducts.Add(product);
                    }
                    else
                    if (i == robotLoaders.Count)
                    {
                        Console.WriteLine("Нет свободных роботов для тяжелых грузов");
                    }
                }
            }
        }
        public void GiveAway(Storage storage, int ID)
        {
            for(var i = 0; i < storage.storageProducts.Count; i++)
            {
                if(storage.storageProducts[i].ID == ID)
                {
                    if(storage.storageProducts[i].Weight < 50)
                    {
                        for(var j = 0; j < robotLoaders.Count; j++)
                        {
                            if (robotLoaders[j].ReadyToGo && robotLoaders[j] is RobotLoaderEasy)
                            {
                                storage.storageProducts.RemoveAt(ID);
                            }
                            else
                            {
                                if(j == robotLoaders.Count) 
                                    Console.WriteLine("Нет свободных роботов");
                            }
                        }
                    }
                    else
                    {
                        for (var j = 0; j < robotLoaders.Count; j++)
                        {
                            if (robotLoaders[j].ReadyToGo && robotLoaders[j] is RobotLoaderHeavy)
                            {
                                storage.storageProducts.RemoveAt(ID);
                            }
                            else
                            {
                                if (j == robotLoaders.Count)
                                    Console.WriteLine("Нет свободных роботов");
                            }
                        }
                    }
                }
            }
        }
    }
}
