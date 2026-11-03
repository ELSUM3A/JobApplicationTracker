using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPractice.Collections
{
    internal class PracticeStack
    {
        public static void Run()
        {
            // Stack (Last In First Out )
            Stack<int> Number = new Stack<int>();

            Number.Push(1); //add in bottom
            Number.Push(2);
            Number.Push(3);
            Number.Push(4); // top

            foreach (int item in Number)
                Console.WriteLine(item);

            Console.WriteLine("//////////");
            Number.Pop(); // return last number added and delete it

            foreach (int item in Number)
                Console.WriteLine(item);

            Console.WriteLine("//////////");

            Console.WriteLine(Number.Peek()); //return last number only

            Console.WriteLine("///end Stack Practice///");
        }
    }
}
