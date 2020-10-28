using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab5
{
    static class GiftController
    {
        public static int GetSumPrice(Gift gift)
        {
            int sum = 0;
            foreach (Goods obj in gift)
                {
                     sum += obj.price * obj.amount;
                }
            return sum;
        }

        public static int GetMinMass(Gift gift)
        {
            int min = gift[0].mass*gift[0].amount;
            int fullMass;
            foreach (Goods obj in gift)
            {
                fullMass = obj.mass * obj.amount;
                if (fullMass < min)
                {
                    min = fullMass;
                }
            }
            return min;
        }

        public static void SortName(Gift gift)
        {
            gift.Sort();
        }

        public static void ToFile (Gift gift, string fileName)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, gift);
            stream.Close();
        }

        public static void FromFile(out Gift gift, string fileName)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            gift = (Gift)formatter.Deserialize(stream);
        }

       /* public static void ToFile(Gift gift, string fileName) => File.WriteAllText(fileName, gift.ToString());
        public static void FromFile(out Gift gift, string fileName)
        {
             gift = new Gift();

            foreach (var line in File.ReadAllLines(fileName)) 
            {
                gift.Add(Gift.ParseUnit(line));
            }

        }
       */
    }
}
