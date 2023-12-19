using System;
using System.Collections.Generic;


namespace lab2
{
    public class MyList<T>
    {
        private List<T> list = new List<T>();

        public void Display(string comment = "")
        {
            if (comment != "") { Console.WriteLine("\n" + comment + "\n"); }
               
            foreach (T item in list)
            {
                if (item is Person)
                {
                    Person p = item as Person;
                    Console.WriteLine(p.Name + " " +  p.age());
                }
            }
        }

        public void Add(T item)
        {
            list.Add(item);
        }

        public void Insert(int index, T item)
        {
            list.Insert(index, item);
        }

        public bool Remove(T item)
        {
            return list.Remove(item);
        }

        public void Clear()
        {
            list.Clear();
        }

        public void Sort(IComparer<T> comparer)
        {
            list.Sort(comparer);
        }
    }
}
