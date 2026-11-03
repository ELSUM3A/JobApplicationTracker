using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPractice.Collections
{
    internal class PracticeHashset
    {
        public static void Run()
        {
            // Hashset
            HashSet<string> setOfNames = new HashSet<string>();

            setOfNames.Add("Ahmed");
            setOfNames.Add("Mohamed");
            setOfNames.Add("Sara");
            setOfNames.Add("Ahmed"); // hashset don't print same key
            setOfNames.Add("sara");  // is Case Sensitive

            foreach (string name in setOfNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("///end Hashset Practice///");

        }
    }
}
