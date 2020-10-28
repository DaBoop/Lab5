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
            var watch = new Watch("Datejust", 12, 5495, "Rolex", "mechanical");

            Console.WriteLine(cake);
            cake.Add(10);
            Console.WriteLine(cake);
            Console.WriteLine();

            watch.Method1(); // Goods
            watch.Method2();

            cake.Method1(); // Product
            cake.Method2();

            object obj = (object)flower;

            Console.WriteLine();

            Console.WriteLine("flower is " +  (obj is Flower ? "Flower" : "not Flower"));
            Console.WriteLine("flower is " +  (obj is Goods ? "Goods" : "not Goods"));
            Console.WriteLine("flower is " + (obj is Product ? "Product" : "not Product"));
            Console.WriteLine("flower is " + (obj is IGoods ? "IGoods" : "not IGoods"));

            Console.WriteLine();

            Console.WriteLine("flower is " + ((obj as Flower) != null ? "Flower" : "not Flower"));
            Console.WriteLine("flower is " + ((obj as Goods) != null ? "Goods" : "not Goods"));
            Console.WriteLine("flower is " + ((obj as Product) != null ? "Product" : "not Product"));
            Console.WriteLine("flower is " + (obj is IGoods ? "IGoods" : "not IGoods"));

        }
    }
}
