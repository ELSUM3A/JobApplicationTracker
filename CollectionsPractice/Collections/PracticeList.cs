using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPractice.Collections
{
    internal class PracticeList
    {
        public static void Run()
        {
            // practice in list<T> 

            List<int> ints = new List<int>();

            Console.WriteLine("-Add item-");// Add item in list
            ints.Add(17);
            ints.Add(23);
            ints.Add(13);
            ints.Add(40);
            ints.Add(9);
            ints.Add(11);

            foreach (int item in ints)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-Remove item-");// remove item from list 

            ints.Remove(17);//by value
            ints.RemoveAt(1);//by index

            foreach (int item in ints)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-search for item-");//search in list 

            bool search = ints.Contains(40);

            Console.WriteLine(search);

            Console.WriteLine("-update item-");//update in list 

            ints[0] = 12;
            ints[1] = 3;

            foreach (int item in ints)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("///end List Practice///");
        }
    }
}
