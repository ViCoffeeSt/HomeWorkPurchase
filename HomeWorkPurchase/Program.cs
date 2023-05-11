using System;
using System.Collections.Generic;

namespace HomeWorkPurchase
{
    class Program
    {
        public static void Main()
        {
            Queue<int> purchasesQueue = new Queue<int>(new int[] { 10, 20, 30, 40, 50 });

            int accountBalance = 0;

            ServeQuque(purchasesQueue, ref accountBalance);

            EndQueue(accountBalance);
        }

        public static void ServeQuque(Queue<int> purchasesQueue, ref int accountBalance)
        {
            while (purchasesQueue.Count > 0)
            {
                int purchase = purchasesQueue.Dequeue();
                accountBalance += purchase;

                Console.WriteLine($"Purchase of {purchase}$ was serviced. Account balance is {accountBalance}$.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void EndQueue(int accountBalance)
        {
            Console.WriteLine("All customers have been serviced.\n" +
                $"\nThe queue is over, all buyers are covered, the final balance is: {accountBalance}$\n" +
                "\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
