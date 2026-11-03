using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPractice.Collections
{
    internal class PracticeDictionary
    {
        public static void Run()
        {
            // Dictionary 
            Dictionary<int, string> NumEmploye = new Dictionary<int, string>();
            NumEmploye.Add(1, "Ahmed");
            NumEmploye.Add(2, "Mohamed");
            NumEmploye.Add(3, "Ali");
            NumEmploye.Add(4, "Mostafa");
            NumEmploye.Add(5, "Ali");

            Console.WriteLine(NumEmploye[3]);

            Console.WriteLine("///end Dictionary Practice///");

        }
    }
}
