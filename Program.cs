﻿using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            var cake = new Cake("Tiramisu", 5, 5, 1000, 1000, 20, 100, 5);
            var sweets = new Sweets("Toffee", 150, 3, 1500, 500, 10, 50);
            var flower = new Flower("Tulip", 1, 30, "purple", 5);
            var watch = new Watch("Datejust", 12, 5495, "Rolex", 1, 200); 

            Console.WriteLine(cake);
            cake.Add(10);
            Console.WriteLine(cake);
            Console.WriteLine(watch); 
            Console.WriteLine();

            watch.Method1(); // Goods
            watch.Method2();

            Console.WriteLine();

            cake.Method1(); // Product
            cake.Method2();



            Console.WriteLine();
           
            Goods goods = cake as Goods;
            goods.Method1();
            goods.Method2();

            Console.WriteLine();

            IGoods igoods = cake as IGoods;
            igoods.Method1();
            // виртуальгный метод низя

            Console.WriteLine();

            object obj = (object)flower;

            Console.WriteLine("flower is " + (obj is Flower ? "Flower" : "not Flower"));
            Console.WriteLine("flower is " + (obj is Goods ? "Goods" : "not Goods"));
            Console.WriteLine("flower is " + (obj is Product ? "Product" : "not Product"));
            Console.WriteLine("flower is " + (obj is IGoods ? "IGoods" : "not IGoods"));

            Console.WriteLine();


            Console.WriteLine("flower is " + ((obj as Flower) != null ? "Flower" : "not Flower"));
            Console.WriteLine("flower is " + ((obj as Goods) != null ? "Goods" : "not Goods"));
            Console.WriteLine("flower is " + ((obj as Product) != null ? "Product" : "not Product"));
            Console.WriteLine("flower is " + (obj is IGoods ? "IGoods" : "not IGoods"));

            Console.WriteLine();

            object[] arr = { cake, sweets, flower, watch};
            foreach (object o in arr)
            {
                Printer.IAmPrinting(o as Goods);
            }

            Console.WriteLine("\n========================\n");
            // И тут внезапно 6 лаба

            Gift gift = new Gift();
            gift.Add(cake);
            gift.Add(flower);
            gift.Add(watch);
            gift.Add(sweets);

            Console.WriteLine(gift);

            Console.WriteLine(GiftController.GetMinMass(gift));
            Console.WriteLine(GiftController.GetSumPrice(gift));
            GiftController.SortName(gift);
            Console.WriteLine(gift);

            var gift2 = new Gift();
            GiftController.ToFile(gift, "e:\\ООП\\Лабы\\Lab5\\Gift.txt");
            GiftController.FromFile(out gift2, "e:\\ООП\\Лабы\\Lab5\\Gift.txt");
            Console.WriteLine(gift2);

            GiftController.ToJson(gift, "e:\\ООП\\Лабы\\Lab5\\Gift.json");
            //GiftController.FromJson(out gift2, "e:\\ООП\\Лабы\\Lab5\\Gift.json");


            Console.WriteLine("\n========================\n");
            // И тут внезапно 7 лаба

            // flower amount = 1;

            try
            {
                flower.Remove(2);
            }
            catch(NegativeAmount)
            {
                Console.WriteLine("Not enough flowers");
            }

            try
            {
                flower.Add(-2);
            }
            catch(ArgumentException)
            {
                Console.WriteLine("Wrong argument");
            }

            try 
            {
                int b = 0;
                int a = 10 / b;
            } 
            catch(DivideByZeroException)
            {
                Console.WriteLine("Division by zero");
            }
        }
    }
}
