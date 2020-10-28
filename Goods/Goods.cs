using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    interface IGoods
    {
        void Add(int n);
        void Remove(int n);
        void Sell();
        int Sell(int money);
        void Method1();

    }
    [Serializable]
    abstract class Goods: IGoods, IComparable
    {
        public int mass { get;  set; } // почему не сказали сразу, а ток в 6 лабе               .............................
        public int amount;

        public string name { get;  set; }
        public int price { get;  set; }

        protected Goods() { } // зачем.

        public Goods(string arg_name, int arg_amount, int arg_price, int arg_mass) => (name, amount, price, mass) = (arg_name, arg_amount, arg_price, arg_mass);


        
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
        public virtual void Method2() => Console.WriteLine("I'm a virtual method");

        override public bool Equals(object o)
        {
            if ((o == null) || !GetType().Equals(o.GetType()))
            {
                return false;
            }
            else
            {
                Goods s = (Goods)o;
                return (s.name == name) && (s.price == price);
            }
        }
        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(base.GetHashCode());
            hash.Add(name);
            hash.Add(price);
            return hash.ToHashCode();
        }

        public override string ToString()
        {
            return $"{amount} of {name} goods, {price}$ each";
        }

        public int CompareTo(object obj)
        {
            Goods goods = obj as Goods;
            return name.CompareTo(goods.name);
        }
    }
    [Serializable]
    sealed class Flower: Goods
    {
        public string color { get; private set; }
        public Flower (string arg_name, int arg_amount, int arg_price, string arg_color, int arg_mass) => (name, amount, price, color, mass ) = (arg_name, arg_amount, arg_price, arg_color, arg_mass);

        public override string ToString()
        {
            return $"{amount} of {color} {name} flowers, {price}$ each.";
        }
    }
    [Serializable]
    sealed partial class Watch : Goods
    {

        public string brand { get; private set; }
        //public string type { get; private set; } // electronic, mechanical
        public enum Type
        {
            electronic = 0,
            mechanical = 1,
            sand = 2
        }
        public Type type { get; private set; }

    }



}
