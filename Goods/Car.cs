using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Car :IGoods
    {
        string name { get; set; }
        int price { get; set; }
        int amount  { get; set; }

        public Car()
        {
            name = "";
            price = 0;
            amount = 0;
        }

        public Car(string arg_name, int arg_price, int arg_amount) => (name, price, amount) = (arg_name, arg_price, arg_amount);

        public void Add(int n) => amount += n;
        public void Remove(int n) => amount -= n;
        public void Sell() => amount--;

        public int Sell(int money)
        {
            if (money < price)
            {
                throw new System.ArgumentException("Not enough money", "money");

            }
            else
            {
                amount--;
                return money - price;
            }
        }

        public void Method1() => Console.WriteLine("I'm an interface method");

    }
}
