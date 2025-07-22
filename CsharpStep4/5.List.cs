using System;
using System.Collections.Generic;
using System.Collections;

namespace ListNamespaces
{
    //<syntax>: list<T> tlist = new List<T>();

    class ExampleList
    {
        static void Main()
        {
            //TypeSafety
            List<int> numbersList = new List<int>();
            numbersList.Add(10);
            numbersList.Add(20);
            numbersList.Add(30);
            numbersList.Add(40);
            //numbersList.Add(false) //can't  change datatype here

            //2.Dynamic size
            numbersList.Add(10);
            numbersList.Add(20);
            numbersList.Add(30);
            numbersList.Add(40);
            //numbersList values: 10, 20, 30, 40, 10, 20 ,30, 40


            // Wecan write like
            //List<int> numbersList1 = new List<int>();
            //numbersList1.Add(10);
            //numbersList1.Add(20);
            //numbersList1.Add(30);
            //numbersList1.Add(40);

            //3.No Boxing

            int Third = numbersList[0];   //no need to convert here anything.

            //4. Multiple Datatypes are not possible
            numbersList.Add(10);
            numbersList.Add(20);
            numbersList.Add(30);
            numbersList.Add(40);
            //numbersList.Add("Hello"); multiple datatypes not possibel


            //5.Looping (here no need to convert unboxing)
            foreach (int i in numbersList)
            {
                Console.WriteLine(i);
            }

            //performance
            List<int> List1000Times = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                List1000Times.Add(i);   //here int only there no need to chane and no boxing here
            }
        }
    }
}
