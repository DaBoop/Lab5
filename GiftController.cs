using System;
using System.Collections.Generic;
using System.Text;

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
        /*public static void SortName(Gift gift)
       
        {
            Goods temp;
            for (int i = 0; i < gift.Count-2; i++)
            {
                for (int j = 0; j < gift.Count-2-i; j++)
                { 
                    if (String.Compare(gift[i].name, gift[i + 1].name, false) == 1)
                    {
                        temp = gift[i];
                        gift[i] = gift[i + 1];
                        gift[i + 1] = temp;
                    }
                }
            }
        }*/

    }
}
