using System;
using System.Collections.Generic;

namespace HomeWorkPurchase
{
    class Program
    {
        public static void Main()
        {
           Queue<int> purchasesQueue = new Queue<int>(new int[] { 10, 20, 30, 40, 50 });

           int accountBalance = ServeQueue(purchasesQueue);

            Console.WriteLine("All customers have been serviced.\n" +
            $"\nThe queue is over, all buyers are covered, the final balance is: {accountBalance}$\n" +
            "\nPress any key to exit...");
        }

        public static int ServeQueue(Queue<int> purchasesQueue)
        {
            int balance = 0;

            while (purchasesQueue.Count > 0)
            {
                int purchase = purchasesQueue.Dequeue();
                balance += purchase;

                Console.WriteLine($"Purchase of {purchase}$ was serviced. Account balance is {balance}$.");
                Console.ReadKey();
                Console.Clear();
            }

            return balance;
        }
    }
}
