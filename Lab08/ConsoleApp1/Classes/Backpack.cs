using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Implements IBag
    public class Backpack<T> : IBag<T>
    {
        //Since items need to be unpacked by index, use a private List<T> for storage.
        private List<T> items = new List<T>();

        public IEnumerator<T> GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Pack(T item)
        {
            if (item != null)
            {
                items.Add(item);
            }
        }

        public T Unpack(int index)
        {
            T item = items[index];
            items.RemoveAt(index);

            return item;
        }


        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
