using System;

namespace Lab5
{
    static class Printer
    {
        public static void IAmPrinting(Goods obj)
        {
            Console.WriteLine(obj.GetType() + " " + obj);
        }   
    }

}