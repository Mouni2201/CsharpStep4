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

            //if we don't use conversion 
            int first = (int)arrayList[0];  //unboxing


        }
    }
}

