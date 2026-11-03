using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPractice.Collections
{
    internal class PracticeQueue
    {
        public static void Run()
        {
            // Queue (First In First Out )
            Queue<int> Numqueue = new Queue<int>();

            Numqueue.Enqueue(1);// add 
            Numqueue.Enqueue(2);
            Numqueue.Enqueue(3);
            Numqueue.Enqueue(4);

            foreach (int i in Numqueue)
                Console.WriteLine(i);

            Console.WriteLine("//////////");
            int delfirst = Numqueue.Dequeue();// return and delete

            Console.WriteLine(delfirst);

            Console.WriteLine("//////////");
            int retfirst = Numqueue.Peek();// return

            Console.WriteLine(retfirst);

            Console.WriteLine("///end Queue Practice///");

        }
    }
}
