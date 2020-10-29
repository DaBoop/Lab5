using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{   
    [Serializable]
    class Gift : IEnumerable<Goods>
    {
        public Logger logger = new Logger();
        List<Goods> list = new List<Goods>();
        public int Count { get => list.Count; }
        public Goods this[int index]
        {
            get => list[index];
            set
            {
                if (value is Goods)
                {
                    list[index] = value;
                }
            }
        }

        public Gift() { }
        public void Sort()
        {
            GiftAction ex = new GiftAction($"Sorted"); // GiftAction
            logger.Add(ex);
            list.Sort();
        }
        public void Add(Goods obj) // Это не много, но это честная работа...
        {
            GiftAction ex = new GiftAction($"Added {obj.name}"); // GiftAction
            logger.Add(ex);
            list.Add(obj);
        }

        public void Add(Goods obj, int position)
        {
            GiftAction ex = new GiftAction("Add");
            logger.Add(ex);
            // Работает? Должно...

            List<Goods> listCopy = list;
            list = new List<Goods>();
            for (var i = 0; i < position; i++)
            {
                list.Add(listCopy[i]);
            }
            list[position] = obj;
            for (var i = position + 1; i < listCopy.Count+1; i++)
            {
                list.Add(listCopy[i]);
            }
        }
        public void Remove(Goods obj)
        {
            GiftAction ex = new GiftAction($"Removed {obj.name}"); // GiftAction
            logger.Add(ex);
            list.Remove(obj);
        }
        public void Remove()
        {
            GiftAction ex = new GiftAction($"Removed {list[list.Count-1].name}"); // GiftAction
            logger.Add(ex);
            list.RemoveAt(list.Count - 1);
        }

        public void Remove(int position)
        {
            GiftAction ex = new GiftAction($"Removed {list[position].name}"); // GiftAction
            logger.Add(ex);
            list.RemoveAt(position);
        }

        public void print()
        {
            if (list.Count == 0)
                throw new EmptyListException("List can not be printed because it's empty");
            string s = "";
            foreach(var obj in list)
            {
                s += obj.name;
            }
            Console.WriteLine(s);
        }

        public override string ToString()
        {
            string s = "";
            foreach (Goods obj in list)
            {
                s += obj.name + " ";
            }
            return s;
        }

        public IEnumerator<Goods> GetEnumerator()
        {
            return ((IEnumerable<Goods>)list).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)list).GetEnumerator();
        }

        
    }

   
}
