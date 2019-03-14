using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MyGenericCollection<T>
    {
        private List<T> list;
        private Random rand;

        public MyGenericCollection()
        {
            this.list = new List<T>();
            this.rand = new Random();
        }

        public void Add(T input)
        {
            if (rand.NextDouble() < 0.5)
            {
                list.Insert(0, input);
            }
            else
            {
                list.Add(input);
            }
        }

        public T Get(int index)
        {
            int randomInt = rand.Next(Math.Min(index, list.Count));
            return list[randomInt];
        }

        public bool IsEmpty()
        {
            return !list.Any();
        }

    }
}
