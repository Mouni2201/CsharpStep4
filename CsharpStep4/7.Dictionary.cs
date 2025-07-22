using System;
using System.Collections.Generic;
using System.Collections;
using System.Net.Http.Headers;

namespace DictionaryNamespace
{
    //Dictionary<Tkey, TValue> dict = new Dictionary<Tkey, TValue>();

    class ExampleDictionary
    {
        static void Main()
        {
            Dictionary<int, string> tableContent = new Dictionary<int, string>();
            //tableContent.Add(int Key, string value);
            tableContent.Add(1, "Chapter1");
            tableContent.Add(7, "Chapter2");
            tableContent.Add(24, "Chapter3");

            //output
            //key is important to get the value
            //tablecontent[1]

            string nameofChapeter = tableContent[1];
            string nameofChapeter1 = tableContent[7];
            string nameofChapeter2 = tableContent[24];

            //lambda expressions: =>

            foreach(KeyValuePair<int, string> kvp in tableContent)
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine(kvp.Value);

            }

            //if you want to find 7 key is availble or not
            if (tableContent.ContainsKey(7))
            {
                Console.WriteLine("yes 7 is availble");
            }

            //to remove key
            tableContent.Remove(7);

            //to add new value

            tableContent.Add(37, "Chapter4");

            //want to update value
            //tableContent(7, "chapeter2")
            if (tableContent.ContainsKey(7))
            {
                tableContent[7] = "Chapter1.1";
            }

        }
    }
}