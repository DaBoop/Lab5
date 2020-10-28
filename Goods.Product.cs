using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{

    abstract class Product : Goods
    {
        public int energyValue { get; protected set; }

        public int mass { get; protected set; }

        protected Product() { }
        public Product(string arg_name, int arg_amount, int arg_price, int arg_mass, int arg_energyValue) => (name, amount, price, mass, energyValue) = (arg_name, arg_amount, arg_price, arg_mass, arg_energyValue);


        new public void Method1() => Console.WriteLine("I'm a new interface method");
        override public void Method2() => Console.WriteLine("I'm an overriden virtual method");

        public override string ToString()
        {
            return $"{amount} of {name} products, {price}$. Mass: {mass}. Energy value: {energyValue} kcal";
        }


    }

    abstract class Confectionery : Product
    {
        public int sugarValue { get; protected set; }

        protected Confectionery() { }
        public Confectionery(string arg_name, int arg_amount, int arg_price, int arg_mass, int arg_energyValue, int arg_sugarValue) => (name, amount, price, mass, energyValue, sugarValue) = (arg_name, arg_amount, arg_price, arg_mass, arg_energyValue, sugarValue);

        public override string ToString()
        {
            return $"{amount} of {name} confectionery products, {price}$ each. Mass: {mass}. Energy value: {energyValue} kcal. Sugar value: {sugarValue} g.";
        }
    }

    sealed class Cake : Confectionery
    {
        public int area { get; private set; }
        public int height { get; private set; }



        public Cake(string arg_name, int arg_amount, int arg_price, int arg_mass, int arg_energyValue, int arg_sugarValue, int arg_area, int arg_height) => (name, amount, price, mass, energyValue, sugarValue, area, height) = (arg_name, arg_amount, arg_price, arg_mass, arg_energyValue, arg_sugarValue, arg_area, arg_height);

        public override string ToString()
        {
            return $"{amount} of {name} cakes, {price}$ each. Mass: {mass}. Energy value: {energyValue} kcal. Sugar value: {sugarValue} g.";
        }
    }

    sealed class Sweets : Confectionery
    {
        public int amountPerKg { get; private set; }
        public Sweets(string arg_name, int arg_amount, int arg_price, int arg_mass, int arg_energyValue, int arg_sugarValue, int arg_amountPerKg) => (name, amount, price, mass, energyValue, sugarValue, amountPerKg) = (arg_name, arg_amount, arg_price, arg_mass, arg_energyValue, arg_sugarValue, arg_amountPerKg);

        public override string ToString()
        {
            return $"{amount} of {name} sweets, {price}$ per kg. Mass: {mass}. Energy value: {energyValue} kcal. Sugar value: {sugarValue} g. Average amount/kg: {amountPerKg}";
        }
    }

}
