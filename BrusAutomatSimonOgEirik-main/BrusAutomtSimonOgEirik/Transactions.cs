using System;
using System.Collections.Generic;
using System.Text;

namespace BrusAutomatSimonOgEirik
{
    class Transactions
    {
        private double Balance;

        public void InsertCoins(int amount)
        {
            Balance += amount;
        }

        public void ReturnCoins()
        {
            Console.WriteLine($"{Balance} coins was blurted out");
            Balance -= Balance;
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Current balance is {Balance}");
        }

        public void DeductPrice(double price)
        {
            if (Balance >= price) Balance -= price;
            else Console.WriteLine("Error 404. Poor bastard detected. You cannot afford that you silly poor bastard. Insert more money or leave thirsty");
        }
        public Lis
    }
}
