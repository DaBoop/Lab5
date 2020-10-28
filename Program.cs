using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            var cake = new Cake("Tiramisu", 5, 100, 1000, 1000, 20, 100, 5);
            var sweets = new Sweets("Toffee", 100, 30, 1500, 500, 10, 50);
            var flower = new Flower("Tulip", 10, 30, "purple");
            var watch = new Watch("Datejust", 12, 5495, "Rolex", 1); 

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
        }
    }
}
