using System;
using System.Collections;

namespace HashtableNamespace
{
    class ExampleHashTable
    {
        static void Main()
        {
            //keyvaluepair and its non-generic collection
            Hashtable ht = new Hashtable();
            //ht.Add(object key, object value);
            ht.Add("Kushal", "9012384895");
            ht.Add(104, "Employee id with 104");
            ht.Add("salary", 10000);

            // ht["Kushal"]; 

            string phonenum = (string)ht["Kushal"];
            string description = (string)ht[104];
            int salary = (int)ht["salary"];

            foreach (DictionaryEntry entry in ht)
            {

                Console.WriteLine(entry.Key);
                Console.WriteLine(entry.Value);
                Console.WriteLine($"Key - {entry.Key} , value - {entry.Value}");


                //check available are not
                if (ht.ContainsKey(104))
                {
                    Console.WriteLine(ht[104] + "Found");

                }

                //updating the value
                ht[104] = "Employee id is 104 is availble in chennai";

                //remove 
                ht.Remove("salary");

                //add
                ht.Add("IsActive", true);
            }
        }
    }
}
