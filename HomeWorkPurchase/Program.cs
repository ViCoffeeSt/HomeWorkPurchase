using System;
using System.Collections.Generic;

namespace HomeWorkPurchase
{
    class Program
    {
        static readonly Queue<int> purchasesQueue = new Queue<int>(new int[] { 10, 20, 30, 40, 50 });

        static int accountBalance = 0;

        static void Main()
        {
            while(purchasesQueue.Count > 0)
            {
                QueueService();
            }

            EndQueue();
        }

        static void QueueService()
        {
                int purchase = purchasesQueue.Dequeue();
                accountBalance += purchase;

                Console.WriteLine($"Purchase of {purchase}$ was serviced. Account balance is {accountBalance}$.");
                Console.ReadKey();
                Console.Clear();
        }

        static void EndQueue()
        {
            Console.WriteLine("All customers have been serviced.\n" +
                $"\nThe queue is over, all buyers are covered, the final balance is: {accountBalance}\n" +
                "\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
