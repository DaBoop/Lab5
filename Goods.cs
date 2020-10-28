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
    abstract class Goods: IGoods
    {
        public int amount;
        public string name { get; protected set; }
        public int price { get; protected set; }

        protected Goods() { } // зачем.

        public Goods(string arg_name, int arg_amount, int arg_price) => (name, amount, price) = (arg_name, arg_amount, arg_price);


        
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

        public void Method1() => Console.WriteLine("I am an interface method");
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

    }




    abstract class Product: Goods
    {
        public int energyValue { get; protected set; }

        public int mass { get; protected set; }

        protected Product() { }
        public Product(string arg_name, int arg_amount, int arg_price, int arg_mass, int arg_energyValue) => (name, amount, price, mass, energyValue) = (arg_name, arg_amount, arg_price, arg_mass, arg_energyValue);


        new public void Method1() => Console.WriteLine("I'm an overriden method");
        override public void Method2() => Console.WriteLine("I'm a virtual method");

        public override string ToString()
        {
            return $"{amount} of {name} products, {price}$. Mass: {mass}. Energy value: {energyValue} kcal";
        }


    }

    abstract class Confectionery: Product
    {
        public int sugarValue { get; protected set; }

        protected Confectionery() { }
        public Confectionery(string arg_name, int arg_amount, int arg_price, int arg_mass, int arg_energyValue, int arg_sugarValue) => (name, amount, price, mass, energyValue, sugarValue) = (arg_name, arg_amount, arg_price, arg_mass, arg_energyValue, sugarValue);

        public override string ToString()
        {
            return $"{amount} of {name} confectionery products, {price}$ each. Mass: {mass}. Energy value: {energyValue} kcal. Sugar value: {sugarValue} g.";
        }
    }
    
    sealed class Cake: Confectionery
    {
       public int area { get; private set; }
       public int height { get; private set; }

       public Cake(string arg_name, int arg_amount, int arg_price, int arg_area, int arg_height) => (name, amount, price, area, height) = (arg_name, arg_amount, arg_price, arg_area, arg_height);

        public override string ToString()
        {
            return $"{amount} of {name} cakes, {price}$ each. Mass: {mass}. Energy value: {energyValue} kcal. Sugar value: {sugarValue} g.";
        }
    }

    sealed class Sweets: Confectionery
    {
        public int amountPerKg { get; private set; }
        public Sweets(string arg_name, int arg_amount, int arg_price, int arg_amountPerKg) => (name, amount, price, amountPerKg) = (arg_name, arg_amount, arg_price, arg_amountPerKg);

        public override string ToString()
        {
            return $"{amount} of {name} sweets, {price}$ per kg. Mass: {mass}. Energy value: {energyValue} kcal. Sugar value: {sugarValue} g. Average amount/kg: {amountPerKg}";
        }
    }

    sealed class Flower: Goods
    {
        public string color { get; private set; }
        public Flower (string arg_name, int arg_amount, int arg_price, string arg_color) => (name, amount, price, color ) = (arg_name, arg_amount, arg_price, arg_color);

        public override string ToString()
        {
            return $"{amount} of {color} {name} flowers, {price}$ each.";
        }
    }

    sealed class Watch : Goods
    {
        public string brand { get; private set; }
        public string type { get; private set; } // electronic, mechanical

        public Watch(string arg_name, int arg_amount, int arg_price, string arg_brand, string arg_type) => (name, amount, price, brand, type) = (arg_name, arg_amount, arg_price, arg_brand, arg_type);

        public override string ToString()
        {
            return $"{amount} of {type} {brand} {name}, {price}$ each.";
        }
    }



}
