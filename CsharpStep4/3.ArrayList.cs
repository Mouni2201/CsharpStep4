using System;
using System.Collections;


namespace ArrayListExample
{
    class ListofArray
    {
        static void Main()
        {
            ArrayList arrayList = new ArrayList();
            //here arraylist is predefinedclass in csharp and it can create multiple values

            //1.Non type safety: add any type of data type
            arrayList.Add(100);
            arrayList.Add(80);
            arrayList.Add("Hrello");
            arrayList.Add(false);

            //2.array list Dynamic size
            arrayList.Add(100);         //0     object(boxing)
            arrayList.Add(80);          //1     object
            arrayList.Add("Hrello");    //2     object
            arrayList.Add(false);       //3     object
            arrayList.Add(20);          //4     object

            //object to expected datatype(unboxing)

            //3.boxing or unboxing(required here)

            //if we don't use conversion that it is boxing
            int first = (int)arrayList[0];  //unboxing
            string second = (string)arrayList[1];

            //object obj =10;
            //object obj1 = "afad";  //we can change like this

            //4.Multiple datattypes are poosible
            arrayList.Add(100);
            arrayList.Add(80);
            arrayList.Add("Hrello");
            arrayList.Add(false);

            //5.Lopping
            foreach(object x in arrayList)
            {
                //int third = int(x) we can convert the datatype here
                Console.WriteLine(x);
            }

            //var x=10;
            //x = "hello";   //can't write Like this

            //object obj = 10;
            //obj = "hello";  we can write like this
            //obj.   ->can't add method

            //performance
            ArrayList arrayList1000times = new ArrayList();
            for (int i = 0; i < 1000; i++) 
            {
                arrayList1000times.Add(i); //objec only create in i
                //infuture in unboxing wants to print and need chanes boxing to unboxing it causes issues
            }




        }
    }
}

